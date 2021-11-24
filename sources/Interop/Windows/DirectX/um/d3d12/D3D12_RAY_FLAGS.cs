// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

[Flags]
public enum D3D12_RAY_FLAGS
{
    D3D12_RAY_FLAG_NONE = 0,
    D3D12_RAY_FLAG_FORCE_OPAQUE = 0x1,
    D3D12_RAY_FLAG_FORCE_NON_OPAQUE = 0x2,
    D3D12_RAY_FLAG_ACCEPT_FIRST_HIT_AND_END_SEARCH = 0x4,
    D3D12_RAY_FLAG_SKIP_CLOSEST_HIT_SHADER = 0x8,
    D3D12_RAY_FLAG_CULL_BACK_FACING_TRIANGLES = 0x10,
    D3D12_RAY_FLAG_CULL_FRONT_FACING_TRIANGLES = 0x20,
    D3D12_RAY_FLAG_CULL_OPAQUE = 0x40,
    D3D12_RAY_FLAG_CULL_NON_OPAQUE = 0x80,
    D3D12_RAY_FLAG_SKIP_TRIANGLES = 0x100,
    D3D12_RAY_FLAG_SKIP_PROCEDURAL_PRIMITIVES = 0x200,
}
