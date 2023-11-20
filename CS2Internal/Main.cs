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
    public static readonly IntPtr ModuleBaseClient = WinApi.GetModuleHandle("client.dll");
    private static readonly IntPtr ModuleBaseEngine = WinApi.GetModuleHandle("engine2.dll");
    public static Entity* _localPlayerPawn;
    private static readonly bool IsRunning = true;

    [UnmanagedCallersOnly(EntryPoint = "DllMain", CallConvs = new[] { typeof(CallConvStdcall) })]
    private static bool DllMain(IntPtr hModule, uint ulReasonForCall, IntPtr lpReserved)
    {
        switch (ulReasonForCall)
        {
            case 1:
                var entityList = new EntityList();
                
                WinApi.AllocConsole();
                Renderer.Init(() => UserInterface(entityList));
                new TaskFactory(TaskCreationOptions.LongRunning, 0)
                    .StartNew(() => MainThread(entityList));
                break;
        }

        return true;
    }

    private static void UserInterface(EntityList entityList)
    {
        ImGui.Begin("Overlay",
            ImGuiWindowFlags.NoTitleBar | ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoMove |
            ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoInputs | ImGuiWindowFlags.NoBackground);
        var io = ImGui.GetIO();
        ImGui.SetWindowPos(new Vector2(0, 0), ImGuiCond.Always);
        ImGui.SetWindowSize(new Vector2(io.DisplaySize.X, io.DisplaySize.Y), ImGuiCond.Always);

        var viewMatrixPtr = (float*)(ModuleBaseClient + client_dll.dwViewMatrix);
        if (viewMatrixPtr == null) return;
        var matrix = new ReadOnlySpan<float>(viewMatrixPtr, 16);
        // var tempEntityList = new List<Entity>(EntityList); //copy to new list to avoid concurrency issues
        // sike use concurrent collection to avoid concurrency issues
        // https://learn.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentbag-1.getenumerator?view=net-7.0#remarks
        foreach (var entity in entityList)
        {
            var engineWidth = 1920;
            var engineHeight = 1080;

            var origin = entity.SceneNode->VecOriginAbsolute;
            var headPos = *(Vector3*)(entity.SceneNode->ModalState.BoneArray + 6 * 32);
            if (!WorldToScreen(headPos, matrix, engineWidth, engineHeight, out var screenHead) ||
                !WorldToScreen(origin, matrix, engineWidth, engineHeight, out var screenBase))
                continue;

            var height = Convert.ToSingle(Math.Sqrt(Math.Pow(screenHead.X - screenBase.X, 2) +
                                                    Math.Pow(screenHead.Y - screenBase.Y, 2)));
            height *= 1.2f;
            var width = height / 2;

            var topLeft = new Vector2(screenBase.X - width / 2, screenBase.Y - height);
            var bottomRight = screenBase with { X = screenBase.X + width / 2 };

            ImGui.GetWindowDrawList().AddRectFilled(topLeft, bottomRight,
                ImGui.ColorConvertFloat4ToU32(new Vector4(0, 0, 0, 0.18f)));

            ImGui.GetWindowDrawList().AddRect(topLeft, bottomRight,
                ImGui.ColorConvertFloat4ToU32(new Vector4(0, 0, 0, 1)), 5, ImDrawCornerFlags.All, 2);

            ImGui.GetWindowDrawList()
                .AddRect(topLeft, bottomRight, ImGui.ColorConvertFloat4ToU32(new Vector4(0, 0, 1, 1)), 5,
                    ImDrawCornerFlags.All, 1);

            foreach (var connection in Boners.BoneConnections)
            {
                var bone1 = Boners.BoneOffsetMap[connection.Bone1];
                var bone2 = Boners.BoneOffsetMap[connection.Bone2];

                var bone1Pos = *(Vector3*)(entity.SceneNode->ModalState.BoneArray + bone1 * 32);
                var bone2Pos = *(Vector3*)(entity.SceneNode->ModalState.BoneArray + bone2 * 32);

                if (!WorldToScreen(bone1Pos, matrix, engineWidth, engineHeight, out var screenBone1) ||
                    !WorldToScreen(bone2Pos, matrix, engineWidth, engineHeight, out var screenBone2))
                    continue;

                ImGui.GetWindowDrawList().AddLine(screenBone1, screenBone2,
                    ImGui.ColorConvertFloat4ToU32(new Vector4(0, 0, 1, 1)), 2);
            }


            //ImGui.GetWindowDrawList().AddRect(topLeft, bottomRight, ImGui.GetColorU32(ImGuiCol.ButtonHovered), 5);
        }

        ImGui.End();
    }

    private static void MainThread(EntityList entityList)
    {
        while (IsRunning)
        {
            entityList.UpdateEntityList();
            Thread.Sleep(100);
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