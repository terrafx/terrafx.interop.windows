// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/dxc/dxcapi.h in the microsoft/DirectXCompiler commit e0cde072b09b51506c0460697b2695d6cccca59d
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A3F84EAB-0FAA-497E-A39C-EE6ED60B2D84")]
    public unsafe partial struct IDxcBlobUtf16
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDxcBlobUtf16*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("LPVOID")]
        public void* GetBufferPointer()
        {
            return lpVtbl->GetBufferPointer((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint GetBufferSize()
        {
            return lpVtbl->GetBufferSize((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEncoding([NativeTypeName("BOOL *")] int* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage)
        {
            return lpVtbl->GetEncoding((IDxcBlobUtf16*)Unsafe.AsPointer(ref this), pKnown, pCodePage);
        }

        [return: NativeTypeName("LPCWSTR")]
        public ushort* GetStringPointer()
        {
            return lpVtbl->GetStringPointer((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint GetStringLength()
        {
            return lpVtbl->GetStringLength((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcBlobUtf16*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcBlobUtf16*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcBlobUtf16*, uint> Release;

            [NativeTypeName("LPVOID () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcBlobUtf16*, void*> GetBufferPointer;

            [NativeTypeName("SIZE_T () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcBlobUtf16*, nuint> GetBufferSize;

            [NativeTypeName("HRESULT (BOOL *, UINT32 *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcBlobUtf16*, int*, uint*, int> GetEncoding;

            [NativeTypeName("LPCWSTR () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcBlobUtf16*, ushort*> GetStringPointer;

            [NativeTypeName("SIZE_T () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcBlobUtf16*, nuint> GetStringLength;
        }
    }
}
