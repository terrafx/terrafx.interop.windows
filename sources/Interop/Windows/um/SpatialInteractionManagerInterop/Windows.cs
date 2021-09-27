// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialInteractionManagerInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static ref readonly Guid IID_ISpatialInteractionManagerInterop
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x36, 0xE5, 0x4E, 0x5C,
                    0x98, 0x6A,
                    0x86, 0x4B,
                    0xA1,
                    0x70,
                    0x58,
                    0x70,
                    0x13,
                    0xD6,
                    0xFD,
                    0x4B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
