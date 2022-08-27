// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_ORIGINAL_FILE_INFO_W
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_ORIGINAL_FILE_INFO32_W));
            }
            else
            {
                return (uint)(sizeof(SP_ORIGINAL_FILE_INFO64_W));
            }
        }
    }

    [FieldOffset(0)]
    public SP_ORIGINAL_FILE_INFO32_W _value32;

    [FieldOffset(0)]
    public SP_ORIGINAL_FILE_INFO64_W _value64;

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

    [NativeTypeName("WCHAR [260]")]
    public Span<ushort> OriginalInfName
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.OriginalInfName[0], 260);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.OriginalInfName[0], 260);
            }
        }
    }

    [NativeTypeName("WCHAR [260]")]
    public Span<ushort> OriginalCatalogName
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.OriginalCatalogName[0], 260);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.OriginalCatalogName[0], 260);
            }
        }
    }
}
