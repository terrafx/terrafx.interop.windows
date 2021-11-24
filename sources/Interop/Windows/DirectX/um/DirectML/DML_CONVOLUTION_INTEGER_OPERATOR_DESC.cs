// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public unsafe partial struct DML_CONVOLUTION_INTEGER_OPERATOR_DESC
{
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputZeroPointTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* FilterTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* FilterZeroPointTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    public uint DimensionCount;

    [NativeTypeName("const UINT *")]
    public uint* Strides;

    [NativeTypeName("const UINT *")]
    public uint* Dilations;

    [NativeTypeName("const UINT *")]
    public uint* StartPadding;

    [NativeTypeName("const UINT *")]
    public uint* EndPadding;

    public uint GroupCount;
}
