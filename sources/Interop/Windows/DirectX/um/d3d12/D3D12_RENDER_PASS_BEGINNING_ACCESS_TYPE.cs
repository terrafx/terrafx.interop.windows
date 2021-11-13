// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX
{
    public enum D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE
    {
        D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_DISCARD = 0,
        D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE = (D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_DISCARD + 1),
        D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_CLEAR = (D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE + 1),
        D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_NO_ACCESS = (D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_CLEAR + 1),
    }
}
