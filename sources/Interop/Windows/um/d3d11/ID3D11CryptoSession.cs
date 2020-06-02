// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B32F9AD-BDCC-40A6-A39D-D5C865845720")]
    public unsafe partial struct ID3D11CryptoSession
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D11CryptoSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D11CryptoSession*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            lpVtbl->GetDevice((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return lpVtbl->SetPrivateDataInterface((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, pData);
        }

        public void GetCryptoType([NativeTypeName("GUID *")] Guid* pCryptoType)
        {
            lpVtbl->GetCryptoType((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCryptoType);
        }

        public void GetDecoderProfile([NativeTypeName("GUID *")] Guid* pDecoderProfile)
        {
            lpVtbl->GetDecoderProfile((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pDecoderProfile);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCertificateSize([NativeTypeName("UINT *")] uint* pCertificateSize)
        {
            return lpVtbl->GetCertificateSize((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCertificateSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCertificate([NativeTypeName("UINT")] uint CertificateSize, [NativeTypeName("BYTE *")] byte* pCertificate)
        {
            return lpVtbl->GetCertificate((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), CertificateSize, pCertificate);
        }

        public void GetCryptoSessionHandle([NativeTypeName("HANDLE *")] IntPtr* pCryptoSessionHandle)
        {
            lpVtbl->GetCryptoSessionHandle((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCryptoSessionHandle);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11CryptoSession*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11CryptoSession*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11CryptoSession*, uint> Release;

            [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11CryptoSession*, ID3D11Device**, void> GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11CryptoSession*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11CryptoSession*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11CryptoSession*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("void (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11CryptoSession*, Guid*, void> GetCryptoType;

            [NativeTypeName("void (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11CryptoSession*, Guid*, void> GetDecoderProfile;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11CryptoSession*, uint*, int> GetCertificateSize;

            [NativeTypeName("HRESULT (UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11CryptoSession*, uint, byte*, int> GetCertificate;

            [NativeTypeName("void (HANDLE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11CryptoSession*, IntPtr*, void> GetCryptoSessionHandle;
        }
    }
}
