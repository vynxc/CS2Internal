using System.Numerics;

namespace CS2Internal.Game;

public static class Config
{
    public static bool AimBot = true;
    public static bool AutoShoot = true;
    public static float AimFoV = 90f;
    public static bool AimDrawFoV = true;
    public static float AimOffset = 1f;
    public static bool Fps = true;
    public static float Fov = 90f;
    public static bool Esp = true;
    public static bool SkeletonEsp = false;
    public static bool BoxEsp = false;
    public static bool HealthEsp = false;
    public static bool NameEsp = false;
    public static bool TracerEsp = false;
    public static Vector4 BoxColor = new(1, 0, 0, 1);
    public static Vector4 SkeletonColor = new(1, 0, 0, 1);
    public static Vector4 TracerColor = new(1, 0, 0, 1);
    public static Vector4 NameColor = new(1, 0, 0, 1);
}