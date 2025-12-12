// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12compiler.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMPILER_CACHE_CONST_VALUE.xml' path='doc/member[@name="D3D12_COMPILER_CACHE_CONST_VALUE"]/*' />
public unsafe partial struct D3D12_COMPILER_CACHE_CONST_VALUE
{
    /// <include file='D3D12_COMPILER_CACHE_CONST_VALUE.xml' path='doc/member[@name="D3D12_COMPILER_CACHE_CONST_VALUE.pValue"]/*' />
    [NativeTypeName("const void *")]
    public void* pValue;

    /// <include file='D3D12_COMPILER_CACHE_CONST_VALUE.xml' path='doc/member[@name="D3D12_COMPILER_CACHE_CONST_VALUE.ValueSize"]/*' />
    public uint ValueSize;
}
