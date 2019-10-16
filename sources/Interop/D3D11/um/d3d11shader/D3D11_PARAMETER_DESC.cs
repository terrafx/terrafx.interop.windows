// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_PARAMETER_DESC
    {
        [NativeTypeName("LPCSTR")]
        public sbyte* Name;

        [NativeTypeName("LPCSTR")]
        public sbyte* SemanticName;

        public D3D_SHADER_VARIABLE_TYPE Type;

        public D3D_SHADER_VARIABLE_CLASS Class;

        [NativeTypeName("UINT")]
        public uint Rows;

        [NativeTypeName("UINT")]
        public uint Columns;

        public D3D_INTERPOLATION_MODE InterpolationMode;

        public D3D_PARAMETER_FLAGS Flags;

        [NativeTypeName("UINT")]
        public uint FirstInRegister;

        [NativeTypeName("UINT")]
        public uint FirstInComponent;

        [NativeTypeName("UINT")]
        public uint FirstOutRegister;

        [NativeTypeName("UINT")]
        public uint FirstOutComponent;
    }
}
