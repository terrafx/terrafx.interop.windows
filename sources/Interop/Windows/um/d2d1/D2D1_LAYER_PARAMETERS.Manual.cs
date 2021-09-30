// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_LAYER_OPTIONS;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public unsafe partial struct D2D1_LAYER_PARAMETERS
    {
        public static ref readonly D2D1_LAYER_PARAMETERS DEFAULT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data;

                if (Environment.Is64BitProcess)
                {
                    data = new byte[] {
                        0xFF, 0xFF, 0x7F, 0xFF,
                        0xFF, 0xFF, 0x7F, 0xFF,
                        0xFF, 0xFF, 0x7F, 0x7F,
                        0xFF, 0xFF, 0x7F, 0x7F,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x80, 0x3F,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x80, 0x3F,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x80, 0x3F,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00
                    };
                }
                else
                {
                    data = new byte[] {
                        0xFF, 0xFF, 0x7F, 0xFF,
                        0xFF, 0xFF, 0x7F, 0xFF,
                        0xFF, 0xFF, 0x7F, 0x7F,
                        0xFF, 0xFF, 0x7F, 0x7F,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x80, 0x3F,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x80, 0x3F,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x80, 0x3F,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00
                    };
                }

                Debug.Assert(data.Length == Unsafe.SizeOf<D2D1_LAYER_PARAMETERS>());
                return ref Unsafe.As<byte, D2D1_LAYER_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public D2D1_LAYER_PARAMETERS([NativeTypeName("ID2D1Geometry *"), Optional] ID2D1Geometry* geometricMask, [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode, [NativeTypeName("FLOAT")] float opacity = 1.0f, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* opacityBrush = null, D2D1_LAYER_OPTIONS layerOptions = D2D1_LAYER_OPTIONS_NONE)
             : this(InfiniteRect, geometricMask, maskAntialiasMode, IdentityMatrix, opacity, opacityBrush, layerOptions)
        {
        }

        public D2D1_LAYER_PARAMETERS([NativeTypeName("const D2D1_RECT_F")] in D2D_RECT_F contentBounds, [NativeTypeName("ID2D1Geometry *"), Optional] ID2D1Geometry* geometricMask, [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode, [NativeTypeName("FLOAT")] float opacity = 1.0f, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* opacityBrush = null, D2D1_LAYER_OPTIONS layerOptions = D2D1_LAYER_OPTIONS_NONE)
            : this(contentBounds, geometricMask, maskAntialiasMode, IdentityMatrix, opacity, opacityBrush, layerOptions)
        {
        }

        public D2D1_LAYER_PARAMETERS([NativeTypeName("ID2D1Geometry *"), Optional] ID2D1Geometry* geometricMask, [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F maskTransform, [NativeTypeName("FLOAT")] float opacity = 1.0f, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* opacityBrush = null, D2D1_LAYER_OPTIONS layerOptions = D2D1_LAYER_OPTIONS_NONE)
            : this(InfiniteRect, geometricMask, maskAntialiasMode, maskTransform, opacity, opacityBrush, layerOptions)
        {
        }

        public D2D1_LAYER_PARAMETERS([NativeTypeName("const D2D1_RECT_F")] in D2D_RECT_F contentBounds, [NativeTypeName("ID2D1Geometry *"), Optional] ID2D1Geometry* geometricMask, [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F maskTransform, [NativeTypeName("FLOAT")] float opacity = 1.0f, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* opacityBrush = null, D2D1_LAYER_OPTIONS layerOptions = D2D1_LAYER_OPTIONS_NONE)
        {
            this = LayerParameters(contentBounds, geometricMask, maskAntialiasMode, maskTransform, opacity, opacityBrush, layerOptions);
        }
    }
}
