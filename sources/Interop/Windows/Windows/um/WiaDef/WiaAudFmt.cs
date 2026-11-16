// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WiaDef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class WiaAudFmt
{
    /// <include file='WiaAudFmt.xml' path='doc/member[@name="WiaAudFmt.WiaAudFmt_WAV"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaAudFmt_WAV
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x46, 0xE1, 0x18, 0xF8,
                0xAF, 0x07,
                0xFF, 0x40,
                0xAE,
                0x55,
                0xBE,
                0x8F,
                0x2C,
                0x06,
                0x5D,
                0xBE
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaAudFmt.xml' path='doc/member[@name="WiaAudFmt.WiaAudFmt_MP3"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaAudFmt_MP3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xFB, 0x71, 0xBC, 0x0F,
                0xBF, 0x43,
                0xF2, 0x49,
                0x91,
                0x90,
                0xE6,
                0xFE,
                0xCF,
                0xF3,
                0x7E,
                0x54
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaAudFmt.xml' path='doc/member[@name="WiaAudFmt.WiaAudFmt_AIFF"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaAudFmt_AIFF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4F, 0xBF, 0xE2, 0x66,
                0xFC, 0xB6,
                0x3F, 0x44,
                0x94,
                0xC8,
                0x2F,
                0x33,
                0xC8,
                0xA6,
                0x5A,
                0xAF
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='WiaAudFmt.xml' path='doc/member[@name="WiaAudFmt.WiaAudFmt_WMA"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid WiaAudFmt_WMA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x13, 0x64, 0x1D, 0xD6,
                0xC2, 0x8B,
                0x8F, 0x43,
                0x93,
                0xAD,
                0x21,
                0xBD,
                0x48,
                0x4D,
                0xB6,
                0xA1
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
