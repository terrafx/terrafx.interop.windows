// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A8BE2AC4-199F-4946-B331-79599FB98DE7")]
    public unsafe partial struct IDXGISwapChain2
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGISwapChain2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGISwapChain2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGISwapChain2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDXGISwapChain2* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDXGISwapChain2* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDXGISwapChain2* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(IDXGISwapChain2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(IDXGISwapChain2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Present(IDXGISwapChain2* pThis, [NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBuffer(IDXGISwapChain2* pThis, [NativeTypeName("UINT")] uint Buffer, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppSurface);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFullscreenState(IDXGISwapChain2* pThis, [NativeTypeName("BOOL")] int Fullscreen, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pTarget);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFullscreenState(IDXGISwapChain2* pThis, [NativeTypeName("BOOL *")] int* pFullscreen, [NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppTarget);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(IDXGISwapChain2* pThis, [NativeTypeName("DXGI_SWAP_CHAIN_DESC *")] DXGI_SWAP_CHAIN_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ResizeBuffers(IDXGISwapChain2* pThis, [NativeTypeName("UINT")] uint BufferCount, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, DXGI_FORMAT NewFormat, [NativeTypeName("UINT")] uint SwapChainFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ResizeTarget(IDXGISwapChain2* pThis, [NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pNewTargetParameters);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainingOutput(IDXGISwapChain2* pThis, [NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppOutput);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameStatistics(IDXGISwapChain2* pThis, [NativeTypeName("DXGI_FRAME_STATISTICS *")] DXGI_FRAME_STATISTICS* pStats);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLastPresentCount(IDXGISwapChain2* pThis, [NativeTypeName("UINT *")] uint* pLastPresentCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc1(IDXGISwapChain2* pThis, [NativeTypeName("DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFullscreenDesc(IDXGISwapChain2* pThis, [NativeTypeName("DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetHwnd(IDXGISwapChain2* pThis, [NativeTypeName("HWND *")] IntPtr* pHwnd);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCoreWindow(IDXGISwapChain2* pThis, [NativeTypeName("const IID &")] Guid* refiid, [NativeTypeName("void **")] void** ppUnk);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Present1(IDXGISwapChain2* pThis, [NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint PresentFlags, [NativeTypeName("const DXGI_PRESENT_PARAMETERS *")] DXGI_PRESENT_PARAMETERS* pPresentParameters);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsTemporaryMonoSupported(IDXGISwapChain2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRestrictToOutput(IDXGISwapChain2* pThis, [NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppRestrictToOutput);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBackgroundColor(IDXGISwapChain2* pThis, [NativeTypeName("const DXGI_RGBA *")] DXGI_RGBA* pColor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBackgroundColor(IDXGISwapChain2* pThis, [NativeTypeName("DXGI_RGBA *")] DXGI_RGBA* pColor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRotation(IDXGISwapChain2* pThis, DXGI_MODE_ROTATION Rotation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRotation(IDXGISwapChain2* pThis, [NativeTypeName("DXGI_MODE_ROTATION *")] DXGI_MODE_ROTATION* pRotation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSourceSize(IDXGISwapChain2* pThis, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSourceSize(IDXGISwapChain2* pThis, [NativeTypeName("UINT *")] uint* pWidth, [NativeTypeName("UINT *")] uint* pHeight);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMaximumFrameLatency(IDXGISwapChain2* pThis, [NativeTypeName("UINT")] uint MaxLatency);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMaximumFrameLatency(IDXGISwapChain2* pThis, [NativeTypeName("UINT *")] uint* pMaxLatency);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HANDLE")]
        public delegate IntPtr _GetFrameLatencyWaitableObject(IDXGISwapChain2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMatrixTransform(IDXGISwapChain2* pThis, [NativeTypeName("const DXGI_MATRIX_3X2_F *")] DXGI_MATRIX_3X2_F* pMatrix);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMatrixTransform(IDXGISwapChain2* pThis, [NativeTypeName("DXGI_MATRIX_3X2_F *")] DXGI_MATRIX_3X2_F* pMatrix);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDXGISwapChain2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDXGISwapChain2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppDevice)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), riid, ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int Present([NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_Present>(lpVtbl->Present)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), SyncInterval, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("UINT")] uint Buffer, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppSurface)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBuffer>(lpVtbl->GetBuffer)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), Buffer, riid, ppSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFullscreenState([NativeTypeName("BOOL")] int Fullscreen, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pTarget)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFullscreenState>(lpVtbl->SetFullscreenState)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), Fullscreen, pTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFullscreenState([NativeTypeName("BOOL *")] int* pFullscreen, [NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppTarget)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFullscreenState>(lpVtbl->GetFullscreenState)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), pFullscreen, ppTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("DXGI_SWAP_CHAIN_DESC *")] DXGI_SWAP_CHAIN_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeBuffers([NativeTypeName("UINT")] uint BufferCount, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, DXGI_FORMAT NewFormat, [NativeTypeName("UINT")] uint SwapChainFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_ResizeBuffers>(lpVtbl->ResizeBuffers)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, NewFormat, SwapChainFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeTarget([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pNewTargetParameters)
        {
            return Marshal.GetDelegateForFunctionPointer<_ResizeTarget>(lpVtbl->ResizeTarget)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), pNewTargetParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainingOutput([NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppOutput)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetContainingOutput>(lpVtbl->GetContainingOutput)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), ppOutput);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics([NativeTypeName("DXGI_FRAME_STATISTICS *")] DXGI_FRAME_STATISTICS* pStats)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFrameStatistics>(lpVtbl->GetFrameStatistics)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), pStats);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastPresentCount([NativeTypeName("UINT *")] uint* pLastPresentCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLastPresentCount>(lpVtbl->GetLastPresentCount)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), pLastPresentCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc1([NativeTypeName("DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc1>(lpVtbl->GetDesc1)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFullscreenDesc([NativeTypeName("DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFullscreenDesc>(lpVtbl->GetFullscreenDesc)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHwnd([NativeTypeName("HWND *")] IntPtr* pHwnd)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetHwnd>(lpVtbl->GetHwnd)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), pHwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCoreWindow([NativeTypeName("const IID &")] Guid* refiid, [NativeTypeName("void **")] void** ppUnk)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCoreWindow>(lpVtbl->GetCoreWindow)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), refiid, ppUnk);
        }

        [return: NativeTypeName("HRESULT")]
        public int Present1([NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint PresentFlags, [NativeTypeName("const DXGI_PRESENT_PARAMETERS *")] DXGI_PRESENT_PARAMETERS* pPresentParameters)
        {
            return Marshal.GetDelegateForFunctionPointer<_Present1>(lpVtbl->Present1)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), SyncInterval, PresentFlags, pPresentParameters);
        }

        [return: NativeTypeName("BOOL")]
        public int IsTemporaryMonoSupported()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsTemporaryMonoSupported>(lpVtbl->IsTemporaryMonoSupported)((IDXGISwapChain2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRestrictToOutput([NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppRestrictToOutput)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRestrictToOutput>(lpVtbl->GetRestrictToOutput)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), ppRestrictToOutput);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBackgroundColor([NativeTypeName("const DXGI_RGBA *")] DXGI_RGBA* pColor)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBackgroundColor>(lpVtbl->SetBackgroundColor)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), pColor);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBackgroundColor([NativeTypeName("DXGI_RGBA *")] DXGI_RGBA* pColor)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBackgroundColor>(lpVtbl->GetBackgroundColor)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), pColor);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRotation(DXGI_MODE_ROTATION Rotation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRotation>(lpVtbl->SetRotation)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), Rotation);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRotation([NativeTypeName("DXGI_MODE_ROTATION *")] DXGI_MODE_ROTATION* pRotation)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRotation>(lpVtbl->GetRotation)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), pRotation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSourceSize([NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSourceSize>(lpVtbl->SetSourceSize)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), Width, Height);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSourceSize([NativeTypeName("UINT *")] uint* pWidth, [NativeTypeName("UINT *")] uint* pHeight)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSourceSize>(lpVtbl->GetSourceSize)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), pWidth, pHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMaximumFrameLatency([NativeTypeName("UINT")] uint MaxLatency)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMaximumFrameLatency>(lpVtbl->SetMaximumFrameLatency)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), MaxLatency);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaximumFrameLatency([NativeTypeName("UINT *")] uint* pMaxLatency)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMaximumFrameLatency>(lpVtbl->GetMaximumFrameLatency)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), pMaxLatency);
        }

        [return: NativeTypeName("HANDLE")]
        public IntPtr GetFrameLatencyWaitableObject()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFrameLatencyWaitableObject>(lpVtbl->GetFrameLatencyWaitableObject)((IDXGISwapChain2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrixTransform([NativeTypeName("const DXGI_MATRIX_3X2_F *")] DXGI_MATRIX_3X2_F* pMatrix)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMatrixTransform>(lpVtbl->SetMatrixTransform)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), pMatrix);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatrixTransform([NativeTypeName("DXGI_MATRIX_3X2_F *")] DXGI_MATRIX_3X2_F* pMatrix)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMatrixTransform>(lpVtbl->GetMatrixTransform)((IDXGISwapChain2*)Unsafe.AsPointer(ref this), pMatrix);
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

            [NativeTypeName("HRESULT (DXGI_SWAP_CHAIN_DESC1 *) __attribute__((stdcall))")]
            public IntPtr GetDesc1;

            [NativeTypeName("HRESULT (DXGI_SWAP_CHAIN_FULLSCREEN_DESC *) __attribute__((stdcall))")]
            public IntPtr GetFullscreenDesc;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public IntPtr GetHwnd;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetCoreWindow;

            [NativeTypeName("HRESULT (UINT, UINT, const DXGI_PRESENT_PARAMETERS *) __attribute__((stdcall))")]
            public IntPtr Present1;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public IntPtr IsTemporaryMonoSupported;

            [NativeTypeName("HRESULT (IDXGIOutput **) __attribute__((stdcall))")]
            public IntPtr GetRestrictToOutput;

            [NativeTypeName("HRESULT (const DXGI_RGBA *) __attribute__((stdcall))")]
            public IntPtr SetBackgroundColor;

            [NativeTypeName("HRESULT (DXGI_RGBA *) __attribute__((stdcall))")]
            public IntPtr GetBackgroundColor;

            [NativeTypeName("HRESULT (DXGI_MODE_ROTATION) __attribute__((stdcall))")]
            public IntPtr SetRotation;

            [NativeTypeName("HRESULT (DXGI_MODE_ROTATION *) __attribute__((stdcall))")]
            public IntPtr GetRotation;

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
            public IntPtr SetSourceSize;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetSourceSize;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr SetMaximumFrameLatency;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public IntPtr GetMaximumFrameLatency;

            [NativeTypeName("HANDLE () __attribute__((stdcall))")]
            public IntPtr GetFrameLatencyWaitableObject;

            [NativeTypeName("HRESULT (const DXGI_MATRIX_3X2_F *) __attribute__((stdcall))")]
            public IntPtr SetMatrixTransform;

            [NativeTypeName("HRESULT (DXGI_MATRIX_3X2_F *) __attribute__((stdcall))")]
            public IntPtr GetMatrixTransform;
        }
    }
}
