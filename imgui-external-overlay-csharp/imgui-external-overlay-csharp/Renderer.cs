using ClickableTransparentOverlay;
using ImGuiNET;
using System.Numerics;
using System.Runtime.InteropServices;

namespace imgui_render
{
    public class Renderer: Overlay
    {
        [DllImport("user32.dll")] static extern short GetAsyncKeyState(int vKey);

        bool Show = true;
        Vector2 WindowSize = new Vector2(400, 200);

        protected override void Render()
        {
            if ((GetAsyncKeyState(0x2D) & 1) > 0)
            {
                Show = !Show;
            }

            if (Show)
            {
                ImGui.SetNextWindowSize(WindowSize);
                ImGui.Begin("ImGui Overlay", ImGuiWindowFlags.NoResize);
                {
                    ImGui.Checkbox("Show Menu", ref Show);

                    ImGui.End();
                }
            }
            
        }
    }
}
