// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SHADER_CACHE_STORE_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_STORE_FLAGS"]/*' />
public enum D3D12_SHADER_CACHE_STORE_FLAGS
{
    /// <include file='D3D12_SHADER_CACHE_STORE_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_STORE_FLAGS.D3D12_SHADER_CACHE_STORE_FLAG_NONE"]/*' />
    D3D12_SHADER_CACHE_STORE_FLAG_NONE = 0,

    /// <include file='D3D12_SHADER_CACHE_STORE_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_STORE_FLAGS.D3D12_SHADER_CACHE_STORE_FLAG_OVERWRITE"]/*' />
    D3D12_SHADER_CACHE_STORE_FLAG_OVERWRITE = 0x1,

    /// <include file='D3D12_SHADER_CACHE_STORE_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_STORE_FLAGS.D3D12_SHADER_CACHE_STORE_FLAG_DO_NOT_EVICT"]/*' />
    D3D12_SHADER_CACHE_STORE_FLAG_DO_NOT_EVICT = 0x2,
}
