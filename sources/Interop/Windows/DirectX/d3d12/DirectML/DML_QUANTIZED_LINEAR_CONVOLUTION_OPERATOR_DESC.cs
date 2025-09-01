// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC
{
    /// <include file='DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.InputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    /// <include file='DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.InputScaleTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputScaleTensor;

    /// <include file='DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.InputZeroPointTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputZeroPointTensor;

    /// <include file='DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.FilterTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* FilterTensor;

    /// <include file='DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.FilterScaleTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* FilterScaleTensor;

    /// <include file='DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.FilterZeroPointTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* FilterZeroPointTensor;

    /// <include file='DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.BiasTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BiasTensor;

    /// <include file='DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.OutputScaleTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputScaleTensor;

    /// <include file='DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.OutputZeroPointTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputZeroPointTensor;

    /// <include file='DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.DimensionCount"]/*' />
    public uint DimensionCount;

    /// <include file='DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.Strides"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* Strides;

    /// <include file='DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.Dilations"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* Dilations;

    /// <include file='DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.StartPadding"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* StartPadding;

    /// <include file='DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.EndPadding"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* EndPadding;

    /// <include file='DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_CONVOLUTION_OPERATOR_DESC.GroupCount"]/*' />
    public uint GroupCount;
}
