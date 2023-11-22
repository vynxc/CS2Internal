using System.Numerics;
using ImGuiNET;

namespace CS2Internal.Utility;

public static class ImGuiHelper
{
    public static void VerticalTabBar(string[] tabNames, ref int selectedTab)
    {
        ImGui.PushStyleVar(ImGuiStyleVar.FrameBorderSize, 1.0f);
        ImGui.PushStyleVar(ImGuiStyleVar.FrameRounding, 0.0f);

        for (var i = 0; i < tabNames.Length; ++i)
            if (ImGui.Button(tabNames[i], new Vector2(-1, 30)))
                selectedTab = i;

        ImGui.PopStyleVar(2);
    }
}