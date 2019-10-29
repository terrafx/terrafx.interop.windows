// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D1_ROUNDED_RECT
    {
        public D2D1_ROUNDED_RECT(in D2D_RECT_F rect, float radiusX, float radiusY)
        {
            this.rect = rect;
            this.radiusX = radiusX;
            this.radiusY = radiusY;
        }
    }
}
