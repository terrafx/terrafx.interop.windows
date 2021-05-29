// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D12_RESOLVE_MODE
    {
        D3D12_RESOLVE_MODE_DECOMPRESS = 0,
        D3D12_RESOLVE_MODE_MIN = 1,
        D3D12_RESOLVE_MODE_MAX = 2,
        D3D12_RESOLVE_MODE_AVERAGE = 3,
        D3D12_RESOLVE_MODE_ENCODE_SAMPLER_FEEDBACK = 4,
        D3D12_RESOLVE_MODE_DECODE_SAMPLER_FEEDBACK = 5,
    }
}
