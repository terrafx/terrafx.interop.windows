// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D10_EFFECT_SHADER_DESC
    {
        [NativeTypeName("const BYTE *")]
        public byte* pInputSignature;

        [NativeTypeName("BOOL")]
        public int IsInline;

        [NativeTypeName("const BYTE *")]
        public byte* pBytecode;

        [NativeTypeName("UINT")]
        public uint BytecodeLength;

        [NativeTypeName("LPCSTR")]
        public sbyte* SODecl;

        [NativeTypeName("UINT")]
        public uint NumInputSignatureEntries;

        [NativeTypeName("UINT")]
        public uint NumOutputSignatureEntries;
    }
}
