// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct FILE_IN_CABINET_INFO_A
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(FILE_IN_CABINET_INFO32_A));
            }
            else
            {
                return (uint)(sizeof(FILE_IN_CABINET_INFO64_A));
            }
        }
    }

    [FieldOffset(0)]
    public FILE_IN_CABINET_INFO32_A _value32;

    [FieldOffset(0)]
    public FILE_IN_CABINET_INFO64_A _value64;

    [NativeTypeName("PCSTR")]
    [UnscopedRef]
    public ref sbyte* NameInCabinet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.NameInCabinet;
            }
            else
            {
                return ref _value64.NameInCabinet;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint FileSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.FileSize;
            }
            else
            {
                return ref _value64.FileSize;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint Win32Error
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Win32Error;
            }
            else
            {
                return ref _value64.Win32Error;
            }
        }
    }

    [NativeTypeName("WORD")]
    [UnscopedRef]
    public ref ushort DosDate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.DosDate;
            }
            else
            {
                return ref _value64.DosDate;
            }
        }
    }

    [NativeTypeName("WORD")]
    [UnscopedRef]
    public ref ushort DosTime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.DosTime;
            }
            else
            {
                return ref _value64.DosTime;
            }
        }
    }

    [NativeTypeName("WORD")]
    [UnscopedRef]
    public ref ushort DosAttribs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.DosAttribs;
            }
            else
            {
                return ref _value64.DosAttribs;
            }
        }
    }

    [NativeTypeName("CHAR[260]")]
    [UnscopedRef]
    public Span<sbyte> FullTargetName
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return _value32.FullTargetName;
            }
            else
            {
                return _value64.FullTargetName;
            }
        }
    }
}
