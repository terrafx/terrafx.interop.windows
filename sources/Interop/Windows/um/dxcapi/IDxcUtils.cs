// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDxcUtils* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDxcUtils* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDxcUtils* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBlobFromBlob(IDxcUtils* pThis, [NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("UINT32")] uint offset, [NativeTypeName("UINT32")] uint length, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppResult);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBlobFromPinned(IDxcUtils* pThis, [NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MoveToBlob(IDxcUtils* pThis, [NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("IMalloc *")] IMalloc* pIMalloc, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBlob(IDxcUtils* pThis, [NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LoadFile(IDxcUtils* pThis, [NativeTypeName("LPCWSTR")] ushort* pFileName, [NativeTypeName("UINT32 *")] uint* pCodePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateReadOnlyStreamFromBlob(IDxcUtils* pThis, [NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IStream **")] IStream** ppStream);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDefaultIncludeHandler(IDxcUtils* pThis, [NativeTypeName("IDxcIncludeHandler **")] IDxcIncludeHandler** ppResult);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBlobAsUtf8(IDxcUtils* pThis, [NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IDxcBlobUtf8 **")] IDxcBlobUtf8** pBlobEncoding);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBlobAsUtf16(IDxcUtils* pThis, [NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IDxcBlobUtf16 **")] IDxcBlobUtf16** pBlobEncoding);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDxilContainerPart(IDxcUtils* pThis, [NativeTypeName("const DxcBuffer *")] DxcBuffer* pShader, [NativeTypeName("UINT32")] uint DxcPart, [NativeTypeName("void **")] void** ppPartData, [NativeTypeName("UINT32 *")] uint* pPartSizeInBytes);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateReflection(IDxcUtils* pThis, [NativeTypeName("const DxcBuffer *")] DxcBuffer* pData, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** ppvReflection);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BuildArguments(IDxcUtils* pThis, [NativeTypeName("LPCWSTR")] ushort* pSourceName, [NativeTypeName("LPCWSTR")] ushort* pEntryPoint, [NativeTypeName("LPCWSTR")] ushort* pTargetProfile, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, [NativeTypeName("IDxcCompilerArgs **")] IDxcCompilerArgs** ppArgs);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPDBContents(IDxcUtils* pThis, [NativeTypeName("IDxcBlob *")] IDxcBlob* pPDBBlob, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppHash, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppContainer);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDxcUtils*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDxcUtils*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDxcUtils*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlobFromBlob([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("UINT32")] uint offset, [NativeTypeName("UINT32")] uint length, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBlobFromBlob>(lpVtbl->CreateBlobFromBlob)((IDxcUtils*)Unsafe.AsPointer(ref this), pBlob, offset, length, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlobFromPinned([NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBlobFromPinned>(lpVtbl->CreateBlobFromPinned)((IDxcUtils*)Unsafe.AsPointer(ref this), pData, size, codePage, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int MoveToBlob([NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("IMalloc *")] IMalloc* pIMalloc, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return Marshal.GetDelegateForFunctionPointer<_MoveToBlob>(lpVtbl->MoveToBlob)((IDxcUtils*)Unsafe.AsPointer(ref this), pData, pIMalloc, size, codePage, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlob([NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBlob>(lpVtbl->CreateBlob)((IDxcUtils*)Unsafe.AsPointer(ref this), pData, size, codePage, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadFile([NativeTypeName("LPCWSTR")] ushort* pFileName, [NativeTypeName("UINT32 *")] uint* pCodePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return Marshal.GetDelegateForFunctionPointer<_LoadFile>(lpVtbl->LoadFile)((IDxcUtils*)Unsafe.AsPointer(ref this), pFileName, pCodePage, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateReadOnlyStreamFromBlob([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IStream **")] IStream** ppStream)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateReadOnlyStreamFromBlob>(lpVtbl->CreateReadOnlyStreamFromBlob)((IDxcUtils*)Unsafe.AsPointer(ref this), pBlob, ppStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDefaultIncludeHandler([NativeTypeName("IDxcIncludeHandler **")] IDxcIncludeHandler** ppResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDefaultIncludeHandler>(lpVtbl->CreateDefaultIncludeHandler)((IDxcUtils*)Unsafe.AsPointer(ref this), ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBlobAsUtf8([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IDxcBlobUtf8 **")] IDxcBlobUtf8** pBlobEncoding)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBlobAsUtf8>(lpVtbl->GetBlobAsUtf8)((IDxcUtils*)Unsafe.AsPointer(ref this), pBlob, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBlobAsUtf16([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IDxcBlobUtf16 **")] IDxcBlobUtf16** pBlobEncoding)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBlobAsUtf16>(lpVtbl->GetBlobAsUtf16)((IDxcUtils*)Unsafe.AsPointer(ref this), pBlob, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDxilContainerPart([NativeTypeName("const DxcBuffer *")] DxcBuffer* pShader, [NativeTypeName("UINT32")] uint DxcPart, [NativeTypeName("void **")] void** ppPartData, [NativeTypeName("UINT32 *")] uint* pPartSizeInBytes)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDxilContainerPart>(lpVtbl->GetDxilContainerPart)((IDxcUtils*)Unsafe.AsPointer(ref this), pShader, DxcPart, ppPartData, pPartSizeInBytes);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateReflection([NativeTypeName("const DxcBuffer *")] DxcBuffer* pData, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** ppvReflection)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateReflection>(lpVtbl->CreateReflection)((IDxcUtils*)Unsafe.AsPointer(ref this), pData, iid, ppvReflection);
        }

        [return: NativeTypeName("HRESULT")]
        public int BuildArguments([NativeTypeName("LPCWSTR")] ushort* pSourceName, [NativeTypeName("LPCWSTR")] ushort* pEntryPoint, [NativeTypeName("LPCWSTR")] ushort* pTargetProfile, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, [NativeTypeName("IDxcCompilerArgs **")] IDxcCompilerArgs** ppArgs)
        {
            return Marshal.GetDelegateForFunctionPointer<_BuildArguments>(lpVtbl->BuildArguments)((IDxcUtils*)Unsafe.AsPointer(ref this), pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPDBContents([NativeTypeName("IDxcBlob *")] IDxcBlob* pPDBBlob, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppHash, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppContainer)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPDBContents>(lpVtbl->GetPDBContents)((IDxcUtils*)Unsafe.AsPointer(ref this), pPDBBlob, ppHash, ppContainer);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IDxcBlob *, UINT32, UINT32, IDxcBlob **) __attribute__((stdcall))")]
            public IntPtr CreateBlobFromBlob;

            [NativeTypeName("HRESULT (LPCVOID, UINT32, UINT32, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public IntPtr CreateBlobFromPinned;

            [NativeTypeName("HRESULT (LPCVOID, IMalloc *, UINT32, UINT32, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public IntPtr MoveToBlob;

            [NativeTypeName("HRESULT (LPCVOID, UINT32, UINT32, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public IntPtr CreateBlob;

            [NativeTypeName("HRESULT (LPCWSTR, UINT32 *, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public IntPtr LoadFile;

            [NativeTypeName("HRESULT (IDxcBlob *, IStream **) __attribute__((stdcall))")]
            public IntPtr CreateReadOnlyStreamFromBlob;

            [NativeTypeName("HRESULT (IDxcIncludeHandler **) __attribute__((stdcall))")]
            public IntPtr CreateDefaultIncludeHandler;

            [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobUtf8 **) __attribute__((stdcall))")]
            public IntPtr GetBlobAsUtf8;

            [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobUtf16 **) __attribute__((stdcall))")]
            public IntPtr GetBlobAsUtf16;

            [NativeTypeName("HRESULT (const DxcBuffer *, UINT32, void **, UINT32 *) __attribute__((stdcall))")]
            public IntPtr GetDxilContainerPart;

            [NativeTypeName("HRESULT (const DxcBuffer *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateReflection;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR *, UINT32, const DxcDefine *, UINT32, IDxcCompilerArgs **) __attribute__((stdcall))")]
            public IntPtr BuildArguments;

            [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlob **, IDxcBlob **) __attribute__((stdcall))")]
            public IntPtr GetPDBContents;
        }
    }
}
