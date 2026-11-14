// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h and um/imapi2.idl in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class LIBID
{
    public static ref readonly Guid LIBID_IMAPI2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x2F, 0x41, 0x35, 0x27,
                0x64, 0x7F,
                0x0F, 0x5B,
                0x8F,
                0x00,
                0x5D,
                0x77,
                0xAF,
                0xBE,
                0x26,
                0x1E
            ];

            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid LIBID_IMAPILib2 => ref LIBID_IMAPI2;
}
