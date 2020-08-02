// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const uint D3D_SHADER_REQUIRES_STENCIL_REF = 0x00000200;

        public const uint D3D_SHADER_REQUIRES_INNER_COVERAGE = 0x00000400;

        public const uint D3D_SHADER_REQUIRES_TYPED_UAV_LOAD_ADDITIONAL_FORMATS = 0x00000800;

        public const uint D3D_SHADER_REQUIRES_ROVS = 0x00001000;

        public const uint D3D_SHADER_REQUIRES_VIEWPORT_AND_RT_ARRAY_INDEX_FROM_ANY_SHADER_FEEDING_RASTERIZER = 0x00002000;

        public static D3D12_SHADER_VERSION_TYPE D3D12_SHVER_GET_TYPE(int _Version) => (D3D12_SHADER_VERSION_TYPE)((_Version >> 16) & 0xFFFF);

        public static int D3D12_SHVER_GET_MAJOR(int _Version) => (_Version >> 4) & 0xF;

        public static int D3D12_SHVER_GET_MINOR(int _Version) => (_Version >> 0) & 0xF;
    }
}
