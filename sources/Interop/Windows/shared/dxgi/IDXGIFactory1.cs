// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("770AAE78-F26F-4DBA-A829-253C83D1B387")]
    public unsafe partial struct IDXGIFactory1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDXGIFactory1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDXGIFactory1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDXGIFactory1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((IDXGIFactory1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return lpVtbl->SetPrivateDataInterface((IDXGIFactory1*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((IDXGIFactory1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return lpVtbl->GetParent((IDXGIFactory1*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapters([NativeTypeName("UINT")] uint Adapter, [NativeTypeName("IDXGIAdapter **")] IDXGIAdapter** ppAdapter)
        {
            return lpVtbl->EnumAdapters((IDXGIFactory1*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int MakeWindowAssociation([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint Flags)
        {
            return lpVtbl->MakeWindowAssociation((IDXGIFactory1*)Unsafe.AsPointer(ref this), WindowHandle, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindowAssociation([NativeTypeName("HWND *")] IntPtr* pWindowHandle)
        {
            return lpVtbl->GetWindowAssociation((IDXGIFactory1*)Unsafe.AsPointer(ref this), pWindowHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChain([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("DXGI_SWAP_CHAIN_DESC *")] DXGI_SWAP_CHAIN_DESC* pDesc, [NativeTypeName("IDXGISwapChain **")] IDXGISwapChain** ppSwapChain)
        {
            return lpVtbl->CreateSwapChain((IDXGIFactory1*)Unsafe.AsPointer(ref this), pDevice, pDesc, ppSwapChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSoftwareAdapter([NativeTypeName("HMODULE")] IntPtr Module, [NativeTypeName("IDXGIAdapter **")] IDXGIAdapter** ppAdapter)
        {
            return lpVtbl->CreateSoftwareAdapter((IDXGIFactory1*)Unsafe.AsPointer(ref this), Module, ppAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapters1([NativeTypeName("UINT")] uint Adapter, [NativeTypeName("IDXGIAdapter1 **")] IDXGIAdapter1** ppAdapter)
        {
            return lpVtbl->EnumAdapters1((IDXGIFactory1*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
        }

        [return: NativeTypeName("BOOL")]
        public int IsCurrent()
        {
            return lpVtbl->IsCurrent((IDXGIFactory1*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory1*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory1*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory1*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory1*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory1*, Guid*, void**, int> GetParent;

            [NativeTypeName("HRESULT (UINT, IDXGIAdapter **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory1*, uint, IDXGIAdapter**, int> EnumAdapters;

            [NativeTypeName("HRESULT (HWND, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory1*, IntPtr, uint, int> MakeWindowAssociation;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory1*, IntPtr*, int> GetWindowAssociation;

            [NativeTypeName("HRESULT (IUnknown *, DXGI_SWAP_CHAIN_DESC *, IDXGISwapChain **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory1*, IUnknown*, DXGI_SWAP_CHAIN_DESC*, IDXGISwapChain**, int> CreateSwapChain;

            [NativeTypeName("HRESULT (HMODULE, IDXGIAdapter **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory1*, IntPtr, IDXGIAdapter**, int> CreateSoftwareAdapter;

            [NativeTypeName("HRESULT (UINT, IDXGIAdapter1 **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory1*, uint, IDXGIAdapter1**, int> EnumAdapters1;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory1*, int> IsCurrent;
        }
    }
}
