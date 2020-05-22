// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcompiler.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class D3DCompiler
    {
        private const string LibraryPath = "D3DCompiler_47";

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DReadFileToBlob", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DReadFileToBlob([NativeTypeName("LPCWSTR")] ushort* pFileName, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppContents);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DWriteBlobToFile", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DWriteBlobToFile([NativeTypeName("ID3DBlob *")] ID3DBlob* pBlob, [NativeTypeName("LPCWSTR")] ushort* pFileName, [NativeTypeName("BOOL")] int bOverwrite);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DCompile", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompile([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("LPCSTR")] sbyte* pSourceName, [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, [NativeTypeName("ID3DInclude *")] ID3DInclude* pInclude, [NativeTypeName("LPCSTR")] sbyte* pEntrypoint, [NativeTypeName("LPCSTR")] sbyte* pTarget, [NativeTypeName("UINT")] uint Flags1, [NativeTypeName("UINT")] uint Flags2, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppCode, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppErrorMsgs);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DCompile2", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompile2([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("LPCSTR")] sbyte* pSourceName, [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, [NativeTypeName("ID3DInclude *")] ID3DInclude* pInclude, [NativeTypeName("LPCSTR")] sbyte* pEntrypoint, [NativeTypeName("LPCSTR")] sbyte* pTarget, [NativeTypeName("UINT")] uint Flags1, [NativeTypeName("UINT")] uint Flags2, [NativeTypeName("UINT")] uint SecondaryDataFlags, [NativeTypeName("LPCVOID")] void* pSecondaryData, [NativeTypeName("SIZE_T")] nuint SecondaryDataSize, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppCode, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppErrorMsgs);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DCompileFromFile", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompileFromFile([NativeTypeName("LPCWSTR")] ushort* pFileName, [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, [NativeTypeName("ID3DInclude *")] ID3DInclude* pInclude, [NativeTypeName("LPCSTR")] sbyte* pEntrypoint, [NativeTypeName("LPCSTR")] sbyte* pTarget, [NativeTypeName("UINT")] uint Flags1, [NativeTypeName("UINT")] uint Flags2, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppCode, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppErrorMsgs);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DPreprocess", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DPreprocess([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("LPCSTR")] sbyte* pSourceName, [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, [NativeTypeName("ID3DInclude *")] ID3DInclude* pInclude, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppCodeText, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppErrorMsgs);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DGetDebugInfo", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetDebugInfo([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppDebugInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DReflect", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DReflect([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("const IID &")] Guid* pInterface, [NativeTypeName("void **")] void** ppReflector);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DReflectLibrary", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DReflectLibrary([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppReflector);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DDisassemble", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDisassemble([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("LPCSTR")] sbyte* szComments, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppDisassembly);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DDisassembleRegion", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDisassembleRegion([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("LPCSTR")] sbyte* szComments, [NativeTypeName("SIZE_T")] nuint StartByteOffset, [NativeTypeName("SIZE_T")] nuint NumInsts, [NativeTypeName("SIZE_T *")] nuint* pFinishByteOffset, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppDisassembly);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DGetTraceInstructionOffsets", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetTraceInstructionOffsets([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("SIZE_T")] nuint StartInstIndex, [NativeTypeName("SIZE_T")] nuint NumInsts, [NativeTypeName("SIZE_T *")] nuint* pOffsets, [NativeTypeName("SIZE_T *")] nuint* pTotalInsts);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DGetInputSignatureBlob", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetInputSignatureBlob([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppSignatureBlob);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DGetOutputSignatureBlob", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetOutputSignatureBlob([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppSignatureBlob);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DGetInputAndOutputSignatureBlob", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetInputAndOutputSignatureBlob([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppSignatureBlob);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DStripShader", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DStripShader([NativeTypeName("LPCVOID")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("UINT")] uint uStripFlags, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppStrippedBlob);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DGetBlobPart", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetBlobPart([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, D3D_BLOB_PART Part, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppPart);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DSetBlobPart", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DSetBlobPart([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, D3D_BLOB_PART Part, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("LPCVOID")] void* pPart, [NativeTypeName("SIZE_T")] nuint PartSize, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppNewShader);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DCreateBlob", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCreateBlob([NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppBlob);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DCompressShaders", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompressShaders([NativeTypeName("UINT")] uint uNumShaders, [NativeTypeName("D3D_SHADER_DATA *")] D3D_SHADER_DATA* pShaderData, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppCompressedData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "D3DDecompressShaders", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDecompressShaders([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("UINT")] uint uNumShaders, [NativeTypeName("UINT")] uint uStartIndex, [NativeTypeName("UINT *")] uint* pIndices, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppShaders, [NativeTypeName("UINT *")] uint* pTotalShaders);
    }
}
