// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D10_SHADER_INPUT_BIND_DESC
    {
        [NativeTypeName("LPCSTR")]
        public sbyte* Name;

        [NativeTypeName("D3D10_SHADER_INPUT_TYPE")]
        public D3D_SHADER_INPUT_TYPE Type;

        public uint BindPoint;

        public uint BindCount;

        public uint uFlags;

        [NativeTypeName("D3D10_RESOURCE_RETURN_TYPE")]
        public D3D_RESOURCE_RETURN_TYPE ReturnType;

        [NativeTypeName("D3D10_SRV_DIMENSION")]
        public D3D_SRV_DIMENSION Dimension;

        public uint NumSamples;
    }
}
