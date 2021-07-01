// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10Blob = new Guid(0x8ba5fb08, 0x5195, 0x40e2, 0xac, 0x58, 0xd, 0x98, 0x9c, 0x3a, 0x1, 0x2);

        [NativeTypeName("const GUID")]
        public static readonly Guid WKPDID_D3DDebugObjectName = new Guid(0x429b8c22, 0x9188, 0x4b0c, 0x87, 0x42, 0xac, 0xb0, 0xbf, 0x85, 0xc2, 0x00);

        [NativeTypeName("const GUID")]
        public static readonly Guid WKPDID_D3DDebugObjectNameW = new Guid(0x4cca5fd8, 0x921f, 0x42c8, 0x85, 0x66, 0x70, 0xca, 0xf2, 0xa9, 0xb7, 0x41);

        [NativeTypeName("const GUID")]
        public static readonly Guid WKPDID_CommentStringW = new Guid(0xd0149dc0, 0x90e8, 0x4ec8, 0x81, 0x44, 0xe9, 0x00, 0xad, 0x26, 0x6b, 0xb2);

        [NativeTypeName("const GUID")]
        public static readonly Guid WKPDID_D3D12UniqueObjectId = new Guid(0x1b39de15, 0xec04, 0x4bae, 0xba, 0x4d, 0x8c, 0xef, 0x79, 0xfc, 0x04, 0xc1);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D_TEXTURE_LAYOUT_ROW_MAJOR = new Guid(0xb5dc234f, 0x72bb, 0x4bec, 0x97, 0x05, 0x8c, 0xf2, 0x58, 0xdf, 0x6b, 0x6c);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE = new Guid(0x4c0f29e3, 0x3f5f, 0x4d35, 0x84, 0xc9, 0xbc, 0x09, 0x83, 0xb6, 0x2c, 0x28);

        [NativeTypeName("#define D3D_FL9_1_REQ_TEXTURE1D_U_DIMENSION 2048")]
        public const int D3D_FL9_1_REQ_TEXTURE1D_U_DIMENSION = 2048;

        [NativeTypeName("#define D3D_FL9_3_REQ_TEXTURE1D_U_DIMENSION 4096")]
        public const int D3D_FL9_3_REQ_TEXTURE1D_U_DIMENSION = 4096;

        [NativeTypeName("#define D3D_FL9_1_REQ_TEXTURE2D_U_OR_V_DIMENSION 2048")]
        public const int D3D_FL9_1_REQ_TEXTURE2D_U_OR_V_DIMENSION = 2048;

        [NativeTypeName("#define D3D_FL9_3_REQ_TEXTURE2D_U_OR_V_DIMENSION 4096")]
        public const int D3D_FL9_3_REQ_TEXTURE2D_U_OR_V_DIMENSION = 4096;

        [NativeTypeName("#define D3D_FL9_1_REQ_TEXTURECUBE_DIMENSION 512")]
        public const int D3D_FL9_1_REQ_TEXTURECUBE_DIMENSION = 512;

        [NativeTypeName("#define D3D_FL9_3_REQ_TEXTURECUBE_DIMENSION 4096")]
        public const int D3D_FL9_3_REQ_TEXTURECUBE_DIMENSION = 4096;

        [NativeTypeName("#define D3D_FL9_1_REQ_TEXTURE3D_U_V_OR_W_DIMENSION 256")]
        public const int D3D_FL9_1_REQ_TEXTURE3D_U_V_OR_W_DIMENSION = 256;

        [NativeTypeName("#define D3D_FL9_1_DEFAULT_MAX_ANISOTROPY 2")]
        public const int D3D_FL9_1_DEFAULT_MAX_ANISOTROPY = 2;

        [NativeTypeName("#define D3D_FL9_1_IA_PRIMITIVE_MAX_COUNT 65535")]
        public const int D3D_FL9_1_IA_PRIMITIVE_MAX_COUNT = 65535;

        [NativeTypeName("#define D3D_FL9_2_IA_PRIMITIVE_MAX_COUNT 1048575")]
        public const int D3D_FL9_2_IA_PRIMITIVE_MAX_COUNT = 1048575;

        [NativeTypeName("#define D3D_FL9_1_SIMULTANEOUS_RENDER_TARGET_COUNT 1")]
        public const int D3D_FL9_1_SIMULTANEOUS_RENDER_TARGET_COUNT = 1;

        [NativeTypeName("#define D3D_FL9_3_SIMULTANEOUS_RENDER_TARGET_COUNT 4")]
        public const int D3D_FL9_3_SIMULTANEOUS_RENDER_TARGET_COUNT = 4;

        [NativeTypeName("#define D3D_FL9_1_MAX_TEXTURE_REPEAT 128")]
        public const int D3D_FL9_1_MAX_TEXTURE_REPEAT = 128;

        [NativeTypeName("#define D3D_FL9_2_MAX_TEXTURE_REPEAT 2048")]
        public const int D3D_FL9_2_MAX_TEXTURE_REPEAT = 2048;

        [NativeTypeName("#define D3D_FL9_3_MAX_TEXTURE_REPEAT 8192")]
        public const int D3D_FL9_3_MAX_TEXTURE_REPEAT = 8192;

        [NativeTypeName("#define D3D_SHADER_FEATURE_DOUBLES 0x00001")]
        public const int D3D_SHADER_FEATURE_DOUBLES = 0x00001;

        [NativeTypeName("#define D3D_SHADER_FEATURE_COMPUTE_SHADERS_PLUS_RAW_AND_STRUCTURED_BUFFERS_VIA_SHADER_4_X 0x00002")]
        public const int D3D_SHADER_FEATURE_COMPUTE_SHADERS_PLUS_RAW_AND_STRUCTURED_BUFFERS_VIA_SHADER_4_X = 0x00002;

        [NativeTypeName("#define D3D_SHADER_FEATURE_UAVS_AT_EVERY_STAGE 0x00004")]
        public const int D3D_SHADER_FEATURE_UAVS_AT_EVERY_STAGE = 0x00004;

        [NativeTypeName("#define D3D_SHADER_FEATURE_64_UAVS 0x00008")]
        public const int D3D_SHADER_FEATURE_64_UAVS = 0x00008;

        [NativeTypeName("#define D3D_SHADER_FEATURE_MINIMUM_PRECISION 0x00010")]
        public const int D3D_SHADER_FEATURE_MINIMUM_PRECISION = 0x00010;

        [NativeTypeName("#define D3D_SHADER_FEATURE_11_1_DOUBLE_EXTENSIONS 0x00020")]
        public const int D3D_SHADER_FEATURE_11_1_DOUBLE_EXTENSIONS = 0x00020;

        [NativeTypeName("#define D3D_SHADER_FEATURE_11_1_SHADER_EXTENSIONS 0x00040")]
        public const int D3D_SHADER_FEATURE_11_1_SHADER_EXTENSIONS = 0x00040;

        [NativeTypeName("#define D3D_SHADER_FEATURE_LEVEL_9_COMPARISON_FILTERING 0x00080")]
        public const int D3D_SHADER_FEATURE_LEVEL_9_COMPARISON_FILTERING = 0x00080;

        [NativeTypeName("#define D3D_SHADER_FEATURE_TILED_RESOURCES 0x00100")]
        public const int D3D_SHADER_FEATURE_TILED_RESOURCES = 0x00100;

        [NativeTypeName("#define D3D_SHADER_FEATURE_STENCIL_REF 0x00200")]
        public const int D3D_SHADER_FEATURE_STENCIL_REF = 0x00200;

        [NativeTypeName("#define D3D_SHADER_FEATURE_INNER_COVERAGE 0x00400")]
        public const int D3D_SHADER_FEATURE_INNER_COVERAGE = 0x00400;

        [NativeTypeName("#define D3D_SHADER_FEATURE_TYPED_UAV_LOAD_ADDITIONAL_FORMATS 0x00800")]
        public const int D3D_SHADER_FEATURE_TYPED_UAV_LOAD_ADDITIONAL_FORMATS = 0x00800;

        [NativeTypeName("#define D3D_SHADER_FEATURE_ROVS 0x01000")]
        public const int D3D_SHADER_FEATURE_ROVS = 0x01000;

        [NativeTypeName("#define D3D_SHADER_FEATURE_VIEWPORT_AND_RT_ARRAY_INDEX_FROM_ANY_SHADER_FEEDING_RASTERIZER 0x02000")]
        public const int D3D_SHADER_FEATURE_VIEWPORT_AND_RT_ARRAY_INDEX_FROM_ANY_SHADER_FEEDING_RASTERIZER = 0x02000;

        [NativeTypeName("#define D3D_SHADER_FEATURE_WAVE_OPS 0x04000")]
        public const int D3D_SHADER_FEATURE_WAVE_OPS = 0x04000;

        [NativeTypeName("#define D3D_SHADER_FEATURE_INT64_OPS 0x08000")]
        public const int D3D_SHADER_FEATURE_INT64_OPS = 0x08000;

        [NativeTypeName("#define D3D_SHADER_FEATURE_VIEW_ID 0x10000")]
        public const int D3D_SHADER_FEATURE_VIEW_ID = 0x10000;

        [NativeTypeName("#define D3D_SHADER_FEATURE_BARYCENTRICS 0x20000")]
        public const int D3D_SHADER_FEATURE_BARYCENTRICS = 0x20000;

        [NativeTypeName("#define D3D_SHADER_FEATURE_NATIVE_16BIT_OPS 0x40000")]
        public const int D3D_SHADER_FEATURE_NATIVE_16BIT_OPS = 0x40000;

        [NativeTypeName("#define D3D_SHADER_FEATURE_SHADING_RATE 0x80000")]
        public const int D3D_SHADER_FEATURE_SHADING_RATE = 0x80000;

        [NativeTypeName("#define D3D_SHADER_FEATURE_RAYTRACING_TIER_1_1 0x100000")]
        public const int D3D_SHADER_FEATURE_RAYTRACING_TIER_1_1 = 0x100000;

        [NativeTypeName("#define D3D_SHADER_FEATURE_SAMPLER_FEEDBACK 0x200000")]
        public const int D3D_SHADER_FEATURE_SAMPLER_FEEDBACK = 0x200000;

        [NativeTypeName("#define IID_ID3DBlob IID_ID3D10Blob")]
        public static readonly Guid IID_ID3DBlob = IID_ID3D10Blob;

        [NativeTypeName("#define D3D_COMPONENT_MASK_X 1")]
        public const int D3D_COMPONENT_MASK_X = 1;

        [NativeTypeName("#define D3D_COMPONENT_MASK_Y 2")]
        public const int D3D_COMPONENT_MASK_Y = 2;

        [NativeTypeName("#define D3D_COMPONENT_MASK_Z 4")]
        public const int D3D_COMPONENT_MASK_Z = 4;

        [NativeTypeName("#define D3D_COMPONENT_MASK_W 8")]
        public const int D3D_COMPONENT_MASK_W = 8;

        public static readonly Guid IID_ID3DDestructionNotifier = new Guid(0xA06EB39A, 0x50DA, 0x425B, 0x8C, 0x31, 0x4E, 0xEC, 0xD6, 0xC2, 0x70, 0xF3);
    }
}
