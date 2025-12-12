// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_SPLIT_OPERATOR_DESC.xml' path='doc/member[@name="DML_SPLIT_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_SPLIT_OPERATOR_DESC
{
    /// <include file='DML_SPLIT_OPERATOR_DESC.xml' path='doc/member[@name="DML_SPLIT_OPERATOR_DESC.InputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    /// <include file='DML_SPLIT_OPERATOR_DESC.xml' path='doc/member[@name="DML_SPLIT_OPERATOR_DESC.OutputCount"]/*' />
    public uint OutputCount;

    /// <include file='DML_SPLIT_OPERATOR_DESC.xml' path='doc/member[@name="DML_SPLIT_OPERATOR_DESC.OutputTensors"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensors;

    /// <include file='DML_SPLIT_OPERATOR_DESC.xml' path='doc/member[@name="DML_SPLIT_OPERATOR_DESC.Axis"]/*' />
    public uint Axis;
}
