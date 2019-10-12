// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d11.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D11_SHADER_RESOURCE_VIEW_DESC
    {
        public DXGI_FORMAT Format;

        [NativeTypeName("D3D11_SRV_DIMENSION")]
        public D3D_SRV_DIMENSION ViewDimension;

        [NativeTypeName("struct (anonymous struct at um/d3d11.h:3392:5)")]
        public _Anonymous_e__Struct Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Struct
        {
            [FieldOffset(0)]
            public D3D11_BUFFER_SRV Buffer;

            [FieldOffset(0)]
            public D3D11_TEX1D_SRV Texture1D;

            [FieldOffset(0)]
            public D3D11_TEX1D_ARRAY_SRV Texture1DArray;

            [FieldOffset(0)]
            public D3D11_TEX2D_SRV Texture2D;

            [FieldOffset(0)]
            public D3D11_TEX2D_ARRAY_SRV Texture2DArray;

            [FieldOffset(0)]
            public D3D11_TEX2DMS_SRV Texture2DMS;

            [FieldOffset(0)]
            public D3D11_TEX2DMS_ARRAY_SRV Texture2DMSArray;

            [FieldOffset(0)]
            public D3D11_TEX3D_SRV Texture3D;

            [FieldOffset(0)]
            public D3D11_TEXCUBE_SRV TextureCube;

            [FieldOffset(0)]
            public D3D11_TEXCUBE_ARRAY_SRV TextureCubeArray;

            [FieldOffset(0)]
            public D3D11_BUFFEREX_SRV BufferEx;
        }
    }
}
