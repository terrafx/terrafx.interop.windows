// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1;
using static TerraFX.Interop.D2D1_ANTIALIAS_MODE;
using static TerraFX.Interop.D2D1_LAYER_OPTIONS;

namespace TerraFX.Interop
{
    public unsafe partial struct D2D1_LAYER_PARAMETERS
    {
        public static readonly D2D1_LAYER_PARAMETERS DEFAULT = new D2D1_LAYER_PARAMETERS(InfiniteRect, null, D2D1_ANTIALIAS_MODE_PER_PRIMITIVE, IdentityMatrix, 1.0f, null, D2D1_LAYER_OPTIONS_NONE);

        public D2D1_LAYER_PARAMETERS([Optional] ID2D1Geometry* geometricMask, [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode, [NativeTypeName("FLOAT")] float opacity = 1.0f, ID2D1Brush* opacityBrush = null, D2D1_LAYER_OPTIONS layerOptions = D2D1_LAYER_OPTIONS_NONE)
             : this(InfiniteRect, geometricMask, maskAntialiasMode, IdentityMatrix, opacity, opacityBrush, layerOptions)
        {
        }

        public D2D1_LAYER_PARAMETERS([NativeTypeName("const D2D1_RECT_F")] in D2D_RECT_F contentBounds, [Optional] ID2D1Geometry* geometricMask, [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode, [NativeTypeName("FLOAT")] float opacity = 1.0f, ID2D1Brush* opacityBrush = null, D2D1_LAYER_OPTIONS layerOptions = D2D1_LAYER_OPTIONS_NONE)
            : this(contentBounds, geometricMask, maskAntialiasMode, IdentityMatrix, opacity, opacityBrush, layerOptions)
        {
        }

        public D2D1_LAYER_PARAMETERS([Optional] ID2D1Geometry* geometricMask, [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F maskTransform, [NativeTypeName("FLOAT")] float opacity = 1.0f, ID2D1Brush* opacityBrush = null, D2D1_LAYER_OPTIONS layerOptions = D2D1_LAYER_OPTIONS_NONE)
            : this(InfiniteRect, geometricMask, maskAntialiasMode, maskTransform, opacity, opacityBrush, layerOptions)
        {
        }

        public D2D1_LAYER_PARAMETERS([NativeTypeName("const D2D1_RECT_F")] in D2D_RECT_F contentBounds, [Optional] ID2D1Geometry* geometricMask, [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F maskTransform, [NativeTypeName("FLOAT")] float opacity = 1.0f, ID2D1Brush* opacityBrush = null, D2D1_LAYER_OPTIONS layerOptions = D2D1_LAYER_OPTIONS_NONE)
        {
            this = LayerParameters(contentBounds, geometricMask, maskAntialiasMode, maskTransform, opacity, opacityBrush, layerOptions);
        }
    }
}
