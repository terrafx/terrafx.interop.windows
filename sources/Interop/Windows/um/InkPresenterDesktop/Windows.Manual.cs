// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InkPresenterDesktop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static ref Guid LIBID_InkDesktopHostLib
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x67, 0x09, 0xEF, 0x2A,
                    0x33, 0xC8,
                    0x38, 0x4F,
                    0x91,
                    0xF3,
                    0x16,
                    0xE6,
                    0x7D,
                    0x55,
                    0xD7,
                    0x17
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
