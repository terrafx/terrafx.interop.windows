// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D12_BACKGROUND_PROCESSING_MODE
    {
        D3D12_BACKGROUND_PROCESSING_MODE_ALLOWED = 0,
        D3D12_BACKGROUND_PROCESSING_MODE_ALLOW_INTRUSIVE_MEASUREMENTS = (D3D12_BACKGROUND_PROCESSING_MODE_ALLOWED + 1),
        D3D12_BACKGROUND_PROCESSING_MODE_DISABLE_BACKGROUND_WORK = (D3D12_BACKGROUND_PROCESSING_MODE_ALLOW_INTRUSIVE_MEASUREMENTS + 1),
        D3D12_BACKGROUND_PROCESSING_MODE_DISABLE_PROFILING_BY_SYSTEM = (D3D12_BACKGROUND_PROCESSING_MODE_DISABLE_BACKGROUND_WORK + 1),
    }
}
