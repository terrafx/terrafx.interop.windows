// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    [Flags]
    public enum D3D12_RAYTRACING_INSTANCE_FLAGS
    {
        D3D12_RAYTRACING_INSTANCE_FLAG_NONE = 0,
        D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_CULL_DISABLE = 0x1,
        D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_FRONT_COUNTERCLOCKWISE = 0x2,
        D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_OPAQUE = 0x4,
        D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_NON_OPAQUE = 0x8,
    }
}
