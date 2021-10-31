// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using static TerraFX.Interop.D3D12_RESOURCE_DIMENSION;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_SUBRESOURCE_FOOTPRINT
    {
        public D3D12_SUBRESOURCE_FOOTPRINT(DXGI_FORMAT format, uint width, uint height, uint depth, uint rowPitch)
        {
            Format = format;
            Width = width;
            Height = height;
            Depth = depth;
            RowPitch = rowPitch;
        }

        public D3D12_SUBRESOURCE_FOOTPRINT([NativeTypeName("const D3D12_RESOURCE_DESC &")] in D3D12_RESOURCE_DESC resDesc, uint rowPitch)
        {
            Format = resDesc.Format;
            Width = (uint)resDesc.Width;
            Height = resDesc.Height;
            Depth = (resDesc.Dimension == D3D12_RESOURCE_DIMENSION_TEXTURE3D ? resDesc.DepthOrArraySize : 1u);
            RowPitch = rowPitch;
        }
    }
}
