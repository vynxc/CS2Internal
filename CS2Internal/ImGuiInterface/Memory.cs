using System.Runtime.InteropServices;

namespace CS2Internal.ImGuiInterface;

public static class Memory
{
    public static unsafe T? Read<T>(IntPtr address, params int[] offsets) where T : unmanaged
    {
        if (address == IntPtr.Zero)
            throw new ArgumentNullException(nameof(address));

        try
        {
            checked
            {
                address = offsets.Aggregate(address, (current, offset) => current + offset);
            }
        }
        catch (OverflowException ex)
        {
            throw new ArgumentException("Overflow", nameof(offsets), ex);
        }

        return *(T*)address;
    }

    public static unsafe void Write<T>(IntPtr address, T value) where T : unmanaged
    {
        if (address == IntPtr.Zero)
            throw new ArgumentNullException(nameof(address));

        *(T*)address = value;
    }
}