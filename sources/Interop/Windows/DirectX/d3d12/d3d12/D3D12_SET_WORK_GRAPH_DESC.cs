// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SET_WORK_GRAPH_DESC.xml' path='doc/member[@name="D3D12_SET_WORK_GRAPH_DESC"]/*' />
public partial struct D3D12_SET_WORK_GRAPH_DESC
{
    /// <include file='D3D12_SET_WORK_GRAPH_DESC.xml' path='doc/member[@name="D3D12_SET_WORK_GRAPH_DESC.ProgramIdentifier"]/*' />
    public D3D12_PROGRAM_IDENTIFIER ProgramIdentifier;

    /// <include file='D3D12_SET_WORK_GRAPH_DESC.xml' path='doc/member[@name="D3D12_SET_WORK_GRAPH_DESC.Flags"]/*' />
    public D3D12_SET_WORK_GRAPH_FLAGS Flags;

    /// <include file='D3D12_SET_WORK_GRAPH_DESC.xml' path='doc/member[@name="D3D12_SET_WORK_GRAPH_DESC.BackingMemory"]/*' />
    public D3D12_GPU_VIRTUAL_ADDRESS_RANGE BackingMemory;

    /// <include file='D3D12_SET_WORK_GRAPH_DESC.xml' path='doc/member[@name="D3D12_SET_WORK_GRAPH_DESC.NodeLocalRootArgumentsTable"]/*' />
    public D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE NodeLocalRootArgumentsTable;
}
