// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9218E6BB-F944-4F7E-A75C-B1B2C7B701F3")]
    [NativeTypeName("struct ID3D12Device8 : ID3D12Device7")]
    public unsafe partial struct ID3D12Device8
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12Device8*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Device8*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12Device8*, uint>)(lpVtbl[1]))((ID3D12Device8*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12Device8*, uint>)(lpVtbl[2]))((ID3D12Device8*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D12Device8*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12Device8*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D12Device8*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12Device8*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* stdcall<ID3D12Device8*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12Device8*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* stdcall<ID3D12Device8*, ushort*, int>)(lpVtbl[6]))((ID3D12Device8*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("UINT")]
        public uint GetNodeCount()
        {
            return ((delegate* stdcall<ID3D12Device8*, uint>)(lpVtbl[7]))((ID3D12Device8*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandQueue([NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] D3D12_COMMAND_QUEUE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandQueue)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_COMMAND_QUEUE_DESC*, Guid*, void**, int>)(lpVtbl[8]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pDesc, riid, ppCommandQueue);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandAllocator(D3D12_COMMAND_LIST_TYPE type, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandAllocator)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_COMMAND_LIST_TYPE, Guid*, void**, int>)(lpVtbl[9]))((ID3D12Device8*)Unsafe.AsPointer(ref this), type, riid, ppCommandAllocator);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGraphicsPipelineState([NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_GRAPHICS_PIPELINE_STATE_DESC*, Guid*, void**, int>)(lpVtbl[10]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComputePipelineState([NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_COMPUTE_PIPELINE_STATE_DESC*, Guid*, void**, int>)(lpVtbl[11]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandList([NativeTypeName("UINT")] uint nodeMask, D3D12_COMMAND_LIST_TYPE type, [NativeTypeName("ID3D12CommandAllocator *")] ID3D12CommandAllocator* pCommandAllocator, [NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pInitialState, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandList)
        {
            return ((delegate* stdcall<ID3D12Device8*, uint, D3D12_COMMAND_LIST_TYPE, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)(lpVtbl[12]))((ID3D12Device8*)Unsafe.AsPointer(ref this), nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D3D12_FEATURE Feature, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_FEATURE, void*, uint, int>)(lpVtbl[13]))((ID3D12Device8*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDescriptorHeap([NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")] D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_DESCRIPTOR_HEAP_DESC*, Guid*, void**, int>)(lpVtbl[14]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pDescriptorHeapDesc, riid, ppvHeap);
        }

        [return: NativeTypeName("UINT")]
        public uint GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_DESCRIPTOR_HEAP_TYPE, uint>)(lpVtbl[15]))((ID3D12Device8*)Unsafe.AsPointer(ref this), DescriptorHeapType);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRootSignature([NativeTypeName("UINT")] uint nodeMask, [NativeTypeName("const void *")] void* pBlobWithRootSignature, [NativeTypeName("SIZE_T")] nuint blobLengthInBytes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvRootSignature)
        {
            return ((delegate* stdcall<ID3D12Device8*, uint, void*, nuint, Guid*, void**, int>)(lpVtbl[16]))((ID3D12Device8*)Unsafe.AsPointer(ref this), nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
        }

        public void CreateConstantBufferView([NativeTypeName("const D3D12_CONSTANT_BUFFER_VIEW_DESC *")] D3D12_CONSTANT_BUFFER_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* stdcall<ID3D12Device8*, D3D12_CONSTANT_BUFFER_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[17]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
        }

        public void CreateShaderResourceView([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_SHADER_RESOURCE_VIEW_DESC *")] D3D12_SHADER_RESOURCE_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* stdcall<ID3D12Device8*, ID3D12Resource*, D3D12_SHADER_RESOURCE_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[18]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        public void CreateUnorderedAccessView([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pCounterResource, [NativeTypeName("const D3D12_UNORDERED_ACCESS_VIEW_DESC *")] D3D12_UNORDERED_ACCESS_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* stdcall<ID3D12Device8*, ID3D12Resource*, ID3D12Resource*, D3D12_UNORDERED_ACCESS_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[19]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pResource, pCounterResource, pDesc, DestDescriptor);
        }

        public void CreateRenderTargetView([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_RENDER_TARGET_VIEW_DESC *")] D3D12_RENDER_TARGET_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* stdcall<ID3D12Device8*, ID3D12Resource*, D3D12_RENDER_TARGET_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[20]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        public void CreateDepthStencilView([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_DEPTH_STENCIL_VIEW_DESC *")] D3D12_DEPTH_STENCIL_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* stdcall<ID3D12Device8*, ID3D12Resource*, D3D12_DEPTH_STENCIL_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[21]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        public void CreateSampler([NativeTypeName("const D3D12_SAMPLER_DESC *")] D3D12_SAMPLER_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* stdcall<ID3D12Device8*, D3D12_SAMPLER_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[22]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
        }

        public void CopyDescriptors([NativeTypeName("UINT")] uint NumDestDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pDestDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pDestDescriptorRangeSizes, [NativeTypeName("UINT")] uint NumSrcDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pSrcDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pSrcDescriptorRangeSizes, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)
        {
            ((delegate* stdcall<ID3D12Device8*, uint, D3D12_CPU_DESCRIPTOR_HANDLE*, uint*, uint, D3D12_CPU_DESCRIPTOR_HANDLE*, uint*, D3D12_DESCRIPTOR_HEAP_TYPE, void>)(lpVtbl[23]))((ID3D12Device8*)Unsafe.AsPointer(ref this), NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }

        public void CopyDescriptorsSimple([NativeTypeName("UINT")] uint NumDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)
        {
            ((delegate* stdcall<ID3D12Device8*, uint, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_DESCRIPTOR_HEAP_TYPE, void>)(lpVtbl[24]))((ID3D12Device8*)Unsafe.AsPointer(ref this), NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
        }

        public D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo([NativeTypeName("UINT")] uint visibleMask, [NativeTypeName("UINT")] uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDescs)
        {
            D3D12_RESOURCE_ALLOCATION_INFO result;
            return *((delegate* stdcall<ID3D12Device8*, D3D12_RESOURCE_ALLOCATION_INFO*, uint, uint, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_ALLOCATION_INFO*>)(lpVtbl[25]))((ID3D12Device8*)Unsafe.AsPointer(ref this), &result, visibleMask, numResourceDescs, pResourceDescs);
        }

        public D3D12_HEAP_PROPERTIES GetCustomHeapProperties([NativeTypeName("UINT")] uint nodeMask, D3D12_HEAP_TYPE heapType)
        {
            D3D12_HEAP_PROPERTIES result;
            return *((delegate* stdcall<ID3D12Device8*, D3D12_HEAP_PROPERTIES*, uint, D3D12_HEAP_TYPE, D3D12_HEAP_PROPERTIES*>)(lpVtbl[26]))((ID3D12Device8*)Unsafe.AsPointer(ref this), &result, nodeMask, heapType);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommittedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riidResource, [NativeTypeName("void **")] void** ppvResource)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_HEAP_PROPERTIES*, D3D12_HEAP_FLAGS, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int>)(lpVtbl[27]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHeap([NativeTypeName("const D3D12_HEAP_DESC *")] D3D12_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_HEAP_DESC*, Guid*, void**, int>)(lpVtbl[28]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePlacedResource([NativeTypeName("ID3D12Heap *")] ID3D12Heap* pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvResource)
        {
            return ((delegate* stdcall<ID3D12Device8*, ID3D12Heap*, ulong, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int>)(lpVtbl[29]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateReservedResource([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvResource)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int>)(lpVtbl[30]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSharedHandle([NativeTypeName("ID3D12DeviceChild *")] ID3D12DeviceChild* pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("HANDLE *")] IntPtr* pHandle)
        {
            return ((delegate* stdcall<ID3D12Device8*, ID3D12DeviceChild*, SECURITY_ATTRIBUTES*, uint, ushort*, IntPtr*, int>)(lpVtbl[31]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pObject, pAttributes, Access, Name, pHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedHandle([NativeTypeName("HANDLE")] IntPtr NTHandle, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObj)
        {
            return ((delegate* stdcall<ID3D12Device8*, IntPtr, Guid*, void**, int>)(lpVtbl[32]))((ID3D12Device8*)Unsafe.AsPointer(ref this), NTHandle, riid, ppvObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedHandleByName([NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("HANDLE *")] IntPtr* pNTHandle)
        {
            return ((delegate* stdcall<ID3D12Device8*, ushort*, uint, IntPtr*, int>)(lpVtbl[33]))((ID3D12Device8*)Unsafe.AsPointer(ref this), Name, Access, pNTHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int MakeResident([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects)
        {
            return ((delegate* stdcall<ID3D12Device8*, uint, ID3D12Pageable**, int>)(lpVtbl[34]))((ID3D12Device8*)Unsafe.AsPointer(ref this), NumObjects, ppObjects);
        }

        [return: NativeTypeName("HRESULT")]
        public int Evict([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects)
        {
            return ((delegate* stdcall<ID3D12Device8*, uint, ID3D12Pageable**, int>)(lpVtbl[35]))((ID3D12Device8*)Unsafe.AsPointer(ref this), NumObjects, ppObjects);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFence([NativeTypeName("UINT64")] ulong InitialValue, D3D12_FENCE_FLAGS Flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppFence)
        {
            return ((delegate* stdcall<ID3D12Device8*, ulong, D3D12_FENCE_FLAGS, Guid*, void**, int>)(lpVtbl[36]))((ID3D12Device8*)Unsafe.AsPointer(ref this), InitialValue, Flags, riid, ppFence);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceRemovedReason()
        {
            return ((delegate* stdcall<ID3D12Device8*, int>)(lpVtbl[37]))((ID3D12Device8*)Unsafe.AsPointer(ref this));
        }

        public void GetCopyableFootprints([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDesc, [NativeTypeName("UINT")] uint FirstSubresource, [NativeTypeName("UINT")] uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, [NativeTypeName("D3D12_PLACED_SUBRESOURCE_FOOTPRINT *")] D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts, [NativeTypeName("UINT *")] uint* pNumRows, [NativeTypeName("UINT64 *")] ulong* pRowSizeInBytes, [NativeTypeName("UINT64 *")] ulong* pTotalBytes)
        {
            ((delegate* stdcall<ID3D12Device8*, D3D12_RESOURCE_DESC*, uint, uint, ulong, D3D12_PLACED_SUBRESOURCE_FOOTPRINT*, uint*, ulong*, ulong*, void>)(lpVtbl[38]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryHeap([NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] D3D12_QUERY_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_QUERY_HEAP_DESC*, Guid*, void**, int>)(lpVtbl[39]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStablePowerState([NativeTypeName("BOOL")] int Enable)
        {
            return ((delegate* stdcall<ID3D12Device8*, int, int>)(lpVtbl[40]))((ID3D12Device8*)Unsafe.AsPointer(ref this), Enable);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandSignature([NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")] D3D12_COMMAND_SIGNATURE_DESC* pDesc, [NativeTypeName("ID3D12RootSignature *")] ID3D12RootSignature* pRootSignature, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvCommandSignature)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_COMMAND_SIGNATURE_DESC*, ID3D12RootSignature*, Guid*, void**, int>)(lpVtbl[41]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pDesc, pRootSignature, riid, ppvCommandSignature);
        }

        public void GetResourceTiling([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pTiledResource, [NativeTypeName("UINT *")] uint* pNumTilesForEntireResource, [NativeTypeName("D3D12_PACKED_MIP_INFO *")] D3D12_PACKED_MIP_INFO* pPackedMipDesc, [NativeTypeName("D3D12_TILE_SHAPE *")] D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips, [NativeTypeName("UINT *")] uint* pNumSubresourceTilings, [NativeTypeName("UINT")] uint FirstSubresourceTilingToGet, [NativeTypeName("D3D12_SUBRESOURCE_TILING *")] D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips)
        {
            ((delegate* stdcall<ID3D12Device8*, ID3D12Resource*, uint*, D3D12_PACKED_MIP_INFO*, D3D12_TILE_SHAPE*, uint*, uint, D3D12_SUBRESOURCE_TILING*, void>)(lpVtbl[42]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        public LUID GetAdapterLuid()
        {
            LUID result;
            return *((delegate* stdcall<ID3D12Device8*, LUID*, LUID*>)(lpVtbl[43]))((ID3D12Device8*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePipelineLibrary([NativeTypeName("const void *")] void* pLibraryBlob, [NativeTypeName("SIZE_T")] nuint BlobLength, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineLibrary)
        {
            return ((delegate* stdcall<ID3D12Device8*, void*, nuint, Guid*, void**, int>)(lpVtbl[44]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pLibraryBlob, BlobLength, riid, ppPipelineLibrary);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEventOnMultipleFenceCompletion([NativeTypeName("ID3D12Fence *const *")] ID3D12Fence** ppFences, [NativeTypeName("const UINT64 *")] ulong* pFenceValues, [NativeTypeName("UINT")] uint NumFences, D3D12_MULTIPLE_FENCE_WAIT_FLAGS Flags, [NativeTypeName("HANDLE")] IntPtr hEvent)
        {
            return ((delegate* stdcall<ID3D12Device8*, ID3D12Fence**, ulong*, uint, D3D12_MULTIPLE_FENCE_WAIT_FLAGS, IntPtr, int>)(lpVtbl[45]))((ID3D12Device8*)Unsafe.AsPointer(ref this), ppFences, pFenceValues, NumFences, Flags, hEvent);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResidencyPriority([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects, [NativeTypeName("const D3D12_RESIDENCY_PRIORITY *")] D3D12_RESIDENCY_PRIORITY* pPriorities)
        {
            return ((delegate* stdcall<ID3D12Device8*, uint, ID3D12Pageable**, D3D12_RESIDENCY_PRIORITY*, int>)(lpVtbl[46]))((ID3D12Device8*)Unsafe.AsPointer(ref this), NumObjects, ppObjects, pPriorities);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePipelineState([NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_PIPELINE_STATE_STREAM_DESC*, Guid*, void**, int>)(lpVtbl[47]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenExistingHeapFromAddress([NativeTypeName("const void *")] void* pAddress, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return ((delegate* stdcall<ID3D12Device8*, void*, Guid*, void**, int>)(lpVtbl[48]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pAddress, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenExistingHeapFromFileMapping([NativeTypeName("HANDLE")] IntPtr hFileMapping, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return ((delegate* stdcall<ID3D12Device8*, IntPtr, Guid*, void**, int>)(lpVtbl[49]))((ID3D12Device8*)Unsafe.AsPointer(ref this), hFileMapping, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnqueueMakeResident(D3D12_RESIDENCY_FLAGS Flags, [NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects, [NativeTypeName("ID3D12Fence *")] ID3D12Fence* pFenceToSignal, [NativeTypeName("UINT64")] ulong FenceValueToSignal)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_RESIDENCY_FLAGS, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)(lpVtbl[50]))((ID3D12Device8*)Unsafe.AsPointer(ref this), Flags, NumObjects, ppObjects, pFenceToSignal, FenceValueToSignal);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandList1([NativeTypeName("UINT")] uint nodeMask, D3D12_COMMAND_LIST_TYPE type, D3D12_COMMAND_LIST_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppCommandList)
        {
            return ((delegate* stdcall<ID3D12Device8*, uint, D3D12_COMMAND_LIST_TYPE, D3D12_COMMAND_LIST_FLAGS, Guid*, void**, int>)(lpVtbl[51]))((ID3D12Device8*)Unsafe.AsPointer(ref this), nodeMask, type, flags, riid, ppCommandList);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateProtectedResourceSession([NativeTypeName("const D3D12_PROTECTED_RESOURCE_SESSION_DESC *")] D3D12_PROTECTED_RESOURCE_SESSION_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppSession)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*, Guid*, void**, int>)(lpVtbl[52]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pDesc, riid, ppSession);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommittedResource1([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedSession, [NativeTypeName("const IID &")] Guid* riidResource, [NativeTypeName("void **")] void** ppvResource)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_HEAP_PROPERTIES*, D3D12_HEAP_FLAGS, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[53]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHeap1([NativeTypeName("const D3D12_HEAP_DESC *")] D3D12_HEAP_DESC* pDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvHeap)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_HEAP_DESC*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[54]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pDesc, pProtectedSession, riid, ppvHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateReservedResource1([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvResource)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[55]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResource);
        }

        public D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo1([NativeTypeName("UINT")] uint visibleMask, [NativeTypeName("UINT")] uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDescs, [NativeTypeName("D3D12_RESOURCE_ALLOCATION_INFO1 *")] D3D12_RESOURCE_ALLOCATION_INFO1* pResourceAllocationInfo1)
        {
            D3D12_RESOURCE_ALLOCATION_INFO result;
            return *((delegate* stdcall<ID3D12Device8*, D3D12_RESOURCE_ALLOCATION_INFO*, uint, uint, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_ALLOCATION_INFO1*, D3D12_RESOURCE_ALLOCATION_INFO*>)(lpVtbl[56]))((ID3D12Device8*)Unsafe.AsPointer(ref this), &result, visibleMask, numResourceDescs, pResourceDescs, pResourceAllocationInfo1);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLifetimeTracker([NativeTypeName("ID3D12LifetimeOwner *")] ID3D12LifetimeOwner* pOwner, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvTracker)
        {
            return ((delegate* stdcall<ID3D12Device8*, ID3D12LifetimeOwner*, Guid*, void**, int>)(lpVtbl[57]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pOwner, riid, ppvTracker);
        }

        public void RemoveDevice()
        {
            ((delegate* stdcall<ID3D12Device8*, void>)(lpVtbl[58]))((ID3D12Device8*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumerateMetaCommands([NativeTypeName("UINT *")] uint* pNumMetaCommands, [NativeTypeName("D3D12_META_COMMAND_DESC *")] D3D12_META_COMMAND_DESC* pDescs)
        {
            return ((delegate* stdcall<ID3D12Device8*, uint*, D3D12_META_COMMAND_DESC*, int>)(lpVtbl[59]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pNumMetaCommands, pDescs);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumerateMetaCommandParameters([NativeTypeName("const GUID &")] Guid* CommandId, D3D12_META_COMMAND_PARAMETER_STAGE Stage, [NativeTypeName("UINT *")] uint* pTotalStructureSizeInBytes, [NativeTypeName("UINT *")] uint* pParameterCount, [NativeTypeName("D3D12_META_COMMAND_PARAMETER_DESC *")] D3D12_META_COMMAND_PARAMETER_DESC* pParameterDescs)
        {
            return ((delegate* stdcall<ID3D12Device8*, Guid*, D3D12_META_COMMAND_PARAMETER_STAGE, uint*, uint*, D3D12_META_COMMAND_PARAMETER_DESC*, int>)(lpVtbl[60]))((ID3D12Device8*)Unsafe.AsPointer(ref this), CommandId, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescs);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMetaCommand([NativeTypeName("const GUID &")] Guid* CommandId, [NativeTypeName("UINT")] uint NodeMask, [NativeTypeName("const void *")] void* pCreationParametersData, [NativeTypeName("SIZE_T")] nuint CreationParametersDataSizeInBytes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppMetaCommand)
        {
            return ((delegate* stdcall<ID3D12Device8*, Guid*, uint, void*, nuint, Guid*, void**, int>)(lpVtbl[61]))((ID3D12Device8*)Unsafe.AsPointer(ref this), CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStateObject([NativeTypeName("const D3D12_STATE_OBJECT_DESC *")] D3D12_STATE_OBJECT_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppStateObject)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_STATE_OBJECT_DESC*, Guid*, void**, int>)(lpVtbl[62]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pDesc, riid, ppStateObject);
        }

        public void GetRaytracingAccelerationStructurePrebuildInfo([NativeTypeName("const D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS *")] D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS* pDesc, [NativeTypeName("D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO *")] D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO* pInfo)
        {
            ((delegate* stdcall<ID3D12Device8*, D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS*, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO*, void>)(lpVtbl[63]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pDesc, pInfo);
        }

        public D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS CheckDriverMatchingIdentifier(D3D12_SERIALIZED_DATA_TYPE SerializedDataType, [NativeTypeName("const D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER *")] D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER* pIdentifierToCheck)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_SERIALIZED_DATA_TYPE, D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER*, D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS>)(lpVtbl[64]))((ID3D12Device8*)Unsafe.AsPointer(ref this), SerializedDataType, pIdentifierToCheck);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBackgroundProcessingMode(D3D12_BACKGROUND_PROCESSING_MODE Mode, D3D12_MEASUREMENTS_ACTION MeasurementsAction, [NativeTypeName("HANDLE")] IntPtr hEventToSignalUponCompletion, [NativeTypeName("BOOL *")] int* pbFurtherMeasurementsDesired)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_BACKGROUND_PROCESSING_MODE, D3D12_MEASUREMENTS_ACTION, IntPtr, int*, int>)(lpVtbl[65]))((ID3D12Device8*)Unsafe.AsPointer(ref this), Mode, MeasurementsAction, hEventToSignalUponCompletion, pbFurtherMeasurementsDesired);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddToStateObject([NativeTypeName("const D3D12_STATE_OBJECT_DESC *")] D3D12_STATE_OBJECT_DESC* pAddition, [NativeTypeName("ID3D12StateObject *")] ID3D12StateObject* pStateObjectToGrowFrom, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppNewStateObject)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_STATE_OBJECT_DESC*, ID3D12StateObject*, Guid*, void**, int>)(lpVtbl[66]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pAddition, pStateObjectToGrowFrom, riid, ppNewStateObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateProtectedResourceSession1([NativeTypeName("const D3D12_PROTECTED_RESOURCE_SESSION_DESC1 *")] D3D12_PROTECTED_RESOURCE_SESSION_DESC1* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppSession)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_PROTECTED_RESOURCE_SESSION_DESC1*, Guid*, void**, int>)(lpVtbl[67]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pDesc, riid, ppSession);
        }

        public D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo2([NativeTypeName("UINT")] uint visibleMask, [NativeTypeName("UINT")] uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC1 *")] D3D12_RESOURCE_DESC1* pResourceDescs, [NativeTypeName("D3D12_RESOURCE_ALLOCATION_INFO1 *")] D3D12_RESOURCE_ALLOCATION_INFO1* pResourceAllocationInfo1)
        {
            D3D12_RESOURCE_ALLOCATION_INFO result;
            return *((delegate* stdcall<ID3D12Device8*, D3D12_RESOURCE_ALLOCATION_INFO*, uint, uint, D3D12_RESOURCE_DESC1*, D3D12_RESOURCE_ALLOCATION_INFO1*, D3D12_RESOURCE_ALLOCATION_INFO*>)(lpVtbl[68]))((ID3D12Device8*)Unsafe.AsPointer(ref this), &result, visibleMask, numResourceDescs, pResourceDescs, pResourceAllocationInfo1);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommittedResource2([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC1 *")] D3D12_RESOURCE_DESC1* pDesc, D3D12_RESOURCE_STATES InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedSession, [NativeTypeName("const IID &")] Guid* riidResource, [NativeTypeName("void **")] void** ppvResource)
        {
            return ((delegate* stdcall<ID3D12Device8*, D3D12_HEAP_PROPERTIES*, D3D12_HEAP_FLAGS, D3D12_RESOURCE_DESC1*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[69]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePlacedResource1([NativeTypeName("ID3D12Heap *")] ID3D12Heap* pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC1 *")] D3D12_RESOURCE_DESC1* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvResource)
        {
            return ((delegate* stdcall<ID3D12Device8*, ID3D12Heap*, ulong, D3D12_RESOURCE_DESC1*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int>)(lpVtbl[70]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }

        public void CreateSamplerFeedbackUnorderedAccessView([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pTargetedResource, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pFeedbackResource, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* stdcall<ID3D12Device8*, ID3D12Resource*, ID3D12Resource*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[71]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pTargetedResource, pFeedbackResource, DestDescriptor);
        }

        public void GetCopyableFootprints1([NativeTypeName("const D3D12_RESOURCE_DESC1 *")] D3D12_RESOURCE_DESC1* pResourceDesc, [NativeTypeName("UINT")] uint FirstSubresource, [NativeTypeName("UINT")] uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, [NativeTypeName("D3D12_PLACED_SUBRESOURCE_FOOTPRINT *")] D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts, [NativeTypeName("UINT *")] uint* pNumRows, [NativeTypeName("UINT64 *")] ulong* pRowSizeInBytes, [NativeTypeName("UINT64 *")] ulong* pTotalBytes)
        {
            ((delegate* stdcall<ID3D12Device8*, D3D12_RESOURCE_DESC1*, uint, uint, ulong, D3D12_PLACED_SUBRESOURCE_FOOTPRINT*, uint*, ulong*, ulong*, void>)(lpVtbl[72]))((ID3D12Device8*)Unsafe.AsPointer(ref this), pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
        }
    }
}
