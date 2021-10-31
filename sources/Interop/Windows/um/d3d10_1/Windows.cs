// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("d3d10_1", ExactSpelling = true)]
        public static extern HRESULT D3D10CreateDevice1(IDXGIAdapter* pAdapter, D3D10_DRIVER_TYPE DriverType, [NativeTypeName("HMODULE")] IntPtr Software, [NativeTypeName("UINT")] uint Flags, D3D10_FEATURE_LEVEL1 HardwareLevel, [NativeTypeName("UINT")] uint SDKVersion, ID3D10Device1** ppDevice);

        [DllImport("d3d10_1", ExactSpelling = true)]
        public static extern HRESULT D3D10CreateDeviceAndSwapChain1(IDXGIAdapter* pAdapter, D3D10_DRIVER_TYPE DriverType, [NativeTypeName("HMODULE")] IntPtr Software, [NativeTypeName("UINT")] uint Flags, D3D10_FEATURE_LEVEL1 HardwareLevel, [NativeTypeName("UINT")] uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D10Device1** ppDevice);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D10BlendState1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x99, 0x8D, 0xAD, 0xED,
                    0x35, 0x8A,
                    0x6D, 0x4D,
                    0x85,
                    0x66,
                    0x2E,
                    0xA2,
                    0x76,
                    0xCD,
                    0xE1,
                    0x61
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D10ShaderResourceView1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x87, 0x4C, 0x7E, 0x9B,
                    0x2C, 0x34,
                    0x06, 0x41,
                    0xA1,
                    0x9F,
                    0x4F,
                    0x27,
                    0x04,
                    0xF6,
                    0x89,
                    0xF0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D10Device1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8F, 0x4C, 0x7E, 0x9B,
                    0x2C, 0x34,
                    0x06, 0x41,
                    0xA1,
                    0x9F,
                    0x4F,
                    0x27,
                    0x04,
                    0xF6,
                    0x89,
                    0xF0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("#define D3D10_1_DEFAULT_SAMPLE_MASK ( 0xffffffff )")]
        public const uint D3D10_1_DEFAULT_SAMPLE_MASK = (0xffffffff);

        [NativeTypeName("#define D3D10_1_FLOAT16_FUSED_TOLERANCE_IN_ULP ( 0.6 )")]
        public const double D3D10_1_FLOAT16_FUSED_TOLERANCE_IN_ULP = (0.6);

        [NativeTypeName("#define D3D10_1_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP ( 0.6f )")]
        public const float D3D10_1_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP = (0.6f);

        [NativeTypeName("#define D3D10_1_GS_INPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D10_1_GS_INPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D10_1_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT ( 32 )")]
        public const int D3D10_1_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT = (32);

        [NativeTypeName("#define D3D10_1_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS ( 128 )")]
        public const int D3D10_1_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS = (128);

        [NativeTypeName("#define D3D10_1_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT ( 32 )")]
        public const int D3D10_1_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT = (32);

        [NativeTypeName("#define D3D10_1_PS_OUTPUT_MASK_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D10_1_PS_OUTPUT_MASK_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D10_1_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D10_1_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D10_1_PS_OUTPUT_MASK_REGISTER_COUNT ( 1 )")]
        public const int D3D10_1_PS_OUTPUT_MASK_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D10_1_SHADER_MAJOR_VERSION ( 4 )")]
        public const int D3D10_1_SHADER_MAJOR_VERSION = (4);

        [NativeTypeName("#define D3D10_1_SHADER_MINOR_VERSION ( 1 )")]
        public const int D3D10_1_SHADER_MINOR_VERSION = (1);

        [NativeTypeName("#define D3D10_1_SO_BUFFER_MAX_STRIDE_IN_BYTES ( 2048 )")]
        public const int D3D10_1_SO_BUFFER_MAX_STRIDE_IN_BYTES = (2048);

        [NativeTypeName("#define D3D10_1_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES ( 256 )")]
        public const int D3D10_1_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES = (256);

        [NativeTypeName("#define D3D10_1_SO_BUFFER_SLOT_COUNT ( 4 )")]
        public const int D3D10_1_SO_BUFFER_SLOT_COUNT = (4);

        [NativeTypeName("#define D3D10_1_SO_MULTIPLE_BUFFER_ELEMENTS_PER_BUFFER ( 1 )")]
        public const int D3D10_1_SO_MULTIPLE_BUFFER_ELEMENTS_PER_BUFFER = (1);

        [NativeTypeName("#define D3D10_1_SO_SINGLE_BUFFER_COMPONENT_LIMIT ( 64 )")]
        public const int D3D10_1_SO_SINGLE_BUFFER_COMPONENT_LIMIT = (64);

        [NativeTypeName("#define D3D10_1_STANDARD_VERTEX_ELEMENT_COUNT ( 32 )")]
        public const int D3D10_1_STANDARD_VERTEX_ELEMENT_COUNT = (32);

        [NativeTypeName("#define D3D10_1_SUBPIXEL_FRACTIONAL_BIT_COUNT ( 8 )")]
        public const int D3D10_1_SUBPIXEL_FRACTIONAL_BIT_COUNT = (8);

        [NativeTypeName("#define D3D10_1_VS_INPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D10_1_VS_INPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D10_1_VS_OUTPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D10_1_VS_OUTPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D10_1_SDK_VERSION ( ( 0 + 0x20 )  )")]
        public const int D3D10_1_SDK_VERSION = ((0 + 0x20));
    }
}
