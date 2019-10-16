// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D12_SHADER_VERSION_TYPE
    {
        D3D12_SHVER_PIXEL_SHADER = 0,
        D3D12_SHVER_VERTEX_SHADER = 1,
        D3D12_SHVER_GEOMETRY_SHADER = 2,
        D3D12_SHVER_HULL_SHADER = 3,
        D3D12_SHVER_DOMAIN_SHADER = 4,
        D3D12_SHVER_COMPUTE_SHADER = 5,
        D3D12_SHVER_RESERVED0 = 0xFFF0,
    }
}
