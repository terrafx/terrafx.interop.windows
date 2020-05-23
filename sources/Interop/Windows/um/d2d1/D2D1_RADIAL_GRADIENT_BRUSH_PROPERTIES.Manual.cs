// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D2D1;

namespace TerraFX.Interop
{
    public partial struct D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES
    {
        public D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES([NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F center, [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F gradientOriginOffset, [NativeTypeName("FLOAT")] float radiusX, [NativeTypeName("FLOAT")] float radiusY)
        {
            this = RadialGradientBrushProperties(center, gradientOriginOffset, radiusX, radiusY);
        }
    }
}
