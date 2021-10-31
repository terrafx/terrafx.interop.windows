// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30BAA41E-B15B-475C-A0BB-1AF5C5B64328")]
    [NativeTypeName("struct ID3D12Device2 : ID3D12Device1")]
    [NativeInheritance("ID3D12Device1")]
    public unsafe partial struct ID3D12Device2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12Device2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Device2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12Device2*, uint>)(lpVtbl[1]))((ID3D12Device2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12Device2*, uint>)(lpVtbl[2]))((ID3D12Device2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D12Device2*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12Device2*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12Device2*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12Device2*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D12Device2*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12Device2*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12Device2*, ushort*, int>)(lpVtbl[6]))((ID3D12Device2*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("UINT")]
        public uint GetNodeCount()
        {
            return ((delegate* unmanaged<ID3D12Device2*, uint>)(lpVtbl[7]))((ID3D12Device2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCommandQueue([NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] D3D12_COMMAND_QUEUE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandQueue)
        {
            return ((delegate* unmanaged<ID3D12Device2*, D3D12_COMMAND_QUEUE_DESC*, Guid*, void**, int>)(lpVtbl[8]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pDesc, riid, ppCommandQueue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCommandAllocator(D3D12_COMMAND_LIST_TYPE type, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandAllocator)
        {
            return ((delegate* unmanaged<ID3D12Device2*, D3D12_COMMAND_LIST_TYPE, Guid*, void**, int>)(lpVtbl[9]))((ID3D12Device2*)Unsafe.AsPointer(ref this), type, riid, ppCommandAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGraphicsPipelineState([NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
        {
            return ((delegate* unmanaged<ID3D12Device2*, D3D12_GRAPHICS_PIPELINE_STATE_DESC*, Guid*, void**, int>)(lpVtbl[10]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int CreateComputePipelineState([NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
        {
            return ((delegate* unmanaged<ID3D12Device2*, D3D12_COMPUTE_PIPELINE_STATE_DESC*, Guid*, void**, int>)(lpVtbl[11]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCommandList([NativeTypeName("UINT")] uint nodeMask, D3D12_COMMAND_LIST_TYPE type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandList)
        {
            return ((delegate* unmanaged<ID3D12Device2*, uint, D3D12_COMMAND_LIST_TYPE, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)(lpVtbl[12]))((ID3D12Device2*)Unsafe.AsPointer(ref this), nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D3D12_FEATURE Feature, void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return ((delegate* unmanaged<ID3D12Device2*, D3D12_FEATURE, void*, uint, int>)(lpVtbl[13]))((ID3D12Device2*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDescriptorHeap([NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")] D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
        {
            return ((delegate* unmanaged<ID3D12Device2*, D3D12_DESCRIPTOR_HEAP_DESC*, Guid*, void**, int>)(lpVtbl[14]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pDescriptorHeapDesc, riid, ppvHeap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("UINT")]
        public uint GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType)
        {
            return ((delegate* unmanaged<ID3D12Device2*, D3D12_DESCRIPTOR_HEAP_TYPE, uint>)(lpVtbl[15]))((ID3D12Device2*)Unsafe.AsPointer(ref this), DescriptorHeapType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRootSignature([NativeTypeName("UINT")] uint nodeMask, [NativeTypeName("const void *")] void* pBlobWithRootSignature, [NativeTypeName("SIZE_T")] nuint blobLengthInBytes, [NativeTypeName("const IID &")] Guid* riid, void** ppvRootSignature)
        {
            return ((delegate* unmanaged<ID3D12Device2*, uint, void*, nuint, Guid*, void**, int>)(lpVtbl[16]))((ID3D12Device2*)Unsafe.AsPointer(ref this), nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void CreateConstantBufferView([NativeTypeName("const D3D12_CONSTANT_BUFFER_VIEW_DESC *")] D3D12_CONSTANT_BUFFER_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device2*, D3D12_CONSTANT_BUFFER_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[17]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void CreateShaderResourceView(ID3D12Resource* pResource, [NativeTypeName("const D3D12_SHADER_RESOURCE_VIEW_DESC *")] D3D12_SHADER_RESOURCE_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device2*, ID3D12Resource*, D3D12_SHADER_RESOURCE_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[18]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void CreateUnorderedAccessView(ID3D12Resource* pResource, ID3D12Resource* pCounterResource, [NativeTypeName("const D3D12_UNORDERED_ACCESS_VIEW_DESC *")] D3D12_UNORDERED_ACCESS_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device2*, ID3D12Resource*, ID3D12Resource*, D3D12_UNORDERED_ACCESS_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[19]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pResource, pCounterResource, pDesc, DestDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void CreateRenderTargetView(ID3D12Resource* pResource, [NativeTypeName("const D3D12_RENDER_TARGET_VIEW_DESC *")] D3D12_RENDER_TARGET_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device2*, ID3D12Resource*, D3D12_RENDER_TARGET_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[20]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void CreateDepthStencilView(ID3D12Resource* pResource, [NativeTypeName("const D3D12_DEPTH_STENCIL_VIEW_DESC *")] D3D12_DEPTH_STENCIL_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device2*, ID3D12Resource*, D3D12_DEPTH_STENCIL_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[21]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void CreateSampler([NativeTypeName("const D3D12_SAMPLER_DESC *")] D3D12_SAMPLER_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device2*, D3D12_SAMPLER_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[22]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void CopyDescriptors([NativeTypeName("UINT")] uint NumDestDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pDestDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pDestDescriptorRangeSizes, [NativeTypeName("UINT")] uint NumSrcDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pSrcDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pSrcDescriptorRangeSizes, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)
        {
            ((delegate* unmanaged<ID3D12Device2*, uint, D3D12_CPU_DESCRIPTOR_HANDLE*, uint*, uint, D3D12_CPU_DESCRIPTOR_HANDLE*, uint*, D3D12_DESCRIPTOR_HEAP_TYPE, void>)(lpVtbl[23]))((ID3D12Device2*)Unsafe.AsPointer(ref this), NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public void CopyDescriptorsSimple([NativeTypeName("UINT")] uint NumDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)
        {
            ((delegate* unmanaged<ID3D12Device2*, uint, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_DESCRIPTOR_HEAP_TYPE, void>)(lpVtbl[24]))((ID3D12Device2*)Unsafe.AsPointer(ref this), NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo([NativeTypeName("UINT")] uint visibleMask, [NativeTypeName("UINT")] uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDescs)
        {
            D3D12_RESOURCE_ALLOCATION_INFO result;
            return *((delegate* unmanaged<ID3D12Device2*, D3D12_RESOURCE_ALLOCATION_INFO*, uint, uint, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_ALLOCATION_INFO*>)(lpVtbl[25]))((ID3D12Device2*)Unsafe.AsPointer(ref this), &result, visibleMask, numResourceDescs, pResourceDescs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public D3D12_HEAP_PROPERTIES GetCustomHeapProperties([NativeTypeName("UINT")] uint nodeMask, D3D12_HEAP_TYPE heapType)
        {
            D3D12_HEAP_PROPERTIES result;
            return *((delegate* unmanaged<ID3D12Device2*, D3D12_HEAP_PROPERTIES*, uint, D3D12_HEAP_TYPE, D3D12_HEAP_PROPERTIES*>)(lpVtbl[26]))((ID3D12Device2*)Unsafe.AsPointer(ref this), &result, nodeMask, heapType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCommittedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riidResource, void** ppvResource)
        {
            return ((delegate* unmanaged<ID3D12Device2*, D3D12_HEAP_PROPERTIES*, D3D12_HEAP_FLAGS, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int>)(lpVtbl[27]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int CreateHeap([NativeTypeName("const D3D12_HEAP_DESC *")] D3D12_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
        {
            return ((delegate* unmanaged<ID3D12Device2*, D3D12_HEAP_DESC*, Guid*, void**, int>)(lpVtbl[28]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePlacedResource(ID3D12Heap* pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, void** ppvResource)
        {
            return ((delegate* unmanaged<ID3D12Device2*, ID3D12Heap*, ulong, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int>)(lpVtbl[29]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int CreateReservedResource([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, void** ppvResource)
        {
            return ((delegate* unmanaged<ID3D12Device2*, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int>)(lpVtbl[30]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSharedHandle(ID3D12DeviceChild* pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("HANDLE *")] IntPtr* pHandle)
        {
            return ((delegate* unmanaged<ID3D12Device2*, ID3D12DeviceChild*, SECURITY_ATTRIBUTES*, uint, ushort*, IntPtr*, int>)(lpVtbl[31]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pObject, pAttributes, Access, Name, pHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int OpenSharedHandle([NativeTypeName("HANDLE")] IntPtr NTHandle, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj)
        {
            return ((delegate* unmanaged<ID3D12Device2*, IntPtr, Guid*, void**, int>)(lpVtbl[32]))((ID3D12Device2*)Unsafe.AsPointer(ref this), NTHandle, riid, ppvObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int OpenSharedHandleByName([NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("HANDLE *")] IntPtr* pNTHandle)
        {
            return ((delegate* unmanaged<ID3D12Device2*, ushort*, uint, IntPtr*, int>)(lpVtbl[33]))((ID3D12Device2*)Unsafe.AsPointer(ref this), Name, Access, pNTHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int MakeResident([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects)
        {
            return ((delegate* unmanaged<ID3D12Device2*, uint, ID3D12Pageable**, int>)(lpVtbl[34]))((ID3D12Device2*)Unsafe.AsPointer(ref this), NumObjects, ppObjects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int Evict([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects)
        {
            return ((delegate* unmanaged<ID3D12Device2*, uint, ID3D12Pageable**, int>)(lpVtbl[35]))((ID3D12Device2*)Unsafe.AsPointer(ref this), NumObjects, ppObjects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFence([NativeTypeName("UINT64")] ulong InitialValue, D3D12_FENCE_FLAGS Flags, [NativeTypeName("const IID &")] Guid* riid, void** ppFence)
        {
            return ((delegate* unmanaged<ID3D12Device2*, ulong, D3D12_FENCE_FLAGS, Guid*, void**, int>)(lpVtbl[36]))((ID3D12Device2*)Unsafe.AsPointer(ref this), InitialValue, Flags, riid, ppFence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceRemovedReason()
        {
            return ((delegate* unmanaged<ID3D12Device2*, int>)(lpVtbl[37]))((ID3D12Device2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public void GetCopyableFootprints([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDesc, [NativeTypeName("UINT")] uint FirstSubresource, [NativeTypeName("UINT")] uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts, [NativeTypeName("UINT *")] uint* pNumRows, [NativeTypeName("UINT64 *")] ulong* pRowSizeInBytes, [NativeTypeName("UINT64 *")] ulong* pTotalBytes)
        {
            ((delegate* unmanaged<ID3D12Device2*, D3D12_RESOURCE_DESC*, uint, uint, ulong, D3D12_PLACED_SUBRESOURCE_FOOTPRINT*, uint*, ulong*, ulong*, void>)(lpVtbl[38]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQueryHeap([NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] D3D12_QUERY_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
        {
            return ((delegate* unmanaged<ID3D12Device2*, D3D12_QUERY_HEAP_DESC*, Guid*, void**, int>)(lpVtbl[39]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int SetStablePowerState(BOOL Enable)
        {
            return ((delegate* unmanaged<ID3D12Device2*, BOOL, int>)(lpVtbl[40]))((ID3D12Device2*)Unsafe.AsPointer(ref this), Enable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCommandSignature([NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")] D3D12_COMMAND_SIGNATURE_DESC* pDesc, ID3D12RootSignature* pRootSignature, [NativeTypeName("const IID &")] Guid* riid, void** ppvCommandSignature)
        {
            return ((delegate* unmanaged<ID3D12Device2*, D3D12_COMMAND_SIGNATURE_DESC*, ID3D12RootSignature*, Guid*, void**, int>)(lpVtbl[41]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pDesc, pRootSignature, riid, ppvCommandSignature);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public void GetResourceTiling(ID3D12Resource* pTiledResource, [NativeTypeName("UINT *")] uint* pNumTilesForEntireResource, D3D12_PACKED_MIP_INFO* pPackedMipDesc, D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips, [NativeTypeName("UINT *")] uint* pNumSubresourceTilings, [NativeTypeName("UINT")] uint FirstSubresourceTilingToGet, D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips)
        {
            ((delegate* unmanaged<ID3D12Device2*, ID3D12Resource*, uint*, D3D12_PACKED_MIP_INFO*, D3D12_TILE_SHAPE*, uint*, uint, D3D12_SUBRESOURCE_TILING*, void>)(lpVtbl[42]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public LUID GetAdapterLuid()
        {
            LUID result;
            return *((delegate* unmanaged<ID3D12Device2*, LUID*, LUID*>)(lpVtbl[43]))((ID3D12Device2*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePipelineLibrary([NativeTypeName("const void *")] void* pLibraryBlob, [NativeTypeName("SIZE_T")] nuint BlobLength, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineLibrary)
        {
            return ((delegate* unmanaged<ID3D12Device2*, void*, nuint, Guid*, void**, int>)(lpVtbl[44]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pLibraryBlob, BlobLength, riid, ppPipelineLibrary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int SetEventOnMultipleFenceCompletion([NativeTypeName("ID3D12Fence *const *")] ID3D12Fence** ppFences, [NativeTypeName("const UINT64 *")] ulong* pFenceValues, [NativeTypeName("UINT")] uint NumFences, D3D12_MULTIPLE_FENCE_WAIT_FLAGS Flags, [NativeTypeName("HANDLE")] IntPtr hEvent)
        {
            return ((delegate* unmanaged<ID3D12Device2*, ID3D12Fence**, ulong*, uint, D3D12_MULTIPLE_FENCE_WAIT_FLAGS, IntPtr, int>)(lpVtbl[45]))((ID3D12Device2*)Unsafe.AsPointer(ref this), ppFences, pFenceValues, NumFences, Flags, hEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int SetResidencyPriority([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects, [NativeTypeName("const D3D12_RESIDENCY_PRIORITY *")] D3D12_RESIDENCY_PRIORITY* pPriorities)
        {
            return ((delegate* unmanaged<ID3D12Device2*, uint, ID3D12Pageable**, D3D12_RESIDENCY_PRIORITY*, int>)(lpVtbl[46]))((ID3D12Device2*)Unsafe.AsPointer(ref this), NumObjects, ppObjects, pPriorities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePipelineState([NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
        {
            return ((delegate* unmanaged<ID3D12Device2*, D3D12_PIPELINE_STATE_STREAM_DESC*, Guid*, void**, int>)(lpVtbl[47]))((ID3D12Device2*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }
    }
}
