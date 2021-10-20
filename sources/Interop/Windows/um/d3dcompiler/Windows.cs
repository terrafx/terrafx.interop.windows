// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcompiler.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DReadFileToBlob([NativeTypeName("LPCWSTR")] ushort* pFileName, ID3DBlob** ppContents);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DWriteBlobToFile(ID3DBlob* pBlob, [NativeTypeName("LPCWSTR")] ushort* pFileName, [NativeTypeName("BOOL")] int bOverwrite);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompile([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("LPCSTR")] sbyte* pSourceName, [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, ID3DInclude* pInclude, [NativeTypeName("LPCSTR")] sbyte* pEntrypoint, [NativeTypeName("LPCSTR")] sbyte* pTarget, [NativeTypeName("UINT")] uint Flags1, [NativeTypeName("UINT")] uint Flags2, ID3DBlob** ppCode, ID3DBlob** ppErrorMsgs);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompile2([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("LPCSTR")] sbyte* pSourceName, [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, ID3DInclude* pInclude, [NativeTypeName("LPCSTR")] sbyte* pEntrypoint, [NativeTypeName("LPCSTR")] sbyte* pTarget, [NativeTypeName("UINT")] uint Flags1, [NativeTypeName("UINT")] uint Flags2, [NativeTypeName("UINT")] uint SecondaryDataFlags, [NativeTypeName("LPCVOID")] void* pSecondaryData, [NativeTypeName("SIZE_T")] nuint SecondaryDataSize, ID3DBlob** ppCode, ID3DBlob** ppErrorMsgs);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompileFromFile([NativeTypeName("LPCWSTR")] ushort* pFileName, [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, ID3DInclude* pInclude, [NativeTypeName("LPCSTR")] sbyte* pEntrypoint, [NativeTypeName("LPCSTR")] sbyte* pTarget, [NativeTypeName("UINT")] uint Flags1, [NativeTypeName("UINT")] uint Flags2, ID3DBlob** ppCode, ID3DBlob** ppErrorMsgs);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DPreprocess([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("LPCSTR")] sbyte* pSourceName, [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, ID3DInclude* pInclude, ID3DBlob** ppCodeText, ID3DBlob** ppErrorMsgs);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetDebugInfo([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, ID3DBlob** ppDebugInfo);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DReflect([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("const IID &")] Guid* pInterface, void** ppReflector);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DReflectLibrary([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppReflector);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDisassemble([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("LPCSTR")] sbyte* szComments, ID3DBlob** ppDisassembly);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDisassembleRegion([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("LPCSTR")] sbyte* szComments, [NativeTypeName("SIZE_T")] nuint StartByteOffset, [NativeTypeName("SIZE_T")] nuint NumInsts, [NativeTypeName("SIZE_T *")] nuint* pFinishByteOffset, ID3DBlob** ppDisassembly);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCreateLinker([NativeTypeName("struct ID3D11Linker **")] ID3D11Linker** ppLinker);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DLoadModule([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint cbSrcDataSize, [NativeTypeName("struct ID3D11Module **")] ID3D11Module** ppModule);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCreateFunctionLinkingGraph([NativeTypeName("UINT")] uint uFlags, [NativeTypeName("struct ID3D11FunctionLinkingGraph **")] ID3D11FunctionLinkingGraph** ppFunctionLinkingGraph);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetTraceInstructionOffsets([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("SIZE_T")] nuint StartInstIndex, [NativeTypeName("SIZE_T")] nuint NumInsts, [NativeTypeName("SIZE_T *")] nuint* pOffsets, [NativeTypeName("SIZE_T *")] nuint* pTotalInsts);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetInputSignatureBlob([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, ID3DBlob** ppSignatureBlob);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetOutputSignatureBlob([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, ID3DBlob** ppSignatureBlob);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetInputAndOutputSignatureBlob([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, ID3DBlob** ppSignatureBlob);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DStripShader([NativeTypeName("LPCVOID")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("UINT")] uint uStripFlags, ID3DBlob** ppStrippedBlob);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetBlobPart([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, D3D_BLOB_PART Part, [NativeTypeName("UINT")] uint Flags, ID3DBlob** ppPart);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DSetBlobPart([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, D3D_BLOB_PART Part, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("LPCVOID")] void* pPart, [NativeTypeName("SIZE_T")] nuint PartSize, ID3DBlob** ppNewShader);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCreateBlob([NativeTypeName("SIZE_T")] nuint Size, ID3DBlob** ppBlob);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompressShaders([NativeTypeName("UINT")] uint uNumShaders, D3D_SHADER_DATA* pShaderData, [NativeTypeName("UINT")] uint uFlags, ID3DBlob** ppCompressedData);

        [DllImport("d3dcompiler_47", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDecompressShaders([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("UINT")] uint uNumShaders, [NativeTypeName("UINT")] uint uStartIndex, [NativeTypeName("UINT *")] uint* pIndices, [NativeTypeName("UINT")] uint uFlags, ID3DBlob** ppShaders, [NativeTypeName("UINT *")] uint* pTotalShaders);

        [NativeTypeName("#define D3DCOMPILER_DLL_W L\"d3dcompiler_47.dll\"")]
        public const string D3DCOMPILER_DLL_W = "d3dcompiler_47.dll";

        [NativeTypeName("#define D3DCOMPILER_DLL_A \"d3dcompiler_47.dll\"")]
        public static ReadOnlySpan<byte> D3DCOMPILER_DLL_A => new byte[] { 0x64, 0x33, 0x64, 0x63, 0x6F, 0x6D, 0x70, 0x69, 0x6C, 0x65, 0x72, 0x5F, 0x34, 0x37, 0x2E, 0x64, 0x6C, 0x6C, 0x00 };

        [NativeTypeName("#define D3D_COMPILER_VERSION 47")]
        public const int D3D_COMPILER_VERSION = 47;

        [NativeTypeName("#define D3DCOMPILER_DLL D3DCOMPILER_DLL_W")]
        public const string D3DCOMPILER_DLL = "d3dcompiler_47.dll";

        [NativeTypeName("#define D3DCOMPILE_DEBUG (1 << 0)")]
        public const int D3DCOMPILE_DEBUG = (1 << 0);

        [NativeTypeName("#define D3DCOMPILE_SKIP_VALIDATION (1 << 1)")]
        public const int D3DCOMPILE_SKIP_VALIDATION = (1 << 1);

        [NativeTypeName("#define D3DCOMPILE_SKIP_OPTIMIZATION (1 << 2)")]
        public const int D3DCOMPILE_SKIP_OPTIMIZATION = (1 << 2);

        [NativeTypeName("#define D3DCOMPILE_PACK_MATRIX_ROW_MAJOR (1 << 3)")]
        public const int D3DCOMPILE_PACK_MATRIX_ROW_MAJOR = (1 << 3);

        [NativeTypeName("#define D3DCOMPILE_PACK_MATRIX_COLUMN_MAJOR (1 << 4)")]
        public const int D3DCOMPILE_PACK_MATRIX_COLUMN_MAJOR = (1 << 4);

        [NativeTypeName("#define D3DCOMPILE_PARTIAL_PRECISION (1 << 5)")]
        public const int D3DCOMPILE_PARTIAL_PRECISION = (1 << 5);

        [NativeTypeName("#define D3DCOMPILE_FORCE_VS_SOFTWARE_NO_OPT (1 << 6)")]
        public const int D3DCOMPILE_FORCE_VS_SOFTWARE_NO_OPT = (1 << 6);

        [NativeTypeName("#define D3DCOMPILE_FORCE_PS_SOFTWARE_NO_OPT (1 << 7)")]
        public const int D3DCOMPILE_FORCE_PS_SOFTWARE_NO_OPT = (1 << 7);

        [NativeTypeName("#define D3DCOMPILE_NO_PRESHADER (1 << 8)")]
        public const int D3DCOMPILE_NO_PRESHADER = (1 << 8);

        [NativeTypeName("#define D3DCOMPILE_AVOID_FLOW_CONTROL (1 << 9)")]
        public const int D3DCOMPILE_AVOID_FLOW_CONTROL = (1 << 9);

        [NativeTypeName("#define D3DCOMPILE_PREFER_FLOW_CONTROL (1 << 10)")]
        public const int D3DCOMPILE_PREFER_FLOW_CONTROL = (1 << 10);

        [NativeTypeName("#define D3DCOMPILE_ENABLE_STRICTNESS (1 << 11)")]
        public const int D3DCOMPILE_ENABLE_STRICTNESS = (1 << 11);

        [NativeTypeName("#define D3DCOMPILE_ENABLE_BACKWARDS_COMPATIBILITY (1 << 12)")]
        public const int D3DCOMPILE_ENABLE_BACKWARDS_COMPATIBILITY = (1 << 12);

        [NativeTypeName("#define D3DCOMPILE_IEEE_STRICTNESS (1 << 13)")]
        public const int D3DCOMPILE_IEEE_STRICTNESS = (1 << 13);

        [NativeTypeName("#define D3DCOMPILE_OPTIMIZATION_LEVEL0 (1 << 14)")]
        public const int D3DCOMPILE_OPTIMIZATION_LEVEL0 = (1 << 14);

        [NativeTypeName("#define D3DCOMPILE_OPTIMIZATION_LEVEL1 0")]
        public const int D3DCOMPILE_OPTIMIZATION_LEVEL1 = 0;

        [NativeTypeName("#define D3DCOMPILE_OPTIMIZATION_LEVEL2 ((1 << 14) | (1 << 15))")]
        public const int D3DCOMPILE_OPTIMIZATION_LEVEL2 = ((1 << 14) | (1 << 15));

        [NativeTypeName("#define D3DCOMPILE_OPTIMIZATION_LEVEL3 (1 << 15)")]
        public const int D3DCOMPILE_OPTIMIZATION_LEVEL3 = (1 << 15);

        [NativeTypeName("#define D3DCOMPILE_RESERVED16 (1 << 16)")]
        public const int D3DCOMPILE_RESERVED16 = (1 << 16);

        [NativeTypeName("#define D3DCOMPILE_RESERVED17 (1 << 17)")]
        public const int D3DCOMPILE_RESERVED17 = (1 << 17);

        [NativeTypeName("#define D3DCOMPILE_WARNINGS_ARE_ERRORS (1 << 18)")]
        public const int D3DCOMPILE_WARNINGS_ARE_ERRORS = (1 << 18);

        [NativeTypeName("#define D3DCOMPILE_RESOURCES_MAY_ALIAS (1 << 19)")]
        public const int D3DCOMPILE_RESOURCES_MAY_ALIAS = (1 << 19);

        [NativeTypeName("#define D3DCOMPILE_ENABLE_UNBOUNDED_DESCRIPTOR_TABLES (1 << 20)")]
        public const int D3DCOMPILE_ENABLE_UNBOUNDED_DESCRIPTOR_TABLES = (1 << 20);

        [NativeTypeName("#define D3DCOMPILE_ALL_RESOURCES_BOUND (1 << 21)")]
        public const int D3DCOMPILE_ALL_RESOURCES_BOUND = (1 << 21);

        [NativeTypeName("#define D3DCOMPILE_DEBUG_NAME_FOR_SOURCE (1 << 22)")]
        public const int D3DCOMPILE_DEBUG_NAME_FOR_SOURCE = (1 << 22);

        [NativeTypeName("#define D3DCOMPILE_DEBUG_NAME_FOR_BINARY (1 << 23)")]
        public const int D3DCOMPILE_DEBUG_NAME_FOR_BINARY = (1 << 23);

        [NativeTypeName("#define D3DCOMPILE_EFFECT_CHILD_EFFECT (1 << 0)")]
        public const int D3DCOMPILE_EFFECT_CHILD_EFFECT = (1 << 0);

        [NativeTypeName("#define D3DCOMPILE_EFFECT_ALLOW_SLOW_OPS (1 << 1)")]
        public const int D3DCOMPILE_EFFECT_ALLOW_SLOW_OPS = (1 << 1);

        [NativeTypeName("#define D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_LATEST 0")]
        public const int D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_LATEST = 0;

        [NativeTypeName("#define D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_0 (1 << 4)")]
        public const int D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_0 = (1 << 4);

        [NativeTypeName("#define D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_1 (1 << 5)")]
        public const int D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_1 = (1 << 5);

        [NativeTypeName("#define D3D_COMPILE_STANDARD_FILE_INCLUDE ((ID3DInclude*)(UINT_PTR)1)")]
        public static ID3DInclude* D3D_COMPILE_STANDARD_FILE_INCLUDE => ((ID3DInclude*)((nuint)(1)));

        [NativeTypeName("#define D3DCOMPILE_SECDATA_MERGE_UAV_SLOTS 0x00000001")]
        public const int D3DCOMPILE_SECDATA_MERGE_UAV_SLOTS = 0x00000001;

        [NativeTypeName("#define D3DCOMPILE_SECDATA_PRESERVE_TEMPLATE_SLOTS 0x00000002")]
        public const int D3DCOMPILE_SECDATA_PRESERVE_TEMPLATE_SLOTS = 0x00000002;

        [NativeTypeName("#define D3DCOMPILE_SECDATA_REQUIRE_TEMPLATE_MATCH 0x00000004")]
        public const int D3DCOMPILE_SECDATA_REQUIRE_TEMPLATE_MATCH = 0x00000004;

        [NativeTypeName("#define D3D_DISASM_ENABLE_COLOR_CODE 0x00000001")]
        public const int D3D_DISASM_ENABLE_COLOR_CODE = 0x00000001;

        [NativeTypeName("#define D3D_DISASM_ENABLE_DEFAULT_VALUE_PRINTS 0x00000002")]
        public const int D3D_DISASM_ENABLE_DEFAULT_VALUE_PRINTS = 0x00000002;

        [NativeTypeName("#define D3D_DISASM_ENABLE_INSTRUCTION_NUMBERING 0x00000004")]
        public const int D3D_DISASM_ENABLE_INSTRUCTION_NUMBERING = 0x00000004;

        [NativeTypeName("#define D3D_DISASM_ENABLE_INSTRUCTION_CYCLE 0x00000008")]
        public const int D3D_DISASM_ENABLE_INSTRUCTION_CYCLE = 0x00000008;

        [NativeTypeName("#define D3D_DISASM_DISABLE_DEBUG_INFO 0x00000010")]
        public const int D3D_DISASM_DISABLE_DEBUG_INFO = 0x00000010;

        [NativeTypeName("#define D3D_DISASM_ENABLE_INSTRUCTION_OFFSET 0x00000020")]
        public const int D3D_DISASM_ENABLE_INSTRUCTION_OFFSET = 0x00000020;

        [NativeTypeName("#define D3D_DISASM_INSTRUCTION_ONLY 0x00000040")]
        public const int D3D_DISASM_INSTRUCTION_ONLY = 0x00000040;

        [NativeTypeName("#define D3D_DISASM_PRINT_HEX_LITERALS 0x00000080")]
        public const int D3D_DISASM_PRINT_HEX_LITERALS = 0x00000080;

        [NativeTypeName("#define D3D_GET_INST_OFFSETS_INCLUDE_NON_EXECUTABLE 0x00000001")]
        public const int D3D_GET_INST_OFFSETS_INCLUDE_NON_EXECUTABLE = 0x00000001;

        [NativeTypeName("#define D3D_COMPRESS_SHADER_KEEP_ALL_PARTS 0x00000001")]
        public const int D3D_COMPRESS_SHADER_KEEP_ALL_PARTS = 0x00000001;
    }
}
