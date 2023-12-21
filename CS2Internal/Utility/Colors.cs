using System.Numerics;

namespace CS2Internal.Utility;

public static class Colors
{
    public static Vector4 ConvertArgbToNormalizedRgb(Vector4 argbColor)
    {
        return new Vector4(argbColor.X / 255.0f, argbColor.Y / 255.0f, argbColor.Z / 255.0f, argbColor.W / 255.0f);
    }
}