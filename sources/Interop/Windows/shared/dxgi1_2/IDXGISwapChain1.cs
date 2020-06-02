// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("790A45F7-0D42-4876-983A-0A55CFE6F4AA")]
    public unsafe partial struct IDXGISwapChain1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return lpVtbl->SetPrivateDataInterface((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return lpVtbl->GetParent((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppDevice)
        {
            return lpVtbl->GetDevice((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int Present([NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags)
        {
            return lpVtbl->Present((IDXGISwapChain1*)Unsafe.AsPointer(ref this), SyncInterval, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("UINT")] uint Buffer, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppSurface)
        {
            return lpVtbl->GetBuffer((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Buffer, riid, ppSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFullscreenState([NativeTypeName("BOOL")] int Fullscreen, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pTarget)
        {
            return lpVtbl->SetFullscreenState((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Fullscreen, pTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFullscreenState([NativeTypeName("BOOL *")] int* pFullscreen, [NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppTarget)
        {
            return lpVtbl->GetFullscreenState((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pFullscreen, ppTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("DXGI_SWAP_CHAIN_DESC *")] DXGI_SWAP_CHAIN_DESC* pDesc)
        {
            return lpVtbl->GetDesc((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeBuffers([NativeTypeName("UINT")] uint BufferCount, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, DXGI_FORMAT NewFormat, [NativeTypeName("UINT")] uint SwapChainFlags)
        {
            return lpVtbl->ResizeBuffers((IDXGISwapChain1*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, NewFormat, SwapChainFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeTarget([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pNewTargetParameters)
        {
            return lpVtbl->ResizeTarget((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pNewTargetParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainingOutput([NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppOutput)
        {
            return lpVtbl->GetContainingOutput((IDXGISwapChain1*)Unsafe.AsPointer(ref this), ppOutput);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics([NativeTypeName("DXGI_FRAME_STATISTICS *")] DXGI_FRAME_STATISTICS* pStats)
        {
            return lpVtbl->GetFrameStatistics((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pStats);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastPresentCount([NativeTypeName("UINT *")] uint* pLastPresentCount)
        {
            return lpVtbl->GetLastPresentCount((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pLastPresentCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc1([NativeTypeName("DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc)
        {
            return lpVtbl->GetDesc1((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFullscreenDesc([NativeTypeName("DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc)
        {
            return lpVtbl->GetFullscreenDesc((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHwnd([NativeTypeName("HWND *")] IntPtr* pHwnd)
        {
            return lpVtbl->GetHwnd((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pHwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCoreWindow([NativeTypeName("const IID &")] Guid* refiid, [NativeTypeName("void **")] void** ppUnk)
        {
            return lpVtbl->GetCoreWindow((IDXGISwapChain1*)Unsafe.AsPointer(ref this), refiid, ppUnk);
        }

        [return: NativeTypeName("HRESULT")]
        public int Present1([NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint PresentFlags, [NativeTypeName("const DXGI_PRESENT_PARAMETERS *")] DXGI_PRESENT_PARAMETERS* pPresentParameters)
        {
            return lpVtbl->Present1((IDXGISwapChain1*)Unsafe.AsPointer(ref this), SyncInterval, PresentFlags, pPresentParameters);
        }

        [return: NativeTypeName("BOOL")]
        public int IsTemporaryMonoSupported()
        {
            return lpVtbl->IsTemporaryMonoSupported((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRestrictToOutput([NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppRestrictToOutput)
        {
            return lpVtbl->GetRestrictToOutput((IDXGISwapChain1*)Unsafe.AsPointer(ref this), ppRestrictToOutput);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBackgroundColor([NativeTypeName("const DXGI_RGBA *")] DXGI_RGBA* pColor)
        {
            return lpVtbl->SetBackgroundColor((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pColor);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBackgroundColor([NativeTypeName("DXGI_RGBA *")] DXGI_RGBA* pColor)
        {
            return lpVtbl->GetBackgroundColor((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pColor);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRotation(DXGI_MODE_ROTATION Rotation)
        {
            return lpVtbl->SetRotation((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Rotation);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRotation([NativeTypeName("DXGI_MODE_ROTATION *")] DXGI_MODE_ROTATION* pRotation)
        {
            return lpVtbl->GetRotation((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pRotation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, Guid*, void**, int> GetParent;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, Guid*, void**, int> GetDevice;

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, uint, uint, int> Present;

            [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, uint, Guid*, void**, int> GetBuffer;

            [NativeTypeName("HRESULT (BOOL, IDXGIOutput *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, int, IDXGIOutput*, int> SetFullscreenState;

            [NativeTypeName("HRESULT (BOOL *, IDXGIOutput **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, int*, IDXGIOutput**, int> GetFullscreenState;

            [NativeTypeName("HRESULT (DXGI_SWAP_CHAIN_DESC *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, DXGI_SWAP_CHAIN_DESC*, int> GetDesc;

            [NativeTypeName("HRESULT (UINT, UINT, UINT, DXGI_FORMAT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, uint, uint, uint, DXGI_FORMAT, uint, int> ResizeBuffers;

            [NativeTypeName("HRESULT (const DXGI_MODE_DESC *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, DXGI_MODE_DESC*, int> ResizeTarget;

            [NativeTypeName("HRESULT (IDXGIOutput **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, IDXGIOutput**, int> GetContainingOutput;

            [NativeTypeName("HRESULT (DXGI_FRAME_STATISTICS *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, DXGI_FRAME_STATISTICS*, int> GetFrameStatistics;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, uint*, int> GetLastPresentCount;

            [NativeTypeName("HRESULT (DXGI_SWAP_CHAIN_DESC1 *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, DXGI_SWAP_CHAIN_DESC1*, int> GetDesc1;

            [NativeTypeName("HRESULT (DXGI_SWAP_CHAIN_FULLSCREEN_DESC *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, DXGI_SWAP_CHAIN_FULLSCREEN_DESC*, int> GetFullscreenDesc;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, IntPtr*, int> GetHwnd;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, Guid*, void**, int> GetCoreWindow;

            [NativeTypeName("HRESULT (UINT, UINT, const DXGI_PRESENT_PARAMETERS *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, uint, uint, DXGI_PRESENT_PARAMETERS*, int> Present1;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, int> IsTemporaryMonoSupported;

            [NativeTypeName("HRESULT (IDXGIOutput **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, IDXGIOutput**, int> GetRestrictToOutput;

            [NativeTypeName("HRESULT (const DXGI_RGBA *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, DXGI_RGBA*, int> SetBackgroundColor;

            [NativeTypeName("HRESULT (DXGI_RGBA *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, DXGI_RGBA*, int> GetBackgroundColor;

            [NativeTypeName("HRESULT (DXGI_MODE_ROTATION) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, DXGI_MODE_ROTATION, int> SetRotation;

            [NativeTypeName("HRESULT (DXGI_MODE_ROTATION *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGISwapChain1*, DXGI_MODE_ROTATION*, int> GetRotation;
        }
    }
}
