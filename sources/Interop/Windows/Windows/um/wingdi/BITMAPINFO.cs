// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct BITMAPINFO
    {
        public BITMAPINFOHEADER bmiHeader;

        [NativeTypeName("RGBQUAD [1]")]
        public _bmiColors_e__FixedBuffer bmiColors;

        public partial struct _bmiColors_e__FixedBuffer
        {
            public RGBQUAD e0;

            public ref RGBQUAD this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<RGBQUAD> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
