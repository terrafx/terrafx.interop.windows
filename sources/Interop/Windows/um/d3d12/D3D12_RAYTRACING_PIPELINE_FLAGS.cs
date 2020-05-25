// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D12_RAYTRACING_PIPELINE_FLAGS
    {
        D3D12_RAYTRACING_PIPELINE_FLAG_NONE = 0,
        D3D12_RAYTRACING_PIPELINE_FLAG_SKIP_TRIANGLES = 0x100,
        D3D12_RAYTRACING_PIPELINE_FLAG_SKIP_PROCEDURAL_PRIMITIVES = 0x200,
    }
}
