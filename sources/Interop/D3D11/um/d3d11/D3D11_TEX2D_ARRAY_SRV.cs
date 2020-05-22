// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_TEX2D_ARRAY_SRV
    {
        [NativeTypeName("UINT")]
        public uint MostDetailedMip;

        [NativeTypeName("UINT")]
        public uint MipLevels;

        [NativeTypeName("UINT")]
        public uint FirstArraySlice;

        [NativeTypeName("UINT")]
        public uint ArraySize;
    }
}
