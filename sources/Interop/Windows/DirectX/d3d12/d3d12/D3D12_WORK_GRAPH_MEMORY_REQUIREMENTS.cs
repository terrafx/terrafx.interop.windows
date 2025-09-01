// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS.xml' path='doc/member[@name="D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS"]/*' />
public partial struct D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS
{
    /// <include file='D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS.xml' path='doc/member[@name="D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS.MinSizeInBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MinSizeInBytes;

    /// <include file='D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS.xml' path='doc/member[@name="D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS.MaxSizeInBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MaxSizeInBytes;

    /// <include file='D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS.xml' path='doc/member[@name="D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS.SizeGranularityInBytes"]/*' />
    public uint SizeGranularityInBytes;
}
