using System.Runtime.InteropServices;

namespace CS2Internal.ImGuiInterface;

public static unsafe class Memory
{
    public static T? Read<T>(IntPtr address, params int[] offsets) where T : unmanaged
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

    public static void Write<T>(IntPtr address, T value) where T : unmanaged
    {
        if (address == IntPtr.Zero)
            throw new ArgumentNullException(nameof(address));

        *(T*)address = value;
    }


    public static T? Read<T>(IntPtr address) where T : unmanaged
    {
        if (address == IntPtr.Zero)
            throw new ArgumentNullException(nameof(address));

        return *(T*)address;
    }

    public static void Nop(IntPtr address, int size)
    {
        if (address == IntPtr.Zero)
            throw new ArgumentNullException(nameof(address));

        var nops = new byte[size];
        for (var i = 0; i < size; i++)
            nops[i] = 0x90;

        Marshal.Copy(nops, 0, address, size);
    }
}