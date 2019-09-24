// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5B160D0F-AC1B-4185-8BA8-B3AE42A5A455")]
    public unsafe struct ID3D12GraphicsCommandList
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] ID3D12GraphicsCommandList* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] ID3D12GraphicsCommandList* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In] IUnknown* pData = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("LPCWSTR")] char* Name
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvDevice = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D12_COMMAND_LIST_TYPE __GetType(
            [In] ID3D12GraphicsCommandList* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Close(
            [In] ID3D12GraphicsCommandList* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Reset(
            [In] ID3D12GraphicsCommandList* This,
            [In] ID3D12CommandAllocator* pAllocator,
            [In] ID3D12PipelineState* pInitialState = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearState(
            [In] ID3D12GraphicsCommandList* This,
            [In] ID3D12PipelineState* pPipelineState = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawInstanced(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint VertexCountPerInstance,
            [In, NativeTypeName("UINT")] uint InstanceCount,
            [In, NativeTypeName("UINT")] uint StartVertexLocation,
            [In, NativeTypeName("UINT")] uint StartInstanceLocation
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawIndexedInstanced(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint IndexCountPerInstance,
            [In, NativeTypeName("UINT")] uint InstanceCount,
            [In, NativeTypeName("UINT")] uint StartIndexLocation,
            [In, NativeTypeName("INT")] int BaseVertexLocation,
            [In, NativeTypeName("UINT")] uint StartInstanceLocation
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Dispatch(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint ThreadGroupCountX,
            [In, NativeTypeName("UINT")] uint ThreadGroupCountY,
            [In, NativeTypeName("UINT")] uint ThreadGroupCountZ
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopyBufferRegion(
            [In] ID3D12GraphicsCommandList* This,
            [In] ID3D12Resource* pDstBuffer,
            [In, NativeTypeName("UINT64")] ulong DstOffset,
            [In] ID3D12Resource* pSrcBuffer,
            [In, NativeTypeName("UINT64")] ulong SrcOffset,
            [In, NativeTypeName("UINT64")] ulong NumBytes
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopyTextureRegion(
            [In] ID3D12GraphicsCommandList* This,
            [In] D3D12_TEXTURE_COPY_LOCATION* pDst,
            [In, NativeTypeName("UINT")] uint DstX,
            [In, NativeTypeName("UINT")] uint DstY,
            [In, NativeTypeName("UINT")] uint DstZ,
            [In] D3D12_TEXTURE_COPY_LOCATION* pSrc,
            [In] D3D12_BOX* pSrcBox = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopyResource(
            [In] ID3D12GraphicsCommandList* This,
            [In] ID3D12Resource* pDstResource,
            [In] ID3D12Resource* pSrcResource
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopyTiles(
            [In] ID3D12GraphicsCommandList* This,
            [In] ID3D12Resource* pTiledResource,
            [In] D3D12_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate,
            [In] D3D12_TILE_REGION_SIZE* pTileRegionSize,
            [In] ID3D12Resource* pBuffer,
            [In, NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes,
            [In] D3D12_TILE_COPY_FLAGS Flags
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ResolveSubresource(
            [In] ID3D12GraphicsCommandList* This,
            [In] ID3D12Resource* pDstResource,
            [In, NativeTypeName("UINT")] uint DstSubresource,
            [In] ID3D12Resource* pSrcResource,
            [In, NativeTypeName("UINT")] uint SrcSubresource,
            [In] DXGI_FORMAT Format
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _IASetPrimitiveTopology(
            [In] ID3D12GraphicsCommandList* This,
            [In] D3D_PRIMITIVE_TOPOLOGY PrimitiveTopology
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _RSSetViewports(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint NumViewports,
            [In] D3D12_VIEWPORT* pViewports
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _RSSetScissorRects(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint NumRects,
            [In, NativeTypeName("D3D12_RECT")] RECT* pRects
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _OMSetBlendFactor(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("FLOAT")] float* BlendFactor = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _OMSetStencilRef(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint StencilRef
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetPipelineState(
            [In] ID3D12GraphicsCommandList* This,
            [In] ID3D12PipelineState* pPipelineState
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ResourceBarrier(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint NumBarriers,
            [In, NativeTypeName("D3D12_RESOURCE_BARRIER[]")] D3D12_RESOURCE_BARRIER* pBarriers
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ExecuteBundle(
            [In] ID3D12GraphicsCommandList* This,
            [In] ID3D12GraphicsCommandList* pCommandList
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetDescriptorHeaps(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint NumDescriptorHeaps,
            [In, NativeTypeName("ID3D12DescriptorHeap*[]")] ID3D12DescriptorHeap** ppDescriptorHeaps
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetComputeRootSignature(
            [In] ID3D12GraphicsCommandList* This,
            [In] ID3D12RootSignature* pRootSignature = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetGraphicsRootSignature(
            [In] ID3D12GraphicsCommandList* This,
            [In] ID3D12RootSignature* pRootSignature = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetComputeRootDescriptorTable(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In] D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetGraphicsRootDescriptorTable(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In] D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetComputeRoot32BitConstant(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("UINT")] uint SrcData,
            [In, NativeTypeName("UINT")] uint DestOffsetIn32BitValues
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetGraphicsRoot32BitConstant(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("UINT")] uint SrcData,
            [In, NativeTypeName("UINT")] uint DestOffsetIn32BitValues
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetComputeRoot32BitConstants(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("UINT")] uint Num32BitValuesToSet,
            [In] void* pSrcData,
            [In, NativeTypeName("UINT")] uint DestOffsetIn32BitValues
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetGraphicsRoot32BitConstants(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("UINT")] uint Num32BitValuesToSet,
            [In] void* pSrcData,
            [In, NativeTypeName("UINT")] uint DestOffsetIn32BitValues
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetComputeRootConstantBufferView(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetGraphicsRootConstantBufferView(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetComputeRootShaderResourceView(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetGraphicsRootShaderResourceView(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetComputeRootUnorderedAccessView(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetGraphicsRootUnorderedAccessView(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _IASetIndexBuffer(
            [In] ID3D12GraphicsCommandList* This,
            [In] D3D12_INDEX_BUFFER_VIEW* pView = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _IASetVertexBuffers(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint StartSlot,
            [In, NativeTypeName("UINT")] uint NumViews,
            [In, NativeTypeName("D3D12_VERTEX_BUFFER_VIEW[]")] D3D12_VERTEX_BUFFER_VIEW* pViews = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SOSetTargets(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint StartSlot,
            [In, NativeTypeName("UINT")] uint NumViews,
            [In, NativeTypeName("D3D12_STREAM_OUTPUT_BUFFER_VIEW[]")] D3D12_STREAM_OUTPUT_BUFFER_VIEW* pViews = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _OMSetRenderTargets(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint NumRenderTargetDescriptors,
            [In, Optional, NativeTypeName("D3D12_CPU_DESCRIPTOR_HANDLE[]")] D3D12_CPU_DESCRIPTOR_HANDLE* pRenderTargetDescriptors,
            [In, NativeTypeName("INT")] int RTsSingleHandleToDescriptorRange,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE* pDepthStencilDescriptor = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearDepthStencilView(
            [In] ID3D12GraphicsCommandList* This,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView,
            [In] D3D12_CLEAR_FLAGS ClearFlags,
            [In, NativeTypeName("FLOAT")] float Depth,
            [In, NativeTypeName("UINT8")] byte Stencil,
            [In, NativeTypeName("UINT")] uint NumRects,
            [In, NativeTypeName("D3D12_RECT[]")] RECT* pRects
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearRenderTargetView(
            [In] ID3D12GraphicsCommandList* This,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView,
            [In, NativeTypeName("FLOAT")] float* ColorRGBA,
            [In, NativeTypeName("UINT")] uint NumRects,
            [In, NativeTypeName("D3D12_RECT[]")] RECT* pRects
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearUnorderedAccessViewUint(
            [In] ID3D12GraphicsCommandList* This,
            [In] D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle,
            [In] ID3D12Resource* pResource,
            [In, NativeTypeName("UINT")] uint* Values,
            [In, NativeTypeName("UINT")] uint NumRects,
            [In, NativeTypeName("D3D12_RECT[]")] RECT* pRects
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearUnorderedAccessViewFloat(
            [In] ID3D12GraphicsCommandList* This,
            [In] D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle,
            [In] ID3D12Resource* pResource,
            [In, NativeTypeName("FLOAT")] float* Values,
            [In, NativeTypeName("UINT")] uint NumRects,
            [In, NativeTypeName("D3D12_RECT[]")] RECT* pRects
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DiscardResource(
            [In] ID3D12GraphicsCommandList* This,
            [In] ID3D12Resource* pResource,
            [In] D3D12_DISCARD_REGION* pRegion = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _BeginQuery(
            [In] ID3D12GraphicsCommandList* This,
            [In] ID3D12QueryHeap* pQueryHeap,
            [In] D3D12_QUERY_TYPE Type,
            [In, NativeTypeName("UINT")] uint Index
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _EndQuery(
            [In] ID3D12GraphicsCommandList* This,
            [In] ID3D12QueryHeap* pQueryHeap,
            [In] D3D12_QUERY_TYPE Type,
            [In, NativeTypeName("UINT")] uint Index
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ResolveQueryData(
            [In] ID3D12GraphicsCommandList* This,
            [In] ID3D12QueryHeap* pQueryHeap,
            [In] D3D12_QUERY_TYPE Type,
            [In, NativeTypeName("UINT")] uint StartIndex,
            [In, NativeTypeName("UINT")] uint NumQueries,
            [In] ID3D12Resource* pDestinationBuffer,
            [In, NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetPredication(
            [In] ID3D12GraphicsCommandList* This,
            [In, Optional] ID3D12Resource* pBuffer,
            [In, NativeTypeName("UINT64")] ulong AlignedBufferOffset,
            [In] D3D12_PREDICATION_OP Operation
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetMarker(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint Metadata,
            [In, Optional] void* pData,
            [In, NativeTypeName("UINT")] uint Size
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _BeginEvent(
            [In] ID3D12GraphicsCommandList* This,
            [In, NativeTypeName("UINT")] uint Metadata,
            [In, Optional] void* pData,
            [In, NativeTypeName("UINT")] uint Size
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _EndEvent(
            [In] ID3D12GraphicsCommandList* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ExecuteIndirect(
            [In] ID3D12GraphicsCommandList* This,
            [In] ID3D12CommandSignature* pCommandSignature,
            [In, NativeTypeName("UINT")] uint MaxCommandCount,
            [In] ID3D12Resource* pArgumentBuffer,
            [In, NativeTypeName("UINT64")] ulong ArgumentBufferOffset,
            [In, Optional] ID3D12Resource* pCountBuffer,
            [In, NativeTypeName("UINT64")] ulong CountBufferOffset
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
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
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
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
            fixed (ID3D12GraphicsCommandList* This = &this)
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
            fixed (ID3D12GraphicsCommandList* This = &this)
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
            fixed (ID3D12GraphicsCommandList* This = &this)
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
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)(
                    This,
                    Name
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvDevice = null
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)(
                    This,
                    riid,
                    ppvDevice
                );
            }
        }

        public D3D12_COMMAND_LIST_TYPE _GetType()
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<__GetType>(lpVtbl->_GetType)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Close>(lpVtbl->Close)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset(
            [In] ID3D12CommandAllocator* pAllocator,
            [In] ID3D12PipelineState* pInitialState = null
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Reset>(lpVtbl->Reset)(
                    This,
                    pAllocator,
                    pInitialState
                );
            }
        }

        public void ClearState(
            [In] ID3D12PipelineState* pPipelineState = null
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearState>(lpVtbl->ClearState)(
                    This,
                    pPipelineState
                );
            }
        }

        public void DrawInstanced(
            [In, NativeTypeName("UINT")] uint VertexCountPerInstance,
            [In, NativeTypeName("UINT")] uint InstanceCount,
            [In, NativeTypeName("UINT")] uint StartVertexLocation,
            [In, NativeTypeName("UINT")] uint StartInstanceLocation
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawInstanced>(lpVtbl->DrawInstanced)(
                    This,
                    VertexCountPerInstance,
                    InstanceCount,
                    StartVertexLocation,
                    StartInstanceLocation
                );
            }
        }

        public void DrawIndexedInstanced(
            [In, NativeTypeName("UINT")] uint IndexCountPerInstance,
            [In, NativeTypeName("UINT")] uint InstanceCount,
            [In, NativeTypeName("UINT")] uint StartIndexLocation,
            [In, NativeTypeName("INT")] int BaseVertexLocation,
            [In, NativeTypeName("UINT")] uint StartInstanceLocation
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawIndexedInstanced>(lpVtbl->DrawIndexedInstanced)(
                    This,
                    IndexCountPerInstance,
                    InstanceCount,
                    StartIndexLocation,
                    BaseVertexLocation,
                    StartInstanceLocation
                );
            }
        }

        public void Dispatch(
            [In, NativeTypeName("UINT")] uint ThreadGroupCountX,
            [In, NativeTypeName("UINT")] uint ThreadGroupCountY,
            [In, NativeTypeName("UINT")] uint ThreadGroupCountZ
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_Dispatch>(lpVtbl->Dispatch)(
                    This,
                    ThreadGroupCountX,
                    ThreadGroupCountY,
                    ThreadGroupCountZ
                );
            }
        }

        public void CopyBufferRegion(
            [In] ID3D12Resource* pDstBuffer,
            [In, NativeTypeName("UINT64")] ulong DstOffset,
            [In] ID3D12Resource* pSrcBuffer,
            [In, NativeTypeName("UINT64")] ulong SrcOffset,
            [In, NativeTypeName("UINT64")] ulong NumBytes
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CopyBufferRegion>(lpVtbl->CopyBufferRegion)(
                    This,
                    pDstBuffer,
                    DstOffset,
                    pSrcBuffer,
                    SrcOffset,
                    NumBytes
                );
            }
        }

        public void CopyTextureRegion(
            [In] D3D12_TEXTURE_COPY_LOCATION* pDst,
            [In, NativeTypeName("UINT")] uint DstX,
            [In, NativeTypeName("UINT")] uint DstY,
            [In, NativeTypeName("UINT")] uint DstZ,
            [In] D3D12_TEXTURE_COPY_LOCATION* pSrc,
            [In] D3D12_BOX* pSrcBox = null
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CopyTextureRegion>(lpVtbl->CopyTextureRegion)(
                    This,
                    pDst,
                    DstX,
                    DstY,
                    DstZ,
                    pSrc,
                    pSrcBox
                );
            }
        }

        public void CopyResource(
            [In] ID3D12Resource* pDstResource,
            [In] ID3D12Resource* pSrcResource
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CopyResource>(lpVtbl->CopyResource)(
                    This,
                    pDstResource,
                    pSrcResource
                );
            }
        }

        public void CopyTiles(
            [In] ID3D12Resource* pTiledResource,
            [In] D3D12_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate,
            [In] D3D12_TILE_REGION_SIZE* pTileRegionSize,
            [In] ID3D12Resource* pBuffer,
            [In, NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes,
            [In] D3D12_TILE_COPY_FLAGS Flags
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_CopyTiles>(lpVtbl->CopyTiles)(
                    This,
                    pTiledResource,
                    pTileRegionStartCoordinate,
                    pTileRegionSize,
                    pBuffer,
                    BufferStartOffsetInBytes,
                    Flags
                );
            }
        }

        public void ResolveSubresource(
            [In] ID3D12Resource* pDstResource,
            [In, NativeTypeName("UINT")] uint DstSubresource,
            [In] ID3D12Resource* pSrcResource,
            [In, NativeTypeName("UINT")] uint SrcSubresource,
            [In] DXGI_FORMAT Format
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ResolveSubresource>(lpVtbl->ResolveSubresource)(
                    This,
                    pDstResource,
                    DstSubresource,
                    pSrcResource,
                    SrcSubresource,
                    Format
                );
            }
        }

        public void IASetPrimitiveTopology(
            [In] D3D_PRIMITIVE_TOPOLOGY PrimitiveTopology
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_IASetPrimitiveTopology>(lpVtbl->IASetPrimitiveTopology)(
                    This,
                    PrimitiveTopology
                );
            }
        }

        public void RSSetViewports(
            [In, NativeTypeName("UINT")] uint NumViewports,
            [In] D3D12_VIEWPORT* pViewports
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_RSSetViewports>(lpVtbl->RSSetViewports)(
                    This,
                    NumViewports,
                    pViewports
                );
            }
        }

        public void RSSetScissorRects(
            [In, NativeTypeName("UINT")] uint NumRects,
            [In, NativeTypeName("D3D12_RECT")] RECT* pRects
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_RSSetScissorRects>(lpVtbl->RSSetScissorRects)(
                    This,
                    NumRects,
                    pRects
                );
            }
        }

        public void OMSetBlendFactor(
            [In, NativeTypeName("FLOAT")] float* BlendFactor = null
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_OMSetBlendFactor>(lpVtbl->OMSetBlendFactor)(
                    This,
                    BlendFactor
                );
            }
        }

        public void OMSetStencilRef(
            [In, NativeTypeName("UINT")] uint StencilRef
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_OMSetStencilRef>(lpVtbl->OMSetStencilRef)(
                    This,
                    StencilRef
                );
            }
        }

        public void SetPipelineState(
            [In] ID3D12PipelineState* pPipelineState
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetPipelineState>(lpVtbl->SetPipelineState)(
                    This,
                    pPipelineState
                );
            }
        }

        public void ResourceBarrier(
            [In, NativeTypeName("UINT")] uint NumBarriers,
            [In, NativeTypeName("D3D12_RESOURCE_BARRIER[]")] D3D12_RESOURCE_BARRIER* pBarriers
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ResourceBarrier>(lpVtbl->ResourceBarrier)(
                    This,
                    NumBarriers,
                    pBarriers
                );
            }
        }

        public void ExecuteBundle(
            [In] ID3D12GraphicsCommandList* pCommandList
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ExecuteBundle>(lpVtbl->ExecuteBundle)(
                    This,
                    pCommandList
                );
            }
        }

        public void SetDescriptorHeaps(
            [In, NativeTypeName("UINT")] uint NumDescriptorHeaps,
            [In, NativeTypeName("ID3D12DescriptorHeap*[]")] ID3D12DescriptorHeap** ppDescriptorHeaps
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetDescriptorHeaps>(lpVtbl->SetDescriptorHeaps)(
                    This,
                    NumDescriptorHeaps,
                    ppDescriptorHeaps
                );
            }
        }

        public void SetComputeRootSignature(
            [In] ID3D12RootSignature* pRootSignature = null
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetComputeRootSignature>(lpVtbl->SetComputeRootSignature)(
                    This,
                    pRootSignature
                );
            }
        }

        public void SetGraphicsRootSignature(
            [In] ID3D12RootSignature* pRootSignature = null
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetGraphicsRootSignature>(lpVtbl->SetGraphicsRootSignature)(
                    This,
                    pRootSignature
                );
            }
        }

        public void SetComputeRootDescriptorTable(
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In] D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetComputeRootDescriptorTable>(lpVtbl->SetComputeRootDescriptorTable)(
                    This,
                    RootParameterIndex,
                    BaseDescriptor
                );
            }
        }

        public void SetGraphicsRootDescriptorTable(
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In] D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetGraphicsRootDescriptorTable>(lpVtbl->SetGraphicsRootDescriptorTable)(
                    This,
                    RootParameterIndex,
                    BaseDescriptor
                );
            }
        }

        public void SetComputeRoot32BitConstant(
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("UINT")] uint SrcData,
            [In, NativeTypeName("UINT")] uint DestOffsetIn32BitValues
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetComputeRoot32BitConstant>(lpVtbl->SetComputeRoot32BitConstant)(
                    This,
                    RootParameterIndex,
                    SrcData,
                    DestOffsetIn32BitValues
                );
            }
        }

        public void SetGraphicsRoot32BitConstant(
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("UINT")] uint SrcData,
            [In, NativeTypeName("UINT")] uint DestOffsetIn32BitValues
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetGraphicsRoot32BitConstant>(lpVtbl->SetGraphicsRoot32BitConstant)(
                    This,
                    RootParameterIndex,
                    SrcData,
                    DestOffsetIn32BitValues
                );
            }
        }

        public void SetComputeRoot32BitConstants(
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("UINT")] uint Num32BitValuesToSet,
            [In] void* pSrcData,
            [In, NativeTypeName("UINT")] uint DestOffsetIn32BitValues
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetComputeRoot32BitConstants>(lpVtbl->SetComputeRoot32BitConstants)(
                    This,
                    RootParameterIndex,
                    Num32BitValuesToSet,
                    pSrcData,
                    DestOffsetIn32BitValues
                );
            }
        }

        public void SetGraphicsRoot32BitConstants(
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("UINT")] uint Num32BitValuesToSet,
            [In] void* pSrcData,
            [In, NativeTypeName("UINT")] uint DestOffsetIn32BitValues
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetGraphicsRoot32BitConstants>(lpVtbl->SetGraphicsRoot32BitConstants)(
                    This,
                    RootParameterIndex,
                    Num32BitValuesToSet,
                    pSrcData,
                    DestOffsetIn32BitValues
                );
            }
        }

        public void SetComputeRootConstantBufferView(
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetComputeRootConstantBufferView>(lpVtbl->SetComputeRootConstantBufferView)(
                    This,
                    RootParameterIndex,
                    BufferLocation
                );
            }
        }

        public void SetGraphicsRootConstantBufferView(
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetGraphicsRootConstantBufferView>(lpVtbl->SetGraphicsRootConstantBufferView)(
                    This,
                    RootParameterIndex,
                    BufferLocation
                );
            }
        }

        public void SetComputeRootShaderResourceView(
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetComputeRootShaderResourceView>(lpVtbl->SetComputeRootShaderResourceView)(
                    This,
                    RootParameterIndex,
                    BufferLocation
                );
            }
        }

        public void SetGraphicsRootShaderResourceView(
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetGraphicsRootShaderResourceView>(lpVtbl->SetGraphicsRootShaderResourceView)(
                    This,
                    RootParameterIndex,
                    BufferLocation
                );
            }
        }

        public void SetComputeRootUnorderedAccessView(
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetComputeRootUnorderedAccessView>(lpVtbl->SetComputeRootUnorderedAccessView)(
                    This,
                    RootParameterIndex,
                    BufferLocation
                );
            }
        }

        public void SetGraphicsRootUnorderedAccessView(
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetGraphicsRootUnorderedAccessView>(lpVtbl->SetGraphicsRootUnorderedAccessView)(
                    This,
                    RootParameterIndex,
                    BufferLocation
                );
            }
        }

        public void IASetIndexBuffer(
            [In] D3D12_INDEX_BUFFER_VIEW* pView = null
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_IASetIndexBuffer>(lpVtbl->IASetIndexBuffer)(
                    This,
                    pView
                );
            }
        }

        public void IASetVertexBuffers(
            [In, NativeTypeName("UINT")] uint StartSlot,
            [In, NativeTypeName("UINT")] uint NumViews,
            [In, NativeTypeName("D3D12_VERTEX_BUFFER_VIEW[]")] D3D12_VERTEX_BUFFER_VIEW* pViews = null
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_IASetVertexBuffers>(lpVtbl->IASetVertexBuffers)(
                    This,
                    StartSlot,
                    NumViews,
                    pViews
                );
            }
        }

        public void SOSetTargets(
            [In, NativeTypeName("UINT")] uint StartSlot,
            [In, NativeTypeName("UINT")] uint NumViews,
            [In, NativeTypeName("D3D12_STREAM_OUTPUT_BUFFER_VIEW[]")] D3D12_STREAM_OUTPUT_BUFFER_VIEW* pViews = null
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SOSetTargets>(lpVtbl->SOSetTargets)(
                    This,
                    StartSlot,
                    NumViews,
                    pViews
                );
            }
        }

        public void OMSetRenderTargets(
            [In, NativeTypeName("UINT")] uint NumRenderTargetDescriptors,
            [In, Optional, NativeTypeName("D3D12_CPU_DESCRIPTOR_HANDLE[]")] D3D12_CPU_DESCRIPTOR_HANDLE* pRenderTargetDescriptors,
            [In, NativeTypeName("INT")] int RTsSingleHandleToDescriptorRange,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE* pDepthStencilDescriptor = null
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_OMSetRenderTargets>(lpVtbl->OMSetRenderTargets)(
                    This,
                    NumRenderTargetDescriptors,
                    pRenderTargetDescriptors,
                    RTsSingleHandleToDescriptorRange,
                    pDepthStencilDescriptor
                );
            }
        }

        public void ClearDepthStencilView(
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView,
            [In] D3D12_CLEAR_FLAGS ClearFlags,
            [In, NativeTypeName("FLOAT")] float Depth,
            [In, NativeTypeName("UINT8")] byte Stencil,
            [In, NativeTypeName("UINT")] uint NumRects,
            [In, NativeTypeName("D3D12_RECT[]")] RECT* pRects
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearDepthStencilView>(lpVtbl->ClearDepthStencilView)(
                    This,
                    DepthStencilView,
                    ClearFlags,
                    Depth,
                    Stencil,
                    NumRects,
                    pRects
                );
            }
        }

        public void ClearRenderTargetView(
            [In] D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView,
            [In, NativeTypeName("FLOAT")] float* ColorRGBA,
            [In, NativeTypeName("UINT")] uint NumRects,
            [In, NativeTypeName("D3D12_RECT[]")] RECT* pRects
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearRenderTargetView>(lpVtbl->ClearRenderTargetView)(
                    This,
                    RenderTargetView,
                    ColorRGBA,
                    NumRects,
                    pRects
                );
            }
        }

        public void ClearUnorderedAccessViewUint(
            [In] D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle,
            [In] ID3D12Resource* pResource,
            [In, NativeTypeName("UINT")] uint* Values,
            [In, NativeTypeName("UINT")] uint NumRects,
            [In, NativeTypeName("D3D12_RECT[]")] RECT* pRects
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearUnorderedAccessViewUint>(lpVtbl->ClearUnorderedAccessViewUint)(
                    This,
                    ViewGPUHandleInCurrentHeap,
                    ViewCPUHandle,
                    pResource,
                    Values,
                    NumRects,
                    pRects
                );
            }
        }

        public void ClearUnorderedAccessViewFloat(
            [In] D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle,
            [In] ID3D12Resource* pResource,
            [In, NativeTypeName("FLOAT")] float* Values,
            [In, NativeTypeName("UINT")] uint NumRects,
            [In, NativeTypeName("D3D12_RECT[]")] RECT* pRects
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearUnorderedAccessViewFloat>(lpVtbl->ClearUnorderedAccessViewFloat)(
                    This,
                    ViewGPUHandleInCurrentHeap,
                    ViewCPUHandle,
                    pResource,
                    Values,
                    NumRects,
                    pRects
                );
            }
        }

        public void DiscardResource(
            [In] ID3D12Resource* pResource,
            [In] D3D12_DISCARD_REGION* pRegion = null
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DiscardResource>(lpVtbl->DiscardResource)(
                    This,
                    pResource,
                    pRegion
                );
            }
        }

        public void BeginQuery(
            [In] ID3D12QueryHeap* pQueryHeap,
            [In] D3D12_QUERY_TYPE Type,
            [In, NativeTypeName("UINT")] uint Index
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_BeginQuery>(lpVtbl->BeginQuery)(
                    This,
                    pQueryHeap,
                    Type,
                    Index
                );
            }
        }

        public void EndQuery(
            [In] ID3D12QueryHeap* pQueryHeap,
            [In] D3D12_QUERY_TYPE Type,
            [In, NativeTypeName("UINT")] uint Index
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_EndQuery>(lpVtbl->EndQuery)(
                    This,
                    pQueryHeap,
                    Type,
                    Index
                );
            }
        }

        public void ResolveQueryData(
            [In] ID3D12QueryHeap* pQueryHeap,
            [In] D3D12_QUERY_TYPE Type,
            [In, NativeTypeName("UINT")] uint StartIndex,
            [In, NativeTypeName("UINT")] uint NumQueries,
            [In] ID3D12Resource* pDestinationBuffer,
            [In, NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ResolveQueryData>(lpVtbl->ResolveQueryData)(
                    This,
                    pQueryHeap,
                    Type,
                    StartIndex,
                    NumQueries,
                    pDestinationBuffer,
                    AlignedDestinationBufferOffset
                );
            }
        }

        public void SetPredication(
            [In, Optional] ID3D12Resource* pBuffer,
            [In, NativeTypeName("UINT64")] ulong AlignedBufferOffset,
            [In] D3D12_PREDICATION_OP Operation
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetPredication>(lpVtbl->SetPredication)(
                    This,
                    pBuffer,
                    AlignedBufferOffset,
                    Operation
                );
            }
        }

        public void SetMarker(
            [In, NativeTypeName("UINT")] uint Metadata,
            [In, Optional] void* pData,
            [In, NativeTypeName("UINT")] uint Size
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetMarker>(lpVtbl->SetMarker)(
                    This,
                    Metadata,
                    pData,
                    Size
                );
            }
        }

        public void BeginEvent(
            [In, NativeTypeName("UINT")] uint Metadata,
            [In, Optional] void* pData,
            [In, NativeTypeName("UINT")] uint Size
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_BeginEvent>(lpVtbl->BeginEvent)(
                    This,
                    Metadata,
                    pData,
                    Size
                );
            }
        }

        public void EndEvent()
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_EndEvent>(lpVtbl->EndEvent)(
                    This
                );
            }
        }

        public void ExecuteIndirect(
            [In] ID3D12CommandSignature* pCommandSignature,
            [In, NativeTypeName("UINT")] uint MaxCommandCount,
            [In] ID3D12Resource* pArgumentBuffer,
            [In, NativeTypeName("UINT64")] ulong ArgumentBufferOffset,
            [In, Optional] ID3D12Resource* pCountBuffer,
            [In, NativeTypeName("UINT64")] ulong CountBufferOffset
        )
        {
            fixed (ID3D12GraphicsCommandList* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ExecuteIndirect>(lpVtbl->ExecuteIndirect)(
                    This,
                    pCommandSignature,
                    MaxCommandCount,
                    pArgumentBuffer,
                    ArgumentBufferOffset,
                    pCountBuffer,
                    CountBufferOffset
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
