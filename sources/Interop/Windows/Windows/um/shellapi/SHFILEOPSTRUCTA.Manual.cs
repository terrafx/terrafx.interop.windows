// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
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

    [UnscopedRef]
    public ref HWND hwnd
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.hwnd;
            }
            else
            {
                return ref _value64.hwnd;
            }
        }
    }

    [UnscopedRef]
    public ref uint wFunc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.wFunc;
            }
            else
            {
                return ref _value64.wFunc;
            }
        }
    }

    [NativeTypeName("PCZZSTR")]
    [UnscopedRef]
    public ref sbyte* pFrom
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.pFrom;
            }
            else
            {
                return ref _value64.pFrom;
            }
        }
    }

    [NativeTypeName("PCZZSTR")]
    [UnscopedRef]
    public ref sbyte* pTo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.pTo;
            }
            else
            {
                return ref _value64.pTo;
            }
        }
    }

    [NativeTypeName("FILEOP_FLAGS")]
    [UnscopedRef]
    public ref ushort fFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.fFlags;
            }
            else
            {
                return ref _value64.fFlags;
            }
        }
    }

    [UnscopedRef]
    public ref BOOL fAnyOperationsAborted
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.fAnyOperationsAborted;
            }
            else
            {
                return ref _value64.fAnyOperationsAborted;
            }
        }
    }

    [NativeTypeName("LPVOID")]
    [UnscopedRef]
    public ref void* hNameMappings
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.hNameMappings;
            }
            else
            {
                return ref _value64.hNameMappings;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    [UnscopedRef]
    public ref sbyte* lpszProgressTitle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.lpszProgressTitle;
            }
            else
            {
                return ref _value64.lpszProgressTitle;
            }
        }
    }
}
