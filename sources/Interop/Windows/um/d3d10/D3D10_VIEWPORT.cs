// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D10_VIEWPORT
    {
        [NativeTypeName("INT")]
        public int TopLeftX;

        [NativeTypeName("INT")]
        public int TopLeftY;

        [NativeTypeName("UINT")]
        public uint Width;

        [NativeTypeName("UINT")]
        public uint Height;

        [NativeTypeName("FLOAT")]
        public float MinDepth;

        [NativeTypeName("FLOAT")]
        public float MaxDepth;
    }
}
