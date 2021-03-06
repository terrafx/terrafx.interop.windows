// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D1_BITMAP_BRUSH_PROPERTIES1
    {
        public D2D1_EXTEND_MODE extendModeX;

        public D2D1_EXTEND_MODE extendModeY;

        public D2D1_INTERPOLATION_MODE interpolationMode;
    }
}
