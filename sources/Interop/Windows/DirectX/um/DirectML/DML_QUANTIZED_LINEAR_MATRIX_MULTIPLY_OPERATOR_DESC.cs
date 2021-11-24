// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public unsafe partial struct DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC
{
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* ATensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* AScaleTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* AZeroPointTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BScaleTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BZeroPointTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputScaleTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputZeroPointTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;
}
