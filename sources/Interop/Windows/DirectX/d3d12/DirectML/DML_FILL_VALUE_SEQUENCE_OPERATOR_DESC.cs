// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_FILL_VALUE_SEQUENCE_OPERATOR_DESC.xml' path='doc/member[@name="DML_FILL_VALUE_SEQUENCE_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_FILL_VALUE_SEQUENCE_OPERATOR_DESC
{
    /// <include file='DML_FILL_VALUE_SEQUENCE_OPERATOR_DESC.xml' path='doc/member[@name="DML_FILL_VALUE_SEQUENCE_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_FILL_VALUE_SEQUENCE_OPERATOR_DESC.xml' path='doc/member[@name="DML_FILL_VALUE_SEQUENCE_OPERATOR_DESC.ValueDataType"]/*' />
    public DML_TENSOR_DATA_TYPE ValueDataType;

    /// <include file='DML_FILL_VALUE_SEQUENCE_OPERATOR_DESC.xml' path='doc/member[@name="DML_FILL_VALUE_SEQUENCE_OPERATOR_DESC.ValueStart"]/*' />
    public DML_SCALAR_UNION ValueStart;

    /// <include file='DML_FILL_VALUE_SEQUENCE_OPERATOR_DESC.xml' path='doc/member[@name="DML_FILL_VALUE_SEQUENCE_OPERATOR_DESC.ValueDelta"]/*' />
    public DML_SCALAR_UNION ValueDelta;
}
