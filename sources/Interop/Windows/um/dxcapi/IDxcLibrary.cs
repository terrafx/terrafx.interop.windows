// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("e5204dc7-d18c-4c3c-bdfb-851673980fe7")]
    public unsafe partial struct IDxcLibrary
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDxcLibrary* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDxcLibrary* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDxcLibrary* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMalloc(IDxcLibrary* pThis, [NativeTypeName("IMalloc *")] IMalloc* pMalloc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBlobFromBlob(IDxcLibrary* pThis, [NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("UINT32")] uint offset, [NativeTypeName("UINT32")] uint length, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppResult);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBlobFromFile(IDxcLibrary* pThis, [NativeTypeName("LPCWSTR")] ushort* pFileName, [NativeTypeName("UINT32 *")] uint* codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBlobWithEncodingFromPinned(IDxcLibrary* pThis, [NativeTypeName("LPCVOID")] void* pText, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBlobWithEncodingOnHeapCopy(IDxcLibrary* pThis, [NativeTypeName("LPCVOID")] void* pText, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBlobWithEncodingOnMalloc(IDxcLibrary* pThis, [NativeTypeName("LPCVOID")] void* pText, [NativeTypeName("IMalloc *")] IMalloc* pIMalloc, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateIncludeHandler(IDxcLibrary* pThis, [NativeTypeName("IDxcIncludeHandler **")] IDxcIncludeHandler** ppResult);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStreamFromBlobReadOnly(IDxcLibrary* pThis, [NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IStream **")] IStream** ppStream);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBlobAsUtf8(IDxcLibrary* pThis, [NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBlobAsUtf16(IDxcLibrary* pThis, [NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDxcLibrary*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDxcLibrary*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDxcLibrary*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMalloc([NativeTypeName("IMalloc *")] IMalloc* pMalloc)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMalloc>(lpVtbl->SetMalloc)((IDxcLibrary*)Unsafe.AsPointer(ref this), pMalloc);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlobFromBlob([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("UINT32")] uint offset, [NativeTypeName("UINT32")] uint length, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBlobFromBlob>(lpVtbl->CreateBlobFromBlob)((IDxcLibrary*)Unsafe.AsPointer(ref this), pBlob, offset, length, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlobFromFile([NativeTypeName("LPCWSTR")] ushort* pFileName, [NativeTypeName("UINT32 *")] uint* codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBlobFromFile>(lpVtbl->CreateBlobFromFile)((IDxcLibrary*)Unsafe.AsPointer(ref this), pFileName, codePage, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlobWithEncodingFromPinned([NativeTypeName("LPCVOID")] void* pText, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBlobWithEncodingFromPinned>(lpVtbl->CreateBlobWithEncodingFromPinned)((IDxcLibrary*)Unsafe.AsPointer(ref this), pText, size, codePage, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlobWithEncodingOnHeapCopy([NativeTypeName("LPCVOID")] void* pText, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBlobWithEncodingOnHeapCopy>(lpVtbl->CreateBlobWithEncodingOnHeapCopy)((IDxcLibrary*)Unsafe.AsPointer(ref this), pText, size, codePage, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlobWithEncodingOnMalloc([NativeTypeName("LPCVOID")] void* pText, [NativeTypeName("IMalloc *")] IMalloc* pIMalloc, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBlobWithEncodingOnMalloc>(lpVtbl->CreateBlobWithEncodingOnMalloc)((IDxcLibrary*)Unsafe.AsPointer(ref this), pText, pIMalloc, size, codePage, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateIncludeHandler([NativeTypeName("IDxcIncludeHandler **")] IDxcIncludeHandler** ppResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateIncludeHandler>(lpVtbl->CreateIncludeHandler)((IDxcLibrary*)Unsafe.AsPointer(ref this), ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStreamFromBlobReadOnly([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IStream **")] IStream** ppStream)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateStreamFromBlobReadOnly>(lpVtbl->CreateStreamFromBlobReadOnly)((IDxcLibrary*)Unsafe.AsPointer(ref this), pBlob, ppStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBlobAsUtf8([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBlobAsUtf8>(lpVtbl->GetBlobAsUtf8)((IDxcLibrary*)Unsafe.AsPointer(ref this), pBlob, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBlobAsUtf16([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBlobAsUtf16>(lpVtbl->GetBlobAsUtf16)((IDxcLibrary*)Unsafe.AsPointer(ref this), pBlob, pBlobEncoding);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IMalloc *) __attribute__((stdcall))")]
            public IntPtr SetMalloc;

            [NativeTypeName("HRESULT (IDxcBlob *, UINT32, UINT32, IDxcBlob **) __attribute__((stdcall))")]
            public IntPtr CreateBlobFromBlob;

            [NativeTypeName("HRESULT (LPCWSTR, UINT32 *, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public IntPtr CreateBlobFromFile;

            [NativeTypeName("HRESULT (LPCVOID, UINT32, UINT32, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public IntPtr CreateBlobWithEncodingFromPinned;

            [NativeTypeName("HRESULT (LPCVOID, UINT32, UINT32, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public IntPtr CreateBlobWithEncodingOnHeapCopy;

            [NativeTypeName("HRESULT (LPCVOID, IMalloc *, UINT32, UINT32, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public IntPtr CreateBlobWithEncodingOnMalloc;

            [NativeTypeName("HRESULT (IDxcIncludeHandler **) __attribute__((stdcall))")]
            public IntPtr CreateIncludeHandler;

            [NativeTypeName("HRESULT (IDxcBlob *, IStream **) __attribute__((stdcall))")]
            public IntPtr CreateStreamFromBlobReadOnly;

            [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public IntPtr GetBlobAsUtf8;

            [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public IntPtr GetBlobAsUtf16;
        }
    }
}
