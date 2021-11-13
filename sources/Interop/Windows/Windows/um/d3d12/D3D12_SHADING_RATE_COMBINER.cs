// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum D3D12_SHADING_RATE_COMBINER
    {
        D3D12_SHADING_RATE_COMBINER_PASSTHROUGH = 0,
        D3D12_SHADING_RATE_COMBINER_OVERRIDE = 1,
        D3D12_SHADING_RATE_COMBINER_MIN = 2,
        D3D12_SHADING_RATE_COMBINER_MAX = 3,
        D3D12_SHADING_RATE_COMBINER_SUM = 4,
    }
}
