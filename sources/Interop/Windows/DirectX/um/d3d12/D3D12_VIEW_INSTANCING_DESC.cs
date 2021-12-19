// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIEW_INSTANCING_DESC.xml' path='doc/member[@name="D3D12_VIEW_INSTANCING_DESC"]/*' />
public unsafe partial struct D3D12_VIEW_INSTANCING_DESC
{
    /// <include file='D3D12_VIEW_INSTANCING_DESC.xml' path='doc/member[@name="D3D12_VIEW_INSTANCING_DESC.ViewInstanceCount"]/*' />
    public uint ViewInstanceCount;

    /// <include file='D3D12_VIEW_INSTANCING_DESC.xml' path='doc/member[@name="D3D12_VIEW_INSTANCING_DESC.pViewInstanceLocations"]/*' />
    [NativeTypeName("const D3D12_VIEW_INSTANCE_LOCATION *")]
    public D3D12_VIEW_INSTANCE_LOCATION* pViewInstanceLocations;

    /// <include file='D3D12_VIEW_INSTANCING_DESC.xml' path='doc/member[@name="D3D12_VIEW_INSTANCING_DESC.Flags"]/*' />
    public D3D12_VIEW_INSTANCING_FLAGS Flags;
}
