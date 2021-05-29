// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D3D11_BIND_FLAG;
using static TerraFX.Interop.D3D11_USAGE;

namespace TerraFX.Interop
{
    public partial struct D3D11_TEXTURE2D_DESC
    {
        public D3D11_TEXTURE2D_DESC(DXGI_FORMAT format, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, [NativeTypeName("UINT")] uint arraySize = 1, [NativeTypeName("UINT")] uint mipLevels = 0, [NativeTypeName("UINT")] uint bindFlags = (uint)D3D11_BIND_SHADER_RESOURCE, D3D11_USAGE usage = D3D11_USAGE_DEFAULT, [NativeTypeName("UINT")] uint cpuaccessFlags = 0, [NativeTypeName("UINT")] uint sampleCount = 1, [NativeTypeName("UINT")] uint sampleQuality = 0, [NativeTypeName("UINT")] uint miscFlags = 0)
        {
            Width = width;
            Height = height;
            MipLevels = mipLevels;
            ArraySize = arraySize;
            Format = format;
            SampleDesc.Count = sampleCount;
            SampleDesc.Quality = sampleQuality;
            Usage = usage;
            BindFlags = bindFlags;
            CPUAccessFlags = cpuaccessFlags;
            MiscFlags = miscFlags;
        }
    }
}
