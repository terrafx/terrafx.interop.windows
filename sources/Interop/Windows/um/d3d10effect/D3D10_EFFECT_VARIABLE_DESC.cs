// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D10_EFFECT_VARIABLE_DESC
    {
        [NativeTypeName("LPCSTR")]
        public sbyte* Name;

        [NativeTypeName("LPCSTR")]
        public sbyte* Semantic;

        [NativeTypeName("UINT")]
        public uint Flags;

        [NativeTypeName("UINT")]
        public uint Annotations;

        [NativeTypeName("UINT")]
        public uint BufferOffset;

        [NativeTypeName("UINT")]
        public uint ExplicitBindPoint;
    }
}
