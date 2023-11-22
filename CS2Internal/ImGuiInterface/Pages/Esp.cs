using CS2Internal.Game;
using ImGuiNET;

namespace CS2Internal.ImGuiInterface.Pages;

public static class Page
{
    public static void RenderEspPage()
    {
        {
            ImGui.Checkbox("ESP", ref Config.Esp);
            ImGui.SameLine();
            ImGui.Checkbox("Box ESP", ref Config.BoxEsp);
            ImGui.SameLine();
            ImGui.Checkbox("Health ESP", ref Config.HealthEsp);
        }
        {
            ImGui.Checkbox("Name ESP", ref Config.NameEsp);
            ImGui.SameLine();
            ImGui.Checkbox("Snapline ESP", ref Config.SnaplineEsp);
            ImGui.SameLine();
            ImGui.Checkbox("Skeleton ESP", ref Config.SkeletonEsp);
        }
        ImGui.ColorEdit4("Box Color", ref Config.BoxColor);
    }
}