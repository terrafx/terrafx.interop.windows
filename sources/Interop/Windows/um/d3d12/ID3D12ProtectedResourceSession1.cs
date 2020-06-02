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
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return lpVtbl->SetPrivateDataInterface((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return lpVtbl->SetName((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return lpVtbl->GetDevice((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStatusFence([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppFence)
        {
            return lpVtbl->GetStatusFence((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), riid, ppFence);
        }

        public D3D12_PROTECTED_SESSION_STATUS GetSessionStatus()
        {
            return lpVtbl->GetSessionStatus((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this));
        }

        public D3D12_PROTECTED_RESOURCE_SESSION_DESC GetDesc()
        {
            D3D12_PROTECTED_RESOURCE_SESSION_DESC result;
            return *lpVtbl->GetDesc((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), &result);
        }

        public D3D12_PROTECTED_RESOURCE_SESSION_DESC1 GetDesc1()
        {
            D3D12_PROTECTED_RESOURCE_SESSION_DESC1 result;
            return *lpVtbl->GetDesc1((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), &result);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ProtectedResourceSession1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ProtectedResourceSession1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ProtectedResourceSession1*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ProtectedResourceSession1*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ProtectedResourceSession1*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ProtectedResourceSession1*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ProtectedResourceSession1*, ushort*, int> SetName;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ProtectedResourceSession1*, Guid*, void**, int> GetDevice;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ProtectedResourceSession1*, Guid*, void**, int> GetStatusFence;

            [NativeTypeName("D3D12_PROTECTED_SESSION_STATUS () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ProtectedResourceSession1*, D3D12_PROTECTED_SESSION_STATUS> GetSessionStatus;

            [NativeTypeName("D3D12_PROTECTED_RESOURCE_SESSION_DESC () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ProtectedResourceSession1*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*> GetDesc;

            [NativeTypeName("D3D12_PROTECTED_RESOURCE_SESSION_DESC1 () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ProtectedResourceSession1*, D3D12_PROTECTED_RESOURCE_SESSION_DESC1*, D3D12_PROTECTED_RESOURCE_SESSION_DESC1*> GetDesc1;
        }
    }
}
