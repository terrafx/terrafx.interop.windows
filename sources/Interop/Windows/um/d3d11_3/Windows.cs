// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Texture2D1 = new Guid(0x51218251, 0x1E33, 0x4617, 0x9C, 0xCB, 0x4D, 0x3A, 0x43, 0x67, 0xE7, 0xBB);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Texture3D1 = new Guid(0x0C711683, 0x2853, 0x4846, 0x9B, 0xB0, 0xF3, 0xE6, 0x06, 0x39, 0xE4, 0x6A);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11RasterizerState2 = new Guid(0x6fbd02fb, 0x209f, 0x46c4, 0xb0, 0x59, 0x2e, 0xd1, 0x55, 0x86, 0xa6, 0xac);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11ShaderResourceView1 = new Guid(0x91308b87, 0x9040, 0x411d, 0x8c, 0x67, 0xc3, 0x92, 0x53, 0xce, 0x38, 0x02);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11RenderTargetView1 = new Guid(0xffbe2e23, 0xf011, 0x418a, 0xac, 0x56, 0x5c, 0xee, 0xd7, 0xc5, 0xb9, 0x4b);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11UnorderedAccessView1 = new Guid(0x7b3b6153, 0xa886, 0x4544, 0xab, 0x37, 0x65, 0x37, 0xc8, 0x50, 0x04, 0x03);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Query1 = new Guid(0x631b4766, 0x36dc, 0x461d, 0x8d, 0xb6, 0xc4, 0x7e, 0x13, 0xe6, 0x09, 0x16);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11DeviceContext3 = new Guid(0xb4e3c01d, 0xe79e, 0x4637, 0x91, 0xb2, 0x51, 0x0e, 0x9f, 0x4c, 0x9b, 0x8f);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Fence = new Guid(0xaffde9d1, 0x1df7, 0x4bb7, 0x8a, 0x34, 0x0f, 0x46, 0x25, 0x1d, 0xab, 0x80);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11DeviceContext4 = new Guid(0x917600da, 0xf58c, 0x4c33, 0x98, 0xd8, 0x3e, 0x15, 0xb3, 0x90, 0xfa, 0x24);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Device3 = new Guid(0xA05C8C37, 0xD2C6, 0x4732, 0xB3, 0xA0, 0x9C, 0xE0, 0xB0, 0xDC, 0x9A, 0xE6);
    }
}
