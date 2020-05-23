// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C3827890-E548-4CFA-96CF-5689A9370F80")]
    public unsafe partial struct ID3D12GraphicsCommandList6
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12GraphicsCommandList6* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12GraphicsCommandList6* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("LPCWSTR")] ushort* Name);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D3D12_COMMAND_LIST_TYPE _GetType(ID3D12GraphicsCommandList6* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Close(ID3D12GraphicsCommandList6* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Reset(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12CommandAllocator *")] ID3D12CommandAllocator* pAllocator, [NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pInitialState);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ClearState(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pPipelineState);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _DrawInstanced(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint VertexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _DrawIndexedInstanced(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint IndexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartIndexLocation, [NativeTypeName("INT")] int BaseVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Dispatch(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint ThreadGroupCountX, [NativeTypeName("UINT")] uint ThreadGroupCountY, [NativeTypeName("UINT")] uint ThreadGroupCountZ);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _CopyBufferRegion(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT64")] ulong NumBytes);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _CopyTextureRegion(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12_TEXTURE_COPY_LOCATION* pDst, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("UINT")] uint DstZ, [NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12_TEXTURE_COPY_LOCATION* pSrc, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pSrcBox);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _CopyResource(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstResource, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcResource);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _CopyTiles(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pTiledResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12_TILE_REGION_SIZE* pTileRegionSize, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, D3D12_TILE_COPY_FLAGS Flags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ResolveSubresource(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, DXGI_FORMAT Format);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _IASetPrimitiveTopology(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("D3D12_PRIMITIVE_TOPOLOGY")] D3D_PRIMITIVE_TOPOLOGY PrimitiveTopology);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _RSSetViewports(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint NumViewports, [NativeTypeName("const D3D12_VIEWPORT *")] D3D12_VIEWPORT* pViewports);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _RSSetScissorRects(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OMSetBlendFactor(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("const FLOAT [4]")] float* BlendFactor);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OMSetStencilRef(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint StencilRef);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetPipelineState(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pPipelineState);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ResourceBarrier(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12_RESOURCE_BARRIER* pBarriers);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ExecuteBundle(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12GraphicsCommandList *")] ID3D12GraphicsCommandList* pCommandList);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetDescriptorHeaps(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint NumDescriptorHeaps, [NativeTypeName("ID3D12DescriptorHeap *const *")] ID3D12DescriptorHeap** ppDescriptorHeaps);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetComputeRootSignature(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12RootSignature *")] ID3D12RootSignature* pRootSignature);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetGraphicsRootSignature(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12RootSignature *")] ID3D12RootSignature* pRootSignature);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetComputeRootDescriptorTable(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetGraphicsRootDescriptorTable(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetComputeRoot32BitConstant(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint SrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetGraphicsRoot32BitConstant(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint SrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetComputeRoot32BitConstants(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetGraphicsRoot32BitConstants(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetComputeRootConstantBufferView(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetGraphicsRootConstantBufferView(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetComputeRootShaderResourceView(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetGraphicsRootShaderResourceView(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetComputeRootUnorderedAccessView(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetGraphicsRootUnorderedAccessView(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _IASetIndexBuffer(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("const D3D12_INDEX_BUFFER_VIEW *")] D3D12_INDEX_BUFFER_VIEW* pView);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _IASetVertexBuffers(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("const D3D12_VERTEX_BUFFER_VIEW *")] D3D12_VERTEX_BUFFER_VIEW* pViews);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SOSetTargets(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("const D3D12_STREAM_OUTPUT_BUFFER_VIEW *")] D3D12_STREAM_OUTPUT_BUFFER_VIEW* pViews);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OMSetRenderTargets(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint NumRenderTargetDescriptors, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pRenderTargetDescriptors, [NativeTypeName("BOOL")] int RTsSingleHandleToDescriptorRange, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pDepthStencilDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ClearDepthStencilView(ID3D12GraphicsCommandList6* pThis, D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView, D3D12_CLEAR_FLAGS ClearFlags, [NativeTypeName("FLOAT")] float Depth, [NativeTypeName("UINT8")] byte Stencil, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ClearRenderTargetView(ID3D12GraphicsCommandList6* pThis, D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView, [NativeTypeName("const FLOAT [4]")] float* ColorRGBA, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ClearUnorderedAccessViewUint(ID3D12GraphicsCommandList6* pThis, D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const UINT [4]")] uint* Values, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ClearUnorderedAccessViewFloat(ID3D12GraphicsCommandList6* pThis, D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const FLOAT [4]")] float* Values, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _DiscardResource(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12_DISCARD_REGION* pRegion);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _BeginQuery(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _EndQuery(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ResolveQueryData(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint StartIndex, [NativeTypeName("UINT")] uint NumQueries, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetPredication(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetMarker(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _BeginEvent(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _EndEvent(ID3D12GraphicsCommandList6* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ExecuteIndirect(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12CommandSignature *")] ID3D12CommandSignature* pCommandSignature, [NativeTypeName("UINT")] uint MaxCommandCount, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pArgumentBuffer, [NativeTypeName("UINT64")] ulong ArgumentBufferOffset, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pCountBuffer, [NativeTypeName("UINT64")] ulong CountBufferOffset);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _AtomicCopyBufferUINT(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT")] uint Dependencies, [NativeTypeName("ID3D12Resource *const *")] ID3D12Resource** ppDependentResources, [NativeTypeName("const D3D12_SUBRESOURCE_RANGE_UINT64 *")] D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _AtomicCopyBufferUINT64(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT")] uint Dependencies, [NativeTypeName("ID3D12Resource *const *")] ID3D12Resource** ppDependentResources, [NativeTypeName("const D3D12_SUBRESOURCE_RANGE_UINT64 *")] D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OMSetDepthBounds(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("FLOAT")] float Min, [NativeTypeName("FLOAT")] float Max);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetSamplePositions(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint NumSamplesPerPixel, [NativeTypeName("UINT")] uint NumPixels, [NativeTypeName("D3D12_SAMPLE_POSITION *")] D3D12_SAMPLE_POSITION* pSamplePositions);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ResolveSubresourceRegion(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("D3D12_RECT *")] RECT* pSrcRect, DXGI_FORMAT Format, D3D12_RESOLVE_MODE ResolveMode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetViewInstanceMask(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint Mask);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _WriteBufferImmediate(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint Count, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")] D3D12_WRITEBUFFERIMMEDIATE_PARAMETER* pParams, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")] D3D12_WRITEBUFFERIMMEDIATE_MODE* pModes);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetProtectedResourceSession(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _BeginRenderPass(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint NumRenderTargets, [NativeTypeName("const D3D12_RENDER_PASS_RENDER_TARGET_DESC *")] D3D12_RENDER_PASS_RENDER_TARGET_DESC* pRenderTargets, [NativeTypeName("const D3D12_RENDER_PASS_DEPTH_STENCIL_DESC *")] D3D12_RENDER_PASS_DEPTH_STENCIL_DESC* pDepthStencil, D3D12_RENDER_PASS_FLAGS Flags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _EndRenderPass(ID3D12GraphicsCommandList6* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _InitializeMetaCommand(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12MetaCommand *")] ID3D12MetaCommand* pMetaCommand, [NativeTypeName("const void *")] void* pInitializationParametersData, [NativeTypeName("SIZE_T")] nuint InitializationParametersDataSizeInBytes);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ExecuteMetaCommand(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12MetaCommand *")] ID3D12MetaCommand* pMetaCommand, [NativeTypeName("const void *")] void* pExecutionParametersData, [NativeTypeName("SIZE_T")] nuint ExecutionParametersDataSizeInBytes);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _BuildRaytracingAccelerationStructure(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("const D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC *")] D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC* pDesc, [NativeTypeName("UINT")] uint NumPostbuildInfoDescs, [NativeTypeName("const D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC *")] D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC* pPostbuildInfoDescs);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _EmitRaytracingAccelerationStructurePostbuildInfo(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("const D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC *")] D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC* pDesc, [NativeTypeName("UINT")] uint NumSourceAccelerationStructures, [NativeTypeName("const D3D12_GPU_VIRTUAL_ADDRESS *")] ulong* pSourceAccelerationStructureData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _CopyRaytracingAccelerationStructure(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong DestAccelerationStructureData, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong SourceAccelerationStructureData, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE Mode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetPipelineState1(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12StateObject *")] ID3D12StateObject* pStateObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _DispatchRays(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("const D3D12_DISPATCH_RAYS_DESC *")] D3D12_DISPATCH_RAYS_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _RSSetShadingRate(ID3D12GraphicsCommandList6* pThis, D3D12_SHADING_RATE baseShadingRate, [NativeTypeName("const D3D12_SHADING_RATE_COMBINER *")] D3D12_SHADING_RATE_COMBINER* combiners);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _RSSetShadingRateImage(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* shadingRateImage);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _DispatchMesh(ID3D12GraphicsCommandList6* pThis, [NativeTypeName("UINT")] uint ThreadGroupCountX, [NativeTypeName("UINT")] uint ThreadGroupCountY, [NativeTypeName("UINT")] uint ThreadGroupCountZ);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        public new D3D12_COMMAND_LIST_TYPE GetType()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetType>(lpVtbl->GetType)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return Marshal.GetDelegateForFunctionPointer<_Close>(lpVtbl->Close)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset([NativeTypeName("ID3D12CommandAllocator *")] ID3D12CommandAllocator* pAllocator, [NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pInitialState)
        {
            return Marshal.GetDelegateForFunctionPointer<_Reset>(lpVtbl->Reset)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pAllocator, pInitialState);
        }

        public void ClearState([NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pPipelineState)
        {
            Marshal.GetDelegateForFunctionPointer<_ClearState>(lpVtbl->ClearState)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pPipelineState);
        }

        public void DrawInstanced([NativeTypeName("UINT")] uint VertexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawInstanced>(lpVtbl->DrawInstanced)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
        }

        public void DrawIndexedInstanced([NativeTypeName("UINT")] uint IndexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartIndexLocation, [NativeTypeName("INT")] int BaseVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawIndexedInstanced>(lpVtbl->DrawIndexedInstanced)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
        }

        public void Dispatch([NativeTypeName("UINT")] uint ThreadGroupCountX, [NativeTypeName("UINT")] uint ThreadGroupCountY, [NativeTypeName("UINT")] uint ThreadGroupCountZ)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispatch>(lpVtbl->Dispatch)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
        }

        public void CopyBufferRegion([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT64")] ulong NumBytes)
        {
            Marshal.GetDelegateForFunctionPointer<_CopyBufferRegion>(lpVtbl->CopyBufferRegion)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
        }

        public void CopyTextureRegion([NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12_TEXTURE_COPY_LOCATION* pDst, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("UINT")] uint DstZ, [NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12_TEXTURE_COPY_LOCATION* pSrc, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pSrcBox)
        {
            Marshal.GetDelegateForFunctionPointer<_CopyTextureRegion>(lpVtbl->CopyTextureRegion)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
        }

        public void CopyResource([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstResource, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcResource)
        {
            Marshal.GetDelegateForFunctionPointer<_CopyResource>(lpVtbl->CopyResource)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDstResource, pSrcResource);
        }

        public void CopyTiles([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pTiledResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12_TILE_REGION_SIZE* pTileRegionSize, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, D3D12_TILE_COPY_FLAGS Flags)
        {
            Marshal.GetDelegateForFunctionPointer<_CopyTiles>(lpVtbl->CopyTiles)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
        }

        public void ResolveSubresource([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, DXGI_FORMAT Format)
        {
            Marshal.GetDelegateForFunctionPointer<_ResolveSubresource>(lpVtbl->ResolveSubresource)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
        }

        public void IASetPrimitiveTopology([NativeTypeName("D3D12_PRIMITIVE_TOPOLOGY")] D3D_PRIMITIVE_TOPOLOGY PrimitiveTopology)
        {
            Marshal.GetDelegateForFunctionPointer<_IASetPrimitiveTopology>(lpVtbl->IASetPrimitiveTopology)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), PrimitiveTopology);
        }

        public void RSSetViewports([NativeTypeName("UINT")] uint NumViewports, [NativeTypeName("const D3D12_VIEWPORT *")] D3D12_VIEWPORT* pViewports)
        {
            Marshal.GetDelegateForFunctionPointer<_RSSetViewports>(lpVtbl->RSSetViewports)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
        }

        public void RSSetScissorRects([NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            Marshal.GetDelegateForFunctionPointer<_RSSetScissorRects>(lpVtbl->RSSetScissorRects)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), NumRects, pRects);
        }

        public void OMSetBlendFactor([NativeTypeName("const FLOAT [4]")] float* BlendFactor)
        {
            Marshal.GetDelegateForFunctionPointer<_OMSetBlendFactor>(lpVtbl->OMSetBlendFactor)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), BlendFactor);
        }

        public void OMSetStencilRef([NativeTypeName("UINT")] uint StencilRef)
        {
            Marshal.GetDelegateForFunctionPointer<_OMSetStencilRef>(lpVtbl->OMSetStencilRef)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), StencilRef);
        }

        public void SetPipelineState([NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pPipelineState)
        {
            Marshal.GetDelegateForFunctionPointer<_SetPipelineState>(lpVtbl->SetPipelineState)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pPipelineState);
        }

        public void ResourceBarrier([NativeTypeName("UINT")] uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12_RESOURCE_BARRIER* pBarriers)
        {
            Marshal.GetDelegateForFunctionPointer<_ResourceBarrier>(lpVtbl->ResourceBarrier)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), NumBarriers, pBarriers);
        }

        public void ExecuteBundle([NativeTypeName("ID3D12GraphicsCommandList *")] ID3D12GraphicsCommandList* pCommandList)
        {
            Marshal.GetDelegateForFunctionPointer<_ExecuteBundle>(lpVtbl->ExecuteBundle)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pCommandList);
        }

        public void SetDescriptorHeaps([NativeTypeName("UINT")] uint NumDescriptorHeaps, [NativeTypeName("ID3D12DescriptorHeap *const *")] ID3D12DescriptorHeap** ppDescriptorHeaps)
        {
            Marshal.GetDelegateForFunctionPointer<_SetDescriptorHeaps>(lpVtbl->SetDescriptorHeaps)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), NumDescriptorHeaps, ppDescriptorHeaps);
        }

        public void SetComputeRootSignature([NativeTypeName("ID3D12RootSignature *")] ID3D12RootSignature* pRootSignature)
        {
            Marshal.GetDelegateForFunctionPointer<_SetComputeRootSignature>(lpVtbl->SetComputeRootSignature)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pRootSignature);
        }

        public void SetGraphicsRootSignature([NativeTypeName("ID3D12RootSignature *")] ID3D12RootSignature* pRootSignature)
        {
            Marshal.GetDelegateForFunctionPointer<_SetGraphicsRootSignature>(lpVtbl->SetGraphicsRootSignature)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pRootSignature);
        }

        public void SetComputeRootDescriptorTable([NativeTypeName("UINT")] uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor)
        {
            Marshal.GetDelegateForFunctionPointer<_SetComputeRootDescriptorTable>(lpVtbl->SetComputeRootDescriptorTable)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, BaseDescriptor);
        }

        public void SetGraphicsRootDescriptorTable([NativeTypeName("UINT")] uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor)
        {
            Marshal.GetDelegateForFunctionPointer<_SetGraphicsRootDescriptorTable>(lpVtbl->SetGraphicsRootDescriptorTable)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, BaseDescriptor);
        }

        public void SetComputeRoot32BitConstant([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint SrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues)
        {
            Marshal.GetDelegateForFunctionPointer<_SetComputeRoot32BitConstant>(lpVtbl->SetComputeRoot32BitConstant)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, SrcData, DestOffsetIn32BitValues);
        }

        public void SetGraphicsRoot32BitConstant([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint SrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues)
        {
            Marshal.GetDelegateForFunctionPointer<_SetGraphicsRoot32BitConstant>(lpVtbl->SetGraphicsRoot32BitConstant)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, SrcData, DestOffsetIn32BitValues);
        }

        public void SetComputeRoot32BitConstants([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues)
        {
            Marshal.GetDelegateForFunctionPointer<_SetComputeRoot32BitConstants>(lpVtbl->SetComputeRoot32BitConstants)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
        }

        public void SetGraphicsRoot32BitConstants([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues)
        {
            Marshal.GetDelegateForFunctionPointer<_SetGraphicsRoot32BitConstants>(lpVtbl->SetGraphicsRoot32BitConstants)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
        }

        public void SetComputeRootConstantBufferView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            Marshal.GetDelegateForFunctionPointer<_SetComputeRootConstantBufferView>(lpVtbl->SetComputeRootConstantBufferView)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void SetGraphicsRootConstantBufferView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            Marshal.GetDelegateForFunctionPointer<_SetGraphicsRootConstantBufferView>(lpVtbl->SetGraphicsRootConstantBufferView)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void SetComputeRootShaderResourceView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            Marshal.GetDelegateForFunctionPointer<_SetComputeRootShaderResourceView>(lpVtbl->SetComputeRootShaderResourceView)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void SetGraphicsRootShaderResourceView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            Marshal.GetDelegateForFunctionPointer<_SetGraphicsRootShaderResourceView>(lpVtbl->SetGraphicsRootShaderResourceView)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void SetComputeRootUnorderedAccessView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            Marshal.GetDelegateForFunctionPointer<_SetComputeRootUnorderedAccessView>(lpVtbl->SetComputeRootUnorderedAccessView)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void SetGraphicsRootUnorderedAccessView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            Marshal.GetDelegateForFunctionPointer<_SetGraphicsRootUnorderedAccessView>(lpVtbl->SetGraphicsRootUnorderedAccessView)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void IASetIndexBuffer([NativeTypeName("const D3D12_INDEX_BUFFER_VIEW *")] D3D12_INDEX_BUFFER_VIEW* pView)
        {
            Marshal.GetDelegateForFunctionPointer<_IASetIndexBuffer>(lpVtbl->IASetIndexBuffer)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pView);
        }

        public void IASetVertexBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("const D3D12_VERTEX_BUFFER_VIEW *")] D3D12_VERTEX_BUFFER_VIEW* pViews)
        {
            Marshal.GetDelegateForFunctionPointer<_IASetVertexBuffers>(lpVtbl->IASetVertexBuffers)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), StartSlot, NumViews, pViews);
        }

        public void SOSetTargets([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("const D3D12_STREAM_OUTPUT_BUFFER_VIEW *")] D3D12_STREAM_OUTPUT_BUFFER_VIEW* pViews)
        {
            Marshal.GetDelegateForFunctionPointer<_SOSetTargets>(lpVtbl->SOSetTargets)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), StartSlot, NumViews, pViews);
        }

        public void OMSetRenderTargets([NativeTypeName("UINT")] uint NumRenderTargetDescriptors, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pRenderTargetDescriptors, [NativeTypeName("BOOL")] int RTsSingleHandleToDescriptorRange, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pDepthStencilDescriptor)
        {
            Marshal.GetDelegateForFunctionPointer<_OMSetRenderTargets>(lpVtbl->OMSetRenderTargets)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
        }

        public void ClearDepthStencilView(D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView, D3D12_CLEAR_FLAGS ClearFlags, [NativeTypeName("FLOAT")] float Depth, [NativeTypeName("UINT8")] byte Stencil, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            Marshal.GetDelegateForFunctionPointer<_ClearDepthStencilView>(lpVtbl->ClearDepthStencilView)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
        }

        public void ClearRenderTargetView(D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView, [NativeTypeName("const FLOAT [4]")] float* ColorRGBA, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            Marshal.GetDelegateForFunctionPointer<_ClearRenderTargetView>(lpVtbl->ClearRenderTargetView)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RenderTargetView, ColorRGBA, NumRects, pRects);
        }

        public void ClearUnorderedAccessViewUint(D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const UINT [4]")] uint* Values, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            Marshal.GetDelegateForFunctionPointer<_ClearUnorderedAccessViewUint>(lpVtbl->ClearUnorderedAccessViewUint)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
        }

        public void ClearUnorderedAccessViewFloat(D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const FLOAT [4]")] float* Values, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            Marshal.GetDelegateForFunctionPointer<_ClearUnorderedAccessViewFloat>(lpVtbl->ClearUnorderedAccessViewFloat)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
        }

        public void DiscardResource([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12_DISCARD_REGION* pRegion)
        {
            Marshal.GetDelegateForFunctionPointer<_DiscardResource>(lpVtbl->DiscardResource)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pResource, pRegion);
        }

        public void BeginQuery([NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index)
        {
            Marshal.GetDelegateForFunctionPointer<_BeginQuery>(lpVtbl->BeginQuery)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
        }

        public void EndQuery([NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index)
        {
            Marshal.GetDelegateForFunctionPointer<_EndQuery>(lpVtbl->EndQuery)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
        }

        public void ResolveQueryData([NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint StartIndex, [NativeTypeName("UINT")] uint NumQueries, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset)
        {
            Marshal.GetDelegateForFunctionPointer<_ResolveQueryData>(lpVtbl->ResolveQueryData)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }

        public void SetPredication([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation)
        {
            Marshal.GetDelegateForFunctionPointer<_SetPredication>(lpVtbl->SetPredication)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pBuffer, AlignedBufferOffset, Operation);
        }

        public void SetMarker([NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            Marshal.GetDelegateForFunctionPointer<_SetMarker>(lpVtbl->SetMarker)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        public void BeginEvent([NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            Marshal.GetDelegateForFunctionPointer<_BeginEvent>(lpVtbl->BeginEvent)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        public void EndEvent()
        {
            Marshal.GetDelegateForFunctionPointer<_EndEvent>(lpVtbl->EndEvent)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this));
        }

        public void ExecuteIndirect([NativeTypeName("ID3D12CommandSignature *")] ID3D12CommandSignature* pCommandSignature, [NativeTypeName("UINT")] uint MaxCommandCount, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pArgumentBuffer, [NativeTypeName("UINT64")] ulong ArgumentBufferOffset, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pCountBuffer, [NativeTypeName("UINT64")] ulong CountBufferOffset)
        {
            Marshal.GetDelegateForFunctionPointer<_ExecuteIndirect>(lpVtbl->ExecuteIndirect)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
        }

        public void AtomicCopyBufferUINT([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT")] uint Dependencies, [NativeTypeName("ID3D12Resource *const *")] ID3D12Resource** ppDependentResources, [NativeTypeName("const D3D12_SUBRESOURCE_RANGE_UINT64 *")] D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges)
        {
            Marshal.GetDelegateForFunctionPointer<_AtomicCopyBufferUINT>(lpVtbl->AtomicCopyBufferUINT)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }

        public void AtomicCopyBufferUINT64([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT")] uint Dependencies, [NativeTypeName("ID3D12Resource *const *")] ID3D12Resource** ppDependentResources, [NativeTypeName("const D3D12_SUBRESOURCE_RANGE_UINT64 *")] D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges)
        {
            Marshal.GetDelegateForFunctionPointer<_AtomicCopyBufferUINT64>(lpVtbl->AtomicCopyBufferUINT64)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }

        public void OMSetDepthBounds([NativeTypeName("FLOAT")] float Min, [NativeTypeName("FLOAT")] float Max)
        {
            Marshal.GetDelegateForFunctionPointer<_OMSetDepthBounds>(lpVtbl->OMSetDepthBounds)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), Min, Max);
        }

        public void SetSamplePositions([NativeTypeName("UINT")] uint NumSamplesPerPixel, [NativeTypeName("UINT")] uint NumPixels, [NativeTypeName("D3D12_SAMPLE_POSITION *")] D3D12_SAMPLE_POSITION* pSamplePositions)
        {
            Marshal.GetDelegateForFunctionPointer<_SetSamplePositions>(lpVtbl->SetSamplePositions)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), NumSamplesPerPixel, NumPixels, pSamplePositions);
        }

        public void ResolveSubresourceRegion([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("D3D12_RECT *")] RECT* pSrcRect, DXGI_FORMAT Format, D3D12_RESOLVE_MODE ResolveMode)
        {
            Marshal.GetDelegateForFunctionPointer<_ResolveSubresourceRegion>(lpVtbl->ResolveSubresourceRegion)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
        }

        public void SetViewInstanceMask([NativeTypeName("UINT")] uint Mask)
        {
            Marshal.GetDelegateForFunctionPointer<_SetViewInstanceMask>(lpVtbl->SetViewInstanceMask)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), Mask);
        }

        public void WriteBufferImmediate([NativeTypeName("UINT")] uint Count, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")] D3D12_WRITEBUFFERIMMEDIATE_PARAMETER* pParams, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")] D3D12_WRITEBUFFERIMMEDIATE_MODE* pModes)
        {
            Marshal.GetDelegateForFunctionPointer<_WriteBufferImmediate>(lpVtbl->WriteBufferImmediate)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), Count, pParams, pModes);
        }

        public void SetProtectedResourceSession([NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession)
        {
            Marshal.GetDelegateForFunctionPointer<_SetProtectedResourceSession>(lpVtbl->SetProtectedResourceSession)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pProtectedResourceSession);
        }

        public void BeginRenderPass([NativeTypeName("UINT")] uint NumRenderTargets, [NativeTypeName("const D3D12_RENDER_PASS_RENDER_TARGET_DESC *")] D3D12_RENDER_PASS_RENDER_TARGET_DESC* pRenderTargets, [NativeTypeName("const D3D12_RENDER_PASS_DEPTH_STENCIL_DESC *")] D3D12_RENDER_PASS_DEPTH_STENCIL_DESC* pDepthStencil, D3D12_RENDER_PASS_FLAGS Flags)
        {
            Marshal.GetDelegateForFunctionPointer<_BeginRenderPass>(lpVtbl->BeginRenderPass)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), NumRenderTargets, pRenderTargets, pDepthStencil, Flags);
        }

        public void EndRenderPass()
        {
            Marshal.GetDelegateForFunctionPointer<_EndRenderPass>(lpVtbl->EndRenderPass)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this));
        }

        public void InitializeMetaCommand([NativeTypeName("ID3D12MetaCommand *")] ID3D12MetaCommand* pMetaCommand, [NativeTypeName("const void *")] void* pInitializationParametersData, [NativeTypeName("SIZE_T")] nuint InitializationParametersDataSizeInBytes)
        {
            Marshal.GetDelegateForFunctionPointer<_InitializeMetaCommand>(lpVtbl->InitializeMetaCommand)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pMetaCommand, pInitializationParametersData, InitializationParametersDataSizeInBytes);
        }

        public void ExecuteMetaCommand([NativeTypeName("ID3D12MetaCommand *")] ID3D12MetaCommand* pMetaCommand, [NativeTypeName("const void *")] void* pExecutionParametersData, [NativeTypeName("SIZE_T")] nuint ExecutionParametersDataSizeInBytes)
        {
            Marshal.GetDelegateForFunctionPointer<_ExecuteMetaCommand>(lpVtbl->ExecuteMetaCommand)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pMetaCommand, pExecutionParametersData, ExecutionParametersDataSizeInBytes);
        }

        public void BuildRaytracingAccelerationStructure([NativeTypeName("const D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC *")] D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC* pDesc, [NativeTypeName("UINT")] uint NumPostbuildInfoDescs, [NativeTypeName("const D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC *")] D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC* pPostbuildInfoDescs)
        {
            Marshal.GetDelegateForFunctionPointer<_BuildRaytracingAccelerationStructure>(lpVtbl->BuildRaytracingAccelerationStructure)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDesc, NumPostbuildInfoDescs, pPostbuildInfoDescs);
        }

        public void EmitRaytracingAccelerationStructurePostbuildInfo([NativeTypeName("const D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC *")] D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC* pDesc, [NativeTypeName("UINT")] uint NumSourceAccelerationStructures, [NativeTypeName("const D3D12_GPU_VIRTUAL_ADDRESS *")] ulong* pSourceAccelerationStructureData)
        {
            Marshal.GetDelegateForFunctionPointer<_EmitRaytracingAccelerationStructurePostbuildInfo>(lpVtbl->EmitRaytracingAccelerationStructurePostbuildInfo)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDesc, NumSourceAccelerationStructures, pSourceAccelerationStructureData);
        }

        public void CopyRaytracingAccelerationStructure([NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong DestAccelerationStructureData, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong SourceAccelerationStructureData, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE Mode)
        {
            Marshal.GetDelegateForFunctionPointer<_CopyRaytracingAccelerationStructure>(lpVtbl->CopyRaytracingAccelerationStructure)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), DestAccelerationStructureData, SourceAccelerationStructureData, Mode);
        }

        public void SetPipelineState1([NativeTypeName("ID3D12StateObject *")] ID3D12StateObject* pStateObject)
        {
            Marshal.GetDelegateForFunctionPointer<_SetPipelineState1>(lpVtbl->SetPipelineState1)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pStateObject);
        }

        public void DispatchRays([NativeTypeName("const D3D12_DISPATCH_RAYS_DESC *")] D3D12_DISPATCH_RAYS_DESC* pDesc)
        {
            Marshal.GetDelegateForFunctionPointer<_DispatchRays>(lpVtbl->DispatchRays)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDesc);
        }

        public void RSSetShadingRate(D3D12_SHADING_RATE baseShadingRate, [NativeTypeName("const D3D12_SHADING_RATE_COMBINER *")] D3D12_SHADING_RATE_COMBINER* combiners)
        {
            Marshal.GetDelegateForFunctionPointer<_RSSetShadingRate>(lpVtbl->RSSetShadingRate)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), baseShadingRate, combiners);
        }

        public void RSSetShadingRateImage([NativeTypeName("ID3D12Resource *")] ID3D12Resource* shadingRateImage)
        {
            Marshal.GetDelegateForFunctionPointer<_RSSetShadingRateImage>(lpVtbl->RSSetShadingRateImage)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), shadingRateImage);
        }

        public void DispatchMesh([NativeTypeName("UINT")] uint ThreadGroupCountX, [NativeTypeName("UINT")] uint ThreadGroupCountY, [NativeTypeName("UINT")] uint ThreadGroupCountZ)
        {
            Marshal.GetDelegateForFunctionPointer<_DispatchMesh>(lpVtbl->DispatchMesh)((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
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

            [NativeTypeName("D3D12_COMMAND_LIST_TYPE () __attribute__((stdcall))")]
            public new IntPtr GetType;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Close;

            [NativeTypeName("HRESULT (ID3D12CommandAllocator *, ID3D12PipelineState *) __attribute__((stdcall))")]
            public IntPtr Reset;

            [NativeTypeName("void (ID3D12PipelineState *) __attribute__((stdcall))")]
            public IntPtr ClearState;

            [NativeTypeName("void (UINT, UINT, UINT, UINT) __attribute__((stdcall))")]
            public IntPtr DrawInstanced;

            [NativeTypeName("void (UINT, UINT, UINT, INT, UINT) __attribute__((stdcall))")]
            public IntPtr DrawIndexedInstanced;

            [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
            public IntPtr Dispatch;

            [NativeTypeName("void (ID3D12Resource *, UINT64, ID3D12Resource *, UINT64, UINT64) __attribute__((stdcall))")]
            public IntPtr CopyBufferRegion;

            [NativeTypeName("void (const D3D12_TEXTURE_COPY_LOCATION *, UINT, UINT, UINT, const D3D12_TEXTURE_COPY_LOCATION *, const D3D12_BOX *) __attribute__((stdcall))")]
            public IntPtr CopyTextureRegion;

            [NativeTypeName("void (ID3D12Resource *, ID3D12Resource *) __attribute__((stdcall))")]
            public IntPtr CopyResource;

            [NativeTypeName("void (ID3D12Resource *, const D3D12_TILED_RESOURCE_COORDINATE *, const D3D12_TILE_REGION_SIZE *, ID3D12Resource *, UINT64, D3D12_TILE_COPY_FLAGS) __attribute__((stdcall))")]
            public IntPtr CopyTiles;

            [NativeTypeName("void (ID3D12Resource *, UINT, ID3D12Resource *, UINT, DXGI_FORMAT) __attribute__((stdcall))")]
            public IntPtr ResolveSubresource;

            [NativeTypeName("void (D3D12_PRIMITIVE_TOPOLOGY) __attribute__((stdcall))")]
            public IntPtr IASetPrimitiveTopology;

            [NativeTypeName("void (UINT, const D3D12_VIEWPORT *) __attribute__((stdcall))")]
            public IntPtr RSSetViewports;

            [NativeTypeName("void (UINT, const D3D12_RECT *) __attribute__((stdcall))")]
            public IntPtr RSSetScissorRects;

            [NativeTypeName("void (const FLOAT *) __attribute__((stdcall))")]
            public IntPtr OMSetBlendFactor;

            [NativeTypeName("void (UINT) __attribute__((stdcall))")]
            public IntPtr OMSetStencilRef;

            [NativeTypeName("void (ID3D12PipelineState *) __attribute__((stdcall))")]
            public IntPtr SetPipelineState;

            [NativeTypeName("void (UINT, const D3D12_RESOURCE_BARRIER *) __attribute__((stdcall))")]
            public IntPtr ResourceBarrier;

            [NativeTypeName("void (ID3D12GraphicsCommandList *) __attribute__((stdcall))")]
            public IntPtr ExecuteBundle;

            [NativeTypeName("void (UINT, ID3D12DescriptorHeap *const *) __attribute__((stdcall))")]
            public IntPtr SetDescriptorHeaps;

            [NativeTypeName("void (ID3D12RootSignature *) __attribute__((stdcall))")]
            public IntPtr SetComputeRootSignature;

            [NativeTypeName("void (ID3D12RootSignature *) __attribute__((stdcall))")]
            public IntPtr SetGraphicsRootSignature;

            [NativeTypeName("void (UINT, D3D12_GPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public IntPtr SetComputeRootDescriptorTable;

            [NativeTypeName("void (UINT, D3D12_GPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public IntPtr SetGraphicsRootDescriptorTable;

            [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
            public IntPtr SetComputeRoot32BitConstant;

            [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
            public IntPtr SetGraphicsRoot32BitConstant;

            [NativeTypeName("void (UINT, UINT, const void *, UINT) __attribute__((stdcall))")]
            public IntPtr SetComputeRoot32BitConstants;

            [NativeTypeName("void (UINT, UINT, const void *, UINT) __attribute__((stdcall))")]
            public IntPtr SetGraphicsRoot32BitConstants;

            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public IntPtr SetComputeRootConstantBufferView;

            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public IntPtr SetGraphicsRootConstantBufferView;

            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public IntPtr SetComputeRootShaderResourceView;

            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public IntPtr SetGraphicsRootShaderResourceView;

            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public IntPtr SetComputeRootUnorderedAccessView;

            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public IntPtr SetGraphicsRootUnorderedAccessView;

            [NativeTypeName("void (const D3D12_INDEX_BUFFER_VIEW *) __attribute__((stdcall))")]
            public IntPtr IASetIndexBuffer;

            [NativeTypeName("void (UINT, UINT, const D3D12_VERTEX_BUFFER_VIEW *) __attribute__((stdcall))")]
            public IntPtr IASetVertexBuffers;

            [NativeTypeName("void (UINT, UINT, const D3D12_STREAM_OUTPUT_BUFFER_VIEW *) __attribute__((stdcall))")]
            public IntPtr SOSetTargets;

            [NativeTypeName("void (UINT, const D3D12_CPU_DESCRIPTOR_HANDLE *, BOOL, const D3D12_CPU_DESCRIPTOR_HANDLE *) __attribute__((stdcall))")]
            public IntPtr OMSetRenderTargets;

            [NativeTypeName("void (D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CLEAR_FLAGS, FLOAT, UINT8, UINT, const D3D12_RECT *) __attribute__((stdcall))")]
            public IntPtr ClearDepthStencilView;

            [NativeTypeName("void (D3D12_CPU_DESCRIPTOR_HANDLE, const FLOAT *, UINT, const D3D12_RECT *) __attribute__((stdcall))")]
            public IntPtr ClearRenderTargetView;

            [NativeTypeName("void (D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource *, const UINT *, UINT, const D3D12_RECT *) __attribute__((stdcall))")]
            public IntPtr ClearUnorderedAccessViewUint;

            [NativeTypeName("void (D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource *, const FLOAT *, UINT, const D3D12_RECT *) __attribute__((stdcall))")]
            public IntPtr ClearUnorderedAccessViewFloat;

            [NativeTypeName("void (ID3D12Resource *, const D3D12_DISCARD_REGION *) __attribute__((stdcall))")]
            public IntPtr DiscardResource;

            [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))")]
            public IntPtr BeginQuery;

            [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))")]
            public IntPtr EndQuery;

            [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT, UINT, ID3D12Resource *, UINT64) __attribute__((stdcall))")]
            public IntPtr ResolveQueryData;

            [NativeTypeName("void (ID3D12Resource *, UINT64, D3D12_PREDICATION_OP) __attribute__((stdcall))")]
            public IntPtr SetPredication;

            [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
            public IntPtr SetMarker;

            [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
            public IntPtr BeginEvent;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr EndEvent;

            [NativeTypeName("void (ID3D12CommandSignature *, UINT, ID3D12Resource *, UINT64, ID3D12Resource *, UINT64) __attribute__((stdcall))")]
            public IntPtr ExecuteIndirect;

            [NativeTypeName("void (ID3D12Resource *, UINT64, ID3D12Resource *, UINT64, UINT, ID3D12Resource *const *, const D3D12_SUBRESOURCE_RANGE_UINT64 *) __attribute__((stdcall))")]
            public IntPtr AtomicCopyBufferUINT;

            [NativeTypeName("void (ID3D12Resource *, UINT64, ID3D12Resource *, UINT64, UINT, ID3D12Resource *const *, const D3D12_SUBRESOURCE_RANGE_UINT64 *) __attribute__((stdcall))")]
            public IntPtr AtomicCopyBufferUINT64;

            [NativeTypeName("void (FLOAT, FLOAT) __attribute__((stdcall))")]
            public IntPtr OMSetDepthBounds;

            [NativeTypeName("void (UINT, UINT, D3D12_SAMPLE_POSITION *) __attribute__((stdcall))")]
            public IntPtr SetSamplePositions;

            [NativeTypeName("void (ID3D12Resource *, UINT, UINT, UINT, ID3D12Resource *, UINT, D3D12_RECT *, DXGI_FORMAT, D3D12_RESOLVE_MODE) __attribute__((stdcall))")]
            public IntPtr ResolveSubresourceRegion;

            [NativeTypeName("void (UINT) __attribute__((stdcall))")]
            public IntPtr SetViewInstanceMask;

            [NativeTypeName("void (UINT, const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *, const D3D12_WRITEBUFFERIMMEDIATE_MODE *) __attribute__((stdcall))")]
            public IntPtr WriteBufferImmediate;

            [NativeTypeName("void (ID3D12ProtectedResourceSession *) __attribute__((stdcall))")]
            public IntPtr SetProtectedResourceSession;

            [NativeTypeName("void (UINT, const D3D12_RENDER_PASS_RENDER_TARGET_DESC *, const D3D12_RENDER_PASS_DEPTH_STENCIL_DESC *, D3D12_RENDER_PASS_FLAGS) __attribute__((stdcall))")]
            public IntPtr BeginRenderPass;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr EndRenderPass;

            [NativeTypeName("void (ID3D12MetaCommand *, const void *, SIZE_T) __attribute__((stdcall))")]
            public IntPtr InitializeMetaCommand;

            [NativeTypeName("void (ID3D12MetaCommand *, const void *, SIZE_T) __attribute__((stdcall))")]
            public IntPtr ExecuteMetaCommand;

            [NativeTypeName("void (const D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC *, UINT, const D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC *) __attribute__((stdcall))")]
            public IntPtr BuildRaytracingAccelerationStructure;

            [NativeTypeName("void (const D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC *, UINT, const D3D12_GPU_VIRTUAL_ADDRESS *) __attribute__((stdcall))")]
            public IntPtr EmitRaytracingAccelerationStructurePostbuildInfo;

            [NativeTypeName("void (D3D12_GPU_VIRTUAL_ADDRESS, D3D12_GPU_VIRTUAL_ADDRESS, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE) __attribute__((stdcall))")]
            public IntPtr CopyRaytracingAccelerationStructure;

            [NativeTypeName("void (ID3D12StateObject *) __attribute__((stdcall))")]
            public IntPtr SetPipelineState1;

            [NativeTypeName("void (const D3D12_DISPATCH_RAYS_DESC *) __attribute__((stdcall))")]
            public IntPtr DispatchRays;

            [NativeTypeName("void (D3D12_SHADING_RATE, const D3D12_SHADING_RATE_COMBINER *) __attribute__((stdcall))")]
            public IntPtr RSSetShadingRate;

            [NativeTypeName("void (ID3D12Resource *) __attribute__((stdcall))")]
            public IntPtr RSSetShadingRateImage;

            [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
            public IntPtr DispatchMesh;
        }
    }
}
