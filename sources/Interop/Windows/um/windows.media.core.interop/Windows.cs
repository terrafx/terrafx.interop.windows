// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.media.core.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const CLSID")]
        public static readonly Guid CLSID_AudioFrameNativeFactory = new Guid(0x16a0a3b9, 0x9f65, 0x4102, 0x93, 0x67, 0x2c, 0xda, 0x3a, 0x4f, 0x37, 0x2a);

        [NativeTypeName("const CLSID")]
        public static readonly Guid CLSID_VideoFrameNativeFactory = new Guid(0xd194386a, 0x4e3, 0x4814, 0x81, 0x0, 0xb2, 0xb0, 0xae, 0x6d, 0x78, 0xc7);
    }
}
