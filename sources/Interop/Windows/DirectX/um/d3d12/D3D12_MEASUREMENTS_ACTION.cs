// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public enum D3D12_MEASUREMENTS_ACTION
{
    D3D12_MEASUREMENTS_ACTION_KEEP_ALL = 0,
    D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS = (D3D12_MEASUREMENTS_ACTION_KEEP_ALL + 1),
    D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS_HIGH_PRIORITY = (D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS + 1),
    D3D12_MEASUREMENTS_ACTION_DISCARD_PREVIOUS = (D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS_HIGH_PRIORITY + 1),
}
