// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8754318E-D3A9-4541-98CF-645B50DC4874")]
    public unsafe partial struct ID3D12GraphicsCommandList4
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return lpVtbl->SetPrivateDataInterface((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return lpVtbl->SetName((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return lpVtbl->GetDevice((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        public new D3D12_COMMAND_LIST_TYPE GetType()
        {
            return lpVtbl->GetType((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return lpVtbl->Close((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset([NativeTypeName("ID3D12CommandAllocator *")] ID3D12CommandAllocator* pAllocator, [NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pInitialState)
        {
            return lpVtbl->Reset((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pAllocator, pInitialState);
        }

        public void ClearState([NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pPipelineState)
        {
            lpVtbl->ClearState((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pPipelineState);
        }

        public void DrawInstanced([NativeTypeName("UINT")] uint VertexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation)
        {
            lpVtbl->DrawInstanced((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
        }

        public void DrawIndexedInstanced([NativeTypeName("UINT")] uint IndexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartIndexLocation, [NativeTypeName("INT")] int BaseVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation)
        {
            lpVtbl->DrawIndexedInstanced((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
        }

        public void Dispatch([NativeTypeName("UINT")] uint ThreadGroupCountX, [NativeTypeName("UINT")] uint ThreadGroupCountY, [NativeTypeName("UINT")] uint ThreadGroupCountZ)
        {
            lpVtbl->Dispatch((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
        }

        public void CopyBufferRegion([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT64")] ulong NumBytes)
        {
            lpVtbl->CopyBufferRegion((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
        }

        public void CopyTextureRegion([NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12_TEXTURE_COPY_LOCATION* pDst, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("UINT")] uint DstZ, [NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12_TEXTURE_COPY_LOCATION* pSrc, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pSrcBox)
        {
            lpVtbl->CopyTextureRegion((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
        }

        public void CopyResource([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstResource, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcResource)
        {
            lpVtbl->CopyResource((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pDstResource, pSrcResource);
        }

        public void CopyTiles([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pTiledResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12_TILE_REGION_SIZE* pTileRegionSize, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, D3D12_TILE_COPY_FLAGS Flags)
        {
            lpVtbl->CopyTiles((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
        }

        public void ResolveSubresource([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, DXGI_FORMAT Format)
        {
            lpVtbl->ResolveSubresource((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
        }

        public void IASetPrimitiveTopology([NativeTypeName("D3D12_PRIMITIVE_TOPOLOGY")] D3D_PRIMITIVE_TOPOLOGY PrimitiveTopology)
        {
            lpVtbl->IASetPrimitiveTopology((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), PrimitiveTopology);
        }

        public void RSSetViewports([NativeTypeName("UINT")] uint NumViewports, [NativeTypeName("const D3D12_VIEWPORT *")] D3D12_VIEWPORT* pViewports)
        {
            lpVtbl->RSSetViewports((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
        }

        public void RSSetScissorRects([NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            lpVtbl->RSSetScissorRects((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), NumRects, pRects);
        }

        public void OMSetBlendFactor([NativeTypeName("const FLOAT [4]")] float* BlendFactor)
        {
            lpVtbl->OMSetBlendFactor((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), BlendFactor);
        }

        public void OMSetStencilRef([NativeTypeName("UINT")] uint StencilRef)
        {
            lpVtbl->OMSetStencilRef((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), StencilRef);
        }

        public void SetPipelineState([NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pPipelineState)
        {
            lpVtbl->SetPipelineState((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pPipelineState);
        }

        public void ResourceBarrier([NativeTypeName("UINT")] uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12_RESOURCE_BARRIER* pBarriers)
        {
            lpVtbl->ResourceBarrier((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), NumBarriers, pBarriers);
        }

        public void ExecuteBundle([NativeTypeName("ID3D12GraphicsCommandList *")] ID3D12GraphicsCommandList* pCommandList)
        {
            lpVtbl->ExecuteBundle((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pCommandList);
        }

        public void SetDescriptorHeaps([NativeTypeName("UINT")] uint NumDescriptorHeaps, [NativeTypeName("ID3D12DescriptorHeap *const *")] ID3D12DescriptorHeap** ppDescriptorHeaps)
        {
            lpVtbl->SetDescriptorHeaps((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), NumDescriptorHeaps, ppDescriptorHeaps);
        }

        public void SetComputeRootSignature([NativeTypeName("ID3D12RootSignature *")] ID3D12RootSignature* pRootSignature)
        {
            lpVtbl->SetComputeRootSignature((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pRootSignature);
        }

        public void SetGraphicsRootSignature([NativeTypeName("ID3D12RootSignature *")] ID3D12RootSignature* pRootSignature)
        {
            lpVtbl->SetGraphicsRootSignature((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pRootSignature);
        }

        public void SetComputeRootDescriptorTable([NativeTypeName("UINT")] uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor)
        {
            lpVtbl->SetComputeRootDescriptorTable((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), RootParameterIndex, BaseDescriptor);
        }

        public void SetGraphicsRootDescriptorTable([NativeTypeName("UINT")] uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor)
        {
            lpVtbl->SetGraphicsRootDescriptorTable((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), RootParameterIndex, BaseDescriptor);
        }

        public void SetComputeRoot32BitConstant([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint SrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues)
        {
            lpVtbl->SetComputeRoot32BitConstant((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), RootParameterIndex, SrcData, DestOffsetIn32BitValues);
        }

        public void SetGraphicsRoot32BitConstant([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint SrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues)
        {
            lpVtbl->SetGraphicsRoot32BitConstant((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), RootParameterIndex, SrcData, DestOffsetIn32BitValues);
        }

        public void SetComputeRoot32BitConstants([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues)
        {
            lpVtbl->SetComputeRoot32BitConstants((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
        }

        public void SetGraphicsRoot32BitConstants([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues)
        {
            lpVtbl->SetGraphicsRoot32BitConstants((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
        }

        public void SetComputeRootConstantBufferView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            lpVtbl->SetComputeRootConstantBufferView((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void SetGraphicsRootConstantBufferView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            lpVtbl->SetGraphicsRootConstantBufferView((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void SetComputeRootShaderResourceView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            lpVtbl->SetComputeRootShaderResourceView((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void SetGraphicsRootShaderResourceView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            lpVtbl->SetGraphicsRootShaderResourceView((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void SetComputeRootUnorderedAccessView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            lpVtbl->SetComputeRootUnorderedAccessView((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void SetGraphicsRootUnorderedAccessView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            lpVtbl->SetGraphicsRootUnorderedAccessView((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void IASetIndexBuffer([NativeTypeName("const D3D12_INDEX_BUFFER_VIEW *")] D3D12_INDEX_BUFFER_VIEW* pView)
        {
            lpVtbl->IASetIndexBuffer((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pView);
        }

        public void IASetVertexBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("const D3D12_VERTEX_BUFFER_VIEW *")] D3D12_VERTEX_BUFFER_VIEW* pViews)
        {
            lpVtbl->IASetVertexBuffers((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), StartSlot, NumViews, pViews);
        }

        public void SOSetTargets([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("const D3D12_STREAM_OUTPUT_BUFFER_VIEW *")] D3D12_STREAM_OUTPUT_BUFFER_VIEW* pViews)
        {
            lpVtbl->SOSetTargets((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), StartSlot, NumViews, pViews);
        }

        public void OMSetRenderTargets([NativeTypeName("UINT")] uint NumRenderTargetDescriptors, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pRenderTargetDescriptors, [NativeTypeName("BOOL")] int RTsSingleHandleToDescriptorRange, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pDepthStencilDescriptor)
        {
            lpVtbl->OMSetRenderTargets((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
        }

        public void ClearDepthStencilView(D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView, D3D12_CLEAR_FLAGS ClearFlags, [NativeTypeName("FLOAT")] float Depth, [NativeTypeName("UINT8")] byte Stencil, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            lpVtbl->ClearDepthStencilView((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
        }

        public void ClearRenderTargetView(D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView, [NativeTypeName("const FLOAT [4]")] float* ColorRGBA, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            lpVtbl->ClearRenderTargetView((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), RenderTargetView, ColorRGBA, NumRects, pRects);
        }

        public void ClearUnorderedAccessViewUint(D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const UINT [4]")] uint* Values, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            lpVtbl->ClearUnorderedAccessViewUint((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
        }

        public void ClearUnorderedAccessViewFloat(D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const FLOAT [4]")] float* Values, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            lpVtbl->ClearUnorderedAccessViewFloat((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
        }

        public void DiscardResource([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12_DISCARD_REGION* pRegion)
        {
            lpVtbl->DiscardResource((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pResource, pRegion);
        }

        public void BeginQuery([NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index)
        {
            lpVtbl->BeginQuery((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
        }

        public void EndQuery([NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index)
        {
            lpVtbl->EndQuery((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
        }

        public void ResolveQueryData([NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint StartIndex, [NativeTypeName("UINT")] uint NumQueries, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset)
        {
            lpVtbl->ResolveQueryData((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }

        public void SetPredication([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation)
        {
            lpVtbl->SetPredication((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pBuffer, AlignedBufferOffset, Operation);
        }

        public void SetMarker([NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            lpVtbl->SetMarker((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        public void BeginEvent([NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            lpVtbl->BeginEvent((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        public void EndEvent()
        {
            lpVtbl->EndEvent((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this));
        }

        public void ExecuteIndirect([NativeTypeName("ID3D12CommandSignature *")] ID3D12CommandSignature* pCommandSignature, [NativeTypeName("UINT")] uint MaxCommandCount, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pArgumentBuffer, [NativeTypeName("UINT64")] ulong ArgumentBufferOffset, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pCountBuffer, [NativeTypeName("UINT64")] ulong CountBufferOffset)
        {
            lpVtbl->ExecuteIndirect((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
        }

        public void AtomicCopyBufferUINT([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT")] uint Dependencies, [NativeTypeName("ID3D12Resource *const *")] ID3D12Resource** ppDependentResources, [NativeTypeName("const D3D12_SUBRESOURCE_RANGE_UINT64 *")] D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges)
        {
            lpVtbl->AtomicCopyBufferUINT((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }

        public void AtomicCopyBufferUINT64([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT")] uint Dependencies, [NativeTypeName("ID3D12Resource *const *")] ID3D12Resource** ppDependentResources, [NativeTypeName("const D3D12_SUBRESOURCE_RANGE_UINT64 *")] D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges)
        {
            lpVtbl->AtomicCopyBufferUINT64((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }

        public void OMSetDepthBounds([NativeTypeName("FLOAT")] float Min, [NativeTypeName("FLOAT")] float Max)
        {
            lpVtbl->OMSetDepthBounds((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), Min, Max);
        }

        public void SetSamplePositions([NativeTypeName("UINT")] uint NumSamplesPerPixel, [NativeTypeName("UINT")] uint NumPixels, [NativeTypeName("D3D12_SAMPLE_POSITION *")] D3D12_SAMPLE_POSITION* pSamplePositions)
        {
            lpVtbl->SetSamplePositions((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), NumSamplesPerPixel, NumPixels, pSamplePositions);
        }

        public void ResolveSubresourceRegion([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("D3D12_RECT *")] RECT* pSrcRect, DXGI_FORMAT Format, D3D12_RESOLVE_MODE ResolveMode)
        {
            lpVtbl->ResolveSubresourceRegion((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
        }

        public void SetViewInstanceMask([NativeTypeName("UINT")] uint Mask)
        {
            lpVtbl->SetViewInstanceMask((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), Mask);
        }

        public void WriteBufferImmediate([NativeTypeName("UINT")] uint Count, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")] D3D12_WRITEBUFFERIMMEDIATE_PARAMETER* pParams, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")] D3D12_WRITEBUFFERIMMEDIATE_MODE* pModes)
        {
            lpVtbl->WriteBufferImmediate((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), Count, pParams, pModes);
        }

        public void SetProtectedResourceSession([NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession)
        {
            lpVtbl->SetProtectedResourceSession((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pProtectedResourceSession);
        }

        public void BeginRenderPass([NativeTypeName("UINT")] uint NumRenderTargets, [NativeTypeName("const D3D12_RENDER_PASS_RENDER_TARGET_DESC *")] D3D12_RENDER_PASS_RENDER_TARGET_DESC* pRenderTargets, [NativeTypeName("const D3D12_RENDER_PASS_DEPTH_STENCIL_DESC *")] D3D12_RENDER_PASS_DEPTH_STENCIL_DESC* pDepthStencil, D3D12_RENDER_PASS_FLAGS Flags)
        {
            lpVtbl->BeginRenderPass((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), NumRenderTargets, pRenderTargets, pDepthStencil, Flags);
        }

        public void EndRenderPass()
        {
            lpVtbl->EndRenderPass((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this));
        }

        public void InitializeMetaCommand([NativeTypeName("ID3D12MetaCommand *")] ID3D12MetaCommand* pMetaCommand, [NativeTypeName("const void *")] void* pInitializationParametersData, [NativeTypeName("SIZE_T")] nuint InitializationParametersDataSizeInBytes)
        {
            lpVtbl->InitializeMetaCommand((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pMetaCommand, pInitializationParametersData, InitializationParametersDataSizeInBytes);
        }

        public void ExecuteMetaCommand([NativeTypeName("ID3D12MetaCommand *")] ID3D12MetaCommand* pMetaCommand, [NativeTypeName("const void *")] void* pExecutionParametersData, [NativeTypeName("SIZE_T")] nuint ExecutionParametersDataSizeInBytes)
        {
            lpVtbl->ExecuteMetaCommand((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pMetaCommand, pExecutionParametersData, ExecutionParametersDataSizeInBytes);
        }

        public void BuildRaytracingAccelerationStructure([NativeTypeName("const D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC *")] D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC* pDesc, [NativeTypeName("UINT")] uint NumPostbuildInfoDescs, [NativeTypeName("const D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC *")] D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC* pPostbuildInfoDescs)
        {
            lpVtbl->BuildRaytracingAccelerationStructure((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pDesc, NumPostbuildInfoDescs, pPostbuildInfoDescs);
        }

        public void EmitRaytracingAccelerationStructurePostbuildInfo([NativeTypeName("const D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC *")] D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC* pDesc, [NativeTypeName("UINT")] uint NumSourceAccelerationStructures, [NativeTypeName("const D3D12_GPU_VIRTUAL_ADDRESS *")] ulong* pSourceAccelerationStructureData)
        {
            lpVtbl->EmitRaytracingAccelerationStructurePostbuildInfo((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pDesc, NumSourceAccelerationStructures, pSourceAccelerationStructureData);
        }

        public void CopyRaytracingAccelerationStructure([NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong DestAccelerationStructureData, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong SourceAccelerationStructureData, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE Mode)
        {
            lpVtbl->CopyRaytracingAccelerationStructure((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), DestAccelerationStructureData, SourceAccelerationStructureData, Mode);
        }

        public void SetPipelineState1([NativeTypeName("ID3D12StateObject *")] ID3D12StateObject* pStateObject)
        {
            lpVtbl->SetPipelineState1((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pStateObject);
        }

        public void DispatchRays([NativeTypeName("const D3D12_DISPATCH_RAYS_DESC *")] D3D12_DISPATCH_RAYS_DESC* pDesc)
        {
            lpVtbl->DispatchRays((ID3D12GraphicsCommandList4*)Unsafe.AsPointer(ref this), pDesc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ushort*, int> SetName;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, Guid*, void**, int> GetDevice;

            [NativeTypeName("D3D12_COMMAND_LIST_TYPE () __attribute__((stdcall))")]
            public new delegate* stdcall<ID3D12GraphicsCommandList4*, D3D12_COMMAND_LIST_TYPE> GetType;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, int> Close;

            [NativeTypeName("HRESULT (ID3D12CommandAllocator *, ID3D12PipelineState *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12CommandAllocator*, ID3D12PipelineState*, int> Reset;

            [NativeTypeName("void (ID3D12PipelineState *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12PipelineState*, void> ClearState;

            [NativeTypeName("void (UINT, UINT, UINT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, uint, uint, uint, void> DrawInstanced;

            [NativeTypeName("void (UINT, UINT, UINT, INT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, uint, uint, int, uint, void> DrawIndexedInstanced;

            [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, uint, uint, void> Dispatch;

            [NativeTypeName("void (ID3D12Resource *, UINT64, ID3D12Resource *, UINT64, UINT64) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void> CopyBufferRegion;

            [NativeTypeName("void (const D3D12_TEXTURE_COPY_LOCATION *, UINT, UINT, UINT, const D3D12_TEXTURE_COPY_LOCATION *, const D3D12_BOX *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, D3D12_TEXTURE_COPY_LOCATION*, uint, uint, uint, D3D12_TEXTURE_COPY_LOCATION*, D3D12_BOX*, void> CopyTextureRegion;

            [NativeTypeName("void (ID3D12Resource *, ID3D12Resource *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12Resource*, ID3D12Resource*, void> CopyResource;

            [NativeTypeName("void (ID3D12Resource *, const D3D12_TILED_RESOURCE_COORDINATE *, const D3D12_TILE_REGION_SIZE *, ID3D12Resource *, UINT64, D3D12_TILE_COPY_FLAGS) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12Resource*, D3D12_TILED_RESOURCE_COORDINATE*, D3D12_TILE_REGION_SIZE*, ID3D12Resource*, ulong, D3D12_TILE_COPY_FLAGS, void> CopyTiles;

            [NativeTypeName("void (ID3D12Resource *, UINT, ID3D12Resource *, UINT, DXGI_FORMAT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12Resource*, uint, ID3D12Resource*, uint, DXGI_FORMAT, void> ResolveSubresource;

            [NativeTypeName("void (D3D12_PRIMITIVE_TOPOLOGY) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, D3D_PRIMITIVE_TOPOLOGY, void> IASetPrimitiveTopology;

            [NativeTypeName("void (UINT, const D3D12_VIEWPORT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, D3D12_VIEWPORT*, void> RSSetViewports;

            [NativeTypeName("void (UINT, const D3D12_RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, RECT*, void> RSSetScissorRects;

            [NativeTypeName("void (const FLOAT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, float*, void> OMSetBlendFactor;

            [NativeTypeName("void (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, void> OMSetStencilRef;

            [NativeTypeName("void (ID3D12PipelineState *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12PipelineState*, void> SetPipelineState;

            [NativeTypeName("void (UINT, const D3D12_RESOURCE_BARRIER *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, D3D12_RESOURCE_BARRIER*, void> ResourceBarrier;

            [NativeTypeName("void (ID3D12GraphicsCommandList *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12GraphicsCommandList*, void> ExecuteBundle;

            [NativeTypeName("void (UINT, ID3D12DescriptorHeap *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, ID3D12DescriptorHeap**, void> SetDescriptorHeaps;

            [NativeTypeName("void (ID3D12RootSignature *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12RootSignature*, void> SetComputeRootSignature;

            [NativeTypeName("void (ID3D12RootSignature *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12RootSignature*, void> SetGraphicsRootSignature;

            [NativeTypeName("void (UINT, D3D12_GPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, D3D12_GPU_DESCRIPTOR_HANDLE, void> SetComputeRootDescriptorTable;

            [NativeTypeName("void (UINT, D3D12_GPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, D3D12_GPU_DESCRIPTOR_HANDLE, void> SetGraphicsRootDescriptorTable;

            [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, uint, uint, void> SetComputeRoot32BitConstant;

            [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, uint, uint, void> SetGraphicsRoot32BitConstant;

            [NativeTypeName("void (UINT, UINT, const void *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, uint, void*, uint, void> SetComputeRoot32BitConstants;

            [NativeTypeName("void (UINT, UINT, const void *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, uint, void*, uint, void> SetGraphicsRoot32BitConstants;

            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, ulong, void> SetComputeRootConstantBufferView;

            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, ulong, void> SetGraphicsRootConstantBufferView;

            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, ulong, void> SetComputeRootShaderResourceView;

            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, ulong, void> SetGraphicsRootShaderResourceView;

            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, ulong, void> SetComputeRootUnorderedAccessView;

            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, ulong, void> SetGraphicsRootUnorderedAccessView;

            [NativeTypeName("void (const D3D12_INDEX_BUFFER_VIEW *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, D3D12_INDEX_BUFFER_VIEW*, void> IASetIndexBuffer;

            [NativeTypeName("void (UINT, UINT, const D3D12_VERTEX_BUFFER_VIEW *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, uint, D3D12_VERTEX_BUFFER_VIEW*, void> IASetVertexBuffers;

            [NativeTypeName("void (UINT, UINT, const D3D12_STREAM_OUTPUT_BUFFER_VIEW *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, uint, D3D12_STREAM_OUTPUT_BUFFER_VIEW*, void> SOSetTargets;

            [NativeTypeName("void (UINT, const D3D12_CPU_DESCRIPTOR_HANDLE *, BOOL, const D3D12_CPU_DESCRIPTOR_HANDLE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, D3D12_CPU_DESCRIPTOR_HANDLE*, int, D3D12_CPU_DESCRIPTOR_HANDLE*, void> OMSetRenderTargets;

            [NativeTypeName("void (D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CLEAR_FLAGS, FLOAT, UINT8, UINT, const D3D12_RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CLEAR_FLAGS, float, byte, uint, RECT*, void> ClearDepthStencilView;

            [NativeTypeName("void (D3D12_CPU_DESCRIPTOR_HANDLE, const FLOAT *, UINT, const D3D12_RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, D3D12_CPU_DESCRIPTOR_HANDLE, float*, uint, RECT*, void> ClearRenderTargetView;

            [NativeTypeName("void (D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource *, const UINT *, UINT, const D3D12_RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource*, uint*, uint, RECT*, void> ClearUnorderedAccessViewUint;

            [NativeTypeName("void (D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource *, const FLOAT *, UINT, const D3D12_RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource*, float*, uint, RECT*, void> ClearUnorderedAccessViewFloat;

            [NativeTypeName("void (ID3D12Resource *, const D3D12_DISCARD_REGION *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12Resource*, D3D12_DISCARD_REGION*, void> DiscardResource;

            [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void> BeginQuery;

            [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void> EndQuery;

            [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT, UINT, ID3D12Resource *, UINT64) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, uint, ID3D12Resource*, ulong, void> ResolveQueryData;

            [NativeTypeName("void (ID3D12Resource *, UINT64, D3D12_PREDICATION_OP) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12Resource*, ulong, D3D12_PREDICATION_OP, void> SetPredication;

            [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, void*, uint, void> SetMarker;

            [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, void*, uint, void> BeginEvent;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, void> EndEvent;

            [NativeTypeName("void (ID3D12CommandSignature *, UINT, ID3D12Resource *, UINT64, ID3D12Resource *, UINT64) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void> ExecuteIndirect;

            [NativeTypeName("void (ID3D12Resource *, UINT64, ID3D12Resource *, UINT64, UINT, ID3D12Resource *const *, const D3D12_SUBRESOURCE_RANGE_UINT64 *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, D3D12_SUBRESOURCE_RANGE_UINT64*, void> AtomicCopyBufferUINT;

            [NativeTypeName("void (ID3D12Resource *, UINT64, ID3D12Resource *, UINT64, UINT, ID3D12Resource *const *, const D3D12_SUBRESOURCE_RANGE_UINT64 *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, D3D12_SUBRESOURCE_RANGE_UINT64*, void> AtomicCopyBufferUINT64;

            [NativeTypeName("void (FLOAT, FLOAT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, float, float, void> OMSetDepthBounds;

            [NativeTypeName("void (UINT, UINT, D3D12_SAMPLE_POSITION *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, uint, D3D12_SAMPLE_POSITION*, void> SetSamplePositions;

            [NativeTypeName("void (ID3D12Resource *, UINT, UINT, UINT, ID3D12Resource *, UINT, D3D12_RECT *, DXGI_FORMAT, D3D12_RESOLVE_MODE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, RECT*, DXGI_FORMAT, D3D12_RESOLVE_MODE, void> ResolveSubresourceRegion;

            [NativeTypeName("void (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, void> SetViewInstanceMask;

            [NativeTypeName("void (UINT, const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *, const D3D12_WRITEBUFFERIMMEDIATE_MODE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, D3D12_WRITEBUFFERIMMEDIATE_PARAMETER*, D3D12_WRITEBUFFERIMMEDIATE_MODE*, void> WriteBufferImmediate;

            [NativeTypeName("void (ID3D12ProtectedResourceSession *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12ProtectedResourceSession*, void> SetProtectedResourceSession;

            [NativeTypeName("void (UINT, const D3D12_RENDER_PASS_RENDER_TARGET_DESC *, const D3D12_RENDER_PASS_DEPTH_STENCIL_DESC *, D3D12_RENDER_PASS_FLAGS) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, uint, D3D12_RENDER_PASS_RENDER_TARGET_DESC*, D3D12_RENDER_PASS_DEPTH_STENCIL_DESC*, D3D12_RENDER_PASS_FLAGS, void> BeginRenderPass;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, void> EndRenderPass;

            [NativeTypeName("void (ID3D12MetaCommand *, const void *, SIZE_T) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12MetaCommand*, void*, nuint, void> InitializeMetaCommand;

            [NativeTypeName("void (ID3D12MetaCommand *, const void *, SIZE_T) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12MetaCommand*, void*, nuint, void> ExecuteMetaCommand;

            [NativeTypeName("void (const D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC *, UINT, const D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC*, uint, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC*, void> BuildRaytracingAccelerationStructure;

            [NativeTypeName("void (const D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC *, UINT, const D3D12_GPU_VIRTUAL_ADDRESS *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC*, uint, ulong*, void> EmitRaytracingAccelerationStructurePostbuildInfo;

            [NativeTypeName("void (D3D12_GPU_VIRTUAL_ADDRESS, D3D12_GPU_VIRTUAL_ADDRESS, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ulong, ulong, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE, void> CopyRaytracingAccelerationStructure;

            [NativeTypeName("void (ID3D12StateObject *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, ID3D12StateObject*, void> SetPipelineState1;

            [NativeTypeName("void (const D3D12_DISPATCH_RAYS_DESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12GraphicsCommandList4*, D3D12_DISPATCH_RAYS_DESC*, void> DispatchRays;
        }
    }
}
