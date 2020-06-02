// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8E349D19-54DB-4A56-9DC9-119D87BDB804")]
    public unsafe partial struct ID3D12LibraryReflection
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12LibraryReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12LibraryReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12LibraryReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D12_LIBRARY_DESC *")] D3D12_LIBRARY_DESC* pDesc)
        {
            return lpVtbl->GetDesc((ID3D12LibraryReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D12FunctionReflection *")]
        public ID3D12FunctionReflection* GetFunctionByIndex([NativeTypeName("INT")] int FunctionIndex)
        {
            return lpVtbl->GetFunctionByIndex((ID3D12LibraryReflection*)Unsafe.AsPointer(ref this), FunctionIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12LibraryReflection*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12LibraryReflection*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12LibraryReflection*, uint> Release;

            [NativeTypeName("HRESULT (D3D12_LIBRARY_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12LibraryReflection*, D3D12_LIBRARY_DESC*, int> GetDesc;

            [NativeTypeName("ID3D12FunctionReflection *(INT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12LibraryReflection*, int, ID3D12FunctionReflection*> GetFunctionByIndex;
        }
    }
}
