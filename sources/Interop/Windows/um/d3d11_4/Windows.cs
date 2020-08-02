// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Device4 = new Guid(0x8992ab71, 0x02e6, 0x4b8d, 0xba, 0x48, 0xb0, 0x56, 0xdc, 0xda, 0x42, 0xc4);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Device5 = new Guid(0x8ffde202, 0xa0e7, 0x45df, 0x9e, 0x01, 0xe8, 0x37, 0x80, 0x1b, 0x5e, 0xa0);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Multithread = new Guid(0x9B7E4E00, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11VideoContext2 = new Guid(0xC4E7374C, 0x6243, 0x4D1B, 0xAE, 0x87, 0x52, 0xB4, 0xF7, 0x40, 0xE2, 0x61);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11VideoDevice2 = new Guid(0x59C0CB01, 0x35F0, 0x4A70, 0x8F, 0x67, 0x87, 0x90, 0x5C, 0x90, 0x6A, 0x53);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11VideoContext3 = new Guid(0xA9E2FAA0, 0xCB39, 0x418F, 0xA0, 0xB7, 0xD8, 0xAA, 0xD4, 0xDE, 0x67, 0x2E);
    }
}
