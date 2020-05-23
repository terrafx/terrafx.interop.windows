// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D12_DEPTH_STENCIL_VIEW_DESC
    {
        public DXGI_FORMAT Format;

        public D3D12_DSV_DIMENSION ViewDimension;

        public D3D12_DSV_FLAGS Flags;

        [NativeTypeName("D3D12_DEPTH_STENCIL_VIEW_DESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d12.h:3333:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public D3D12_TEX1D_DSV Texture1D;

            [FieldOffset(0)]
            public D3D12_TEX1D_ARRAY_DSV Texture1DArray;

            [FieldOffset(0)]
            public D3D12_TEX2D_DSV Texture2D;

            [FieldOffset(0)]
            public D3D12_TEX2D_ARRAY_DSV Texture2DArray;

            [FieldOffset(0)]
            public D3D12_TEX2DMS_DSV Texture2DMS;

            [FieldOffset(0)]
            public D3D12_TEX2DMS_ARRAY_DSV Texture2DMSArray;
        }
    }
}
