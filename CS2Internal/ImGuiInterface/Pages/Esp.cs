using CS2Internal.Game;
using ImGuiNET;

namespace CS2Internal.ImGuiInterface.Pages;

public static partial class Page
{
    public static void RenderEspPage()
    {
        ImGui.TextUnformatted("ESP Options:");
        ImGui.Checkbox("ESP", ref Config.Esp);
        ImGui.Separator();
        {
            ImGui.BeginGroup();
            ImGui.Checkbox("2D ESP", ref Config.TwoDEsp);
            ImGui.Checkbox("Name ESP", ref Config.NameEsp);
            ImGui.EndGroup();

            ImGui.SameLine();

            ImGui.BeginGroup();
            ImGui.Checkbox("3D ESP", ref Config.BoxEsp);
            ImGui.Checkbox("Tracer ESP", ref Config.TracerEsp);
            ImGui.EndGroup();

            ImGui.SameLine();

            ImGui.BeginGroup();
            ImGui.Checkbox("Health ESP", ref Config.HealthEsp);
            ImGui.Checkbox("Skeleton ESP", ref Config.SkeletonEsp);
            ImGui.EndGroup();
        }

        ImGui.Separator();
        {
            ImGui.TextUnformatted("Colors:");
            ImGui.Separator();

            ImGui.ColorEdit4("Box Color", ref Config.BoxColor);
            ImGui.ColorEdit4("Tracer Color", ref Config.TracerColor);
            ImGui.ColorEdit4("Skeleton Color", ref Config.SkeletonColor);
            ImGui.ColorEdit4("Name Color", ref Config.NameColor);
        }
    }
}