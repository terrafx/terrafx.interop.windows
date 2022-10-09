// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RESOURCE_STATE_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_STATE_BARRIER"]/*' />
public unsafe partial struct D3D12_RESOURCE_STATE_BARRIER
{
    /// <include file='D3D12_RESOURCE_STATE_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_STATE_BARRIER.State"]/*' />
    public D3D12_RESOURCE_STATES State;

    /// <include file='D3D12_RESOURCE_STATE_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_STATE_BARRIER.pResource"]/*' />
    public ID3D12Resource* pResource;

    /// <include file='D3D12_RESOURCE_STATE_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_STATE_BARRIER.Subresource"]/*' />
    public uint Subresource;

    /// <include file='D3D12_RESOURCE_STATE_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_STATE_BARRIER.Sync"]/*' />
    public D3D12_BARRIER_SYNC Sync;

    /// <include file='D3D12_RESOURCE_STATE_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_STATE_BARRIER.Access"]/*' />
    public D3D12_BARRIER_ACCESS Access;

    /// <include file='D3D12_RESOURCE_STATE_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_STATE_BARRIER.Layout"]/*' />
    public D3D12_BARRIER_LAYOUT Layout;
}
