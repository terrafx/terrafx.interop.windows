// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Extended bitmap properties.</summary>
    public unsafe partial struct D2D1_BITMAP_PROPERTIES1
    {
        public D2D1_PIXEL_FORMAT pixelFormat;

        [NativeTypeName("FLOAT")]
        public float dpiX;

        [NativeTypeName("FLOAT")]
        public float dpiY;

        /// <summary>Specifies how the bitmap can be used.</summary>
        public D2D1_BITMAP_OPTIONS bitmapOptions;

        public ID2D1ColorContext* colorContext;
    }
}
