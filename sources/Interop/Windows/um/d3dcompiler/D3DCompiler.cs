// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3dcompiler.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using TerraFX.Utilities;
using static TerraFX.Interop.D3D12;

namespace TerraFX.Interop
{
    public static unsafe class D3DCompiler
    {
        #region Constants
        public const string D3DCOMPILER_DLL = "D3DCompiler_47.dll";

        public const int D3D_COMPILER_VERSION = 47;

        public const uint D3D_COMPILE_STANDARD_FILE_INCLUDE = 1;

        public const uint D3D_GET_INST_OFFSETS_INCLUDE_NON_EXECUTABLE = 0x00000001;

        public const uint D3D_COMPRESS_SHADER_KEEP_ALL_PARTS = 0x00000001;
        #endregion

        #region D3DCOMPILE_* Constants
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
        #endregion

        #region D3DCOMPILE_EFFECT_* Constants
        public const uint D3DCOMPILE_EFFECT_CHILD_EFFECT = 1 << 0;

        public const uint D3DCOMPILE_EFFECT_ALLOW_SLOW_OPS = 1 << 1;
        #endregion

        #region D3DCOMPILE_FLAGS2_* Constants
        public const uint D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_LATEST = 0;

        public const uint D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_0 = 1 << 4;

        public const uint D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_1 = 1 << 5;
        #endregion

        #region D3DCOMPILE_SECDATA_* Constants
        public const uint D3DCOMPILE_SECDATA_MERGE_UAV_SLOTS = 0x00000001;

        public const uint D3DCOMPILE_SECDATA_PRESERVE_TEMPLATE_SLOTS = 0x00000002;

        public const uint D3DCOMPILE_SECDATA_REQUIRE_TEMPLATE_MATCH = 0x00000004;
        #endregion

        #region D3D_DISASM_* Constants
        public const uint D3D_DISASM_ENABLE_COLOR_CODE = 0x00000001;

        public const uint D3D_DISASM_ENABLE_DEFAULT_VALUE_PRINTS = 0x00000002;

        public const uint D3D_DISASM_ENABLE_INSTRUCTION_NUMBERING = 0x00000004;

        public const uint D3D_DISASM_ENABLE_INSTRUCTION_CYCLE = 0x00000008;

        public const uint D3D_DISASM_DISABLE_DEBUG_INFO = 0x00000010;

        public const uint D3D_DISASM_ENABLE_INSTRUCTION_OFFSET = 0x00000020;

        public const uint D3D_DISASM_INSTRUCTION_ONLY = 0x00000040;

        public const uint D3D_DISASM_PRINT_HEX_LITERALS = 0x00000080;
        #endregion

        #region External Methods
        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DReadFileToBlob", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DReadFileToBlob(
            [In, NativeTypeName("LPCWSTR")] char* pFileName,
            [Out] ID3DBlob** ppContents
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DWriteBlobToFile", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DWriteBlobToFile(
            [In] ID3DBlob* pBlob,
            [In, NativeTypeName("LPCWSTR")] char* pFileName,
            [In, NativeTypeName("BOOL")] int bOverwrite
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, EntryPoint = "D3DCompile", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompile(
            [In, NativeTypeName("LPCVOID")] void* pSrcData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SrcDataSize,
            [In, Optional, NativeTypeName("LPCSTR")] sbyte* pSourceName,
            [In, Optional] D3D_SHADER_MACRO* pDefines,
            [In, Optional] ID3DInclude* pInclude,
            [In, Optional, NativeTypeName("LPCSTR")] sbyte* pEntrypoint,
            [In, NativeTypeName("LPCSTR")] sbyte* pTarget,
            [In, NativeTypeName("UINT")] uint Flags1,
            [In, NativeTypeName("UINT")] uint Flags2,
            [Out] ID3DBlob** ppCode,
            [Out, Optional] ID3DBlob** ppErrorMsgs
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, EntryPoint = "D3DCompile2", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompile2(
            [In, NativeTypeName("LPCVOID")] void* pSrcData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SrcDataSize,
            [In, Optional, NativeTypeName("LPCSTR")] sbyte* pSourceName,
            [In, Optional] D3D_SHADER_MACRO* pDefines,
            [In, Optional] ID3DInclude* pInclude,
            [In, NativeTypeName("LPCSTR")] sbyte* pEntrypoint,
            [In, NativeTypeName("LPCSTR")] sbyte* pTarget,
            [In, NativeTypeName("UINT")] uint Flags1,
            [In, NativeTypeName("UINT")] uint Flags2,
            [In, NativeTypeName("UINT")] uint SecondaryDataFlags,
            [In, Optional, NativeTypeName("LPCVOID")] void* pSecondaryData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SecondaryDataSize,
            [Out] ID3DBlob** ppCode,
            [Out, Optional] ID3DBlob** ppErrorMsgs
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DCompileFromFile", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompileFromFile(
            [In, NativeTypeName("LPCWSTR")] char* pFileName,
            [In, Optional] D3D_SHADER_MACRO* pDefines,
            [In, Optional] ID3DInclude* pInclude,
            [In, NativeTypeName("LPCSTR")] sbyte* pEntrypoint,
            [In, NativeTypeName("LPCSTR")] sbyte* pTarget,
            [In, NativeTypeName("UINT")] uint Flags1,
            [In, NativeTypeName("UINT")] uint Flags2,
            [Out] ID3DBlob** ppCode,
            [Out, Optional] ID3DBlob** ppErrorMsgs
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DPreprocess", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DPreprocess(
            [In, NativeTypeName("LPCVOID")] void* pSrcData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SrcDataSize,
            [In, Optional, NativeTypeName("LPCSTR")] sbyte* pSourceName,
            [In, Optional] D3D_SHADER_MACRO* pDefines,
            [In, Optional] ID3DInclude* pInclude,
            [Out] ID3DBlob** ppCodeText,
            [Out, Optional] ID3DBlob** ppErrorMsgs
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DGetDebugInfo", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetDebugInfo(
            [In, NativeTypeName("LPCVOID")] void* pSrcData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SrcDataSize,
            [Out] ID3DBlob** ppDebugInfo
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DReflect", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DReflect(
            [In, NativeTypeName("LPCVOID")] void* pSrcData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SrcDataSize,
            [In, NativeTypeName("REFIID")] Guid* pInterface,
            [Out] void** ppReflector
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DReflectLibrary", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DReflectLibrary(
            [In, NativeTypeName("LPCVOID")] void* pSrcData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SrcDataSize,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out, NativeTypeName("LPVOID")] void** ppReflector
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DDisassemble", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDisassemble(
            [In, NativeTypeName("LPCVOID")] void* pSrcData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SrcDataSize,
            [In, NativeTypeName("UINT")] uint Flags,
            [In, Optional, NativeTypeName("LPCSTR")] sbyte* szComments,
            [Out] ID3DBlob** ppDisassembly
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DDisassembleRegion", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDisassembleRegion(
            [In, NativeTypeName("LPCVOID")] void* pSrcData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SrcDataSize,
            [In, NativeTypeName("UINT")] uint Flags,
            [In, Optional, NativeTypeName("LPCSTR")] sbyte* szComments,
            [In, NativeTypeName("SIZE_T")] UIntPtr StartByteOffset,
            [In, NativeTypeName("SIZE_T")] UIntPtr NumInsts,
            [Out, Optional, NativeTypeName("SIZE_T")] UIntPtr* pFinishByteOffset,
            [Out] ID3DBlob** ppDisassembly
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DGetTraceInstructionOffsets", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetTraceInstructionOffsets(
            [In, NativeTypeName("LPCVOID")] void* pSrcData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SrcDataSize,
            [In, NativeTypeName("UINT")] uint Flags,
            [In, NativeTypeName("SIZE_T")] UIntPtr StartInstIndex,
            [In, NativeTypeName("SIZE_T")] UIntPtr NumInsts,
            [Out, Optional, NativeTypeName("SIZE_T")] UIntPtr* pOffsets,
            [Out, Optional, NativeTypeName("SIZE_T")] UIntPtr* pTotalInsts
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DGetInputSignatureBlob", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetInputSignatureBlob(
            [In, NativeTypeName("LPCVOID")] void* pSrcData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SrcDataSize,
            [Out] ID3DBlob** ppSignatureBlob
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DGetOutputSignatureBlob", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetOutputSignatureBlob(
            [In, NativeTypeName("LPCVOID")] void* pSrcData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SrcDataSize,
            [Out] ID3DBlob** ppSignatureBlob
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DGetInputAndOutputSignatureBlob", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetInputAndOutputSignatureBlob(
            [In, NativeTypeName("LPCVOID")] void* pSrcData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SrcDataSize,
            [Out] ID3DBlob** ppSignatureBlob
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DStripShader", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DStripShader(
            [In, NativeTypeName("LPCVOID")] void* pShaderBytecode,
            [In, NativeTypeName("SIZE_T")] UIntPtr BytecodeLength,
            [In, NativeTypeName("UINT")] uint uStripFlags,
            [Out] ID3DBlob** ppStrippedBlob
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DGetBlobPart", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetBlobPart(
            [In, NativeTypeName("LPCVOID")] void* pSrcData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SrcDataSize,
            [In] D3D_BLOB_PART Part,
            [In, NativeTypeName("UINT")] uint Flags,
            [Out] ID3DBlob** ppPart
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DSetBlobPart", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DSetBlobPart(
            [In, NativeTypeName("LPCVOID")] void* pSrcData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SrcDataSize,
            [In] D3D_BLOB_PART Part,
            [In, NativeTypeName("UINT")] uint Flags,
            [In, NativeTypeName("LPCVOID")] void* pPart,
            [In, NativeTypeName("SIZE_T")] UIntPtr PartSize,
            [Out] ID3DBlob** ppNewShader
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DCreateBlob", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCreateBlob(
            [In, NativeTypeName("SIZE_T")] UIntPtr Size,
            [Out] ID3DBlob** ppBlob
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DCompressShaders", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompressShaders(
            [In, NativeTypeName("UINT")] uint uNumShaders,
            [In, NativeTypeName("D3D_SHADER_DATA[]")] D3D_SHADER_DATA* pShaderData,
            [In, NativeTypeName("UINT")] uint uFlags,
            [Out] ID3DBlob** ppCompressedData
        );

        [DllImport(D3DCOMPILER_DLL, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3DDecompressShaders", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDecompressShaders(
            [In, NativeTypeName("LPCVOID")] void* pSrcData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SrcDataSize,
            [In, NativeTypeName("UINT")] uint uNumShaders,
            [In, NativeTypeName("UINT")] uint uStartIndex,
            [In, Optional, NativeTypeName("UINT[]")] uint* pIndices,
            [In, NativeTypeName("UINT")] uint uFlags,
            [Out] ID3DBlob** ppShaders,
            [Out, Optional, NativeTypeName("UINT")] uint* pTotalShaders
        );
        #endregion

        #region Methods
        public static int D3D12ReflectLibrary(void* pSrcData, UIntPtr SrcDataSize, ID3D12LibraryReflection** ppReflector)
        {
            var iid = IID_ID3D12LibraryReflection;
            return D3DReflectLibrary(pSrcData, SrcDataSize, &iid, (void**)ppReflector);
        }
        #endregion
    }
}
