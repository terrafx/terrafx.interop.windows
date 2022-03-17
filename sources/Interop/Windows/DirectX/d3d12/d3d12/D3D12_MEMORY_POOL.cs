// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_MEMORY_POOL.xml' path='doc/member[@name="D3D12_MEMORY_POOL"]/*' />
public enum D3D12_MEMORY_POOL
{
    /// <include file='D3D12_MEMORY_POOL.xml' path='doc/member[@name="D3D12_MEMORY_POOL.D3D12_MEMORY_POOL_UNKNOWN"]/*' />
    D3D12_MEMORY_POOL_UNKNOWN = 0,

    /// <include file='D3D12_MEMORY_POOL.xml' path='doc/member[@name="D3D12_MEMORY_POOL.D3D12_MEMORY_POOL_L0"]/*' />
    D3D12_MEMORY_POOL_L0 = 1,

    /// <include file='D3D12_MEMORY_POOL.xml' path='doc/member[@name="D3D12_MEMORY_POOL.D3D12_MEMORY_POOL_L1"]/*' />
    D3D12_MEMORY_POOL_L1 = 2,
}
