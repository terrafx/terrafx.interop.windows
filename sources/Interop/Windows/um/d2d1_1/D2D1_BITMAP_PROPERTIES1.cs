// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D2D1_BITMAP_PROPERTIES1
    {
        public D2D1_PIXEL_FORMAT pixelFormat;

        [NativeTypeName("FLOAT")]
        public float dpiX;

        [NativeTypeName("FLOAT")]
        public float dpiY;

        public D2D1_BITMAP_OPTIONS bitmapOptions;

        [NativeTypeName("ID2D1ColorContext *")]
        public ID2D1ColorContext* colorContext;
    }
}
