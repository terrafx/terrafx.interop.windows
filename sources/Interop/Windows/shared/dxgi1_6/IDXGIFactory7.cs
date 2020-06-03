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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDXGIFactory7*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDXGIFactory7*, uint>)(lpVtbl[1]))((IDXGIFactory7*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDXGIFactory7*, uint>)(lpVtbl[2]))((IDXGIFactory7*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<IDXGIFactory7*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* stdcall<IDXGIFactory7*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<IDXGIFactory7*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return ((delegate* stdcall<IDXGIFactory7*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapters([NativeTypeName("UINT")] uint Adapter, [NativeTypeName("IDXGIAdapter **")] IDXGIAdapter** ppAdapter)
        {
            return ((delegate* stdcall<IDXGIFactory7*, uint, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int MakeWindowAssociation([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint Flags)
        {
            return ((delegate* stdcall<IDXGIFactory7*, IntPtr, uint, int>)(lpVtbl[8]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), WindowHandle, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindowAssociation([NativeTypeName("HWND *")] IntPtr* pWindowHandle)
        {
            return ((delegate* stdcall<IDXGIFactory7*, IntPtr*, int>)(lpVtbl[9]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), pWindowHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChain([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("DXGI_SWAP_CHAIN_DESC *")] DXGI_SWAP_CHAIN_DESC* pDesc, [NativeTypeName("IDXGISwapChain **")] IDXGISwapChain** ppSwapChain)
        {
            return ((delegate* stdcall<IDXGIFactory7*, IUnknown*, DXGI_SWAP_CHAIN_DESC*, IDXGISwapChain**, int>)(lpVtbl[10]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), pDevice, pDesc, ppSwapChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSoftwareAdapter([NativeTypeName("HMODULE")] IntPtr Module, [NativeTypeName("IDXGIAdapter **")] IDXGIAdapter** ppAdapter)
        {
            return ((delegate* stdcall<IDXGIFactory7*, IntPtr, IDXGIAdapter**, int>)(lpVtbl[11]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Module, ppAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapters1([NativeTypeName("UINT")] uint Adapter, [NativeTypeName("IDXGIAdapter1 **")] IDXGIAdapter1** ppAdapter)
        {
            return ((delegate* stdcall<IDXGIFactory7*, uint, IDXGIAdapter1**, int>)(lpVtbl[12]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
        }

        [return: NativeTypeName("BOOL")]
        public int IsCurrent()
        {
            return ((delegate* stdcall<IDXGIFactory7*, int>)(lpVtbl[13]))((IDXGIFactory7*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsWindowedStereoEnabled()
        {
            return ((delegate* stdcall<IDXGIFactory7*, int>)(lpVtbl[14]))((IDXGIFactory7*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForHwnd([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, [NativeTypeName("const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pFullscreenDesc, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pRestrictToOutput, [NativeTypeName("IDXGISwapChain1 **")] IDXGISwapChain1** ppSwapChain)
        {
            return ((delegate* stdcall<IDXGIFactory7*, IUnknown*, IntPtr, DXGI_SWAP_CHAIN_DESC1*, DXGI_SWAP_CHAIN_FULLSCREEN_DESC*, IDXGIOutput*, IDXGISwapChain1**, int>)(lpVtbl[15]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForCoreWindow([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("IUnknown *")] IUnknown* pWindow, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pRestrictToOutput, [NativeTypeName("IDXGISwapChain1 **")] IDXGISwapChain1** ppSwapChain)
        {
            return ((delegate* stdcall<IDXGIFactory7*, IUnknown*, IUnknown*, DXGI_SWAP_CHAIN_DESC1*, IDXGIOutput*, IDXGISwapChain1**, int>)(lpVtbl[16]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSharedResourceAdapterLuid([NativeTypeName("HANDLE")] IntPtr hResource, [NativeTypeName("LUID *")] LUID* pLuid)
        {
            return ((delegate* stdcall<IDXGIFactory7*, IntPtr, LUID*, int>)(lpVtbl[17]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), hResource, pLuid);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterStereoStatusWindow([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* stdcall<IDXGIFactory7*, IntPtr, uint, uint*, int>)(lpVtbl[18]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), WindowHandle, wMsg, pdwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterStereoStatusEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* stdcall<IDXGIFactory7*, IntPtr, uint*, int>)(lpVtbl[19]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        public void UnregisterStereoStatus([NativeTypeName("DWORD")] uint dwCookie)
        {
            ((delegate* stdcall<IDXGIFactory7*, uint, void>)(lpVtbl[20]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterOcclusionStatusWindow([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* stdcall<IDXGIFactory7*, IntPtr, uint, uint*, int>)(lpVtbl[21]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), WindowHandle, wMsg, pdwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterOcclusionStatusEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* stdcall<IDXGIFactory7*, IntPtr, uint*, int>)(lpVtbl[22]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        public void UnregisterOcclusionStatus([NativeTypeName("DWORD")] uint dwCookie)
        {
            ((delegate* stdcall<IDXGIFactory7*, uint, void>)(lpVtbl[23]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForComposition([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pRestrictToOutput, [NativeTypeName("IDXGISwapChain1 **")] IDXGISwapChain1** ppSwapChain)
        {
            return ((delegate* stdcall<IDXGIFactory7*, IUnknown*, DXGI_SWAP_CHAIN_DESC1*, IDXGIOutput*, IDXGISwapChain1**, int>)(lpVtbl[24]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), pDevice, pDesc, pRestrictToOutput, ppSwapChain);
        }

        [return: NativeTypeName("UINT")]
        public uint GetCreationFlags()
        {
            return ((delegate* stdcall<IDXGIFactory7*, uint>)(lpVtbl[25]))((IDXGIFactory7*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapterByLuid(LUID AdapterLuid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter)
        {
            return ((delegate* stdcall<IDXGIFactory7*, LUID, Guid*, void**, int>)(lpVtbl[26]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), AdapterLuid, riid, ppvAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumWarpAdapter([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter)
        {
            return ((delegate* stdcall<IDXGIFactory7*, Guid*, void**, int>)(lpVtbl[27]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), riid, ppvAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(DXGI_FEATURE Feature, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return ((delegate* stdcall<IDXGIFactory7*, DXGI_FEATURE, void*, uint, int>)(lpVtbl[28]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapterByGpuPreference([NativeTypeName("UINT")] uint Adapter, DXGI_GPU_PREFERENCE GpuPreference, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter)
        {
            return ((delegate* stdcall<IDXGIFactory7*, uint, DXGI_GPU_PREFERENCE, Guid*, void**, int>)(lpVtbl[29]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Adapter, GpuPreference, riid, ppvAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterAdaptersChangedEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* stdcall<IDXGIFactory7*, IntPtr, uint*, int>)(lpVtbl[30]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterAdaptersChangedEvent([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* stdcall<IDXGIFactory7*, uint, int>)(lpVtbl[31]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), dwCookie);
        }
    }
}
