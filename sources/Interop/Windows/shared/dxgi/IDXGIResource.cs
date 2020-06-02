// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("035F3AB4-482E-4E50-B41F-8A7F8BD8960B")]
    public unsafe partial struct IDXGIResource
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDXGIResource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDXGIResource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDXGIResource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((IDXGIResource*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return lpVtbl->SetPrivateDataInterface((IDXGIResource*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((IDXGIResource*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return lpVtbl->GetParent((IDXGIResource*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppDevice)
        {
            return lpVtbl->GetDevice((IDXGIResource*)Unsafe.AsPointer(ref this), riid, ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSharedHandle([NativeTypeName("HANDLE *")] IntPtr* pSharedHandle)
        {
            return lpVtbl->GetSharedHandle((IDXGIResource*)Unsafe.AsPointer(ref this), pSharedHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUsage([NativeTypeName("DXGI_USAGE *")] uint* pUsage)
        {
            return lpVtbl->GetUsage((IDXGIResource*)Unsafe.AsPointer(ref this), pUsage);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEvictionPriority([NativeTypeName("UINT")] uint EvictionPriority)
        {
            return lpVtbl->SetEvictionPriority((IDXGIResource*)Unsafe.AsPointer(ref this), EvictionPriority);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEvictionPriority([NativeTypeName("UINT *")] uint* pEvictionPriority)
        {
            return lpVtbl->GetEvictionPriority((IDXGIResource*)Unsafe.AsPointer(ref this), pEvictionPriority);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIResource*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIResource*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIResource*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIResource*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIResource*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIResource*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIResource*, Guid*, void**, int> GetParent;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIResource*, Guid*, void**, int> GetDevice;

            [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIResource*, IntPtr*, int> GetSharedHandle;

            [NativeTypeName("HRESULT (DXGI_USAGE *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIResource*, uint*, int> GetUsage;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIResource*, uint, int> SetEvictionPriority;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIResource*, uint*, int> GetEvictionPriority;
        }
    }
}
