using System.Numerics;

namespace CS2Internal.Game;

public static class Config
{
    public static bool Aimbot = true;
    public static bool Overlay = true;
    public static bool Fps = true;
    public static float Fov = 90f;
    public static bool Esp = true;
    public static bool SkeletonEsp = false;
    public static bool BoxEsp = false;
    public static Vector4 BoxColor = new(1, 0, 0, 1);
    public static bool HealthEsp = false;
    public static bool NameEsp = false;
    public static bool SnaplineEsp = false;
}