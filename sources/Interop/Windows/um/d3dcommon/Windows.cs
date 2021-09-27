// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D10Blob
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x08, 0xFB, 0xA5, 0x8B,
                    0x95, 0x51,
                    0xE2, 0x40,
                    0xAC,
                    0x58,
                    0x0D,
                    0x98,
                    0x9C,
                    0x3A,
                    0x01,
                    0x02
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid WKPDID_D3DDebugObjectName
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0x8C, 0x9B, 0x42,
                    0x88, 0x91,
                    0x0C, 0x4B,
                    0x87,
                    0x42,
                    0xAC,
                    0xB0,
                    0xBF,
                    0x85,
                    0xC2,
                    0x00
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid WKPDID_D3DDebugObjectNameW
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD8, 0x5F, 0xCA, 0x4C,
                    0x1F, 0x92,
                    0xC8, 0x42,
                    0x85,
                    0x66,
                    0x70,
                    0xCA,
                    0xF2,
                    0xA9,
                    0xB7,
                    0x41
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid WKPDID_CommentStringW
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC0, 0x9D, 0x14, 0xD0,
                    0xE8, 0x90,
                    0xC8, 0x4E,
                    0x81,
                    0x44,
                    0xE9,
                    0x00,
                    0xAD,
                    0x26,
                    0x6B,
                    0xB2
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid WKPDID_D3D12UniqueObjectId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x15, 0xDE, 0x39, 0x1B,
                    0x04, 0xEC,
                    0xAE, 0x4B,
                    0xBA,
                    0x4D,
                    0x8C,
                    0xEF,
                    0x79,
                    0xFC,
                    0x04,
                    0xC1
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D_TEXTURE_LAYOUT_ROW_MAJOR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4F, 0x23, 0xDC, 0xB5,
                    0xBB, 0x72,
                    0xEC, 0x4B,
                    0x97,
                    0x05,
                    0x8C,
                    0xF2,
                    0x58,
                    0xDF,
                    0x6B,
                    0x6C
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE3, 0x29, 0x0F, 0x4C,
                    0x5F, 0x3F,
                    0x35, 0x4D,
                    0x84,
                    0xC9,
                    0xBC,
                    0x09,
                    0x83,
                    0xB6,
                    0x2C,
                    0x28
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

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
        public static ref readonly Guid IID_ID3DBlob => ref IID_ID3D10Blob;

        [NativeTypeName("#define D3D_COMPONENT_MASK_X 1")]
        public const int D3D_COMPONENT_MASK_X = 1;

        [NativeTypeName("#define D3D_COMPONENT_MASK_Y 2")]
        public const int D3D_COMPONENT_MASK_Y = 2;

        [NativeTypeName("#define D3D_COMPONENT_MASK_Z 4")]
        public const int D3D_COMPONENT_MASK_Z = 4;

        [NativeTypeName("#define D3D_COMPONENT_MASK_W 8")]
        public const int D3D_COMPONENT_MASK_W = 8;

        public static ref readonly Guid IID_ID3DDestructionNotifier
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9A, 0xB3, 0x6E, 0xA0,
                    0xDA, 0x50,
                    0x5B, 0x42,
                    0x8C,
                    0x31,
                    0x4E,
                    0xEC,
                    0xD6,
                    0xC2,
                    0x70,
                    0xF3
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
