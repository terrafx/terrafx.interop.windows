// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct BITMAPCOREINFO
    {
        public BITMAPCOREHEADER bmciHeader;

        [NativeTypeName("RGBTRIPLE [1]")]
        public _bmciColors_e__FixedBuffer bmciColors;

        public partial struct _bmciColors_e__FixedBuffer
        {
            public RGBTRIPLE e0;

            public unsafe ref RGBTRIPLE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<RGBTRIPLE> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<RGBTRIPLE>((RGBTRIPLE*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
