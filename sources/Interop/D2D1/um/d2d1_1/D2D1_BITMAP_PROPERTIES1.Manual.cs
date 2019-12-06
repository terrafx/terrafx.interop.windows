// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D2D1;
using static TerraFX.Interop.D2D1_BITMAP_OPTIONS;

namespace TerraFX.Interop
{
    public unsafe partial struct D2D1_BITMAP_PROPERTIES1
    {
        public static readonly D2D1_BITMAP_PROPERTIES1 DEFAULT = new D2D1_BITMAP_PROPERTIES1(D2D1_BITMAP_OPTIONS_NONE, default, 96.0f, 96.0f, null);

        public D2D1_BITMAP_PROPERTIES1(D2D1_BITMAP_OPTIONS bitmapOptions = D2D1_BITMAP_OPTIONS_NONE, [NativeTypeName("const D2D1_PIXEL_FORMAT")] D2D1_PIXEL_FORMAT pixelFormat = default, [NativeTypeName("FLOAT")] float dpiX = 96.0f, [NativeTypeName("FLOAT")] float dpiY = 96.0f, ID2D1ColorContext* colorContext = null)
        {
            this = BitmapProperties1(bitmapOptions, pixelFormat, dpiX, dpiY, colorContext);
        }
    }
}
