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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDxcLibrary*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDxcLibrary*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDxcLibrary*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMalloc([NativeTypeName("IMalloc *")] IMalloc* pMalloc)
        {
            return lpVtbl->SetMalloc((IDxcLibrary*)Unsafe.AsPointer(ref this), pMalloc);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlobFromBlob([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("UINT32")] uint offset, [NativeTypeName("UINT32")] uint length, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppResult)
        {
            return lpVtbl->CreateBlobFromBlob((IDxcLibrary*)Unsafe.AsPointer(ref this), pBlob, offset, length, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlobFromFile([NativeTypeName("LPCWSTR")] ushort* pFileName, [NativeTypeName("UINT32 *")] uint* codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return lpVtbl->CreateBlobFromFile((IDxcLibrary*)Unsafe.AsPointer(ref this), pFileName, codePage, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlobWithEncodingFromPinned([NativeTypeName("LPCVOID")] void* pText, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return lpVtbl->CreateBlobWithEncodingFromPinned((IDxcLibrary*)Unsafe.AsPointer(ref this), pText, size, codePage, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlobWithEncodingOnHeapCopy([NativeTypeName("LPCVOID")] void* pText, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return lpVtbl->CreateBlobWithEncodingOnHeapCopy((IDxcLibrary*)Unsafe.AsPointer(ref this), pText, size, codePage, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlobWithEncodingOnMalloc([NativeTypeName("LPCVOID")] void* pText, [NativeTypeName("IMalloc *")] IMalloc* pIMalloc, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return lpVtbl->CreateBlobWithEncodingOnMalloc((IDxcLibrary*)Unsafe.AsPointer(ref this), pText, pIMalloc, size, codePage, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateIncludeHandler([NativeTypeName("IDxcIncludeHandler **")] IDxcIncludeHandler** ppResult)
        {
            return lpVtbl->CreateIncludeHandler((IDxcLibrary*)Unsafe.AsPointer(ref this), ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStreamFromBlobReadOnly([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IStream **")] IStream** ppStream)
        {
            return lpVtbl->CreateStreamFromBlobReadOnly((IDxcLibrary*)Unsafe.AsPointer(ref this), pBlob, ppStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBlobAsUtf8([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return lpVtbl->GetBlobAsUtf8((IDxcLibrary*)Unsafe.AsPointer(ref this), pBlob, pBlobEncoding);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBlobAsUtf16([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pBlobEncoding)
        {
            return lpVtbl->GetBlobAsUtf16((IDxcLibrary*)Unsafe.AsPointer(ref this), pBlob, pBlobEncoding);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcLibrary*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcLibrary*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcLibrary*, uint> Release;

            [NativeTypeName("HRESULT (IMalloc *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcLibrary*, IMalloc*, int> SetMalloc;

            [NativeTypeName("HRESULT (IDxcBlob *, UINT32, UINT32, IDxcBlob **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int> CreateBlobFromBlob;

            [NativeTypeName("HRESULT (LPCWSTR, UINT32 *, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcLibrary*, ushort*, uint*, IDxcBlobEncoding**, int> CreateBlobFromFile;

            [NativeTypeName("HRESULT (LPCVOID, UINT32, UINT32, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int> CreateBlobWithEncodingFromPinned;

            [NativeTypeName("HRESULT (LPCVOID, UINT32, UINT32, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int> CreateBlobWithEncodingOnHeapCopy;

            [NativeTypeName("HRESULT (LPCVOID, IMalloc *, UINT32, UINT32, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int> CreateBlobWithEncodingOnMalloc;

            [NativeTypeName("HRESULT (IDxcIncludeHandler **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcLibrary*, IDxcIncludeHandler**, int> CreateIncludeHandler;

            [NativeTypeName("HRESULT (IDxcBlob *, IStream **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcLibrary*, IDxcBlob*, IStream**, int> CreateStreamFromBlobReadOnly;

            [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int> GetBlobAsUtf8;

            [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int> GetBlobAsUtf16;
        }
    }
}
