// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A4966EED-76DB-44DA-84C1-EE9A7AFB20A8")]
    public unsafe partial struct IDXGIFactory7
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDXGIFactory7*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDXGIFactory7*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDXGIFactory7*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((IDXGIFactory7*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return lpVtbl->SetPrivateDataInterface((IDXGIFactory7*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((IDXGIFactory7*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return lpVtbl->GetParent((IDXGIFactory7*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapters([NativeTypeName("UINT")] uint Adapter, [NativeTypeName("IDXGIAdapter **")] IDXGIAdapter** ppAdapter)
        {
            return lpVtbl->EnumAdapters((IDXGIFactory7*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int MakeWindowAssociation([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint Flags)
        {
            return lpVtbl->MakeWindowAssociation((IDXGIFactory7*)Unsafe.AsPointer(ref this), WindowHandle, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindowAssociation([NativeTypeName("HWND *")] IntPtr* pWindowHandle)
        {
            return lpVtbl->GetWindowAssociation((IDXGIFactory7*)Unsafe.AsPointer(ref this), pWindowHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChain([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("DXGI_SWAP_CHAIN_DESC *")] DXGI_SWAP_CHAIN_DESC* pDesc, [NativeTypeName("IDXGISwapChain **")] IDXGISwapChain** ppSwapChain)
        {
            return lpVtbl->CreateSwapChain((IDXGIFactory7*)Unsafe.AsPointer(ref this), pDevice, pDesc, ppSwapChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSoftwareAdapter([NativeTypeName("HMODULE")] IntPtr Module, [NativeTypeName("IDXGIAdapter **")] IDXGIAdapter** ppAdapter)
        {
            return lpVtbl->CreateSoftwareAdapter((IDXGIFactory7*)Unsafe.AsPointer(ref this), Module, ppAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapters1([NativeTypeName("UINT")] uint Adapter, [NativeTypeName("IDXGIAdapter1 **")] IDXGIAdapter1** ppAdapter)
        {
            return lpVtbl->EnumAdapters1((IDXGIFactory7*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
        }

        [return: NativeTypeName("BOOL")]
        public int IsCurrent()
        {
            return lpVtbl->IsCurrent((IDXGIFactory7*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsWindowedStereoEnabled()
        {
            return lpVtbl->IsWindowedStereoEnabled((IDXGIFactory7*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForHwnd([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, [NativeTypeName("const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pFullscreenDesc, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pRestrictToOutput, [NativeTypeName("IDXGISwapChain1 **")] IDXGISwapChain1** ppSwapChain)
        {
            return lpVtbl->CreateSwapChainForHwnd((IDXGIFactory7*)Unsafe.AsPointer(ref this), pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForCoreWindow([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("IUnknown *")] IUnknown* pWindow, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pRestrictToOutput, [NativeTypeName("IDXGISwapChain1 **")] IDXGISwapChain1** ppSwapChain)
        {
            return lpVtbl->CreateSwapChainForCoreWindow((IDXGIFactory7*)Unsafe.AsPointer(ref this), pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSharedResourceAdapterLuid([NativeTypeName("HANDLE")] IntPtr hResource, [NativeTypeName("LUID *")] LUID* pLuid)
        {
            return lpVtbl->GetSharedResourceAdapterLuid((IDXGIFactory7*)Unsafe.AsPointer(ref this), hResource, pLuid);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterStereoStatusWindow([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return lpVtbl->RegisterStereoStatusWindow((IDXGIFactory7*)Unsafe.AsPointer(ref this), WindowHandle, wMsg, pdwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterStereoStatusEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return lpVtbl->RegisterStereoStatusEvent((IDXGIFactory7*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        public void UnregisterStereoStatus([NativeTypeName("DWORD")] uint dwCookie)
        {
            lpVtbl->UnregisterStereoStatus((IDXGIFactory7*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterOcclusionStatusWindow([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return lpVtbl->RegisterOcclusionStatusWindow((IDXGIFactory7*)Unsafe.AsPointer(ref this), WindowHandle, wMsg, pdwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterOcclusionStatusEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return lpVtbl->RegisterOcclusionStatusEvent((IDXGIFactory7*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        public void UnregisterOcclusionStatus([NativeTypeName("DWORD")] uint dwCookie)
        {
            lpVtbl->UnregisterOcclusionStatus((IDXGIFactory7*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForComposition([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pRestrictToOutput, [NativeTypeName("IDXGISwapChain1 **")] IDXGISwapChain1** ppSwapChain)
        {
            return lpVtbl->CreateSwapChainForComposition((IDXGIFactory7*)Unsafe.AsPointer(ref this), pDevice, pDesc, pRestrictToOutput, ppSwapChain);
        }

        [return: NativeTypeName("UINT")]
        public uint GetCreationFlags()
        {
            return lpVtbl->GetCreationFlags((IDXGIFactory7*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapterByLuid(LUID AdapterLuid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter)
        {
            return lpVtbl->EnumAdapterByLuid((IDXGIFactory7*)Unsafe.AsPointer(ref this), AdapterLuid, riid, ppvAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumWarpAdapter([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter)
        {
            return lpVtbl->EnumWarpAdapter((IDXGIFactory7*)Unsafe.AsPointer(ref this), riid, ppvAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(DXGI_FEATURE Feature, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return lpVtbl->CheckFeatureSupport((IDXGIFactory7*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapterByGpuPreference([NativeTypeName("UINT")] uint Adapter, DXGI_GPU_PREFERENCE GpuPreference, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter)
        {
            return lpVtbl->EnumAdapterByGpuPreference((IDXGIFactory7*)Unsafe.AsPointer(ref this), Adapter, GpuPreference, riid, ppvAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterAdaptersChangedEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return lpVtbl->RegisterAdaptersChangedEvent((IDXGIFactory7*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterAdaptersChangedEvent([NativeTypeName("DWORD")] uint dwCookie)
        {
            return lpVtbl->UnregisterAdaptersChangedEvent((IDXGIFactory7*)Unsafe.AsPointer(ref this), dwCookie);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, Guid*, void**, int> GetParent;

            [NativeTypeName("HRESULT (UINT, IDXGIAdapter **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, uint, IDXGIAdapter**, int> EnumAdapters;

            [NativeTypeName("HRESULT (HWND, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, IntPtr, uint, int> MakeWindowAssociation;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, IntPtr*, int> GetWindowAssociation;

            [NativeTypeName("HRESULT (IUnknown *, DXGI_SWAP_CHAIN_DESC *, IDXGISwapChain **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, IUnknown*, DXGI_SWAP_CHAIN_DESC*, IDXGISwapChain**, int> CreateSwapChain;

            [NativeTypeName("HRESULT (HMODULE, IDXGIAdapter **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, IntPtr, IDXGIAdapter**, int> CreateSoftwareAdapter;

            [NativeTypeName("HRESULT (UINT, IDXGIAdapter1 **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, uint, IDXGIAdapter1**, int> EnumAdapters1;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, int> IsCurrent;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, int> IsWindowedStereoEnabled;

            [NativeTypeName("HRESULT (IUnknown *, HWND, const DXGI_SWAP_CHAIN_DESC1 *, const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, IUnknown*, IntPtr, DXGI_SWAP_CHAIN_DESC1*, DXGI_SWAP_CHAIN_FULLSCREEN_DESC*, IDXGIOutput*, IDXGISwapChain1**, int> CreateSwapChainForHwnd;

            [NativeTypeName("HRESULT (IUnknown *, IUnknown *, const DXGI_SWAP_CHAIN_DESC1 *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, IUnknown*, IUnknown*, DXGI_SWAP_CHAIN_DESC1*, IDXGIOutput*, IDXGISwapChain1**, int> CreateSwapChainForCoreWindow;

            [NativeTypeName("HRESULT (HANDLE, LUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, IntPtr, LUID*, int> GetSharedResourceAdapterLuid;

            [NativeTypeName("HRESULT (HWND, UINT, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, IntPtr, uint, uint*, int> RegisterStereoStatusWindow;

            [NativeTypeName("HRESULT (HANDLE, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, IntPtr, uint*, int> RegisterStereoStatusEvent;

            [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, uint, void> UnregisterStereoStatus;

            [NativeTypeName("HRESULT (HWND, UINT, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, IntPtr, uint, uint*, int> RegisterOcclusionStatusWindow;

            [NativeTypeName("HRESULT (HANDLE, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, IntPtr, uint*, int> RegisterOcclusionStatusEvent;

            [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, uint, void> UnregisterOcclusionStatus;

            [NativeTypeName("HRESULT (IUnknown *, const DXGI_SWAP_CHAIN_DESC1 *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, IUnknown*, DXGI_SWAP_CHAIN_DESC1*, IDXGIOutput*, IDXGISwapChain1**, int> CreateSwapChainForComposition;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, uint> GetCreationFlags;

            [NativeTypeName("HRESULT (LUID, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, LUID, Guid*, void**, int> EnumAdapterByLuid;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, Guid*, void**, int> EnumWarpAdapter;

            [NativeTypeName("HRESULT (DXGI_FEATURE, void *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, DXGI_FEATURE, void*, uint, int> CheckFeatureSupport;

            [NativeTypeName("HRESULT (UINT, DXGI_GPU_PREFERENCE, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, uint, DXGI_GPU_PREFERENCE, Guid*, void**, int> EnumAdapterByGpuPreference;

            [NativeTypeName("HRESULT (HANDLE, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, IntPtr, uint*, int> RegisterAdaptersChangedEvent;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory7*, uint, int> UnregisterAdaptersChangedEvent;
        }
    }
}
