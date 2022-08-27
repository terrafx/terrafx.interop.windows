// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_INF_INFORMATION
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_INF_INFORMATION32));
            }
            else
            {
                return (uint)(sizeof(SP_INF_INFORMATION64));
            }
        }
    }

    [FieldOffset(0)]
    public SP_INF_INFORMATION32 _value32;

    [FieldOffset(0)]
    public SP_INF_INFORMATION64 _value64;

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint InfStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.InfStyle;
            }
            else
            {
                return ref _value64.InfStyle;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint InfCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.InfCount;
            }
            else
            {
                return ref _value64.InfCount;
            }
        }
    }

    [NativeTypeName("BYTE [1]")]
    public Span<byte> VersionData
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.VersionData[0], 1);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.VersionData[0], 1);
            }
        }
    }
}
