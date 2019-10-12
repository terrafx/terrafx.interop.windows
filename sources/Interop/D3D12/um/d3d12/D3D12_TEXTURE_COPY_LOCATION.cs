// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using static TerraFX.Interop.D3D12_TEXTURE_COPY_TYPE;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_TEXTURE_COPY_LOCATION
    {
        public ID3D12Resource* pResource;

        public D3D12_TEXTURE_COPY_TYPE Type;

        public _Anonymous_e__Union Anonymous;

        public D3D12_TEXTURE_COPY_LOCATION(ID3D12Resource* pRes)
        {
            this = default;
            pResource = pRes;
        }

        public D3D12_TEXTURE_COPY_LOCATION(ID3D12Resource* pRes, D3D12_PLACED_SUBRESOURCE_FOOTPRINT* Footprint)
        {
            this = default;
            pResource = pRes;
            Type = D3D12_TEXTURE_COPY_TYPE_PLACED_FOOTPRINT;
            Anonymous.PlacedFootprint = *Footprint;
        }
        public D3D12_TEXTURE_COPY_LOCATION(ID3D12Resource* pRes, uint Sub)
        {
            this = default;
            pResource = pRes;
            Type = D3D12_TEXTURE_COPY_TYPE_SUBRESOURCE_INDEX;
            Anonymous.SubresourceIndex = Sub;
        }

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
