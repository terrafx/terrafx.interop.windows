// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_WORK_GRAPH_FLAGS.xml' path='doc/member[@name="D3D12_WORK_GRAPH_FLAGS"]/*' />
public enum D3D12_WORK_GRAPH_FLAGS
{
    /// <include file='D3D12_WORK_GRAPH_FLAGS.xml' path='doc/member[@name="D3D12_WORK_GRAPH_FLAGS.D3D12_WORK_GRAPH_FLAG_NONE"]/*' />
    D3D12_WORK_GRAPH_FLAG_NONE = 0,

    /// <include file='D3D12_WORK_GRAPH_FLAGS.xml' path='doc/member[@name="D3D12_WORK_GRAPH_FLAGS.D3D12_WORK_GRAPH_FLAG_INCLUDE_ALL_AVAILABLE_NODES"]/*' />
    D3D12_WORK_GRAPH_FLAG_INCLUDE_ALL_AVAILABLE_NODES = 0x1,
}
