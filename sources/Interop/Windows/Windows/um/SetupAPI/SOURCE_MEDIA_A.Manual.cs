// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SOURCE_MEDIA_A
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SOURCE_MEDIA32_A));
            }
            else
            {
                return (uint)(sizeof(SOURCE_MEDIA64_A));
            }
        }
    }

    [FieldOffset(0)]
    public SOURCE_MEDIA32_A _value32;

    [FieldOffset(0)]
    public SOURCE_MEDIA64_A _value64;

    [NativeTypeName("PCSTR")]
    [UnscopedRef]
    public ref sbyte* Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Reserved;
            }
            else
            {
                return ref _value64.Reserved;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    [UnscopedRef]
    public ref sbyte* Tagfile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Tagfile;
            }
            else
            {
                return ref _value64.Tagfile;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    [UnscopedRef]
    public ref sbyte* Description
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.Description;
            }
            else
            {
                return ref _value64.Description;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    [UnscopedRef]
    public ref sbyte* SourcePath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.SourcePath;
            }
            else
            {
                return ref _value64.SourcePath;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    [UnscopedRef]
    public ref sbyte* SourceFile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.SourceFile;
            }
            else
            {
                return ref _value64.SourceFile;
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
