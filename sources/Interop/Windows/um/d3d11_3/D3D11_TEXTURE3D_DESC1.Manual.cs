// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D3D11_BIND_FLAG;
using static TerraFX.Interop.D3D11_TEXTURE_LAYOUT;
using static TerraFX.Interop.D3D11_USAGE;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_TEXTURE3D_DESC1
    {
        public D3D11_TEXTURE3D_DESC1(DXGI_FORMAT format, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, [NativeTypeName("UINT")] uint depth, [NativeTypeName("UINT")] uint mipLevels = 0, [NativeTypeName("UINT")] uint bindFlags = (uint)D3D11_BIND_SHADER_RESOURCE, D3D11_USAGE usage = D3D11_USAGE_DEFAULT, [NativeTypeName("UINT")] uint cpuaccessFlags = 0, [NativeTypeName("UINT")] uint miscFlags = 0, D3D11_TEXTURE_LAYOUT textureLayout = D3D11_TEXTURE_LAYOUT_UNDEFINED)
        {
            Width = width;
            Height = height;
            Depth = depth;
            MipLevels = mipLevels;
            Format = format;
            Usage = usage;
            BindFlags = bindFlags;
            CPUAccessFlags = cpuaccessFlags;
            MiscFlags = miscFlags;
            TextureLayout = textureLayout;
        }

        public D3D11_TEXTURE3D_DESC1([NativeTypeName("const D3D11_TEXTURE3D_DESC &")] D3D11_TEXTURE3D_DESC* desc, D3D11_TEXTURE_LAYOUT textureLayout = D3D11_TEXTURE_LAYOUT_UNDEFINED)
        {
            Width = desc->Width;
            Height = desc->Height;
            Depth = desc->Depth;
            MipLevels = desc->MipLevels;
            Format = desc->Format;
            Usage = desc->Usage;
            BindFlags = desc->BindFlags;
            CPUAccessFlags = desc->CPUAccessFlags;
            MiscFlags = desc->MiscFlags;
            TextureLayout = textureLayout;
        }
    }
}
