// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("790A45F7-0D42-4876-983A-0A55CFE6F4AA")]
    public unsafe partial struct IDXGISwapChain1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGISwapChain1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGISwapChain1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGISwapChain1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDXGISwapChain1* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDXGISwapChain1* This, [NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDXGISwapChain1* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(IDXGISwapChain1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppParent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(IDXGISwapChain1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Present(IDXGISwapChain1* This, [NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBuffer(IDXGISwapChain1* This, [NativeTypeName("UINT")] uint Buffer, [NativeTypeName("REFIID")] Guid* riid, void** ppSurface);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFullscreenState(IDXGISwapChain1* This, [NativeTypeName("BOOL")] int Fullscreen, IDXGIOutput* pTarget = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFullscreenState(IDXGISwapChain1* This, [NativeTypeName("BOOL")] int* pFullscreen = null, IDXGIOutput** ppTarget = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(IDXGISwapChain1* This, DXGI_SWAP_CHAIN_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ResizeBuffers(IDXGISwapChain1* This, [NativeTypeName("UINT")] uint BufferCount, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, DXGI_FORMAT NewFormat, [NativeTypeName("UINT")] uint SwapChainFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ResizeTarget(IDXGISwapChain1* This, DXGI_MODE_DESC* pNewTargetParameters);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainingOutput(IDXGISwapChain1* This, IDXGIOutput** ppOutput);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameStatistics(IDXGISwapChain1* This, DXGI_FRAME_STATISTICS* pStats);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLastPresentCount(IDXGISwapChain1* This, [NativeTypeName("UINT")] uint* pLastPresentCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc1(IDXGISwapChain1* This, DXGI_SWAP_CHAIN_DESC1* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFullscreenDesc(IDXGISwapChain1* This, DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetHwnd(IDXGISwapChain1* This, [NativeTypeName("HWND")] IntPtr* pHwnd);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCoreWindow(IDXGISwapChain1* This, [NativeTypeName("REFIID")] Guid* refiid, void** ppUnk);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Present1(IDXGISwapChain1* This, [NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint PresentFlags, DXGI_PRESENT_PARAMETERS* pPresentParameters);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsTemporaryMonoSupported(IDXGISwapChain1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRestrictToOutput(IDXGISwapChain1* This, IDXGIOutput** ppRestrictToOutput);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBackgroundColor(IDXGISwapChain1* This, DXGI_RGBA* pColor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBackgroundColor(IDXGISwapChain1* This, DXGI_RGBA* pColor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRotation(IDXGISwapChain1* This, DXGI_MODE_ROTATION Rotation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRotation(IDXGISwapChain1* This, DXGI_MODE_ROTATION* pRotation);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(This, Name, DataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(This, Name, pUnknown);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(This, Name, pDataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("REFIID")] Guid* riid, void** ppParent)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(This, riid, ppParent);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("REFIID")] Guid* riid, void** ppDevice)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)(This, riid, ppDevice);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Present([NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Present>(lpVtbl->Present)(This, SyncInterval, Flags);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("UINT")] uint Buffer, [NativeTypeName("REFIID")] Guid* riid, void** ppSurface)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBuffer>(lpVtbl->GetBuffer)(This, Buffer, riid, ppSurface);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFullscreenState([NativeTypeName("BOOL")] int Fullscreen, IDXGIOutput* pTarget = null)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFullscreenState>(lpVtbl->SetFullscreenState)(This, Fullscreen, pTarget);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFullscreenState([NativeTypeName("BOOL")] int* pFullscreen = null, IDXGIOutput** ppTarget = null)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFullscreenState>(lpVtbl->GetFullscreenState)(This, pFullscreen, ppTarget);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc(DXGI_SWAP_CHAIN_DESC* pDesc)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(This, pDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeBuffers([NativeTypeName("UINT")] uint BufferCount, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, DXGI_FORMAT NewFormat, [NativeTypeName("UINT")] uint SwapChainFlags)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ResizeBuffers>(lpVtbl->ResizeBuffers)(This, BufferCount, Width, Height, NewFormat, SwapChainFlags);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeTarget(DXGI_MODE_DESC* pNewTargetParameters)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ResizeTarget>(lpVtbl->ResizeTarget)(This, pNewTargetParameters);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainingOutput(IDXGIOutput** ppOutput)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContainingOutput>(lpVtbl->GetContainingOutput)(This, ppOutput);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFrameStatistics>(lpVtbl->GetFrameStatistics)(This, pStats);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastPresentCount([NativeTypeName("UINT")] uint* pLastPresentCount)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLastPresentCount>(lpVtbl->GetLastPresentCount)(This, pLastPresentCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc1(DXGI_SWAP_CHAIN_DESC1* pDesc)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc1>(lpVtbl->GetDesc1)(This, pDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFullscreenDesc(DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFullscreenDesc>(lpVtbl->GetFullscreenDesc)(This, pDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHwnd([NativeTypeName("HWND")] IntPtr* pHwnd)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetHwnd>(lpVtbl->GetHwnd)(This, pHwnd);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCoreWindow([NativeTypeName("REFIID")] Guid* refiid, void** ppUnk)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCoreWindow>(lpVtbl->GetCoreWindow)(This, refiid, ppUnk);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Present1([NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint PresentFlags, DXGI_PRESENT_PARAMETERS* pPresentParameters)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Present1>(lpVtbl->Present1)(This, SyncInterval, PresentFlags, pPresentParameters);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsTemporaryMonoSupported()
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsTemporaryMonoSupported>(lpVtbl->IsTemporaryMonoSupported)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRestrictToOutput(IDXGIOutput** ppRestrictToOutput)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRestrictToOutput>(lpVtbl->GetRestrictToOutput)(This, ppRestrictToOutput);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBackgroundColor(DXGI_RGBA* pColor)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetBackgroundColor>(lpVtbl->SetBackgroundColor)(This, pColor);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBackgroundColor(DXGI_RGBA* pColor)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBackgroundColor>(lpVtbl->GetBackgroundColor)(This, pColor);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRotation(DXGI_MODE_ROTATION Rotation)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetRotation>(lpVtbl->SetRotation)(This, Rotation);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRotation(DXGI_MODE_ROTATION* pRotation)
        {
            fixed (IDXGISwapChain1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRotation>(lpVtbl->GetRotation)(This, pRotation);
            }
        }

        public partial struct Vtbl
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
        }
    }
}
