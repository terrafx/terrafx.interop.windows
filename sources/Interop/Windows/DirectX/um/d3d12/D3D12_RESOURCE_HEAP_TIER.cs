// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RESOURCE_HEAP_TIER.xml' path='doc/member[@name="D3D12_RESOURCE_HEAP_TIER"]/*' />
public enum D3D12_RESOURCE_HEAP_TIER
{
    /// <include file='D3D12_RESOURCE_HEAP_TIER.xml' path='doc/member[@name="D3D12_RESOURCE_HEAP_TIER.D3D12_RESOURCE_HEAP_TIER_1"]/*' />
    D3D12_RESOURCE_HEAP_TIER_1 = 1,

    /// <include file='D3D12_RESOURCE_HEAP_TIER.xml' path='doc/member[@name="D3D12_RESOURCE_HEAP_TIER.D3D12_RESOURCE_HEAP_TIER_2"]/*' />
    D3D12_RESOURCE_HEAP_TIER_2 = 2,
}
