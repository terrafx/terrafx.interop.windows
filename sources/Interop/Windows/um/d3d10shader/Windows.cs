// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D10ShaderReflectionType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7D, 0xAD, 0x30, 0xC5,
                    0x16, 0x9B,
                    0x95, 0x43,
                    0xA9,
                    0x79,
                    0xBA,
                    0x2E,
                    0xCF,
                    0xF8,
                    0x3A,
                    0xDD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D10ShaderReflectionVariable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x95, 0x3C, 0xF6, 0x1B,
                    0x50, 0x26,
                    0x5D, 0x40,
                    0x99,
                    0xC1,
                    0x36,
                    0x36,
                    0xBD,
                    0x1D,
                    0xA0,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D10ShaderReflectionConstantBuffer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x94, 0x6A, 0xC6, 0x66,
                    0xDD, 0xDD,
                    0x62, 0x4B,
                    0xA6,
                    0x6A,
                    0xF0,
                    0xDA,
                    0x33,
                    0xC2,
                    0xB4,
                    0xD0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D10ShaderReflection
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB6, 0x20, 0x0E, 0xD4,
                    0xF7, 0xF8,
                    0xAD, 0x42,
                    0xAB,
                    0x20,
                    0x4B,
                    0xAF,
                    0x8F,
                    0x15,
                    0xDF,
                    0xAA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10CompileShader([NativeTypeName("LPCSTR")] sbyte* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("const D3D10_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, [NativeTypeName("LPD3D10INCLUDE")] ID3DInclude* pInclude, [NativeTypeName("LPCSTR")] sbyte* pFunctionName, [NativeTypeName("LPCSTR")] sbyte* pProfile, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppShader, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppErrorMsgs);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10DisassembleShader([NativeTypeName("const void *")] void* pShader, [NativeTypeName("SIZE_T")] nuint BytecodeLength, BOOL EnableColorCode, [NativeTypeName("LPCSTR")] sbyte* pComments, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppDisassembly);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("LPCSTR")]
        public static extern sbyte* D3D10GetPixelShaderProfile(ID3D10Device* pDevice);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("LPCSTR")]
        public static extern sbyte* D3D10GetVertexShaderProfile(ID3D10Device* pDevice);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("LPCSTR")]
        public static extern sbyte* D3D10GetGeometryShaderProfile(ID3D10Device* pDevice);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10ReflectShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D10ShaderReflection** ppReflector);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10PreprocessShader([NativeTypeName("LPCSTR")] sbyte* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("const D3D10_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, [NativeTypeName("LPD3D10INCLUDE")] ID3DInclude* pInclude, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppShaderText, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppErrorMsgs);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10GetInputSignatureBlob([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppSignatureBlob);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10GetOutputSignatureBlob([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppSignatureBlob);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10GetInputAndOutputSignatureBlob([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppSignatureBlob);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10GetShaderDebugInfo([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppDebugInfo);

        [NativeTypeName("#define D3D10_SHADER_DEBUG (1 << 0)")]
        public const int D3D10_SHADER_DEBUG = (1 << 0);

        [NativeTypeName("#define D3D10_SHADER_SKIP_VALIDATION (1 << 1)")]
        public const int D3D10_SHADER_SKIP_VALIDATION = (1 << 1);

        [NativeTypeName("#define D3D10_SHADER_SKIP_OPTIMIZATION (1 << 2)")]
        public const int D3D10_SHADER_SKIP_OPTIMIZATION = (1 << 2);

        [NativeTypeName("#define D3D10_SHADER_PACK_MATRIX_ROW_MAJOR (1 << 3)")]
        public const int D3D10_SHADER_PACK_MATRIX_ROW_MAJOR = (1 << 3);

        [NativeTypeName("#define D3D10_SHADER_PACK_MATRIX_COLUMN_MAJOR (1 << 4)")]
        public const int D3D10_SHADER_PACK_MATRIX_COLUMN_MAJOR = (1 << 4);

        [NativeTypeName("#define D3D10_SHADER_PARTIAL_PRECISION (1 << 5)")]
        public const int D3D10_SHADER_PARTIAL_PRECISION = (1 << 5);

        [NativeTypeName("#define D3D10_SHADER_FORCE_VS_SOFTWARE_NO_OPT (1 << 6)")]
        public const int D3D10_SHADER_FORCE_VS_SOFTWARE_NO_OPT = (1 << 6);

        [NativeTypeName("#define D3D10_SHADER_FORCE_PS_SOFTWARE_NO_OPT (1 << 7)")]
        public const int D3D10_SHADER_FORCE_PS_SOFTWARE_NO_OPT = (1 << 7);

        [NativeTypeName("#define D3D10_SHADER_NO_PRESHADER (1 << 8)")]
        public const int D3D10_SHADER_NO_PRESHADER = (1 << 8);

        [NativeTypeName("#define D3D10_SHADER_AVOID_FLOW_CONTROL (1 << 9)")]
        public const int D3D10_SHADER_AVOID_FLOW_CONTROL = (1 << 9);

        [NativeTypeName("#define D3D10_SHADER_PREFER_FLOW_CONTROL (1 << 10)")]
        public const int D3D10_SHADER_PREFER_FLOW_CONTROL = (1 << 10);

        [NativeTypeName("#define D3D10_SHADER_ENABLE_STRICTNESS (1 << 11)")]
        public const int D3D10_SHADER_ENABLE_STRICTNESS = (1 << 11);

        [NativeTypeName("#define D3D10_SHADER_ENABLE_BACKWARDS_COMPATIBILITY (1 << 12)")]
        public const int D3D10_SHADER_ENABLE_BACKWARDS_COMPATIBILITY = (1 << 12);

        [NativeTypeName("#define D3D10_SHADER_IEEE_STRICTNESS (1 << 13)")]
        public const int D3D10_SHADER_IEEE_STRICTNESS = (1 << 13);

        [NativeTypeName("#define D3D10_SHADER_WARNINGS_ARE_ERRORS (1 << 18)")]
        public const int D3D10_SHADER_WARNINGS_ARE_ERRORS = (1 << 18);

        [NativeTypeName("#define D3D10_SHADER_RESOURCES_MAY_ALIAS (1 << 19)")]
        public const int D3D10_SHADER_RESOURCES_MAY_ALIAS = (1 << 19);

        [NativeTypeName("#define D3D10_ENABLE_UNBOUNDED_DESCRIPTOR_TABLES (1 << 20)")]
        public const int D3D10_ENABLE_UNBOUNDED_DESCRIPTOR_TABLES = (1 << 20);

        [NativeTypeName("#define D3D10_ALL_RESOURCES_BOUND (1 << 21)")]
        public const int D3D10_ALL_RESOURCES_BOUND = (1 << 21);

        [NativeTypeName("#define D3D10_SHADER_DEBUG_NAME_FOR_SOURCE (1 << 22)")]
        public const int D3D10_SHADER_DEBUG_NAME_FOR_SOURCE = (1 << 22);

        [NativeTypeName("#define D3D10_SHADER_DEBUG_NAME_FOR_BINARY (1 << 23)")]
        public const int D3D10_SHADER_DEBUG_NAME_FOR_BINARY = (1 << 23);

        [NativeTypeName("#define D3D10_SHADER_OPTIMIZATION_LEVEL0 (1 << 14)")]
        public const int D3D10_SHADER_OPTIMIZATION_LEVEL0 = (1 << 14);

        [NativeTypeName("#define D3D10_SHADER_OPTIMIZATION_LEVEL1 0")]
        public const int D3D10_SHADER_OPTIMIZATION_LEVEL1 = 0;

        [NativeTypeName("#define D3D10_SHADER_OPTIMIZATION_LEVEL2 ((1 << 14) | (1 << 15))")]
        public const int D3D10_SHADER_OPTIMIZATION_LEVEL2 = ((1 << 14) | (1 << 15));

        [NativeTypeName("#define D3D10_SHADER_OPTIMIZATION_LEVEL3 (1 << 15)")]
        public const int D3D10_SHADER_OPTIMIZATION_LEVEL3 = (1 << 15);

        [NativeTypeName("#define D3D10_SHADER_FLAGS2_FORCE_ROOT_SIGNATURE_LATEST 0")]
        public const int D3D10_SHADER_FLAGS2_FORCE_ROOT_SIGNATURE_LATEST = 0;

        [NativeTypeName("#define D3D10_SHADER_FLAGS2_FORCE_ROOT_SIGNATURE_1_0 (1 << 4)")]
        public const int D3D10_SHADER_FLAGS2_FORCE_ROOT_SIGNATURE_1_0 = (1 << 4);

        [NativeTypeName("#define D3D10_SHADER_FLAGS2_FORCE_ROOT_SIGNATURE_1_1 (1 << 5)")]
        public const int D3D10_SHADER_FLAGS2_FORCE_ROOT_SIGNATURE_1_1 = (1 << 5);
    }
}
