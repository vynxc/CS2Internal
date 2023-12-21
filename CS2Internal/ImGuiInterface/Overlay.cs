using System.ComponentModel;
using System.Numerics;
using System.Runtime.InteropServices;
using CS2Internal.Game;
using CS2Internal.Utility;
using ImGuiNET;

namespace CS2Internal.ImGuiInterface;

public partial class ImGuiUi
{
    public static unsafe void RenderOverlay()
    {
        try
        {
            ImGui.Begin("Overlay",
                ImGuiWindowFlags.NoTitleBar | ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoMove |
                ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoInputs | ImGuiWindowFlags.NoBackground);

            if (Config.Fps)
                ImGui.GetWindowDrawList().AddText(ImGui.GetFont(), 25, new Vector2(15, 15),
                    ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1)), $"FPS: {Main.Fps}");

            var io = ImGui.GetIO();
            ImGui.SetWindowPos(new Vector2(0, 0), ImGuiCond.Always);
            ImGui.SetWindowSize(new Vector2(io.DisplaySize.X, io.DisplaySize.Y), ImGuiCond.Always);

            var viewMatrixPtr = (float*)(Main.ModuleBaseClient + client_dll.dwViewMatrix);
            if (viewMatrixPtr == null) return;
            var matrix = new ReadOnlySpan<float>(viewMatrixPtr, 16);
            List<Entity> tempEntityList;
            lock (Main.EntityListLock)
            {
                tempEntityList = new List<Entity>(Main.EntityList);
            }

            float maxAimDistance = 100000;
            Vector3 aimPos = new();
            foreach (var entity in tempEntityList)
            {
                if (entity.EntityPawn.SceneNode->Dormant != 0)
                    continue;

                var engineWidth = 1920;
                var engineHeight = 1080;

                var origin = entity.EntityPawn.SceneNode->VecOriginAbsolute;
                var headPos = *(Vector3*)(entity.EntityPawn.SceneNode->ModalState.BoneArray + 6 * 32);
                var boxColor = Config.BoxColor;
                var spotted = false;
                if (Main.LocalPlayerPawn->Health != 0)
                    if ((entity.EntityPawn.EntitySpottedState.SpottedByMask &
                         (1 << (int)Main.LocalPlayerPawnPtr)) != 0 ||
                        (Main.LocalPlayerPawn->EntitySpottedState.SpottedByMask &
                         (1 << (int)entity.EntityPawnPtr)) != 0)
                    {
                        boxColor = new Vector4(0, 1, 0, 1);
                        spotted = true;
                    }

                var head = *(Vector3*)(entity.EntityPawn.SceneNode->ModalState.BoneArray + 6 * 32);
                Cs2.WorldToScreen(head, matrix, engineWidth, engineHeight, out var headScreen);
                var distanceToSight = Vector2.Distance(headScreen, new Vector2(engineWidth / 2f, engineHeight / 2f));
                var shouldShoot = !Config.VisibleCheck || spotted;
                if ((entity.EntityPawn.TeamNum != Main.LocalPlayerPawn->TeamNum) & (Main.LocalPlayerPawn->Health != 0))
                    if (distanceToSight < maxAimDistance && distanceToSight < Config.AimFoV && shouldShoot)
                    {
                        maxAimDistance = distanceToSight;
                        aimPos = head;
                        aimPos.Z -= Config.AimOffset;
                    }


                var sHead = Cs2.WorldToScreen(headPos, matrix, engineWidth, engineHeight, out var screenHead);
                Cs2.WorldToScreen(origin, matrix, engineWidth, engineHeight, out var screenBase);

                if (!sHead) continue;
                var height = Convert.ToSingle(Math.Sqrt(Math.Pow(screenHead.X - screenBase.X, 2) +
                                                        Math.Pow(screenHead.Y - screenBase.Y, 2)));
                height *= 1.2f;

                var width = height / 2;


                if (Config.BoxEsp)
                    Drawing.Draw3dBox(headPos, origin, entity.EntityPawn.SceneNode->ViewAngle.X, matrix,
                        boxColor);

                else if (Config.TwoDEsp) Drawing.Draw2dBox(screenBase, width, height, boxColor);

                if (Config.SkeletonEsp)
                    Drawing.DrawSkeleton(entity.EntityPawn, matrix, engineWidth, engineHeight);

                if (Config.AimDrawFoV)
                    Drawing.DrawAimbotFov();

                if (Config.TracerEsp)
                    Drawing.DrawTracers(screenBase);

                if (!Config.NameEsp) continue;
                var name = entity.EntityController.SanitizedPlayerName;
                if (name is not null)
                    Drawing.DrawText(screenBase,
                        $"[{name}] [{entity.EntityPawn.Health} hp]");
            }

            if (Config.AimBot)
                if (WinApi.GetAsyncKeyState(18) != 0)
                    if (aimPos != default)
                    {
                        Cs2.AimAt(aimPos);
                        Cs2.TriggerBot();
                    }

            tempEntityList.Clear();
            ImGui.End();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}