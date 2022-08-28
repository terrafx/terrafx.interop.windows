// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct NOTIFYICONIDENTIFIER
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(NOTIFYICONIDENTIFIER32));
            }
            else
            {
                return (uint)(sizeof(NOTIFYICONIDENTIFIER64));
            }
        }
    }

    [FieldOffset(0)]
    public NOTIFYICONIDENTIFIER32 _value32;

    [FieldOffset(0)]
    public NOTIFYICONIDENTIFIER64 _value64;

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
    public ref HWND hWnd
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.hWnd;
            }
            else
            {
                return ref _value64.hWnd;
            }
        }
    }

    [UnscopedRef]
    public ref uint uID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.uID;
            }
            else
            {
                return ref _value64.uID;
            }
        }
    }

    [UnscopedRef]
    public ref Guid guidItem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.guidItem;
            }
            else
            {
                return ref _value64.guidItem;
            }
        }
    }
}
