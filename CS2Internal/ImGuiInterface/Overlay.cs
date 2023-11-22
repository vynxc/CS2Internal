using System.Numerics;
using CS2Internal.Game;
using ImGuiNET;

namespace CS2Internal.ImGuiInterface;

public partial class ImGuiUi
{
    public static unsafe void RenderOverlay()
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

        foreach (var entity in tempEntityList)
        {
            if (entity.SceneNode->Dormant != 0)
                continue;

            var engineWidth = 1920;
            var engineHeight = 1080;

            var origin = entity.SceneNode->VecOriginAbsolute;
            var headPos = *(Vector3*)(entity.SceneNode->ModalState.BoneArray + 6 * 32);

            if (!Cs2.WorldToScreen(headPos, matrix, engineWidth, engineHeight, out var screenHead) ||
                !Cs2.WorldToScreen(origin, matrix, engineWidth, engineHeight, out var screenBase))
                continue;

            var height = Convert.ToSingle(Math.Sqrt(Math.Pow(screenHead.X - screenBase.X, 2) +
                                                    Math.Pow(screenHead.Y - screenBase.Y, 2)));
            height *= 1.2f;
            var width = height / 2;
            if (Config.BoxEsp && Config.Esp)
                Drawing.Draw3dBox(headPos, origin, entity.SceneNode->VecRotation.X, 25, 1, matrix);
            else if (Config.Esp) Drawing.Draw2dBox(screenBase, width, height, Config.BoxColor);

            if (Config.SkeletonEsp)
                Drawing.DrawSkeleton(entity, matrix, engineWidth, engineHeight);
        }

        tempEntityList.Clear();
        ImGui.End();
    }
}