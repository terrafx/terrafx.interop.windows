// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct FILEPATHS_A
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(FILEPATHS32_A));
            }
            else
            {
                return (uint)(sizeof(FILEPATHS64_A));
            }
        }
    }

    [FieldOffset(0)]
    public FILEPATHS32_A _value32;

    [FieldOffset(0)]
    public FILEPATHS64_A _value64;

    [NativeTypeName("PCSTR")]
    public ref sbyte* Target
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).Target;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).Target;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    public ref sbyte* Source
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).Source;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).Source;
            }
        }
    }

    public ref uint Win32Error
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.Win32Error, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.Win32Error, 1));
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint Flags
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.Flags, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.Flags, 1));
            }
        }
    }
}
