// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct APPBARDATA
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(APPBARDATA32));
            }
            else
            {
                return (uint)(sizeof(APPBARDATA64));
            }
        }
    }

    [FieldOffset(0)]
    public APPBARDATA32 _value32;

    [FieldOffset(0)]
    public APPBARDATA64 _value64;

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
    public ref uint uCallbackMessage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.uCallbackMessage;
            }
            else
            {
                return ref _value64.uCallbackMessage;
            }
        }
    }

    [UnscopedRef]
    public ref uint uEdge
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.uEdge;
            }
            else
            {
                return ref _value64.uEdge;
            }
        }
    }

    [UnscopedRef]
    public ref RECT rc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.rc;
            }
            else
            {
                return ref _value64.rc;
            }
        }
    }

    [UnscopedRef]
    public ref LPARAM lParam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.lParam;
            }
            else
            {
                return ref _value64.lParam;
            }
        }
    }
}
