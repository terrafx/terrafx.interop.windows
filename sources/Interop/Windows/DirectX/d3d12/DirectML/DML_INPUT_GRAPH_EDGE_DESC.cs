// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_INPUT_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_INPUT_GRAPH_EDGE_DESC"]/*' />
public unsafe partial struct DML_INPUT_GRAPH_EDGE_DESC
{
    /// <include file='DML_INPUT_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_INPUT_GRAPH_EDGE_DESC.GraphInputIndex"]/*' />
    public uint GraphInputIndex;

    /// <include file='DML_INPUT_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_INPUT_GRAPH_EDGE_DESC.ToNodeIndex"]/*' />
    public uint ToNodeIndex;

    /// <include file='DML_INPUT_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_INPUT_GRAPH_EDGE_DESC.ToNodeInputIndex"]/*' />
    public uint ToNodeInputIndex;

    /// <include file='DML_INPUT_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_INPUT_GRAPH_EDGE_DESC.Name"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* Name;
}
