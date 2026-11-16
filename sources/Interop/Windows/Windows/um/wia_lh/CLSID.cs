// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_WiaDevMgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x26, 0xE7, 0xF4, 0xA1,
                0xF1, 0x8C,
                0xD1, 0x11,
                0xBF,
                0x92,
                0x00,
                0x60,
                0x08,
                0x1E,
                0xD8,
                0x11
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_WiaDevMgr2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xBC, 0x92, 0xC2, 0xB6,
                0x88, 0x7C,
                0xEE, 0x41,
                0x8B,
                0x54,
                0x8E,
                0xC9,
                0x26,
                0x17,
                0xE5,
                0x99
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_WiaLog
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x57, 0x53, 0xE7, 0xA1,
                0x1A, 0x88,
                0x9E, 0x41,
                0x83,
                0xE2,
                0xBB,
                0x16,
                0xDB,
                0x19,
                0x7C,
                0x68
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
