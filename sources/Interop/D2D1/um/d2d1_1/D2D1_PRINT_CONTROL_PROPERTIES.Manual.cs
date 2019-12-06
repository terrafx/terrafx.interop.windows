// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D1_PRINT_CONTROL_PROPERTIES
    {
        public static readonly D2D1_PRINT_CONTROL_PROPERTIES DEFAULT = new D2D1_PRINT_CONTROL_PROPERTIES(D2D1_PRINT_FONT_SUBSET_MODE.D2D1_PRINT_FONT_SUBSET_MODE_DEFAULT, 150.0f, D2D1_COLOR_SPACE.D2D1_COLOR_SPACE_SRGB);

        public D2D1_PRINT_CONTROL_PROPERTIES(D2D1_PRINT_FONT_SUBSET_MODE fontSubset, float rasterDpi, D2D1_COLOR_SPACE colorSpace)
        {
            this.fontSubset = fontSubset;
            rasterDPI = rasterDpi;
            this.colorSpace = colorSpace;
        }
    }
}
