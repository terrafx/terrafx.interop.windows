// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3015A308-DCBD-47AA-A747-192486D14D4A")]
    [NativeTypeName("struct ID3D11AuthenticatedChannel : ID3D11DeviceChild")]
    [NativeInheritance("ID3D11DeviceChild")]
    public unsafe partial struct ID3D11AuthenticatedChannel
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11AuthenticatedChannel*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11AuthenticatedChannel*, uint>)(lpVtbl[1]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11AuthenticatedChannel*, uint>)(lpVtbl[2]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11AuthenticatedChannel*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11AuthenticatedChannel*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11AuthenticatedChannel*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11AuthenticatedChannel*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetCertificateSize(uint* pCertificateSize)
        {
            return ((delegate* unmanaged<ID3D11AuthenticatedChannel*, uint*, int>)(lpVtbl[7]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), pCertificateSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetCertificate(uint CertificateSize, byte* pCertificate)
        {
            return ((delegate* unmanaged<ID3D11AuthenticatedChannel*, uint, byte*, int>)(lpVtbl[8]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), CertificateSize, pCertificate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void GetChannelHandle(HANDLE* pChannelHandle)
        {
            ((delegate* unmanaged<ID3D11AuthenticatedChannel*, HANDLE*, void>)(lpVtbl[9]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), pChannelHandle);
        }
    }
}
