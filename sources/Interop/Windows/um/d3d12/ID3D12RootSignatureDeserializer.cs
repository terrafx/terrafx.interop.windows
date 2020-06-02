// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("34AB647B-3CC8-46AC-841B-C0965645C046")]
    public unsafe partial struct ID3D12RootSignatureDeserializer
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12RootSignatureDeserializer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12RootSignatureDeserializer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12RootSignatureDeserializer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")]
        public D3D12_ROOT_SIGNATURE_DESC* GetRootSignatureDesc()
        {
            return lpVtbl->GetRootSignatureDesc((ID3D12RootSignatureDeserializer*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12RootSignatureDeserializer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12RootSignatureDeserializer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12RootSignatureDeserializer*, uint> Release;

            [NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *() __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12RootSignatureDeserializer*, D3D12_ROOT_SIGNATURE_DESC*> GetRootSignatureDesc;
        }
    }
}
