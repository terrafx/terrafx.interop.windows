// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d11.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B32F9AD-BDCC-40A6-A39D-D5C865845720")]
    public unsafe partial struct ID3D11CryptoSession
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11CryptoSession* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11CryptoSession* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11CryptoSession* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDevice(ID3D11CryptoSession* pThis, [NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D11CryptoSession* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D11CryptoSession* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D11CryptoSession* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetCryptoType(ID3D11CryptoSession* pThis, [NativeTypeName("GUID *")] Guid* pCryptoType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDecoderProfile(ID3D11CryptoSession* pThis, [NativeTypeName("GUID *")] Guid* pDecoderProfile);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCertificateSize(ID3D11CryptoSession* pThis, [NativeTypeName("UINT *")] uint* pCertificateSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCertificate(ID3D11CryptoSession* pThis, [NativeTypeName("UINT")] uint CertificateSize, [NativeTypeName("BYTE *")] byte* pCertificate);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetCryptoSessionHandle(ID3D11CryptoSession* pThis, [NativeTypeName("HANDLE *")] void** pCryptoSessionHandle);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11CryptoSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11CryptoSession*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, pData);
        }

        public void GetCryptoType([NativeTypeName("GUID *")] Guid* pCryptoType)
        {
            Marshal.GetDelegateForFunctionPointer<_GetCryptoType>(lpVtbl->GetCryptoType)((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCryptoType);
        }

        public void GetDecoderProfile([NativeTypeName("GUID *")] Guid* pDecoderProfile)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDecoderProfile>(lpVtbl->GetDecoderProfile)((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pDecoderProfile);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCertificateSize([NativeTypeName("UINT *")] uint* pCertificateSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCertificateSize>(lpVtbl->GetCertificateSize)((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCertificateSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCertificate([NativeTypeName("UINT")] uint CertificateSize, [NativeTypeName("BYTE *")] byte* pCertificate)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCertificate>(lpVtbl->GetCertificate)((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), CertificateSize, pCertificate);
        }

        public void GetCryptoSessionHandle([NativeTypeName("HANDLE *")] void** pCryptoSessionHandle)
        {
            Marshal.GetDelegateForFunctionPointer<_GetCryptoSessionHandle>(lpVtbl->GetCryptoSessionHandle)((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCryptoSessionHandle);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **)")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG ()")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG ()")]
            public IntPtr Release;

            [NativeTypeName("void (ID3D11Device **)")]
            public IntPtr GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *)")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *)")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *)")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("void (GUID *)")]
            public IntPtr GetCryptoType;

            [NativeTypeName("void (GUID *)")]
            public IntPtr GetDecoderProfile;

            [NativeTypeName("HRESULT (UINT *)")]
            public IntPtr GetCertificateSize;

            [NativeTypeName("HRESULT (UINT, BYTE *)")]
            public IntPtr GetCertificate;

            [NativeTypeName("void (HANDLE *)")]
            public IntPtr GetCryptoSessionHandle;
        }
    }
}
