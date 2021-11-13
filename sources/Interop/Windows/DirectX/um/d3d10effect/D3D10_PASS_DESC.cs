// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX
{
    public unsafe partial struct D3D10_PASS_DESC
    {
        [NativeTypeName("LPCSTR")]
        public sbyte* Name;

        public uint Annotations;

        public byte* pIAInputSignature;

        [NativeTypeName("SIZE_T")]
        public nuint IAInputSignatureSize;

        public uint StencilRef;

        public uint SampleMask;

        [NativeTypeName("FLOAT [4]")]
        public fixed float BlendFactor[4];
    }
}
