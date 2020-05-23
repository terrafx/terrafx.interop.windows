// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows;
using static TerraFX.Interop.D2D1_CAP_STYLE;
using static TerraFX.Interop.D2D1_DASH_STYLE;
using static TerraFX.Interop.D2D1_LINE_JOIN;
using static TerraFX.Interop.D2D1_STROKE_TRANSFORM_TYPE;

namespace TerraFX.Interop
{
    public partial struct D2D1_STROKE_STYLE_PROPERTIES1
    {
        public static readonly D2D1_STROKE_STYLE_PROPERTIES1 DEFAULT = new D2D1_STROKE_STYLE_PROPERTIES1(D2D1_CAP_STYLE_FLAT, D2D1_CAP_STYLE_FLAT, D2D1_CAP_STYLE_FLAT, D2D1_LINE_JOIN_MITER, 10.0f, D2D1_DASH_STYLE_SOLID, 0.0f, D2D1_STROKE_TRANSFORM_TYPE_NORMAL);

        public D2D1_STROKE_STYLE_PROPERTIES1(D2D1_CAP_STYLE startCap = D2D1_CAP_STYLE_FLAT, D2D1_CAP_STYLE endCap = D2D1_CAP_STYLE_FLAT, D2D1_CAP_STYLE dashCap = D2D1_CAP_STYLE_FLAT, D2D1_LINE_JOIN lineJoin = D2D1_LINE_JOIN_MITER, [NativeTypeName("FLOAT")] float miterLimit = 10.0f, D2D1_DASH_STYLE dashStyle = D2D1_DASH_STYLE_SOLID, [NativeTypeName("FLOAT")] float dashOffset = 0.0f, D2D1_STROKE_TRANSFORM_TYPE transformType = D2D1_STROKE_TRANSFORM_TYPE_NORMAL)
        {
            this = StrokeStyleProperties1(startCap, endCap, dashCap, lineJoin, miterLimit, dashStyle, dashOffset, transformType);
        }
    }
}
