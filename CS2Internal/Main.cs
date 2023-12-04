using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CS2Internal.Game;
using CS2Internal.ImGuiInterface;
using CS2Internal.Utility;

namespace CS2Internal;

public abstract partial class Main
{
    [UnmanagedCallersOnly(EntryPoint = "DllMain", CallConvs = new[] { typeof(CallConvStdcall) })]
    private static bool DllMain(IntPtr hModule, uint ulReasonForCall, IntPtr lpReserved)
    {
        switch (ulReasonForCall)
        {
            case 1:
                Module = hModule;
                WinApi.AllocConsole();
                Stopwatch = new Stopwatch();
                Stopwatch.Start();
                ImGuiX.Renderer.Init(Renderer);
                Task.Run(MainThread);
                break;
        }

        return true;
    }

    private static void Renderer()
    {
        var deltaTime = Stopwatch!.Elapsed.TotalSeconds;
        FrameCounter++;
        Stopwatch.Restart();

        TimeCounter += deltaTime;
        if (TimeCounter >= RefreshTime)
        {
            Fps = FrameCounter / TimeCounter;
            FrameCounter = 0;
            TimeCounter -= RefreshTime;
        }

        if (ShowMenu) ImGuiUi.RenderMenu();

        ImGuiUi.RenderOverlay();


        // if (Config.Aimbot)
    }

    private static Vector2 _oldPunch;

    private static unsafe void NoRecoil()
    {
        while (true)
        {
            var punchCache = LocalPlayerPawn->AimPunchCache;
            var tempAngle = new Vector3(0, 0, 0);
            var punchAngle = *(Vector3*)(punchCache.Data + (punchCache.Count - 1) * (ulong)sizeof(Vector3));
            if (punchCache.Count is > 0 and < 0xFFFF)
            {
                var viewAngles = Cs2.GetViewAngle();
                tempAngle.X = viewAngles.X + _oldPunch.X - punchAngle.X * 2;
                tempAngle.Y = viewAngles.Y + _oldPunch.Y - punchAngle.Y * 2;
                tempAngle = Vector3.Normalize(tempAngle);

                _oldPunch.X = punchAngle.X * 2;
                _oldPunch.Y = punchAngle.Y * 2;

                Cs2.SetViewAngle(tempAngle);
            }
            else
            {
                _oldPunch.X = 0;
                _oldPunch.Y = 0;
            }

            Thread.Sleep(2);
        }
    }


    private static void MainThread()
    {
        // Task.Run(NoRecoil);
        while (IsRunning)
        {
            Cs2.UpdateEntityList();

            if (WinApi.GetAsyncKeyState(0x2D) != 0)
            {
                ShowMenu = !ShowMenu;
                Thread.Sleep(200);
            }

            Thread.Sleep(30);
        }
    }
}