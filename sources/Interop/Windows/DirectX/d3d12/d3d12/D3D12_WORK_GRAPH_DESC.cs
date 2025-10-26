// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_WORK_GRAPH_DESC.xml' path='doc/member[@name="D3D12_WORK_GRAPH_DESC"]/*' />
public unsafe partial struct D3D12_WORK_GRAPH_DESC
{
    /// <include file='D3D12_WORK_GRAPH_DESC.xml' path='doc/member[@name="D3D12_WORK_GRAPH_DESC.ProgramName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* ProgramName;

    /// <include file='D3D12_WORK_GRAPH_DESC.xml' path='doc/member[@name="D3D12_WORK_GRAPH_DESC.Flags"]/*' />
    public D3D12_WORK_GRAPH_FLAGS Flags;

    /// <include file='D3D12_WORK_GRAPH_DESC.xml' path='doc/member[@name="D3D12_WORK_GRAPH_DESC.NumEntrypoints"]/*' />
    public uint NumEntrypoints;

    /// <include file='D3D12_WORK_GRAPH_DESC.xml' path='doc/member[@name="D3D12_WORK_GRAPH_DESC.pEntrypoints"]/*' />
    [NativeTypeName("const D3D12_NODE_ID *")]
    public D3D12_NODE_ID* pEntrypoints;

    /// <include file='D3D12_WORK_GRAPH_DESC.xml' path='doc/member[@name="D3D12_WORK_GRAPH_DESC.NumExplicitlyDefinedNodes"]/*' />
    public uint NumExplicitlyDefinedNodes;

    /// <include file='D3D12_WORK_GRAPH_DESC.xml' path='doc/member[@name="D3D12_WORK_GRAPH_DESC.pExplicitlyDefinedNodes"]/*' />
    [NativeTypeName("const D3D12_NODE *")]
    public D3D12_NODE* pExplicitlyDefinedNodes;
}
