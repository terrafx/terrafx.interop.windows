// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_FENCE_BARRIERS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FENCE_BARRIERS"]/*' />
public partial struct D3D12_FEATURE_DATA_FENCE_BARRIERS
{
    /// <include file='D3D12_FEATURE_DATA_FENCE_BARRIERS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FENCE_BARRIERS.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_FENCE_BARRIERS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FENCE_BARRIERS.CommandListType"]/*' />
    public D3D12_COMMAND_LIST_TYPE CommandListType;

    /// <include file='D3D12_FEATURE_DATA_FENCE_BARRIERS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FENCE_BARRIERS.FenceBarriersTier"]/*' />
    public D3D12_FENCE_BARRIERS_TIER FenceBarriersTier;

    /// <include file='D3D12_FEATURE_DATA_FENCE_BARRIERS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FENCE_BARRIERS.SupportFlags"]/*' />
    public D3D12_FENCE_BARRIERS_SUPPORT_FLAGS SupportFlags;
}
