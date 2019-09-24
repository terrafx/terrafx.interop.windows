// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D3D12_RESOURCE_DIMENSION;

namespace TerraFX.Interop
{
    public unsafe struct D3D12_SUBRESOURCE_FOOTPRINT
    {
        public DXGI_FORMAT Format;

        [NativeTypeName("UINT")]
        public uint Width;

        [NativeTypeName("UINT")]
        public uint Height;

        [NativeTypeName("UINT")]
        public uint Depth;

        [NativeTypeName("UINT")]
        public uint RowPitch;

        public D3D12_SUBRESOURCE_FOOTPRINT(DXGI_FORMAT format, uint width, uint height, uint depth, uint rowPitch)
        {
            Format = format;
            Width = width;
            Height = height;
            Depth = depth;
            RowPitch = rowPitch;
        }

        public D3D12_SUBRESOURCE_FOOTPRINT(D3D12_RESOURCE_DESC* resDesc, uint rowPitch)
        {
            Format = resDesc->Format;
            Width = (uint)resDesc->Width;
            Height = resDesc->Height;
            Depth = resDesc->Dimension == D3D12_RESOURCE_DIMENSION_TEXTURE3D ? resDesc->DepthOrArraySize : (uint)1;
            RowPitch = rowPitch;
        }
    }
}
