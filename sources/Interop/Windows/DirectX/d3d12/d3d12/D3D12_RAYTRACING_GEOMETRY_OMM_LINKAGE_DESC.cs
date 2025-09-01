// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RAYTRACING_GEOMETRY_OMM_LINKAGE_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_OMM_LINKAGE_DESC"]/*' />
public partial struct D3D12_RAYTRACING_GEOMETRY_OMM_LINKAGE_DESC
{
    /// <include file='D3D12_RAYTRACING_GEOMETRY_OMM_LINKAGE_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_OMM_LINKAGE_DESC.OpacityMicromapIndexBuffer"]/*' />
    public D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE OpacityMicromapIndexBuffer;

    /// <include file='D3D12_RAYTRACING_GEOMETRY_OMM_LINKAGE_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_OMM_LINKAGE_DESC.OpacityMicromapIndexFormat"]/*' />
    public DXGI_FORMAT OpacityMicromapIndexFormat;

    /// <include file='D3D12_RAYTRACING_GEOMETRY_OMM_LINKAGE_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_OMM_LINKAGE_DESC.OpacityMicromapBaseLocation"]/*' />
    public uint OpacityMicromapBaseLocation;

    /// <include file='D3D12_RAYTRACING_GEOMETRY_OMM_LINKAGE_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_OMM_LINKAGE_DESC.OpacityMicromapArray"]/*' />
    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong OpacityMicromapArray;
}
