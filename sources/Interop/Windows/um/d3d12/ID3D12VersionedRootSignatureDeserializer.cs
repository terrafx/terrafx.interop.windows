// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7F91CE67-090C-4BB7-B78E-ED8FF2E31DA0")]
    public unsafe partial struct ID3D12VersionedRootSignatureDeserializer
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRootSignatureDescAtVersion(D3D_ROOT_SIGNATURE_VERSION convertToVersion, [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **")] D3D12_VERSIONED_ROOT_SIGNATURE_DESC** ppDesc)
        {
            return lpVtbl->GetRootSignatureDescAtVersion((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this), convertToVersion, ppDesc);
        }

        [return: NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
        public D3D12_VERSIONED_ROOT_SIGNATURE_DESC* GetUnconvertedRootSignatureDesc()
        {
            return lpVtbl->GetUnconvertedRootSignatureDesc((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VersionedRootSignatureDeserializer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VersionedRootSignatureDeserializer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VersionedRootSignatureDeserializer*, uint> Release;

            [NativeTypeName("HRESULT (D3D_ROOT_SIGNATURE_VERSION, const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VersionedRootSignatureDeserializer*, D3D_ROOT_SIGNATURE_VERSION, D3D12_VERSIONED_ROOT_SIGNATURE_DESC**, int> GetRootSignatureDescAtVersion;

            [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *() __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VersionedRootSignatureDeserializer*, D3D12_VERSIONED_ROOT_SIGNATURE_DESC*> GetUnconvertedRootSignatureDesc;
        }
    }
}
