using System.Numerics;
using CS2Internal.Utility;

namespace CS2Internal.Game;

public static class Config
{
    public static bool AimBot = false;
    public static bool TriggerBot = true;
    public static bool AntiRecoil = true;
    public static float AimFoV = 190f;
    public static bool VisibleCheck = false;
    public static bool AimDrawFoV = true;
    public static float AimOffset = 4f;
    public static bool Fps = true;
    public static float Fov = 90f;
    public static bool SkeletonEsp = false;
    public static bool Esp = false;
    public static bool BoxEsp = true;
    public static bool TwoDEsp = false;
    public static bool HealthEsp = false;
    public static bool NameEsp = false;
    public static bool TracerEsp = true;
    public static Vector4 BoxColor = Colors.ConvertArgbToNormalizedRgb(new Vector4(127, 255, 212, 255));
    public static Vector4 SkeletonColor = new(0.9f, 0.5f, 0.2f, 1f); // Orange
    public static Vector4 TracerColor = new(0.1f, 0.3f, 0.9f, 1f); // Blue
    public static Vector4 NameColor = new(0.8f, 0.2f, 0.7f, 1f); // Purple
}