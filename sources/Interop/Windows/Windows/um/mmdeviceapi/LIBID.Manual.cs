// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class LIBID
{
    public static ref readonly Guid LIBID_MMDeviceAPILib
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                    0xA3, 0xAF, 0xDA, 0x2F,
                    0x23, 0x75,
                    0x66, 0x4F,
                    0x99,
                    0x57,
                    0x9D,
                    0x5E,
                    0x7F,
                    0xE6,
                    0x98,
                    0xF6
                };

            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
