// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_GRAPH_DESC.xml' path='doc/member[@name="DML_GRAPH_DESC"]/*' />
public unsafe partial struct DML_GRAPH_DESC
{
    /// <include file='DML_GRAPH_DESC.xml' path='doc/member[@name="DML_GRAPH_DESC.InputCount"]/*' />
    public uint InputCount;

    /// <include file='DML_GRAPH_DESC.xml' path='doc/member[@name="DML_GRAPH_DESC.OutputCount"]/*' />
    public uint OutputCount;

    /// <include file='DML_GRAPH_DESC.xml' path='doc/member[@name="DML_GRAPH_DESC.NodeCount"]/*' />
    public uint NodeCount;

    /// <include file='DML_GRAPH_DESC.xml' path='doc/member[@name="DML_GRAPH_DESC.Nodes"]/*' />
    [NativeTypeName("const DML_GRAPH_NODE_DESC *")]
    public DML_GRAPH_NODE_DESC* Nodes;

    /// <include file='DML_GRAPH_DESC.xml' path='doc/member[@name="DML_GRAPH_DESC.InputEdgeCount"]/*' />
    public uint InputEdgeCount;

    /// <include file='DML_GRAPH_DESC.xml' path='doc/member[@name="DML_GRAPH_DESC.InputEdges"]/*' />
    [NativeTypeName("const DML_GRAPH_EDGE_DESC *")]
    public DML_GRAPH_EDGE_DESC* InputEdges;

    /// <include file='DML_GRAPH_DESC.xml' path='doc/member[@name="DML_GRAPH_DESC.OutputEdgeCount"]/*' />
    public uint OutputEdgeCount;

    /// <include file='DML_GRAPH_DESC.xml' path='doc/member[@name="DML_GRAPH_DESC.OutputEdges"]/*' />
    [NativeTypeName("const DML_GRAPH_EDGE_DESC *")]
    public DML_GRAPH_EDGE_DESC* OutputEdges;

    /// <include file='DML_GRAPH_DESC.xml' path='doc/member[@name="DML_GRAPH_DESC.IntermediateEdgeCount"]/*' />
    public uint IntermediateEdgeCount;

    /// <include file='DML_GRAPH_DESC.xml' path='doc/member[@name="DML_GRAPH_DESC.IntermediateEdges"]/*' />
    [NativeTypeName("const DML_GRAPH_EDGE_DESC *")]
    public DML_GRAPH_EDGE_DESC* IntermediateEdges;
}
