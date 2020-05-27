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

        public static readonly Guid IID_ID3D11ShaderReflectionType = new Guid(0x6E6FFA6A, 0x9BAE, 0x4613, 0xA5, 0x1E, 0x91, 0x65, 0x2D, 0x50, 0x8C, 0x21);

        public static readonly Guid IID_ID3D11ShaderReflectionVariable = new Guid(0x51F23923, 0xF3E5, 0x4BD1, 0x91, 0xCB, 0x60, 0x61, 0x77, 0xD8, 0xDB, 0x4C);

        public static readonly Guid IID_ID3D11ShaderReflectionConstantBuffer = new Guid(0xEB62D63D, 0x93DD, 0x4318, 0x8A, 0xE8, 0xC6, 0xF8, 0x3A, 0xD3, 0x71, 0xB8);

        public static readonly Guid IID_ID3D11ShaderReflection = new Guid(0x8D536CA1, 0x0CCA, 0x4956, 0xA8, 0x37, 0x78, 0x69, 0x63, 0x75, 0x55, 0x84);

        public static readonly Guid IID_ID3D11LibraryReflection = new Guid(0x54384F1B, 0x5B3E, 0x4BB7, 0xAE, 0x1, 0x60, 0xBA, 0x30, 0x97, 0xCB, 0xB6);

        public static readonly Guid IID_ID3D11FunctionReflection = new Guid(0x207BCECB, 0xD683, 0x4A06, 0xA8, 0xA3, 0x9B, 0x14, 0x9B, 0x9F, 0x73, 0xA4);

        public static readonly Guid IID_ID3D11FunctionParameterReflection = new Guid(0x42757488, 0x334F, 0x47FE, 0x98, 0x2E, 0x1A, 0x65, 0xD0, 0x8C, 0xC4, 0x62);

        public static readonly Guid IID_ID3D11Module = new Guid(0xCAC701EE, 0x80FC, 0x4122, 0x82, 0x42, 0x10, 0xB3, 0x9C, 0x8C, 0xEC, 0x34);

        public static readonly Guid IID_ID3D11ModuleInstance = new Guid(0x469E07F7, 0x45A, 0x48D5, 0xAA, 0x12, 0x68, 0xA4, 0x78, 0xCD, 0xF7, 0x5D);

        public static readonly Guid IID_ID3D11Linker = new Guid(0x59A6CD0E, 0xE10D, 0x4C1F, 0x88, 0xC0, 0x63, 0xAB, 0xA1, 0xDA, 0xF3, 0xE);

        public static readonly Guid IID_ID3D11LinkingNode = new Guid(0xD80DD70C, 0x8D2F, 0x4751, 0x94, 0xA1, 0x3, 0xC7, 0x9B, 0x35, 0x56, 0xDB);

        public static readonly Guid IID_ID3D11FunctionLinkingGraph = new Guid(0x54133220, 0x1CE8, 0x43D3, 0x82, 0x36, 0x98, 0x55, 0xC5, 0xCE, 0xEC, 0xFF);

        public static D3D11_SHADER_VERSION_TYPE D3D11_SHVER_GET_TYPE(int _Version) => (D3D11_SHADER_VERSION_TYPE)((_Version >> 16) & 0xFFFF);

        public static int D3D11_SHVER_GET_MAJOR(int _Version) => (_Version >> 4) & 0xF;

        public static int D3D11_SHVER_GET_MINOR(int _Version) => (_Version >> 0) & 0xF;
    }
}
