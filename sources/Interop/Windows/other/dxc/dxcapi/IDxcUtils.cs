// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/dxc/dxcapi.h in the microsoft/DirectXCompiler commit e0cde072b09b51506c0460697b2695d6cccca59d
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4605C4CB-2019-492A-ADA4-65F20BB7D67F")]
    public unsafe partial struct IDxcUtils
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDxcUtils*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDxcUtils*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDxcUtils*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlobFromBlob([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("UINT32")] uint offset, [NativeTypeName("UINT32")] uint length, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppResult)
        {
            return lpVtbl->CreateBlobFromBlob((IDxcUtils*)Unsafe.AsPointer(ref this), pBlob, offset, length, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlobFromPinned([NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return lpVtbl->CreateBlobFromPinned((IDxcUtils*)Unsafe.AsPointer(ref this), pData, size, codePage, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int MoveToBlob([NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("IMalloc *")] IMalloc* pIMalloc, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return lpVtbl->MoveToBlob((IDxcUtils*)Unsafe.AsPointer(ref this), pData, pIMalloc, size, codePage, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlob([NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return lpVtbl->CreateBlob((IDxcUtils*)Unsafe.AsPointer(ref this), pData, size, codePage, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadFile([NativeTypeName("LPCWSTR")] ushort* pFileName, [NativeTypeName("UINT32 *")] uint* pCodePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return lpVtbl->LoadFile((IDxcUtils*)Unsafe.AsPointer(ref this), pFileName, pCodePage, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateReadOnlyStreamFromBlob([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IStream **")] IStream** ppStream)
        {
            return lpVtbl->CreateReadOnlyStreamFromBlob((IDxcUtils*)Unsafe.AsPointer(ref this), pBlob, ppStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDefaultIncludeHandler([NativeTypeName("IDxcIncludeHandler **")] IDxcIncludeHandler** ppResult)
        {
            return lpVtbl->CreateDefaultIncludeHandler((IDxcUtils*)Unsafe.AsPointer(ref this), ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBlobAsUtf8([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IDxcBlobUtf8 **")] IDxcBlobUtf8** pBlobEncoding)
        {
            return lpVtbl->GetBlobAsUtf8((IDxcUtils*)Unsafe.AsPointer(ref this), pBlob, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBlobAsUtf16([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IDxcBlobUtf16 **")] IDxcBlobUtf16** pBlobEncoding)
        {
            return lpVtbl->GetBlobAsUtf16((IDxcUtils*)Unsafe.AsPointer(ref this), pBlob, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDxilContainerPart([NativeTypeName("const DxcBuffer *")] DxcBuffer* pShader, [NativeTypeName("UINT32")] uint DxcPart, [NativeTypeName("void **")] void** ppPartData, [NativeTypeName("UINT32 *")] uint* pPartSizeInBytes)
        {
            return lpVtbl->GetDxilContainerPart((IDxcUtils*)Unsafe.AsPointer(ref this), pShader, DxcPart, ppPartData, pPartSizeInBytes);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateReflection([NativeTypeName("const DxcBuffer *")] DxcBuffer* pData, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** ppvReflection)
        {
            return lpVtbl->CreateReflection((IDxcUtils*)Unsafe.AsPointer(ref this), pData, iid, ppvReflection);
        }

        [return: NativeTypeName("HRESULT")]
        public int BuildArguments([NativeTypeName("LPCWSTR")] ushort* pSourceName, [NativeTypeName("LPCWSTR")] ushort* pEntryPoint, [NativeTypeName("LPCWSTR")] ushort* pTargetProfile, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, [NativeTypeName("IDxcCompilerArgs **")] IDxcCompilerArgs** ppArgs)
        {
            return lpVtbl->BuildArguments((IDxcUtils*)Unsafe.AsPointer(ref this), pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPDBContents([NativeTypeName("IDxcBlob *")] IDxcBlob* pPDBBlob, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppHash, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppContainer)
        {
            return lpVtbl->GetPDBContents((IDxcUtils*)Unsafe.AsPointer(ref this), pPDBBlob, ppHash, ppContainer);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcUtils*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcUtils*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcUtils*, uint> Release;

            [NativeTypeName("HRESULT (IDxcBlob *, UINT32, UINT32, IDxcBlob **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int> CreateBlobFromBlob;

            [NativeTypeName("HRESULT (LPCVOID, UINT32, UINT32, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int> CreateBlobFromPinned;

            [NativeTypeName("HRESULT (LPCVOID, IMalloc *, UINT32, UINT32, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int> MoveToBlob;

            [NativeTypeName("HRESULT (LPCVOID, UINT32, UINT32, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int> CreateBlob;

            [NativeTypeName("HRESULT (LPCWSTR, UINT32 *, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcUtils*, ushort*, uint*, IDxcBlobEncoding**, int> LoadFile;

            [NativeTypeName("HRESULT (IDxcBlob *, IStream **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcUtils*, IDxcBlob*, IStream**, int> CreateReadOnlyStreamFromBlob;

            [NativeTypeName("HRESULT (IDxcIncludeHandler **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcUtils*, IDxcIncludeHandler**, int> CreateDefaultIncludeHandler;

            [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobUtf8 **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int> GetBlobAsUtf8;

            [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobUtf16 **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcUtils*, IDxcBlob*, IDxcBlobUtf16**, int> GetBlobAsUtf16;

            [NativeTypeName("HRESULT (const DxcBuffer *, UINT32, void **, UINT32 *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcUtils*, DxcBuffer*, uint, void**, uint*, int> GetDxilContainerPart;

            [NativeTypeName("HRESULT (const DxcBuffer *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcUtils*, DxcBuffer*, Guid*, void**, int> CreateReflection;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR *, UINT32, const DxcDefine *, UINT32, IDxcCompilerArgs **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcUtils*, ushort*, ushort*, ushort*, ushort**, uint, DxcDefine*, uint, IDxcCompilerArgs**, int> BuildArguments;

            [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlob **, IDxcBlob **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int> GetPDBContents;
        }
    }
}
