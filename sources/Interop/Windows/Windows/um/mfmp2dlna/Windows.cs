// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmp2dlna.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MPEG2DLNASink
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC5, 0xE7, 0x5F, 0xFA,
                    0x1D, 0x6A,
                    0x11, 0x4B,
                    0xB4,
                    0x1F,
                    0xF9,
                    0x59,
                    0xD6,
                    0xC7,
                    0x65,
                    0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFDLNASinkInit
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x99, 0x27, 0x01, 0x0C,
                    0x61, 0x1B,
                    0x10, 0x4C,
                    0xBD,
                    0xA9,
                    0x04,
                    0x44,
                    0x5B,
                    0xE5,
                    0xF5,
                    0x61
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
