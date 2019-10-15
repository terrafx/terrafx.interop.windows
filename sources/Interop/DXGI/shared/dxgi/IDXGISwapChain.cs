// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("310D36A0-D2E7-4C0A-AA04-6A9D23B8886A")]
    public unsafe partial struct IDXGISwapChain
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGISwapChain* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGISwapChain* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGISwapChain* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDXGISwapChain* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDXGISwapChain* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDXGISwapChain* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(IDXGISwapChain* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(IDXGISwapChain* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Present(IDXGISwapChain* pThis, [NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBuffer(IDXGISwapChain* pThis, [NativeTypeName("UINT")] uint Buffer, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppSurface);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFullscreenState(IDXGISwapChain* pThis, [NativeTypeName("BOOL")] int Fullscreen, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pTarget);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFullscreenState(IDXGISwapChain* pThis, [NativeTypeName("BOOL *")] int* pFullscreen, [NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppTarget);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(IDXGISwapChain* pThis, [NativeTypeName("DXGI_SWAP_CHAIN_DESC *")] DXGI_SWAP_CHAIN_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ResizeBuffers(IDXGISwapChain* pThis, [NativeTypeName("UINT")] uint BufferCount, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, DXGI_FORMAT NewFormat, [NativeTypeName("UINT")] uint SwapChainFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ResizeTarget(IDXGISwapChain* pThis, [NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pNewTargetParameters);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainingOutput(IDXGISwapChain* pThis, [NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppOutput);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameStatistics(IDXGISwapChain* pThis, [NativeTypeName("DXGI_FRAME_STATISTICS *")] DXGI_FRAME_STATISTICS* pStats);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLastPresentCount(IDXGISwapChain* pThis, [NativeTypeName("UINT *")] uint* pLastPresentCount);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDXGISwapChain*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDXGISwapChain*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDXGISwapChain*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((IDXGISwapChain*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((IDXGISwapChain*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((IDXGISwapChain*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)((IDXGISwapChain*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppDevice)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)((IDXGISwapChain*)Unsafe.AsPointer(ref this), riid, ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int Present([NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_Present>(lpVtbl->Present)((IDXGISwapChain*)Unsafe.AsPointer(ref this), SyncInterval, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("UINT")] uint Buffer, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppSurface)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBuffer>(lpVtbl->GetBuffer)((IDXGISwapChain*)Unsafe.AsPointer(ref this), Buffer, riid, ppSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFullscreenState([NativeTypeName("BOOL")] int Fullscreen, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pTarget)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFullscreenState>(lpVtbl->SetFullscreenState)((IDXGISwapChain*)Unsafe.AsPointer(ref this), Fullscreen, pTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFullscreenState([NativeTypeName("BOOL *")] int* pFullscreen, [NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppTarget)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFullscreenState>(lpVtbl->GetFullscreenState)((IDXGISwapChain*)Unsafe.AsPointer(ref this), pFullscreen, ppTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("DXGI_SWAP_CHAIN_DESC *")] DXGI_SWAP_CHAIN_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((IDXGISwapChain*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeBuffers([NativeTypeName("UINT")] uint BufferCount, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, DXGI_FORMAT NewFormat, [NativeTypeName("UINT")] uint SwapChainFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_ResizeBuffers>(lpVtbl->ResizeBuffers)((IDXGISwapChain*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, NewFormat, SwapChainFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeTarget([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pNewTargetParameters)
        {
            return Marshal.GetDelegateForFunctionPointer<_ResizeTarget>(lpVtbl->ResizeTarget)((IDXGISwapChain*)Unsafe.AsPointer(ref this), pNewTargetParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainingOutput([NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppOutput)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetContainingOutput>(lpVtbl->GetContainingOutput)((IDXGISwapChain*)Unsafe.AsPointer(ref this), ppOutput);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics([NativeTypeName("DXGI_FRAME_STATISTICS *")] DXGI_FRAME_STATISTICS* pStats)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFrameStatistics>(lpVtbl->GetFrameStatistics)((IDXGISwapChain*)Unsafe.AsPointer(ref this), pStats);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastPresentCount([NativeTypeName("UINT *")] uint* pLastPresentCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLastPresentCount>(lpVtbl->GetLastPresentCount)((IDXGISwapChain*)Unsafe.AsPointer(ref this), pLastPresentCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetParent;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetDevice;

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
            public IntPtr Present;

            [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetBuffer;

            [NativeTypeName("HRESULT (BOOL, IDXGIOutput *) __attribute__((stdcall))")]
            public IntPtr SetFullscreenState;

            [NativeTypeName("HRESULT (BOOL *, IDXGIOutput **) __attribute__((stdcall))")]
            public IntPtr GetFullscreenState;

            [NativeTypeName("HRESULT (DXGI_SWAP_CHAIN_DESC *) __attribute__((stdcall))")]
            public IntPtr GetDesc;

            [NativeTypeName("HRESULT (UINT, UINT, UINT, DXGI_FORMAT, UINT) __attribute__((stdcall))")]
            public IntPtr ResizeBuffers;

            [NativeTypeName("HRESULT (const DXGI_MODE_DESC *) __attribute__((stdcall))")]
            public IntPtr ResizeTarget;

            [NativeTypeName("HRESULT (IDXGIOutput **) __attribute__((stdcall))")]
            public IntPtr GetContainingOutput;

            [NativeTypeName("HRESULT (DXGI_FRAME_STATISTICS *) __attribute__((stdcall))")]
            public IntPtr GetFrameStatistics;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public IntPtr GetLastPresentCount;
        }
    }
}
