// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("310D36A0-D2E7-4C0A-AA04-6A9D23B8886A")]
    public unsafe struct IDXGISwapChain
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGISwapChain* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGISwapChain* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGISwapChain* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDXGISwapChain* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDXGISwapChain* This, [NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDXGISwapChain* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(IDXGISwapChain* This, [NativeTypeName("REFIID")] Guid* riid, void** ppParent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(IDXGISwapChain* This, [NativeTypeName("REFIID")] Guid* riid, void** ppDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Present(IDXGISwapChain* This, [NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBuffer(IDXGISwapChain* This, [NativeTypeName("UINT")] uint Buffer, [NativeTypeName("REFIID")] Guid* riid, void** ppSurface);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFullscreenState(IDXGISwapChain* This, [NativeTypeName("BOOL")] int Fullscreen, IDXGIOutput* pTarget = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFullscreenState(IDXGISwapChain* This, [NativeTypeName("BOOL")] int* pFullscreen = null, IDXGIOutput** ppTarget = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(IDXGISwapChain* This, DXGI_SWAP_CHAIN_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ResizeBuffers(IDXGISwapChain* This, [NativeTypeName("UINT")] uint BufferCount, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, DXGI_FORMAT NewFormat, [NativeTypeName("UINT")] uint SwapChainFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ResizeTarget(IDXGISwapChain* This, DXGI_MODE_DESC* pNewTargetParameters);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainingOutput(IDXGISwapChain* This, IDXGIOutput** ppOutput);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameStatistics(IDXGISwapChain* This, DXGI_FRAME_STATISTICS* pStats);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLastPresentCount(IDXGISwapChain* This, [NativeTypeName("UINT")] uint* pLastPresentCount);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData)
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(This, Name, DataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null)
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(This, Name, pUnknown);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData)
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(This, Name, pDataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("REFIID")] Guid* riid, void** ppParent)
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(This, riid, ppParent);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("REFIID")] Guid* riid, void** ppDevice)
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)(This, riid, ppDevice);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Present([NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags)
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Present>(lpVtbl->Present)(This, SyncInterval, Flags);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("UINT")] uint Buffer, [NativeTypeName("REFIID")] Guid* riid, void** ppSurface)
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBuffer>(lpVtbl->GetBuffer)(This, Buffer, riid, ppSurface);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFullscreenState([NativeTypeName("BOOL")] int Fullscreen, IDXGIOutput* pTarget = null)
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFullscreenState>(lpVtbl->SetFullscreenState)(This, Fullscreen, pTarget);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFullscreenState([NativeTypeName("BOOL")] int* pFullscreen = null, IDXGIOutput** ppTarget = null)
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFullscreenState>(lpVtbl->GetFullscreenState)(This, pFullscreen, ppTarget);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc(DXGI_SWAP_CHAIN_DESC* pDesc)
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(This, pDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeBuffers([NativeTypeName("UINT")] uint BufferCount, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, DXGI_FORMAT NewFormat, [NativeTypeName("UINT")] uint SwapChainFlags)
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ResizeBuffers>(lpVtbl->ResizeBuffers)(This, BufferCount, Width, Height, NewFormat, SwapChainFlags);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeTarget(DXGI_MODE_DESC* pNewTargetParameters)
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ResizeTarget>(lpVtbl->ResizeTarget)(This, pNewTargetParameters);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainingOutput(IDXGIOutput** ppOutput)
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContainingOutput>(lpVtbl->GetContainingOutput)(This, ppOutput);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats)
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFrameStatistics>(lpVtbl->GetFrameStatistics)(This, pStats);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastPresentCount([NativeTypeName("UINT")] uint* pLastPresentCount)
        {
            fixed (IDXGISwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLastPresentCount>(lpVtbl->GetLastPresentCount)(This, pLastPresentCount);
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
        }
    }
}
