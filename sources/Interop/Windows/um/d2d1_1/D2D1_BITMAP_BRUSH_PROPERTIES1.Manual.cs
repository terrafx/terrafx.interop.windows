// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;
using static TerraFX.Interop.D2D1_EXTEND_MODE;
using static TerraFX.Interop.D2D1_INTERPOLATION_MODE;

namespace TerraFX.Interop
{
    public partial struct D2D1_BITMAP_BRUSH_PROPERTIES1
    {
        public static ref readonly D2D1_BITMAP_BRUSH_PROPERTIES1 DEFAULT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<D2D1_BITMAP_BRUSH_PROPERTIES1>());
                return ref Unsafe.As<byte, D2D1_BITMAP_BRUSH_PROPERTIES1>(ref MemoryMarshal.GetReference(data));
            }
        }

        public D2D1_BITMAP_BRUSH_PROPERTIES1(D2D1_EXTEND_MODE extendModeX = D2D1_EXTEND_MODE_CLAMP, D2D1_EXTEND_MODE extendModeY = D2D1_EXTEND_MODE_CLAMP, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR)
        {
            this = BitmapBrushProperties1(extendModeX, extendModeY, interpolationMode);
        }
    }
}
