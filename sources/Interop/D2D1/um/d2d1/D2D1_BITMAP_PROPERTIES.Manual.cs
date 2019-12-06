// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D2D1;

namespace TerraFX.Interop
{
    public partial struct D2D1_BITMAP_PROPERTIES
    {
        public static readonly D2D1_BITMAP_PROPERTIES DEFAULT = new D2D1_BITMAP_PROPERTIES(default, 96.0f, 96.0f);

        public D2D1_BITMAP_PROPERTIES([NativeTypeName("const D2D1_PIXEL_FORMAT &")] in D2D1_PIXEL_FORMAT pixelFormat = default, [NativeTypeName("FLOAT")] float dpiX = 96.0f, [NativeTypeName("FLOAT")] float dpiY = 96.0f)
        {
            this = BitmapProperties(pixelFormat, dpiX, dpiY);
        }
    }
}
