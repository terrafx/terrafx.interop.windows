// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct FILEPATHS_A
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(FILEPATHS32_A));
            }
            else
            {
                return (uint)(sizeof(FILEPATHS64_A));
            }
        }
    }

    [FieldOffset(0)]
    public FILEPATHS32_A _value32;

    [FieldOffset(0)]
    public FILEPATHS64_A _value64;

    [NativeTypeName("PCSTR")]
    [UnscopedRef]
    public ref sbyte* Target
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Target;
            }
            else
            {
                return ref _value64.Target;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    [UnscopedRef]
    public ref sbyte* Source
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Source;
            }
            else
            {
                return ref _value64.Source;
            }
        }
    }

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

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Flags;
            }
            else
            {
                return ref _value64.Flags;
            }
        }
    }
}
