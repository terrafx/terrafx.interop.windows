// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CEDB484A-D4E9-445A-B991-CA21CA157DC2")]
    public unsafe partial struct IDxcOperationResult
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDxcOperationResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDxcOperationResult*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDxcOperationResult*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("HRESULT *")] int* pStatus)
        {
            return lpVtbl->GetStatus((IDxcOperationResult*)Unsafe.AsPointer(ref this), pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResult([NativeTypeName("IDxcBlob **")] IDxcBlob** pResult)
        {
            return lpVtbl->GetResult((IDxcOperationResult*)Unsafe.AsPointer(ref this), pResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetErrorBuffer([NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** pErrors)
        {
            return lpVtbl->GetErrorBuffer((IDxcOperationResult*)Unsafe.AsPointer(ref this), pErrors);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOperationResult*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOperationResult*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOperationResult*, uint> Release;

            [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOperationResult*, int*, int> GetStatus;

            [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOperationResult*, IDxcBlob**, int> GetResult;

            [NativeTypeName("HRESULT (IDxcBlobEncoding **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOperationResult*, IDxcBlobEncoding**, int> GetErrorBuffer;
        }
    }
}
