// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0EC870A6-5D7E-4C22-8CFC-5BAAE07616ED")]
    public unsafe partial struct ID3D12CommandQueue
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12CommandQueue* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12CommandQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12CommandQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D12CommandQueue* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D12CommandQueue* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D12CommandQueue* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(ID3D12CommandQueue* pThis, [NativeTypeName("LPCWSTR")] ushort* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(ID3D12CommandQueue* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _UpdateTileMappings(ID3D12CommandQueue* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("UINT")] uint NumResourceRegions, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12_TILED_RESOURCE_COORDINATE* pResourceRegionStartCoordinates, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12_TILE_REGION_SIZE* pResourceRegionSizes, [NativeTypeName("ID3D12Heap *")] ID3D12Heap* pHeap, [NativeTypeName("UINT")] uint NumRanges, [NativeTypeName("const D3D12_TILE_RANGE_FLAGS *")] D3D12_TILE_RANGE_FLAGS* pRangeFlags, [NativeTypeName("const UINT *")] uint* pHeapRangeStartOffsets, [NativeTypeName("const UINT *")] uint* pRangeTileCounts, D3D12_TILE_MAPPING_FLAGS Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopyTileMappings(ID3D12CommandQueue* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12_TILED_RESOURCE_COORDINATE* pDstRegionStartCoordinate, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12_TILED_RESOURCE_COORDINATE* pSrcRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12_TILE_REGION_SIZE* pRegionSize, D3D12_TILE_MAPPING_FLAGS Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ExecuteCommandLists(ID3D12CommandQueue* pThis, [NativeTypeName("UINT")] uint NumCommandLists, [NativeTypeName("ID3D12CommandList *const *")] ID3D12CommandList** ppCommandLists);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetMarker(ID3D12CommandQueue* pThis, [NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _BeginEvent(ID3D12CommandQueue* pThis, [NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _EndEvent(ID3D12CommandQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Signal(ID3D12CommandQueue* pThis, [NativeTypeName("ID3D12Fence *")] ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong Value);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Wait(ID3D12CommandQueue* pThis, [NativeTypeName("ID3D12Fence *")] ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong Value);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTimestampFrequency(ID3D12CommandQueue* pThis, [NativeTypeName("UINT64 *")] ulong* pFrequency);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClockCalibration(ID3D12CommandQueue* pThis, [NativeTypeName("UINT64 *")] ulong* pGpuTimestamp, [NativeTypeName("UINT64 *")] ulong* pCpuTimestamp);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D12_COMMAND_QUEUE_DESC* _GetDesc(ID3D12CommandQueue* pThis, D3D12_COMMAND_QUEUE_DESC* _result);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        public void UpdateTileMappings([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("UINT")] uint NumResourceRegions, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12_TILED_RESOURCE_COORDINATE* pResourceRegionStartCoordinates, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12_TILE_REGION_SIZE* pResourceRegionSizes, [NativeTypeName("ID3D12Heap *")] ID3D12Heap* pHeap, [NativeTypeName("UINT")] uint NumRanges, [NativeTypeName("const D3D12_TILE_RANGE_FLAGS *")] D3D12_TILE_RANGE_FLAGS* pRangeFlags, [NativeTypeName("const UINT *")] uint* pHeapRangeStartOffsets, [NativeTypeName("const UINT *")] uint* pRangeTileCounts, D3D12_TILE_MAPPING_FLAGS Flags)
        {
            Marshal.GetDelegateForFunctionPointer<_UpdateTileMappings>(lpVtbl->UpdateTileMappings)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this), pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
        }

        public void CopyTileMappings([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12_TILED_RESOURCE_COORDINATE* pDstRegionStartCoordinate, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12_TILED_RESOURCE_COORDINATE* pSrcRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12_TILE_REGION_SIZE* pRegionSize, D3D12_TILE_MAPPING_FLAGS Flags)
        {
            Marshal.GetDelegateForFunctionPointer<_CopyTileMappings>(lpVtbl->CopyTileMappings)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this), pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
        }

        public void ExecuteCommandLists([NativeTypeName("UINT")] uint NumCommandLists, [NativeTypeName("ID3D12CommandList *const *")] ID3D12CommandList** ppCommandLists)
        {
            Marshal.GetDelegateForFunctionPointer<_ExecuteCommandLists>(lpVtbl->ExecuteCommandLists)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this), NumCommandLists, ppCommandLists);
        }

        public void SetMarker([NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            Marshal.GetDelegateForFunctionPointer<_SetMarker>(lpVtbl->SetMarker)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        public void BeginEvent([NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            Marshal.GetDelegateForFunctionPointer<_BeginEvent>(lpVtbl->BeginEvent)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        public void EndEvent()
        {
            Marshal.GetDelegateForFunctionPointer<_EndEvent>(lpVtbl->EndEvent)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Signal([NativeTypeName("ID3D12Fence *")] ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong Value)
        {
            return Marshal.GetDelegateForFunctionPointer<_Signal>(lpVtbl->Signal)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this), pFence, Value);
        }

        [return: NativeTypeName("HRESULT")]
        public int Wait([NativeTypeName("ID3D12Fence *")] ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong Value)
        {
            return Marshal.GetDelegateForFunctionPointer<_Wait>(lpVtbl->Wait)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this), pFence, Value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTimestampFrequency([NativeTypeName("UINT64 *")] ulong* pFrequency)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTimestampFrequency>(lpVtbl->GetTimestampFrequency)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this), pFrequency);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClockCalibration([NativeTypeName("UINT64 *")] ulong* pGpuTimestamp, [NativeTypeName("UINT64 *")] ulong* pCpuTimestamp)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetClockCalibration>(lpVtbl->GetClockCalibration)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this), pGpuTimestamp, pCpuTimestamp);
        }

        public D3D12_COMMAND_QUEUE_DESC GetDesc()
        {
            D3D12_COMMAND_QUEUE_DESC result;
            return *Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((ID3D12CommandQueue*)Unsafe.AsPointer(ref this), &result);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public IntPtr SetName;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetDevice;

            [NativeTypeName("void (ID3D12Resource *, UINT, const D3D12_TILED_RESOURCE_COORDINATE *, const D3D12_TILE_REGION_SIZE *, ID3D12Heap *, UINT, const D3D12_TILE_RANGE_FLAGS *, const UINT *, const UINT *, D3D12_TILE_MAPPING_FLAGS) __attribute__((stdcall))")]
            public IntPtr UpdateTileMappings;

            [NativeTypeName("void (ID3D12Resource *, const D3D12_TILED_RESOURCE_COORDINATE *, ID3D12Resource *, const D3D12_TILED_RESOURCE_COORDINATE *, const D3D12_TILE_REGION_SIZE *, D3D12_TILE_MAPPING_FLAGS) __attribute__((stdcall))")]
            public IntPtr CopyTileMappings;

            [NativeTypeName("void (UINT, ID3D12CommandList *const *) __attribute__((stdcall))")]
            public IntPtr ExecuteCommandLists;

            [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
            public IntPtr SetMarker;

            [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
            public IntPtr BeginEvent;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr EndEvent;

            [NativeTypeName("HRESULT (ID3D12Fence *, UINT64) __attribute__((stdcall))")]
            public IntPtr Signal;

            [NativeTypeName("HRESULT (ID3D12Fence *, UINT64) __attribute__((stdcall))")]
            public IntPtr Wait;

            [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
            public IntPtr GetTimestampFrequency;

            [NativeTypeName("HRESULT (UINT64 *, UINT64 *) __attribute__((stdcall))")]
            public IntPtr GetClockCalibration;

            [NativeTypeName("D3D12_COMMAND_QUEUE_DESC () __attribute__((stdcall))")]
            public IntPtr GetDesc;
        }
    }
}
