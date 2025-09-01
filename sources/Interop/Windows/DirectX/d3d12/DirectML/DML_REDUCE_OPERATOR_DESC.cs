// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_REDUCE_OPERATOR_DESC.xml' path='doc/member[@name="DML_REDUCE_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_REDUCE_OPERATOR_DESC
{
    /// <include file='DML_REDUCE_OPERATOR_DESC.xml' path='doc/member[@name="DML_REDUCE_OPERATOR_DESC.Function"]/*' />
    public DML_REDUCE_FUNCTION Function;

    /// <include file='DML_REDUCE_OPERATOR_DESC.xml' path='doc/member[@name="DML_REDUCE_OPERATOR_DESC.InputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    /// <include file='DML_REDUCE_OPERATOR_DESC.xml' path='doc/member[@name="DML_REDUCE_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_REDUCE_OPERATOR_DESC.xml' path='doc/member[@name="DML_REDUCE_OPERATOR_DESC.AxisCount"]/*' />
    public uint AxisCount;

    /// <include file='DML_REDUCE_OPERATOR_DESC.xml' path='doc/member[@name="DML_REDUCE_OPERATOR_DESC.Axes"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* Axes;
}
