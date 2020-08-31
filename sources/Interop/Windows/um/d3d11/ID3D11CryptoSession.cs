// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B32F9AD-BDCC-40A6-A39D-D5C865845720")]
    [NativeTypeName("struct ID3D11CryptoSession : ID3D11DeviceChild")]
    public unsafe partial struct ID3D11CryptoSession
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D11CryptoSession*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D11CryptoSession*, uint>)(lpVtbl[1]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D11CryptoSession*, uint>)(lpVtbl[2]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            ((delegate* stdcall<ID3D11CryptoSession*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D11CryptoSession*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D11CryptoSession*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* stdcall<ID3D11CryptoSession*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetCryptoType([NativeTypeName("GUID *")] Guid* pCryptoType)
        {
            ((delegate* stdcall<ID3D11CryptoSession*, Guid*, void>)(lpVtbl[7]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCryptoType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDecoderProfile([NativeTypeName("GUID *")] Guid* pDecoderProfile)
        {
            ((delegate* stdcall<ID3D11CryptoSession*, Guid*, void>)(lpVtbl[8]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pDecoderProfile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCertificateSize([NativeTypeName("UINT *")] uint* pCertificateSize)
        {
            return ((delegate* stdcall<ID3D11CryptoSession*, uint*, int>)(lpVtbl[9]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCertificateSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCertificate([NativeTypeName("UINT")] uint CertificateSize, [NativeTypeName("BYTE *")] byte* pCertificate)
        {
            return ((delegate* stdcall<ID3D11CryptoSession*, uint, byte*, int>)(lpVtbl[10]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), CertificateSize, pCertificate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetCryptoSessionHandle([NativeTypeName("HANDLE *")] IntPtr* pCryptoSessionHandle)
        {
            ((delegate* stdcall<ID3D11CryptoSession*, IntPtr*, void>)(lpVtbl[11]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCryptoSessionHandle);
        }
    }
}
