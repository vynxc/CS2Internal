using System.Numerics;
using CS2Internal.Game;
using ImGuiNET;

namespace CS2Internal.ImGuiInterface;

public static class Drawing
{
    private static double ConvertToRadians(double angle)
    {
        return Math.PI / 180 * angle;
    }

    public static void Draw3dBox(Vector3 head, Vector3 foot, float xAngle,
        ReadOnlySpan<float> matrix)
    {
        const int width = 25;
        const int thickness = 1;
        var height3D = (int)Math.Abs(head.Z - foot.Z);
        height3D = (int)(height3D * 1.2f);
        var bases = new Vector3[4];
        var tops = new Vector3[4];

        for (var i = 0; i < 4; i++)
        {
            bases[i].Z = foot.Z;
            bases[i].X = foot.X + (float)Math.Cos(ConvertToRadians(xAngle + 45 + 90 * i)) * width;
            bases[i].Y = foot.Y + (float)Math.Sin(ConvertToRadians(xAngle + 45 + 90 * i)) * width;
            tops[i] = new Vector3(bases[i].X, bases[i].Y, bases[i].Z + height3D);
        }


        //TODO: take from engine dll
        var engineWidth = 1920;
        var engineHeight = 1080;

        var screenBases = new Vector2[4];
        var screenTops = new Vector2[4];

        for (var i = 0; i < 4; i++)
            if (!Cs2.WorldToScreen(bases[i], matrix, engineWidth, engineHeight, out screenBases[i]) ||
                !Cs2.WorldToScreen(tops[i], matrix, engineWidth, engineHeight, out screenTops[i]))
                return;

        var color = ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1));

        var drawList = ImGui.GetWindowDrawList();

        for (var i = 0; i < 4; i++)
        {
            drawList.AddLine(screenTops[i], screenBases[i], color, thickness);
            drawList.AddLine(screenTops[i], screenTops[(i + 1) % 4], color, thickness);
            drawList.AddLine(screenBases[i], screenBases[(i + 1) % 4], color, thickness);
        }
    }

    public static void Draw2dBox(Vector2 screenBase, float width, float height, Vector4 color)
    {
        var topLeft = new Vector2(screenBase.X - width / 2, screenBase.Y - height);

        var bottomRight = new Vector2(screenBase.X + width / 2, screenBase.Y + height / 10);

        ImGui.GetWindowDrawList().AddRectFilled(topLeft, bottomRight,
            ImGui.ColorConvertFloat4ToU32(new Vector4(0, 0, 0, 0.18f)));

        ImGui.GetWindowDrawList().AddRect(topLeft, bottomRight,
            ImGui.ColorConvertFloat4ToU32(new Vector4(0, 0, 0, 1)), 3, ImDrawCornerFlags.All, 2);

        ImGui.GetWindowDrawList()
            .AddRect(topLeft, bottomRight, ImGui.ColorConvertFloat4ToU32(color), 3,
                ImDrawCornerFlags.All, 1);
    }

    public static unsafe void DrawSkeleton(Entity entity, ReadOnlySpan<float> matrix, int engineWidth, int engineHeight)
    {
        foreach (var connection in Boners.BoneConnections)
        {
            var bone1 = Boners.BoneOffsetMap[connection.Bone1];
            var bone2 = Boners.BoneOffsetMap[connection.Bone2];

            var bone1Pos = *(Vector3*)(entity.SceneNode->ModalState.BoneArray + bone1 * 32);
            var bone2Pos = *(Vector3*)(entity.SceneNode->ModalState.BoneArray + bone2 * 32);

            if (!Cs2.WorldToScreen(bone1Pos, matrix, engineWidth, engineHeight, out var screenBone1) ||
                !Cs2.WorldToScreen(bone2Pos, matrix, engineWidth, engineHeight, out var screenBone2))
                continue;

            ImGui.GetWindowDrawList().AddLine(screenBone1, screenBone2,
                ImGui.ColorConvertFloat4ToU32(Config.BoxColor), 2);
        }
    }
}