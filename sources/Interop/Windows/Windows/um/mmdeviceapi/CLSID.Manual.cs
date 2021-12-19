// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class CLSID
{
    public static ref readonly Guid CLSID_MMDeviceEnumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                    0x95, 0x03, 0xDE, 0xBC,
                    0x2F, 0xE5,
                    0x7C, 0x46,
                    0x8E,
                    0x3D,
                    0xC4,
                    0x57,
                    0x92,
                    0x91,
                    0x69,
                    0x2E
                };

            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
