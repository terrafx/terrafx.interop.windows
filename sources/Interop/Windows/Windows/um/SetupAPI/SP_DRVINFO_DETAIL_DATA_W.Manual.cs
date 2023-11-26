// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_DRVINFO_DETAIL_DATA_W
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_DRVINFO_DETAIL_DATA32_W));
            }
            else
            {
                return (uint)(sizeof(SP_DRVINFO_DETAIL_DATA64_W));
            }
        }
    }

    [FieldOffset(0)]
    public SP_DRVINFO_DETAIL_DATA32_W _value32;

    [FieldOffset(0)]
    public SP_DRVINFO_DETAIL_DATA64_W _value64;

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

    [NativeTypeName("WCHAR [256]")]
    [UnscopedRef]
    public Span<char> SectionName
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return _value32.SectionName;
            }
            else
            {
                return _value64.SectionName;
            }
        }
    }

    [NativeTypeName("WCHAR[260]")]
    [UnscopedRef]
    public Span<char> InfFileName
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return _value32.InfFileName;
            }
            else
            {
                return _value64.InfFileName;
            }
        }
    }

    [NativeTypeName("WCHAR[256]")]
    [UnscopedRef]
    public Span<char> DrvDescription
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return _value32.DrvDescription;
            }
            else
            {
                return _value64.DrvDescription;
            }
        }
    }

    [NativeTypeName("WCHAR[1]")]
    [UnscopedRef]
    public Span<char> HardwareID
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
