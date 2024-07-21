// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_RANDOM_GENERATOR_OPERATOR_DESC.xml' path='doc/member[@name="DML_RANDOM_GENERATOR_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_RANDOM_GENERATOR_OPERATOR_DESC
{
    /// <include file='DML_RANDOM_GENERATOR_OPERATOR_DESC.xml' path='doc/member[@name="DML_RANDOM_GENERATOR_OPERATOR_DESC.InputStateTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputStateTensor;

    /// <include file='DML_RANDOM_GENERATOR_OPERATOR_DESC.xml' path='doc/member[@name="DML_RANDOM_GENERATOR_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_RANDOM_GENERATOR_OPERATOR_DESC.xml' path='doc/member[@name="DML_RANDOM_GENERATOR_OPERATOR_DESC.OutputStateTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputStateTensor;

    /// <include file='DML_RANDOM_GENERATOR_OPERATOR_DESC.xml' path='doc/member[@name="DML_RANDOM_GENERATOR_OPERATOR_DESC.Type"]/*' />
    public DML_RANDOM_GENERATOR_TYPE Type;
}
