// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_OPERATOR_GRAPH_NODE_DESC.xml' path='doc/member[@name="DML_OPERATOR_GRAPH_NODE_DESC"]/*' />
public unsafe partial struct DML_OPERATOR_GRAPH_NODE_DESC
{
    /// <include file='DML_OPERATOR_GRAPH_NODE_DESC.xml' path='doc/member[@name="DML_OPERATOR_GRAPH_NODE_DESC.Operator"]/*' />
    public IDMLOperator* Operator;

    /// <include file='DML_OPERATOR_GRAPH_NODE_DESC.xml' path='doc/member[@name="DML_OPERATOR_GRAPH_NODE_DESC.Name"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* Name;
}
