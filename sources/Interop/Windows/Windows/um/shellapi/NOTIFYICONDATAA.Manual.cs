// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct NOTIFYICONDATAA
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(NOTIFYICONDATA32A));
            }
            else
            {
                return (uint)(sizeof(NOTIFYICONDATA64A));
            }
        }
    }

    [FieldOffset(0)]
    public NOTIFYICONDATA32A _value32;

    [FieldOffset(0)]
    public NOTIFYICONDATA64A _value64;

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

    public ref HWND hWnd
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.hWnd, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.hWnd, 1));
            }
        }
    }

    public ref uint uID
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.uID, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.uID, 1));
            }
        }
    }

    public ref uint uFlags
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.uFlags, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.uFlags, 1));
            }
        }
    }

    public ref uint uCallbackMessage
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.uCallbackMessage, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.uCallbackMessage, 1));
            }
        }
    }

    public ref HICON hIcon
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.hIcon, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.hIcon, 1));
            }
        }
    }

    [NativeTypeName("CHAR [128]")]
    public Span<sbyte> szTip
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.szTip[0], 1);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.szTip[0], 1);
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint dwState
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.dwState, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.dwState, 1));
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint dwStateMask
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.dwStateMask, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.dwStateMask, 1));
            }
        }
    }

    [NativeTypeName("CHAR [256]")]
    public Span<sbyte> szInfo
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.szInfo[0], 1);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.szInfo[0], 1);
            }
        }
    }

    [NativeTypeName("CHAR [64]")]
    public Span<sbyte> szInfoTitle
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.szInfoTitle[0], 1);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.szInfoTitle[0], 1);
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint dwInfoFlags
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.dwInfoFlags, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.dwInfoFlags, 1));
            }
        }
    }

    public ref Guid guidItem
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.guidItem, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.guidItem, 1));
            }
        }
    }

    public ref HICON hBalloonIcon
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.hBalloonIcon, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.hBalloonIcon, 1));
            }
        }
    }

    public ref uint uTimeout
    {
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

    public ref uint uVersion
    {
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
