// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_BACKUP_QUEUE_PARAMS_V1_A
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_BACKUP_QUEUE_PARAMS32_V1_A));
            }
            else
            {
                return (uint)(sizeof(SP_BACKUP_QUEUE_PARAMS64_V1_A));
            }
        }
    }

    [FieldOffset(0)]
    public SP_BACKUP_QUEUE_PARAMS32_V1_A _value32;

    [FieldOffset(0)]
    public SP_BACKUP_QUEUE_PARAMS64_V1_A _value64;

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

    [NativeTypeName("CHAR [260]")]
    public Span<sbyte> FullInfPath
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.FullInfPath[0], 260);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.FullInfPath[0], 260);
            }
        }
    }

    [UnscopedRef]
    public ref int FilenameOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.FilenameOffset;
            }
            else
            {
                return ref _value64.FilenameOffset;
            }
        }
    }
}
