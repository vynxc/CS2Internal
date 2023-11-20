using System.Reflection;
using System.Runtime.InteropServices;

namespace CS2Internal.ImGuiX;

public static class Renderer
{
    private static void LoadEmbeddedDll(string resourceName)
    {
        var currentAssembly = Assembly.GetExecutingAssembly();

        var fullResourceName = $"{currentAssembly.GetName().Name}.{resourceName}";

        using var resourceStream = currentAssembly.GetManifestResourceStream(fullResourceName);
        if (resourceStream == null) throw new Exception($"Resource '{fullResourceName}' not found.");

        var tempPath = Path.Combine(Path.GetTempPath(), resourceName);

        using (var fileStream = new FileStream(tempPath, FileMode.Create))
        {
            resourceStream.CopyTo(fileStream);
        }

        LoadLibrary(tempPath);
    }

    #region PInvoke

    [DllImport("kernel32.dll")]
    private static extern IntPtr LoadLibrary(string dllToLoad);

    [DllImport("PInvokeHooker.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetPresent(CallbackDelegate callback);

    [DllImport("PInvokeHooker.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetRenderDraw(CallbackNothingDelegate callback);

    [DllImport("PInvokeHooker.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void Init();

    [DllImport("PInvokeHooker.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern IntPtr GetHWND();

    [DllImport("PInvokeHooker.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern IntPtr GetDevice();

    [DllImport("PInvokeHooker.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern IntPtr GetContext();

    [DllImport("PInvokeHooker.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetWndProcHandler(WndProcDelegate callback);

    #endregion

    #region Delegates

    private delegate long WndProcDelegate(IntPtr hWnd, uint msg, long wParam, uint lParam);

    private delegate void CallbackDelegate(IntPtr swapChainPtr, int syncInterval, int flags);

    private delegate void CallbackNothingDelegate();

    #endregion

    private static bool _isInit;

    private static void HkPresent(IntPtr swapChainPtr, int syncInterval, int flags)
    {
        if (!_isInit)
        {
            var hwnd = GetHWND();
            var device = GetDevice();
            var context = GetContext();

            ImGuiNET.ImGui.CreateContext();
            ImplWin32.Init(hwnd);
            ImplDx11.Init(device, context);
            _isInit = true;
        }

        ImplDx11.NewFrame();
        ImplWin32.NewFrame();
        ImGuiNET.ImGui.NewFrame();
        _renderUi();
        ImGuiNET.ImGui.Render();
    }

    public delegate void RenderInterface();

    private static RenderInterface _renderUi;


    public static void Init(RenderInterface ui)
    {
        _renderUi = ui;
        LoadEmbeddedDll("PInvokeHooker.dll");
        LoadEmbeddedDll("cimgui.dll");
        Task.Run(WorkerThread);
    }


    private static void Render()
    {
        ImplDx11.RenderDrawData(ImGuiNET.ImGui.GetDrawData());
    }

    private static long WndProcHandler(IntPtr hWnd, uint msg, long wParam, uint lParam)
    {
        var data = ImplWin32.WndProcHandler(hWnd, msg, wParam, lParam);
        return data;
    }

    private static void CreateHook()
    {
        SetWndProcHandler(WndProcHandler);
        SetPresent(HkPresent);
        SetRenderDraw(Render);
        Init();
    }

    private static void WorkerThread()
    {
        CreateHook();
    }
}