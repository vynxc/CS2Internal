using System.Numerics;
using CS2Internal.ImGuiInterface.Pages;
using CS2Internal.Utility;
using ImGuiNET;

namespace CS2Internal.ImGuiInterface;

public partial class ImGuiUi
{
    public static void RenderMenu()
    {
        ImGui.Begin("Styled Menu");
        {
            ImGui.SetWindowSize(new Vector2(500, 300));
            ImGui.BeginChild("TabsAndContent", new Vector2(150, -1), true, ImGuiWindowFlags.None);
            {
                ImGuiHelper.VerticalTabBar(Main.Tabs, ref Main.SelectedTab);
            }
            ImGui.EndChild();
            ImGui.SameLine();
            ImGui.BeginChild("MainContent", new Vector2(0, -1), true, ImGuiWindowFlags.None);
            {
                if (Main.SelectedTab == 0)
                {
                    Page.RenderEspPage();
                }
                else
                {
                    ImGui.TextUnformatted($"Tab Content: {Main.Tabs[Main.SelectedTab]}");
                    ImGui.TextUnformatted("Main Content Goes Here");
                }
            }
            ImGui.EndChild();
        }
        ImGui.End();
    }
}