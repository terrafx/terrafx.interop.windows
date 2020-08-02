// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int D3D_RETURN_PARAMETER_INDEX = -1;

        public const uint D3D_SHADER_REQUIRES_DOUBLES = 0x00000001;

        public const uint D3D_SHADER_REQUIRES_EARLY_DEPTH_STENCIL = 0x00000002;

        public const uint D3D_SHADER_REQUIRES_UAVS_AT_EVERY_STAGE = 0x00000004;

        public const uint D3D_SHADER_REQUIRES_64_UAVS = 0x00000008;

        public const uint D3D_SHADER_REQUIRES_MINIMUM_PRECISION = 0x00000010;

        public const uint D3D_SHADER_REQUIRES_11_1_DOUBLE_EXTENSIONS = 0x00000020;

        public const uint D3D_SHADER_REQUIRES_11_1_SHADER_EXTENSIONS = 0x00000040;

        public const uint D3D_SHADER_REQUIRES_LEVEL_9_COMPARISON_FILTERING = 0x00000080;

        public const uint D3D_SHADER_REQUIRES_TILED_RESOURCES = 0x00000100;

        public static D3D11_SHADER_VERSION_TYPE D3D11_SHVER_GET_TYPE(int _Version) => (D3D11_SHADER_VERSION_TYPE)((_Version >> 16) & 0xFFFF);

        public static int D3D11_SHVER_GET_MAJOR(int _Version) => (_Version >> 4) & 0xF;

        public static int D3D11_SHVER_GET_MINOR(int _Version) => (_Version >> 0) & 0xF;
    }
}
