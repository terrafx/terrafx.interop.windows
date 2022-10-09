// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D3D12_BARRIER_SUBRESOURCE_RANGE
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

    public D3D12_BARRIER_SUBRESOURCE_RANGE(uint FirstMipLevel, uint NumMips, uint FirstArraySlice, uint NumArraySlices, uint FirstPlane = 0, uint NumPlanes = 1)
    {
        IndexOrFirstMipLevel = FirstMipLevel;
        NumMipLevels = NumMips;
        this.FirstArraySlice = FirstArraySlice;
        this.NumArraySlices = NumArraySlices;
        this.FirstPlane = FirstPlane;
        this.NumPlanes = NumPlanes;
    }
}
