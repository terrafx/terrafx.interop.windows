// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_SELECTDEVICE_PARAMS_A
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_SELECTDEVICE_PARAMS32_A));
            }
            else
            {
                return (uint)(sizeof(SP_SELECTDEVICE_PARAMS64_A));
            }
        }
    }

    [FieldOffset(0)]
    public SP_SELECTDEVICE_PARAMS32_A _value32;

    [FieldOffset(0)]
    public SP_SELECTDEVICE_PARAMS64_A _value64;

    [UnscopedRef]
    public ref SP_CLASSINSTALL_HEADER ClassInstallHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref Unsafe.As<SP_CLASSINSTALL_HEADER32, SP_CLASSINSTALL_HEADER>(ref _value32.ClassInstallHeader);
            }
            else
            {
                return ref Unsafe.As<SP_CLASSINSTALL_HEADER64, SP_CLASSINSTALL_HEADER>(ref _value64.ClassInstallHeader);
            }
        }
    }

    [NativeTypeName("CHAR [60]")]
    public Span<sbyte> Title
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.Title[0], 60);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.Title[0], 60);
            }
        }
    }

    [NativeTypeName("CHAR [256]")]
    public Span<sbyte> Instructions
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.Instructions[0], 256);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.Instructions[0], 256);
            }
        }
    }

    [NativeTypeName("CHAR [30]")]
    public Span<sbyte> ListLabel
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.ListLabel[0], 30);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.ListLabel[0], 30);
            }
        }
    }

    [NativeTypeName("CHAR [256]")]
    public Span<sbyte> SubTitle
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.SubTitle[0], 256);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.SubTitle[0], 256);
            }
        }
    }

    [NativeTypeName("BYTE [2]")]
    public Span<byte> Reserved
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.Reserved[0], 2);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.Reserved[0], 2);
            }
        }
    }
}
