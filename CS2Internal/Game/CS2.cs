using System.Numerics;
using System.Runtime.InteropServices;
using CS2Internal.Utility;

namespace CS2Internal.Game;

public static class Cs2
{
    public static unsafe void UpdateEntityList()
    {
        try
        {
            if (Main.ModuleBaseClient == IntPtr.Zero)
                return;

            var localPlayer = *(IntPtr*)(Main.ModuleBaseClient + client_dll.dwLocalPlayerPawn);

            if (localPlayer != IntPtr.Zero)
            {
                Main.LocalPlayerPawn = (EntityPawn*)localPlayer;
                Main.LocalPlayerPawnPtr = localPlayer;
            }


            lock (Main.EntityListLock)
            {
                Main.EntityList.Clear();
            }

            var tempEntityAddress = *(IntPtr*)(Main.ModuleBaseClient + client_dll.dwEntityList);
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
                var playerEntity = *(EntityPawn*)pCsPlayerPawn;
                if (localPlayer == pCsPlayerPawn)
                    continue;
                if (playerEntity.Health is <= 0 or > 100) continue;

                lock (Main.EntityListLock)
                {
                    Main.EntityList.Add(new Entity
                    {
                        EntityPawn = playerEntity,
                        EntityController = *(EntityController*)player
                    });
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public static Vector3 GetViewAngle()
    {
        var viewAnglesPtr = new IntPtr(Main.ModuleBaseClient + client_dll.dwViewAngles);

        return Marshal.PtrToStructure<Vector3>(viewAnglesPtr);
    }

    private static void Shoot()
    {
        WinApi.Mouse_Event(WinApi.MOUSEEVENTF_ABSOLUTE | WinApi.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        Thread.Sleep(10);
        WinApi.Mouse_Event(WinApi.MOUSEEVENTF_ABSOLUTE | WinApi.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
    }

    public static void SetViewAngle(Vector3 angle)
    {
        try
        {
            var viewAnglesPtr = new IntPtr(Main.ModuleBaseClient + client_dll.dwViewAngles);

            Marshal.StructureToPtr(angle, viewAnglesPtr, false);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    private const float Smoothing = 0.1f;
    private static Vector2 _oldPunch;


    public static unsafe void AimAt(Vector3 target, bool autoShoot = false)
    {
        try
        {
            var origin = Main.LocalPlayerPawn->SceneNode->VecOriginAbsolute;
            var viewOffset = Main.LocalPlayerPawn->ViewOffset;
            var myPos = origin + viewOffset;
            var deltaVec = target - myPos;
            var deltaVecLength = Math.Sqrt(deltaVec.X * deltaVec.X + deltaVec.Y * deltaVec.Y + deltaVec.Z * deltaVec.Z);
            var pitch = (float)-Math.Asin(deltaVec.Z / deltaVecLength) * (180 / (float)Math.PI);
            var yaw = (float)Math.Atan2(deltaVec.Y, deltaVec.X) * (180 / (float)Math.PI);
            if (!(pitch >= -89) || !(pitch <= 89) || !(yaw >= -180) || !(yaw <= 180)) return;
            var currentAngles = new Vector3(
                pitch,
                yaw,
                0);
            SetViewAngle(currentAngles);
            if (!autoShoot) return;
            var punchCache = Main.LocalPlayerPawn->AimPunchCache;
            var tempAngle = new Vector3(0, 0, 0);
            var punchAngle = *(Vector3*)(punchCache.Data + (punchCache.Count - 1) * (ulong)sizeof(Vector3));
            if (punchCache.Count is > 0 and < 0xFFFF)
            {
                var viewAngles = GetViewAngle();
                tempAngle.X = viewAngles.X + _oldPunch.X - punchAngle.X * 2;
                tempAngle.Y = viewAngles.Y + _oldPunch.Y - punchAngle.Y * 2;
                while (tempAngle.Y > 180) tempAngle.Y -= 360;

                while (tempAngle.Y < -180) tempAngle.Y += 360;

                if (tempAngle.X > 89.0f) tempAngle.X = 89.0f;

                if (tempAngle.X < -89.0f) tempAngle.X = -89.0f;

                _oldPunch.X = punchAngle.X * 2;
                _oldPunch.Y = punchAngle.Y * 2;
                SetViewAngle(tempAngle);
            }
            else
            {
                _oldPunch.X = 0;
                _oldPunch.Y = 0;
            }

            Shoot();
        }
        catch (Exception e)
        {
            Console.WriteLine("Caught " + e.Message);
            Console.WriteLine("at " + e.StackTrace);
        }
    }


    public static bool WorldToScreen(Vector3 pos, ReadOnlySpan<float> m, int windowWidth, int windowHeight,
        out Vector2 screen, bool behindCheck = true)
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

        if (behindCheck && clipCoords.W < 0.1f)
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