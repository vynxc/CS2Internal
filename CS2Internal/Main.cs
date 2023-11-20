using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CS2Internal.Game;
using CS2Internal.ImGuiX;
using CS2Internal.Utility;
using ImGuiNET;
using ImGui = ImGuiNET.ImGui;

namespace CS2Internal;

public abstract unsafe class Main
{
    private static readonly IntPtr ModuleBaseClient = WinApi.GetModuleHandle("client.dll");
    private static readonly IntPtr ModuleBaseEngine = WinApi.GetModuleHandle("engine2.dll");
    private static Entity* _localPlayerPawn;
    private static readonly bool IsRunning = true;
    private static List<Entity> _entityList = new();

    [UnmanagedCallersOnly(EntryPoint = "DllMain", CallConvs = new[] { typeof(CallConvStdcall) })]
    private static bool DllMain(IntPtr hModule, uint ulReasonForCall, IntPtr lpReserved)
    {
        switch (ulReasonForCall)
        {
            case 1:

                WinApi.AllocConsole();
                Renderer.Init(UserInterface);
                Task.Run(MainThread);
                break;
        }

        return true;
    }
    
    private static void UserInterface()
    {
        ImGui.Begin("Overlay",
            ImGuiWindowFlags.NoTitleBar | ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoMove |
            ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoInputs | ImGuiWindowFlags.NoBackground);
        var io = ImGui.GetIO();
        ImGui.SetWindowPos(new Vector2(0, 0), ImGuiCond.Always);
        ImGui.SetWindowSize(new Vector2(io.DisplaySize.X, io.DisplaySize.Y), ImGuiCond.Always);

        var matrix = new ReadOnlySpan<float>((float*)(ModuleBaseClient + client_dll.dwViewMatrix), 16);
        
        foreach (var entity in _entityList)
        {
            var engineWidth = 1920;
            var engineHeight = 1080;

            var origin = entity.SceneNode->VecOriginAbsolute;
            var headPos = *(Vector3*)(entity.SceneNode->ModalState.BoneArray + 6 * 32);
            if (!WorldToScreen(headPos, matrix, engineWidth, engineHeight, out var screenHead) ||
                !WorldToScreen(origin, matrix, engineWidth, engineHeight, out var screenBase))
                continue;


            var height = Math.Abs(screenHead.Y - screenBase.Y);
            var width = height / 2;
            var topLeft = screenHead with { X = screenHead.X - width / 2 };
            var bottomRight = screenBase with { X = screenBase.X + width / 2 };

            ImGui.GetWindowDrawList().AddRectFilled(topLeft, bottomRight,
                ImGui.ColorConvertFloat4ToU32(new Vector4(0, 0, 0, 0.18f)));

            ImGui.GetWindowDrawList().AddRect(topLeft, bottomRight,
                ImGui.ColorConvertFloat4ToU32(new Vector4(0, 0, 0, 1)), 5, ImDrawCornerFlags.All, 2);

            ImGui.GetWindowDrawList()
                .AddRect(topLeft, bottomRight, ImGui.ColorConvertFloat4ToU32(new Vector4(0, 0, 1, 1)), 5,
                    ImDrawCornerFlags.All, 1);

            //ImGui.GetWindowDrawList().AddRect(topLeft, bottomRight, ImGui.GetColorU32(ImGuiCol.ButtonHovered), 5);
        }

        ImGui.End();
    }

    private static void UpdateEntityList(IntPtr localPlayerPtr, ICollection<Entity> entityList)
    {
        entityList.Clear();
        
        var tempEntityAddress = *(IntPtr*)(ModuleBaseClient + client_dll.dwEntityList);
        if (tempEntityAddress == IntPtr.Zero) return;
        for (var i = 0; i < 32; i++)
        {
            var listEntry = *(IntPtr*)(tempEntityAddress + (((8 * (i & 0x7FFF)) >> 9) + 16));

            if (listEntry == IntPtr.Zero) continue;

            var player = *(IntPtr*)(listEntry + 120 * (i & 0x1FF));

            if (player == IntPtr.Zero) continue;

            var playerPawn = *(IntPtr*)(player + CCSPlayerController.m_hPlayerPawn);

            if (playerPawn == IntPtr.Zero) continue;

            var listEntry2 = *(IntPtr*)(tempEntityAddress + 0x8 * ((playerPawn & 0x7FFF) >> 9) + 16);

            if (listEntry2 == IntPtr.Zero) continue;

            var pCsPlayerPawn = *(IntPtr*)(listEntry2 + 120 * (playerPawn & 0x1FF));

            if (pCsPlayerPawn == IntPtr.Zero) continue;

            var playerEntity = *(Entity*)pCsPlayerPawn;

            //dont work cause its not supposed to 
            if (localPlayerPtr == pCsPlayerPawn)
                continue;

            if (playerEntity.Health is > 0 and <= 100)
                entityList.Add(playerEntity);
        }
    }


    private static void MainThread()
    {
        while (IsRunning)
        {
            try
            {
                if (ModuleBaseClient == IntPtr.Zero)
                    continue;

                var localPlayer = *(IntPtr*)(ModuleBaseClient + client_dll.dwLocalPlayerPawn);

                if (localPlayer == IntPtr.Zero)
                    continue;
                var viewMatrixPtr = (float*)(ModuleBaseClient + client_dll.dwViewMatrix);
                if (viewMatrixPtr == null) continue;
                _localPlayerPawn = *(Entity**)localPlayer;
                UpdateEntityList(localPlayer, _entityList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Thread.Sleep(10);
        }
    }

    private static bool WorldToScreen(Vector3 pos, ReadOnlySpan<float> m, int windowWidth, int windowHeight,
        out Vector2 screen)
    {
        screen = default;

        var vx = new Vector4(pos.X);
        var v1 = new Vector4(m[0], m[4], m[8], m[12]);
        var vy = new Vector4(pos.Y);
        var v2 = new Vector4(m[1], m[5], m[9], m[13]);
        var vz = new Vector4(pos.Z);
        var v3 = new Vector4(m[2], m[6], m[10], m[14]);
        var v4 = new Vector4(m[3], m[7], m[11], m[15]);

        var clipCoords = vx * v1 + vy * v2 + vz * v3 + v4;

        if (clipCoords.W < 0.1f)
            return false;

        var v2Ndc = new Vector2(clipCoords.X, clipCoords.Y);
        v2Ndc /= clipCoords.W;

        var v2Wnd = new Vector2(windowWidth, windowHeight);
        var v22 = new Vector2(2);
        screen = v2Wnd / v22 * v2Ndc;
        screen *= new Vector2(1, -1);
        screen += v2Ndc + v2Wnd / v22;
        return true;
    }
}