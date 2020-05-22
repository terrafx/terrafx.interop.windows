// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D12_DEBUG_DEVICE_PARAMETER_TYPE
    {
        D3D12_DEBUG_DEVICE_PARAMETER_FEATURE_FLAGS = 0,
        D3D12_DEBUG_DEVICE_PARAMETER_GPU_BASED_VALIDATION_SETTINGS = (D3D12_DEBUG_DEVICE_PARAMETER_FEATURE_FLAGS + 1),
        D3D12_DEBUG_DEVICE_PARAMETER_GPU_SLOWDOWN_PERFORMANCE_FACTOR = (D3D12_DEBUG_DEVICE_PARAMETER_GPU_BASED_VALIDATION_SETTINGS + 1),
    }
}
