// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8C210BF3-011F-4422-8D70-6F9ACB8DB617")]
    [NativeTypeName("struct IDxcCompiler : IUnknown")]
    public unsafe partial struct IDxcCompiler
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDxcCompiler*, Guid*, void**, int>)(lpVtbl[0]))((IDxcCompiler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDxcCompiler*, uint>)(lpVtbl[1]))((IDxcCompiler*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDxcCompiler*, uint>)(lpVtbl[2]))((IDxcCompiler*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Compile([NativeTypeName("IDxcBlob *")] IDxcBlob* pSource, [NativeTypeName("LPCWSTR")] ushort* pSourceName, [NativeTypeName("LPCWSTR")] ushort* pEntryPoint, [NativeTypeName("LPCWSTR")] ushort* pTargetProfile, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, [NativeTypeName("IDxcIncludeHandler *")] IDxcIncludeHandler* pIncludeHandler, [NativeTypeName("IDxcOperationResult **")] IDxcOperationResult** ppResult)
        {
            return ((delegate* stdcall<IDxcCompiler*, IDxcBlob*, ushort*, ushort*, ushort*, ushort**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)(lpVtbl[3]))((IDxcCompiler*)Unsafe.AsPointer(ref this), pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int Preprocess([NativeTypeName("IDxcBlob *")] IDxcBlob* pSource, [NativeTypeName("LPCWSTR")] ushort* pSourceName, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, [NativeTypeName("IDxcIncludeHandler *")] IDxcIncludeHandler* pIncludeHandler, [NativeTypeName("IDxcOperationResult **")] IDxcOperationResult** ppResult)
        {
            return ((delegate* stdcall<IDxcCompiler*, IDxcBlob*, ushort*, ushort**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)(lpVtbl[4]))((IDxcCompiler*)Unsafe.AsPointer(ref this), pSource, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int Disassemble([NativeTypeName("IDxcBlob *")] IDxcBlob* pSource, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** ppDisassembly)
        {
            return ((delegate* stdcall<IDxcCompiler*, IDxcBlob*, IDxcBlobEncoding**, int>)(lpVtbl[5]))((IDxcCompiler*)Unsafe.AsPointer(ref this), pSource, ppDisassembly);
        }
    }
}
