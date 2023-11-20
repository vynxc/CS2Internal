using System.Runtime.InteropServices;
using ImGuiNET;

namespace CS2Internal.ImGuiX;

public abstract class ImplDx11
{
    [DllImport("cimgui", EntryPoint = "ImGui_ImplDX11_Init", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool Init(IntPtr device, IntPtr contenxt);

    [DllImport("cimgui", EntryPoint = "ImGui_ImplDX11_Shutdown", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Shutdown();

    [DllImport("cimgui", EntryPoint = "ImGui_ImplDX11_NewFrame", CallingConvention = CallingConvention.Cdecl)]
    public static extern void NewFrame();

    [DllImport("cimgui", EntryPoint = "ImGui_ImplDX11_RenderDrawData",
        CallingConvention = CallingConvention.Cdecl)]
    public static extern void RenderDrawData(ImDrawDataPtr drawData);

    [DllImport("cimgui", EntryPoint = "ImGui_ImplDX11_CreateDeviceObjects",
        CallingConvention = CallingConvention.Cdecl)]
    public static extern bool CreateDeviceObjects();

    [DllImport("cimgui", EntryPoint = "ImGui_ImplDX11_InvalidateDeviceObjects",
        CallingConvention = CallingConvention.Cdecl)]
    public static extern void InvalidateDeviceObjects();
}