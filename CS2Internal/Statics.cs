using System.Diagnostics;
using CS2Internal.Game;
using CS2Internal.Utility;

namespace CS2Internal;

public abstract unsafe partial class Main
{
    public static readonly IntPtr ModuleBaseClient = WinApi.GetModuleHandle("client.dll");
    public static readonly IntPtr ModuleBaseEngine = WinApi.GetModuleHandle("engine2.dll");
    public static EntityPawn* LocalPlayerPawn;
    public static IntPtr LocalPlayerPawnPtr;
    public static readonly bool IsRunning = true;
    public static readonly List<Entity> EntityList = new();
    public static readonly object EntityListLock = new();
    public static int FrameCounter = 0;
    public static double TimeCounter = 0.0;
    public const double RefreshTime = 0.5; // Time until update in seconds
    public static double Fps = 0.0;
    public static Stopwatch? Stopwatch;
    public static readonly string[] Tabs = { "Esp", "Tab 2", "Tab 3" };
    public static int SelectedTab = 0;
    public static bool ShowMenu = true;
    public static IntPtr Module;
}