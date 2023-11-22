using System.Numerics;

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

            if (localPlayer != IntPtr.Zero) Main.LocalPlayerPawn = *(Entity**)localPlayer;


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
                var playerEntity = *(Entity*)pCsPlayerPawn;

                if (localPlayer == pCsPlayerPawn)
                    continue;
                if (playerEntity.Health is <= 0 or > 100) continue;

                lock (Main.EntityListLock)
                {
                    Main.EntityList.Add(playerEntity);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public static bool WorldToScreen(Vector3 pos, ReadOnlySpan<float> m, int windowWidth, int windowHeight,
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