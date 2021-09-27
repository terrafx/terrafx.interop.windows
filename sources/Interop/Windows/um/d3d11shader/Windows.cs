// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11ShaderReflectionType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6A, 0xFA, 0x6F, 0x6E,
                    0xAE, 0x9B,
                    0x13, 0x46,
                    0xA5,
                    0x1E,
                    0x91,
                    0x65,
                    0x2D,
                    0x50,
                    0x8C,
                    0x21
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11ShaderReflectionVariable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x23, 0x39, 0xF2, 0x51,
                    0xE5, 0xF3,
                    0xD1, 0x4B,
                    0x91,
                    0xCB,
                    0x60,
                    0x61,
                    0x77,
                    0xD8,
                    0xDB,
                    0x4C
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11ShaderReflectionConstantBuffer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3D, 0xD6, 0x62, 0xEB,
                    0xDD, 0x93,
                    0x18, 0x43,
                    0x8A,
                    0xE8,
                    0xC6,
                    0xF8,
                    0x3A,
                    0xD3,
                    0x71,
                    0xB8
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11ShaderReflection
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA1, 0x6C, 0x53, 0x8D,
                    0xCA, 0x0C,
                    0x56, 0x49,
                    0xA8,
                    0x37,
                    0x78,
                    0x69,
                    0x63,
                    0x75,
                    0x55,
                    0x84
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11LibraryReflection
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1B, 0x4F, 0x38, 0x54,
                    0x3E, 0x5B,
                    0xB7, 0x4B,
                    0xAE,
                    0x01,
                    0x60,
                    0xBA,
                    0x30,
                    0x97,
                    0xCB,
                    0xB6
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11FunctionReflection
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCB, 0xCE, 0x7B, 0x20,
                    0x83, 0xD6,
                    0x06, 0x4A,
                    0xA8,
                    0xA3,
                    0x9B,
                    0x14,
                    0x9B,
                    0x9F,
                    0x73,
                    0xA4
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11FunctionParameterReflection
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x88, 0x74, 0x75, 0x42,
                    0x4F, 0x33,
                    0xFE, 0x47,
                    0x98,
                    0x2E,
                    0x1A,
                    0x65,
                    0xD0,
                    0x8C,
                    0xC4,
                    0x62
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11Module
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0x01, 0xC7, 0xCA,
                    0xFC, 0x80,
                    0x22, 0x41,
                    0x82,
                    0x42,
                    0x10,
                    0xB3,
                    0x9C,
                    0x8C,
                    0xEC,
                    0x34
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11ModuleInstance
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF7, 0x07, 0x9E, 0x46,
                    0x5A, 0x04,
                    0xD5, 0x48,
                    0xAA,
                    0x12,
                    0x68,
                    0xA4,
                    0x78,
                    0xCD,
                    0xF7,
                    0x5D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11Linker
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0E, 0xCD, 0xA6, 0x59,
                    0x0D, 0xE1,
                    0x1F, 0x4C,
                    0x88,
                    0xC0,
                    0x63,
                    0xAB,
                    0xA1,
                    0xDA,
                    0xF3,
                    0x0E
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11LinkingNode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0C, 0xD7, 0x0D, 0xD8,
                    0x2F, 0x8D,
                    0x51, 0x47,
                    0x94,
                    0xA1,
                    0x03,
                    0xC7,
                    0x9B,
                    0x35,
                    0x56,
                    0xDB
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11FunctionLinkingGraph
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0x32, 0x13, 0x54,
                    0xE8, 0x1C,
                    0xD3, 0x43,
                    0x82,
                    0x36,
                    0x98,
                    0x55,
                    0xC5,
                    0xCE,
                    0xEC,
                    0xFF
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("#define D3D_RETURN_PARAMETER_INDEX (-1)")]
        public const int D3D_RETURN_PARAMETER_INDEX = (-1);

        [NativeTypeName("#define D3D_SHADER_REQUIRES_DOUBLES 0x00000001")]
        public const int D3D_SHADER_REQUIRES_DOUBLES = 0x00000001;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_EARLY_DEPTH_STENCIL 0x00000002")]
        public const int D3D_SHADER_REQUIRES_EARLY_DEPTH_STENCIL = 0x00000002;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_UAVS_AT_EVERY_STAGE 0x00000004")]
        public const int D3D_SHADER_REQUIRES_UAVS_AT_EVERY_STAGE = 0x00000004;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_64_UAVS 0x00000008")]
        public const int D3D_SHADER_REQUIRES_64_UAVS = 0x00000008;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_MINIMUM_PRECISION 0x00000010")]
        public const int D3D_SHADER_REQUIRES_MINIMUM_PRECISION = 0x00000010;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_11_1_DOUBLE_EXTENSIONS 0x00000020")]
        public const int D3D_SHADER_REQUIRES_11_1_DOUBLE_EXTENSIONS = 0x00000020;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_11_1_SHADER_EXTENSIONS 0x00000040")]
        public const int D3D_SHADER_REQUIRES_11_1_SHADER_EXTENSIONS = 0x00000040;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_LEVEL_9_COMPARISON_FILTERING 0x00000080")]
        public const int D3D_SHADER_REQUIRES_LEVEL_9_COMPARISON_FILTERING = 0x00000080;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_TILED_RESOURCES 0x00000100")]
        public const int D3D_SHADER_REQUIRES_TILED_RESOURCES = 0x00000100;
    }
}
