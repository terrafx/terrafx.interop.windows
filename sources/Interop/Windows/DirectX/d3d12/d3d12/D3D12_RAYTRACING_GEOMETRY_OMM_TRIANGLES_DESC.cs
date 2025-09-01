// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RAYTRACING_GEOMETRY_OMM_TRIANGLES_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_OMM_TRIANGLES_DESC"]/*' />
public unsafe partial struct D3D12_RAYTRACING_GEOMETRY_OMM_TRIANGLES_DESC
{
    /// <include file='D3D12_RAYTRACING_GEOMETRY_OMM_TRIANGLES_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_OMM_TRIANGLES_DESC.pTriangles"]/*' />
    [NativeTypeName("const D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC *")]
    public D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC* pTriangles;

    /// <include file='D3D12_RAYTRACING_GEOMETRY_OMM_TRIANGLES_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_OMM_TRIANGLES_DESC.pOmmLinkage"]/*' />
    [NativeTypeName("const D3D12_RAYTRACING_GEOMETRY_OMM_LINKAGE_DESC *")]
    public D3D12_RAYTRACING_GEOMETRY_OMM_LINKAGE_DESC* pOmmLinkage;
}
