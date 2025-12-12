// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12compiler.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMPILER_CACHE_VALUE_KEY.xml' path='doc/member[@name="D3D12_COMPILER_CACHE_VALUE_KEY"]/*' />
public unsafe partial struct D3D12_COMPILER_CACHE_VALUE_KEY
{
    /// <include file='D3D12_COMPILER_CACHE_VALUE_KEY.xml' path='doc/member[@name="D3D12_COMPILER_CACHE_VALUE_KEY.pKey"]/*' />
    [NativeTypeName("const void *")]
    public void* pKey;

    /// <include file='D3D12_COMPILER_CACHE_VALUE_KEY.xml' path='doc/member[@name="D3D12_COMPILER_CACHE_VALUE_KEY.KeySize"]/*' />
    public uint KeySize;
}
