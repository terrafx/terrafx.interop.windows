// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D2D1_BITMAP_PROPERTIES1
    {
        public static readonly D2D1_BITMAP_PROPERTIES1 DEFAULT = new D2D1_BITMAP_PROPERTIES1(D2D1_BITMAP_OPTIONS.D2D1_BITMAP_OPTIONS_NONE, D2D1_PIXEL_FORMAT.DEFAULT, 96.0f, 96.0f, null);

        public D2D1_BITMAP_PROPERTIES1(D2D1_BITMAP_OPTIONS bitmapOptions, D2D1_PIXEL_FORMAT pixelFormat, float dpiX, float dpiY, ID2D1ColorContext* colorContext)
        {
            this.bitmapOptions = bitmapOptions;
            this.pixelFormat = pixelFormat;
            this.dpiX = dpiX;
            this.dpiY = dpiY;
            this.colorContext = colorContext;
        }
    }
}
