// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.DirectX.D2D1_LAYER_OPTIONS1;
using static TerraFX.Interop.DirectX.DirectX;

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D2D1_LAYER_PARAMETERS1
{
    public static ref readonly D2D1_LAYER_PARAMETERS1 DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data;

            if (Environment.Is64BitProcess)
            {
                data = [
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
                ];
            }
            else
            {
                data = [
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
                ];
            }

            Debug.Assert(data.Length == Unsafe.SizeOf<D2D1_LAYER_PARAMETERS1>());
            return ref Unsafe.As<byte, D2D1_LAYER_PARAMETERS1>(ref MemoryMarshal.GetReference(data));
        }
    }

    public D2D1_LAYER_PARAMETERS1([Optional] ID2D1Geometry* geometricMask, [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode, float opacity = 1.0f, ID2D1Brush* opacityBrush = null, D2D1_LAYER_OPTIONS1 layerOptions = D2D1_LAYER_OPTIONS1_NONE)
         : this(InfiniteRect, geometricMask, maskAntialiasMode, IdentityMatrix, opacity, opacityBrush, layerOptions)
    {
    }

    public D2D1_LAYER_PARAMETERS1([NativeTypeName("const D2D1_RECT_F")] in D2D_RECT_F contentBounds, [Optional] ID2D1Geometry* geometricMask, [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode, float opacity = 1.0f, ID2D1Brush* opacityBrush = null, D2D1_LAYER_OPTIONS1 layerOptions = D2D1_LAYER_OPTIONS1_NONE)
        : this(contentBounds, geometricMask, maskAntialiasMode, IdentityMatrix, opacity, opacityBrush, layerOptions)
    {
    }

    public D2D1_LAYER_PARAMETERS1([Optional] ID2D1Geometry* geometricMask, [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F maskTransform, float opacity = 1.0f, ID2D1Brush* opacityBrush = null, D2D1_LAYER_OPTIONS1 layerOptions = D2D1_LAYER_OPTIONS1_NONE)
        : this(InfiniteRect, geometricMask, maskAntialiasMode, maskTransform, opacity, opacityBrush, layerOptions)
    {
    }

    public D2D1_LAYER_PARAMETERS1([NativeTypeName("const D2D1_RECT_F")] in D2D_RECT_F contentBounds, [Optional] ID2D1Geometry* geometricMask, [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F maskTransform, float opacity = 1.0f, ID2D1Brush* opacityBrush = null, D2D1_LAYER_OPTIONS1 layerOptions = D2D1_LAYER_OPTIONS1_NONE)
    {
        this = LayerParameters1(contentBounds, geometricMask, maskAntialiasMode, maskTransform, opacity, opacityBrush, layerOptions);
    }
}
