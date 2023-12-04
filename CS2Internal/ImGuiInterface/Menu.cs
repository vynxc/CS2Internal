using System.Collections.Frozen;
using System.Collections.Immutable;
using System.Numerics;
using CS2Internal.ImGuiInterface.Pages;
using CS2Internal.Utility;
using ImGuiNET;

namespace CS2Internal.ImGuiInterface;

public static partial class ImGuiUi
{
    private static readonly ImmutableArray<(string Title, Action RenderPage)> PagesArray = new[]
    {
        ("ESP", new Action(Page.RenderEspPage)),
        ("Aim Bot", new Action(Page.RenderAimBotPage))
    }.ToImmutableArray();

    public static void RenderMenu()
    {
        ImGui.Begin("Styled Menu");
        {
            ImGui.SetWindowSize(new Vector2(500, 300));
            ImGui.BeginChild("TabsAndContent", new Vector2(150, -1), true, ImGuiWindowFlags.None);
            {
                ImGuiHelper.VerticalTabBar(PagesArray.Select(x => x.Title).ToArray(), ref Main.SelectedTab);
            }
            ImGui.EndChild();
            ImGui.SameLine();
            ImGui.BeginChild("MainContent", new Vector2(0, -1), true, ImGuiWindowFlags.None);
            {
                PagesArray.Select(x => x.RenderPage).ElementAt(Main.SelectedTab).Invoke();
            }
            ImGui.EndChild();
        }
        ImGui.End();
    }
}