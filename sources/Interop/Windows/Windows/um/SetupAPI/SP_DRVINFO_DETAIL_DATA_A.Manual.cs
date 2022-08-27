// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
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
    [UnscopedRef]
    public ref uint cbSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.cbSize;
            }
            else
            {
                return ref _value64.cbSize;
            }
        }
    }

    [UnscopedRef]
    public ref FILETIME InfDate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.InfDate;
            }
            else
            {
                return ref _value64.InfDate;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint CompatIDsOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.CompatIDsOffset;
            }
            else
            {
                return ref _value64.CompatIDsOffset;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint CompatIDsLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.CompatIDsLength;
            }
            else
            {
                return ref _value64.CompatIDsLength;
            }
        }
    }

    [NativeTypeName("ULONG_PTR")]
    [UnscopedRef]
    public ref nuint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Reserved;
            }
            else
            {
                return ref _value64.Reserved;
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
