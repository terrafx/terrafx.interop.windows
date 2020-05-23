// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DD95B90B-F05F-4F6A-BD65-25BFB264BD84")]
    public unsafe partial struct IDXGISwapChainMedia
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGISwapChainMedia* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGISwapChainMedia* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGISwapChainMedia* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameStatisticsMedia(IDXGISwapChainMedia* pThis, [NativeTypeName("DXGI_FRAME_STATISTICS_MEDIA *")] DXGI_FRAME_STATISTICS_MEDIA* pStats);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPresentDuration(IDXGISwapChainMedia* pThis, [NativeTypeName("UINT")] uint Duration);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckPresentDurationSupport(IDXGISwapChainMedia* pThis, [NativeTypeName("UINT")] uint DesiredPresentDuration, [NativeTypeName("UINT *")] uint* pClosestSmallerPresentDuration, [NativeTypeName("UINT *")] uint* pClosestLargerPresentDuration);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatisticsMedia([NativeTypeName("DXGI_FRAME_STATISTICS_MEDIA *")] DXGI_FRAME_STATISTICS_MEDIA* pStats)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFrameStatisticsMedia>(lpVtbl->GetFrameStatisticsMedia)((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), pStats);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPresentDuration([NativeTypeName("UINT")] uint Duration)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPresentDuration>(lpVtbl->SetPresentDuration)((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), Duration);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckPresentDurationSupport([NativeTypeName("UINT")] uint DesiredPresentDuration, [NativeTypeName("UINT *")] uint* pClosestSmallerPresentDuration, [NativeTypeName("UINT *")] uint* pClosestLargerPresentDuration)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckPresentDurationSupport>(lpVtbl->CheckPresentDurationSupport)((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), DesiredPresentDuration, pClosestSmallerPresentDuration, pClosestLargerPresentDuration);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DXGI_FRAME_STATISTICS_MEDIA *) __attribute__((stdcall))")]
            public IntPtr GetFrameStatisticsMedia;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr SetPresentDuration;

            [NativeTypeName("HRESULT (UINT, UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr CheckPresentDurationSupport;
        }
    }
}
