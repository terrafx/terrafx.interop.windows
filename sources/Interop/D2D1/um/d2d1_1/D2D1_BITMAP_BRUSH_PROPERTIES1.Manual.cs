// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D2D1;
using static TerraFX.Interop.D2D1_EXTEND_MODE;
using static TerraFX.Interop.D2D1_INTERPOLATION_MODE;

namespace TerraFX.Interop
{
    public partial struct D2D1_BITMAP_BRUSH_PROPERTIES1
    {
        public static readonly D2D1_BITMAP_BRUSH_PROPERTIES1 DEFAULT = new D2D1_BITMAP_BRUSH_PROPERTIES1(D2D1_EXTEND_MODE_CLAMP, D2D1_EXTEND_MODE_CLAMP, D2D1_INTERPOLATION_MODE_LINEAR);

        public D2D1_BITMAP_BRUSH_PROPERTIES1(D2D1_EXTEND_MODE extendModeX = D2D1_EXTEND_MODE_CLAMP, D2D1_EXTEND_MODE extendModeY = D2D1_EXTEND_MODE_CLAMP, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR)
        {
            this = BitmapBrushProperties1(extendModeX, extendModeY, interpolationMode);
        }
    }
}
