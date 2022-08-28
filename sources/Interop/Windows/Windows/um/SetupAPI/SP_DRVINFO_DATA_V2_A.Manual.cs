// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_DRVINFO_DATA_V2_A
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_DRVINFO_DATA32_V2_A));
            }
            else
            {
                return (uint)(sizeof(SP_DRVINFO_DATA64_V2_A));
            }
        }
    }

    [FieldOffset(0)]
    public SP_DRVINFO_DATA32_V2_A _value32;

    [FieldOffset(0)]
    public SP_DRVINFO_DATA64_V2_A _value64;

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

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint DriverType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.DriverType;
            }
            else
            {
                return ref _value64.DriverType;
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
    public Span<sbyte> Description
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.Description[0], 256);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.Description[0], 256);
            }
        }
    }

    [NativeTypeName("CHAR [256]")]
    public Span<sbyte> MfgName
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.MfgName[0], 256);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.MfgName[0], 256);
            }
        }
    }

    [NativeTypeName("CHAR [256]")]
    public Span<sbyte> ProviderName
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.ProviderName[0], 256);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.ProviderName[0], 256);
            }
        }
    }

    [UnscopedRef]
    public ref FILETIME DriverDate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.DriverDate;
            }
            else
            {
                return ref _value64.DriverDate;
            }
        }
    }

    [NativeTypeName("DWORDLONG")]
    [UnscopedRef]
    public ref ulong DriverVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.DriverVersion;
            }
            else
            {
                return ref _value64.DriverVersion;
            }
        }
    }
}
