// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12CommandQueue1.xml' path='doc/member[@name="ID3D12CommandQueue1"]/*' />
[Guid("3A3C3165-0EE7-4B8E-A0AF-6356B4C3BBB9")]
[NativeTypeName("struct ID3D12CommandQueue1 : ID3D12CommandQueue")]
[NativeInheritance("ID3D12CommandQueue")]
public unsafe partial struct ID3D12CommandQueue1 : ID3D12CommandQueue1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12CommandQueue1);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, uint>)(lpVtbl[1]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, uint>)(lpVtbl[2]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12Object.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] char* Name)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, char*, int>)(lpVtbl[6]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), Name);
    }

    /// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
    }

    /// <inheritdoc cref="ID3D12CommandQueue.UpdateTileMappings" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12_TILED_RESOURCE_COORDINATE* pResourceRegionStartCoordinates, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12_TILE_REGION_SIZE* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [NativeTypeName("const D3D12_TILE_RANGE_FLAGS *")] D3D12_TILE_RANGE_FLAGS* pRangeFlags, [NativeTypeName("const UINT *")] uint* pHeapRangeStartOffsets, [NativeTypeName("const UINT *")] uint* pRangeTileCounts, D3D12_TILE_MAPPING_FLAGS Flags)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, ID3D12Resource*, uint, D3D12_TILED_RESOURCE_COORDINATE*, D3D12_TILE_REGION_SIZE*, ID3D12Heap*, uint, D3D12_TILE_RANGE_FLAGS*, uint*, uint*, D3D12_TILE_MAPPING_FLAGS, void>)(lpVtbl[8]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <inheritdoc cref="ID3D12CommandQueue.CopyTileMappings" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void CopyTileMappings(ID3D12Resource* pDstResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12_TILED_RESOURCE_COORDINATE* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12_TILED_RESOURCE_COORDINATE* pSrcRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12_TILE_REGION_SIZE* pRegionSize, D3D12_TILE_MAPPING_FLAGS Flags)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, ID3D12Resource*, D3D12_TILED_RESOURCE_COORDINATE*, ID3D12Resource*, D3D12_TILED_RESOURCE_COORDINATE*, D3D12_TILE_REGION_SIZE*, D3D12_TILE_MAPPING_FLAGS, void>)(lpVtbl[9]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <inheritdoc cref="ID3D12CommandQueue.ExecuteCommandLists" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void ExecuteCommandLists(uint NumCommandLists, [NativeTypeName("ID3D12CommandList *const *")] ID3D12CommandList** ppCommandLists)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, uint, ID3D12CommandList**, void>)(lpVtbl[10]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), NumCommandLists, ppCommandLists);
    }

    /// <inheritdoc cref="ID3D12CommandQueue.SetMarker" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, uint, void*, uint, void>)(lpVtbl[11]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
    }

    /// <inheritdoc cref="ID3D12CommandQueue.BeginEvent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, uint, void*, uint, void>)(lpVtbl[12]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
    }

    /// <inheritdoc cref="ID3D12CommandQueue.EndEvent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void EndEvent()
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, void>)(lpVtbl[13]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12CommandQueue.Signal" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Signal(ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong Value)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, ID3D12Fence*, ulong, int>)(lpVtbl[14]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), pFence, Value);
    }

    /// <inheritdoc cref="ID3D12CommandQueue.Wait" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Wait(ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong Value)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, ID3D12Fence*, ulong, int>)(lpVtbl[15]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), pFence, Value);
    }

    /// <inheritdoc cref="ID3D12CommandQueue.GetTimestampFrequency" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetTimestampFrequency([NativeTypeName("UINT64 *")] ulong* pFrequency)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, ulong*, int>)(lpVtbl[16]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), pFrequency);
    }

    /// <inheritdoc cref="ID3D12CommandQueue.GetClockCalibration" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetClockCalibration([NativeTypeName("UINT64 *")] ulong* pGpuTimestamp, [NativeTypeName("UINT64 *")] ulong* pCpuTimestamp)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, ulong*, ulong*, int>)(lpVtbl[17]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), pGpuTimestamp, pCpuTimestamp);
    }

    /// <inheritdoc cref="ID3D12CommandQueue.GetDesc" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public D3D12_COMMAND_QUEUE_DESC GetDesc()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, D3D12_COMMAND_QUEUE_DESC>)(lpVtbl[18]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12CommandQueue1.xml' path='doc/member[@name="ID3D12CommandQueue1.SetProcessPriority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetProcessPriority(D3D12_COMMAND_QUEUE_PROCESS_PRIORITY Priority)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, D3D12_COMMAND_QUEUE_PROCESS_PRIORITY, int>)(lpVtbl[19]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), Priority);
    }

    /// <include file='ID3D12CommandQueue1.xml' path='doc/member[@name="ID3D12CommandQueue1.GetProcessPriority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetProcessPriority(D3D12_COMMAND_QUEUE_PROCESS_PRIORITY* pOutValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, D3D12_COMMAND_QUEUE_PROCESS_PRIORITY*, int>)(lpVtbl[20]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), pOutValue);
    }

    /// <include file='ID3D12CommandQueue1.xml' path='doc/member[@name="ID3D12CommandQueue1.SetGlobalPriority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetGlobalPriority(D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY Priority)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY, int>)(lpVtbl[21]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), Priority);
    }

    /// <include file='ID3D12CommandQueue1.xml' path='doc/member[@name="ID3D12CommandQueue1.GetGlobalPriority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetGlobalPriority(D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY* pOutValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CommandQueue1*, D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY*, int>)(lpVtbl[22]))((ID3D12CommandQueue1*)Unsafe.AsPointer(ref this), pOutValue);
    }

    public interface Interface : ID3D12CommandQueue.Interface
    {
        [VtblIndex(19)]
        HRESULT SetProcessPriority(D3D12_COMMAND_QUEUE_PROCESS_PRIORITY Priority);

        [VtblIndex(20)]
        HRESULT GetProcessPriority(D3D12_COMMAND_QUEUE_PROCESS_PRIORITY* pOutValue);

        [VtblIndex(21)]
        HRESULT SetGlobalPriority(D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY Priority);

        [VtblIndex(22)]
        HRESULT GetGlobalPriority(D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY* pOutValue);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetName;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetDevice;

        [NativeTypeName("void (ID3D12Resource *, UINT, const D3D12_TILED_RESOURCE_COORDINATE *, const D3D12_TILE_REGION_SIZE *, ID3D12Heap *, UINT, const D3D12_TILE_RANGE_FLAGS *, const UINT *, const UINT *, D3D12_TILE_MAPPING_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12Resource*, uint, D3D12_TILED_RESOURCE_COORDINATE*, D3D12_TILE_REGION_SIZE*, ID3D12Heap*, uint, D3D12_TILE_RANGE_FLAGS*, uint*, uint*, D3D12_TILE_MAPPING_FLAGS, void> UpdateTileMappings;

        [NativeTypeName("void (ID3D12Resource *, const D3D12_TILED_RESOURCE_COORDINATE *, ID3D12Resource *, const D3D12_TILED_RESOURCE_COORDINATE *, const D3D12_TILE_REGION_SIZE *, D3D12_TILE_MAPPING_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12Resource*, D3D12_TILED_RESOURCE_COORDINATE*, ID3D12Resource*, D3D12_TILED_RESOURCE_COORDINATE*, D3D12_TILE_REGION_SIZE*, D3D12_TILE_MAPPING_FLAGS, void> CopyTileMappings;

        [NativeTypeName("void (UINT, ID3D12CommandList *const *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, ID3D12CommandList**, void> ExecuteCommandLists;

        [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, uint, void> SetMarker;

        [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, uint, void> BeginEvent;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> EndEvent;

        [NativeTypeName("HRESULT (ID3D12Fence *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12Fence*, ulong, int> Signal;

        [NativeTypeName("HRESULT (ID3D12Fence *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12Fence*, ulong, int> Wait;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> GetTimestampFrequency;

        [NativeTypeName("HRESULT (UINT64 *, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, ulong*, int> GetClockCalibration;

        [NativeTypeName("D3D12_COMMAND_QUEUE_DESC () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMMAND_QUEUE_DESC> GetDesc;

        [NativeTypeName("HRESULT (D3D12_COMMAND_QUEUE_PROCESS_PRIORITY) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMMAND_QUEUE_PROCESS_PRIORITY, int> SetProcessPriority;

        [NativeTypeName("HRESULT (D3D12_COMMAND_QUEUE_PROCESS_PRIORITY *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMMAND_QUEUE_PROCESS_PRIORITY*, int> GetProcessPriority;

        [NativeTypeName("HRESULT (D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY, int> SetGlobalPriority;

        [NativeTypeName("HRESULT (D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY*, int> GetGlobalPriority;
    }
}
