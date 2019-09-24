// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_5.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D585D5A-BD4A-489E-B1F4-3DBCB6452FFB")]
    public unsafe struct IDXGISwapChain4
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGISwapChain4* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGISwapChain4* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGISwapChain4* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDXGISwapChain4* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDXGISwapChain4* This, [NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDXGISwapChain4* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(IDXGISwapChain4* This, [NativeTypeName("REFIID")] Guid* riid, void** ppParent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(IDXGISwapChain4* This, [NativeTypeName("REFIID")] Guid* riid, void** ppDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Present(IDXGISwapChain4* This, [NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBuffer(IDXGISwapChain4* This, [NativeTypeName("UINT")] uint Buffer, [NativeTypeName("REFIID")] Guid* riid, void** ppSurface);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFullscreenState(IDXGISwapChain4* This, [NativeTypeName("BOOL")] int Fullscreen, IDXGIOutput* pTarget = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFullscreenState(IDXGISwapChain4* This, [NativeTypeName("BOOL")] int* pFullscreen = null, IDXGIOutput** ppTarget = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(IDXGISwapChain4* This, DXGI_SWAP_CHAIN_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ResizeBuffers(IDXGISwapChain4* This, [NativeTypeName("UINT")] uint BufferCount, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, DXGI_FORMAT NewFormat, [NativeTypeName("UINT")] uint SwapChainFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ResizeTarget(IDXGISwapChain4* This, DXGI_MODE_DESC* pNewTargetParameters);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainingOutput(IDXGISwapChain4* This, IDXGIOutput** ppOutput);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameStatistics(IDXGISwapChain4* This, DXGI_FRAME_STATISTICS* pStats);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLastPresentCount(IDXGISwapChain4* This, [NativeTypeName("UINT")] uint* pLastPresentCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc1(IDXGISwapChain4* This, DXGI_SWAP_CHAIN_DESC1* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFullscreenDesc(IDXGISwapChain4* This, DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetHwnd(IDXGISwapChain4* This, [NativeTypeName("HWND")] IntPtr* pHwnd);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCoreWindow(IDXGISwapChain4* This, [NativeTypeName("REFIID")] Guid* refiid, void** ppUnk);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Present1(IDXGISwapChain4* This, [NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint PresentFlags, DXGI_PRESENT_PARAMETERS* pPresentParameters);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsTemporaryMonoSupported(IDXGISwapChain4* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRestrictToOutput(IDXGISwapChain4* This, IDXGIOutput** ppRestrictToOutput);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBackgroundColor(IDXGISwapChain4* This, DXGI_RGBA* pColor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBackgroundColor(IDXGISwapChain4* This, DXGI_RGBA* pColor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRotation(IDXGISwapChain4* This, DXGI_MODE_ROTATION Rotation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRotation(IDXGISwapChain4* This, DXGI_MODE_ROTATION* pRotation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSourceSize(IDXGISwapChain4* This, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSourceSize(IDXGISwapChain4* This, [NativeTypeName("UINT")] uint* pWidth, [NativeTypeName("UINT")] uint* pHeight);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMaximumFrameLatency(IDXGISwapChain4* This, [NativeTypeName("UINT")] uint MaxLatency);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMaximumFrameLatency(IDXGISwapChain4* This, [NativeTypeName("UINT")] uint* pMaxLatency);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HANDLE")]
        public delegate IntPtr _GetFrameLatencyWaitableObject(IDXGISwapChain4* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMatrixTransform(IDXGISwapChain4* This, DXGI_MATRIX_3X2_F* pMatrix);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMatrixTransform(IDXGISwapChain4* This, DXGI_MATRIX_3X2_F* pMatrix);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetCurrentBackBufferIndex(IDXGISwapChain4* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckColorSpaceSupport(IDXGISwapChain4* This, DXGI_COLOR_SPACE_TYPE ColorSpace, [NativeTypeName("UINT")] uint* pColorSpaceSupport);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetColorSpace1(IDXGISwapChain4* This, DXGI_COLOR_SPACE_TYPE ColorSpace);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ResizeBuffers1(IDXGISwapChain4* This, [NativeTypeName("UINT")] uint BufferCount, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, DXGI_FORMAT Format, [NativeTypeName("UINT")] uint SwapChainFlags, [NativeTypeName("UINT[]")] uint* pCreationNodeMask, [NativeTypeName("IUnknown*[]")] IUnknown** ppPresentQueue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetHDRMetaData(IDXGISwapChain4* This, DXGI_HDR_METADATA_TYPE Type, [NativeTypeName("UINT")] uint Size, void* pMetaData = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(This, Name, DataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(This, Name, pUnknown);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(This, Name, pDataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("REFIID")] Guid* riid, void** ppParent)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(This, riid, ppParent);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("REFIID")] Guid* riid, void** ppDevice)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)(This, riid, ppDevice);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Present([NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Present>(lpVtbl->Present)(This, SyncInterval, Flags);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("UINT")] uint Buffer, [NativeTypeName("REFIID")] Guid* riid, void** ppSurface)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBuffer>(lpVtbl->GetBuffer)(This, Buffer, riid, ppSurface);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFullscreenState([NativeTypeName("BOOL")] int Fullscreen, IDXGIOutput* pTarget = null)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFullscreenState>(lpVtbl->SetFullscreenState)(This, Fullscreen, pTarget);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFullscreenState([NativeTypeName("BOOL")] int* pFullscreen = null, IDXGIOutput** ppTarget = null)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFullscreenState>(lpVtbl->GetFullscreenState)(This, pFullscreen, ppTarget);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc(DXGI_SWAP_CHAIN_DESC* pDesc)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(This, pDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeBuffers([NativeTypeName("UINT")] uint BufferCount, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, DXGI_FORMAT NewFormat, [NativeTypeName("UINT")] uint SwapChainFlags)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ResizeBuffers>(lpVtbl->ResizeBuffers)(This, BufferCount, Width, Height, NewFormat, SwapChainFlags);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeTarget(DXGI_MODE_DESC* pNewTargetParameters)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ResizeTarget>(lpVtbl->ResizeTarget)(This, pNewTargetParameters);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainingOutput(IDXGIOutput** ppOutput)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContainingOutput>(lpVtbl->GetContainingOutput)(This, ppOutput);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFrameStatistics>(lpVtbl->GetFrameStatistics)(This, pStats);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastPresentCount([NativeTypeName("UINT")] uint* pLastPresentCount)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLastPresentCount>(lpVtbl->GetLastPresentCount)(This, pLastPresentCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc1(DXGI_SWAP_CHAIN_DESC1* pDesc)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc1>(lpVtbl->GetDesc1)(This, pDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFullscreenDesc(DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFullscreenDesc>(lpVtbl->GetFullscreenDesc)(This, pDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHwnd([NativeTypeName("HWND")] IntPtr* pHwnd)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetHwnd>(lpVtbl->GetHwnd)(This, pHwnd);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCoreWindow([NativeTypeName("REFIID")] Guid* refiid, void** ppUnk)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCoreWindow>(lpVtbl->GetCoreWindow)(This, refiid, ppUnk);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Present1([NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint PresentFlags, DXGI_PRESENT_PARAMETERS* pPresentParameters)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Present1>(lpVtbl->Present1)(This, SyncInterval, PresentFlags, pPresentParameters);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsTemporaryMonoSupported()
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsTemporaryMonoSupported>(lpVtbl->IsTemporaryMonoSupported)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRestrictToOutput(IDXGIOutput** ppRestrictToOutput)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRestrictToOutput>(lpVtbl->GetRestrictToOutput)(This, ppRestrictToOutput);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBackgroundColor(DXGI_RGBA* pColor)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetBackgroundColor>(lpVtbl->SetBackgroundColor)(This, pColor);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBackgroundColor(DXGI_RGBA* pColor)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBackgroundColor>(lpVtbl->GetBackgroundColor)(This, pColor);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRotation(DXGI_MODE_ROTATION Rotation)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetRotation>(lpVtbl->SetRotation)(This, Rotation);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRotation(DXGI_MODE_ROTATION* pRotation)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRotation>(lpVtbl->GetRotation)(This, pRotation);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSourceSize([NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetSourceSize>(lpVtbl->SetSourceSize)(This, Width, Height);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSourceSize([NativeTypeName("UINT")] uint* pWidth, [NativeTypeName("UINT")] uint* pHeight)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSourceSize>(lpVtbl->GetSourceSize)(This, pWidth, pHeight);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMaximumFrameLatency([NativeTypeName("UINT")] uint MaxLatency)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetMaximumFrameLatency>(lpVtbl->SetMaximumFrameLatency)(This, MaxLatency);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaximumFrameLatency([NativeTypeName("UINT")] uint* pMaxLatency)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMaximumFrameLatency>(lpVtbl->GetMaximumFrameLatency)(This, pMaxLatency);
            }
        }

        [return: NativeTypeName("HANDLE")]
        public IntPtr GetFrameLatencyWaitableObject()
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFrameLatencyWaitableObject>(lpVtbl->GetFrameLatencyWaitableObject)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrixTransform(DXGI_MATRIX_3X2_F* pMatrix)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetMatrixTransform>(lpVtbl->SetMatrixTransform)(This, pMatrix);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatrixTransform(DXGI_MATRIX_3X2_F* pMatrix)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMatrixTransform>(lpVtbl->GetMatrixTransform)(This, pMatrix);
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetCurrentBackBufferIndex()
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCurrentBackBufferIndex>(lpVtbl->GetCurrentBackBufferIndex)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckColorSpaceSupport(DXGI_COLOR_SPACE_TYPE ColorSpace, [NativeTypeName("UINT")] uint* pColorSpaceSupport)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CheckColorSpaceSupport>(lpVtbl->CheckColorSpaceSupport)(This, ColorSpace, pColorSpaceSupport);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorSpace1(DXGI_COLOR_SPACE_TYPE ColorSpace)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetColorSpace1>(lpVtbl->SetColorSpace1)(This, ColorSpace);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeBuffers1([NativeTypeName("UINT")] uint BufferCount, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, DXGI_FORMAT Format, [NativeTypeName("UINT")] uint SwapChainFlags, [NativeTypeName("UINT[]")] uint* pCreationNodeMask, [NativeTypeName("IUnknown*[]")] IUnknown** ppPresentQueue)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ResizeBuffers1>(lpVtbl->ResizeBuffers1)(This, BufferCount, Width, Height, Format, SwapChainFlags, pCreationNodeMask, ppPresentQueue);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHDRMetaData(DXGI_HDR_METADATA_TYPE Type, [NativeTypeName("UINT")] uint Size, void* pMetaData = null)
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetHDRMetaData>(lpVtbl->SetHDRMetaData)(This, Type, Size, pMetaData);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetPrivateData;

            public IntPtr SetPrivateDataInterface;

            public IntPtr GetPrivateData;

            public IntPtr GetParent;

            public IntPtr GetDevice;

            public IntPtr Present;

            public IntPtr GetBuffer;

            public IntPtr SetFullscreenState;

            public IntPtr GetFullscreenState;

            public IntPtr GetDesc;

            public IntPtr ResizeBuffers;

            public IntPtr ResizeTarget;

            public IntPtr GetContainingOutput;

            public IntPtr GetFrameStatistics;

            public IntPtr GetLastPresentCount;

            public IntPtr GetDesc1;

            public IntPtr GetFullscreenDesc;

            public IntPtr GetHwnd;

            public IntPtr GetCoreWindow;

            public IntPtr Present1;

            public IntPtr IsTemporaryMonoSupported;

            public IntPtr GetRestrictToOutput;

            public IntPtr SetBackgroundColor;

            public IntPtr GetBackgroundColor;

            public IntPtr SetRotation;

            public IntPtr GetRotation;

            public IntPtr SetSourceSize;

            public IntPtr GetSourceSize;

            public IntPtr SetMaximumFrameLatency;

            public IntPtr GetMaximumFrameLatency;

            public IntPtr GetFrameLatencyWaitableObject;

            public IntPtr SetMatrixTransform;

            public IntPtr GetMatrixTransform;

            public IntPtr GetCurrentBackBufferIndex;

            public IntPtr CheckColorSpaceSupport;

            public IntPtr SetColorSpace1;

            public IntPtr ResizeBuffers1;

            public IntPtr SetHDRMetaData;
        }
    }
}
