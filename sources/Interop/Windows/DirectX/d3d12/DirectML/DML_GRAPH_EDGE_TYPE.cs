// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_GRAPH_EDGE_TYPE.xml' path='doc/member[@name="DML_GRAPH_EDGE_TYPE"]/*' />
public enum DML_GRAPH_EDGE_TYPE
{
    /// <include file='DML_GRAPH_EDGE_TYPE.xml' path='doc/member[@name="DML_GRAPH_EDGE_TYPE.DML_GRAPH_EDGE_TYPE_INVALID"]/*' />
    DML_GRAPH_EDGE_TYPE_INVALID,

    /// <include file='DML_GRAPH_EDGE_TYPE.xml' path='doc/member[@name="DML_GRAPH_EDGE_TYPE.DML_GRAPH_EDGE_TYPE_INPUT"]/*' />
    DML_GRAPH_EDGE_TYPE_INPUT,

    /// <include file='DML_GRAPH_EDGE_TYPE.xml' path='doc/member[@name="DML_GRAPH_EDGE_TYPE.DML_GRAPH_EDGE_TYPE_OUTPUT"]/*' />
    DML_GRAPH_EDGE_TYPE_OUTPUT,

    /// <include file='DML_GRAPH_EDGE_TYPE.xml' path='doc/member[@name="DML_GRAPH_EDGE_TYPE.DML_GRAPH_EDGE_TYPE_INTERMEDIATE"]/*' />
    DML_GRAPH_EDGE_TYPE_INTERMEDIATE,
}
