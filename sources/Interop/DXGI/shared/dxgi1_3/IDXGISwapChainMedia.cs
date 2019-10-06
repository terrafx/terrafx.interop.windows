// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DD95B90B-F05F-4F6A-BD65-25BFB264BD84")]
    public unsafe partial struct IDXGISwapChainMedia
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGISwapChainMedia* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGISwapChainMedia* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGISwapChainMedia* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameStatisticsMedia(IDXGISwapChainMedia* This, DXGI_FRAME_STATISTICS_MEDIA* pStats);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPresentDuration(IDXGISwapChainMedia* This, [NativeTypeName("UINT")] uint Duration);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckPresentDurationSupport(IDXGISwapChainMedia* This, [NativeTypeName("UINT")] uint DesiredPresentDuration, [NativeTypeName("UINT")] uint* pClosestSmallerPresentDuration, [NativeTypeName("UINT")] uint* pClosestLargerPresentDuration);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDXGISwapChainMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGISwapChainMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGISwapChainMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatisticsMedia(DXGI_FRAME_STATISTICS_MEDIA* pStats)
        {
            fixed (IDXGISwapChainMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFrameStatisticsMedia>(lpVtbl->GetFrameStatisticsMedia)(This, pStats);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPresentDuration([NativeTypeName("UINT")] uint Duration)
        {
            fixed (IDXGISwapChainMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPresentDuration>(lpVtbl->SetPresentDuration)(This, Duration);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckPresentDurationSupport([NativeTypeName("UINT")] uint DesiredPresentDuration, [NativeTypeName("UINT")] uint* pClosestSmallerPresentDuration, [NativeTypeName("UINT")] uint* pClosestLargerPresentDuration)
        {
            fixed (IDXGISwapChainMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CheckPresentDurationSupport>(lpVtbl->CheckPresentDurationSupport)(This, DesiredPresentDuration, pClosestSmallerPresentDuration, pClosestLargerPresentDuration);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFrameStatisticsMedia;

            public IntPtr SetPresentDuration;

            public IntPtr CheckPresentDurationSupport;
        }
    }
}
