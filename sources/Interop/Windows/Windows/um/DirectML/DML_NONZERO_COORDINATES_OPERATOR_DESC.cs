// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct DML_NONZERO_COORDINATES_OPERATOR_DESC
    {
        [NativeTypeName("const DML_TENSOR_DESC *")]
        public DML_TENSOR_DESC* InputTensor;

        [NativeTypeName("const DML_TENSOR_DESC *")]
        public DML_TENSOR_DESC* OutputCountTensor;

        [NativeTypeName("const DML_TENSOR_DESC *")]
        public DML_TENSOR_DESC* OutputCoordinatesTensor;
    }
}
