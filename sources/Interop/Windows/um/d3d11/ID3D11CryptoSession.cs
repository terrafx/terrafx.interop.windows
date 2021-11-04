// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B32F9AD-BDCC-40A6-A39D-D5C865845720")]
    [NativeTypeName("struct ID3D11CryptoSession : ID3D11DeviceChild")]
    [NativeInheritance("ID3D11DeviceChild")]
    public unsafe partial struct ID3D11CryptoSession
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11CryptoSession*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11CryptoSession*, uint>)(lpVtbl[1]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11CryptoSession*, uint>)(lpVtbl[2]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11CryptoSession*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11CryptoSession*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11CryptoSession*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11CryptoSession*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void GetCryptoType(Guid* pCryptoType)
        {
            ((delegate* unmanaged<ID3D11CryptoSession*, Guid*, void>)(lpVtbl[7]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCryptoType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void GetDecoderProfile(Guid* pDecoderProfile)
        {
            ((delegate* unmanaged<ID3D11CryptoSession*, Guid*, void>)(lpVtbl[8]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pDecoderProfile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetCertificateSize(uint* pCertificateSize)
        {
            return ((delegate* unmanaged<ID3D11CryptoSession*, uint*, int>)(lpVtbl[9]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCertificateSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetCertificate(uint CertificateSize, byte* pCertificate)
        {
            return ((delegate* unmanaged<ID3D11CryptoSession*, uint, byte*, int>)(lpVtbl[10]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), CertificateSize, pCertificate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void GetCryptoSessionHandle(HANDLE* pCryptoSessionHandle)
        {
            ((delegate* unmanaged<ID3D11CryptoSession*, HANDLE*, void>)(lpVtbl[11]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCryptoSessionHandle);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11CryptoSession*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11CryptoSession*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11CryptoSession*, uint> Release;

            [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11CryptoSession*, ID3D11Device**, void> GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11CryptoSession*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11CryptoSession*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11CryptoSession*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("void (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11CryptoSession*, Guid*, void> GetCryptoType;

            [NativeTypeName("void (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11CryptoSession*, Guid*, void> GetDecoderProfile;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11CryptoSession*, uint*, int> GetCertificateSize;

            [NativeTypeName("HRESULT (UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11CryptoSession*, uint, byte*, int> GetCertificate;

            [NativeTypeName("void (HANDLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11CryptoSession*, HANDLE*, void> GetCryptoSessionHandle;
        }
    }
}
