// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("95B4F95F-D8DA-4CA4-9EE6-3B76D5968A10")]
    [NativeTypeName("struct IDXGIDevice4 : IDXGIDevice3")]
    [NativeInheritance("IDXGIDevice3")]
    public unsafe partial struct IDXGIDevice4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIDevice4*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIDevice4*, uint>)(lpVtbl[1]))((IDXGIDevice4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIDevice4*, uint>)(lpVtbl[2]))((IDXGIDevice4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGIDevice4*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGIDevice4*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGIDevice4*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGIDevice4*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdapter(IDXGIAdapter** pAdapter)
        {
            return ((delegate* unmanaged<IDXGIDevice4*, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), pAdapter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSurface([NativeTypeName("const DXGI_SURFACE_DESC *")] DXGI_SURFACE_DESC* pDesc, [NativeTypeName("UINT")] uint NumSurfaces, [NativeTypeName("DXGI_USAGE")] uint Usage, [NativeTypeName("const DXGI_SHARED_RESOURCE *")] DXGI_SHARED_RESOURCE* pSharedResource, IDXGISurface** ppSurface)
        {
            return ((delegate* unmanaged<IDXGIDevice4*, DXGI_SURFACE_DESC*, uint, uint, DXGI_SHARED_RESOURCE*, IDXGISurface**, int>)(lpVtbl[8]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int QueryResourceResidency([NativeTypeName("IUnknown *const *")] IUnknown** ppResources, DXGI_RESIDENCY* pResidencyStatus, [NativeTypeName("UINT")] uint NumResources)
        {
            return ((delegate* unmanaged<IDXGIDevice4*, IUnknown**, DXGI_RESIDENCY*, uint, int>)(lpVtbl[9]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), ppResources, pResidencyStatus, NumResources);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetGPUThreadPriority([NativeTypeName("INT")] int Priority)
        {
            return ((delegate* unmanaged<IDXGIDevice4*, int, int>)(lpVtbl[10]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), Priority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetGPUThreadPriority([NativeTypeName("INT *")] int* pPriority)
        {
            return ((delegate* unmanaged<IDXGIDevice4*, int*, int>)(lpVtbl[11]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), pPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaximumFrameLatency([NativeTypeName("UINT")] uint MaxLatency)
        {
            return ((delegate* unmanaged<IDXGIDevice4*, uint, int>)(lpVtbl[12]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), MaxLatency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaximumFrameLatency([NativeTypeName("UINT *")] uint* pMaxLatency)
        {
            return ((delegate* unmanaged<IDXGIDevice4*, uint*, int>)(lpVtbl[13]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), pMaxLatency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int OfferResources([NativeTypeName("UINT")] uint NumResources, [NativeTypeName("IDXGIResource *const *")] IDXGIResource** ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority)
        {
            return ((delegate* unmanaged<IDXGIDevice4*, uint, IDXGIResource**, DXGI_OFFER_RESOURCE_PRIORITY, int>)(lpVtbl[14]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, Priority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int ReclaimResources([NativeTypeName("UINT")] uint NumResources, [NativeTypeName("IDXGIResource *const *")] IDXGIResource** ppResources, BOOL* pDiscarded)
        {
            return ((delegate* unmanaged<IDXGIDevice4*, uint, IDXGIResource**, BOOL*, int>)(lpVtbl[15]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, pDiscarded);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int EnqueueSetEvent([NativeTypeName("HANDLE")] IntPtr hEvent)
        {
            return ((delegate* unmanaged<IDXGIDevice4*, IntPtr, int>)(lpVtbl[16]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), hEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void Trim()
        {
            ((delegate* unmanaged<IDXGIDevice4*, void>)(lpVtbl[17]))((IDXGIDevice4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int OfferResources1([NativeTypeName("UINT")] uint NumResources, [NativeTypeName("IDXGIResource *const *")] IDXGIResource** ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority, [NativeTypeName("UINT")] uint Flags)
        {
            return ((delegate* unmanaged<IDXGIDevice4*, uint, IDXGIResource**, DXGI_OFFER_RESOURCE_PRIORITY, uint, int>)(lpVtbl[18]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, Priority, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int ReclaimResources1([NativeTypeName("UINT")] uint NumResources, [NativeTypeName("IDXGIResource *const *")] IDXGIResource** ppResources, DXGI_RECLAIM_RESOURCE_RESULTS* pResults)
        {
            return ((delegate* unmanaged<IDXGIDevice4*, uint, IDXGIResource**, DXGI_RECLAIM_RESOURCE_RESULTS*, int>)(lpVtbl[19]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, pResults);
        }
    }
}
