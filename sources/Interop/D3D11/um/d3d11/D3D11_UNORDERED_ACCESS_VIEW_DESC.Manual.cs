// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d11.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D11_UNORDERED_ACCESS_VIEW_DESC
    {
        public DXGI_FORMAT Format;

        public D3D11_UAV_DIMENSION ViewDimension;

        [NativeTypeName("struct (anonymous struct at um/d3d11.h:4650:5)")]
        public _Anonymous_e__Struct Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Struct
        {
            [FieldOffset(0)]
            public D3D11_BUFFER_UAV Buffer;

            [FieldOffset(0)]
            public D3D11_TEX1D_UAV Texture1D;

            [FieldOffset(0)]
            public D3D11_TEX1D_ARRAY_UAV Texture1DArray;

            [FieldOffset(0)]
            public D3D11_TEX2D_UAV Texture2D;

            [FieldOffset(0)]
            public D3D11_TEX2D_ARRAY_UAV Texture2DArray;

            [FieldOffset(0)]
            public D3D11_TEX3D_UAV Texture3D;
        }
    }
}
