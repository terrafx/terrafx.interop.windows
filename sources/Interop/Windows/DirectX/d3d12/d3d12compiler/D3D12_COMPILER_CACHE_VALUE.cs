// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12compiler.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMPILER_CACHE_VALUE.xml' path='doc/member[@name="D3D12_COMPILER_CACHE_VALUE"]/*' />
public unsafe partial struct D3D12_COMPILER_CACHE_VALUE
{
    /// <include file='D3D12_COMPILER_CACHE_VALUE.xml' path='doc/member[@name="D3D12_COMPILER_CACHE_VALUE.pValue"]/*' />
    public void* pValue;

    /// <include file='D3D12_COMPILER_CACHE_VALUE.xml' path='doc/member[@name="D3D12_COMPILER_CACHE_VALUE.ValueSize"]/*' />
    public uint ValueSize;
}
