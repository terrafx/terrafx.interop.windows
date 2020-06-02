// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/dxc/dxcapi.h in the microsoft/DirectXCompiler commit e0cde072b09b51506c0460697b2695d6cccca59d
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("228B4687-5A6A-4730-900C-9702B2203F54")]
    public unsafe partial struct IDxcCompiler3
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDxcCompiler3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDxcCompiler3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDxcCompiler3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Compile([NativeTypeName("const DxcBuffer *")] DxcBuffer* pSource, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("IDxcIncludeHandler *")] IDxcIncludeHandler* pIncludeHandler, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppResult)
        {
            return lpVtbl->Compile((IDxcCompiler3*)Unsafe.AsPointer(ref this), pSource, pArguments, argCount, pIncludeHandler, riid, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int Disassemble([NativeTypeName("const DxcBuffer *")] DxcBuffer* pObject, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppResult)
        {
            return lpVtbl->Disassemble((IDxcCompiler3*)Unsafe.AsPointer(ref this), pObject, riid, ppResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcCompiler3*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcCompiler3*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcCompiler3*, uint> Release;

            [NativeTypeName("HRESULT (const DxcBuffer *, LPCWSTR *, UINT32, IDxcIncludeHandler *, const IID &, LPVOID *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcCompiler3*, DxcBuffer*, ushort**, uint, IDxcIncludeHandler*, Guid*, void**, int> Compile;

            [NativeTypeName("HRESULT (const DxcBuffer *, const IID &, LPVOID *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcCompiler3*, DxcBuffer*, Guid*, void**, int> Disassemble;
        }
    }
}
