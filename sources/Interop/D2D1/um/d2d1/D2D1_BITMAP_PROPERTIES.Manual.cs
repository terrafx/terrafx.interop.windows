// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D1_BITMAP_PROPERTIES
    {
        public static readonly D2D1_BITMAP_PROPERTIES DEFAULT = new D2D1_BITMAP_PROPERTIES(D2D1_PIXEL_FORMAT.DEFAULT, 96.0f, 96.0f);

        public D2D1_BITMAP_PROPERTIES(D2D1_PIXEL_FORMAT pixelFormat, float dpiX, float dpiY)
        {
            this.pixelFormat = pixelFormat;
            this.dpiX = dpiX;
            this.dpiY = dpiY;
        }
    }
}
