// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7F91CE67-090C-4BB7-B78E-ED8FF2E31DA0")]
    [NativeTypeName("struct ID3D12VersionedRootSignatureDeserializer : IUnknown")]
    public unsafe partial struct ID3D12VersionedRootSignatureDeserializer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer*, uint>)(lpVtbl[1]))((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer*, uint>)(lpVtbl[2]))((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRootSignatureDescAtVersion(D3D_ROOT_SIGNATURE_VERSION convertToVersion, [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **")] D3D12_VERSIONED_ROOT_SIGNATURE_DESC** ppDesc)
        {
            return ((delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer*, D3D_ROOT_SIGNATURE_VERSION, D3D12_VERSIONED_ROOT_SIGNATURE_DESC**, int>)(lpVtbl[3]))((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this), convertToVersion, ppDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
        public D3D12_VERSIONED_ROOT_SIGNATURE_DESC* GetUnconvertedRootSignatureDesc()
        {
            return ((delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer*, D3D12_VERSIONED_ROOT_SIGNATURE_DESC*>)(lpVtbl[4]))((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this));
        }
    }
}
