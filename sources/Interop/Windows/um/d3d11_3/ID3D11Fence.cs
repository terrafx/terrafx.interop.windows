// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AFFDE9D1-1DF7-4BB7-8A34-0F46251DAB80")]
    public unsafe partial struct ID3D11Fence
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D11Fence*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Fence*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D11Fence*, uint>)(lpVtbl[1]))((ID3D11Fence*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D11Fence*, uint>)(lpVtbl[2]))((ID3D11Fence*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            ((delegate* stdcall<ID3D11Fence*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Fence*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D11Fence*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Fence*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D11Fence*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Fence*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* stdcall<ID3D11Fence*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Fence*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSharedHandle([NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint dwAccess, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("HANDLE *")] IntPtr* pHandle)
        {
            return ((delegate* stdcall<ID3D11Fence*, SECURITY_ATTRIBUTES*, uint, ushort*, IntPtr*, int>)(lpVtbl[7]))((ID3D11Fence*)Unsafe.AsPointer(ref this), pAttributes, dwAccess, lpName, pHandle);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetCompletedValue()
        {
            return ((delegate* stdcall<ID3D11Fence*, ulong>)(lpVtbl[8]))((ID3D11Fence*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEventOnCompletion([NativeTypeName("UINT64")] ulong Value, [NativeTypeName("HANDLE")] IntPtr hEvent)
        {
            return ((delegate* stdcall<ID3D11Fence*, ulong, IntPtr, int>)(lpVtbl[9]))((ID3D11Fence*)Unsafe.AsPointer(ref this), Value, hEvent);
        }
    }
}
