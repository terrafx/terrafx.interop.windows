// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.1")]
    [Guid("DD95B90B-F05F-4F6A-BD65-25BFB264BD84")]
    [NativeTypeName("struct IDXGISwapChainMedia : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDXGISwapChainMedia : IDXGISwapChainMedia.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGISwapChainMedia*, Guid*, void**, int>)(lpVtbl[0]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGISwapChainMedia*, uint>)(lpVtbl[1]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGISwapChainMedia*, uint>)(lpVtbl[2]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetFrameStatisticsMedia(DXGI_FRAME_STATISTICS_MEDIA* pStats)
        {
            return ((delegate* unmanaged<IDXGISwapChainMedia*, DXGI_FRAME_STATISTICS_MEDIA*, int>)(lpVtbl[3]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), pStats);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPresentDuration(uint Duration)
        {
            return ((delegate* unmanaged<IDXGISwapChainMedia*, uint, int>)(lpVtbl[4]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), Duration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CheckPresentDurationSupport(uint DesiredPresentDuration, uint* pClosestSmallerPresentDuration, uint* pClosestLargerPresentDuration)
        {
            return ((delegate* unmanaged<IDXGISwapChainMedia*, uint, uint*, uint*, int>)(lpVtbl[5]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), DesiredPresentDuration, pClosestSmallerPresentDuration, pClosestLargerPresentDuration);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetFrameStatisticsMedia(DXGI_FRAME_STATISTICS_MEDIA* pStats);

            [VtblIndex(4)]
            HRESULT SetPresentDuration(uint Duration);

            [VtblIndex(5)]
            HRESULT CheckPresentDurationSupport(uint DesiredPresentDuration, uint* pClosestSmallerPresentDuration, uint* pClosestLargerPresentDuration);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGISwapChainMedia*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGISwapChainMedia*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGISwapChainMedia*, uint> Release;

            [NativeTypeName("HRESULT (DXGI_FRAME_STATISTICS_MEDIA *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGISwapChainMedia*, DXGI_FRAME_STATISTICS_MEDIA*, int> GetFrameStatisticsMedia;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGISwapChainMedia*, uint, int> SetPresentDuration;

            [NativeTypeName("HRESULT (UINT, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGISwapChainMedia*, uint, uint*, uint*, int> CheckPresentDurationSupport;
        }
    }
}
