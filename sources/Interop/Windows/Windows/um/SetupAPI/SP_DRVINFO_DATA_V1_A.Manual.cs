// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_DRVINFO_DATA_V1_A
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_DRVINFO_DATA32_V1_A));
            }
            else
            {
                return (uint)(sizeof(SP_DRVINFO_DATA64_V1_A));
            }
        }
    }

    [FieldOffset(0)]
    public SP_DRVINFO_DATA32_V1_A _value32;

    [FieldOffset(0)]
    public SP_DRVINFO_DATA64_V1_A _value64;

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

    [NativeTypeName("CHAR[256]")]
    [UnscopedRef]
    public Span<sbyte> Description
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return _value32.Description;
            }
            else
            {
                return _value64.Description;
            }
        }
    }

    [NativeTypeName("CHAR[256]")]
    [UnscopedRef]
    public Span<sbyte> MfgName
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return _value32.MfgName;
            }
            else
            {
                return _value64.MfgName;
            }
        }
    }

    [NativeTypeName("CHAR[256]")]
    [UnscopedRef]
    public Span<sbyte> ProviderName
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return _value32.ProviderName;
            }
            else
            {
                return _value64.ProviderName;
            }
        }
    }
}
