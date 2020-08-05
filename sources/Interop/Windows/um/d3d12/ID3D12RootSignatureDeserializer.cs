// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("34AB647B-3CC8-46AC-841B-C0965645C046")]
    [NativeTypeName("struct ID3D12RootSignatureDeserializer : IUnknown")]
    public unsafe partial struct ID3D12RootSignatureDeserializer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12RootSignatureDeserializer*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12RootSignatureDeserializer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12RootSignatureDeserializer*, uint>)(lpVtbl[1]))((ID3D12RootSignatureDeserializer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12RootSignatureDeserializer*, uint>)(lpVtbl[2]))((ID3D12RootSignatureDeserializer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")]
        public D3D12_ROOT_SIGNATURE_DESC* GetRootSignatureDesc()
        {
            return ((delegate* stdcall<ID3D12RootSignatureDeserializer*, D3D12_ROOT_SIGNATURE_DESC*>)(lpVtbl[3]))((ID3D12RootSignatureDeserializer*)Unsafe.AsPointer(ref this));
        }
    }
}
