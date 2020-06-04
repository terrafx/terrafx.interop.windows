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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDXGISwapChainMedia*, Guid*, void**, int>)(lpVtbl[0]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDXGISwapChainMedia*, uint>)(lpVtbl[1]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDXGISwapChainMedia*, uint>)(lpVtbl[2]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatisticsMedia([NativeTypeName("DXGI_FRAME_STATISTICS_MEDIA *")] DXGI_FRAME_STATISTICS_MEDIA* pStats)
        {
            return ((delegate* stdcall<IDXGISwapChainMedia*, DXGI_FRAME_STATISTICS_MEDIA*, int>)(lpVtbl[3]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), pStats);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPresentDuration([NativeTypeName("UINT")] uint Duration)
        {
            return ((delegate* stdcall<IDXGISwapChainMedia*, uint, int>)(lpVtbl[4]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), Duration);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckPresentDurationSupport([NativeTypeName("UINT")] uint DesiredPresentDuration, [NativeTypeName("UINT *")] uint* pClosestSmallerPresentDuration, [NativeTypeName("UINT *")] uint* pClosestLargerPresentDuration)
        {
            return ((delegate* stdcall<IDXGISwapChainMedia*, uint, uint*, uint*, int>)(lpVtbl[5]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), DesiredPresentDuration, pClosestSmallerPresentDuration, pClosestLargerPresentDuration);
        }
    }
}
