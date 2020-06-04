// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D6F12DD6-76FB-406E-8961-4296EEFC0409")]
    public unsafe partial struct ID3D12ProtectedResourceSession1
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession1*, uint>)(lpVtbl[1]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession1*, uint>)(lpVtbl[2]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession1*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession1*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession1*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession1*, ushort*, int>)(lpVtbl[6]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStatusFence([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppFence)
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)(lpVtbl[8]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), riid, ppFence);
        }

        public D3D12_PROTECTED_SESSION_STATUS GetSessionStatus()
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession1*, D3D12_PROTECTED_SESSION_STATUS>)(lpVtbl[9]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this));
        }

        public D3D12_PROTECTED_RESOURCE_SESSION_DESC GetDesc()
        {
            D3D12_PROTECTED_RESOURCE_SESSION_DESC result;
            return *((delegate* stdcall<ID3D12ProtectedResourceSession1*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*>)(lpVtbl[10]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), &result);
        }

        public D3D12_PROTECTED_RESOURCE_SESSION_DESC1 GetDesc1()
        {
            D3D12_PROTECTED_RESOURCE_SESSION_DESC1 result;
            return *((delegate* stdcall<ID3D12ProtectedResourceSession1*, D3D12_PROTECTED_RESOURCE_SESSION_DESC1*, D3D12_PROTECTED_RESOURCE_SESSION_DESC1*>)(lpVtbl[11]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), &result);
        }
    }
}
