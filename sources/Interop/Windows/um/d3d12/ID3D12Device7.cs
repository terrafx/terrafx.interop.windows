// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5C014B53-68A1-4B9B-8BD1-DD6046B9358B")]
    public unsafe partial struct ID3D12Device7
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12Device7* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12Device7* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12Device7* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D12Device7* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D12Device7* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D12Device7* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(ID3D12Device7* pThis, [NativeTypeName("LPCWSTR")] ushort* Name);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetNodeCount(ID3D12Device7* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommandQueue(ID3D12Device7* pThis, [NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] D3D12_COMMAND_QUEUE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandQueue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommandAllocator(ID3D12Device7* pThis, D3D12_COMMAND_LIST_TYPE type, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandAllocator);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGraphicsPipelineState(ID3D12Device7* pThis, [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateComputePipelineState(ID3D12Device7* pThis, [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommandList(ID3D12Device7* pThis, [NativeTypeName("UINT")] uint nodeMask, D3D12_COMMAND_LIST_TYPE type, [NativeTypeName("ID3D12CommandAllocator *")] ID3D12CommandAllocator* pCommandAllocator, [NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pInitialState, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandList);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckFeatureSupport(ID3D12Device7* pThis, D3D12_FEATURE Feature, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDescriptorHeap(ID3D12Device7* pThis, [NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")] D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetDescriptorHandleIncrementSize(ID3D12Device7* pThis, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRootSignature(ID3D12Device7* pThis, [NativeTypeName("UINT")] uint nodeMask, [NativeTypeName("const void *")] void* pBlobWithRootSignature, [NativeTypeName("SIZE_T")] nuint blobLengthInBytes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvRootSignature);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _CreateConstantBufferView(ID3D12Device7* pThis, [NativeTypeName("const D3D12_CONSTANT_BUFFER_VIEW_DESC *")] D3D12_CONSTANT_BUFFER_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _CreateShaderResourceView(ID3D12Device7* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_SHADER_RESOURCE_VIEW_DESC *")] D3D12_SHADER_RESOURCE_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _CreateUnorderedAccessView(ID3D12Device7* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pCounterResource, [NativeTypeName("const D3D12_UNORDERED_ACCESS_VIEW_DESC *")] D3D12_UNORDERED_ACCESS_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _CreateRenderTargetView(ID3D12Device7* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_RENDER_TARGET_VIEW_DESC *")] D3D12_RENDER_TARGET_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _CreateDepthStencilView(ID3D12Device7* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_DEPTH_STENCIL_VIEW_DESC *")] D3D12_DEPTH_STENCIL_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _CreateSampler(ID3D12Device7* pThis, [NativeTypeName("const D3D12_SAMPLER_DESC *")] D3D12_SAMPLER_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _CopyDescriptors(ID3D12Device7* pThis, [NativeTypeName("UINT")] uint NumDestDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pDestDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pDestDescriptorRangeSizes, [NativeTypeName("UINT")] uint NumSrcDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pSrcDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pSrcDescriptorRangeSizes, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _CopyDescriptorsSimple(ID3D12Device7* pThis, [NativeTypeName("UINT")] uint NumDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D3D12_RESOURCE_ALLOCATION_INFO* _GetResourceAllocationInfo(ID3D12Device7* pThis, D3D12_RESOURCE_ALLOCATION_INFO* _result, [NativeTypeName("UINT")] uint visibleMask, [NativeTypeName("UINT")] uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDescs);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D3D12_HEAP_PROPERTIES* _GetCustomHeapProperties(ID3D12Device7* pThis, D3D12_HEAP_PROPERTIES* _result, [NativeTypeName("UINT")] uint nodeMask, D3D12_HEAP_TYPE heapType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommittedResource(ID3D12Device7* pThis, [NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riidResource, [NativeTypeName("void **")] void** ppvResource);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateHeap(ID3D12Device7* pThis, [NativeTypeName("const D3D12_HEAP_DESC *")] D3D12_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePlacedResource(ID3D12Device7* pThis, [NativeTypeName("ID3D12Heap *")] ID3D12Heap* pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvResource);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateReservedResource(ID3D12Device7* pThis, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvResource);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSharedHandle(ID3D12Device7* pThis, [NativeTypeName("ID3D12DeviceChild *")] ID3D12DeviceChild* pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("HANDLE *")] IntPtr* pHandle);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenSharedHandle(ID3D12Device7* pThis, [NativeTypeName("HANDLE")] IntPtr NTHandle, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObj);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenSharedHandleByName(ID3D12Device7* pThis, [NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("HANDLE *")] IntPtr* pNTHandle);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MakeResident(ID3D12Device7* pThis, [NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Evict(ID3D12Device7* pThis, [NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFence(ID3D12Device7* pThis, [NativeTypeName("UINT64")] ulong InitialValue, D3D12_FENCE_FLAGS Flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppFence);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceRemovedReason(ID3D12Device7* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetCopyableFootprints(ID3D12Device7* pThis, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDesc, [NativeTypeName("UINT")] uint FirstSubresource, [NativeTypeName("UINT")] uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, [NativeTypeName("D3D12_PLACED_SUBRESOURCE_FOOTPRINT *")] D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts, [NativeTypeName("UINT *")] uint* pNumRows, [NativeTypeName("UINT64 *")] ulong* pRowSizeInBytes, [NativeTypeName("UINT64 *")] ulong* pTotalBytes);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateQueryHeap(ID3D12Device7* pThis, [NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] D3D12_QUERY_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetStablePowerState(ID3D12Device7* pThis, [NativeTypeName("BOOL")] int Enable);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommandSignature(ID3D12Device7* pThis, [NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")] D3D12_COMMAND_SIGNATURE_DESC* pDesc, [NativeTypeName("ID3D12RootSignature *")] ID3D12RootSignature* pRootSignature, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvCommandSignature);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetResourceTiling(ID3D12Device7* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pTiledResource, [NativeTypeName("UINT *")] uint* pNumTilesForEntireResource, [NativeTypeName("D3D12_PACKED_MIP_INFO *")] D3D12_PACKED_MIP_INFO* pPackedMipDesc, [NativeTypeName("D3D12_TILE_SHAPE *")] D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips, [NativeTypeName("UINT *")] uint* pNumSubresourceTilings, [NativeTypeName("UINT")] uint FirstSubresourceTilingToGet, [NativeTypeName("D3D12_SUBRESOURCE_TILING *")] D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate LUID* _GetAdapterLuid(ID3D12Device7* pThis, LUID* _result);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePipelineLibrary(ID3D12Device7* pThis, [NativeTypeName("const void *")] void* pLibraryBlob, [NativeTypeName("SIZE_T")] nuint BlobLength, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineLibrary);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetEventOnMultipleFenceCompletion(ID3D12Device7* pThis, [NativeTypeName("ID3D12Fence *const *")] ID3D12Fence** ppFences, [NativeTypeName("const UINT64 *")] ulong* pFenceValues, [NativeTypeName("UINT")] uint NumFences, D3D12_MULTIPLE_FENCE_WAIT_FLAGS Flags, [NativeTypeName("HANDLE")] IntPtr hEvent);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetResidencyPriority(ID3D12Device7* pThis, [NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects, [NativeTypeName("const D3D12_RESIDENCY_PRIORITY *")] D3D12_RESIDENCY_PRIORITY* pPriorities);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePipelineState(ID3D12Device7* pThis, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenExistingHeapFromAddress(ID3D12Device7* pThis, [NativeTypeName("const void *")] void* pAddress, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenExistingHeapFromFileMapping(ID3D12Device7* pThis, [NativeTypeName("HANDLE")] IntPtr hFileMapping, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnqueueMakeResident(ID3D12Device7* pThis, D3D12_RESIDENCY_FLAGS Flags, [NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects, [NativeTypeName("ID3D12Fence *")] ID3D12Fence* pFenceToSignal, [NativeTypeName("UINT64")] ulong FenceValueToSignal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommandList1(ID3D12Device7* pThis, [NativeTypeName("UINT")] uint nodeMask, D3D12_COMMAND_LIST_TYPE type, D3D12_COMMAND_LIST_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandList);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateProtectedResourceSession(ID3D12Device7* pThis, [NativeTypeName("const D3D12_PROTECTED_RESOURCE_SESSION_DESC *")] D3D12_PROTECTED_RESOURCE_SESSION_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppSession);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommittedResource1(ID3D12Device7* pThis, [NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedSession, [NativeTypeName("const IID &")] Guid* riidResource, [NativeTypeName("void **")] void** ppvResource);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateHeap1(ID3D12Device7* pThis, [NativeTypeName("const D3D12_HEAP_DESC *")] D3D12_HEAP_DESC* pDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateReservedResource1(ID3D12Device7* pThis, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvResource);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D3D12_RESOURCE_ALLOCATION_INFO* _GetResourceAllocationInfo1(ID3D12Device7* pThis, D3D12_RESOURCE_ALLOCATION_INFO* _result, [NativeTypeName("UINT")] uint visibleMask, [NativeTypeName("UINT")] uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDescs, [NativeTypeName("D3D12_RESOURCE_ALLOCATION_INFO1 *")] D3D12_RESOURCE_ALLOCATION_INFO1* pResourceAllocationInfo1);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateLifetimeTracker(ID3D12Device7* pThis, [NativeTypeName("ID3D12LifetimeOwner *")] ID3D12LifetimeOwner* pOwner, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvTracker);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _RemoveDevice(ID3D12Device7* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumerateMetaCommands(ID3D12Device7* pThis, [NativeTypeName("UINT *")] uint* pNumMetaCommands, [NativeTypeName("D3D12_META_COMMAND_DESC *")] D3D12_META_COMMAND_DESC* pDescs);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumerateMetaCommandParameters(ID3D12Device7* pThis, [NativeTypeName("const GUID &")] Guid* CommandId, D3D12_META_COMMAND_PARAMETER_STAGE Stage, [NativeTypeName("UINT *")] uint* pTotalStructureSizeInBytes, [NativeTypeName("UINT *")] uint* pParameterCount, [NativeTypeName("D3D12_META_COMMAND_PARAMETER_DESC *")] D3D12_META_COMMAND_PARAMETER_DESC* pParameterDescs);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMetaCommand(ID3D12Device7* pThis, [NativeTypeName("const GUID &")] Guid* CommandId, [NativeTypeName("UINT")] uint NodeMask, [NativeTypeName("const void *")] void* pCreationParametersData, [NativeTypeName("SIZE_T")] nuint CreationParametersDataSizeInBytes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppMetaCommand);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStateObject(ID3D12Device7* pThis, [NativeTypeName("const D3D12_STATE_OBJECT_DESC *")] D3D12_STATE_OBJECT_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppStateObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetRaytracingAccelerationStructurePrebuildInfo(ID3D12Device7* pThis, [NativeTypeName("const D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS *")] D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS* pDesc, [NativeTypeName("D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO *")] D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO* pInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS _CheckDriverMatchingIdentifier(ID3D12Device7* pThis, D3D12_SERIALIZED_DATA_TYPE SerializedDataType, [NativeTypeName("const D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER *")] D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER* pIdentifierToCheck);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBackgroundProcessingMode(ID3D12Device7* pThis, D3D12_BACKGROUND_PROCESSING_MODE Mode, D3D12_MEASUREMENTS_ACTION MeasurementsAction, [NativeTypeName("HANDLE")] IntPtr hEventToSignalUponCompletion, [NativeTypeName("BOOL *")] int* pbFurtherMeasurementsDesired);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddToStateObject(ID3D12Device7* pThis, [NativeTypeName("const D3D12_STATE_OBJECT_DESC *")] D3D12_STATE_OBJECT_DESC* pAddition, [NativeTypeName("ID3D12StateObject *")] ID3D12StateObject* pStateObjectToGrowFrom, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppNewStateObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateProtectedResourceSession1(ID3D12Device7* pThis, [NativeTypeName("const D3D12_PROTECTED_RESOURCE_SESSION_DESC1 *")] D3D12_PROTECTED_RESOURCE_SESSION_DESC1* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppSession);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D12Device7*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D12Device7*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D12Device7*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((ID3D12Device7*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((ID3D12Device7*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((ID3D12Device7*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)((ID3D12Device7*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("UINT")]
        public uint GetNodeCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNodeCount>(lpVtbl->GetNodeCount)((ID3D12Device7*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandQueue([NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] D3D12_COMMAND_QUEUE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandQueue)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCommandQueue>(lpVtbl->CreateCommandQueue)((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppCommandQueue);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandAllocator(D3D12_COMMAND_LIST_TYPE type, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandAllocator)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCommandAllocator>(lpVtbl->CreateCommandAllocator)((ID3D12Device7*)Unsafe.AsPointer(ref this), type, riid, ppCommandAllocator);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGraphicsPipelineState([NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateGraphicsPipelineState>(lpVtbl->CreateGraphicsPipelineState)((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComputePipelineState([NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateComputePipelineState>(lpVtbl->CreateComputePipelineState)((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandList([NativeTypeName("UINT")] uint nodeMask, D3D12_COMMAND_LIST_TYPE type, [NativeTypeName("ID3D12CommandAllocator *")] ID3D12CommandAllocator* pCommandAllocator, [NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pInitialState, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandList)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCommandList>(lpVtbl->CreateCommandList)((ID3D12Device7*)Unsafe.AsPointer(ref this), nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D3D12_FEATURE Feature, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckFeatureSupport>(lpVtbl->CheckFeatureSupport)((ID3D12Device7*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDescriptorHeap([NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")] D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDescriptorHeap>(lpVtbl->CreateDescriptorHeap)((ID3D12Device7*)Unsafe.AsPointer(ref this), pDescriptorHeapDesc, riid, ppvHeap);
        }

        [return: NativeTypeName("UINT")]
        public uint GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDescriptorHandleIncrementSize>(lpVtbl->GetDescriptorHandleIncrementSize)((ID3D12Device7*)Unsafe.AsPointer(ref this), DescriptorHeapType);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRootSignature([NativeTypeName("UINT")] uint nodeMask, [NativeTypeName("const void *")] void* pBlobWithRootSignature, [NativeTypeName("SIZE_T")] nuint blobLengthInBytes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvRootSignature)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRootSignature>(lpVtbl->CreateRootSignature)((ID3D12Device7*)Unsafe.AsPointer(ref this), nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
        }

        public void CreateConstantBufferView([NativeTypeName("const D3D12_CONSTANT_BUFFER_VIEW_DESC *")] D3D12_CONSTANT_BUFFER_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            Marshal.GetDelegateForFunctionPointer<_CreateConstantBufferView>(lpVtbl->CreateConstantBufferView)((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
        }

        public void CreateShaderResourceView([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_SHADER_RESOURCE_VIEW_DESC *")] D3D12_SHADER_RESOURCE_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            Marshal.GetDelegateForFunctionPointer<_CreateShaderResourceView>(lpVtbl->CreateShaderResourceView)((ID3D12Device7*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        public void CreateUnorderedAccessView([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pCounterResource, [NativeTypeName("const D3D12_UNORDERED_ACCESS_VIEW_DESC *")] D3D12_UNORDERED_ACCESS_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            Marshal.GetDelegateForFunctionPointer<_CreateUnorderedAccessView>(lpVtbl->CreateUnorderedAccessView)((ID3D12Device7*)Unsafe.AsPointer(ref this), pResource, pCounterResource, pDesc, DestDescriptor);
        }

        public void CreateRenderTargetView([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_RENDER_TARGET_VIEW_DESC *")] D3D12_RENDER_TARGET_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            Marshal.GetDelegateForFunctionPointer<_CreateRenderTargetView>(lpVtbl->CreateRenderTargetView)((ID3D12Device7*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        public void CreateDepthStencilView([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_DEPTH_STENCIL_VIEW_DESC *")] D3D12_DEPTH_STENCIL_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            Marshal.GetDelegateForFunctionPointer<_CreateDepthStencilView>(lpVtbl->CreateDepthStencilView)((ID3D12Device7*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        public void CreateSampler([NativeTypeName("const D3D12_SAMPLER_DESC *")] D3D12_SAMPLER_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            Marshal.GetDelegateForFunctionPointer<_CreateSampler>(lpVtbl->CreateSampler)((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
        }

        public void CopyDescriptors([NativeTypeName("UINT")] uint NumDestDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pDestDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pDestDescriptorRangeSizes, [NativeTypeName("UINT")] uint NumSrcDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pSrcDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pSrcDescriptorRangeSizes, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)
        {
            Marshal.GetDelegateForFunctionPointer<_CopyDescriptors>(lpVtbl->CopyDescriptors)((ID3D12Device7*)Unsafe.AsPointer(ref this), NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }

        public void CopyDescriptorsSimple([NativeTypeName("UINT")] uint NumDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)
        {
            Marshal.GetDelegateForFunctionPointer<_CopyDescriptorsSimple>(lpVtbl->CopyDescriptorsSimple)((ID3D12Device7*)Unsafe.AsPointer(ref this), NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
        }

        public D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo([NativeTypeName("UINT")] uint visibleMask, [NativeTypeName("UINT")] uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDescs)
        {
            D3D12_RESOURCE_ALLOCATION_INFO result;
            return *Marshal.GetDelegateForFunctionPointer<_GetResourceAllocationInfo>(lpVtbl->GetResourceAllocationInfo)((ID3D12Device7*)Unsafe.AsPointer(ref this), &result, visibleMask, numResourceDescs, pResourceDescs);
        }

        public D3D12_HEAP_PROPERTIES GetCustomHeapProperties([NativeTypeName("UINT")] uint nodeMask, D3D12_HEAP_TYPE heapType)
        {
            D3D12_HEAP_PROPERTIES result;
            return *Marshal.GetDelegateForFunctionPointer<_GetCustomHeapProperties>(lpVtbl->GetCustomHeapProperties)((ID3D12Device7*)Unsafe.AsPointer(ref this), &result, nodeMask, heapType);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommittedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riidResource, [NativeTypeName("void **")] void** ppvResource)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCommittedResource>(lpVtbl->CreateCommittedResource)((ID3D12Device7*)Unsafe.AsPointer(ref this), pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHeap([NativeTypeName("const D3D12_HEAP_DESC *")] D3D12_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateHeap>(lpVtbl->CreateHeap)((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePlacedResource([NativeTypeName("ID3D12Heap *")] ID3D12Heap* pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvResource)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreatePlacedResource>(lpVtbl->CreatePlacedResource)((ID3D12Device7*)Unsafe.AsPointer(ref this), pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateReservedResource([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvResource)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateReservedResource>(lpVtbl->CreateReservedResource)((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSharedHandle([NativeTypeName("ID3D12DeviceChild *")] ID3D12DeviceChild* pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("HANDLE *")] IntPtr* pHandle)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSharedHandle>(lpVtbl->CreateSharedHandle)((ID3D12Device7*)Unsafe.AsPointer(ref this), pObject, pAttributes, Access, Name, pHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedHandle([NativeTypeName("HANDLE")] IntPtr NTHandle, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObj)
        {
            return Marshal.GetDelegateForFunctionPointer<_OpenSharedHandle>(lpVtbl->OpenSharedHandle)((ID3D12Device7*)Unsafe.AsPointer(ref this), NTHandle, riid, ppvObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedHandleByName([NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("HANDLE *")] IntPtr* pNTHandle)
        {
            return Marshal.GetDelegateForFunctionPointer<_OpenSharedHandleByName>(lpVtbl->OpenSharedHandleByName)((ID3D12Device7*)Unsafe.AsPointer(ref this), Name, Access, pNTHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int MakeResident([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects)
        {
            return Marshal.GetDelegateForFunctionPointer<_MakeResident>(lpVtbl->MakeResident)((ID3D12Device7*)Unsafe.AsPointer(ref this), NumObjects, ppObjects);
        }

        [return: NativeTypeName("HRESULT")]
        public int Evict([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects)
        {
            return Marshal.GetDelegateForFunctionPointer<_Evict>(lpVtbl->Evict)((ID3D12Device7*)Unsafe.AsPointer(ref this), NumObjects, ppObjects);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFence([NativeTypeName("UINT64")] ulong InitialValue, D3D12_FENCE_FLAGS Flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppFence)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFence>(lpVtbl->CreateFence)((ID3D12Device7*)Unsafe.AsPointer(ref this), InitialValue, Flags, riid, ppFence);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceRemovedReason()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDeviceRemovedReason>(lpVtbl->GetDeviceRemovedReason)((ID3D12Device7*)Unsafe.AsPointer(ref this));
        }

        public void GetCopyableFootprints([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDesc, [NativeTypeName("UINT")] uint FirstSubresource, [NativeTypeName("UINT")] uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, [NativeTypeName("D3D12_PLACED_SUBRESOURCE_FOOTPRINT *")] D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts, [NativeTypeName("UINT *")] uint* pNumRows, [NativeTypeName("UINT64 *")] ulong* pRowSizeInBytes, [NativeTypeName("UINT64 *")] ulong* pTotalBytes)
        {
            Marshal.GetDelegateForFunctionPointer<_GetCopyableFootprints>(lpVtbl->GetCopyableFootprints)((ID3D12Device7*)Unsafe.AsPointer(ref this), pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryHeap([NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] D3D12_QUERY_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateQueryHeap>(lpVtbl->CreateQueryHeap)((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStablePowerState([NativeTypeName("BOOL")] int Enable)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetStablePowerState>(lpVtbl->SetStablePowerState)((ID3D12Device7*)Unsafe.AsPointer(ref this), Enable);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandSignature([NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")] D3D12_COMMAND_SIGNATURE_DESC* pDesc, [NativeTypeName("ID3D12RootSignature *")] ID3D12RootSignature* pRootSignature, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvCommandSignature)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCommandSignature>(lpVtbl->CreateCommandSignature)((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, pRootSignature, riid, ppvCommandSignature);
        }

        public void GetResourceTiling([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pTiledResource, [NativeTypeName("UINT *")] uint* pNumTilesForEntireResource, [NativeTypeName("D3D12_PACKED_MIP_INFO *")] D3D12_PACKED_MIP_INFO* pPackedMipDesc, [NativeTypeName("D3D12_TILE_SHAPE *")] D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips, [NativeTypeName("UINT *")] uint* pNumSubresourceTilings, [NativeTypeName("UINT")] uint FirstSubresourceTilingToGet, [NativeTypeName("D3D12_SUBRESOURCE_TILING *")] D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips)
        {
            Marshal.GetDelegateForFunctionPointer<_GetResourceTiling>(lpVtbl->GetResourceTiling)((ID3D12Device7*)Unsafe.AsPointer(ref this), pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        public LUID GetAdapterLuid()
        {
            LUID result;
            return *Marshal.GetDelegateForFunctionPointer<_GetAdapterLuid>(lpVtbl->GetAdapterLuid)((ID3D12Device7*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePipelineLibrary([NativeTypeName("const void *")] void* pLibraryBlob, [NativeTypeName("SIZE_T")] nuint BlobLength, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineLibrary)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreatePipelineLibrary>(lpVtbl->CreatePipelineLibrary)((ID3D12Device7*)Unsafe.AsPointer(ref this), pLibraryBlob, BlobLength, riid, ppPipelineLibrary);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEventOnMultipleFenceCompletion([NativeTypeName("ID3D12Fence *const *")] ID3D12Fence** ppFences, [NativeTypeName("const UINT64 *")] ulong* pFenceValues, [NativeTypeName("UINT")] uint NumFences, D3D12_MULTIPLE_FENCE_WAIT_FLAGS Flags, [NativeTypeName("HANDLE")] IntPtr hEvent)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetEventOnMultipleFenceCompletion>(lpVtbl->SetEventOnMultipleFenceCompletion)((ID3D12Device7*)Unsafe.AsPointer(ref this), ppFences, pFenceValues, NumFences, Flags, hEvent);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResidencyPriority([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects, [NativeTypeName("const D3D12_RESIDENCY_PRIORITY *")] D3D12_RESIDENCY_PRIORITY* pPriorities)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetResidencyPriority>(lpVtbl->SetResidencyPriority)((ID3D12Device7*)Unsafe.AsPointer(ref this), NumObjects, ppObjects, pPriorities);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePipelineState([NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreatePipelineState>(lpVtbl->CreatePipelineState)((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenExistingHeapFromAddress([NativeTypeName("const void *")] void* pAddress, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return Marshal.GetDelegateForFunctionPointer<_OpenExistingHeapFromAddress>(lpVtbl->OpenExistingHeapFromAddress)((ID3D12Device7*)Unsafe.AsPointer(ref this), pAddress, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenExistingHeapFromFileMapping([NativeTypeName("HANDLE")] IntPtr hFileMapping, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return Marshal.GetDelegateForFunctionPointer<_OpenExistingHeapFromFileMapping>(lpVtbl->OpenExistingHeapFromFileMapping)((ID3D12Device7*)Unsafe.AsPointer(ref this), hFileMapping, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnqueueMakeResident(D3D12_RESIDENCY_FLAGS Flags, [NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects, [NativeTypeName("ID3D12Fence *")] ID3D12Fence* pFenceToSignal, [NativeTypeName("UINT64")] ulong FenceValueToSignal)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnqueueMakeResident>(lpVtbl->EnqueueMakeResident)((ID3D12Device7*)Unsafe.AsPointer(ref this), Flags, NumObjects, ppObjects, pFenceToSignal, FenceValueToSignal);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandList1([NativeTypeName("UINT")] uint nodeMask, D3D12_COMMAND_LIST_TYPE type, D3D12_COMMAND_LIST_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandList)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCommandList1>(lpVtbl->CreateCommandList1)((ID3D12Device7*)Unsafe.AsPointer(ref this), nodeMask, type, flags, riid, ppCommandList);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateProtectedResourceSession([NativeTypeName("const D3D12_PROTECTED_RESOURCE_SESSION_DESC *")] D3D12_PROTECTED_RESOURCE_SESSION_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppSession)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateProtectedResourceSession>(lpVtbl->CreateProtectedResourceSession)((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppSession);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommittedResource1([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedSession, [NativeTypeName("const IID &")] Guid* riidResource, [NativeTypeName("void **")] void** ppvResource)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCommittedResource1>(lpVtbl->CreateCommittedResource1)((ID3D12Device7*)Unsafe.AsPointer(ref this), pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHeap1([NativeTypeName("const D3D12_HEAP_DESC *")] D3D12_HEAP_DESC* pDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateHeap1>(lpVtbl->CreateHeap1)((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, pProtectedSession, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateReservedResource1([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvResource)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateReservedResource1>(lpVtbl->CreateReservedResource1)((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResource);
        }

        public D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo1([NativeTypeName("UINT")] uint visibleMask, [NativeTypeName("UINT")] uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDescs, [NativeTypeName("D3D12_RESOURCE_ALLOCATION_INFO1 *")] D3D12_RESOURCE_ALLOCATION_INFO1* pResourceAllocationInfo1)
        {
            D3D12_RESOURCE_ALLOCATION_INFO result;
            return *Marshal.GetDelegateForFunctionPointer<_GetResourceAllocationInfo1>(lpVtbl->GetResourceAllocationInfo1)((ID3D12Device7*)Unsafe.AsPointer(ref this), &result, visibleMask, numResourceDescs, pResourceDescs, pResourceAllocationInfo1);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLifetimeTracker([NativeTypeName("ID3D12LifetimeOwner *")] ID3D12LifetimeOwner* pOwner, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvTracker)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateLifetimeTracker>(lpVtbl->CreateLifetimeTracker)((ID3D12Device7*)Unsafe.AsPointer(ref this), pOwner, riid, ppvTracker);
        }

        public void RemoveDevice()
        {
            Marshal.GetDelegateForFunctionPointer<_RemoveDevice>(lpVtbl->RemoveDevice)((ID3D12Device7*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumerateMetaCommands([NativeTypeName("UINT *")] uint* pNumMetaCommands, [NativeTypeName("D3D12_META_COMMAND_DESC *")] D3D12_META_COMMAND_DESC* pDescs)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumerateMetaCommands>(lpVtbl->EnumerateMetaCommands)((ID3D12Device7*)Unsafe.AsPointer(ref this), pNumMetaCommands, pDescs);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumerateMetaCommandParameters([NativeTypeName("const GUID &")] Guid* CommandId, D3D12_META_COMMAND_PARAMETER_STAGE Stage, [NativeTypeName("UINT *")] uint* pTotalStructureSizeInBytes, [NativeTypeName("UINT *")] uint* pParameterCount, [NativeTypeName("D3D12_META_COMMAND_PARAMETER_DESC *")] D3D12_META_COMMAND_PARAMETER_DESC* pParameterDescs)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumerateMetaCommandParameters>(lpVtbl->EnumerateMetaCommandParameters)((ID3D12Device7*)Unsafe.AsPointer(ref this), CommandId, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescs);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMetaCommand([NativeTypeName("const GUID &")] Guid* CommandId, [NativeTypeName("UINT")] uint NodeMask, [NativeTypeName("const void *")] void* pCreationParametersData, [NativeTypeName("SIZE_T")] nuint CreationParametersDataSizeInBytes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppMetaCommand)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateMetaCommand>(lpVtbl->CreateMetaCommand)((ID3D12Device7*)Unsafe.AsPointer(ref this), CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStateObject([NativeTypeName("const D3D12_STATE_OBJECT_DESC *")] D3D12_STATE_OBJECT_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppStateObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateStateObject>(lpVtbl->CreateStateObject)((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppStateObject);
        }

        public void GetRaytracingAccelerationStructurePrebuildInfo([NativeTypeName("const D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS *")] D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS* pDesc, [NativeTypeName("D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO *")] D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO* pInfo)
        {
            Marshal.GetDelegateForFunctionPointer<_GetRaytracingAccelerationStructurePrebuildInfo>(lpVtbl->GetRaytracingAccelerationStructurePrebuildInfo)((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, pInfo);
        }

        public D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS CheckDriverMatchingIdentifier(D3D12_SERIALIZED_DATA_TYPE SerializedDataType, [NativeTypeName("const D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER *")] D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER* pIdentifierToCheck)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckDriverMatchingIdentifier>(lpVtbl->CheckDriverMatchingIdentifier)((ID3D12Device7*)Unsafe.AsPointer(ref this), SerializedDataType, pIdentifierToCheck);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBackgroundProcessingMode(D3D12_BACKGROUND_PROCESSING_MODE Mode, D3D12_MEASUREMENTS_ACTION MeasurementsAction, [NativeTypeName("HANDLE")] IntPtr hEventToSignalUponCompletion, [NativeTypeName("BOOL *")] int* pbFurtherMeasurementsDesired)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBackgroundProcessingMode>(lpVtbl->SetBackgroundProcessingMode)((ID3D12Device7*)Unsafe.AsPointer(ref this), Mode, MeasurementsAction, hEventToSignalUponCompletion, pbFurtherMeasurementsDesired);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddToStateObject([NativeTypeName("const D3D12_STATE_OBJECT_DESC *")] D3D12_STATE_OBJECT_DESC* pAddition, [NativeTypeName("ID3D12StateObject *")] ID3D12StateObject* pStateObjectToGrowFrom, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppNewStateObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddToStateObject>(lpVtbl->AddToStateObject)((ID3D12Device7*)Unsafe.AsPointer(ref this), pAddition, pStateObjectToGrowFrom, riid, ppNewStateObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateProtectedResourceSession1([NativeTypeName("const D3D12_PROTECTED_RESOURCE_SESSION_DESC1 *")] D3D12_PROTECTED_RESOURCE_SESSION_DESC1* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppSession)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateProtectedResourceSession1>(lpVtbl->CreateProtectedResourceSession1)((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppSession);
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

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public IntPtr GetNodeCount;

            [NativeTypeName("HRESULT (const D3D12_COMMAND_QUEUE_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateCommandQueue;

            [NativeTypeName("HRESULT (D3D12_COMMAND_LIST_TYPE, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateCommandAllocator;

            [NativeTypeName("HRESULT (const D3D12_GRAPHICS_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateGraphicsPipelineState;

            [NativeTypeName("HRESULT (const D3D12_COMPUTE_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateComputePipelineState;

            [NativeTypeName("HRESULT (UINT, D3D12_COMMAND_LIST_TYPE, ID3D12CommandAllocator *, ID3D12PipelineState *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateCommandList;

            [NativeTypeName("HRESULT (D3D12_FEATURE, void *, UINT) __attribute__((stdcall))")]
            public IntPtr CheckFeatureSupport;

            [NativeTypeName("HRESULT (const D3D12_DESCRIPTOR_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateDescriptorHeap;

            [NativeTypeName("UINT (D3D12_DESCRIPTOR_HEAP_TYPE) __attribute__((stdcall))")]
            public IntPtr GetDescriptorHandleIncrementSize;

            [NativeTypeName("HRESULT (UINT, const void *, SIZE_T, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateRootSignature;

            [NativeTypeName("void (const D3D12_CONSTANT_BUFFER_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public IntPtr CreateConstantBufferView;

            [NativeTypeName("void (ID3D12Resource *, const D3D12_SHADER_RESOURCE_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public IntPtr CreateShaderResourceView;

            [NativeTypeName("void (ID3D12Resource *, ID3D12Resource *, const D3D12_UNORDERED_ACCESS_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public IntPtr CreateUnorderedAccessView;

            [NativeTypeName("void (ID3D12Resource *, const D3D12_RENDER_TARGET_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public IntPtr CreateRenderTargetView;

            [NativeTypeName("void (ID3D12Resource *, const D3D12_DEPTH_STENCIL_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public IntPtr CreateDepthStencilView;

            [NativeTypeName("void (const D3D12_SAMPLER_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public IntPtr CreateSampler;

            [NativeTypeName("void (UINT, const D3D12_CPU_DESCRIPTOR_HANDLE *, const UINT *, UINT, const D3D12_CPU_DESCRIPTOR_HANDLE *, const UINT *, D3D12_DESCRIPTOR_HEAP_TYPE) __attribute__((stdcall))")]
            public IntPtr CopyDescriptors;

            [NativeTypeName("void (UINT, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_DESCRIPTOR_HEAP_TYPE) __attribute__((stdcall))")]
            public IntPtr CopyDescriptorsSimple;

            [NativeTypeName("D3D12_RESOURCE_ALLOCATION_INFO (UINT, UINT, const D3D12_RESOURCE_DESC *) __attribute__((stdcall))")]
            public IntPtr GetResourceAllocationInfo;

            [NativeTypeName("D3D12_HEAP_PROPERTIES (UINT, D3D12_HEAP_TYPE) __attribute__((stdcall))")]
            public IntPtr GetCustomHeapProperties;

            [NativeTypeName("HRESULT (const D3D12_HEAP_PROPERTIES *, D3D12_HEAP_FLAGS, const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateCommittedResource;

            [NativeTypeName("HRESULT (const D3D12_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateHeap;

            [NativeTypeName("HRESULT (ID3D12Heap *, UINT64, const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreatePlacedResource;

            [NativeTypeName("HRESULT (const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateReservedResource;

            [NativeTypeName("HRESULT (ID3D12DeviceChild *, const SECURITY_ATTRIBUTES *, DWORD, LPCWSTR, HANDLE *) __attribute__((stdcall))")]
            public IntPtr CreateSharedHandle;

            [NativeTypeName("HRESULT (HANDLE, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr OpenSharedHandle;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, HANDLE *) __attribute__((stdcall))")]
            public IntPtr OpenSharedHandleByName;

            [NativeTypeName("HRESULT (UINT, ID3D12Pageable *const *) __attribute__((stdcall))")]
            public IntPtr MakeResident;

            [NativeTypeName("HRESULT (UINT, ID3D12Pageable *const *) __attribute__((stdcall))")]
            public IntPtr Evict;

            [NativeTypeName("HRESULT (UINT64, D3D12_FENCE_FLAGS, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateFence;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr GetDeviceRemovedReason;

            [NativeTypeName("void (const D3D12_RESOURCE_DESC *, UINT, UINT, UINT64, D3D12_PLACED_SUBRESOURCE_FOOTPRINT *, UINT *, UINT64 *, UINT64 *) __attribute__((stdcall))")]
            public IntPtr GetCopyableFootprints;

            [NativeTypeName("HRESULT (const D3D12_QUERY_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateQueryHeap;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr SetStablePowerState;

            [NativeTypeName("HRESULT (const D3D12_COMMAND_SIGNATURE_DESC *, ID3D12RootSignature *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateCommandSignature;

            [NativeTypeName("void (ID3D12Resource *, UINT *, D3D12_PACKED_MIP_INFO *, D3D12_TILE_SHAPE *, UINT *, UINT, D3D12_SUBRESOURCE_TILING *) __attribute__((stdcall))")]
            public IntPtr GetResourceTiling;

            [NativeTypeName("LUID () __attribute__((stdcall))")]
            public IntPtr GetAdapterLuid;

            [NativeTypeName("HRESULT (const void *, SIZE_T, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreatePipelineLibrary;

            [NativeTypeName("HRESULT (ID3D12Fence *const *, const UINT64 *, UINT, D3D12_MULTIPLE_FENCE_WAIT_FLAGS, HANDLE) __attribute__((stdcall))")]
            public IntPtr SetEventOnMultipleFenceCompletion;

            [NativeTypeName("HRESULT (UINT, ID3D12Pageable *const *, const D3D12_RESIDENCY_PRIORITY *) __attribute__((stdcall))")]
            public IntPtr SetResidencyPriority;

            [NativeTypeName("HRESULT (const D3D12_PIPELINE_STATE_STREAM_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreatePipelineState;

            [NativeTypeName("HRESULT (const void *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr OpenExistingHeapFromAddress;

            [NativeTypeName("HRESULT (HANDLE, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr OpenExistingHeapFromFileMapping;

            [NativeTypeName("HRESULT (D3D12_RESIDENCY_FLAGS, UINT, ID3D12Pageable *const *, ID3D12Fence *, UINT64) __attribute__((stdcall))")]
            public IntPtr EnqueueMakeResident;

            [NativeTypeName("HRESULT (UINT, D3D12_COMMAND_LIST_TYPE, D3D12_COMMAND_LIST_FLAGS, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateCommandList1;

            [NativeTypeName("HRESULT (const D3D12_PROTECTED_RESOURCE_SESSION_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateProtectedResourceSession;

            [NativeTypeName("HRESULT (const D3D12_HEAP_PROPERTIES *, D3D12_HEAP_FLAGS, const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateCommittedResource1;

            [NativeTypeName("HRESULT (const D3D12_HEAP_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateHeap1;

            [NativeTypeName("HRESULT (const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateReservedResource1;

            [NativeTypeName("D3D12_RESOURCE_ALLOCATION_INFO (UINT, UINT, const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_ALLOCATION_INFO1 *) __attribute__((stdcall))")]
            public IntPtr GetResourceAllocationInfo1;

            [NativeTypeName("HRESULT (ID3D12LifetimeOwner *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateLifetimeTracker;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr RemoveDevice;

            [NativeTypeName("HRESULT (UINT *, D3D12_META_COMMAND_DESC *) __attribute__((stdcall))")]
            public IntPtr EnumerateMetaCommands;

            [NativeTypeName("HRESULT (const GUID &, D3D12_META_COMMAND_PARAMETER_STAGE, UINT *, UINT *, D3D12_META_COMMAND_PARAMETER_DESC *) __attribute__((stdcall))")]
            public IntPtr EnumerateMetaCommandParameters;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *, SIZE_T, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateMetaCommand;

            [NativeTypeName("HRESULT (const D3D12_STATE_OBJECT_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateStateObject;

            [NativeTypeName("void (const D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS *, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO *) __attribute__((stdcall))")]
            public IntPtr GetRaytracingAccelerationStructurePrebuildInfo;

            [NativeTypeName("D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS (D3D12_SERIALIZED_DATA_TYPE, const D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER *) __attribute__((stdcall))")]
            public IntPtr CheckDriverMatchingIdentifier;

            [NativeTypeName("HRESULT (D3D12_BACKGROUND_PROCESSING_MODE, D3D12_MEASUREMENTS_ACTION, HANDLE, BOOL *) __attribute__((stdcall))")]
            public IntPtr SetBackgroundProcessingMode;

            [NativeTypeName("HRESULT (const D3D12_STATE_OBJECT_DESC *, ID3D12StateObject *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr AddToStateObject;

            [NativeTypeName("HRESULT (const D3D12_PROTECTED_RESOURCE_SESSION_DESC1 *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateProtectedResourceSession1;
        }
    }
}
