// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_SHADER_INPUT_BIND_DESC
    {
        [NativeTypeName("LPCSTR")]
        public sbyte* Name;

        public D3D_SHADER_INPUT_TYPE Type;

        [NativeTypeName("UINT")]
        public uint BindPoint;

        [NativeTypeName("UINT")]
        public uint BindCount;

        [NativeTypeName("UINT")]
        public uint uFlags;

        public D3D_RESOURCE_RETURN_TYPE ReturnType;

        public D3D_SRV_DIMENSION Dimension;

        [NativeTypeName("UINT")]
        public uint NumSamples;
    }
}
