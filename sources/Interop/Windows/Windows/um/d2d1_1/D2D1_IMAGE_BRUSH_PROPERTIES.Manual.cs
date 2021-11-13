// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.Windows;
using static TerraFX.Interop.Windows.D2D1_EXTEND_MODE;
using static TerraFX.Interop.Windows.D2D1_INTERPOLATION_MODE;

namespace TerraFX.Interop.Windows
{
    public partial struct D2D1_IMAGE_BRUSH_PROPERTIES
    {
        public D2D1_IMAGE_BRUSH_PROPERTIES([NativeTypeName("D2D1_RECT_F")] D2D_RECT_F sourceRectangle, D2D1_EXTEND_MODE extendModeX = D2D1_EXTEND_MODE_CLAMP, D2D1_EXTEND_MODE extendModeY = D2D1_EXTEND_MODE_CLAMP, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR)
        {
            this = ImageBrushProperties(sourceRectangle, extendModeX, extendModeY, interpolationMode);
        }
    }
}
