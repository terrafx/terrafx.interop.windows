// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.media.core.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid CLSID_AudioFrameNativeFactory = new Guid(0x16A0A3B9, 0x9F65, 0x4102, 0x93, 0x67, 0x2C, 0xDA, 0x3A, 0x4F, 0x37, 0x2A);

        public static readonly Guid CLSID_VideoFrameNativeFactory = new Guid(0xD194386A, 0x04E3, 0x4814, 0x81, 0x00, 0xB2, 0xB0, 0xAE, 0x6D, 0x78, 0xC7);

        public static readonly Guid IID_IAudioFrameNative = new Guid(0x20BE1E2E, 0x930F, 0x4746, 0x93, 0x35, 0x3C, 0x33, 0x2F, 0x25, 0x50, 0x93);
       
        public static readonly Guid IID_IAudioFrameNativeFactory = new Guid(0x7BD67CF8, 0xBF7D, 0x43E6, 0xAF, 0x8D, 0xB1, 0x70, 0xEE, 0x0C, 0x01, 0x10);

        public static readonly Guid IID_IVideoFrameNative = new Guid(0x26BA702B, 0x314A, 0x4620, 0xAA, 0xF6, 0x7A, 0x51, 0xAA, 0x58, 0xFA, 0x18);

        public static readonly Guid IID_IVideoFrameNativeFactory = new Guid(0x69E3693E, 0x8E1E, 0x4E63, 0xAC, 0x4C, 0x7F, 0xDC, 0x21, 0xD9, 0x73, 0x1D);
    }
}
