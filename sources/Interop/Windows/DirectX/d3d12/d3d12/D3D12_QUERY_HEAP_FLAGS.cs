// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.619.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_QUERY_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_QUERY_HEAP_FLAGS"]/*' />
public enum D3D12_QUERY_HEAP_FLAGS
{
    /// <include file='D3D12_QUERY_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_QUERY_HEAP_FLAGS.D3D12_QUERY_HEAP_FLAG_NONE"]/*' />
    D3D12_QUERY_HEAP_FLAG_NONE = 0,

    /// <include file='D3D12_QUERY_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_QUERY_HEAP_FLAGS.D3D12_QUERY_HEAP_FLAG_CPU_RESOLVE"]/*' />
    D3D12_QUERY_HEAP_FLAG_CPU_RESOLVE = 1,
}
