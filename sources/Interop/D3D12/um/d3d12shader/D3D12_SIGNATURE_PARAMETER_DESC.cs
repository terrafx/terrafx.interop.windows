// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_SIGNATURE_PARAMETER_DESC
    {
        [NativeTypeName("LPCSTR")]
        public sbyte* SemanticName;

        [NativeTypeName("UINT")]
        public uint SemanticIndex;

        [NativeTypeName("UINT")]
        public uint Register;

        public D3D_NAME SystemValueType;

        public D3D_REGISTER_COMPONENT_TYPE ComponentType;

        [NativeTypeName("BYTE")]
        public byte Mask;

        [NativeTypeName("BYTE")]
        public byte ReadWriteMask;

        [NativeTypeName("UINT")]
        public uint Stream;

        public D3D_MIN_PRECISION MinPrecision;
    }
}
