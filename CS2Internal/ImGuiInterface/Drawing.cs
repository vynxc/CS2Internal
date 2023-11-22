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

    public static void Draw3dBox(Vector3 top, Vector3 bot, float a, float width, int thickness,
        ReadOnlySpan<float> matrix)
    {
        var height3D = (int)Math.Abs(top.Z - bot.Z);
        height3D = (int)(height3D * 1.2f);
        Vector3 b1, b2, b3, b4, t1, t2, t3, t4;
        b1.Z = b2.Z = b3.Z = b4.Z = bot.Z;
        b1.X = bot.X + (float)Math.Cos(ConvertToRadians(a + 45)) * width;
        b1.Y = bot.Y + (float)Math.Sin(ConvertToRadians(a + 45)) * width;

        b2.X = bot.X + (float)Math.Cos(ConvertToRadians(a + 135)) * width;
        b2.Y = bot.Y + (float)Math.Sin(ConvertToRadians(a + 135)) * width;

        b3.X = bot.X + (float)Math.Cos(ConvertToRadians(a + 225)) * width;
        b3.Y = bot.Y + (float)Math.Sin(ConvertToRadians(a + 225)) * width;

        b4.X = bot.X + (float)Math.Cos(ConvertToRadians(a + 315)) * width;
        b4.Y = bot.Y + (float)Math.Sin(ConvertToRadians(a + 315)) * width;

        t1.X = b1.X;
        t1.Y = b1.Y;
        t1.Z = b1.Z + height3D;

        t2.X = b2.X;
        t2.Y = b2.Y;
        t2.Z = b2.Z + height3D;

        t3.X = b3.X;
        t3.Y = b3.Y;
        t3.Z = b3.Z + height3D;

        t4.X = b4.X;
        t4.Y = b4.Y;
        t4.Z = b4.Z + height3D;
        var engineWidth = 1920;
        var engineHeight = 1080;

        if (!Cs2.WorldToScreen(b1, matrix, engineWidth, engineHeight, out var b12) ||
            !Cs2.WorldToScreen(b2, matrix, engineWidth, engineHeight, out var b22) ||
            !Cs2.WorldToScreen(b3, matrix, engineWidth, engineHeight, out var b32) ||
            !Cs2.WorldToScreen(b4, matrix, engineWidth, engineHeight, out var b42) ||
            !Cs2.WorldToScreen(t1, matrix, engineWidth, engineHeight, out var t12) ||
            !Cs2.WorldToScreen(t2, matrix, engineWidth, engineHeight, out var t22) ||
            !Cs2.WorldToScreen(t3, matrix, engineWidth, engineHeight, out var t32) ||
            !Cs2.WorldToScreen(t4, matrix, engineWidth, engineHeight, out var t42))
        {
            return;
        }

        ImGui.GetWindowDrawList()
            .AddLine(t12, b12, ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1)), thickness);
        ImGui.GetWindowDrawList()
            .AddLine(t22, b22, ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1)), thickness);
        ImGui.GetWindowDrawList()
            .AddLine(t32, b32, ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1)), thickness);
        ImGui.GetWindowDrawList()
            .AddLine(t42, b42, ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1)), thickness);

        ImGui.GetWindowDrawList()
            .AddLine(t12, t22, ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1)), thickness);
        ImGui.GetWindowDrawList()
            .AddLine(t22, t32, ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1)), thickness);
        ImGui.GetWindowDrawList()
            .AddLine(t32, t42, ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1)), thickness);
        ImGui.GetWindowDrawList()
            .AddLine(t42, t12, ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1)), thickness);

        ImGui.GetWindowDrawList()
            .AddLine(b12, b22, ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1)), thickness);
        ImGui.GetWindowDrawList()
            .AddLine(b22, b32, ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1)), thickness);
        ImGui.GetWindowDrawList()
            .AddLine(b32, b42, ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1)), thickness);
        ImGui.GetWindowDrawList()
            .AddLine(b42, b12, ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1)), thickness);
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