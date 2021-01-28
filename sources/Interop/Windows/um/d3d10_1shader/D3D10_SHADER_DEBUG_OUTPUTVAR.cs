// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D10_SHADER_DEBUG_OUTPUTVAR
    {
        [NativeTypeName("UINT")]
        public uint Var;

        [NativeTypeName("UINT")]
        public uint uValueMin;

        [NativeTypeName("UINT")]
        public uint uValueMax;

        [NativeTypeName("INT")]
        public int iValueMin;

        [NativeTypeName("INT")]
        public int iValueMax;

        [NativeTypeName("FLOAT")]
        public float fValueMin;

        [NativeTypeName("FLOAT")]
        public float fValueMax;

        [NativeTypeName("BOOL")]
        public int bNaNPossible;

        [NativeTypeName("BOOL")]
        public int bInfPossible;
    }
}
