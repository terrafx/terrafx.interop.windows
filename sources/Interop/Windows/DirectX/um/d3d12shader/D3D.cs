// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX
{
    public static partial class D3D
    {
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
