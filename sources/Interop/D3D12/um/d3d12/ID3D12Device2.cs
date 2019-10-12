// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30BAA41E-B15B-475C-A0BB-1AF5C5B64328")]
    public unsafe partial struct ID3D12Device2
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12Device2* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12Device2* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12Device2* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D12Device2* This, [NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint* pDataSize, void* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D12Device2* This, [NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, void* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D12Device2* This, [NativeTypeName("REFGUID")] Guid* guid, IUnknown* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(ID3D12Device2* This, [NativeTypeName("LPCWSTR")] ushort* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetNodeCount(ID3D12Device2* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommandQueue(ID3D12Device2* This, D3D12_COMMAND_QUEUE_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppCommandQueue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommandAllocator(ID3D12Device2* This, D3D12_COMMAND_LIST_TYPE Type, [NativeTypeName("REFIID")] Guid* riid, void** ppCommandAllocator);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGraphicsPipelineState(ID3D12Device2* This, D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppPipelineState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateComputePipelineState(ID3D12Device2* This, D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppPipelineState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommandList(ID3D12Device2* This, [NativeTypeName("UINT")] uint NodeMask, D3D12_COMMAND_LIST_TYPE Type, ID3D12CommandAllocator* pCommandAllocator, [Optional] ID3D12PipelineState* pInitialState, [NativeTypeName("REFIID")] Guid* riid, void** ppCommandList);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckFeatureSupport(ID3D12Device2* This, D3D12_FEATURE Feature, void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDescriptorHeap(ID3D12Device2* This, D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppvHeap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetDescriptorHandleIncrementSize(ID3D12Device2* This, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRootSignature(ID3D12Device2* This, [NativeTypeName("UINT")] uint NodeMask, void* pBlobWithRootSignature, [NativeTypeName("SIZE_T")] UIntPtr blobLengthInBytes, [NativeTypeName("REFIID")] Guid* riid, void** ppvRootSignature);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CreateConstantBufferView(ID3D12Device2* This, [Optional] D3D12_CONSTANT_BUFFER_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CreateShaderResourceView(ID3D12Device2* This, [Optional] ID3D12Resource* pResource, [Optional] D3D12_SHADER_RESOURCE_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CreateUnorderedAccessView(ID3D12Device2* This, [Optional] ID3D12Resource* pResource, [Optional] ID3D12Resource* pCounterResource, [Optional] D3D12_UNORDERED_ACCESS_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CreateRenderTargetView(ID3D12Device2* This, [Optional] ID3D12Resource* pResource, [Optional] D3D12_RENDER_TARGET_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CreateDepthStencilView(ID3D12Device2* This, [Optional] ID3D12Resource* pResource, [Optional] D3D12_DEPTH_STENCIL_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CreateSampler(ID3D12Device2* This, D3D12_SAMPLER_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopyDescriptors(ID3D12Device2* This, [NativeTypeName("UINT")] uint NumDestDescriptorRanges, [NativeTypeName("D3D12_CPU_DESCRIPTOR_HANDLE[]")] D3D12_CPU_DESCRIPTOR_HANDLE* pDestDescriptorRangeStarts, [Optional, NativeTypeName("UINT[]")] uint* pDestDescriptorRangeSizes, [NativeTypeName("UINT")] uint NumSrcDescriptorRanges, [NativeTypeName("D3D12_CPU_DESCRIPTOR_HANDLE[]")] D3D12_CPU_DESCRIPTOR_HANDLE* pSrcDescriptorRangeStarts, [Optional, NativeTypeName("UINT[]")] uint* pSrcDescriptorRangeSizes, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopyDescriptorsSimple(ID3D12Device2* This, [NativeTypeName("UINT")] uint NumDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D12_RESOURCE_ALLOCATION_INFO* _GetResourceAllocationInfo(ID3D12Device2* This, D3D12_RESOURCE_ALLOCATION_INFO* _result, [NativeTypeName("UINT")] uint visibleMask, [NativeTypeName("UINT")] uint numResourceDescs, D3D12_RESOURCE_DESC* pResourceDescs);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D12_HEAP_PROPERTIES* _GetCustomHeapProperties(ID3D12Device2* This, D3D12_HEAP_PROPERTIES* _result, [NativeTypeName("UINT")] uint NodeMask, D3D12_HEAP_TYPE heapType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommittedResource(ID3D12Device2* This, D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, [Optional] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("REFIID")] Guid* riidResource, void** ppvResource = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateHeap(ID3D12Device2* This, D3D12_HEAP_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppvHeap = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePlacedResource(ID3D12Device2* This, ID3D12Heap* pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [Optional] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("REFIID")] Guid* riid, void** ppvResource = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateReservedResource(ID3D12Device2* This, D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [Optional] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("REFIID")] Guid* riid, void** ppvResource = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSharedHandle(ID3D12Device2* This, ID3D12DeviceChild* pObject, [Optional] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint Access, [Optional, NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("HANDLE")] IntPtr* pHandle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenSharedHandle(ID3D12Device2* This, [NativeTypeName("HANDLE")] IntPtr NTHandle, [NativeTypeName("REFIID")] Guid* riid, void** ppvObj = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenSharedHandleByName(ID3D12Device2* This, [NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("HANDLE")] IntPtr* pNTHandle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MakeResident(ID3D12Device2* This, [NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable*[]")] ID3D12Pageable** ppObjects);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Evict(ID3D12Device2* This, [NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable*[]")] ID3D12Pageable** ppObjects);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFence(ID3D12Device2* This, [NativeTypeName("UINT64")] ulong InitialValue, D3D12_FENCE_FLAGS Flags, [NativeTypeName("REFIID")] Guid* riid, void** ppFence);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceRemovedReason(ID3D12Device2* This
);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetCopyableFootprints(ID3D12Device2* This, D3D12_RESOURCE_DESC* pResourceDesc, [NativeTypeName("UINT")] uint FirstSubresource, [NativeTypeName("UINT")] uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, [NativeTypeName("D3D12_PLACED_SUBRESOURCE_FOOTPRINT[]")] D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts = null, [NativeTypeName("UINT[]")] uint* pNumRows = null, [NativeTypeName("UINT64[]")] ulong* pRowSizeInBytes = null, [NativeTypeName("UINT64")] ulong* pTotalBytes = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateQueryHeap(ID3D12Device2* This, D3D12_QUERY_HEAP_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppvHeap = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetStablePowerState(ID3D12Device2* This, [NativeTypeName("BOOL")] int Enable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommandSignature(ID3D12Device2* This, D3D12_COMMAND_SIGNATURE_DESC* pDesc, [Optional] ID3D12RootSignature* pRootSignature, [NativeTypeName("REFIID")] Guid* riid, void** ppvCommandSignature = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetResourceTiling(ID3D12Device2* This, ID3D12Resource* pTiledResource, [Optional, NativeTypeName("UINT")] uint* pNumTilesForEntireResource, [Optional] D3D12_PACKED_MIP_INFO* pPackedMipDesc, [Optional] D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips, [Optional, NativeTypeName("UINT")] uint* pNumSubresourceTilings, [NativeTypeName("UINT")] uint FirstSubresourceTilingToGet, D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate LUID* _GetAdapterLuid(ID3D12Device2* This, LUID* _result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePipelineLibrary(ID3D12Device2* This, void* pLibraryBlob, [NativeTypeName("SIZE_T")] UIntPtr BlobLength, [NativeTypeName("REFIID")] Guid* riid, void** ppPipelineLibrary);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetEventOnMultipleFenceCompletion(ID3D12Device2* This, [NativeTypeName("ID3D12Fence*[]")] ID3D12Fence** ppFences, [NativeTypeName("UINT64[]")] ulong* pFenceValues, [NativeTypeName("UINT")] uint NumFences, D3D12_MULTIPLE_FENCE_WAIT_FLAGS Flags, [NativeTypeName("HANDLE")] IntPtr hEvent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetResidencyPriority(ID3D12Device2* This, [NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable*[]")] ID3D12Pageable** ppObjects, [NativeTypeName("D3D12_RESIDENCY_PRIORITY[]")] D3D12_RESIDENCY_PRIORITY* pPriorities);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePipelineState(ID3D12Device2* This, D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppPipelineState);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint* pDataSize, void* pData = null)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(This, guid, pDataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, void* pData = null)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(This, guid, DataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("REFGUID")] Guid* guid, IUnknown* pData = null)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(This, guid, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)(This, Name);
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetNodeCount()
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNodeCount>(lpVtbl->GetNodeCount)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandQueue(D3D12_COMMAND_QUEUE_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppCommandQueue)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateCommandQueue>(lpVtbl->CreateCommandQueue)(This, pDesc, riid, ppCommandQueue);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandAllocator(D3D12_COMMAND_LIST_TYPE Type, [NativeTypeName("REFIID")] Guid* riid, void** ppCommandAllocator)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateCommandAllocator>(lpVtbl->CreateCommandAllocator)(This, Type, riid, ppCommandAllocator);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGraphicsPipelineState(D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateGraphicsPipelineState>(lpVtbl->CreateGraphicsPipelineState)(This, pDesc, riid, ppPipelineState);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComputePipelineState(D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateComputePipelineState>(lpVtbl->CreateComputePipelineState)(This, pDesc, riid, ppPipelineState);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandList([NativeTypeName("UINT")] uint NodeMask, D3D12_COMMAND_LIST_TYPE Type, ID3D12CommandAllocator* pCommandAllocator, [Optional] ID3D12PipelineState* pInitialState, [NativeTypeName("REFIID")] Guid* riid, void** ppCommandList)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateCommandList>(lpVtbl->CreateCommandList)(This, NodeMask, Type, pCommandAllocator, pInitialState, riid, ppCommandList);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D3D12_FEATURE Feature, void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CheckFeatureSupport>(lpVtbl->CheckFeatureSupport)(This, Feature, pFeatureSupportData, FeatureSupportDataSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDescriptorHeap(D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppvHeap)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDescriptorHeap>(lpVtbl->CreateDescriptorHeap)(This, pDescriptorHeapDesc, riid, ppvHeap);
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDescriptorHandleIncrementSize>(lpVtbl->GetDescriptorHandleIncrementSize)(This, DescriptorHeapType);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRootSignature([NativeTypeName("UINT")] uint NodeMask, void* pBlobWithRootSignature, [NativeTypeName("SIZE_T")] UIntPtr blobLengthInBytes, [NativeTypeName("REFIID")] Guid* riid, void** ppvRootSignature)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateRootSignature>(lpVtbl->CreateRootSignature)(This, NodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
            }
        }

        public void CreateConstantBufferView([Optional] D3D12_CONSTANT_BUFFER_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            fixed (ID3D12Device2* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CreateConstantBufferView>(lpVtbl->CreateConstantBufferView)(This, pDesc, DestDescriptor);
            }
        }

        public void CreateShaderResourceView([Optional] ID3D12Resource* pResource, [Optional] D3D12_SHADER_RESOURCE_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            fixed (ID3D12Device2* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CreateShaderResourceView>(lpVtbl->CreateShaderResourceView)(This, pResource, pDesc, DestDescriptor);
            }
        }

        public void CreateUnorderedAccessView([Optional] ID3D12Resource* pResource, [Optional] ID3D12Resource* pCounterResource, [Optional] D3D12_UNORDERED_ACCESS_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            fixed (ID3D12Device2* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CreateUnorderedAccessView>(lpVtbl->CreateUnorderedAccessView)(This, pResource, pCounterResource, pDesc, DestDescriptor);
            }
        }

        public void CreateRenderTargetView([Optional] ID3D12Resource* pResource, [Optional] D3D12_RENDER_TARGET_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            fixed (ID3D12Device2* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CreateRenderTargetView>(lpVtbl->CreateRenderTargetView)(This, pResource, pDesc, DestDescriptor);
            }
        }

        public void CreateDepthStencilView([Optional] ID3D12Resource* pResource, [Optional] D3D12_DEPTH_STENCIL_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            fixed (ID3D12Device2* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CreateDepthStencilView>(lpVtbl->CreateDepthStencilView)(This, pResource, pDesc, DestDescriptor);
            }
        }

        public void CreateSampler(D3D12_SAMPLER_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            fixed (ID3D12Device2* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CreateSampler>(lpVtbl->CreateSampler)(This, pDesc, DestDescriptor);
            }
        }

        public void CopyDescriptors([NativeTypeName("UINT")] uint NumDestDescriptorRanges, [NativeTypeName("D3D12_CPU_DESCRIPTOR_HANDLE[]")] D3D12_CPU_DESCRIPTOR_HANDLE* pDestDescriptorRangeStarts, [Optional, NativeTypeName("UINT[]")] uint* pDestDescriptorRangeSizes, [NativeTypeName("UINT")] uint NumSrcDescriptorRanges, [NativeTypeName("D3D12_CPU_DESCRIPTOR_HANDLE[]")] D3D12_CPU_DESCRIPTOR_HANDLE* pSrcDescriptorRangeStarts, [Optional, NativeTypeName("UINT[]")] uint* pSrcDescriptorRangeSizes, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)
        {
            fixed (ID3D12Device2* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CopyDescriptors>(lpVtbl->CopyDescriptors)(This, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }

        public void CopyDescriptorsSimple([NativeTypeName("UINT")] uint NumDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)
        {
            fixed (ID3D12Device2* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CopyDescriptorsSimple>(lpVtbl->CopyDescriptorsSimple)(This, NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
            }
        }

        public D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo([NativeTypeName("UINT")] uint visibleMask, [NativeTypeName("UINT")] uint numResourceDescs, D3D12_RESOURCE_DESC* pResourceDescs)
        {
            fixed (ID3D12Device2* This = &this)
            {
                D3D12_RESOURCE_ALLOCATION_INFO result;
                return *Marshal.GetDelegateForFunctionPointer<_GetResourceAllocationInfo>(lpVtbl->GetResourceAllocationInfo)(This, &result, visibleMask, numResourceDescs, pResourceDescs);
            }
        }

        public D3D12_HEAP_PROPERTIES GetCustomHeapProperties([NativeTypeName("UINT")] uint NodeMask, D3D12_HEAP_TYPE heapType)
        {
            fixed (ID3D12Device2* This = &this)
            {
                D3D12_HEAP_PROPERTIES result;
                return *Marshal.GetDelegateForFunctionPointer<_GetCustomHeapProperties>(lpVtbl->GetCustomHeapProperties)(This, &result, NodeMask, heapType);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommittedResource(D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, [Optional] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("REFIID")] Guid* riidResource, void** ppvResource = null)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateCommittedResource>(lpVtbl->CreateCommittedResource)(This, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHeap(D3D12_HEAP_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppvHeap = null)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateHeap>(lpVtbl->CreateHeap)(This, pDesc, riid, ppvHeap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePlacedResource(ID3D12Heap* pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [Optional] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("REFIID")] Guid* riid, void** ppvResource = null)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePlacedResource>(lpVtbl->CreatePlacedResource)(This, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateReservedResource(D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [Optional] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("REFIID")] Guid* riid, void** ppvResource = null)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateReservedResource>(lpVtbl->CreateReservedResource)(This, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSharedHandle(ID3D12DeviceChild* pObject, [Optional] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint Access, [Optional, NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("HANDLE")] IntPtr* pHandle)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSharedHandle>(lpVtbl->CreateSharedHandle)(This, pObject, pAttributes, Access, Name, pHandle);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedHandle([NativeTypeName("HANDLE")] IntPtr NTHandle, [NativeTypeName("REFIID")] Guid* riid, void** ppvObj = null)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_OpenSharedHandle>(lpVtbl->OpenSharedHandle)(This, NTHandle, riid, ppvObj);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedHandleByName([NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("HANDLE")] IntPtr* pNTHandle)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_OpenSharedHandleByName>(lpVtbl->OpenSharedHandleByName)(This, Name, Access, pNTHandle);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MakeResident([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable*[]")] ID3D12Pageable** ppObjects)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MakeResident>(lpVtbl->MakeResident)(This, NumObjects, ppObjects);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Evict([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable*[]")] ID3D12Pageable** ppObjects)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Evict>(lpVtbl->Evict)(This, NumObjects, ppObjects);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFence([NativeTypeName("UINT64")] ulong InitialValue, D3D12_FENCE_FLAGS Flags, [NativeTypeName("REFIID")] Guid* riid, void** ppFence)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFence>(lpVtbl->CreateFence)(This, InitialValue, Flags, riid, ppFence);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceRemovedReason()
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDeviceRemovedReason>(lpVtbl->GetDeviceRemovedReason)(This);
            }
        }

        public void GetCopyableFootprints(D3D12_RESOURCE_DESC* pResourceDesc, [NativeTypeName("UINT")] uint FirstSubresource, [NativeTypeName("UINT")] uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, [NativeTypeName("D3D12_PLACED_SUBRESOURCE_FOOTPRINT[]")] D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts = null, [NativeTypeName("UINT[]")] uint* pNumRows = null, [NativeTypeName("UINT64[]")] ulong* pRowSizeInBytes = null, [NativeTypeName("UINT64")] ulong* pTotalBytes = null)
        {
            fixed (ID3D12Device2* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetCopyableFootprints>(lpVtbl->GetCopyableFootprints)(This, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryHeap(D3D12_QUERY_HEAP_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppvHeap = null)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateQueryHeap>(lpVtbl->CreateQueryHeap)(This, pDesc, riid, ppvHeap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStablePowerState([NativeTypeName("BOOL")] int Enable)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetStablePowerState>(lpVtbl->SetStablePowerState)(This, Enable);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandSignature(D3D12_COMMAND_SIGNATURE_DESC* pDesc, [Optional] ID3D12RootSignature* pRootSignature, [NativeTypeName("REFIID")] Guid* riid, void** ppvCommandSignature = null)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateCommandSignature>(lpVtbl->CreateCommandSignature)(This, pDesc, pRootSignature, riid, ppvCommandSignature);
            }
        }

        public void GetResourceTiling(ID3D12Resource* pTiledResource, [Optional, NativeTypeName("UINT")] uint* pNumTilesForEntireResource, [Optional] D3D12_PACKED_MIP_INFO* pPackedMipDesc, [Optional] D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips, [Optional, NativeTypeName("UINT")] uint* pNumSubresourceTilings, [NativeTypeName("UINT")] uint FirstSubresourceTilingToGet, D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips)
        {
            fixed (ID3D12Device2* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetResourceTiling>(lpVtbl->GetResourceTiling)(This, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }

        public LUID GetAdapterLuid()
        {
            fixed (ID3D12Device2* This = &this)
            {
                LUID result;
                return *Marshal.GetDelegateForFunctionPointer<_GetAdapterLuid>(lpVtbl->GetAdapterLuid)(This, &result);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePipelineLibrary(void* pLibraryBlob, [NativeTypeName("SIZE_T")] UIntPtr BlobLength, [NativeTypeName("REFIID")] Guid* riid, void** ppPipelineLibrary)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePipelineLibrary>(lpVtbl->CreatePipelineLibrary)(This, pLibraryBlob, BlobLength, riid, ppPipelineLibrary);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEventOnMultipleFenceCompletion([NativeTypeName("ID3D12Fence*[]")] ID3D12Fence** ppFences, [NativeTypeName("UINT64[]")] ulong* pFenceValues, [NativeTypeName("UINT")] uint NumFences, D3D12_MULTIPLE_FENCE_WAIT_FLAGS Flags, [NativeTypeName("HANDLE")] IntPtr hEvent)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetEventOnMultipleFenceCompletion>(lpVtbl->SetEventOnMultipleFenceCompletion)(This, ppFences, pFenceValues, NumFences, Flags, hEvent);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResidencyPriority([NativeTypeName("UINT")] uint NumObjects, [NativeTypeName("ID3D12Pageable*[]")] ID3D12Pageable** ppObjects, [NativeTypeName("D3D12_RESIDENCY_PRIORITY[]")] D3D12_RESIDENCY_PRIORITY* pPriorities)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetResidencyPriority>(lpVtbl->SetResidencyPriority)(This, NumObjects, ppObjects, pPriorities);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePipelineState(D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12Device2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePipelineState>(lpVtbl->CreatePipelineState)(This, pDesc, riid, ppPipelineState);
            }
        }

        public partial struct Vtbl
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

            public IntPtr CreatePipelineState;
        }
    }
}
