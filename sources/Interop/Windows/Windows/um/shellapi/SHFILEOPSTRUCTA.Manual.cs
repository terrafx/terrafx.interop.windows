// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SHFILEOPSTRUCTA
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SHFILEOPSTRUCT32A));
            }
            else
            {
                return (uint)(sizeof(SHFILEOPSTRUCT64A));
            }
        }
    }

    [FieldOffset(0)]
    public SHFILEOPSTRUCT32A _value32;

    [FieldOffset(0)]
    public SHFILEOPSTRUCT64A _value64;

    public ref HWND hwnd
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.hwnd, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.hwnd, 1));
            }
        }
    }

    public ref uint wFunc
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.wFunc, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.wFunc, 1));
            }
        }
    }

    [NativeTypeName("PCZZSTR")]
    public ref sbyte* pFrom
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).pFrom;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).pFrom;
            }
        }
    }

    [NativeTypeName("PCZZSTR")]
    public ref sbyte* pTo
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).pTo;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).pTo;
            }
        }
    }

    [NativeTypeName("FILEOP_FLAGS")]
    public ref ushort fFlags
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.fFlags, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.fFlags, 1));
            }
        }
    }

    public ref BOOL fAnyOperationsAborted
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.fAnyOperationsAborted, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.fAnyOperationsAborted, 1));
            }
        }
    }

    [NativeTypeName("LPVOID")]
    public ref void* hNameMappings
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).hNameMappings;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).hNameMappings;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    public ref sbyte* lpszProgressTitle
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).lpszProgressTitle;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).lpszProgressTitle;
            }
        }
    }
}
