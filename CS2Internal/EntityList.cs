using System.Collections;
using System.Collections.Concurrent;
using CS2Internal.Game;

namespace CS2Internal;

public class EntityList
{
    private readonly ConcurrentBag<Entity> _entities = new();

    public unsafe void UpdateEntityList(ref Entity* localPlayerPawn)
    {
        if (Main.ModuleBaseClient == IntPtr.Zero)
            return;

        var localPlayer = *(IntPtr*)(Main.ModuleBaseClient + client_dll.dwLocalPlayerPawn);

        if (localPlayer != IntPtr.Zero)
            localPlayerPawn = *(Entity**)localPlayer;

        _entities.Clear();

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

            if (playerEntity.Health is > 0 and <= 100)
                _entities.Add(playerEntity);
        }
    }

    public IEnumerator<Entity> GetEnumerator()
    {
        return _entities.GetEnumerator();
    }
}