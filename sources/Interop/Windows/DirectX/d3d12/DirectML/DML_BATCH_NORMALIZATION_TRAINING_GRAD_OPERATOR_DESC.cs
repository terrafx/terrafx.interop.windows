// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC
{
    /// <include file='DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.InputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    /// <include file='DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.InputGradientTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputGradientTensor;

    /// <include file='DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.MeanTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* MeanTensor;

    /// <include file='DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.VarianceTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* VarianceTensor;

    /// <include file='DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.ScaleTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* ScaleTensor;

    /// <include file='DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.OutputGradientTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputGradientTensor;

    /// <include file='DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.OutputScaleGradientTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputScaleGradientTensor;

    /// <include file='DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.OutputBiasGradientTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputBiasGradientTensor;

    /// <include file='DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESC.Epsilon"]/*' />
    public float Epsilon;
}
