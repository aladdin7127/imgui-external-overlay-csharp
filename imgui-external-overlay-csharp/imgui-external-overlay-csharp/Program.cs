using imgui_render;

Renderer renderer = new Renderer();
Thread renderThread = new Thread(renderer.Start().Wait);
renderThread.Start();