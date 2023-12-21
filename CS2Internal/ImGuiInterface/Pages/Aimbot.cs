using CS2Internal.Game;
using ImGuiNET;

namespace CS2Internal.ImGuiInterface.Pages;

public static partial class Page
{
    public static void RenderAimBotPage()
    {
        ImGui.TextUnformatted("Aimbot Options:");
        ImGui.Separator();
        {
            ImGui.BeginGroup();
            ImGui.Checkbox("Aim bot", ref Config.AimBot);
            ImGui.Checkbox("Trigger Bot", ref Config.TriggerBot);
            ImGui.Checkbox("Visible Check", ref Config.VisibleCheck);
            ImGui.Checkbox("Anti Recoil", ref Config.AntiRecoil);
            ImGui.SliderFloat("Aim Offset", ref Config.AimOffset, 0, 10);
            ImGui.EndGroup();

            ImGui.BeginGroup();
            ImGui.Checkbox("Draw FOV", ref Config.AimDrawFoV);
            ImGui.SliderFloat("FOV", ref Config.AimFoV, 0, 360);
            ImGui.EndGroup();
        }
    }
}