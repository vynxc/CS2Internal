using System.Numerics;
using CS2Internal.Game;
using ImGuiNET;

namespace CS2Internal.ImGuiInterface;

/// <summary>
/// Utility class for drawing various elements on the screen.
/// </summary>
public static class Drawing
{
    /// <summary>
    /// Converts an angle from degrees to radians.
    /// </summary>
    /// <param name="angle">The angle in degrees to be converted.</param>
    /// <returns>The angle converted to radians.</returns>
    private static double ConvertToRadians(double angle)
    {
        return Math.PI / 180 * angle;
    }

    /// <summary>
    /// Draws the aimbot field of view (FoV) on the screen.
    /// </summary>
    public static void DrawAimbotFov()
    {
        var color = ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1));
        var drawList = ImGui.GetWindowDrawList();
        var center = new Vector2(ImGui.GetIO().DisplaySize.X / 2, ImGui.GetIO().DisplaySize.Y / 2);
        drawList.AddCircle(center, Config.AimFoV, color, 100, 1);
    }

    /// <summary>
    /// Draws a 3D box on the screen with the specified parameters.
    /// </summary>
    /// <param name="head">The head position of the box in 3D space.</param>
    /// <param name="foot">The foot position of the box in 3D space.</param>
    /// <param name="xAngle">The rotation angle of the box around the X-axis.</param>
    /// <param name="matrix">The matrix used for world transformation.</param>
    /// <param name="vec4Color">The color of the box in RGBA format.</param>
    public static void Draw3dBox(Vector3 head, Vector3 foot, float xAngle,
        ReadOnlySpan<float> matrix, Vector4 vec4Color)
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
        {
            var sHead = Cs2.WorldToScreen(bases[i], matrix, engineWidth, engineHeight, out screenBases[i]);
            Cs2.WorldToScreen(tops[i], matrix, engineWidth, engineHeight, out screenTops[i]);
            if (!sHead)
                return;
        }

        var color = ImGui.ColorConvertFloat4ToU32(vec4Color);

        var drawList = ImGui.GetWindowDrawList();

        for (var i = 0; i < 4; i++)
        {
            drawList.AddLine(screenTops[i], screenBases[i], color, thickness);
            drawList.AddLine(screenTops[i], screenTops[(i + 1) % 4], color, thickness);
            drawList.AddLine(screenBases[i], screenBases[(i + 1) % 4], color, thickness);
        }
    }

    /// <summary>
    /// Draws a 2D box on the screen using ImGui.
    /// </summary>
    /// <param name="foot">The bottom center position of the box.</param>
    /// <param name="width">The width of the box.</param>
    /// <param name="height">The height of the box.</param>
    /// <param name="color">The color of the box.</param>
    public static void Draw2dBox(Vector2 foot, float width, float height, Vector4 color)
    {
        var topLeft = new Vector2(foot.X - width / 2, foot.Y - height);

        var bottomRight = new Vector2(foot.X + width / 2, foot.Y + height / 10);

        ImGui.GetWindowDrawList().AddRectFilled(topLeft, bottomRight,
            ImGui.ColorConvertFloat4ToU32(new Vector4(0, 0, 0, 0.18f)));

        ImGui.GetWindowDrawList().AddRect(topLeft, bottomRight,
            ImGui.ColorConvertFloat4ToU32(new Vector4(0, 0, 0, 1)), 3, ImDrawCornerFlags.All, 2);

        ImGui.GetWindowDrawList()
            .AddRect(topLeft, bottomRight, ImGui.ColorConvertFloat4ToU32(color), 3,
                ImDrawCornerFlags.All, 1);
    }

    /// <summary>
    /// Draws tracers from the center of the window to the specified foot position.
    /// </summary>
    /// <param name="foot">The position of the foot.</param>
    public static void DrawTracers(Vector2 foot)
    {
        ImGui.GetWindowDrawList().AddLine(
            new Vector2(ImGui.GetIO().DisplaySize.X / 2, ImGui.GetIO().DisplaySize.Y / 2),
            foot, ImGui.ColorConvertFloat4ToU32(Config.TracerColor), 1);
    }


    /// <summary>
    /// Calculates the optimal font size based on the given distance.
    /// </summary>
    /// <param name="distance">The distance to calculate the font size for.</param>
    /// <returns>The calculated font size.</returns>
    /// <remarks>
    /// The font size is determined using a linear mapping formula, where the distance is mapped to a range
    /// between the minimum and maximum font size values. Any distance below the minimum value will result
    /// in the smallest font size, while any distance above the maximum value will result in the largest font size.
    /// </remarks>
    /// <param name="distance">The distance to calculate the font size for.</param>
    /// <returns>The calculated font size.</returns>
    /// <example>
    /// float fontSize = CalculateFontSize(15.5); // Returns 18.8
    /// </example>
    private static float CalculateFontSize(double distance)
    {
        // Define the parameters for the linear mapping
        const float minDistance = 0.0f; // Minimum distance for the smallest font size
        const float maxDistance = 30.0f; // Maximum distance for the largest font size
        const float minFontSize = 16.0f; // Smallest font size
        const float maxFontSize = 22.0f; // Largest font size

        // Ensure the distance is within the specified range
        distance = Math.Max(minDistance, Math.Min(distance, maxDistance));

        // Linear mapping formula
        return (float)(maxDistance - distance) / (maxDistance - minDistance) * (maxFontSize - minFontSize) +
               minFontSize;
    }

    /// <summary>
    /// Draws text on the screen at the specified position.
    /// </summary>
    /// <param name="foot">The position at which to draw the text.</param>
    /// <param name="text">The text to be drawn on the screen.</param>
    public static void DrawText(Vector2 foot, string text)
    {
        var distance = Vector2.Distance(new Vector2(ImGui.GetIO().DisplaySize.X / 2, ImGui.GetIO().DisplaySize.Y / 2),
            foot);
        var fontSize = CalculateFontSize(distance);
        var textWidth = ImGui.CalcTextSize(text).X;
        ImGui.GetWindowDrawList().AddText(ImGui.GetFont(), fontSize, new Vector2(foot.X - textWidth / 2, foot.Y - 20),
            ImGui.ColorConvertFloat4ToU32(Config.NameColor), text);
    }

    /// <summary>
    /// Draws the skeleton of an entity pawn on the screen.
    /// </summary>
    /// <param name="entityPawn">The entity pawn to draw the skeleton for.</param>
    /// <param name="matrix">The matrix used for transforming world coordinates to screen coordinates.</param>
    /// <param name="engineWidth">The width of the game engine.</param>
    /// <param name="engineHeight">The height of the game engine.</param>
    public static unsafe void DrawSkeleton(EntityPawn entityPawn, ReadOnlySpan<float> matrix, int engineWidth,
        int engineHeight)
    {

        foreach (var connection in Boners.BoneConnections)
        {
            var bone1 = Boners.BoneOffsetMap[connection.Bone1];
            var bone2 = Boners.BoneOffsetMap[connection.Bone2];
        
            var bone1Pos = *(Vector3*)(entityPawn.SceneNode->ModalState.BoneArray + bone1 * 32);
            var bone2Pos = *(Vector3*)(entityPawn.SceneNode->ModalState.BoneArray + bone2 * 32);
        
            if (!Cs2.WorldToScreen(bone1Pos, matrix, engineWidth, engineHeight, out var screenBone1) ||
                !Cs2.WorldToScreen(bone2Pos, matrix, engineWidth, engineHeight, out var screenBone2))
                continue;
        
            ImGui.GetWindowDrawList().AddLine(screenBone1, screenBone2,
                ImGui.ColorConvertFloat4ToU32(Config.SkeletonColor), 2);
        }
    }
}