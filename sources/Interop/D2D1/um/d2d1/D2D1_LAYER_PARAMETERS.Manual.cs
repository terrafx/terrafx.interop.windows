// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D2D1_LAYER_PARAMETERS
    {
        public static readonly D2D1_LAYER_PARAMETERS DEFAULT = new D2D1_LAYER_PARAMETERS(D2D_RECT_F.Infinite, null, D2D1_ANTIALIAS_MODE.D2D1_ANTIALIAS_MODE_PER_PRIMITIVE, D2D_MATRIX_3X2_F.Identity, 1.0f, null, D2D1_LAYER_OPTIONS.D2D1_LAYER_OPTIONS_NONE);

        public D2D1_LAYER_PARAMETERS(D2D_RECT_F contentBounds, ID2D1Geometry* geometricMask, D2D1_ANTIALIAS_MODE maskAntialiasMode, D2D_MATRIX_3X2_F maskTransform, float opacity, ID2D1Brush* opacityBrush, D2D1_LAYER_OPTIONS layerOptions)
        {
            this.contentBounds = contentBounds;
            this.geometricMask = geometricMask;
            this.maskAntialiasMode = maskAntialiasMode;
            this.maskTransform = maskTransform;
            this.opacity = opacity;
            this.opacityBrush = opacityBrush;
            this.layerOptions = layerOptions;
        }
    }
}
