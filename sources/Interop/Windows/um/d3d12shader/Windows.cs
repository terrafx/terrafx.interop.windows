// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12ShaderReflectionType = new Guid(0xe913c351, 0x783d, 0x48ca, 0xa1, 0xd1, 0x4f, 0x30, 0x62, 0x84, 0xad, 0x56);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12ShaderReflectionVariable = new Guid(0x8337a8a6, 0xa216, 0x444a, 0xb2, 0xf4, 0x31, 0x47, 0x33, 0xa7, 0x3a, 0xea);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12ShaderReflectionConstantBuffer = new Guid(0xc59598b4, 0x48b3, 0x4869, 0xb9, 0xb1, 0xb1, 0x61, 0x8b, 0x14, 0xa8, 0xb7);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12ShaderReflection = new Guid(0x5a58797d, 0xa72c, 0x478d, 0x8b, 0xa2, 0xef, 0xc6, 0xb0, 0xef, 0xe8, 0x8e);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12LibraryReflection = new Guid(0x8e349d19, 0x54db, 0x4a56, 0x9d, 0xc9, 0x11, 0x9d, 0x87, 0xbd, 0xb8, 0x4);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12FunctionReflection = new Guid(0x1108795c, 0x2772, 0x4ba9, 0xb2, 0xa8, 0xd4, 0x64, 0xdc, 0x7e, 0x27, 0x99);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12FunctionParameterReflection = new Guid(0xec25f42d, 0x7006, 0x4f2b, 0xb3, 0x3e, 0x2, 0xcc, 0x33, 0x75, 0x73, 0x3f);

        [NativeTypeName("#define D3D_SHADER_REQUIRES_STENCIL_REF 0x00000200")]
        public const int D3D_SHADER_REQUIRES_STENCIL_REF = 0x00000200;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_INNER_COVERAGE 0x00000400")]
        public const int D3D_SHADER_REQUIRES_INNER_COVERAGE = 0x00000400;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_TYPED_UAV_LOAD_ADDITIONAL_FORMATS 0x00000800")]
        public const int D3D_SHADER_REQUIRES_TYPED_UAV_LOAD_ADDITIONAL_FORMATS = 0x00000800;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_ROVS 0x00001000")]
        public const int D3D_SHADER_REQUIRES_ROVS = 0x00001000;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_VIEWPORT_AND_RT_ARRAY_INDEX_FROM_ANY_SHADER_FEEDING_RASTERIZER 0x00002000")]
        public const int D3D_SHADER_REQUIRES_VIEWPORT_AND_RT_ARRAY_INDEX_FROM_ANY_SHADER_FEEDING_RASTERIZER = 0x00002000;
    }
}
