using ClickableTransparentOverlay;
using ImGuiNET;

namespace imgui_render
{
    public class Renderer: Overlay
    {
        protected override void Render()
        {
            ImGui.Begin("ImGui Overlay");
            {
                ImGui.End();
            }
        }
    }
}
