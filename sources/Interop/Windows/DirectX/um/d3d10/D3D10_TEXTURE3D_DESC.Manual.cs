// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.DirectX.D3D10_BIND_FLAG;
using static TerraFX.Interop.DirectX.D3D10_USAGE;

namespace TerraFX.Interop.DirectX;

public partial struct D3D10_TEXTURE3D_DESC
{
    public D3D10_TEXTURE3D_DESC(DXGI_FORMAT format, uint width, uint height, uint depth, uint mipLevels = 0, uint bindFlags = (uint)D3D10_BIND_SHADER_RESOURCE, D3D10_USAGE usage = D3D10_USAGE_DEFAULT, uint cpuaccessFlags = 0, uint miscFlags = 0)
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
    }
}
