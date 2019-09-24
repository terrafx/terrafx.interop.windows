// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0EC870A6-5D7E-4C22-8CFC-5BAAE07616ED")]
    public unsafe struct ID3D12CommandQueue
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12CommandQueue* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12CommandQueue* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12CommandQueue* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D12CommandQueue* This, [NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint* pDataSize, void* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D12CommandQueue* This, [NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, void* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D12CommandQueue* This, [NativeTypeName("REFGUID")] Guid* guid, IUnknown* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(ID3D12CommandQueue* This, [NativeTypeName("LPCWSTR")] ushort* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(ID3D12CommandQueue* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvDevice = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _UpdateTileMappings(ID3D12CommandQueue* This, ID3D12Resource* pResource, [NativeTypeName("UINT")] uint NumResourceRegions, [Optional, NativeTypeName("D3D12_TILED_RESOURCE_COORDINATE[]")] D3D12_TILED_RESOURCE_COORDINATE* pResourceRegionStartCoordinates, [Optional, NativeTypeName("D3D12_TILE_REGION_SIZE[]")] D3D12_TILE_REGION_SIZE* pResourceRegionSizes, [Optional] ID3D12Heap* pHeap, [NativeTypeName("UINT")] uint NumRanges, [Optional, NativeTypeName("D3D12_TILE_RANGE_FLAGS[]")] D3D12_TILE_RANGE_FLAGS* pRangeFlags, [Optional, NativeTypeName("UINT[]")] uint* pHeapRangeStartOffsets, [Optional, NativeTypeName("UINT[]")] uint* pRangeTileCounts, D3D12_TILE_MAPPING_FLAGS Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopyTileMappings(ID3D12CommandQueue* This, ID3D12Resource* pDstResource, D3D12_TILED_RESOURCE_COORDINATE* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, D3D12_TILED_RESOURCE_COORDINATE* pSrcRegionStartCoordinate, D3D12_TILE_REGION_SIZE* pRegionSize, D3D12_TILE_MAPPING_FLAGS Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ExecuteCommandLists(ID3D12CommandQueue* This, [NativeTypeName("UINT")] uint NumCommandLists, [NativeTypeName("ID3D12CommandList*[]")] ID3D12CommandList** ppCommandLists);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetMarker(ID3D12CommandQueue* This, [NativeTypeName("UINT")] uint Metadata, [Optional] void* pData, [NativeTypeName("UINT")] uint Size);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _BeginEvent(ID3D12CommandQueue* This, [NativeTypeName("UINT")] uint Metadata, [Optional] void* pData, [NativeTypeName("UINT")] uint Size);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _EndEvent(ID3D12CommandQueue* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Signal(ID3D12CommandQueue* This, ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong Value);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Wait(ID3D12CommandQueue* This, ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong Value);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTimestampFrequency(ID3D12CommandQueue* This, [NativeTypeName("UINT64")] ulong* pFrequency);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClockCalibration(ID3D12CommandQueue* This, [NativeTypeName("UINT64")] ulong* pGpuTimestamp, [NativeTypeName("UINT64")] ulong* pCpuTimestamp);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D12_COMMAND_QUEUE_DESC* _GetDesc(ID3D12CommandQueue* This, D3D12_COMMAND_QUEUE_DESC* _result);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint* pDataSize, void* pData = null)
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(This, guid, pDataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, void* pData = null)
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(This, guid, DataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("REFGUID")] Guid* guid, IUnknown* pData = null)
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(This, guid, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)(This, Name);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("REFIID")] Guid* riid, void** ppvDevice = null)
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)(This, riid, ppvDevice);
            }
        }

        public void UpdateTileMappings(ID3D12Resource* pResource, [NativeTypeName("UINT")] uint NumResourceRegions, [Optional, NativeTypeName("D3D12_TILED_RESOURCE_COORDINATE[]")] D3D12_TILED_RESOURCE_COORDINATE* pResourceRegionStartCoordinates, [Optional, NativeTypeName("D3D12_TILE_REGION_SIZE[]")] D3D12_TILE_REGION_SIZE* pResourceRegionSizes, [Optional] ID3D12Heap* pHeap, [NativeTypeName("UINT")] uint NumRanges, [Optional, NativeTypeName("D3D12_TILE_RANGE_FLAGS[]")] D3D12_TILE_RANGE_FLAGS* pRangeFlags, [Optional, NativeTypeName("UINT[]")] uint* pHeapRangeStartOffsets, [Optional, NativeTypeName("UINT[]")] uint* pRangeTileCounts, D3D12_TILE_MAPPING_FLAGS Flags)
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_UpdateTileMappings>(lpVtbl->UpdateTileMappings)(This, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }

        public void CopyTileMappings(ID3D12Resource* pDstResource, D3D12_TILED_RESOURCE_COORDINATE* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, D3D12_TILED_RESOURCE_COORDINATE* pSrcRegionStartCoordinate, D3D12_TILE_REGION_SIZE* pRegionSize, D3D12_TILE_MAPPING_FLAGS Flags)
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CopyTileMappings>(lpVtbl->CopyTileMappings)(This, pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
            }
        }

        public void ExecuteCommandLists([NativeTypeName("UINT")] uint NumCommandLists, [NativeTypeName("ID3D12CommandList*[]")] ID3D12CommandList** ppCommandLists)
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ExecuteCommandLists>(lpVtbl->ExecuteCommandLists)(This, NumCommandLists, ppCommandLists);
            }
        }

        public void SetMarker([NativeTypeName("UINT")] uint Metadata, [Optional] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetMarker>(lpVtbl->SetMarker)(This, Metadata, pData, Size);
            }
        }

        public void BeginEvent([NativeTypeName("UINT")] uint Metadata, [Optional] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_BeginEvent>(lpVtbl->BeginEvent)(This, Metadata, pData, Size);
            }
        }

        public void EndEvent()
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_EndEvent>(lpVtbl->EndEvent)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Signal(ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong Value)
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Signal>(lpVtbl->Signal)(This, pFence, Value);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Wait(ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong Value)
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Wait>(lpVtbl->Wait)(This, pFence, Value);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTimestampFrequency([NativeTypeName("UINT64")] ulong* pFrequency)
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTimestampFrequency>(lpVtbl->GetTimestampFrequency)(This, pFrequency);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClockCalibration([NativeTypeName("UINT64")] ulong* pGpuTimestamp, [NativeTypeName("UINT64")] ulong* pCpuTimestamp)
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetClockCalibration>(lpVtbl->GetClockCalibration)(This, pGpuTimestamp, pCpuTimestamp);
            }
        }

        public D3D12_COMMAND_QUEUE_DESC GetDesc()
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                D3D12_COMMAND_QUEUE_DESC result;
                return *Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(This, &result);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetPrivateData;

            public IntPtr SetPrivateData;

            public IntPtr SetPrivateDataInterface;

            public IntPtr SetName;

            public IntPtr GetDevice;

            public IntPtr UpdateTileMappings;

            public IntPtr CopyTileMappings;

            public IntPtr ExecuteCommandLists;

            public IntPtr SetMarker;

            public IntPtr BeginEvent;

            public IntPtr EndEvent;

            public IntPtr Signal;

            public IntPtr Wait;

            public IntPtr GetTimestampFrequency;

            public IntPtr GetClockCalibration;

            public IntPtr GetDesc;
        }
    }
}
