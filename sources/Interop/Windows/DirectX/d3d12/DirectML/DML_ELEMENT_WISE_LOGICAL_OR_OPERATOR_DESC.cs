// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_ELEMENT_WISE_LOGICAL_OR_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_LOGICAL_OR_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_ELEMENT_WISE_LOGICAL_OR_OPERATOR_DESC
{
    /// <include file='DML_ELEMENT_WISE_LOGICAL_OR_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_LOGICAL_OR_OPERATOR_DESC.ATensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* ATensor;

    /// <include file='DML_ELEMENT_WISE_LOGICAL_OR_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_LOGICAL_OR_OPERATOR_DESC.BTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BTensor;

    /// <include file='DML_ELEMENT_WISE_LOGICAL_OR_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_LOGICAL_OR_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;
}
