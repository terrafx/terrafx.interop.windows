// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
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

    public ref int iSysImageIndex
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.iSysImageIndex, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.iSysImageIndex, 1));
            }
        }
    }

    public ref int iIcon
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.iIcon, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.iIcon, 1));
            }
        }
    }

    [NativeTypeName("WCHAR [260]")]
    public Span<ushort> szPath
    {
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
