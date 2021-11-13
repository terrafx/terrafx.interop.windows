// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid LIBID_MSAATEXTLib
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7A, 0x2D, 0x0E, 0x15,
                    0xC1, 0xDA,
                    0x82, 0x45,
                    0x94,
                    0x7D,
                    0x2A,
                    0x8F,
                    0xD7,
                    0x8B,
                    0x82,
                    0xCD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("#define TS_STRF_START ( 0 )")]
        public const int TS_STRF_START = (0);

        [NativeTypeName("#define TS_STRF_MID ( 1 )")]
        public const int TS_STRF_MID = (1);

        [NativeTypeName("#define TS_STRF_END ( 2 )")]
        public const int TS_STRF_END = (2);
    }
}
