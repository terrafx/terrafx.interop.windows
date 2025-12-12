// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_barriers.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_BARRIER_SUBRESOURCE_RANGE.xml' path='doc/member[@name="D3D12_BARRIER_SUBRESOURCE_RANGE"]/*' />
[NativeTypeName("struct CD3DX12_BARRIER_SUBRESOURCE_RANGE : D3D12_BARRIER_SUBRESOURCE_RANGE")]
[NativeInheritance("D3D12_BARRIER_SUBRESOURCE_RANGE")]
public partial struct D3D12_BARRIER_SUBRESOURCE_RANGE
{
    public D3D12_BARRIER_SUBRESOURCE_RANGE(uint Subresource)
    {
        IndexOrFirstMipLevel = Subresource;
        NumMipLevels = 0;
        FirstArraySlice = 0;
        NumArraySlices = 0;
        FirstPlane = 0;
        NumPlanes = 0;
    }

    public D3D12_BARRIER_SUBRESOURCE_RANGE(uint firstMipLevel, uint numMips, uint firstArraySlice, uint numArraySlices, uint firstPlane = 0, uint numPlanes = 1)
    {
        IndexOrFirstMipLevel = firstMipLevel;
        NumMipLevels = numMips;
        FirstArraySlice = firstArraySlice;
        NumArraySlices = numArraySlices;
        FirstPlane = firstPlane;
        NumPlanes = numPlanes;
    }
}
