// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_TEXTURE3D_DESC1
    {
        public uint Width;

        public uint Height;

        public uint Depth;

        public uint MipLevels;

        public DXGI_FORMAT Format;

        public D3D11_USAGE Usage;

        public uint BindFlags;

        public uint CPUAccessFlags;

        public uint MiscFlags;

        public D3D11_TEXTURE_LAYOUT TextureLayout;
    }
}
