// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("81DADC15-2BAD-4392-93C5-101345C4AA98")]
    public unsafe partial struct ID3D12Device3
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12Device3* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12Device3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12Device3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D12Device3* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D12Device3* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D12Device3* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(ID3D12Device3* pThis, [NativeTypeName("LPCWSTR")] ushort* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetNodeCount(ID3D12Device3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommandQueue(ID3D12Device3* pThis, [NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] D3D12_COMMAND_QUEUE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandQueue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommandAllocator(ID3D12Device3* pThis, D3D12_COMMAND_LIST_TYPE type, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandAllocator);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGraphicsPipelineState(ID3D12Device3* pThis, [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateComputePipelineState(ID3D12Device3* pThis, [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommandList(ID3D12Device3* pThis, [NativeTypeName("UINT")] uint nodeMask, D3D12_COMMAND_LIST_TYPE type, [NativeTypeName("ID3D12CommandAllocator *")] ID3D12CommandAllocator* pCommandAllocator, [NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pInitialState, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandList);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckFeatureSupport(ID3D12Device3* pThis, D3D12_FEATURE Feature, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDescriptorHeap(ID3D12Device3* pThis, [NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")] D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetDescriptorHandleIncrementSize(ID3D12Device3* pThis, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRootSignature(ID3D12Device3* pThis, [NativeTypeName("UINT")] uint nodeMask, [NativeTypeName("const void *")] void* pBlobWithRootSignature, [NativeTypeName("SIZE_T")] UIntPtr blobLengthInBytes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvRootSignature);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CreateConstantBufferView(ID3D12Device3* pThis, [NativeTypeName("const D3D12_CONSTANT_BUFFER_VIEW_DESC *")] D3D12_CONSTANT_BUFFER_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CreateShaderResourceView(ID3D12Device3* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_SHADER_RESOURCE_VIEW_DESC *")] D3D12_SHADER_RESOURCE_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CreateUnorderedAccessView(ID3D12Device3* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pCounterResource, [NativeTypeName("const D3D12_UNORDERED_ACCESS_VIEW_DESC *")] D3D12_UNORDERED_ACCESS_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CreateRenderTargetView(ID3D12Device3* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_RENDER_TARGET_VIEW_DESC *")] D3D12_RENDER_TARGET_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CreateDepthStencilView(ID3D12Device3* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_DEPTH_STENCIL_VIEW_DESC *")] D3D12_DEPTH_STENCIL_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CreateSampler(ID3D12Device3* pThis, [NativeTypeName("const D3D12_SAMPLER_DESC *")] D3D12_SAMPLER_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopyDescriptors(ID3D12Device3* pThis, [NativeTypeName("UINT")] uint NumDestDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pDestDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pDestDescriptorRangeSizes, [NativeTypeName("UINT")] uint NumSrcDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pSrcDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pSrcDescriptorRangeSizes, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopyDescriptorsSimple(ID3D12Device3* pThis, [NativeTypeName("UINT")] uint NumDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D12_RESOURCE_ALLOCATION_INFO* _GetResourceAllocationInfo(ID3D12Device3* pThis, D3D12_RESOURCE_ALLOCATION_INFO* _result, [NativeTypeName("UINT")] uint visibleMask, [NativeTypeName("UINT")] uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDescs);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D12_HEAP_PROPERTIES* _GetCustomHeapProperties(ID3D12Device3* pThis, D3D12_HEAP_PROPERTIES* _result, [NativeTypeName("UINT")] uint nodeMask, D3D12_HEAP_TYPE heapType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommittedResource(ID3D12Device3* pThis, [NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riidResource, [NativeTypeName("void **")] void** ppvResource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateHeap(ID3D12Device3* pThis, [NativeTypeName("const D3D12_HEAP_DESC *")] D3D12_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePlacedResource(ID3D12Device3* pThis, [NativeTypeName("ID3D12Heap *")] ID3D12Heap* pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvResource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateReservedResource(ID3D12Device3* pThis, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvResource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSharedHandle(ID3D12Device3* pThis, [NativeTypeName("ID3D12DeviceChild *")] ID3D12DeviceChild* pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("HANDLE *")] IntPtr* pHandle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenSharedHandle(ID3D12Device3* pThis, [NativeTypeName("HANDLE")] IntPtr NTHandle, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObj);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenSharedHandleByName(ID3D12Device3* pThis, [NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("HANDLE *")] IntPtr* pNTHandle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MakeResident(ID3D12Device3* pThis, [NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Evict(ID3D12Device3* pThis, [NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFence(ID3D12Device3* pThis, [NativeTypeName("UINT64")] ulong InitialValue, D3D12_FENCE_FLAGS Flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppFence);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceRemovedReason(ID3D12Device3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetCopyableFootprints(ID3D12Device3* pThis, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDesc, [NativeTypeName("UINT")] uint FirstSubresource, [NativeTypeName("UINT")] uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, [NativeTypeName("D3D12_PLACED_SUBRESOURCE_FOOTPRINT *")] D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts, [NativeTypeName("UINT *")] uint* pNumRows, [NativeTypeName("UINT64 *")] ulong* pRowSizeInBytes, [NativeTypeName("UINT64 *")] ulong* pTotalBytes);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateQueryHeap(ID3D12Device3* pThis, [NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] D3D12_QUERY_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetStablePowerState(ID3D12Device3* pThis, [NativeTypeName("BOOL")] int Enable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommandSignature(ID3D12Device3* pThis, [NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")] D3D12_COMMAND_SIGNATURE_DESC* pDesc, [NativeTypeName("ID3D12RootSignature *")] ID3D12RootSignature* pRootSignature, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvCommandSignature);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetResourceTiling(ID3D12Device3* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pTiledResource, [NativeTypeName("UINT *")] uint* pNumTilesForEntireResource, [NativeTypeName("D3D12_PACKED_MIP_INFO *")] D3D12_PACKED_MIP_INFO* pPackedMipDesc, [NativeTypeName("D3D12_TILE_SHAPE *")] D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips, [NativeTypeName("UINT *")] uint* pNumSubresourceTilings, [NativeTypeName("UINT")] uint FirstSubresourceTilingToGet, [NativeTypeName("D3D12_SUBRESOURCE_TILING *")] D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate LUID* _GetAdapterLuid(ID3D12Device3* pThis, LUID* _result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePipelineLibrary(ID3D12Device3* pThis, [NativeTypeName("const void *")] void* pLibraryBlob, [NativeTypeName("SIZE_T")] UIntPtr BlobLength, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineLibrary);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetEventOnMultipleFenceCompletion(ID3D12Device3* pThis, [NativeTypeName("ID3D12Fence *const *")] ID3D12Fence** ppFences, [NativeTypeName("const UINT64 *")] ulong* pFenceValues, [NativeTypeName("UINT")] uint NumFences, D3D12_MULTIPLE_FENCE_WAIT_FLAGS Flags, [NativeTypeName("HANDLE")] IntPtr hEvent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetResidencyPriority(ID3D12Device3* pThis, [NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects, [NativeTypeName("const D3D12_RESIDENCY_PRIORITY *")] D3D12_RESIDENCY_PRIORITY* pPriorities);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePipelineState(ID3D12Device3* pThis, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenExistingHeapFromAddress(ID3D12Device3* pThis, [NativeTypeName("const void *")] void* pAddress, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenExistingHeapFromFileMapping(ID3D12Device3* pThis, [NativeTypeName("HANDLE")] IntPtr hFileMapping, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnqueueMakeResident(ID3D12Device3* pThis, D3D12_RESIDENCY_FLAGS Flags, [NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects, [NativeTypeName("ID3D12Fence *")] ID3D12Fence* pFenceToSignal, [NativeTypeName("UINT64")] ulong FenceValueToSignal);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D12Device3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D12Device3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D12Device3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((ID3D12Device3*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((ID3D12Device3*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((ID3D12Device3*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)((ID3D12Device3*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("UINT")]
        public uint GetNodeCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNodeCount>(lpVtbl->GetNodeCount)((ID3D12Device3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandQueue([NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] D3D12_COMMAND_QUEUE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandQueue)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCommandQueue>(lpVtbl->CreateCommandQueue)((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, riid, ppCommandQueue);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandAllocator(D3D12_COMMAND_LIST_TYPE type, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandAllocator)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCommandAllocator>(lpVtbl->CreateCommandAllocator)((ID3D12Device3*)Unsafe.AsPointer(ref this), type, riid, ppCommandAllocator);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGraphicsPipelineState([NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateGraphicsPipelineState>(lpVtbl->CreateGraphicsPipelineState)((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComputePipelineState([NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateComputePipelineState>(lpVtbl->CreateComputePipelineState)((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandList([NativeTypeName("UINT")] uint nodeMask, D3D12_COMMAND_LIST_TYPE type, [NativeTypeName("ID3D12CommandAllocator *")] ID3D12CommandAllocator* pCommandAllocator, [NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pInitialState, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandList)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCommandList>(lpVtbl->CreateCommandList)((ID3D12Device3*)Unsafe.AsPointer(ref this), nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D3D12_FEATURE Feature, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckFeatureSupport>(lpVtbl->CheckFeatureSupport)((ID3D12Device3*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDescriptorHeap([NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")] D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDescriptorHeap>(lpVtbl->CreateDescriptorHeap)((ID3D12Device3*)Unsafe.AsPointer(ref this), pDescriptorHeapDesc, riid, ppvHeap);
        }

        [return: NativeTypeName("UINT")]
        public uint GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDescriptorHandleIncrementSize>(lpVtbl->GetDescriptorHandleIncrementSize)((ID3D12Device3*)Unsafe.AsPointer(ref this), DescriptorHeapType);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRootSignature([NativeTypeName("UINT")] uint nodeMask, [NativeTypeName("const void *")] void* pBlobWithRootSignature, [NativeTypeName("SIZE_T")] UIntPtr blobLengthInBytes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvRootSignature)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRootSignature>(lpVtbl->CreateRootSignature)((ID3D12Device3*)Unsafe.AsPointer(ref this), nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
        }

        public void CreateConstantBufferView([NativeTypeName("const D3D12_CONSTANT_BUFFER_VIEW_DESC *")] D3D12_CONSTANT_BUFFER_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            Marshal.GetDelegateForFunctionPointer<_CreateConstantBufferView>(lpVtbl->CreateConstantBufferView)((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
        }

        public void CreateShaderResourceView([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_SHADER_RESOURCE_VIEW_DESC *")] D3D12_SHADER_RESOURCE_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            Marshal.GetDelegateForFunctionPointer<_CreateShaderResourceView>(lpVtbl->CreateShaderResourceView)((ID3D12Device3*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        public void CreateUnorderedAccessView([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pCounterResource, [NativeTypeName("const D3D12_UNORDERED_ACCESS_VIEW_DESC *")] D3D12_UNORDERED_ACCESS_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            Marshal.GetDelegateForFunctionPointer<_CreateUnorderedAccessView>(lpVtbl->CreateUnorderedAccessView)((ID3D12Device3*)Unsafe.AsPointer(ref this), pResource, pCounterResource, pDesc, DestDescriptor);
        }

        public void CreateRenderTargetView([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_RENDER_TARGET_VIEW_DESC *")] D3D12_RENDER_TARGET_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            Marshal.GetDelegateForFunctionPointer<_CreateRenderTargetView>(lpVtbl->CreateRenderTargetView)((ID3D12Device3*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        public void CreateDepthStencilView([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_DEPTH_STENCIL_VIEW_DESC *")] D3D12_DEPTH_STENCIL_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            Marshal.GetDelegateForFunctionPointer<_CreateDepthStencilView>(lpVtbl->CreateDepthStencilView)((ID3D12Device3*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        public void CreateSampler([NativeTypeName("const D3D12_SAMPLER_DESC *")] D3D12_SAMPLER_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            Marshal.GetDelegateForFunctionPointer<_CreateSampler>(lpVtbl->CreateSampler)((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
        }

        public void CopyDescriptors([NativeTypeName("UINT")] uint NumDestDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pDestDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pDestDescriptorRangeSizes, [NativeTypeName("UINT")] uint NumSrcDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pSrcDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pSrcDescriptorRangeSizes, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)
        {
            Marshal.GetDelegateForFunctionPointer<_CopyDescriptors>(lpVtbl->CopyDescriptors)((ID3D12Device3*)Unsafe.AsPointer(ref this), NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }

        public void CopyDescriptorsSimple([NativeTypeName("UINT")] uint NumDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)
        {
            Marshal.GetDelegateForFunctionPointer<_CopyDescriptorsSimple>(lpVtbl->CopyDescriptorsSimple)((ID3D12Device3*)Unsafe.AsPointer(ref this), NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
        }

        public D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo([NativeTypeName("UINT")] uint visibleMask, [NativeTypeName("UINT")] uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDescs)
        {
            D3D12_RESOURCE_ALLOCATION_INFO result;
            return *Marshal.GetDelegateForFunctionPointer<_GetResourceAllocationInfo>(lpVtbl->GetResourceAllocationInfo)((ID3D12Device3*)Unsafe.AsPointer(ref this), &result, visibleMask, numResourceDescs, pResourceDescs);
        }

        public D3D12_HEAP_PROPERTIES GetCustomHeapProperties([NativeTypeName("UINT")] uint nodeMask, D3D12_HEAP_TYPE heapType)
        {
            D3D12_HEAP_PROPERTIES result;
            return *Marshal.GetDelegateForFunctionPointer<_GetCustomHeapProperties>(lpVtbl->GetCustomHeapProperties)((ID3D12Device3*)Unsafe.AsPointer(ref this), &result, nodeMask, heapType);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommittedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riidResource, [NativeTypeName("void **")] void** ppvResource)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCommittedResource>(lpVtbl->CreateCommittedResource)((ID3D12Device3*)Unsafe.AsPointer(ref this), pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHeap([NativeTypeName("const D3D12_HEAP_DESC *")] D3D12_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateHeap>(lpVtbl->CreateHeap)((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePlacedResource([NativeTypeName("ID3D12Heap *")] ID3D12Heap* pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvResource)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreatePlacedResource>(lpVtbl->CreatePlacedResource)((ID3D12Device3*)Unsafe.AsPointer(ref this), pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateReservedResource([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvResource)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateReservedResource>(lpVtbl->CreateReservedResource)((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSharedHandle([NativeTypeName("ID3D12DeviceChild *")] ID3D12DeviceChild* pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("HANDLE *")] IntPtr* pHandle)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSharedHandle>(lpVtbl->CreateSharedHandle)((ID3D12Device3*)Unsafe.AsPointer(ref this), pObject, pAttributes, Access, Name, pHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedHandle([NativeTypeName("HANDLE")] IntPtr NTHandle, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObj)
        {
            return Marshal.GetDelegateForFunctionPointer<_OpenSharedHandle>(lpVtbl->OpenSharedHandle)((ID3D12Device3*)Unsafe.AsPointer(ref this), NTHandle, riid, ppvObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedHandleByName([NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("HANDLE *")] IntPtr* pNTHandle)
        {
            return Marshal.GetDelegateForFunctionPointer<_OpenSharedHandleByName>(lpVtbl->OpenSharedHandleByName)((ID3D12Device3*)Unsafe.AsPointer(ref this), Name, Access, pNTHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int MakeResident([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects)
        {
            return Marshal.GetDelegateForFunctionPointer<_MakeResident>(lpVtbl->MakeResident)((ID3D12Device3*)Unsafe.AsPointer(ref this), NumObjects, ppObjects);
        }

        [return: NativeTypeName("HRESULT")]
        public int Evict([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects)
        {
            return Marshal.GetDelegateForFunctionPointer<_Evict>(lpVtbl->Evict)((ID3D12Device3*)Unsafe.AsPointer(ref this), NumObjects, ppObjects);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFence([NativeTypeName("UINT64")] ulong InitialValue, D3D12_FENCE_FLAGS Flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppFence)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFence>(lpVtbl->CreateFence)((ID3D12Device3*)Unsafe.AsPointer(ref this), InitialValue, Flags, riid, ppFence);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceRemovedReason()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDeviceRemovedReason>(lpVtbl->GetDeviceRemovedReason)((ID3D12Device3*)Unsafe.AsPointer(ref this));
        }

        public void GetCopyableFootprints([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDesc, [NativeTypeName("UINT")] uint FirstSubresource, [NativeTypeName("UINT")] uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, [NativeTypeName("D3D12_PLACED_SUBRESOURCE_FOOTPRINT *")] D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts, [NativeTypeName("UINT *")] uint* pNumRows, [NativeTypeName("UINT64 *")] ulong* pRowSizeInBytes, [NativeTypeName("UINT64 *")] ulong* pTotalBytes)
        {
            Marshal.GetDelegateForFunctionPointer<_GetCopyableFootprints>(lpVtbl->GetCopyableFootprints)((ID3D12Device3*)Unsafe.AsPointer(ref this), pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryHeap([NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] D3D12_QUERY_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateQueryHeap>(lpVtbl->CreateQueryHeap)((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStablePowerState([NativeTypeName("BOOL")] int Enable)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetStablePowerState>(lpVtbl->SetStablePowerState)((ID3D12Device3*)Unsafe.AsPointer(ref this), Enable);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandSignature([NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")] D3D12_COMMAND_SIGNATURE_DESC* pDesc, [NativeTypeName("ID3D12RootSignature *")] ID3D12RootSignature* pRootSignature, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvCommandSignature)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCommandSignature>(lpVtbl->CreateCommandSignature)((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, pRootSignature, riid, ppvCommandSignature);
        }

        public void GetResourceTiling([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pTiledResource, [NativeTypeName("UINT *")] uint* pNumTilesForEntireResource, [NativeTypeName("D3D12_PACKED_MIP_INFO *")] D3D12_PACKED_MIP_INFO* pPackedMipDesc, [NativeTypeName("D3D12_TILE_SHAPE *")] D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips, [NativeTypeName("UINT *")] uint* pNumSubresourceTilings, [NativeTypeName("UINT")] uint FirstSubresourceTilingToGet, [NativeTypeName("D3D12_SUBRESOURCE_TILING *")] D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips)
        {
            Marshal.GetDelegateForFunctionPointer<_GetResourceTiling>(lpVtbl->GetResourceTiling)((ID3D12Device3*)Unsafe.AsPointer(ref this), pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        public LUID GetAdapterLuid()
        {
            LUID result;
            return *Marshal.GetDelegateForFunctionPointer<_GetAdapterLuid>(lpVtbl->GetAdapterLuid)((ID3D12Device3*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePipelineLibrary([NativeTypeName("const void *")] void* pLibraryBlob, [NativeTypeName("SIZE_T")] UIntPtr BlobLength, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineLibrary)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreatePipelineLibrary>(lpVtbl->CreatePipelineLibrary)((ID3D12Device3*)Unsafe.AsPointer(ref this), pLibraryBlob, BlobLength, riid, ppPipelineLibrary);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEventOnMultipleFenceCompletion([NativeTypeName("ID3D12Fence *const *")] ID3D12Fence** ppFences, [NativeTypeName("const UINT64 *")] ulong* pFenceValues, [NativeTypeName("UINT")] uint NumFences, D3D12_MULTIPLE_FENCE_WAIT_FLAGS Flags, [NativeTypeName("HANDLE")] IntPtr hEvent)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetEventOnMultipleFenceCompletion>(lpVtbl->SetEventOnMultipleFenceCompletion)((ID3D12Device3*)Unsafe.AsPointer(ref this), ppFences, pFenceValues, NumFences, Flags, hEvent);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResidencyPriority([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects, [NativeTypeName("const D3D12_RESIDENCY_PRIORITY *")] D3D12_RESIDENCY_PRIORITY* pPriorities)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetResidencyPriority>(lpVtbl->SetResidencyPriority)((ID3D12Device3*)Unsafe.AsPointer(ref this), NumObjects, ppObjects, pPriorities);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePipelineState([NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreatePipelineState>(lpVtbl->CreatePipelineState)((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenExistingHeapFromAddress([NativeTypeName("const void *")] void* pAddress, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return Marshal.GetDelegateForFunctionPointer<_OpenExistingHeapFromAddress>(lpVtbl->OpenExistingHeapFromAddress)((ID3D12Device3*)Unsafe.AsPointer(ref this), pAddress, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenExistingHeapFromFileMapping([NativeTypeName("HANDLE")] IntPtr hFileMapping, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return Marshal.GetDelegateForFunctionPointer<_OpenExistingHeapFromFileMapping>(lpVtbl->OpenExistingHeapFromFileMapping)((ID3D12Device3*)Unsafe.AsPointer(ref this), hFileMapping, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnqueueMakeResident(D3D12_RESIDENCY_FLAGS Flags, [NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects, [NativeTypeName("ID3D12Fence *")] ID3D12Fence* pFenceToSignal, [NativeTypeName("UINT64")] ulong FenceValueToSignal)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnqueueMakeResident>(lpVtbl->EnqueueMakeResident)((ID3D12Device3*)Unsafe.AsPointer(ref this), Flags, NumObjects, ppObjects, pFenceToSignal, FenceValueToSignal);
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
        }
    }
}
