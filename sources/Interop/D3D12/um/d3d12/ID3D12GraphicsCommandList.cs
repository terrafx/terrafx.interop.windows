// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5B160D0F-AC1B-4185-8BA8-B3AE42A5A455")]
    public unsafe partial struct ID3D12GraphicsCommandList
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12GraphicsCommandList* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12GraphicsCommandList* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12GraphicsCommandList* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D12GraphicsCommandList* This, [NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint* pDataSize, void* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D12GraphicsCommandList* This, [NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, void* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D12GraphicsCommandList* This, [NativeTypeName("REFGUID")] Guid* guid, IUnknown* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(ID3D12GraphicsCommandList* This, [NativeTypeName("LPCWSTR")] ushort* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(ID3D12GraphicsCommandList* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvDevice = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D12_COMMAND_LIST_TYPE __GetType(ID3D12GraphicsCommandList* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Close(ID3D12GraphicsCommandList* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Reset(ID3D12GraphicsCommandList* This, ID3D12CommandAllocator* pAllocator, ID3D12PipelineState* pInitialState = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearState(ID3D12GraphicsCommandList* This, ID3D12PipelineState* pPipelineState = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawInstanced(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint VertexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawIndexedInstanced(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint IndexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartIndexLocation, [NativeTypeName("INT")] int BaseVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Dispatch(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint ThreadGroupCountX, [NativeTypeName("UINT")] uint ThreadGroupCountY, [NativeTypeName("UINT")] uint ThreadGroupCountZ);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopyBufferRegion(ID3D12GraphicsCommandList* This, ID3D12Resource* pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, ID3D12Resource* pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT64")] ulong NumBytes);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopyTextureRegion(ID3D12GraphicsCommandList* This, D3D12_TEXTURE_COPY_LOCATION* pDst, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("UINT")] uint DstZ, D3D12_TEXTURE_COPY_LOCATION* pSrc, D3D12_BOX* pSrcBox = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopyResource(ID3D12GraphicsCommandList* This, ID3D12Resource* pDstResource, ID3D12Resource* pSrcResource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopyTiles(ID3D12GraphicsCommandList* This, ID3D12Resource* pTiledResource, D3D12_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate, D3D12_TILE_REGION_SIZE* pTileRegionSize, ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, D3D12_TILE_COPY_FLAGS Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ResolveSubresource(ID3D12GraphicsCommandList* This, ID3D12Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, ID3D12Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, DXGI_FORMAT Format);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _IASetPrimitiveTopology(ID3D12GraphicsCommandList* This, D3D_PRIMITIVE_TOPOLOGY PrimitiveTopology);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _RSSetViewports(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint NumViewports, D3D12_VIEWPORT* pViewports);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _RSSetScissorRects(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("D3D12_RECT")] RECT* pRects);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _OMSetBlendFactor(ID3D12GraphicsCommandList* This, [NativeTypeName("FLOAT")] float* BlendFactor = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _OMSetStencilRef(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint StencilRef);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetPipelineState(ID3D12GraphicsCommandList* This, ID3D12PipelineState* pPipelineState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ResourceBarrier(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint NumBarriers, [NativeTypeName("D3D12_RESOURCE_BARRIER[]")] D3D12_RESOURCE_BARRIER* pBarriers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ExecuteBundle(ID3D12GraphicsCommandList* This, ID3D12GraphicsCommandList* pCommandList);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetDescriptorHeaps(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint NumDescriptorHeaps, [NativeTypeName("ID3D12DescriptorHeap*[]")] ID3D12DescriptorHeap** ppDescriptorHeaps);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetComputeRootSignature(ID3D12GraphicsCommandList* This, ID3D12RootSignature* pRootSignature = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetGraphicsRootSignature(ID3D12GraphicsCommandList* This, ID3D12RootSignature* pRootSignature = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetComputeRootDescriptorTable(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetGraphicsRootDescriptorTable(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetComputeRoot32BitConstant(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint SrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetGraphicsRoot32BitConstant(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint SrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetComputeRoot32BitConstants(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint Num32BitValuesToSet, void* pSrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetGraphicsRoot32BitConstants(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint Num32BitValuesToSet, void* pSrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetComputeRootConstantBufferView(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetGraphicsRootConstantBufferView(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetComputeRootShaderResourceView(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetGraphicsRootShaderResourceView(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetComputeRootUnorderedAccessView(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetGraphicsRootUnorderedAccessView(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _IASetIndexBuffer(ID3D12GraphicsCommandList* This, D3D12_INDEX_BUFFER_VIEW* pView = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _IASetVertexBuffers(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("D3D12_VERTEX_BUFFER_VIEW[]")] D3D12_VERTEX_BUFFER_VIEW* pViews = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SOSetTargets(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("D3D12_STREAM_OUTPUT_BUFFER_VIEW[]")] D3D12_STREAM_OUTPUT_BUFFER_VIEW* pViews = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _OMSetRenderTargets(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint NumRenderTargetDescriptors, [Optional, NativeTypeName("D3D12_CPU_DESCRIPTOR_HANDLE[]")] D3D12_CPU_DESCRIPTOR_HANDLE* pRenderTargetDescriptors, [NativeTypeName("INT")] int RTsSingleHandleToDescriptorRange, D3D12_CPU_DESCRIPTOR_HANDLE* pDepthStencilDescriptor = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearDepthStencilView(ID3D12GraphicsCommandList* This, D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView, D3D12_CLEAR_FLAGS ClearFlags, [NativeTypeName("FLOAT")] float Depth, [NativeTypeName("UINT8")] byte Stencil, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("D3D12_RECT[]")] RECT* pRects);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearRenderTargetView(ID3D12GraphicsCommandList* This, D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView, [NativeTypeName("FLOAT")] float* ColorRGBA, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("D3D12_RECT[]")] RECT* pRects);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearUnorderedAccessViewUint(ID3D12GraphicsCommandList* This, D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, ID3D12Resource* pResource, [NativeTypeName("UINT")] uint* Values, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("D3D12_RECT[]")] RECT* pRects);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearUnorderedAccessViewFloat(ID3D12GraphicsCommandList* This, D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, ID3D12Resource* pResource, [NativeTypeName("FLOAT")] float* Values, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("D3D12_RECT[]")] RECT* pRects);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DiscardResource(ID3D12GraphicsCommandList* This, ID3D12Resource* pResource, D3D12_DISCARD_REGION* pRegion = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _BeginQuery(ID3D12GraphicsCommandList* This, ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _EndQuery(ID3D12GraphicsCommandList* This, ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ResolveQueryData(ID3D12GraphicsCommandList* This, ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint StartIndex, [NativeTypeName("UINT")] uint NumQueries, ID3D12Resource* pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetPredication(ID3D12GraphicsCommandList* This, [Optional] ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetMarker(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint Metadata, [Optional] void* pData, [NativeTypeName("UINT")] uint Size);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _BeginEvent(ID3D12GraphicsCommandList* This, [NativeTypeName("UINT")] uint Metadata, [Optional] void* pData, [NativeTypeName("UINT")] uint Size);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _EndEvent(ID3D12GraphicsCommandList* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ExecuteIndirect(ID3D12GraphicsCommandList* This, ID3D12CommandSignature* pCommandSignature, [NativeTypeName("UINT")] uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, [NativeTypeName("UINT64")] ulong ArgumentBufferOffset, [Optional] ID3D12Resource* pCountBuffer, [NativeTypeName("UINT64")] ulong CountBufferOffset);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint* pDataSize, void* pData = null)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(This, guid, pDataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, void* pData = null)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(This, guid, DataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("REFGUID")] Guid* guid, IUnknown* pData = null)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(This, guid, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)(This, Name);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("REFIID")] Guid* riid, void** ppvDevice = null)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)(This, riid, ppvDevice);
            }
        }

        public D3D12_COMMAND_LIST_TYPE _GetType()
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<__GetType>(lpVtbl->_GetType)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Close>(lpVtbl->Close)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset(ID3D12CommandAllocator* pAllocator, ID3D12PipelineState* pInitialState = null)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Reset>(lpVtbl->Reset)(This, pAllocator, pInitialState);
            }
        }

        public void ClearState(ID3D12PipelineState* pPipelineState = null)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearState>(lpVtbl->ClearState)(This, pPipelineState);
            }
        }

        public void DrawInstanced([NativeTypeName("UINT")] uint VertexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawInstanced>(lpVtbl->DrawInstanced)(This, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
            }
        }

        public void DrawIndexedInstanced([NativeTypeName("UINT")] uint IndexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartIndexLocation, [NativeTypeName("INT")] int BaseVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawIndexedInstanced>(lpVtbl->DrawIndexedInstanced)(This, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
            }
        }

        public void Dispatch([NativeTypeName("UINT")] uint ThreadGroupCountX, [NativeTypeName("UINT")] uint ThreadGroupCountY, [NativeTypeName("UINT")] uint ThreadGroupCountZ)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_Dispatch>(lpVtbl->Dispatch)(This, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
            }
        }

        public void CopyBufferRegion(ID3D12Resource* pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, ID3D12Resource* pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT64")] ulong NumBytes)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CopyBufferRegion>(lpVtbl->CopyBufferRegion)(This, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
            }
        }

        public void CopyTextureRegion(D3D12_TEXTURE_COPY_LOCATION* pDst, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("UINT")] uint DstZ, D3D12_TEXTURE_COPY_LOCATION* pSrc, D3D12_BOX* pSrcBox = null)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CopyTextureRegion>(lpVtbl->CopyTextureRegion)(This, pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
            }
        }

        public void CopyResource(ID3D12Resource* pDstResource, ID3D12Resource* pSrcResource)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CopyResource>(lpVtbl->CopyResource)(This, pDstResource, pSrcResource);
            }
        }

        public void CopyTiles(ID3D12Resource* pTiledResource, D3D12_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate, D3D12_TILE_REGION_SIZE* pTileRegionSize, ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, D3D12_TILE_COPY_FLAGS Flags)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CopyTiles>(lpVtbl->CopyTiles)(This, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }

        public void ResolveSubresource(ID3D12Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, ID3D12Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, DXGI_FORMAT Format)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ResolveSubresource>(lpVtbl->ResolveSubresource)(This, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
            }
        }

        public void IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY PrimitiveTopology)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_IASetPrimitiveTopology>(lpVtbl->IASetPrimitiveTopology)(This, PrimitiveTopology);
            }
        }

        public void RSSetViewports([NativeTypeName("UINT")] uint NumViewports, D3D12_VIEWPORT* pViewports)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_RSSetViewports>(lpVtbl->RSSetViewports)(This, NumViewports, pViewports);
            }
        }

        public void RSSetScissorRects([NativeTypeName("UINT")] uint NumRects, [NativeTypeName("D3D12_RECT")] RECT* pRects)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_RSSetScissorRects>(lpVtbl->RSSetScissorRects)(This, NumRects, pRects);
            }
        }

        public void OMSetBlendFactor([NativeTypeName("FLOAT")] float* BlendFactor = null)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_OMSetBlendFactor>(lpVtbl->OMSetBlendFactor)(This, BlendFactor);
            }
        }

        public void OMSetStencilRef([NativeTypeName("UINT")] uint StencilRef)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_OMSetStencilRef>(lpVtbl->OMSetStencilRef)(This, StencilRef);
            }
        }

        public void SetPipelineState(ID3D12PipelineState* pPipelineState)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetPipelineState>(lpVtbl->SetPipelineState)(This, pPipelineState);
            }
        }

        public void ResourceBarrier([NativeTypeName("UINT")] uint NumBarriers, [NativeTypeName("D3D12_RESOURCE_BARRIER[]")] D3D12_RESOURCE_BARRIER* pBarriers)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ResourceBarrier>(lpVtbl->ResourceBarrier)(This, NumBarriers, pBarriers);
            }
        }

        public void ExecuteBundle(ID3D12GraphicsCommandList* pCommandList)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ExecuteBundle>(lpVtbl->ExecuteBundle)(This, pCommandList);
            }
        }

        public void SetDescriptorHeaps([NativeTypeName("UINT")] uint NumDescriptorHeaps, [NativeTypeName("ID3D12DescriptorHeap*[]")] ID3D12DescriptorHeap** ppDescriptorHeaps)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetDescriptorHeaps>(lpVtbl->SetDescriptorHeaps)(This, NumDescriptorHeaps, ppDescriptorHeaps);
            }
        }

        public void SetComputeRootSignature(ID3D12RootSignature* pRootSignature = null)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetComputeRootSignature>(lpVtbl->SetComputeRootSignature)(This, pRootSignature);
            }
        }

        public void SetGraphicsRootSignature(ID3D12RootSignature* pRootSignature = null)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetGraphicsRootSignature>(lpVtbl->SetGraphicsRootSignature)(This, pRootSignature);
            }
        }

        public void SetComputeRootDescriptorTable([NativeTypeName("UINT")] uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetComputeRootDescriptorTable>(lpVtbl->SetComputeRootDescriptorTable)(This, RootParameterIndex, BaseDescriptor);
            }
        }

        public void SetGraphicsRootDescriptorTable([NativeTypeName("UINT")] uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetGraphicsRootDescriptorTable>(lpVtbl->SetGraphicsRootDescriptorTable)(This, RootParameterIndex, BaseDescriptor);
            }
        }

        public void SetComputeRoot32BitConstant([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint SrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetComputeRoot32BitConstant>(lpVtbl->SetComputeRoot32BitConstant)(This, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
            }
        }

        public void SetGraphicsRoot32BitConstant([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint SrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetGraphicsRoot32BitConstant>(lpVtbl->SetGraphicsRoot32BitConstant)(This, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
            }
        }

        public void SetComputeRoot32BitConstants([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint Num32BitValuesToSet, void* pSrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetComputeRoot32BitConstants>(lpVtbl->SetComputeRoot32BitConstants)(This, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
            }
        }

        public void SetGraphicsRoot32BitConstants([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint Num32BitValuesToSet, void* pSrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetGraphicsRoot32BitConstants>(lpVtbl->SetGraphicsRoot32BitConstants)(This, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
            }
        }

        public void SetComputeRootConstantBufferView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetComputeRootConstantBufferView>(lpVtbl->SetComputeRootConstantBufferView)(This, RootParameterIndex, BufferLocation);
            }
        }

        public void SetGraphicsRootConstantBufferView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetGraphicsRootConstantBufferView>(lpVtbl->SetGraphicsRootConstantBufferView)(This, RootParameterIndex, BufferLocation);
            }
        }

        public void SetComputeRootShaderResourceView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetComputeRootShaderResourceView>(lpVtbl->SetComputeRootShaderResourceView)(This, RootParameterIndex, BufferLocation);
            }
        }

        public void SetGraphicsRootShaderResourceView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetGraphicsRootShaderResourceView>(lpVtbl->SetGraphicsRootShaderResourceView)(This, RootParameterIndex, BufferLocation);
            }
        }

        public void SetComputeRootUnorderedAccessView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetComputeRootUnorderedAccessView>(lpVtbl->SetComputeRootUnorderedAccessView)(This, RootParameterIndex, BufferLocation);
            }
        }

        public void SetGraphicsRootUnorderedAccessView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetGraphicsRootUnorderedAccessView>(lpVtbl->SetGraphicsRootUnorderedAccessView)(This, RootParameterIndex, BufferLocation);
            }
        }

        public void IASetIndexBuffer(D3D12_INDEX_BUFFER_VIEW* pView = null)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_IASetIndexBuffer>(lpVtbl->IASetIndexBuffer)(This, pView);
            }
        }

        public void IASetVertexBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("D3D12_VERTEX_BUFFER_VIEW[]")] D3D12_VERTEX_BUFFER_VIEW* pViews = null)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_IASetVertexBuffers>(lpVtbl->IASetVertexBuffers)(This, StartSlot, NumViews, pViews);
            }
        }

        public void SOSetTargets([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("D3D12_STREAM_OUTPUT_BUFFER_VIEW[]")] D3D12_STREAM_OUTPUT_BUFFER_VIEW* pViews = null)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SOSetTargets>(lpVtbl->SOSetTargets)(This, StartSlot, NumViews, pViews);
            }
        }

        public void OMSetRenderTargets([NativeTypeName("UINT")] uint NumRenderTargetDescriptors, [Optional, NativeTypeName("D3D12_CPU_DESCRIPTOR_HANDLE[]")] D3D12_CPU_DESCRIPTOR_HANDLE* pRenderTargetDescriptors, [NativeTypeName("INT")] int RTsSingleHandleToDescriptorRange, D3D12_CPU_DESCRIPTOR_HANDLE* pDepthStencilDescriptor = null)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_OMSetRenderTargets>(lpVtbl->OMSetRenderTargets)(This, NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
            }
        }

        public void ClearDepthStencilView(D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView, D3D12_CLEAR_FLAGS ClearFlags, [NativeTypeName("FLOAT")] float Depth, [NativeTypeName("UINT8")] byte Stencil, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("D3D12_RECT[]")] RECT* pRects)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearDepthStencilView>(lpVtbl->ClearDepthStencilView)(This, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
            }
        }

        public void ClearRenderTargetView(D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView, [NativeTypeName("FLOAT")] float* ColorRGBA, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("D3D12_RECT[]")] RECT* pRects)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearRenderTargetView>(lpVtbl->ClearRenderTargetView)(This, RenderTargetView, ColorRGBA, NumRects, pRects);
            }
        }

        public void ClearUnorderedAccessViewUint(D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, ID3D12Resource* pResource, [NativeTypeName("UINT")] uint* Values, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("D3D12_RECT[]")] RECT* pRects)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearUnorderedAccessViewUint>(lpVtbl->ClearUnorderedAccessViewUint)(This, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
            }
        }

        public void ClearUnorderedAccessViewFloat(D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, ID3D12Resource* pResource, [NativeTypeName("FLOAT")] float* Values, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("D3D12_RECT[]")] RECT* pRects)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearUnorderedAccessViewFloat>(lpVtbl->ClearUnorderedAccessViewFloat)(This, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
            }
        }

        public void DiscardResource(ID3D12Resource* pResource, D3D12_DISCARD_REGION* pRegion = null)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DiscardResource>(lpVtbl->DiscardResource)(This, pResource, pRegion);
            }
        }

        public void BeginQuery(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_BeginQuery>(lpVtbl->BeginQuery)(This, pQueryHeap, Type, Index);
            }
        }

        public void EndQuery(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_EndQuery>(lpVtbl->EndQuery)(This, pQueryHeap, Type, Index);
            }
        }

        public void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint StartIndex, [NativeTypeName("UINT")] uint NumQueries, ID3D12Resource* pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ResolveQueryData>(lpVtbl->ResolveQueryData)(This, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
            }
        }

        public void SetPredication([Optional] ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetPredication>(lpVtbl->SetPredication)(This, pBuffer, AlignedBufferOffset, Operation);
            }
        }

        public void SetMarker([NativeTypeName("UINT")] uint Metadata, [Optional] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetMarker>(lpVtbl->SetMarker)(This, Metadata, pData, Size);
            }
        }

        public void BeginEvent([NativeTypeName("UINT")] uint Metadata, [Optional] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_BeginEvent>(lpVtbl->BeginEvent)(This, Metadata, pData, Size);
            }
        }

        public void EndEvent()
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_EndEvent>(lpVtbl->EndEvent)(This);
            }
        }

        public void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, [NativeTypeName("UINT")] uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, [NativeTypeName("UINT64")] ulong ArgumentBufferOffset, [Optional] ID3D12Resource* pCountBuffer, [NativeTypeName("UINT64")] ulong CountBufferOffset)
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ExecuteIndirect>(lpVtbl->ExecuteIndirect)(This, pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
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

            public IntPtr GetDevice;

            public IntPtr _GetType;

            public IntPtr Close;

            public IntPtr Reset;

            public IntPtr ClearState;

            public IntPtr DrawInstanced;

            public IntPtr DrawIndexedInstanced;

            public IntPtr Dispatch;

            public IntPtr CopyBufferRegion;

            public IntPtr CopyTextureRegion;

            public IntPtr CopyResource;

            public IntPtr CopyTiles;

            public IntPtr ResolveSubresource;

            public IntPtr IASetPrimitiveTopology;

            public IntPtr RSSetViewports;

            public IntPtr RSSetScissorRects;

            public IntPtr OMSetBlendFactor;

            public IntPtr OMSetStencilRef;

            public IntPtr SetPipelineState;

            public IntPtr ResourceBarrier;

            public IntPtr ExecuteBundle;

            public IntPtr SetDescriptorHeaps;

            public IntPtr SetComputeRootSignature;

            public IntPtr SetGraphicsRootSignature;

            public IntPtr SetComputeRootDescriptorTable;

            public IntPtr SetGraphicsRootDescriptorTable;

            public IntPtr SetComputeRoot32BitConstant;

            public IntPtr SetGraphicsRoot32BitConstant;

            public IntPtr SetComputeRoot32BitConstants;

            public IntPtr SetGraphicsRoot32BitConstants;

            public IntPtr SetComputeRootConstantBufferView;

            public IntPtr SetGraphicsRootConstantBufferView;

            public IntPtr SetComputeRootShaderResourceView;

            public IntPtr SetGraphicsRootShaderResourceView;

            public IntPtr SetComputeRootUnorderedAccessView;

            public IntPtr SetGraphicsRootUnorderedAccessView;

            public IntPtr IASetIndexBuffer;

            public IntPtr IASetVertexBuffers;

            public IntPtr SOSetTargets;

            public IntPtr OMSetRenderTargets;

            public IntPtr ClearDepthStencilView;

            public IntPtr ClearRenderTargetView;

            public IntPtr ClearUnorderedAccessViewUint;

            public IntPtr ClearUnorderedAccessViewFloat;

            public IntPtr DiscardResource;

            public IntPtr BeginQuery;

            public IntPtr EndQuery;

            public IntPtr ResolveQueryData;

            public IntPtr SetPredication;

            public IntPtr SetMarker;

            public IntPtr BeginEvent;

            public IntPtr EndEvent;

            public IntPtr ExecuteIndirect;
        }
    }
}
