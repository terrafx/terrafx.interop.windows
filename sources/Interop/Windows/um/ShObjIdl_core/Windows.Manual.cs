// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static ref Guid CLSID_ShellLibrary
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1D, 0x21, 0xB3, 0xD9,
                    0x7F, 0xE5,
                    0x26, 0x44,
                    0xAA,
                    0xEF,
                    0x30,
                    0xA8,
                    0x06,
                    0xAD,
                    0xD3,
                    0x97
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
