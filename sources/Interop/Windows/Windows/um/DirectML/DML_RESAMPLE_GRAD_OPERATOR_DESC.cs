// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct DML_RESAMPLE_GRAD_OPERATOR_DESC
    {
        [NativeTypeName("const DML_TENSOR_DESC *")]
        public DML_TENSOR_DESC* InputGradientTensor;

        [NativeTypeName("const DML_TENSOR_DESC *")]
        public DML_TENSOR_DESC* OutputGradientTensor;

        public DML_INTERPOLATION_MODE InterpolationMode;

        public uint DimensionCount;

        [NativeTypeName("const FLOAT *")]
        public float* Scales;

        [NativeTypeName("const FLOAT *")]
        public float* InputPixelOffsets;

        [NativeTypeName("const FLOAT *")]
        public float* OutputPixelOffsets;
    }
}
