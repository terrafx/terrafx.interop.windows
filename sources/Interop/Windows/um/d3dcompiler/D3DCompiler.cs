// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3dcompiler.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D3D12;

namespace TerraFX.Interop
{
    public static unsafe class D3DCompiler
    {
        public const string D3DCOMPILER_DLL = "D3DCompiler_47.dll";

        public const int D3D_COMPILER_VERSION = 47;

        public const uint D3D_COMPILE_STANDARD_FILE_INCLUDE = 1;

        public const uint D3D_GET_INST_OFFSETS_INCLUDE_NON_EXECUTABLE = 0x00000001;

        public const uint D3D_COMPRESS_SHADER_KEEP_ALL_PARTS = 0x00000001;

        public const uint D3DCOMPILE_DEBUG = 1 << 0;

        public const uint D3DCOMPILE_SKIP_VALIDATION = 1 << 1;

        public const uint D3DCOMPILE_SKIP_OPTIMIZATION = 1 << 2;

        public const uint D3DCOMPILE_PACK_MATRIX_ROW_MAJOR = 1 << 3;

        public const uint D3DCOMPILE_PACK_MATRIX_COLUMN_MAJOR = 1 << 4;

        public const uint D3DCOMPILE_PARTIAL_PRECISION = 1 << 5;

        public const uint D3DCOMPILE_FORCE_VS_SOFTWARE_NO_OPT = 1 << 6;

        public const uint D3DCOMPILE_FORCE_PS_SOFTWARE_NO_OPT = 1 << 7;

        public const uint D3DCOMPILE_NO_PRESHADER = 1 << 8;

        public const uint D3DCOMPILE_AVOID_FLOW_CONTROL = 1 << 9;

        public const uint D3DCOMPILE_PREFER_FLOW_CONTROL = 1 << 10;

        public const uint D3DCOMPILE_ENABLE_STRICTNESS = 1 << 11;

        public const uint D3DCOMPILE_ENABLE_BACKWARDS_COMPATIBILITY = 1 << 12;

        public const uint D3DCOMPILE_IEEE_STRICTNESS = 1 << 13;

        public const uint D3DCOMPILE_OPTIMIZATION_LEVEL0 = 1 << 14;

        public const uint D3DCOMPILE_OPTIMIZATION_LEVEL1 = 0;

        public const uint D3DCOMPILE_OPTIMIZATION_LEVEL2 = (1 << 14) | (1 << 15);

        public const uint D3DCOMPILE_OPTIMIZATION_LEVEL3 = 1 << 15;

        public const uint D3DCOMPILE_RESERVED16 = 1 << 16;

        public const uint D3DCOMPILE_RESERVED17 = 1 << 17;

        public const uint D3DCOMPILE_WARNINGS_ARE_ERRORS = 1 << 18;

        public const uint D3DCOMPILE_RESOURCES_MAY_ALIAS = 1 << 19;

        public const uint D3DCOMPILE_ENABLE_UNBOUNDED_DESCRIPTOR_TABLES = 1 << 20;

        public const uint D3DCOMPILE_ALL_RESOURCES_BOUND = 1 << 21;

        public const uint D3DCOMPILE_EFFECT_CHILD_EFFECT = 1 << 0;

        public const uint D3DCOMPILE_EFFECT_ALLOW_SLOW_OPS = 1 << 1;

        public const uint D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_LATEST = 0;

        public const uint D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_0 = 1 << 4;

        public const uint D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_1 = 1 << 5;

        public const uint D3DCOMPILE_SECDATA_MERGE_UAV_SLOTS = 0x00000001;

        public const uint D3DCOMPILE_SECDATA_PRESERVE_TEMPLATE_SLOTS = 0x00000002;

        public const uint D3DCOMPILE_SECDATA_REQUIRE_TEMPLATE_MATCH = 0x00000004;

        public const uint D3D_DISASM_ENABLE_COLOR_CODE = 0x00000001;

        public const uint D3D_DISASM_ENABLE_DEFAULT_VALUE_PRINTS = 0x00000002;

        public const uint D3D_DISASM_ENABLE_INSTRUCTION_NUMBERING = 0x00000004;

        public const uint D3D_DISASM_ENABLE_INSTRUCTION_CYCLE = 0x00000008;

        public const uint D3D_DISASM_DISABLE_DEBUG_INFO = 0x00000010;

        public const uint D3D_DISASM_ENABLE_INSTRUCTION_OFFSET = 0x00000020;

        public const uint D3D_DISASM_INSTRUCTION_ONLY = 0x00000040;

        public const uint D3D_DISASM_PRINT_HEX_LITERALS = 0x00000080;

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DReadFileToBlob", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DReadFileToBlob([NativeTypeName("LPCWSTR")] char* pFileName, ID3DBlob** ppContents);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DWriteBlobToFile", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DWriteBlobToFile(ID3DBlob* pBlob, [NativeTypeName("LPCWSTR")] char* pFileName, [NativeTypeName("BOOL")] int bOverwrite);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, EntryPoint = "D3DCompile", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompile([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] UIntPtr SrcDataSize, [Optional, NativeTypeName("LPCSTR")] sbyte* pSourceName, [Optional] D3D_SHADER_MACRO* pDefines, [Optional] ID3DInclude* pInclude, [Optional, NativeTypeName("LPCSTR")] sbyte* pEntrypoint, [NativeTypeName("LPCSTR")] sbyte* pTarget, [NativeTypeName("UINT")] uint Flags1, [NativeTypeName("UINT")] uint Flags2, ID3DBlob** ppCode, [Optional] ID3DBlob** ppErrorMsgs);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, EntryPoint = "D3DCompile2", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompile2([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] UIntPtr SrcDataSize, [Optional, NativeTypeName("LPCSTR")] sbyte* pSourceName, [Optional] D3D_SHADER_MACRO* pDefines, [Optional] ID3DInclude* pInclude, [NativeTypeName("LPCSTR")] sbyte* pEntrypoint, [NativeTypeName("LPCSTR")] sbyte* pTarget, [NativeTypeName("UINT")] uint Flags1, [NativeTypeName("UINT")] uint Flags2, [NativeTypeName("UINT")] uint SecondaryDataFlags, [Optional, NativeTypeName("LPCVOID")] void* pSecondaryData, [NativeTypeName("SIZE_T")] UIntPtr SecondaryDataSize, ID3DBlob** ppCode, [Optional] ID3DBlob** ppErrorMsgs);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DCompileFromFile", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompileFromFile([NativeTypeName("LPCWSTR")] char* pFileName, [Optional] D3D_SHADER_MACRO* pDefines, [Optional] ID3DInclude* pInclude, [NativeTypeName("LPCSTR")] sbyte* pEntrypoint, [NativeTypeName("LPCSTR")] sbyte* pTarget, [NativeTypeName("UINT")] uint Flags1, [NativeTypeName("UINT")] uint Flags2, ID3DBlob** ppCode, [Optional] ID3DBlob** ppErrorMsgs);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DPreprocess", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DPreprocess([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] UIntPtr SrcDataSize, [Optional, NativeTypeName("LPCSTR")] sbyte* pSourceName, [Optional] D3D_SHADER_MACRO* pDefines, [Optional] ID3DInclude* pInclude, ID3DBlob** ppCodeText, [Optional] ID3DBlob** ppErrorMsgs);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DGetDebugInfo", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetDebugInfo([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] UIntPtr SrcDataSize, ID3DBlob** ppDebugInfo);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DReflect", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DReflect([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] UIntPtr SrcDataSize, [NativeTypeName("REFIID")] Guid* pInterface, void** ppReflector);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DReflectLibrary", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DReflectLibrary([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] UIntPtr SrcDataSize, [NativeTypeName("REFIID")] Guid* riid, [NativeTypeName("LPVOID")] void** ppReflector);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DDisassemble", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDisassemble([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] UIntPtr SrcDataSize, [NativeTypeName("UINT")] uint Flags, [Optional, NativeTypeName("LPCSTR")] sbyte* szComments, ID3DBlob** ppDisassembly);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DDisassembleRegion", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDisassembleRegion([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] UIntPtr SrcDataSize, [NativeTypeName("UINT")] uint Flags, [Optional, NativeTypeName("LPCSTR")] sbyte* szComments, [NativeTypeName("SIZE_T")] UIntPtr StartByteOffset, [NativeTypeName("SIZE_T")] UIntPtr NumInsts, [Optional, NativeTypeName("SIZE_T")] UIntPtr* pFinishByteOffset, ID3DBlob** ppDisassembly);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DGetTraceInstructionOffsets", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetTraceInstructionOffsets([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] UIntPtr SrcDataSize, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("SIZE_T")] UIntPtr StartInstIndex, [NativeTypeName("SIZE_T")] UIntPtr NumInsts, [Optional, NativeTypeName("SIZE_T")] UIntPtr* pOffsets, [Optional, NativeTypeName("SIZE_T")] UIntPtr* pTotalInsts);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DGetInputSignatureBlob", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetInputSignatureBlob([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] UIntPtr SrcDataSize, ID3DBlob** ppSignatureBlob);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DGetOutputSignatureBlob", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetOutputSignatureBlob([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] UIntPtr SrcDataSize, ID3DBlob** ppSignatureBlob);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DGetInputAndOutputSignatureBlob", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetInputAndOutputSignatureBlob([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] UIntPtr SrcDataSize, ID3DBlob** ppSignatureBlob);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DStripShader", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DStripShader([NativeTypeName("LPCVOID")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] UIntPtr BytecodeLength, [NativeTypeName("UINT")] uint uStripFlags, ID3DBlob** ppStrippedBlob);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DGetBlobPart", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetBlobPart([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] UIntPtr SrcDataSize, D3D_BLOB_PART Part, [NativeTypeName("UINT")] uint Flags, ID3DBlob** ppPart);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DSetBlobPart", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DSetBlobPart([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] UIntPtr SrcDataSize, D3D_BLOB_PART Part, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("LPCVOID")] void* pPart, [NativeTypeName("SIZE_T")] UIntPtr PartSize, ID3DBlob** ppNewShader);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DCreateBlob", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCreateBlob([NativeTypeName("SIZE_T")] UIntPtr Size, ID3DBlob** ppBlob);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DCompressShaders", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompressShaders([NativeTypeName("UINT")] uint uNumShaders, [NativeTypeName("D3D_SHADER_DATA[]")] D3D_SHADER_DATA* pShaderData, [NativeTypeName("UINT")] uint uFlags, ID3DBlob** ppCompressedData);

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DDecompressShaders", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDecompressShaders([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] UIntPtr SrcDataSize, [NativeTypeName("UINT")] uint uNumShaders, [NativeTypeName("UINT")] uint uStartIndex, [Optional, NativeTypeName("UINT[]")] uint* pIndices, [NativeTypeName("UINT")] uint uFlags, ID3DBlob** ppShaders, [Optional, NativeTypeName("UINT")] uint* pTotalShaders);

        public static int D3D12ReflectLibrary(void* pSrcData, UIntPtr SrcDataSize, ID3D12LibraryReflection** ppReflector)
        {
            var iid = IID_ID3D12LibraryReflection;
            return D3DReflectLibrary(pSrcData, SrcDataSize, &iid, (void**)ppReflector);
        }
    }
}
