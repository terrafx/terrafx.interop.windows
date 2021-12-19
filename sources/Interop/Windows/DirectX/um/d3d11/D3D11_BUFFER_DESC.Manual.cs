// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.DirectX.D3D11_USAGE;

namespace TerraFX.Interop.DirectX;

public partial struct D3D11_BUFFER_DESC
{
    public D3D11_BUFFER_DESC(uint byteWidth, uint bindFlags, D3D11_USAGE usage = D3D11_USAGE_DEFAULT, uint cpuaccessFlags = 0, uint miscFlags = 0, uint structureByteStride = 0)
    {
        ByteWidth = byteWidth;
        Usage = usage;
        BindFlags = bindFlags;
        CPUAccessFlags = cpuaccessFlags;
        MiscFlags = miscFlags;
        StructureByteStride = structureByteStride;
    }
}
