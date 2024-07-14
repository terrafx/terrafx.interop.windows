// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D3D12_SUBRESOURCE_RANGE_UINT64
{
    public D3D12_SUBRESOURCE_RANGE_UINT64(uint subresource, [NativeTypeName("const D3D12_RANGE_UINT64 &")] in D3D12_RANGE_UINT64 range)
    {
        Subresource = subresource;
        Range = range;
    }
}
