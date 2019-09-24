// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("DD95B90B-F05F-4F6A-BD65-25BFB264BD84")]
    public unsafe struct IDXGISwapChainMedia
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDXGISwapChainMedia* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDXGISwapChainMedia* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDXGISwapChainMedia* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFrameStatisticsMedia(
            [In] IDXGISwapChainMedia* This,
            [Out] DXGI_FRAME_STATISTICS_MEDIA* pStats
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPresentDuration(
            [In] IDXGISwapChainMedia* This,
            [In, NativeTypeName("UINT")] uint Duration
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CheckPresentDurationSupport(
            [In] IDXGISwapChainMedia* This,
            [In, NativeTypeName("UINT")] uint DesiredPresentDuration,
            [Out, NativeTypeName("UINT")] uint* pClosestSmallerPresentDuration,
            [Out, NativeTypeName("UINT")] uint* pClosestLargerPresentDuration
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDXGISwapChainMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGISwapChainMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGISwapChainMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatisticsMedia(
            [Out] DXGI_FRAME_STATISTICS_MEDIA* pStats
        )
        {
            fixed (IDXGISwapChainMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFrameStatisticsMedia>(lpVtbl->GetFrameStatisticsMedia)(
                    This,
                    pStats
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPresentDuration(
            [In, NativeTypeName("UINT")] uint Duration
        )
        {
            fixed (IDXGISwapChainMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPresentDuration>(lpVtbl->SetPresentDuration)(
                    This,
                    Duration
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckPresentDurationSupport(
            [In, NativeTypeName("UINT")] uint DesiredPresentDuration,
            [Out, NativeTypeName("UINT")] uint* pClosestSmallerPresentDuration,
            [Out, NativeTypeName("UINT")] uint* pClosestLargerPresentDuration
        )
        {
            fixed (IDXGISwapChainMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CheckPresentDurationSupport>(lpVtbl->CheckPresentDurationSupport)(
                    This,
                    DesiredPresentDuration,
                    pClosestSmallerPresentDuration,
                    pClosestLargerPresentDuration
                );
            }
        }

        public struct Vtbl
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
