// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("77ACCE80-638E-4E65-8895-C1F23386863E")]
    public unsafe struct ID3D12Device1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID3D12Device1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID3D12Device1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID3D12Device1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPrivateData(
            [In] ID3D12Device1* This,
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateData(
            [In] ID3D12Device1* This,
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateDataInterface(
            [In] ID3D12Device1* This,
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In] IUnknown* pData = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetName(
            [In] ID3D12Device1* This,
            [In, NativeTypeName("LPCWSTR")] char* Name
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public /* static */ delegate uint _GetNodeCount(
            [In] ID3D12Device1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateCommandQueue(
            [In] ID3D12Device1* This,
            [In] D3D12_COMMAND_QUEUE_DESC* pDesc,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppCommandQueue
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateCommandAllocator(
            [In] ID3D12Device1* This,
            [In] D3D12_COMMAND_LIST_TYPE Type,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppCommandAllocator
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateGraphicsPipelineState(
            [In] ID3D12Device1* This,
            [In] D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppPipelineState
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateComputePipelineState(
            [In] ID3D12Device1* This,
            [In] D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppPipelineState
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateCommandList(
            [In] ID3D12Device1* This,
            [In, NativeTypeName("UINT")] uint NodeMask,
            [In] D3D12_COMMAND_LIST_TYPE Type,
            [In] ID3D12CommandAllocator* pCommandAllocator,
            [In, Optional] ID3D12PipelineState* pInitialState,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppCommandList
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CheckFeatureSupport(
            [In] ID3D12Device1* This,
            [In] D3D12_FEATURE Feature,
            [In, Out] void* pFeatureSupportData,
            [In, NativeTypeName("UINT")] uint FeatureSupportDataSize
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDescriptorHeap(
            [In] ID3D12Device1* This,
            [In] D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvHeap
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public /* static */ delegate uint _GetDescriptorHandleIncrementSize(
            [In] ID3D12Device1* This,
            [In] D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateRootSignature(
            [In] ID3D12Device1* This,
            [In, NativeTypeName("UINT")] uint NodeMask,
            [In] void* pBlobWithRootSignature,
            [In, NativeTypeName("SIZE_T")] UIntPtr blobLengthInBytes,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvRootSignature
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _CreateConstantBufferView(
            [In] ID3D12Device1* This,
            [In, Optional] D3D12_CONSTANT_BUFFER_VIEW_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _CreateShaderResourceView(
            [In] ID3D12Device1* This,
            [In, Optional] ID3D12Resource* pResource,
            [In, Optional] D3D12_SHADER_RESOURCE_VIEW_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _CreateUnorderedAccessView(
            [In] ID3D12Device1* This,
            [In, Optional] ID3D12Resource* pResource,
            [In, Optional] ID3D12Resource* pCounterResource,
            [In, Optional] D3D12_UNORDERED_ACCESS_VIEW_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _CreateRenderTargetView(
            [In] ID3D12Device1* This,
            [In, Optional] ID3D12Resource* pResource,
            [In, Optional] D3D12_RENDER_TARGET_VIEW_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _CreateDepthStencilView(
            [In] ID3D12Device1* This,
            [In, Optional] ID3D12Resource* pResource,
            [In, Optional] D3D12_DEPTH_STENCIL_VIEW_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _CreateSampler(
            [In] ID3D12Device1* This,
            [In] D3D12_SAMPLER_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _CopyDescriptors(
            [In] ID3D12Device1* This,
            [In, NativeTypeName("UINT")] uint NumDestDescriptorRanges,
            [In, NativeTypeName("D3D12_CPU_DESCRIPTOR_HANDLE[]")] D3D12_CPU_DESCRIPTOR_HANDLE* pDestDescriptorRangeStarts,
            [In, Optional, NativeTypeName("UINT[]")] uint* pDestDescriptorRangeSizes,
            [In, NativeTypeName("UINT")] uint NumSrcDescriptorRanges,
            [In, NativeTypeName("D3D12_CPU_DESCRIPTOR_HANDLE[]")] D3D12_CPU_DESCRIPTOR_HANDLE* pSrcDescriptorRangeStarts,
            [In, Optional, NativeTypeName("UINT[]")] uint* pSrcDescriptorRangeSizes,
            [In] D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _CopyDescriptorsSimple(
            [In] ID3D12Device1* This,
            [In, NativeTypeName("UINT")] uint NumDescriptors,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart,
            [In] D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate D3D12_RESOURCE_ALLOCATION_INFO* _GetResourceAllocationInfo(
            [In] ID3D12Device1* This,
            [Out] D3D12_RESOURCE_ALLOCATION_INFO* _result,
            [In, NativeTypeName("UINT")] uint visibleMask,
            [In, NativeTypeName("UINT")] uint numResourceDescs,
            [In] D3D12_RESOURCE_DESC* pResourceDescs
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate D3D12_HEAP_PROPERTIES* _GetCustomHeapProperties(
            [In] ID3D12Device1* This,
            [Out] D3D12_HEAP_PROPERTIES* _result,
            [In, NativeTypeName("UINT")] uint NodeMask,
            [In] D3D12_HEAP_TYPE heapType
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateCommittedResource(
            [In] ID3D12Device1* This,
            [In] D3D12_HEAP_PROPERTIES* pHeapProperties,
            [In] D3D12_HEAP_FLAGS HeapFlags,
            [In] D3D12_RESOURCE_DESC* pDesc,
            [In] D3D12_RESOURCE_STATES InitialResourceState,
            [In, Optional] D3D12_CLEAR_VALUE* pOptimizedClearValue,
            [In, NativeTypeName("REFIID")] Guid* riidResource,
            [Out] void** ppvResource = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateHeap(
            [In] ID3D12Device1* This,
            [In] D3D12_HEAP_DESC* pDesc,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvHeap = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreatePlacedResource(
            [In] ID3D12Device1* This,
            [In] ID3D12Heap* pHeap,
            [In, NativeTypeName("UINT64")] ulong HeapOffset,
            [In] D3D12_RESOURCE_DESC* pDesc,
            [In] D3D12_RESOURCE_STATES InitialState,
            [In, Optional] D3D12_CLEAR_VALUE* pOptimizedClearValue,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvResource = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateReservedResource(
            [In] ID3D12Device1* This,
            [In] D3D12_RESOURCE_DESC* pDesc,
            [In] D3D12_RESOURCE_STATES InitialState,
            [In, Optional] D3D12_CLEAR_VALUE* pOptimizedClearValue,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvResource = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateSharedHandle(
            [In] ID3D12Device1* This,
            [In] ID3D12DeviceChild* pObject,
            [In, Optional] SECURITY_ATTRIBUTES* pAttributes,
            [In, NativeTypeName("DWORD")] uint Access,
            [In, Optional, NativeTypeName("LPCWSTR")] char* Name,
            [Out, NativeTypeName("HANDLE")] IntPtr* pHandle
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _OpenSharedHandle(
            [In] ID3D12Device1* This,
            [In, NativeTypeName("HANDLE")] IntPtr NTHandle,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObj = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _OpenSharedHandleByName(
            [In] ID3D12Device1* This,
            [In, NativeTypeName("LPCWSTR")] char* Name,
            [In, NativeTypeName("DWORD")] uint Access,
            [Out, NativeTypeName("HANDLE")] IntPtr* pNTHandle
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _MakeResident(
            [In] ID3D12Device1* This,
            [In, NativeTypeName("UINT")] uint NumObjects,
            [In, NativeTypeName("ID3D12Pageable*[]")] ID3D12Pageable** ppObjects
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Evict(
            [In] ID3D12Device1* This,
            [In, NativeTypeName("UINT")] uint NumObjects,
            [In, NativeTypeName("ID3D12Pageable*[]")] ID3D12Pageable** ppObjects
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateFence(
            [In] ID3D12Device1* This,
            [In, NativeTypeName("UINT64")] ulong InitialValue,
            [In] D3D12_FENCE_FLAGS Flags,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppFence
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDeviceRemovedReason(
            [In] ID3D12Device1* This

        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _GetCopyableFootprints(
            [In] ID3D12Device1* This,
            [In] D3D12_RESOURCE_DESC* pResourceDesc,
            [In, NativeTypeName("UINT")] uint FirstSubresource,
            [In, NativeTypeName("UINT")] uint NumSubresources,
            [In, NativeTypeName("UINT64")] ulong BaseOffset,
            [Out, NativeTypeName("D3D12_PLACED_SUBRESOURCE_FOOTPRINT[]")] D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts = null,
            [Out, NativeTypeName("UINT[]")] uint* pNumRows = null,
            [Out, NativeTypeName("UINT64[]")] ulong* pRowSizeInBytes = null,
            [Out, NativeTypeName("UINT64")] ulong* pTotalBytes = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateQueryHeap(
            [In] ID3D12Device1* This,
            [In] D3D12_QUERY_HEAP_DESC* pDesc,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvHeap = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetStablePowerState(
            [In] ID3D12Device1* This,
            [In, NativeTypeName("BOOL")] int Enable
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateCommandSignature(
            [In] ID3D12Device1* This,
            [In] D3D12_COMMAND_SIGNATURE_DESC* pDesc,
            [In, Optional] ID3D12RootSignature* pRootSignature,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvCommandSignature = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _GetResourceTiling(
            [In] ID3D12Device1* This,
            [In] ID3D12Resource* pTiledResource,
            [Out, Optional, NativeTypeName("UINT")] uint* pNumTilesForEntireResource,
            [Out, Optional] D3D12_PACKED_MIP_INFO* pPackedMipDesc,
            [Out, Optional] D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips,
            [In, Out, Optional, NativeTypeName("UINT")] uint* pNumSubresourceTilings,
            [In, NativeTypeName("UINT")] uint FirstSubresourceTilingToGet,
            [Out] D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate LUID* _GetAdapterLuid(
            [In] ID3D12Device1* This,
            [Out] LUID* _result
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreatePipelineLibrary(
            [In] ID3D12Device1* This,
            [In] void* pLibraryBlob,
            [In, NativeTypeName("SIZE_T")] UIntPtr BlobLength,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppPipelineLibrary
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetEventOnMultipleFenceCompletion(
            [In] ID3D12Device1* This,
            [In, NativeTypeName("ID3D12Fence*[]")] ID3D12Fence** ppFences,
            [In, NativeTypeName("UINT64[]")] ulong* pFenceValues,
            [In, NativeTypeName("UINT")] uint NumFences,
            [In] D3D12_MULTIPLE_FENCE_WAIT_FLAGS Flags,
            [In, NativeTypeName("HANDLE")] IntPtr hEvent
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetResidencyPriority(
            [In] ID3D12Device1* This,
            [In, NativeTypeName("UINT")] uint NumObjects,
            [In, NativeTypeName("ID3D12Pageable*[]")] ID3D12Pageable** ppObjects,
            [In, NativeTypeName("D3D12_RESIDENCY_PRIORITY[]")] D3D12_RESIDENCY_PRIORITY* pPriorities
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID3D12Device1* This = &this)
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
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12Device1* This = &this)
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
            fixed (ID3D12Device1* This = &this)
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
            fixed (ID3D12Device1* This = &this)
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
            fixed (ID3D12Device1* This = &this)
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
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)(
                    This,
                    Name
                );
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetNodeCount()
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNodeCount>(lpVtbl->GetNodeCount)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandQueue(
            [In] D3D12_COMMAND_QUEUE_DESC* pDesc,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppCommandQueue
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateCommandQueue>(lpVtbl->CreateCommandQueue)(
                    This,
                    pDesc,
                    riid,
                    ppCommandQueue
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandAllocator(
            [In] D3D12_COMMAND_LIST_TYPE Type,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppCommandAllocator
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateCommandAllocator>(lpVtbl->CreateCommandAllocator)(
                    This,
                    Type,
                    riid,
                    ppCommandAllocator
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGraphicsPipelineState(
            [In] D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppPipelineState
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateGraphicsPipelineState>(lpVtbl->CreateGraphicsPipelineState)(
                    This,
                    pDesc,
                    riid,
                    ppPipelineState
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComputePipelineState(
            [In] D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppPipelineState
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateComputePipelineState>(lpVtbl->CreateComputePipelineState)(
                    This,
                    pDesc,
                    riid,
                    ppPipelineState
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandList(
            [In, NativeTypeName("UINT")] uint NodeMask,
            [In] D3D12_COMMAND_LIST_TYPE Type,
            [In] ID3D12CommandAllocator* pCommandAllocator,
            [In, Optional] ID3D12PipelineState* pInitialState,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppCommandList
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateCommandList>(lpVtbl->CreateCommandList)(
                    This,
                    NodeMask,
                    Type,
                    pCommandAllocator,
                    pInitialState,
                    riid,
                    ppCommandList
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(
            [In] D3D12_FEATURE Feature,
            [In, Out] void* pFeatureSupportData,
            [In, NativeTypeName("UINT")] uint FeatureSupportDataSize
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CheckFeatureSupport>(lpVtbl->CheckFeatureSupport)(
                    This,
                    Feature,
                    pFeatureSupportData,
                    FeatureSupportDataSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDescriptorHeap(
            [In] D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvHeap
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDescriptorHeap>(lpVtbl->CreateDescriptorHeap)(
                    This,
                    pDescriptorHeapDesc,
                    riid,
                    ppvHeap
                );
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetDescriptorHandleIncrementSize(
            [In] D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDescriptorHandleIncrementSize>(lpVtbl->GetDescriptorHandleIncrementSize)(
                    This,
                    DescriptorHeapType
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRootSignature(
            [In, NativeTypeName("UINT")] uint NodeMask,
            [In] void* pBlobWithRootSignature,
            [In, NativeTypeName("SIZE_T")] UIntPtr blobLengthInBytes,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvRootSignature
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateRootSignature>(lpVtbl->CreateRootSignature)(
                    This,
                    NodeMask,
                    pBlobWithRootSignature,
                    blobLengthInBytes,
                    riid,
                    ppvRootSignature
                );
            }
        }

        public void CreateConstantBufferView(
            [In, Optional] D3D12_CONSTANT_BUFFER_VIEW_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CreateConstantBufferView>(lpVtbl->CreateConstantBufferView)(
                    This,
                    pDesc,
                    DestDescriptor
                );
            }
        }

        public void CreateShaderResourceView(
            [In, Optional] ID3D12Resource* pResource,
            [In, Optional] D3D12_SHADER_RESOURCE_VIEW_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CreateShaderResourceView>(lpVtbl->CreateShaderResourceView)(
                    This,
                    pResource,
                    pDesc,
                    DestDescriptor
                );
            }
        }

        public void CreateUnorderedAccessView(
            [In, Optional] ID3D12Resource* pResource,
            [In, Optional] ID3D12Resource* pCounterResource,
            [In, Optional] D3D12_UNORDERED_ACCESS_VIEW_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CreateUnorderedAccessView>(lpVtbl->CreateUnorderedAccessView)(
                    This,
                    pResource,
                    pCounterResource,
                    pDesc,
                    DestDescriptor
                );
            }
        }

        public void CreateRenderTargetView(
            [In, Optional] ID3D12Resource* pResource,
            [In, Optional] D3D12_RENDER_TARGET_VIEW_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CreateRenderTargetView>(lpVtbl->CreateRenderTargetView)(
                    This,
                    pResource,
                    pDesc,
                    DestDescriptor
                );
            }
        }

        public void CreateDepthStencilView(
            [In, Optional] ID3D12Resource* pResource,
            [In, Optional] D3D12_DEPTH_STENCIL_VIEW_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CreateDepthStencilView>(lpVtbl->CreateDepthStencilView)(
                    This,
                    pResource,
                    pDesc,
                    DestDescriptor
                );
            }
        }

        public void CreateSampler(
            [In] D3D12_SAMPLER_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CreateSampler>(lpVtbl->CreateSampler)(
                    This,
                    pDesc,
                    DestDescriptor
                );
            }
        }

        public void CopyDescriptors(
            [In, NativeTypeName("UINT")] uint NumDestDescriptorRanges,
            [In, NativeTypeName("D3D12_CPU_DESCRIPTOR_HANDLE[]")] D3D12_CPU_DESCRIPTOR_HANDLE* pDestDescriptorRangeStarts,
            [In, Optional, NativeTypeName("UINT[]")] uint* pDestDescriptorRangeSizes,
            [In, NativeTypeName("UINT")] uint NumSrcDescriptorRanges,
            [In, NativeTypeName("D3D12_CPU_DESCRIPTOR_HANDLE[]")] D3D12_CPU_DESCRIPTOR_HANDLE* pSrcDescriptorRangeStarts,
            [In, Optional, NativeTypeName("UINT[]")] uint* pSrcDescriptorRangeSizes,
            [In] D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CopyDescriptors>(lpVtbl->CopyDescriptors)(
                    This,
                    NumDestDescriptorRanges,
                    pDestDescriptorRangeStarts,
                    pDestDescriptorRangeSizes,
                    NumSrcDescriptorRanges,
                    pSrcDescriptorRangeStarts,
                    pSrcDescriptorRangeSizes,
                    DescriptorHeapsType
                );
            }
        }

        public void CopyDescriptorsSimple(
            [In, NativeTypeName("UINT")] uint NumDescriptors,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart,
            [In] D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CopyDescriptorsSimple>(lpVtbl->CopyDescriptorsSimple)(
                    This,
                    NumDescriptors,
                    DestDescriptorRangeStart,
                    SrcDescriptorRangeStart,
                    DescriptorHeapsType
                );
            }
        }

        public D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo(
            [In, NativeTypeName("UINT")] uint visibleMask,
            [In, NativeTypeName("UINT")] uint numResourceDescs,
            [In] D3D12_RESOURCE_DESC* pResourceDescs
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                D3D12_RESOURCE_ALLOCATION_INFO result;
                return *Marshal.GetDelegateForFunctionPointer<_GetResourceAllocationInfo>(lpVtbl->GetResourceAllocationInfo)(
                    This,
                    &result,
                    visibleMask,
                    numResourceDescs,
                    pResourceDescs
                );
            }
        }

        public D3D12_HEAP_PROPERTIES GetCustomHeapProperties(
            [In, NativeTypeName("UINT")] uint NodeMask,
            [In] D3D12_HEAP_TYPE heapType
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                D3D12_HEAP_PROPERTIES result;
                return *Marshal.GetDelegateForFunctionPointer<_GetCustomHeapProperties>(lpVtbl->GetCustomHeapProperties)(
                    This,
                    &result,
                    NodeMask,
                    heapType
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommittedResource(
            [In] D3D12_HEAP_PROPERTIES* pHeapProperties,
            [In] D3D12_HEAP_FLAGS HeapFlags,
            [In] D3D12_RESOURCE_DESC* pDesc,
            [In] D3D12_RESOURCE_STATES InitialResourceState,
            [In, Optional] D3D12_CLEAR_VALUE* pOptimizedClearValue,
            [In, NativeTypeName("REFIID")] Guid* riidResource,
            [Out] void** ppvResource = null
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateCommittedResource>(lpVtbl->CreateCommittedResource)(
                    This,
                    pHeapProperties,
                    HeapFlags,
                    pDesc,
                    InitialResourceState,
                    pOptimizedClearValue,
                    riidResource,
                    ppvResource
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHeap(
            [In] D3D12_HEAP_DESC* pDesc,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvHeap = null
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateHeap>(lpVtbl->CreateHeap)(
                    This,
                    pDesc,
                    riid,
                    ppvHeap
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePlacedResource(
            [In] ID3D12Heap* pHeap,
            [In, NativeTypeName("UINT64")] ulong HeapOffset,
            [In] D3D12_RESOURCE_DESC* pDesc,
            [In] D3D12_RESOURCE_STATES InitialState,
            [In, Optional] D3D12_CLEAR_VALUE* pOptimizedClearValue,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvResource = null
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePlacedResource>(lpVtbl->CreatePlacedResource)(
                    This,
                    pHeap,
                    HeapOffset,
                    pDesc,
                    InitialState,
                    pOptimizedClearValue,
                    riid,
                    ppvResource
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateReservedResource(
            [In] D3D12_RESOURCE_DESC* pDesc,
            [In] D3D12_RESOURCE_STATES InitialState,
            [In, Optional] D3D12_CLEAR_VALUE* pOptimizedClearValue,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvResource = null
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateReservedResource>(lpVtbl->CreateReservedResource)(
                    This,
                    pDesc,
                    InitialState,
                    pOptimizedClearValue,
                    riid,
                    ppvResource
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSharedHandle(
            [In] ID3D12DeviceChild* pObject,
            [In, Optional] SECURITY_ATTRIBUTES* pAttributes,
            [In, NativeTypeName("DWORD")] uint Access,
            [In, Optional, NativeTypeName("LPCWSTR")] char* Name,
            [Out, NativeTypeName("HANDLE")] IntPtr* pHandle
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSharedHandle>(lpVtbl->CreateSharedHandle)(
                    This,
                    pObject,
                    pAttributes,
                    Access,
                    Name,
                    pHandle
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedHandle(
            [In, NativeTypeName("HANDLE")] IntPtr NTHandle,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObj = null
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_OpenSharedHandle>(lpVtbl->OpenSharedHandle)(
                    This,
                    NTHandle,
                    riid,
                    ppvObj
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedHandleByName(
            [In, NativeTypeName("LPCWSTR")] char* Name,
            [In, NativeTypeName("DWORD")] uint Access,
            [Out, NativeTypeName("HANDLE")] IntPtr* pNTHandle
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_OpenSharedHandleByName>(lpVtbl->OpenSharedHandleByName)(
                    This,
                    Name,
                    Access,
                    pNTHandle
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MakeResident(
            [In, NativeTypeName("UINT")] uint NumObjects,
            [In, NativeTypeName("ID3D12Pageable*[]")] ID3D12Pageable** ppObjects
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MakeResident>(lpVtbl->MakeResident)(
                    This,
                    NumObjects,
                    ppObjects
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Evict(
            [In, NativeTypeName("UINT")] uint NumObjects,
            [In, NativeTypeName("ID3D12Pageable*[]")] ID3D12Pageable** ppObjects
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Evict>(lpVtbl->Evict)(
                    This,
                    NumObjects,
                    ppObjects
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFence(
            [In, NativeTypeName("UINT64")] ulong InitialValue,
            [In] D3D12_FENCE_FLAGS Flags,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppFence
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFence>(lpVtbl->CreateFence)(
                    This,
                    InitialValue,
                    Flags,
                    riid,
                    ppFence
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceRemovedReason()
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDeviceRemovedReason>(lpVtbl->GetDeviceRemovedReason)(
                    This
                );
            }
        }

        public void GetCopyableFootprints(
            [In] D3D12_RESOURCE_DESC* pResourceDesc,
            [In, NativeTypeName("UINT")] uint FirstSubresource,
            [In, NativeTypeName("UINT")] uint NumSubresources,
            [In, NativeTypeName("UINT64")] ulong BaseOffset,
            [Out, NativeTypeName("D3D12_PLACED_SUBRESOURCE_FOOTPRINT[]")] D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts = null,
            [Out, NativeTypeName("UINT[]")] uint* pNumRows = null,
            [Out, NativeTypeName("UINT64[]")] ulong* pRowSizeInBytes = null,
            [Out, NativeTypeName("UINT64")] ulong* pTotalBytes = null
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetCopyableFootprints>(lpVtbl->GetCopyableFootprints)(
                    This,
                    pResourceDesc,
                    FirstSubresource,
                    NumSubresources,
                    BaseOffset,
                    pLayouts,
                    pNumRows,
                    pRowSizeInBytes,
                    pTotalBytes
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryHeap(
            [In] D3D12_QUERY_HEAP_DESC* pDesc,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvHeap = null
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateQueryHeap>(lpVtbl->CreateQueryHeap)(
                    This,
                    pDesc,
                    riid,
                    ppvHeap
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStablePowerState(
            [In, NativeTypeName("BOOL")] int Enable
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetStablePowerState>(lpVtbl->SetStablePowerState)(
                    This,
                    Enable
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandSignature(
            [In] D3D12_COMMAND_SIGNATURE_DESC* pDesc,
            [In, Optional] ID3D12RootSignature* pRootSignature,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvCommandSignature = null
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateCommandSignature>(lpVtbl->CreateCommandSignature)(
                    This,
                    pDesc,
                    pRootSignature,
                    riid,
                    ppvCommandSignature
                );
            }
        }

        public void GetResourceTiling(
            [In] ID3D12Resource* pTiledResource,
            [Out, Optional, NativeTypeName("UINT")] uint* pNumTilesForEntireResource,
            [Out, Optional] D3D12_PACKED_MIP_INFO* pPackedMipDesc,
            [Out, Optional] D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips,
            [In, Out, Optional, NativeTypeName("UINT")] uint* pNumSubresourceTilings,
            [In, NativeTypeName("UINT")] uint FirstSubresourceTilingToGet,
            [Out] D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetResourceTiling>(lpVtbl->GetResourceTiling)(
                    This,
                    pTiledResource,
                    pNumTilesForEntireResource,
                    pPackedMipDesc,
                    pStandardTileShapeForNonPackedMips,
                    pNumSubresourceTilings,
                    FirstSubresourceTilingToGet,
                    pSubresourceTilingsForNonPackedMips
                );
            }
        }

        public LUID GetAdapterLuid()
        {
            fixed (ID3D12Device1* This = &this)
            {
                LUID result;
                return *Marshal.GetDelegateForFunctionPointer<_GetAdapterLuid>(lpVtbl->GetAdapterLuid)(
                    This,
                    &result
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePipelineLibrary(
            [In] void* pLibraryBlob,
            [In, NativeTypeName("SIZE_T")] UIntPtr BlobLength,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppPipelineLibrary
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePipelineLibrary>(lpVtbl->CreatePipelineLibrary)(
                    This,
                    pLibraryBlob,
                    BlobLength,
                    riid,
                    ppPipelineLibrary
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEventOnMultipleFenceCompletion(
            [In, NativeTypeName("ID3D12Fence*[]")] ID3D12Fence** ppFences,
            [In, NativeTypeName("UINT64[]")] ulong* pFenceValues,
            [In, NativeTypeName("UINT")] uint NumFences,
            [In] D3D12_MULTIPLE_FENCE_WAIT_FLAGS Flags,
            [In, NativeTypeName("HANDLE")] IntPtr hEvent
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetEventOnMultipleFenceCompletion>(lpVtbl->SetEventOnMultipleFenceCompletion)(
                    This,
                    ppFences,
                    pFenceValues,
                    NumFences,
                    Flags,
                    hEvent
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResidencyPriority(
            [In, NativeTypeName("UINT")] uint NumObjects,
            [In, NativeTypeName("ID3D12Pageable*[]")] ID3D12Pageable** ppObjects,
            [In, NativeTypeName("D3D12_RESIDENCY_PRIORITY[]")] D3D12_RESIDENCY_PRIORITY* pPriorities
        )
        {
            fixed (ID3D12Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetResidencyPriority>(lpVtbl->SetResidencyPriority)(
                    This,
                    NumObjects,
                    ppObjects,
                    pPriorities
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

            public IntPtr GetNodeCount;

            public IntPtr CreateCommandQueue;

            public IntPtr CreateCommandAllocator;

            public IntPtr CreateGraphicsPipelineState;

            public IntPtr CreateComputePipelineState;

            public IntPtr CreateCommandList;

            public IntPtr CheckFeatureSupport;

            public IntPtr CreateDescriptorHeap;

            public IntPtr GetDescriptorHandleIncrementSize;

            public IntPtr CreateRootSignature;

            public IntPtr CreateConstantBufferView;

            public IntPtr CreateShaderResourceView;

            public IntPtr CreateUnorderedAccessView;

            public IntPtr CreateRenderTargetView;

            public IntPtr CreateDepthStencilView;

            public IntPtr CreateSampler;

            public IntPtr CopyDescriptors;

            public IntPtr CopyDescriptorsSimple;

            public IntPtr GetResourceAllocationInfo;

            public IntPtr GetCustomHeapProperties;

            public IntPtr CreateCommittedResource;

            public IntPtr CreateHeap;

            public IntPtr CreatePlacedResource;

            public IntPtr CreateReservedResource;

            public IntPtr CreateSharedHandle;

            public IntPtr OpenSharedHandle;

            public IntPtr OpenSharedHandleByName;

            public IntPtr MakeResident;

            public IntPtr Evict;

            public IntPtr CreateFence;

            public IntPtr GetDeviceRemovedReason;

            public IntPtr GetCopyableFootprints;

            public IntPtr CreateQueryHeap;

            public IntPtr SetStablePowerState;

            public IntPtr CreateCommandSignature;

            public IntPtr GetResourceTiling;

            public IntPtr GetAdapterLuid;

            public IntPtr CreatePipelineLibrary;

            public IntPtr SetEventOnMultipleFenceCompletion;

            public IntPtr SetResidencyPriority;
        }
    }
}
