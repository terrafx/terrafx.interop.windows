// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct OPEN_PRINTER_PROPS_INFOA
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(OPEN_PRINTER_PROPS_INFO32A));
            }
            else
            {
                return (uint)(sizeof(OPEN_PRINTER_PROPS_INFO64A));
            }
        }
    }

    [FieldOffset(0)]
    public OPEN_PRINTER_PROPS_INFO32A _value32;

    [FieldOffset(0)]
    public OPEN_PRINTER_PROPS_INFO64A _value64;

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint dwSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.dwSize;
            }
            else
            {
                return ref _value64.dwSize;
            }
        }
    }

    [NativeTypeName("LPSTR")]
    [UnscopedRef]
    public ref sbyte* pszSheetName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.pszSheetName;
            }
            else
            {
                return ref _value64.pszSheetName;
            }
        }
    }

    [UnscopedRef]
    public ref uint uSheetIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.uSheetIndex;
            }
            else
            {
                return ref _value64.uSheetIndex;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint dwFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.dwFlags;
            }
            else
            {
                return ref _value64.dwFlags;
            }
        }
    }

    [UnscopedRef]
    public ref BOOL bModal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.bModal;
            }
            else
            {
                return ref _value64.bModal;
            }
        }
    }
}
