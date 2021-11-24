// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("05008617-FBFD-4051-A790-144884B4F6A9")]
[NativeTypeName("struct IDXGIDevice2 : IDXGIDevice1")]
[NativeInheritance("IDXGIDevice1")]
public unsafe partial struct IDXGIDevice2 : IDXGIDevice2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIDevice2*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGIDevice2*, uint>)(lpVtbl[1]))((IDXGIDevice2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIDevice2*, uint>)(lpVtbl[2]))((IDXGIDevice2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<IDXGIDevice2*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
    {
        return ((delegate* unmanaged<IDXGIDevice2*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), Name, pUnknown);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<IDXGIDevice2*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
    {
        return ((delegate* unmanaged<IDXGIDevice2*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), riid, ppParent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAdapter(IDXGIAdapter** pAdapter)
    {
        return ((delegate* unmanaged<IDXGIDevice2*, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), pAdapter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateSurface([NativeTypeName("const DXGI_SURFACE_DESC *")] DXGI_SURFACE_DESC* pDesc, uint NumSurfaces, [NativeTypeName("DXGI_USAGE")] uint Usage, [NativeTypeName("const DXGI_SHARED_RESOURCE *")] DXGI_SHARED_RESOURCE* pSharedResource, IDXGISurface** ppSurface)
    {
        return ((delegate* unmanaged<IDXGIDevice2*, DXGI_SURFACE_DESC*, uint, uint, DXGI_SHARED_RESOURCE*, IDXGISurface**, int>)(lpVtbl[8]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT QueryResourceResidency([NativeTypeName("IUnknown *const *")] IUnknown** ppResources, DXGI_RESIDENCY* pResidencyStatus, uint NumResources)
    {
        return ((delegate* unmanaged<IDXGIDevice2*, IUnknown**, DXGI_RESIDENCY*, uint, int>)(lpVtbl[9]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), ppResources, pResidencyStatus, NumResources);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetGPUThreadPriority(int Priority)
    {
        return ((delegate* unmanaged<IDXGIDevice2*, int, int>)(lpVtbl[10]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), Priority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetGPUThreadPriority(int* pPriority)
    {
        return ((delegate* unmanaged<IDXGIDevice2*, int*, int>)(lpVtbl[11]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), pPriority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetMaximumFrameLatency(uint MaxLatency)
    {
        return ((delegate* unmanaged<IDXGIDevice2*, uint, int>)(lpVtbl[12]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), MaxLatency);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetMaximumFrameLatency(uint* pMaxLatency)
    {
        return ((delegate* unmanaged<IDXGIDevice2*, uint*, int>)(lpVtbl[13]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), pMaxLatency);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT OfferResources(uint NumResources, [NativeTypeName("IDXGIResource *const *")] IDXGIResource** ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority)
    {
        return ((delegate* unmanaged<IDXGIDevice2*, uint, IDXGIResource**, DXGI_OFFER_RESOURCE_PRIORITY, int>)(lpVtbl[14]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), NumResources, ppResources, Priority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ReclaimResources(uint NumResources, [NativeTypeName("IDXGIResource *const *")] IDXGIResource** ppResources, BOOL* pDiscarded)
    {
        return ((delegate* unmanaged<IDXGIDevice2*, uint, IDXGIResource**, BOOL*, int>)(lpVtbl[15]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), NumResources, ppResources, pDiscarded);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT EnqueueSetEvent(HANDLE hEvent)
    {
        return ((delegate* unmanaged<IDXGIDevice2*, HANDLE, int>)(lpVtbl[16]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), hEvent);
    }

    public interface Interface : IDXGIDevice1.Interface
    {
        [VtblIndex(14)]
        HRESULT OfferResources(uint NumResources, [NativeTypeName("IDXGIResource *const *")] IDXGIResource** ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority);

        [VtblIndex(15)]
        HRESULT ReclaimResources(uint NumResources, [NativeTypeName("IDXGIResource *const *")] IDXGIResource** ppResources, BOOL* pDiscarded);

        [VtblIndex(16)]
        HRESULT EnqueueSetEvent(HANDLE hEvent);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDevice2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDevice2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDevice2*, uint> Release;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDevice2*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDevice2*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDevice2*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDevice2*, Guid*, void**, int> GetParent;

        [NativeTypeName("HRESULT (IDXGIAdapter **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDevice2*, IDXGIAdapter**, int> GetAdapter;

        [NativeTypeName("HRESULT (const DXGI_SURFACE_DESC *, UINT, DXGI_USAGE, const DXGI_SHARED_RESOURCE *, IDXGISurface **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDevice2*, DXGI_SURFACE_DESC*, uint, uint, DXGI_SHARED_RESOURCE*, IDXGISurface**, int> CreateSurface;

        [NativeTypeName("HRESULT (IUnknown *const *, DXGI_RESIDENCY *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDevice2*, IUnknown**, DXGI_RESIDENCY*, uint, int> QueryResourceResidency;

        [NativeTypeName("HRESULT (INT) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDevice2*, int, int> SetGPUThreadPriority;

        [NativeTypeName("HRESULT (INT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDevice2*, int*, int> GetGPUThreadPriority;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDevice2*, uint, int> SetMaximumFrameLatency;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDevice2*, uint*, int> GetMaximumFrameLatency;

        [NativeTypeName("HRESULT (UINT, IDXGIResource *const *, DXGI_OFFER_RESOURCE_PRIORITY) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDevice2*, uint, IDXGIResource**, DXGI_OFFER_RESOURCE_PRIORITY, int> OfferResources;

        [NativeTypeName("HRESULT (UINT, IDXGIResource *const *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDevice2*, uint, IDXGIResource**, BOOL*, int> ReclaimResources;

        [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDevice2*, HANDLE, int> EnqueueSetEvent;
    }
}
