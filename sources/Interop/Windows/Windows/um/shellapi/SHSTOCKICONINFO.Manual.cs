// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SHSTOCKICONINFO
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SHSTOCKICONINFO32));
            }
            else
            {
                return (uint)(sizeof(SHSTOCKICONINFO64));
            }
        }
    }

    [FieldOffset(0)]
    public SHSTOCKICONINFO32 _value32;

    [FieldOffset(0)]
    public SHSTOCKICONINFO64 _value64;

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
    public ref HICON hIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.hIcon;
            }
            else
            {
                return ref _value64.hIcon;
            }
        }
    }

    [UnscopedRef]
    public ref int iSysImageIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.iSysImageIndex;
            }
            else
            {
                return ref _value64.iSysImageIndex;
            }
        }
    }

    [UnscopedRef]
    public ref int iIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.iIcon;
            }
            else
            {
                return ref _value64.iIcon;
            }
        }
    }

    [NativeTypeName("WCHAR [260]")]
    [UnscopedRef]
    public Span<ushort> szPath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.szPath[0], 260);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.szPath[0], 260);
            }
        }
    }
}
