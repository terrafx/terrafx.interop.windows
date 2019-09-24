// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("0EC870A6-5D7E-4C22-8CFC-5BAAE07616ED")]
    public unsafe struct ID3D12CommandQueue
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID3D12CommandQueue* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID3D12CommandQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID3D12CommandQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPrivateData(
            [In] ID3D12CommandQueue* This,
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateData(
            [In] ID3D12CommandQueue* This,
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateDataInterface(
            [In] ID3D12CommandQueue* This,
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In] IUnknown* pData = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetName(
            [In] ID3D12CommandQueue* This,
            [In, NativeTypeName("LPCWSTR")] char* Name
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDevice(
            [In] ID3D12CommandQueue* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvDevice = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _UpdateTileMappings(
            [In] ID3D12CommandQueue* This,
            [In] ID3D12Resource* pResource,
            [In, NativeTypeName("UINT")] uint NumResourceRegions,
            [In, Optional, NativeTypeName("D3D12_TILED_RESOURCE_COORDINATE[]")] D3D12_TILED_RESOURCE_COORDINATE* pResourceRegionStartCoordinates,
            [In, Optional, NativeTypeName("D3D12_TILE_REGION_SIZE[]")] D3D12_TILE_REGION_SIZE* pResourceRegionSizes,
            [In, Optional] ID3D12Heap* pHeap,
            [In, NativeTypeName("UINT")] uint NumRanges,
            [In, Optional, NativeTypeName("D3D12_TILE_RANGE_FLAGS[]")] D3D12_TILE_RANGE_FLAGS* pRangeFlags,
            [In, Optional, NativeTypeName("UINT[]")] uint* pHeapRangeStartOffsets,
            [In, Optional, NativeTypeName("UINT[]")] uint* pRangeTileCounts,
            [In] D3D12_TILE_MAPPING_FLAGS Flags
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _CopyTileMappings(
            [In] ID3D12CommandQueue* This,
            [In] ID3D12Resource* pDstResource,
            [In] D3D12_TILED_RESOURCE_COORDINATE* pDstRegionStartCoordinate,
            [In] ID3D12Resource* pSrcResource,
            [In] D3D12_TILED_RESOURCE_COORDINATE* pSrcRegionStartCoordinate,
            [In] D3D12_TILE_REGION_SIZE* pRegionSize,
            [In] D3D12_TILE_MAPPING_FLAGS Flags
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _ExecuteCommandLists(
            [In] ID3D12CommandQueue* This,
            [In, NativeTypeName("UINT")] uint NumCommandLists,
            [In, NativeTypeName("ID3D12CommandList*[]")] ID3D12CommandList** ppCommandLists
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetMarker(
            [In] ID3D12CommandQueue* This,
            [In, NativeTypeName("UINT")] uint Metadata,
            [In, Optional] void* pData,
            [In, NativeTypeName("UINT")] uint Size
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _BeginEvent(
            [In] ID3D12CommandQueue* This,
            [In, NativeTypeName("UINT")] uint Metadata,
            [In, Optional] void* pData,
            [In, NativeTypeName("UINT")] uint Size
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _EndEvent(
            [In] ID3D12CommandQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Signal(
            [In] ID3D12CommandQueue* This,
            [In] ID3D12Fence* pFence,
            [In, NativeTypeName("UINT64")] ulong Value
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Wait(
            [In] ID3D12CommandQueue* This,
            [In] ID3D12Fence* pFence,
            [In, NativeTypeName("UINT64")] ulong Value
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetTimestampFrequency(
            [In] ID3D12CommandQueue* This,
            [Out, NativeTypeName("UINT64")] ulong* pFrequency
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetClockCalibration(
            [In] ID3D12CommandQueue* This,
            [Out, NativeTypeName("UINT64")] ulong* pGpuTimestamp,
            [Out, NativeTypeName("UINT64")] ulong* pCpuTimestamp
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D3D12_COMMAND_QUEUE_DESC* _GetDesc(
            [In] ID3D12CommandQueue* This,
            [Out] D3D12_COMMAND_QUEUE_DESC* _result
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID3D12CommandQueue* This = &this)
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
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData(
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData = null
        )
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(
                    This,
                    guid,
                    pDataSize,
                    pData
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData(
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData = null
        )
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(
                    This,
                    guid,
                    DataSize,
                    pData
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface(
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In] IUnknown* pData = null
        )
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(
                    This,
                    guid,
                    pData
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName(
            [In, NativeTypeName("LPCWSTR")] char* Name
        )
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)(
                    This,
                    Name
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvDevice = null
        )
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)(
                    This,
                    riid,
                    ppvDevice
                );
            }
        }

        public void UpdateTileMappings(
            [In] ID3D12Resource* pResource,
            [In, NativeTypeName("UINT")] uint NumResourceRegions,
            [In, Optional, NativeTypeName("D3D12_TILED_RESOURCE_COORDINATE[]")] D3D12_TILED_RESOURCE_COORDINATE* pResourceRegionStartCoordinates,
            [In, Optional, NativeTypeName("D3D12_TILE_REGION_SIZE[]")] D3D12_TILE_REGION_SIZE* pResourceRegionSizes,
            [In, Optional] ID3D12Heap* pHeap,
            [In, NativeTypeName("UINT")] uint NumRanges,
            [In, Optional, NativeTypeName("D3D12_TILE_RANGE_FLAGS[]")] D3D12_TILE_RANGE_FLAGS* pRangeFlags,
            [In, Optional, NativeTypeName("UINT[]")] uint* pHeapRangeStartOffsets,
            [In, Optional, NativeTypeName("UINT[]")] uint* pRangeTileCounts,
            [In] D3D12_TILE_MAPPING_FLAGS Flags
        )
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_UpdateTileMappings>(lpVtbl->UpdateTileMappings)(
                    This,
                    pResource,
                    NumResourceRegions,
                    pResourceRegionStartCoordinates,
                    pResourceRegionSizes,
                    pHeap,
                    NumRanges,
                    pRangeFlags,
                    pHeapRangeStartOffsets,
                    pRangeTileCounts,
                    Flags
                );
            }
        }

        public void CopyTileMappings(
            [In] ID3D12Resource* pDstResource,
            [In] D3D12_TILED_RESOURCE_COORDINATE* pDstRegionStartCoordinate,
            [In] ID3D12Resource* pSrcResource,
            [In] D3D12_TILED_RESOURCE_COORDINATE* pSrcRegionStartCoordinate,
            [In] D3D12_TILE_REGION_SIZE* pRegionSize,
            [In] D3D12_TILE_MAPPING_FLAGS Flags
        )
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CopyTileMappings>(lpVtbl->CopyTileMappings)(
                    This,
                    pDstResource,
                    pDstRegionStartCoordinate,
                    pSrcResource,
                    pSrcRegionStartCoordinate,
                    pRegionSize,
                    Flags
                );
            }
        }

        public void ExecuteCommandLists(
            [In, NativeTypeName("UINT")] uint NumCommandLists,
            [In, NativeTypeName("ID3D12CommandList*[]")] ID3D12CommandList** ppCommandLists
        )
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ExecuteCommandLists>(lpVtbl->ExecuteCommandLists)(
                    This,
                    NumCommandLists,
                    ppCommandLists
                );
            }
        }

        public void SetMarker(
            [In, NativeTypeName("UINT")] uint Metadata,
            [In, Optional] void* pData,
            [In, NativeTypeName("UINT")] uint Size
        )
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetMarker>(lpVtbl->SetMarker)(
                    This,
                    Metadata,
                    pData,
                    Size
                );
            }
        }

        public void BeginEvent(
            [In, NativeTypeName("UINT")] uint Metadata,
            [In, Optional] void* pData,
            [In, NativeTypeName("UINT")] uint Size
        )
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_BeginEvent>(lpVtbl->BeginEvent)(
                    This,
                    Metadata,
                    pData,
                    Size
                );
            }
        }

        public void EndEvent()
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_EndEvent>(lpVtbl->EndEvent)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Signal(
            [In] ID3D12Fence* pFence,
            [In, NativeTypeName("UINT64")] ulong Value
        )
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Signal>(lpVtbl->Signal)(
                    This,
                    pFence,
                    Value
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Wait(
            [In] ID3D12Fence* pFence,
            [In, NativeTypeName("UINT64")] ulong Value
        )
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Wait>(lpVtbl->Wait)(
                    This,
                    pFence,
                    Value
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTimestampFrequency(
            [Out, NativeTypeName("UINT64")] ulong* pFrequency
        )
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTimestampFrequency>(lpVtbl->GetTimestampFrequency)(
                    This,
                    pFrequency
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClockCalibration(
            [Out, NativeTypeName("UINT64")] ulong* pGpuTimestamp,
            [Out, NativeTypeName("UINT64")] ulong* pCpuTimestamp
        )
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetClockCalibration>(lpVtbl->GetClockCalibration)(
                    This,
                    pGpuTimestamp,
                    pCpuTimestamp
                );
            }
        }

        public D3D12_COMMAND_QUEUE_DESC GetDesc()
        {
            fixed (ID3D12CommandQueue* This = &this)
            {
                D3D12_COMMAND_QUEUE_DESC result;
                return *Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(
                    This,
                    &result
                );
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
