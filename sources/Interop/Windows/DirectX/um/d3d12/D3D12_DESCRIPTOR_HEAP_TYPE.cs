// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DESCRIPTOR_HEAP_TYPE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_HEAP_TYPE"]/*' />
public enum D3D12_DESCRIPTOR_HEAP_TYPE
{
    /// <include file='D3D12_DESCRIPTOR_HEAP_TYPE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_HEAP_TYPE.D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV"]/*' />
    D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV = 0,

    /// <include file='D3D12_DESCRIPTOR_HEAP_TYPE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_HEAP_TYPE.D3D12_DESCRIPTOR_HEAP_TYPE_SAMPLER"]/*' />
    D3D12_DESCRIPTOR_HEAP_TYPE_SAMPLER = (D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV + 1),

    /// <include file='D3D12_DESCRIPTOR_HEAP_TYPE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_HEAP_TYPE.D3D12_DESCRIPTOR_HEAP_TYPE_RTV"]/*' />
    D3D12_DESCRIPTOR_HEAP_TYPE_RTV = (D3D12_DESCRIPTOR_HEAP_TYPE_SAMPLER + 1),

    /// <include file='D3D12_DESCRIPTOR_HEAP_TYPE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_HEAP_TYPE.D3D12_DESCRIPTOR_HEAP_TYPE_DSV"]/*' />
    D3D12_DESCRIPTOR_HEAP_TYPE_DSV = (D3D12_DESCRIPTOR_HEAP_TYPE_RTV + 1),

    /// <include file='D3D12_DESCRIPTOR_HEAP_TYPE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_HEAP_TYPE.D3D12_DESCRIPTOR_HEAP_TYPE_NUM_TYPES"]/*' />
    D3D12_DESCRIPTOR_HEAP_TYPE_NUM_TYPES = (D3D12_DESCRIPTOR_HEAP_TYPE_DSV + 1),
}
