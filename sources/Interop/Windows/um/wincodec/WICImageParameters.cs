// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public struct WICImageParameters
    {
        #region Fields
        public D2D1_PIXEL_FORMAT pixelFormat;

        [NativeTypeName("FLOAT")]
        public float dpiX;

        [NativeTypeName("FLOAT")]
        public float dpiY;

        [NativeTypeName("FLOAT")]
        public float Top;

        [NativeTypeName("FLOAT")]
        public float Left;

        [NativeTypeName("UINT32")]
        public uint PixelWidth;

        [NativeTypeName("UINT32")]
        public uint PixelHeight;
        #endregion
    }
}
