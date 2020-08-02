// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid DXGI_DEBUG_D3D11 = new Guid(0x4b99317b, 0xac39, 0x4aa6, 0xbb, 0xb, 0xba, 0xa0, 0x47, 0x84, 0x79, 0x8f);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Debug = new Guid(0x79cf2233, 0x7536, 0x4948, 0x9d, 0x36, 0x1e, 0x46, 0x92, 0xdc, 0x57, 0x60);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11SwitchToRef = new Guid(0x1ef337e3, 0x58e7, 0x4f83, 0xa6, 0x92, 0xdb, 0x22, 0x1f, 0x5e, 0xd4, 0x7e);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11TracingDevice = new Guid(0x1911c771, 0x1587, 0x413e, 0xa7, 0xe0, 0xfb, 0x26, 0xc3, 0xde, 0x02, 0x68);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11RefTrackingOptions = new Guid(0x193dacdf, 0x0db2, 0x4c05, 0xa5, 0x5c, 0xef, 0x06, 0xca, 0xc5, 0x6f, 0xd9);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11RefDefaultTrackingOptions = new Guid(0x03916615, 0xc644, 0x418c, 0x9b, 0xf4, 0x75, 0xdb, 0x5b, 0xe6, 0x3c, 0xa0);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11InfoQueue = new Guid(0x6543dbb6, 0x1b48, 0x42f5, 0xab, 0x82, 0xe9, 0x7e, 0xc7, 0x43, 0x26, 0xf6);
    }
}
