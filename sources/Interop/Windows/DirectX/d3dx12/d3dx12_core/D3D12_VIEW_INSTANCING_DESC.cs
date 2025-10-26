// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIEW_INSTANCING_DESC.xml' path='doc/member[@name="D3D12_VIEW_INSTANCING_DESC"]/*' />
[NativeTypeName("struct CD3DX12_VIEW_INSTANCING_DESC : D3D12_VIEW_INSTANCING_DESC")]
[NativeInheritance("D3D12_VIEW_INSTANCING_DESC")]
public unsafe partial struct D3D12_VIEW_INSTANCING_DESC
{
    public D3D12_VIEW_INSTANCING_DESC(uint InViewInstanceCount, [NativeTypeName("const D3D12_VIEW_INSTANCE_LOCATION *")] D3D12_VIEW_INSTANCE_LOCATION* InViewInstanceLocations, D3D12_VIEW_INSTANCING_FLAGS InFlags)
    {
        ViewInstanceCount = InViewInstanceCount;
        pViewInstanceLocations = InViewInstanceLocations;
        Flags = InFlags;
    }
}
