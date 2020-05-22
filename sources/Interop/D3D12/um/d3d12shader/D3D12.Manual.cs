// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class D3D12
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

        public const uint D3D_SHADER_REQUIRES_STENCIL_REF = 0x00000200;

        public const uint D3D_SHADER_REQUIRES_INNER_COVERAGE = 0x00000400;

        public const uint D3D_SHADER_REQUIRES_TYPED_UAV_LOAD_ADDITIONAL_FORMATS = 0x00000800;

        public const uint D3D_SHADER_REQUIRES_ROVS = 0x00001000;

        public const uint D3D_SHADER_REQUIRES_VIEWPORT_AND_RT_ARRAY_INDEX_FROM_ANY_SHADER_FEEDING_RASTERIZER = 0x00002000;

        public static readonly Guid IID_ID3D12ShaderReflectionType = new Guid(0xE913C351, 0x783D, 0x48CA, 0xA1, 0xD1, 0x4F, 0x30, 0x62, 0x84, 0xAD, 0x56);

        public static readonly Guid IID_ID3D12ShaderReflectionVariable = new Guid(0x8337A8A6, 0xA216, 0x444A, 0xB2, 0xF4, 0x31, 0x47, 0x33, 0xA7, 0x3A, 0xEA);

        public static readonly Guid IID_ID3D12ShaderReflectionConstantBuffer = new Guid(0xC59598B4, 0x48B3, 0x4869, 0xB9, 0xB1, 0xB1, 0x61, 0x8B, 0x14, 0xA8, 0xB7);

        public static readonly Guid IID_ID3D12ShaderReflection = new Guid(0x5A58797D, 0xA72C, 0x478D, 0x8B, 0xA2, 0xEF, 0xC6, 0xB0, 0xEF, 0xE8, 0x8E);

        public static readonly Guid IID_ID3D12LibraryReflection = new Guid(0x8E349D19, 0x54DB, 0x4A56, 0x9D, 0xC9, 0x11, 0x9D, 0x87, 0xBD, 0xB8, 0x04);

        public static readonly Guid IID_ID3D12FunctionReflection = new Guid(0x1108795C, 0x2772, 0x4BA9, 0xB2, 0xA8, 0xD4, 0x64, 0xDC, 0x7E, 0x27, 0x99);

        public static readonly Guid IID_ID3D12FunctionParameterReflection = new Guid(0xEC25F42D, 0x7006, 0x4F2B, 0xB3, 0x3E, 0x02, 0xCC, 0x33, 0x75, 0x73, 0x3F);

        public static D3D12_SHADER_VERSION_TYPE D3D12_SHVER_GET_TYPE(int _Version) => (D3D12_SHADER_VERSION_TYPE)((_Version >> 16) & 0xFFFF);

        public static int D3D12_SHVER_GET_MAJOR(int _Version) => (_Version >> 4) & 0xF;

        public static int D3D12_SHVER_GET_MINOR(int _Version) => (_Version >> 0) & 0xF;
    }
}
