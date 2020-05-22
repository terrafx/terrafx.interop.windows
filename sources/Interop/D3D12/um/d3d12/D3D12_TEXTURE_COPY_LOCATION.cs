// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_TEXTURE_COPY_LOCATION
    {
        [NativeTypeName("ID3D12Resource *")]
        public ID3D12Resource* pResource;

        public D3D12_TEXTURE_COPY_TYPE Type;

        [NativeTypeName("D3D12_TEXTURE_COPY_LOCATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d12.h:2685:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public D3D12_PLACED_SUBRESOURCE_FOOTPRINT PlacedFootprint;

            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint SubresourceIndex;
        }
    }
}
