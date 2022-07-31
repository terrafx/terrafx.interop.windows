// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_DRVINFO_DETAIL_DATA_A
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_DRVINFO_DETAIL_DATA32_A));
            }
            else
            {
                return (uint)(sizeof(SP_DRVINFO_DETAIL_DATA64_A));
            }
        }
    }

    [FieldOffset(0)]
    public SP_DRVINFO_DETAIL_DATA32_A _value32;

    [FieldOffset(0)]
    public SP_DRVINFO_DETAIL_DATA64_A _value64;

    [NativeTypeName("DWORD")]
    public ref uint cbSize
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.cbSize, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.cbSize, 1));
            }
        }
    }

    public ref FILETIME InfDate
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.InfDate, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.InfDate, 1));
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint CompatIDsOffset
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.CompatIDsOffset, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.CompatIDsOffset, 1));
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint CompatIDsLength
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.CompatIDsLength, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.CompatIDsLength, 1));
            }
        }
    }

    [NativeTypeName("ULONG_PTR")]
    public ref nuint Reserved
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.Reserved, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.Reserved, 1));
            }
        }
    }

    [NativeTypeName("CHAR [256]")]
    public Span<sbyte> SectionName
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.SectionName[0], 256);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.SectionName[0], 256);
            }
        }
    }

    [NativeTypeName("CHAR [260]")]
    public Span<sbyte> InfFileName
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.InfFileName[0], 260);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.InfFileName[0], 260);
            }
        }
    }

    [NativeTypeName("CHAR [256]")]
    public Span<sbyte> DrvDescription
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.DrvDescription[0], 256);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.DrvDescription[0], 256);
            }
        }
    }

    [NativeTypeName("CHAR [1]")]
    public Span<sbyte> HardwareID
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.HardwareID[0], 1);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.HardwareID[0], 1);
            }
        }
    }
}
