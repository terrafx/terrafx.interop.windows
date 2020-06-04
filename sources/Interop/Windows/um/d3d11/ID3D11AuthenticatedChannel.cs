// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3015A308-DCBD-47AA-A747-192486D14D4A")]
    public unsafe partial struct ID3D11AuthenticatedChannel
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D11AuthenticatedChannel*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D11AuthenticatedChannel*, uint>)(lpVtbl[1]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D11AuthenticatedChannel*, uint>)(lpVtbl[2]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            ((delegate* stdcall<ID3D11AuthenticatedChannel*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D11AuthenticatedChannel*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D11AuthenticatedChannel*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* stdcall<ID3D11AuthenticatedChannel*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCertificateSize([NativeTypeName("UINT *")] uint* pCertificateSize)
        {
            return ((delegate* stdcall<ID3D11AuthenticatedChannel*, uint*, int>)(lpVtbl[7]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), pCertificateSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCertificate([NativeTypeName("UINT")] uint CertificateSize, [NativeTypeName("BYTE *")] byte* pCertificate)
        {
            return ((delegate* stdcall<ID3D11AuthenticatedChannel*, uint, byte*, int>)(lpVtbl[8]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), CertificateSize, pCertificate);
        }

        public void GetChannelHandle([NativeTypeName("HANDLE *")] IntPtr* pChannelHandle)
        {
            ((delegate* stdcall<ID3D11AuthenticatedChannel*, IntPtr*, void>)(lpVtbl[9]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), pChannelHandle);
        }
    }
}
