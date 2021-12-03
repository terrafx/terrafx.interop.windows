// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RESOURCE_TRANSITION_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_TRANSITION_BARRIER"]/*' />
public unsafe partial struct D3D12_RESOURCE_TRANSITION_BARRIER
{
    /// <include file='D3D12_RESOURCE_TRANSITION_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_TRANSITION_BARRIER.pResource"]/*' />
    public ID3D12Resource* pResource;

    /// <include file='D3D12_RESOURCE_TRANSITION_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_TRANSITION_BARRIER.Subresource"]/*' />
    public uint Subresource;

    /// <include file='D3D12_RESOURCE_TRANSITION_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_TRANSITION_BARRIER.StateBefore"]/*' />
    public D3D12_RESOURCE_STATES StateBefore;

    /// <include file='D3D12_RESOURCE_TRANSITION_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_TRANSITION_BARRIER.StateAfter"]/*' />
    public D3D12_RESOURCE_STATES StateAfter;
}
