// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct NOTIFYICONDATAW
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(NOTIFYICONDATA32W));
            }
            else
            {
                return (uint)(sizeof(NOTIFYICONDATA64W));
            }
        }
    }

    [FieldOffset(0)]
    public NOTIFYICONDATA32W _value32;

    [FieldOffset(0)]
    public NOTIFYICONDATA64W _value64;

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
    public ref uint uFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.uFlags;
            }
            else
            {
                return ref _value64.uFlags;
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

    [NativeTypeName("WCHAR [128]")]
    public Span<ushort> szTip
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.szTip[0], 128);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.szTip[0], 128);
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint dwState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.dwState;
            }
            else
            {
                return ref _value64.dwState;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint dwStateMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.dwStateMask;
            }
            else
            {
                return ref _value64.dwStateMask;
            }
        }
    }

    [NativeTypeName("WCHAR [256]")]
    public Span<ushort> szInfo
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.szInfo[0], 256);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.szInfo[0], 256);
            }
        }
    }

    [NativeTypeName("WCHAR [64]")]
    public Span<ushort> szInfoTitle
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.szInfoTitle[0], 64);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.szInfoTitle[0], 64);
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint dwInfoFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.dwInfoFlags;
            }
            else
            {
                return ref _value64.dwInfoFlags;
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

    [UnscopedRef]
    public ref HICON hBalloonIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.hBalloonIcon;
            }
            else
            {
                return ref _value64.hBalloonIcon;
            }
        }
    }

    [UnscopedRef]
    public ref uint uTimeout
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.uTimeout;
            }
            else
            {
                return ref _value64.uTimeout;
            }
        }
    }

    [UnscopedRef]
    public ref uint uVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.uVersion;
            }
            else
            {
                return ref _value64.uVersion;
            }
        }
    }
}
