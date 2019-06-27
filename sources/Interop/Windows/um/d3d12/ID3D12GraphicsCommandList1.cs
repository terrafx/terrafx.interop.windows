// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("553103FB-1FE7-4557-BB38-946D7D0E7CA7")]
    public unsafe struct ID3D12GraphicsCommandList1
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID3D12GraphicsCommandList1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID3D12GraphicsCommandList1* This
        );
        #endregion

        #region ID3D12Object Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPrivateData(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateData(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateDataInterface(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In] IUnknown* pData = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetName(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("LPCWSTR")] char* Name
        );
        #endregion

        #region ID3D12DeviceChild Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDevice(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvDevice = null
        );
        #endregion

        #region ID3D12CommandList Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D3D12_COMMAND_LIST_TYPE __GetType(
            [In] ID3D12GraphicsCommandList1* This
        );
        #endregion

        #region ID3D12GraphicsCommandList Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Close(
            [In] ID3D12GraphicsCommandList1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Reset(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12CommandAllocator* pAllocator,
            [In] ID3D12PipelineState* pInitialState = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _ClearState(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12PipelineState* pPipelineState = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _DrawInstanced(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint VertexCountPerInstance,
            [In, NativeTypeName("UINT")] uint InstanceCount,
            [In, NativeTypeName("UINT")] uint StartVertexLocation,
            [In, NativeTypeName("UINT")] uint StartInstanceLocation
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _DrawIndexedInstanced(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint IndexCountPerInstance,
            [In, NativeTypeName("UINT")] uint InstanceCount,
            [In, NativeTypeName("UINT")] uint StartIndexLocation,
            [In, NativeTypeName("INT")] int BaseVertexLocation,
            [In, NativeTypeName("UINT")] uint StartInstanceLocation
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _Dispatch(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint ThreadGroupCountX,
            [In, NativeTypeName("UINT")] uint ThreadGroupCountY,
            [In, NativeTypeName("UINT")] uint ThreadGroupCountZ
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _CopyBufferRegion(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12Resource* pDstBuffer,
            [In, NativeTypeName("UINT64")] ulong DstOffset,
            [In] ID3D12Resource* pSrcBuffer,
            [In, NativeTypeName("UINT64")] ulong SrcOffset,
            [In, NativeTypeName("UINT64")] ulong NumBytes
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _CopyTextureRegion(
            [In] ID3D12GraphicsCommandList1* This,
            [In] D3D12_TEXTURE_COPY_LOCATION* pDst,
            [In, NativeTypeName("UINT")] uint DstX,
            [In, NativeTypeName("UINT")] uint DstY,
            [In, NativeTypeName("UINT")] uint DstZ,
            [In] D3D12_TEXTURE_COPY_LOCATION* pSrc,
            [In] D3D12_BOX* pSrcBox = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _CopyResource(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12Resource* pDstResource,
            [In] ID3D12Resource* pSrcResource
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _CopyTiles(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12Resource* pTiledResource,
            [In] D3D12_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate,
            [In] D3D12_TILE_REGION_SIZE* pTileRegionSize,
            [In] ID3D12Resource* pBuffer,
            [In, NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes,
            [In] D3D12_TILE_COPY_FLAGS Flags
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _ResolveSubresource(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12Resource* pDstResource,
            [In, NativeTypeName("UINT")] uint DstSubresource,
            [In] ID3D12Resource* pSrcResource,
            [In, NativeTypeName("UINT")] uint SrcSubresource,
            [In] DXGI_FORMAT Format
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _IASetPrimitiveTopology(
            [In] ID3D12GraphicsCommandList1* This,
            [In] D3D_PRIMITIVE_TOPOLOGY PrimitiveTopology
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _RSSetViewports(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint NumViewports,
            [In] D3D12_VIEWPORT* pViewports
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _RSSetScissorRects(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint NumRects,
            [In, NativeTypeName("D3D12_RECT")] RECT* pRects
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _OMSetBlendFactor(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("FLOAT")] float* BlendFactor = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _OMSetStencilRef(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint StencilRef
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetPipelineState(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12PipelineState* pPipelineState
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _ResourceBarrier(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint NumBarriers,
            [In, NativeTypeName("D3D12_RESOURCE_BARRIER[]")] D3D12_RESOURCE_BARRIER* pBarriers
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _ExecuteBundle(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12GraphicsCommandList* pCommandList
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetDescriptorHeaps(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint NumDescriptorHeaps,
            [In, NativeTypeName("ID3D12DescriptorHeap*[]")] ID3D12DescriptorHeap** ppDescriptorHeaps
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetComputeRootSignature(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12RootSignature* pRootSignature = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetGraphicsRootSignature(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12RootSignature* pRootSignature = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetComputeRootDescriptorTable(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In] D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetGraphicsRootDescriptorTable(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In] D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetComputeRoot32BitConstant(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("UINT")] uint SrcData,
            [In, NativeTypeName("UINT")] uint DestOffsetIn32BitValues
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetGraphicsRoot32BitConstant(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("UINT")] uint SrcData,
            [In, NativeTypeName("UINT")] uint DestOffsetIn32BitValues
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetComputeRoot32BitConstants(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("UINT")] uint Num32BitValuesToSet,
            [In] void* pSrcData,
            [In, NativeTypeName("UINT")] uint DestOffsetIn32BitValues
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetGraphicsRoot32BitConstants(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("UINT")] uint Num32BitValuesToSet,
            [In] void* pSrcData,
            [In, NativeTypeName("UINT")] uint DestOffsetIn32BitValues
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetComputeRootConstantBufferView(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetGraphicsRootConstantBufferView(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetComputeRootShaderResourceView(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetGraphicsRootShaderResourceView(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetComputeRootUnorderedAccessView(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetGraphicsRootUnorderedAccessView(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint RootParameterIndex,
            [In, NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _IASetIndexBuffer(
            [In] ID3D12GraphicsCommandList1* This,
            [In] D3D12_INDEX_BUFFER_VIEW* pView = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _IASetVertexBuffers(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint StartSlot,
            [In, NativeTypeName("UINT")] uint NumViews,
            [In, NativeTypeName("D3D12_VERTEX_BUFFER_VIEW[]")] D3D12_VERTEX_BUFFER_VIEW* pViews = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SOSetTargets(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint StartSlot,
            [In, NativeTypeName("UINT")] uint NumViews,
            [In, NativeTypeName("D3D12_STREAM_OUTPUT_BUFFER_VIEW[]")] D3D12_STREAM_OUTPUT_BUFFER_VIEW* pViews = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _OMSetRenderTargets(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint NumRenderTargetDescriptors,
            [In, Optional, NativeTypeName("D3D12_CPU_DESCRIPTOR_HANDLE[]")] D3D12_CPU_DESCRIPTOR_HANDLE* pRenderTargetDescriptors,
            [In, NativeTypeName("INT")] int RTsSingleHandleToDescriptorRange,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE* pDepthStencilDescriptor = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _ClearDepthStencilView(
            [In] ID3D12GraphicsCommandList1* This,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView,
            [In] D3D12_CLEAR_FLAGS ClearFlags,
            [In, NativeTypeName("FLOAT")] float Depth,
            [In, NativeTypeName("UINT8")] byte Stencil,
            [In, NativeTypeName("UINT")] uint NumRects,
            [In, NativeTypeName("D3D12_RECT[]")] RECT* pRects
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _ClearRenderTargetView(
            [In] ID3D12GraphicsCommandList1* This,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView,
            [In, NativeTypeName("FLOAT")] float* ColorRGBA,
            [In, NativeTypeName("UINT")] uint NumRects,
            [In, NativeTypeName("D3D12_RECT[]")] RECT* pRects
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _ClearUnorderedAccessViewUint(
            [In] ID3D12GraphicsCommandList1* This,
            [In] D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle,
            [In] ID3D12Resource* pResource,
            [In, NativeTypeName("UINT")] uint* Values,
            [In, NativeTypeName("UINT")] uint NumRects,
            [In, NativeTypeName("D3D12_RECT[]")] RECT* pRects
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _ClearUnorderedAccessViewFloat(
            [In] ID3D12GraphicsCommandList1* This,
            [In] D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle,
            [In] ID3D12Resource* pResource,
            [In, NativeTypeName("FLOAT")] float* Values,
            [In, NativeTypeName("UINT")] uint NumRects,
            [In, NativeTypeName("D3D12_RECT[]")] RECT* pRects
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _DiscardResource(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12Resource* pResource,
            [In] D3D12_DISCARD_REGION* pRegion = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _BeginQuery(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12QueryHeap* pQueryHeap,
            [In] D3D12_QUERY_TYPE Type,
            [In, NativeTypeName("UINT")] uint Index
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _EndQuery(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12QueryHeap* pQueryHeap,
            [In] D3D12_QUERY_TYPE Type,
            [In, NativeTypeName("UINT")] uint Index
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _ResolveQueryData(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12QueryHeap* pQueryHeap,
            [In] D3D12_QUERY_TYPE Type,
            [In, NativeTypeName("UINT")] uint StartIndex,
            [In, NativeTypeName("UINT")] uint NumQueries,
            [In] ID3D12Resource* pDestinationBuffer,
            [In, NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetPredication(
            [In] ID3D12GraphicsCommandList1* This,
            [In, Optional] ID3D12Resource* pBuffer,
            [In, NativeTypeName("UINT64")] ulong AlignedBufferOffset,
            [In] D3D12_PREDICATION_OP Operation
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetMarker(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint Metadata,
            [In, Optional] void* pData,
            [In, NativeTypeName("UINT")] uint Size
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _BeginEvent(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint Metadata,
            [In, Optional] void* pData,
            [In, NativeTypeName("UINT")] uint Size
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _EndEvent(
            [In] ID3D12GraphicsCommandList1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _ExecuteIndirect(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12CommandSignature* pCommandSignature,
            [In, NativeTypeName("UINT")] uint MaxCommandCount,
            [In] ID3D12Resource* pArgumentBuffer,
            [In, NativeTypeName("UINT64")] ulong ArgumentBufferOffset,
            [In, Optional] ID3D12Resource* pCountBuffer,
            [In, NativeTypeName("UINT64")] ulong CountBufferOffset
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _AtomicCopyBufferUINT(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12Resource* pDstBuffer,
            [In, NativeTypeName("UINT64")] ulong DstOffset,
            [In] ID3D12Resource* pSrcBuffer,
            [In, NativeTypeName("UINT64")] ulong SrcOffset,
            [In, NativeTypeName("UINT")] uint Dependencies,
            [In, NativeTypeName("ID3D12Resource*[]")] ID3D12Resource** ppDependentResources,
            [In, NativeTypeName("D3D12_SUBRESOURCE_RANGE_UINT64[]")] D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _AtomicCopyBufferUINT64(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12Resource* pDstBuffer,
            [In, NativeTypeName("UINT64")] ulong DstOffset,
            [In] ID3D12Resource* pSrcBuffer,
            [In, NativeTypeName("UINT64")] ulong SrcOffset,
            [In, NativeTypeName("UINT")] uint Dependencies,
            [In, NativeTypeName("ID3D12Resource*[]")] ID3D12Resource** ppDependentResources,
            [In, NativeTypeName("D3D12_SUBRESOURCE_RANGE_UINT64[]")] D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _OMSetDepthBounds(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("FLOAT")] float Min,
            [In, NativeTypeName("FLOAT")] float Max
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetSamplePositions(
            [In] ID3D12GraphicsCommandList1* This,
            [In, NativeTypeName("UINT")] uint NumSamplesPerPixel,
            [In, NativeTypeName("UINT")] uint NumPixels,
            [In, NativeTypeName("D3D12_SAMPLE_POSITION[]")] D3D12_SAMPLE_POSITION* pSamplePositions
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _ResolveSubresourceRegion(
            [In] ID3D12GraphicsCommandList1* This,
            [In] ID3D12Resource* pDstResource,
            [In, NativeTypeName("UINT")] uint DstSubresource,
            [In, NativeTypeName("UINT")] uint DstX,
            [In, NativeTypeName("UINT")] uint DstY,
            [In] ID3D12Resource* pSrcResource,
            [In, NativeTypeName("UINT")] uint SrcSubresource,
            [In, Optional, NativeTypeName("D3D12_RECT")] RECT* pSrcRect,
            [In] DXGI_FORMAT Format,
            [In] D3D12_RESOLVE_MODE ResolveMode
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region ID3D12Object Methods
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData(
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData = null
        )
        {
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                return MarshalFunction<_GetPrivateData>(lpVtbl->GetPrivateData)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                return MarshalFunction<_SetPrivateData>(lpVtbl->SetPrivateData)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                return MarshalFunction<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                return MarshalFunction<_SetName>(lpVtbl->SetName)(
                    This,
                    Name
                );
            }
        }
        #endregion

        #region ID3D12DeviceChild Methods
        [return: NativeTypeName("HRESULT")]
        public int GetDevice(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvDevice = null
        )
        {
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                return MarshalFunction<_GetDevice>(lpVtbl->GetDevice)(
                    This,
                    riid,
                    ppvDevice
                );
            }
        }
        #endregion

        #region ID3D12CommandList Methods
        public D3D12_COMMAND_LIST_TYPE _GetType()
        {
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                return MarshalFunction<__GetType>(lpVtbl->_GetType)(
                    This
                );
            }
        }
        #endregion

        #region ID3D12GraphicsCommandList Methods
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                return MarshalFunction<_Close>(lpVtbl->Close)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                return MarshalFunction<_Reset>(lpVtbl->Reset)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_ClearState>(lpVtbl->ClearState)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_DrawInstanced>(lpVtbl->DrawInstanced)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_DrawIndexedInstanced>(lpVtbl->DrawIndexedInstanced)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_Dispatch>(lpVtbl->Dispatch)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_CopyBufferRegion>(lpVtbl->CopyBufferRegion)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_CopyTextureRegion>(lpVtbl->CopyTextureRegion)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_CopyResource>(lpVtbl->CopyResource)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_CopyTiles>(lpVtbl->CopyTiles)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_ResolveSubresource>(lpVtbl->ResolveSubresource)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_IASetPrimitiveTopology>(lpVtbl->IASetPrimitiveTopology)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_RSSetViewports>(lpVtbl->RSSetViewports)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_RSSetScissorRects>(lpVtbl->RSSetScissorRects)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_OMSetBlendFactor>(lpVtbl->OMSetBlendFactor)(
                    This,
                    BlendFactor
                );
            }
        }

        public void OMSetStencilRef(
            [In, NativeTypeName("UINT")] uint StencilRef
        )
        {
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_OMSetStencilRef>(lpVtbl->OMSetStencilRef)(
                    This,
                    StencilRef
                );
            }
        }

        public void SetPipelineState(
            [In] ID3D12PipelineState* pPipelineState
        )
        {
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetPipelineState>(lpVtbl->SetPipelineState)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_ResourceBarrier>(lpVtbl->ResourceBarrier)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_ExecuteBundle>(lpVtbl->ExecuteBundle)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetDescriptorHeaps>(lpVtbl->SetDescriptorHeaps)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetComputeRootSignature>(lpVtbl->SetComputeRootSignature)(
                    This,
                    pRootSignature
                );
            }
        }

        public void SetGraphicsRootSignature(
            [In] ID3D12RootSignature* pRootSignature = null
        )
        {
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetGraphicsRootSignature>(lpVtbl->SetGraphicsRootSignature)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetComputeRootDescriptorTable>(lpVtbl->SetComputeRootDescriptorTable)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetGraphicsRootDescriptorTable>(lpVtbl->SetGraphicsRootDescriptorTable)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetComputeRoot32BitConstant>(lpVtbl->SetComputeRoot32BitConstant)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetGraphicsRoot32BitConstant>(lpVtbl->SetGraphicsRoot32BitConstant)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetComputeRoot32BitConstants>(lpVtbl->SetComputeRoot32BitConstants)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetGraphicsRoot32BitConstants>(lpVtbl->SetGraphicsRoot32BitConstants)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetComputeRootConstantBufferView>(lpVtbl->SetComputeRootConstantBufferView)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetGraphicsRootConstantBufferView>(lpVtbl->SetGraphicsRootConstantBufferView)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetComputeRootShaderResourceView>(lpVtbl->SetComputeRootShaderResourceView)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetGraphicsRootShaderResourceView>(lpVtbl->SetGraphicsRootShaderResourceView)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetComputeRootUnorderedAccessView>(lpVtbl->SetComputeRootUnorderedAccessView)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetGraphicsRootUnorderedAccessView>(lpVtbl->SetGraphicsRootUnorderedAccessView)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_IASetIndexBuffer>(lpVtbl->IASetIndexBuffer)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_IASetVertexBuffers>(lpVtbl->IASetVertexBuffers)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SOSetTargets>(lpVtbl->SOSetTargets)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_OMSetRenderTargets>(lpVtbl->OMSetRenderTargets)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_ClearDepthStencilView>(lpVtbl->ClearDepthStencilView)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_ClearRenderTargetView>(lpVtbl->ClearRenderTargetView)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_ClearUnorderedAccessViewUint>(lpVtbl->ClearUnorderedAccessViewUint)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_ClearUnorderedAccessViewFloat>(lpVtbl->ClearUnorderedAccessViewFloat)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_DiscardResource>(lpVtbl->DiscardResource)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_BeginQuery>(lpVtbl->BeginQuery)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_EndQuery>(lpVtbl->EndQuery)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_ResolveQueryData>(lpVtbl->ResolveQueryData)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetPredication>(lpVtbl->SetPredication)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetMarker>(lpVtbl->SetMarker)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_BeginEvent>(lpVtbl->BeginEvent)(
                    This,
                    Metadata,
                    pData,
                    Size
                );
            }
        }

        public void EndEvent()
        {
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_EndEvent>(lpVtbl->EndEvent)(
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
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_ExecuteIndirect>(lpVtbl->ExecuteIndirect)(
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
        #endregion

        #region Methods
        public void AtomicCopyBufferUINT(
            [In] ID3D12Resource* pDstBuffer,
            [In, NativeTypeName("UINT64")] ulong DstOffset,
            [In] ID3D12Resource* pSrcBuffer,
            [In, NativeTypeName("UINT64")] ulong SrcOffset,
            [In, NativeTypeName("UINT")] uint Dependencies,
            [In, NativeTypeName("ID3D12Resource*[]")] ID3D12Resource** ppDependentResources,
            [In, NativeTypeName("D3D12_SUBRESOURCE_RANGE_UINT64[]")] D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges
        )
        {
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_AtomicCopyBufferUINT>(lpVtbl->AtomicCopyBufferUINT)(
                    This,
                    pDstBuffer,
                    DstOffset,
                    pSrcBuffer,
                    SrcOffset,
                    Dependencies,
                    ppDependentResources,
                    pDependentSubresourceRanges
                );
            }
        }

        public void AtomicCopyBufferUINT64(
            [In] ID3D12Resource* pDstBuffer,
            [In, NativeTypeName("UINT64")] ulong DstOffset,
            [In] ID3D12Resource* pSrcBuffer,
            [In, NativeTypeName("UINT64")] ulong SrcOffset,
            [In, NativeTypeName("UINT")] uint Dependencies,
            [In, NativeTypeName("ID3D12Resource*[]")] ID3D12Resource** ppDependentResources,
            [In, NativeTypeName("D3D12_SUBRESOURCE_RANGE_UINT64[]")] D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges
        )
        {
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_AtomicCopyBufferUINT64>(lpVtbl->AtomicCopyBufferUINT64)(
                    This,
                    pDstBuffer,
                    DstOffset,
                    pSrcBuffer,
                    SrcOffset,
                    Dependencies,
                    ppDependentResources,
                    pDependentSubresourceRanges
                );
            }
        }

        public void OMSetDepthBounds(
            [In, NativeTypeName("FLOAT")] float Min,
            [In, NativeTypeName("FLOAT")] float Max
        )
        {
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_OMSetDepthBounds>(lpVtbl->OMSetDepthBounds)(
                    This,
                    Min,
                    Max
                );
            }
        }

        public void SetSamplePositions(
            [In, NativeTypeName("UINT")] uint NumSamplesPerPixel,
            [In, NativeTypeName("UINT")] uint NumPixels,
            [In, NativeTypeName("D3D12_SAMPLE_POSITION[]")] D3D12_SAMPLE_POSITION* pSamplePositions
        )
        {
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_SetSamplePositions>(lpVtbl->SetSamplePositions)(
                    This,
                    NumSamplesPerPixel,
                    NumPixels,
                    pSamplePositions
                );
            }
        }

        public void ResolveSubresourceRegion(
            [In] ID3D12Resource* pDstResource,
            [In, NativeTypeName("UINT")] uint DstSubresource,
            [In, NativeTypeName("UINT")] uint DstX,
            [In, NativeTypeName("UINT")] uint DstY,
            [In] ID3D12Resource* pSrcResource,
            [In, NativeTypeName("UINT")] uint SrcSubresource,
            [In, Optional, NativeTypeName("D3D12_RECT")] RECT* pSrcRect,
            [In] DXGI_FORMAT Format,
            [In] D3D12_RESOLVE_MODE ResolveMode
        )
        {
            fixed (ID3D12GraphicsCommandList1* This = &this)
            {
                MarshalFunction<_ResolveSubresourceRegion>(lpVtbl->ResolveSubresourceRegion)(
                    This,
                    pDstResource,
                    DstSubresource,
                    DstX,
                    DstY,
                    pSrcResource,
                    SrcSubresource,
                    pSrcRect,
                    Format,
                    ResolveMode
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region ID3D12Object Fields
            public IntPtr GetPrivateData;

            public IntPtr SetPrivateData;

            public IntPtr SetPrivateDataInterface;

            public IntPtr SetName;
            #endregion

            #region ID3D12DeviceChild Fields
            public IntPtr GetDevice;
            #endregion

            #region ID3D12CommandList Fields
            public IntPtr _GetType;
            #endregion

            #region ID3D12GraphicsCommandList Fields
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
            #endregion

            #region Fields
            public IntPtr AtomicCopyBufferUINT;

            public IntPtr AtomicCopyBufferUINT64;

            public IntPtr OMSetDepthBounds;

            public IntPtr SetSamplePositions;

            public IntPtr ResolveSubresourceRegion;
            #endregion
        }
        #endregion
    }
}
