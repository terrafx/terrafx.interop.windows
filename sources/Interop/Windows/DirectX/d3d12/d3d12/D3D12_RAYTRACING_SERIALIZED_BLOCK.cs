// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RAYTRACING_SERIALIZED_BLOCK.xml' path='doc/member[@name="D3D12_RAYTRACING_SERIALIZED_BLOCK"]/*' />
public partial struct D3D12_RAYTRACING_SERIALIZED_BLOCK
{
    /// <include file='D3D12_RAYTRACING_SERIALIZED_BLOCK.xml' path='doc/member[@name="D3D12_RAYTRACING_SERIALIZED_BLOCK.Type"]/*' />
    public D3D12_RAYTRACING_SERIALIZED_BLOCK_TYPE Type;

    /// <include file='D3D12_RAYTRACING_SERIALIZED_BLOCK.xml' path='doc/member[@name="D3D12_RAYTRACING_SERIALIZED_BLOCK.NumBlockPointersAfterHeader"]/*' />
    [NativeTypeName("UINT64")]
    public ulong NumBlockPointersAfterHeader;
}
