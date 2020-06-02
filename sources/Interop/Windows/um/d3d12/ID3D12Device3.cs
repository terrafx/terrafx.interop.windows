// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12Device3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12Device3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12Device3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((ID3D12Device3*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((ID3D12Device3*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return lpVtbl->SetPrivateDataInterface((ID3D12Device3*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return lpVtbl->SetName((ID3D12Device3*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("UINT")]
        public uint GetNodeCount()
        {
            return lpVtbl->GetNodeCount((ID3D12Device3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandQueue([NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] D3D12_COMMAND_QUEUE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandQueue)
        {
            return lpVtbl->CreateCommandQueue((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, riid, ppCommandQueue);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandAllocator(D3D12_COMMAND_LIST_TYPE type, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandAllocator)
        {
            return lpVtbl->CreateCommandAllocator((ID3D12Device3*)Unsafe.AsPointer(ref this), type, riid, ppCommandAllocator);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGraphicsPipelineState([NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState)
        {
            return lpVtbl->CreateGraphicsPipelineState((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComputePipelineState([NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState)
        {
            return lpVtbl->CreateComputePipelineState((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandList([NativeTypeName("UINT")] uint nodeMask, D3D12_COMMAND_LIST_TYPE type, [NativeTypeName("ID3D12CommandAllocator *")] ID3D12CommandAllocator* pCommandAllocator, [NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pInitialState, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandList)
        {
            return lpVtbl->CreateCommandList((ID3D12Device3*)Unsafe.AsPointer(ref this), nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D3D12_FEATURE Feature, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return lpVtbl->CheckFeatureSupport((ID3D12Device3*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDescriptorHeap([NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")] D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return lpVtbl->CreateDescriptorHeap((ID3D12Device3*)Unsafe.AsPointer(ref this), pDescriptorHeapDesc, riid, ppvHeap);
        }

        [return: NativeTypeName("UINT")]
        public uint GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType)
        {
            return lpVtbl->GetDescriptorHandleIncrementSize((ID3D12Device3*)Unsafe.AsPointer(ref this), DescriptorHeapType);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRootSignature([NativeTypeName("UINT")] uint nodeMask, [NativeTypeName("const void *")] void* pBlobWithRootSignature, [NativeTypeName("SIZE_T")] nuint blobLengthInBytes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvRootSignature)
        {
            return lpVtbl->CreateRootSignature((ID3D12Device3*)Unsafe.AsPointer(ref this), nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
        }

        public void CreateConstantBufferView([NativeTypeName("const D3D12_CONSTANT_BUFFER_VIEW_DESC *")] D3D12_CONSTANT_BUFFER_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            lpVtbl->CreateConstantBufferView((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
        }

        public void CreateShaderResourceView([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_SHADER_RESOURCE_VIEW_DESC *")] D3D12_SHADER_RESOURCE_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            lpVtbl->CreateShaderResourceView((ID3D12Device3*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        public void CreateUnorderedAccessView([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pCounterResource, [NativeTypeName("const D3D12_UNORDERED_ACCESS_VIEW_DESC *")] D3D12_UNORDERED_ACCESS_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            lpVtbl->CreateUnorderedAccessView((ID3D12Device3*)Unsafe.AsPointer(ref this), pResource, pCounterResource, pDesc, DestDescriptor);
        }

        public void CreateRenderTargetView([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_RENDER_TARGET_VIEW_DESC *")] D3D12_RENDER_TARGET_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            lpVtbl->CreateRenderTargetView((ID3D12Device3*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        public void CreateDepthStencilView([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_DEPTH_STENCIL_VIEW_DESC *")] D3D12_DEPTH_STENCIL_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            lpVtbl->CreateDepthStencilView((ID3D12Device3*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        public void CreateSampler([NativeTypeName("const D3D12_SAMPLER_DESC *")] D3D12_SAMPLER_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            lpVtbl->CreateSampler((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
        }

        public void CopyDescriptors([NativeTypeName("UINT")] uint NumDestDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pDestDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pDestDescriptorRangeSizes, [NativeTypeName("UINT")] uint NumSrcDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pSrcDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pSrcDescriptorRangeSizes, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)
        {
            lpVtbl->CopyDescriptors((ID3D12Device3*)Unsafe.AsPointer(ref this), NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }

        public void CopyDescriptorsSimple([NativeTypeName("UINT")] uint NumDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)
        {
            lpVtbl->CopyDescriptorsSimple((ID3D12Device3*)Unsafe.AsPointer(ref this), NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
        }

        public D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo([NativeTypeName("UINT")] uint visibleMask, [NativeTypeName("UINT")] uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDescs)
        {
            D3D12_RESOURCE_ALLOCATION_INFO result;
            return *lpVtbl->GetResourceAllocationInfo((ID3D12Device3*)Unsafe.AsPointer(ref this), &result, visibleMask, numResourceDescs, pResourceDescs);
        }

        public D3D12_HEAP_PROPERTIES GetCustomHeapProperties([NativeTypeName("UINT")] uint nodeMask, D3D12_HEAP_TYPE heapType)
        {
            D3D12_HEAP_PROPERTIES result;
            return *lpVtbl->GetCustomHeapProperties((ID3D12Device3*)Unsafe.AsPointer(ref this), &result, nodeMask, heapType);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommittedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riidResource, [NativeTypeName("void **")] void** ppvResource)
        {
            return lpVtbl->CreateCommittedResource((ID3D12Device3*)Unsafe.AsPointer(ref this), pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHeap([NativeTypeName("const D3D12_HEAP_DESC *")] D3D12_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return lpVtbl->CreateHeap((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePlacedResource([NativeTypeName("ID3D12Heap *")] ID3D12Heap* pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvResource)
        {
            return lpVtbl->CreatePlacedResource((ID3D12Device3*)Unsafe.AsPointer(ref this), pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateReservedResource([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvResource)
        {
            return lpVtbl->CreateReservedResource((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSharedHandle([NativeTypeName("ID3D12DeviceChild *")] ID3D12DeviceChild* pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("HANDLE *")] IntPtr* pHandle)
        {
            return lpVtbl->CreateSharedHandle((ID3D12Device3*)Unsafe.AsPointer(ref this), pObject, pAttributes, Access, Name, pHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedHandle([NativeTypeName("HANDLE")] IntPtr NTHandle, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObj)
        {
            return lpVtbl->OpenSharedHandle((ID3D12Device3*)Unsafe.AsPointer(ref this), NTHandle, riid, ppvObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedHandleByName([NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("HANDLE *")] IntPtr* pNTHandle)
        {
            return lpVtbl->OpenSharedHandleByName((ID3D12Device3*)Unsafe.AsPointer(ref this), Name, Access, pNTHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int MakeResident([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects)
        {
            return lpVtbl->MakeResident((ID3D12Device3*)Unsafe.AsPointer(ref this), NumObjects, ppObjects);
        }

        [return: NativeTypeName("HRESULT")]
        public int Evict([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects)
        {
            return lpVtbl->Evict((ID3D12Device3*)Unsafe.AsPointer(ref this), NumObjects, ppObjects);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFence([NativeTypeName("UINT64")] ulong InitialValue, D3D12_FENCE_FLAGS Flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppFence)
        {
            return lpVtbl->CreateFence((ID3D12Device3*)Unsafe.AsPointer(ref this), InitialValue, Flags, riid, ppFence);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceRemovedReason()
        {
            return lpVtbl->GetDeviceRemovedReason((ID3D12Device3*)Unsafe.AsPointer(ref this));
        }

        public void GetCopyableFootprints([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDesc, [NativeTypeName("UINT")] uint FirstSubresource, [NativeTypeName("UINT")] uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, [NativeTypeName("D3D12_PLACED_SUBRESOURCE_FOOTPRINT *")] D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts, [NativeTypeName("UINT *")] uint* pNumRows, [NativeTypeName("UINT64 *")] ulong* pRowSizeInBytes, [NativeTypeName("UINT64 *")] ulong* pTotalBytes)
        {
            lpVtbl->GetCopyableFootprints((ID3D12Device3*)Unsafe.AsPointer(ref this), pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryHeap([NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] D3D12_QUERY_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return lpVtbl->CreateQueryHeap((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStablePowerState([NativeTypeName("BOOL")] int Enable)
        {
            return lpVtbl->SetStablePowerState((ID3D12Device3*)Unsafe.AsPointer(ref this), Enable);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandSignature([NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")] D3D12_COMMAND_SIGNATURE_DESC* pDesc, [NativeTypeName("ID3D12RootSignature *")] ID3D12RootSignature* pRootSignature, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvCommandSignature)
        {
            return lpVtbl->CreateCommandSignature((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, pRootSignature, riid, ppvCommandSignature);
        }

        public void GetResourceTiling([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pTiledResource, [NativeTypeName("UINT *")] uint* pNumTilesForEntireResource, [NativeTypeName("D3D12_PACKED_MIP_INFO *")] D3D12_PACKED_MIP_INFO* pPackedMipDesc, [NativeTypeName("D3D12_TILE_SHAPE *")] D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips, [NativeTypeName("UINT *")] uint* pNumSubresourceTilings, [NativeTypeName("UINT")] uint FirstSubresourceTilingToGet, [NativeTypeName("D3D12_SUBRESOURCE_TILING *")] D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips)
        {
            lpVtbl->GetResourceTiling((ID3D12Device3*)Unsafe.AsPointer(ref this), pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        public LUID GetAdapterLuid()
        {
            LUID result;
            return *lpVtbl->GetAdapterLuid((ID3D12Device3*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePipelineLibrary([NativeTypeName("const void *")] void* pLibraryBlob, [NativeTypeName("SIZE_T")] nuint BlobLength, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineLibrary)
        {
            return lpVtbl->CreatePipelineLibrary((ID3D12Device3*)Unsafe.AsPointer(ref this), pLibraryBlob, BlobLength, riid, ppPipelineLibrary);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEventOnMultipleFenceCompletion([NativeTypeName("ID3D12Fence *const *")] ID3D12Fence** ppFences, [NativeTypeName("const UINT64 *")] ulong* pFenceValues, [NativeTypeName("UINT")] uint NumFences, D3D12_MULTIPLE_FENCE_WAIT_FLAGS Flags, [NativeTypeName("HANDLE")] IntPtr hEvent)
        {
            return lpVtbl->SetEventOnMultipleFenceCompletion((ID3D12Device3*)Unsafe.AsPointer(ref this), ppFences, pFenceValues, NumFences, Flags, hEvent);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResidencyPriority([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects, [NativeTypeName("const D3D12_RESIDENCY_PRIORITY *")] D3D12_RESIDENCY_PRIORITY* pPriorities)
        {
            return lpVtbl->SetResidencyPriority((ID3D12Device3*)Unsafe.AsPointer(ref this), NumObjects, ppObjects, pPriorities);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePipelineState([NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState)
        {
            return lpVtbl->CreatePipelineState((ID3D12Device3*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenExistingHeapFromAddress([NativeTypeName("const void *")] void* pAddress, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return lpVtbl->OpenExistingHeapFromAddress((ID3D12Device3*)Unsafe.AsPointer(ref this), pAddress, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenExistingHeapFromFileMapping([NativeTypeName("HANDLE")] IntPtr hFileMapping, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return lpVtbl->OpenExistingHeapFromFileMapping((ID3D12Device3*)Unsafe.AsPointer(ref this), hFileMapping, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnqueueMakeResident(D3D12_RESIDENCY_FLAGS Flags, [NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects, [NativeTypeName("ID3D12Fence *")] ID3D12Fence* pFenceToSignal, [NativeTypeName("UINT64")] ulong FenceValueToSignal)
        {
            return lpVtbl->EnqueueMakeResident((ID3D12Device3*)Unsafe.AsPointer(ref this), Flags, NumObjects, ppObjects, pFenceToSignal, FenceValueToSignal);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, ushort*, int> SetName;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, uint> GetNodeCount;

            [NativeTypeName("HRESULT (const D3D12_COMMAND_QUEUE_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_COMMAND_QUEUE_DESC*, Guid*, void**, int> CreateCommandQueue;

            [NativeTypeName("HRESULT (D3D12_COMMAND_LIST_TYPE, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_COMMAND_LIST_TYPE, Guid*, void**, int> CreateCommandAllocator;

            [NativeTypeName("HRESULT (const D3D12_GRAPHICS_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_GRAPHICS_PIPELINE_STATE_DESC*, Guid*, void**, int> CreateGraphicsPipelineState;

            [NativeTypeName("HRESULT (const D3D12_COMPUTE_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_COMPUTE_PIPELINE_STATE_DESC*, Guid*, void**, int> CreateComputePipelineState;

            [NativeTypeName("HRESULT (UINT, D3D12_COMMAND_LIST_TYPE, ID3D12CommandAllocator *, ID3D12PipelineState *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, uint, D3D12_COMMAND_LIST_TYPE, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int> CreateCommandList;

            [NativeTypeName("HRESULT (D3D12_FEATURE, void *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_FEATURE, void*, uint, int> CheckFeatureSupport;

            [NativeTypeName("HRESULT (const D3D12_DESCRIPTOR_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_DESCRIPTOR_HEAP_DESC*, Guid*, void**, int> CreateDescriptorHeap;

            [NativeTypeName("UINT (D3D12_DESCRIPTOR_HEAP_TYPE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_DESCRIPTOR_HEAP_TYPE, uint> GetDescriptorHandleIncrementSize;

            [NativeTypeName("HRESULT (UINT, const void *, SIZE_T, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, uint, void*, nuint, Guid*, void**, int> CreateRootSignature;

            [NativeTypeName("void (const D3D12_CONSTANT_BUFFER_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_CONSTANT_BUFFER_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> CreateConstantBufferView;

            [NativeTypeName("void (ID3D12Resource *, const D3D12_SHADER_RESOURCE_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, ID3D12Resource*, D3D12_SHADER_RESOURCE_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> CreateShaderResourceView;

            [NativeTypeName("void (ID3D12Resource *, ID3D12Resource *, const D3D12_UNORDERED_ACCESS_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, ID3D12Resource*, ID3D12Resource*, D3D12_UNORDERED_ACCESS_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> CreateUnorderedAccessView;

            [NativeTypeName("void (ID3D12Resource *, const D3D12_RENDER_TARGET_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, ID3D12Resource*, D3D12_RENDER_TARGET_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> CreateRenderTargetView;

            [NativeTypeName("void (ID3D12Resource *, const D3D12_DEPTH_STENCIL_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, ID3D12Resource*, D3D12_DEPTH_STENCIL_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> CreateDepthStencilView;

            [NativeTypeName("void (const D3D12_SAMPLER_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_SAMPLER_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> CreateSampler;

            [NativeTypeName("void (UINT, const D3D12_CPU_DESCRIPTOR_HANDLE *, const UINT *, UINT, const D3D12_CPU_DESCRIPTOR_HANDLE *, const UINT *, D3D12_DESCRIPTOR_HEAP_TYPE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, uint, D3D12_CPU_DESCRIPTOR_HANDLE*, uint*, uint, D3D12_CPU_DESCRIPTOR_HANDLE*, uint*, D3D12_DESCRIPTOR_HEAP_TYPE, void> CopyDescriptors;

            [NativeTypeName("void (UINT, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_DESCRIPTOR_HEAP_TYPE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, uint, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_DESCRIPTOR_HEAP_TYPE, void> CopyDescriptorsSimple;

            [NativeTypeName("D3D12_RESOURCE_ALLOCATION_INFO (UINT, UINT, const D3D12_RESOURCE_DESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_RESOURCE_ALLOCATION_INFO*, uint, uint, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_ALLOCATION_INFO*> GetResourceAllocationInfo;

            [NativeTypeName("D3D12_HEAP_PROPERTIES (UINT, D3D12_HEAP_TYPE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_HEAP_PROPERTIES*, uint, D3D12_HEAP_TYPE, D3D12_HEAP_PROPERTIES*> GetCustomHeapProperties;

            [NativeTypeName("HRESULT (const D3D12_HEAP_PROPERTIES *, D3D12_HEAP_FLAGS, const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_HEAP_PROPERTIES*, D3D12_HEAP_FLAGS, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int> CreateCommittedResource;

            [NativeTypeName("HRESULT (const D3D12_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_HEAP_DESC*, Guid*, void**, int> CreateHeap;

            [NativeTypeName("HRESULT (ID3D12Heap *, UINT64, const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, ID3D12Heap*, ulong, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int> CreatePlacedResource;

            [NativeTypeName("HRESULT (const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int> CreateReservedResource;

            [NativeTypeName("HRESULT (ID3D12DeviceChild *, const SECURITY_ATTRIBUTES *, DWORD, LPCWSTR, HANDLE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, ID3D12DeviceChild*, SECURITY_ATTRIBUTES*, uint, ushort*, IntPtr*, int> CreateSharedHandle;

            [NativeTypeName("HRESULT (HANDLE, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, IntPtr, Guid*, void**, int> OpenSharedHandle;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, HANDLE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, ushort*, uint, IntPtr*, int> OpenSharedHandleByName;

            [NativeTypeName("HRESULT (UINT, ID3D12Pageable *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, uint, ID3D12Pageable**, int> MakeResident;

            [NativeTypeName("HRESULT (UINT, ID3D12Pageable *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, uint, ID3D12Pageable**, int> Evict;

            [NativeTypeName("HRESULT (UINT64, D3D12_FENCE_FLAGS, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, ulong, D3D12_FENCE_FLAGS, Guid*, void**, int> CreateFence;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, int> GetDeviceRemovedReason;

            [NativeTypeName("void (const D3D12_RESOURCE_DESC *, UINT, UINT, UINT64, D3D12_PLACED_SUBRESOURCE_FOOTPRINT *, UINT *, UINT64 *, UINT64 *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_RESOURCE_DESC*, uint, uint, ulong, D3D12_PLACED_SUBRESOURCE_FOOTPRINT*, uint*, ulong*, ulong*, void> GetCopyableFootprints;

            [NativeTypeName("HRESULT (const D3D12_QUERY_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_QUERY_HEAP_DESC*, Guid*, void**, int> CreateQueryHeap;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, int, int> SetStablePowerState;

            [NativeTypeName("HRESULT (const D3D12_COMMAND_SIGNATURE_DESC *, ID3D12RootSignature *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_COMMAND_SIGNATURE_DESC*, ID3D12RootSignature*, Guid*, void**, int> CreateCommandSignature;

            [NativeTypeName("void (ID3D12Resource *, UINT *, D3D12_PACKED_MIP_INFO *, D3D12_TILE_SHAPE *, UINT *, UINT, D3D12_SUBRESOURCE_TILING *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, ID3D12Resource*, uint*, D3D12_PACKED_MIP_INFO*, D3D12_TILE_SHAPE*, uint*, uint, D3D12_SUBRESOURCE_TILING*, void> GetResourceTiling;

            [NativeTypeName("LUID () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, LUID*, LUID*> GetAdapterLuid;

            [NativeTypeName("HRESULT (const void *, SIZE_T, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, void*, nuint, Guid*, void**, int> CreatePipelineLibrary;

            [NativeTypeName("HRESULT (ID3D12Fence *const *, const UINT64 *, UINT, D3D12_MULTIPLE_FENCE_WAIT_FLAGS, HANDLE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, ID3D12Fence**, ulong*, uint, D3D12_MULTIPLE_FENCE_WAIT_FLAGS, IntPtr, int> SetEventOnMultipleFenceCompletion;

            [NativeTypeName("HRESULT (UINT, ID3D12Pageable *const *, const D3D12_RESIDENCY_PRIORITY *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, uint, ID3D12Pageable**, D3D12_RESIDENCY_PRIORITY*, int> SetResidencyPriority;

            [NativeTypeName("HRESULT (const D3D12_PIPELINE_STATE_STREAM_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_PIPELINE_STATE_STREAM_DESC*, Guid*, void**, int> CreatePipelineState;

            [NativeTypeName("HRESULT (const void *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, void*, Guid*, void**, int> OpenExistingHeapFromAddress;

            [NativeTypeName("HRESULT (HANDLE, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, IntPtr, Guid*, void**, int> OpenExistingHeapFromFileMapping;

            [NativeTypeName("HRESULT (D3D12_RESIDENCY_FLAGS, UINT, ID3D12Pageable *const *, ID3D12Fence *, UINT64) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Device3*, D3D12_RESIDENCY_FLAGS, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int> EnqueueMakeResident;
        }
    }
}
