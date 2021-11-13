// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0.19041.0")]
    public unsafe partial struct DML_RESAMPLE_OPERATOR_DESC
    {
        [NativeTypeName("const DML_TENSOR_DESC *")]
        public DML_TENSOR_DESC* InputTensor;

        [NativeTypeName("const DML_TENSOR_DESC *")]
        public DML_TENSOR_DESC* OutputTensor;

        public DML_INTERPOLATION_MODE InterpolationMode;

        public uint ScaleCount;

        [NativeTypeName("const FLOAT *")]
        public float* Scales;
    }
}
