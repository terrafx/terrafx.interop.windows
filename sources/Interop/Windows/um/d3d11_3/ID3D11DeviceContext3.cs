// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B4E3C01D-E79E-4637-91B2-510E9F4C9B8F")]
    public unsafe partial struct ID3D11DeviceContext3
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11DeviceContext3* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11DeviceContext3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11DeviceContext3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDevice(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D11DeviceContext3* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D11DeviceContext3* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D11DeviceContext3* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VSSetConstantBuffers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PSSetShaderResources(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PSSetShader(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11PixelShader *")] ID3D11PixelShader* pPixelShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PSSetSamplers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VSSetShader(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11VertexShader *")] ID3D11VertexShader* pVertexShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawIndexed(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint IndexCount, [NativeTypeName("UINT")] uint StartIndexLocation, [NativeTypeName("INT")] int BaseVertexLocation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Draw(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint VertexCount, [NativeTypeName("UINT")] uint StartVertexLocation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Map(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("UINT")] uint Subresource, D3D11_MAP MapType, [NativeTypeName("UINT")] uint MapFlags, [NativeTypeName("D3D11_MAPPED_SUBRESOURCE *")] D3D11_MAPPED_SUBRESOURCE* pMappedResource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Unmap(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("UINT")] uint Subresource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PSSetConstantBuffers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _IASetInputLayout(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11InputLayout *")] ID3D11InputLayout* pInputLayout);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _IASetVertexBuffers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppVertexBuffers, [NativeTypeName("const UINT *")] uint* pStrides, [NativeTypeName("const UINT *")] uint* pOffsets);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _IASetIndexBuffer(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pIndexBuffer, DXGI_FORMAT Format, [NativeTypeName("UINT")] uint Offset);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawIndexedInstanced(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint IndexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartIndexLocation, [NativeTypeName("INT")] int BaseVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawInstanced(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint VertexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GSSetConstantBuffers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GSSetShader(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11GeometryShader *")] ID3D11GeometryShader* pShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _IASetPrimitiveTopology(ID3D11DeviceContext3* pThis, [NativeTypeName("D3D11_PRIMITIVE_TOPOLOGY")] D3D_PRIMITIVE_TOPOLOGY Topology);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VSSetShaderResources(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VSSetSamplers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Begin(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Asynchronous *")] ID3D11Asynchronous* pAsync);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _End(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Asynchronous *")] ID3D11Asynchronous* pAsync);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetData(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Asynchronous *")] ID3D11Asynchronous* pAsync, [NativeTypeName("void *")] void* pData, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("UINT")] uint GetDataFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetPredication(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Predicate *")] ID3D11Predicate* pPredicate, [NativeTypeName("BOOL")] int PredicateValue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GSSetShaderResources(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GSSetSamplers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _OMSetRenderTargets(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11RenderTargetView *const *")] ID3D11RenderTargetView** ppRenderTargetViews, [NativeTypeName("ID3D11DepthStencilView *")] ID3D11DepthStencilView* pDepthStencilView);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _OMSetRenderTargetsAndUnorderedAccessViews(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint NumRTVs, [NativeTypeName("ID3D11RenderTargetView *const *")] ID3D11RenderTargetView** ppRenderTargetViews, [NativeTypeName("ID3D11DepthStencilView *")] ID3D11DepthStencilView* pDepthStencilView, [NativeTypeName("UINT")] uint UAVStartSlot, [NativeTypeName("UINT")] uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView *const *")] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [NativeTypeName("const UINT *")] uint* pUAVInitialCounts);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _OMSetBlendState(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11BlendState *")] ID3D11BlendState* pBlendState, [NativeTypeName("const FLOAT [4]")] float* BlendFactor, [NativeTypeName("UINT")] uint SampleMask);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _OMSetDepthStencilState(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11DepthStencilState *")] ID3D11DepthStencilState* pDepthStencilState, [NativeTypeName("UINT")] uint StencilRef);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SOSetTargets(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppSOTargets, [NativeTypeName("const UINT *")] uint* pOffsets);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawAuto(ID3D11DeviceContext3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawIndexedInstancedIndirect(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pBufferForArgs, [NativeTypeName("UINT")] uint AlignedByteOffsetForArgs);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawInstancedIndirect(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pBufferForArgs, [NativeTypeName("UINT")] uint AlignedByteOffsetForArgs);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Dispatch(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint ThreadGroupCountX, [NativeTypeName("UINT")] uint ThreadGroupCountY, [NativeTypeName("UINT")] uint ThreadGroupCountZ);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DispatchIndirect(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pBufferForArgs, [NativeTypeName("UINT")] uint AlignedByteOffsetForArgs);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _RSSetState(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11RasterizerState *")] ID3D11RasterizerState* pRasterizerState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _RSSetViewports(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint NumViewports, [NativeTypeName("const D3D11_VIEWPORT *")] D3D11_VIEWPORT* pViewports);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _RSSetScissorRects(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D11_RECT *")] RECT* pRects);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopySubresourceRegion(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("UINT")] uint DstZ, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pSrcBox);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopyResource(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSrcResource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _UpdateSubresource(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopyStructureCount(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pDstBuffer, [NativeTypeName("UINT")] uint DstAlignedByteOffset, [NativeTypeName("ID3D11UnorderedAccessView *")] ID3D11UnorderedAccessView* pSrcView);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearRenderTargetView(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11RenderTargetView *")] ID3D11RenderTargetView* pRenderTargetView, [NativeTypeName("const FLOAT [4]")] float* ColorRGBA);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearUnorderedAccessViewUint(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11UnorderedAccessView *")] ID3D11UnorderedAccessView* pUnorderedAccessView, [NativeTypeName("const UINT [4]")] uint* Values);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearUnorderedAccessViewFloat(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11UnorderedAccessView *")] ID3D11UnorderedAccessView* pUnorderedAccessView, [NativeTypeName("const FLOAT [4]")] float* Values);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearDepthStencilView(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11DepthStencilView *")] ID3D11DepthStencilView* pDepthStencilView, [NativeTypeName("UINT")] uint ClearFlags, [NativeTypeName("FLOAT")] float Depth, [NativeTypeName("UINT8")] byte Stencil);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GenerateMips(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11ShaderResourceView *")] ID3D11ShaderResourceView* pShaderResourceView);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetResourceMinLOD(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("FLOAT")] float MinLOD);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetResourceMinLOD(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ResolveSubresource(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, DXGI_FORMAT Format);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ExecuteCommandList(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11CommandList *")] ID3D11CommandList* pCommandList, [NativeTypeName("BOOL")] int RestoreContextState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _HSSetShaderResources(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _HSSetShader(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11HullShader *")] ID3D11HullShader* pHullShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _HSSetSamplers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _HSSetConstantBuffers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DSSetShaderResources(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DSSetShader(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11DomainShader *")] ID3D11DomainShader* pDomainShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DSSetSamplers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DSSetConstantBuffers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CSSetShaderResources(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CSSetUnorderedAccessViews(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView *const *")] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [NativeTypeName("const UINT *")] uint* pUAVInitialCounts);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CSSetShader(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11ComputeShader *")] ID3D11ComputeShader* pComputeShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CSSetSamplers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CSSetConstantBuffers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VSGetConstantBuffers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PSGetShaderResources(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PSGetShader(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11PixelShader **")] ID3D11PixelShader** ppPixelShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PSGetSamplers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VSGetShader(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11VertexShader **")] ID3D11VertexShader** ppVertexShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PSGetConstantBuffers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _IAGetInputLayout(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11InputLayout **")] ID3D11InputLayout** ppInputLayout);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _IAGetVertexBuffers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppVertexBuffers, [NativeTypeName("UINT *")] uint* pStrides, [NativeTypeName("UINT *")] uint* pOffsets);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _IAGetIndexBuffer(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** pIndexBuffer, [NativeTypeName("DXGI_FORMAT *")] DXGI_FORMAT* Format, [NativeTypeName("UINT *")] uint* Offset);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GSGetConstantBuffers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GSGetShader(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11GeometryShader **")] ID3D11GeometryShader** ppGeometryShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _IAGetPrimitiveTopology(ID3D11DeviceContext3* pThis, [NativeTypeName("D3D11_PRIMITIVE_TOPOLOGY *")] D3D_PRIMITIVE_TOPOLOGY* pTopology);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VSGetShaderResources(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VSGetSamplers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetPredication(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Predicate **")] ID3D11Predicate** ppPredicate, [NativeTypeName("BOOL *")] int* pPredicateValue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GSGetShaderResources(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GSGetSamplers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _OMGetRenderTargets(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11RenderTargetView **")] ID3D11RenderTargetView** ppRenderTargetViews, [NativeTypeName("ID3D11DepthStencilView **")] ID3D11DepthStencilView** ppDepthStencilView);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _OMGetRenderTargetsAndUnorderedAccessViews(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint NumRTVs, [NativeTypeName("ID3D11RenderTargetView **")] ID3D11RenderTargetView** ppRenderTargetViews, [NativeTypeName("ID3D11DepthStencilView **")] ID3D11DepthStencilView** ppDepthStencilView, [NativeTypeName("UINT")] uint UAVStartSlot, [NativeTypeName("UINT")] uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView **")] ID3D11UnorderedAccessView** ppUnorderedAccessViews);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _OMGetBlendState(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11BlendState **")] ID3D11BlendState** ppBlendState, [NativeTypeName("FLOAT [4]")] float* BlendFactor, [NativeTypeName("UINT *")] uint* pSampleMask);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _OMGetDepthStencilState(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11DepthStencilState **")] ID3D11DepthStencilState** ppDepthStencilState, [NativeTypeName("UINT *")] uint* pStencilRef);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SOGetTargets(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppSOTargets);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _RSGetState(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11RasterizerState **")] ID3D11RasterizerState** ppRasterizerState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _RSGetViewports(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT *")] uint* pNumViewports, [NativeTypeName("D3D11_VIEWPORT *")] D3D11_VIEWPORT* pViewports);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _RSGetScissorRects(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT *")] uint* pNumRects, [NativeTypeName("D3D11_RECT *")] RECT* pRects);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _HSGetShaderResources(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _HSGetShader(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11HullShader **")] ID3D11HullShader** ppHullShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _HSGetSamplers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _HSGetConstantBuffers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DSGetShaderResources(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DSGetShader(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11DomainShader **")] ID3D11DomainShader** ppDomainShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DSGetSamplers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DSGetConstantBuffers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CSGetShaderResources(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CSGetUnorderedAccessViews(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView **")] ID3D11UnorderedAccessView** ppUnorderedAccessViews);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CSGetShader(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11ComputeShader **")] ID3D11ComputeShader** ppComputeShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CSGetSamplers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CSGetConstantBuffers(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearState(ID3D11DeviceContext3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Flush(ID3D11DeviceContext3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D11_DEVICE_CONTEXT_TYPE _GetType(ID3D11DeviceContext3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetContextFlags(ID3D11DeviceContext3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FinishCommandList(ID3D11DeviceContext3* pThis, [NativeTypeName("BOOL")] int RestoreDeferredContextState, [NativeTypeName("ID3D11CommandList **")] ID3D11CommandList** ppCommandList);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopySubresourceRegion1(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("UINT")] uint DstZ, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pSrcBox, [NativeTypeName("UINT")] uint CopyFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _UpdateSubresource1(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch, [NativeTypeName("UINT")] uint CopyFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DiscardResource(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DiscardView(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11View *")] ID3D11View* pResourceView);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VSSetConstantBuffers1(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _HSSetConstantBuffers1(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DSSetConstantBuffers1(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GSSetConstantBuffers1(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PSSetConstantBuffers1(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CSSetConstantBuffers1(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _VSGetConstantBuffers1(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _HSGetConstantBuffers1(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DSGetConstantBuffers1(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GSGetConstantBuffers1(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PSGetConstantBuffers1(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CSGetConstantBuffers1(ID3D11DeviceContext3* pThis, [NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SwapDeviceContextState(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3DDeviceContextState *")] ID3DDeviceContextState* pState, [NativeTypeName("ID3DDeviceContextState **")] ID3DDeviceContextState** ppPreviousState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearView(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11View *")] ID3D11View* pView, [NativeTypeName("const FLOAT [4]")] float* Color, [NativeTypeName("const D3D11_RECT *")] RECT* pRect, [NativeTypeName("UINT")] uint NumRects);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DiscardView1(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11View *")] ID3D11View* pResourceView, [NativeTypeName("const D3D11_RECT *")] RECT* pRects, [NativeTypeName("UINT")] uint NumRects);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UpdateTileMappings(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pTiledResource, [NativeTypeName("UINT")] uint NumTiledResourceRegions, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pTiledResourceRegionStartCoordinates, [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pTiledResourceRegionSizes, [NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pTilePool, [NativeTypeName("UINT")] uint NumRanges, [NativeTypeName("const UINT *")] uint* pRangeFlags, [NativeTypeName("const UINT *")] uint* pTilePoolStartOffsets, [NativeTypeName("const UINT *")] uint* pRangeTileCounts, [NativeTypeName("UINT")] uint Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyTileMappings(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDestTiledResource, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pDestRegionStartCoordinate, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSourceTiledResource, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pSourceRegionStartCoordinate, [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pTileRegionSize, [NativeTypeName("UINT")] uint Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CopyTiles(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pTiledResource, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate, [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pTileRegionSize, [NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, [NativeTypeName("UINT")] uint Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _UpdateTiles(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDestTiledResource, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pDestTileRegionStartCoordinate, [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pDestTileRegionSize, [NativeTypeName("const void *")] void* pSourceTileData, [NativeTypeName("UINT")] uint Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ResizeTilePool(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pTilePool, [NativeTypeName("UINT64")] ulong NewSizeInBytes);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _TiledResourceBarrier(ID3D11DeviceContext3* pThis, [NativeTypeName("ID3D11DeviceChild *")] ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrier, [NativeTypeName("ID3D11DeviceChild *")] ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrier);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsAnnotationEnabled(ID3D11DeviceContext3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetMarkerInt(ID3D11DeviceContext3* pThis, [NativeTypeName("LPCWSTR")] ushort* pLabel, [NativeTypeName("INT")] int Data);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _BeginEventInt(ID3D11DeviceContext3* pThis, [NativeTypeName("LPCWSTR")] ushort* pLabel, [NativeTypeName("INT")] int Data);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _EndEvent(ID3D11DeviceContext3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Flush1(ID3D11DeviceContext3* pThis, D3D11_CONTEXT_TYPE ContextType, [NativeTypeName("HANDLE")] IntPtr hEvent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetHardwareProtectionState(ID3D11DeviceContext3* pThis, [NativeTypeName("BOOL")] int HwProtectionEnable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetHardwareProtectionState(ID3D11DeviceContext3* pThis, [NativeTypeName("BOOL *")] int* pHwProtectionEnable);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), guid, pData);
        }

        public void VSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            Marshal.GetDelegateForFunctionPointer<_VSSetConstantBuffers>(lpVtbl->VSSetConstantBuffers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void PSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            Marshal.GetDelegateForFunctionPointer<_PSSetShaderResources>(lpVtbl->PSSetShaderResources)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void PSSetShader([NativeTypeName("ID3D11PixelShader *")] ID3D11PixelShader* pPixelShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            Marshal.GetDelegateForFunctionPointer<_PSSetShader>(lpVtbl->PSSetShader)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pPixelShader, ppClassInstances, NumClassInstances);
        }

        public void PSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            Marshal.GetDelegateForFunctionPointer<_PSSetSamplers>(lpVtbl->PSSetSamplers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void VSSetShader([NativeTypeName("ID3D11VertexShader *")] ID3D11VertexShader* pVertexShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            Marshal.GetDelegateForFunctionPointer<_VSSetShader>(lpVtbl->VSSetShader)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pVertexShader, ppClassInstances, NumClassInstances);
        }

        public void DrawIndexed([NativeTypeName("UINT")] uint IndexCount, [NativeTypeName("UINT")] uint StartIndexLocation, [NativeTypeName("INT")] int BaseVertexLocation)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawIndexed>(lpVtbl->DrawIndexed)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), IndexCount, StartIndexLocation, BaseVertexLocation);
        }

        public void Draw([NativeTypeName("UINT")] uint VertexCount, [NativeTypeName("UINT")] uint StartVertexLocation)
        {
            Marshal.GetDelegateForFunctionPointer<_Draw>(lpVtbl->Draw)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), VertexCount, StartVertexLocation);
        }

        [return: NativeTypeName("HRESULT")]
        public int Map([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("UINT")] uint Subresource, D3D11_MAP MapType, [NativeTypeName("UINT")] uint MapFlags, [NativeTypeName("D3D11_MAPPED_SUBRESOURCE *")] D3D11_MAPPED_SUBRESOURCE* pMappedResource)
        {
            return Marshal.GetDelegateForFunctionPointer<_Map>(lpVtbl->Map)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pResource, Subresource, MapType, MapFlags, pMappedResource);
        }

        public void Unmap([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("UINT")] uint Subresource)
        {
            Marshal.GetDelegateForFunctionPointer<_Unmap>(lpVtbl->Unmap)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pResource, Subresource);
        }

        public void PSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            Marshal.GetDelegateForFunctionPointer<_PSSetConstantBuffers>(lpVtbl->PSSetConstantBuffers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void IASetInputLayout([NativeTypeName("ID3D11InputLayout *")] ID3D11InputLayout* pInputLayout)
        {
            Marshal.GetDelegateForFunctionPointer<_IASetInputLayout>(lpVtbl->IASetInputLayout)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pInputLayout);
        }

        public void IASetVertexBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppVertexBuffers, [NativeTypeName("const UINT *")] uint* pStrides, [NativeTypeName("const UINT *")] uint* pOffsets)
        {
            Marshal.GetDelegateForFunctionPointer<_IASetVertexBuffers>(lpVtbl->IASetVertexBuffers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        public void IASetIndexBuffer([NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pIndexBuffer, DXGI_FORMAT Format, [NativeTypeName("UINT")] uint Offset)
        {
            Marshal.GetDelegateForFunctionPointer<_IASetIndexBuffer>(lpVtbl->IASetIndexBuffer)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pIndexBuffer, Format, Offset);
        }

        public void DrawIndexedInstanced([NativeTypeName("UINT")] uint IndexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartIndexLocation, [NativeTypeName("INT")] int BaseVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawIndexedInstanced>(lpVtbl->DrawIndexedInstanced)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
        }

        public void DrawInstanced([NativeTypeName("UINT")] uint VertexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawInstanced>(lpVtbl->DrawInstanced)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
        }

        public void GSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            Marshal.GetDelegateForFunctionPointer<_GSSetConstantBuffers>(lpVtbl->GSSetConstantBuffers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void GSSetShader([NativeTypeName("ID3D11GeometryShader *")] ID3D11GeometryShader* pShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            Marshal.GetDelegateForFunctionPointer<_GSSetShader>(lpVtbl->GSSetShader)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pShader, ppClassInstances, NumClassInstances);
        }

        public void IASetPrimitiveTopology([NativeTypeName("D3D11_PRIMITIVE_TOPOLOGY")] D3D_PRIMITIVE_TOPOLOGY Topology)
        {
            Marshal.GetDelegateForFunctionPointer<_IASetPrimitiveTopology>(lpVtbl->IASetPrimitiveTopology)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), Topology);
        }

        public void VSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            Marshal.GetDelegateForFunctionPointer<_VSSetShaderResources>(lpVtbl->VSSetShaderResources)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void VSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            Marshal.GetDelegateForFunctionPointer<_VSSetSamplers>(lpVtbl->VSSetSamplers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void Begin([NativeTypeName("ID3D11Asynchronous *")] ID3D11Asynchronous* pAsync)
        {
            Marshal.GetDelegateForFunctionPointer<_Begin>(lpVtbl->Begin)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pAsync);
        }

        public void End([NativeTypeName("ID3D11Asynchronous *")] ID3D11Asynchronous* pAsync)
        {
            Marshal.GetDelegateForFunctionPointer<_End>(lpVtbl->End)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pAsync);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("ID3D11Asynchronous *")] ID3D11Asynchronous* pAsync, [NativeTypeName("void *")] void* pData, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("UINT")] uint GetDataFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetData>(lpVtbl->GetData)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pAsync, pData, DataSize, GetDataFlags);
        }

        public void SetPredication([NativeTypeName("ID3D11Predicate *")] ID3D11Predicate* pPredicate, [NativeTypeName("BOOL")] int PredicateValue)
        {
            Marshal.GetDelegateForFunctionPointer<_SetPredication>(lpVtbl->SetPredication)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pPredicate, PredicateValue);
        }

        public void GSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            Marshal.GetDelegateForFunctionPointer<_GSSetShaderResources>(lpVtbl->GSSetShaderResources)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void GSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            Marshal.GetDelegateForFunctionPointer<_GSSetSamplers>(lpVtbl->GSSetSamplers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void OMSetRenderTargets([NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11RenderTargetView *const *")] ID3D11RenderTargetView** ppRenderTargetViews, [NativeTypeName("ID3D11DepthStencilView *")] ID3D11DepthStencilView* pDepthStencilView)
        {
            Marshal.GetDelegateForFunctionPointer<_OMSetRenderTargets>(lpVtbl->OMSetRenderTargets)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), NumViews, ppRenderTargetViews, pDepthStencilView);
        }

        public void OMSetRenderTargetsAndUnorderedAccessViews([NativeTypeName("UINT")] uint NumRTVs, [NativeTypeName("ID3D11RenderTargetView *const *")] ID3D11RenderTargetView** ppRenderTargetViews, [NativeTypeName("ID3D11DepthStencilView *")] ID3D11DepthStencilView* pDepthStencilView, [NativeTypeName("UINT")] uint UAVStartSlot, [NativeTypeName("UINT")] uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView *const *")] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [NativeTypeName("const UINT *")] uint* pUAVInitialCounts)
        {
            Marshal.GetDelegateForFunctionPointer<_OMSetRenderTargetsAndUnorderedAccessViews>(lpVtbl->OMSetRenderTargetsAndUnorderedAccessViews)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }

        public void OMSetBlendState([NativeTypeName("ID3D11BlendState *")] ID3D11BlendState* pBlendState, [NativeTypeName("const FLOAT [4]")] float* BlendFactor, [NativeTypeName("UINT")] uint SampleMask)
        {
            Marshal.GetDelegateForFunctionPointer<_OMSetBlendState>(lpVtbl->OMSetBlendState)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pBlendState, BlendFactor, SampleMask);
        }

        public void OMSetDepthStencilState([NativeTypeName("ID3D11DepthStencilState *")] ID3D11DepthStencilState* pDepthStencilState, [NativeTypeName("UINT")] uint StencilRef)
        {
            Marshal.GetDelegateForFunctionPointer<_OMSetDepthStencilState>(lpVtbl->OMSetDepthStencilState)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDepthStencilState, StencilRef);
        }

        public void SOSetTargets([NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppSOTargets, [NativeTypeName("const UINT *")] uint* pOffsets)
        {
            Marshal.GetDelegateForFunctionPointer<_SOSetTargets>(lpVtbl->SOSetTargets)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), NumBuffers, ppSOTargets, pOffsets);
        }

        public void DrawAuto()
        {
            Marshal.GetDelegateForFunctionPointer<_DrawAuto>(lpVtbl->DrawAuto)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        public void DrawIndexedInstancedIndirect([NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pBufferForArgs, [NativeTypeName("UINT")] uint AlignedByteOffsetForArgs)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawIndexedInstancedIndirect>(lpVtbl->DrawIndexedInstancedIndirect)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pBufferForArgs, AlignedByteOffsetForArgs);
        }

        public void DrawInstancedIndirect([NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pBufferForArgs, [NativeTypeName("UINT")] uint AlignedByteOffsetForArgs)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawInstancedIndirect>(lpVtbl->DrawInstancedIndirect)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pBufferForArgs, AlignedByteOffsetForArgs);
        }

        public void Dispatch([NativeTypeName("UINT")] uint ThreadGroupCountX, [NativeTypeName("UINT")] uint ThreadGroupCountY, [NativeTypeName("UINT")] uint ThreadGroupCountZ)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispatch>(lpVtbl->Dispatch)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
        }

        public void DispatchIndirect([NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pBufferForArgs, [NativeTypeName("UINT")] uint AlignedByteOffsetForArgs)
        {
            Marshal.GetDelegateForFunctionPointer<_DispatchIndirect>(lpVtbl->DispatchIndirect)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pBufferForArgs, AlignedByteOffsetForArgs);
        }

        public void RSSetState([NativeTypeName("ID3D11RasterizerState *")] ID3D11RasterizerState* pRasterizerState)
        {
            Marshal.GetDelegateForFunctionPointer<_RSSetState>(lpVtbl->RSSetState)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pRasterizerState);
        }

        public void RSSetViewports([NativeTypeName("UINT")] uint NumViewports, [NativeTypeName("const D3D11_VIEWPORT *")] D3D11_VIEWPORT* pViewports)
        {
            Marshal.GetDelegateForFunctionPointer<_RSSetViewports>(lpVtbl->RSSetViewports)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
        }

        public void RSSetScissorRects([NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D11_RECT *")] RECT* pRects)
        {
            Marshal.GetDelegateForFunctionPointer<_RSSetScissorRects>(lpVtbl->RSSetScissorRects)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), NumRects, pRects);
        }

        public void CopySubresourceRegion([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("UINT")] uint DstZ, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pSrcBox)
        {
            Marshal.GetDelegateForFunctionPointer<_CopySubresourceRegion>(lpVtbl->CopySubresourceRegion)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
        }

        public void CopyResource([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSrcResource)
        {
            Marshal.GetDelegateForFunctionPointer<_CopyResource>(lpVtbl->CopyResource)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDstResource, pSrcResource);
        }

        public void UpdateSubresource([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch)
        {
            Marshal.GetDelegateForFunctionPointer<_UpdateSubresource>(lpVtbl->UpdateSubresource)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        public void CopyStructureCount([NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pDstBuffer, [NativeTypeName("UINT")] uint DstAlignedByteOffset, [NativeTypeName("ID3D11UnorderedAccessView *")] ID3D11UnorderedAccessView* pSrcView)
        {
            Marshal.GetDelegateForFunctionPointer<_CopyStructureCount>(lpVtbl->CopyStructureCount)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDstBuffer, DstAlignedByteOffset, pSrcView);
        }

        public void ClearRenderTargetView([NativeTypeName("ID3D11RenderTargetView *")] ID3D11RenderTargetView* pRenderTargetView, [NativeTypeName("const FLOAT [4]")] float* ColorRGBA)
        {
            Marshal.GetDelegateForFunctionPointer<_ClearRenderTargetView>(lpVtbl->ClearRenderTargetView)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pRenderTargetView, ColorRGBA);
        }

        public void ClearUnorderedAccessViewUint([NativeTypeName("ID3D11UnorderedAccessView *")] ID3D11UnorderedAccessView* pUnorderedAccessView, [NativeTypeName("const UINT [4]")] uint* Values)
        {
            Marshal.GetDelegateForFunctionPointer<_ClearUnorderedAccessViewUint>(lpVtbl->ClearUnorderedAccessViewUint)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pUnorderedAccessView, Values);
        }

        public void ClearUnorderedAccessViewFloat([NativeTypeName("ID3D11UnorderedAccessView *")] ID3D11UnorderedAccessView* pUnorderedAccessView, [NativeTypeName("const FLOAT [4]")] float* Values)
        {
            Marshal.GetDelegateForFunctionPointer<_ClearUnorderedAccessViewFloat>(lpVtbl->ClearUnorderedAccessViewFloat)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pUnorderedAccessView, Values);
        }

        public void ClearDepthStencilView([NativeTypeName("ID3D11DepthStencilView *")] ID3D11DepthStencilView* pDepthStencilView, [NativeTypeName("UINT")] uint ClearFlags, [NativeTypeName("FLOAT")] float Depth, [NativeTypeName("UINT8")] byte Stencil)
        {
            Marshal.GetDelegateForFunctionPointer<_ClearDepthStencilView>(lpVtbl->ClearDepthStencilView)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDepthStencilView, ClearFlags, Depth, Stencil);
        }

        public void GenerateMips([NativeTypeName("ID3D11ShaderResourceView *")] ID3D11ShaderResourceView* pShaderResourceView)
        {
            Marshal.GetDelegateForFunctionPointer<_GenerateMips>(lpVtbl->GenerateMips)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pShaderResourceView);
        }

        public void SetResourceMinLOD([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("FLOAT")] float MinLOD)
        {
            Marshal.GetDelegateForFunctionPointer<_SetResourceMinLOD>(lpVtbl->SetResourceMinLOD)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pResource, MinLOD);
        }

        [return: NativeTypeName("FLOAT")]
        public float GetResourceMinLOD([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetResourceMinLOD>(lpVtbl->GetResourceMinLOD)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pResource);
        }

        public void ResolveSubresource([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, DXGI_FORMAT Format)
        {
            Marshal.GetDelegateForFunctionPointer<_ResolveSubresource>(lpVtbl->ResolveSubresource)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
        }

        public void ExecuteCommandList([NativeTypeName("ID3D11CommandList *")] ID3D11CommandList* pCommandList, [NativeTypeName("BOOL")] int RestoreContextState)
        {
            Marshal.GetDelegateForFunctionPointer<_ExecuteCommandList>(lpVtbl->ExecuteCommandList)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pCommandList, RestoreContextState);
        }

        public void HSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            Marshal.GetDelegateForFunctionPointer<_HSSetShaderResources>(lpVtbl->HSSetShaderResources)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void HSSetShader([NativeTypeName("ID3D11HullShader *")] ID3D11HullShader* pHullShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            Marshal.GetDelegateForFunctionPointer<_HSSetShader>(lpVtbl->HSSetShader)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pHullShader, ppClassInstances, NumClassInstances);
        }

        public void HSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            Marshal.GetDelegateForFunctionPointer<_HSSetSamplers>(lpVtbl->HSSetSamplers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void HSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            Marshal.GetDelegateForFunctionPointer<_HSSetConstantBuffers>(lpVtbl->HSSetConstantBuffers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void DSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            Marshal.GetDelegateForFunctionPointer<_DSSetShaderResources>(lpVtbl->DSSetShaderResources)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void DSSetShader([NativeTypeName("ID3D11DomainShader *")] ID3D11DomainShader* pDomainShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            Marshal.GetDelegateForFunctionPointer<_DSSetShader>(lpVtbl->DSSetShader)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDomainShader, ppClassInstances, NumClassInstances);
        }

        public void DSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            Marshal.GetDelegateForFunctionPointer<_DSSetSamplers>(lpVtbl->DSSetSamplers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void DSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            Marshal.GetDelegateForFunctionPointer<_DSSetConstantBuffers>(lpVtbl->DSSetConstantBuffers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void CSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            Marshal.GetDelegateForFunctionPointer<_CSSetShaderResources>(lpVtbl->CSSetShaderResources)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void CSSetUnorderedAccessViews([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView *const *")] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [NativeTypeName("const UINT *")] uint* pUAVInitialCounts)
        {
            Marshal.GetDelegateForFunctionPointer<_CSSetUnorderedAccessViews>(lpVtbl->CSSetUnorderedAccessViews)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }

        public void CSSetShader([NativeTypeName("ID3D11ComputeShader *")] ID3D11ComputeShader* pComputeShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            Marshal.GetDelegateForFunctionPointer<_CSSetShader>(lpVtbl->CSSetShader)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pComputeShader, ppClassInstances, NumClassInstances);
        }

        public void CSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            Marshal.GetDelegateForFunctionPointer<_CSSetSamplers>(lpVtbl->CSSetSamplers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void CSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            Marshal.GetDelegateForFunctionPointer<_CSSetConstantBuffers>(lpVtbl->CSSetConstantBuffers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void VSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers)
        {
            Marshal.GetDelegateForFunctionPointer<_VSGetConstantBuffers>(lpVtbl->VSGetConstantBuffers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void PSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            Marshal.GetDelegateForFunctionPointer<_PSGetShaderResources>(lpVtbl->PSGetShaderResources)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void PSGetShader([NativeTypeName("ID3D11PixelShader **")] ID3D11PixelShader** ppPixelShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            Marshal.GetDelegateForFunctionPointer<_PSGetShader>(lpVtbl->PSGetShader)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppPixelShader, ppClassInstances, pNumClassInstances);
        }

        public void PSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers)
        {
            Marshal.GetDelegateForFunctionPointer<_PSGetSamplers>(lpVtbl->PSGetSamplers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void VSGetShader([NativeTypeName("ID3D11VertexShader **")] ID3D11VertexShader** ppVertexShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            Marshal.GetDelegateForFunctionPointer<_VSGetShader>(lpVtbl->VSGetShader)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppVertexShader, ppClassInstances, pNumClassInstances);
        }

        public void PSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers)
        {
            Marshal.GetDelegateForFunctionPointer<_PSGetConstantBuffers>(lpVtbl->PSGetConstantBuffers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void IAGetInputLayout([NativeTypeName("ID3D11InputLayout **")] ID3D11InputLayout** ppInputLayout)
        {
            Marshal.GetDelegateForFunctionPointer<_IAGetInputLayout>(lpVtbl->IAGetInputLayout)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppInputLayout);
        }

        public void IAGetVertexBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppVertexBuffers, [NativeTypeName("UINT *")] uint* pStrides, [NativeTypeName("UINT *")] uint* pOffsets)
        {
            Marshal.GetDelegateForFunctionPointer<_IAGetVertexBuffers>(lpVtbl->IAGetVertexBuffers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        public void IAGetIndexBuffer([NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** pIndexBuffer, [NativeTypeName("DXGI_FORMAT *")] DXGI_FORMAT* Format, [NativeTypeName("UINT *")] uint* Offset)
        {
            Marshal.GetDelegateForFunctionPointer<_IAGetIndexBuffer>(lpVtbl->IAGetIndexBuffer)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pIndexBuffer, Format, Offset);
        }

        public void GSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers)
        {
            Marshal.GetDelegateForFunctionPointer<_GSGetConstantBuffers>(lpVtbl->GSGetConstantBuffers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void GSGetShader([NativeTypeName("ID3D11GeometryShader **")] ID3D11GeometryShader** ppGeometryShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            Marshal.GetDelegateForFunctionPointer<_GSGetShader>(lpVtbl->GSGetShader)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppGeometryShader, ppClassInstances, pNumClassInstances);
        }

        public void IAGetPrimitiveTopology([NativeTypeName("D3D11_PRIMITIVE_TOPOLOGY *")] D3D_PRIMITIVE_TOPOLOGY* pTopology)
        {
            Marshal.GetDelegateForFunctionPointer<_IAGetPrimitiveTopology>(lpVtbl->IAGetPrimitiveTopology)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pTopology);
        }

        public void VSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            Marshal.GetDelegateForFunctionPointer<_VSGetShaderResources>(lpVtbl->VSGetShaderResources)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void VSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers)
        {
            Marshal.GetDelegateForFunctionPointer<_VSGetSamplers>(lpVtbl->VSGetSamplers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void GetPredication([NativeTypeName("ID3D11Predicate **")] ID3D11Predicate** ppPredicate, [NativeTypeName("BOOL *")] int* pPredicateValue)
        {
            Marshal.GetDelegateForFunctionPointer<_GetPredication>(lpVtbl->GetPredication)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppPredicate, pPredicateValue);
        }

        public void GSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            Marshal.GetDelegateForFunctionPointer<_GSGetShaderResources>(lpVtbl->GSGetShaderResources)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void GSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers)
        {
            Marshal.GetDelegateForFunctionPointer<_GSGetSamplers>(lpVtbl->GSGetSamplers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void OMGetRenderTargets([NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11RenderTargetView **")] ID3D11RenderTargetView** ppRenderTargetViews, [NativeTypeName("ID3D11DepthStencilView **")] ID3D11DepthStencilView** ppDepthStencilView)
        {
            Marshal.GetDelegateForFunctionPointer<_OMGetRenderTargets>(lpVtbl->OMGetRenderTargets)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), NumViews, ppRenderTargetViews, ppDepthStencilView);
        }

        public void OMGetRenderTargetsAndUnorderedAccessViews([NativeTypeName("UINT")] uint NumRTVs, [NativeTypeName("ID3D11RenderTargetView **")] ID3D11RenderTargetView** ppRenderTargetViews, [NativeTypeName("ID3D11DepthStencilView **")] ID3D11DepthStencilView** ppDepthStencilView, [NativeTypeName("UINT")] uint UAVStartSlot, [NativeTypeName("UINT")] uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView **")] ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            Marshal.GetDelegateForFunctionPointer<_OMGetRenderTargetsAndUnorderedAccessViews>(lpVtbl->OMGetRenderTargetsAndUnorderedAccessViews)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
        }

        public void OMGetBlendState([NativeTypeName("ID3D11BlendState **")] ID3D11BlendState** ppBlendState, [NativeTypeName("FLOAT [4]")] float* BlendFactor, [NativeTypeName("UINT *")] uint* pSampleMask)
        {
            Marshal.GetDelegateForFunctionPointer<_OMGetBlendState>(lpVtbl->OMGetBlendState)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppBlendState, BlendFactor, pSampleMask);
        }

        public void OMGetDepthStencilState([NativeTypeName("ID3D11DepthStencilState **")] ID3D11DepthStencilState** ppDepthStencilState, [NativeTypeName("UINT *")] uint* pStencilRef)
        {
            Marshal.GetDelegateForFunctionPointer<_OMGetDepthStencilState>(lpVtbl->OMGetDepthStencilState)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppDepthStencilState, pStencilRef);
        }

        public void SOGetTargets([NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppSOTargets)
        {
            Marshal.GetDelegateForFunctionPointer<_SOGetTargets>(lpVtbl->SOGetTargets)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), NumBuffers, ppSOTargets);
        }

        public void RSGetState([NativeTypeName("ID3D11RasterizerState **")] ID3D11RasterizerState** ppRasterizerState)
        {
            Marshal.GetDelegateForFunctionPointer<_RSGetState>(lpVtbl->RSGetState)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppRasterizerState);
        }

        public void RSGetViewports([NativeTypeName("UINT *")] uint* pNumViewports, [NativeTypeName("D3D11_VIEWPORT *")] D3D11_VIEWPORT* pViewports)
        {
            Marshal.GetDelegateForFunctionPointer<_RSGetViewports>(lpVtbl->RSGetViewports)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pNumViewports, pViewports);
        }

        public void RSGetScissorRects([NativeTypeName("UINT *")] uint* pNumRects, [NativeTypeName("D3D11_RECT *")] RECT* pRects)
        {
            Marshal.GetDelegateForFunctionPointer<_RSGetScissorRects>(lpVtbl->RSGetScissorRects)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pNumRects, pRects);
        }

        public void HSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            Marshal.GetDelegateForFunctionPointer<_HSGetShaderResources>(lpVtbl->HSGetShaderResources)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void HSGetShader([NativeTypeName("ID3D11HullShader **")] ID3D11HullShader** ppHullShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            Marshal.GetDelegateForFunctionPointer<_HSGetShader>(lpVtbl->HSGetShader)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppHullShader, ppClassInstances, pNumClassInstances);
        }

        public void HSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers)
        {
            Marshal.GetDelegateForFunctionPointer<_HSGetSamplers>(lpVtbl->HSGetSamplers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void HSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers)
        {
            Marshal.GetDelegateForFunctionPointer<_HSGetConstantBuffers>(lpVtbl->HSGetConstantBuffers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void DSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            Marshal.GetDelegateForFunctionPointer<_DSGetShaderResources>(lpVtbl->DSGetShaderResources)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void DSGetShader([NativeTypeName("ID3D11DomainShader **")] ID3D11DomainShader** ppDomainShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            Marshal.GetDelegateForFunctionPointer<_DSGetShader>(lpVtbl->DSGetShader)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppDomainShader, ppClassInstances, pNumClassInstances);
        }

        public void DSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers)
        {
            Marshal.GetDelegateForFunctionPointer<_DSGetSamplers>(lpVtbl->DSGetSamplers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void DSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers)
        {
            Marshal.GetDelegateForFunctionPointer<_DSGetConstantBuffers>(lpVtbl->DSGetConstantBuffers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void CSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            Marshal.GetDelegateForFunctionPointer<_CSGetShaderResources>(lpVtbl->CSGetShaderResources)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void CSGetUnorderedAccessViews([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView **")] ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            Marshal.GetDelegateForFunctionPointer<_CSGetUnorderedAccessViews>(lpVtbl->CSGetUnorderedAccessViews)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumUAVs, ppUnorderedAccessViews);
        }

        public void CSGetShader([NativeTypeName("ID3D11ComputeShader **")] ID3D11ComputeShader** ppComputeShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            Marshal.GetDelegateForFunctionPointer<_CSGetShader>(lpVtbl->CSGetShader)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppComputeShader, ppClassInstances, pNumClassInstances);
        }

        public void CSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers)
        {
            Marshal.GetDelegateForFunctionPointer<_CSGetSamplers>(lpVtbl->CSGetSamplers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void CSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers)
        {
            Marshal.GetDelegateForFunctionPointer<_CSGetConstantBuffers>(lpVtbl->CSGetConstantBuffers)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void ClearState()
        {
            Marshal.GetDelegateForFunctionPointer<_ClearState>(lpVtbl->ClearState)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        public void Flush()
        {
            Marshal.GetDelegateForFunctionPointer<_Flush>(lpVtbl->Flush)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        public new D3D11_DEVICE_CONTEXT_TYPE GetType()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetType>(lpVtbl->GetType)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetContextFlags()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetContextFlags>(lpVtbl->GetContextFlags)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int FinishCommandList([NativeTypeName("BOOL")] int RestoreDeferredContextState, [NativeTypeName("ID3D11CommandList **")] ID3D11CommandList** ppCommandList)
        {
            return Marshal.GetDelegateForFunctionPointer<_FinishCommandList>(lpVtbl->FinishCommandList)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), RestoreDeferredContextState, ppCommandList);
        }

        public void CopySubresourceRegion1([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("UINT")] uint DstZ, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pSrcBox, [NativeTypeName("UINT")] uint CopyFlags)
        {
            Marshal.GetDelegateForFunctionPointer<_CopySubresourceRegion1>(lpVtbl->CopySubresourceRegion1)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
        }

        public void UpdateSubresource1([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch, [NativeTypeName("UINT")] uint CopyFlags)
        {
            Marshal.GetDelegateForFunctionPointer<_UpdateSubresource1>(lpVtbl->UpdateSubresource1)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
        }

        public void DiscardResource([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource)
        {
            Marshal.GetDelegateForFunctionPointer<_DiscardResource>(lpVtbl->DiscardResource)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pResource);
        }

        public void DiscardView([NativeTypeName("ID3D11View *")] ID3D11View* pResourceView)
        {
            Marshal.GetDelegateForFunctionPointer<_DiscardView>(lpVtbl->DiscardView)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pResourceView);
        }

        public void VSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            Marshal.GetDelegateForFunctionPointer<_VSSetConstantBuffers1>(lpVtbl->VSSetConstantBuffers1)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void HSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            Marshal.GetDelegateForFunctionPointer<_HSSetConstantBuffers1>(lpVtbl->HSSetConstantBuffers1)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void DSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            Marshal.GetDelegateForFunctionPointer<_DSSetConstantBuffers1>(lpVtbl->DSSetConstantBuffers1)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void GSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            Marshal.GetDelegateForFunctionPointer<_GSSetConstantBuffers1>(lpVtbl->GSSetConstantBuffers1)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void PSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            Marshal.GetDelegateForFunctionPointer<_PSSetConstantBuffers1>(lpVtbl->PSSetConstantBuffers1)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void CSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            Marshal.GetDelegateForFunctionPointer<_CSSetConstantBuffers1>(lpVtbl->CSSetConstantBuffers1)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void VSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            Marshal.GetDelegateForFunctionPointer<_VSGetConstantBuffers1>(lpVtbl->VSGetConstantBuffers1)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void HSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            Marshal.GetDelegateForFunctionPointer<_HSGetConstantBuffers1>(lpVtbl->HSGetConstantBuffers1)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void DSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            Marshal.GetDelegateForFunctionPointer<_DSGetConstantBuffers1>(lpVtbl->DSGetConstantBuffers1)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void GSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            Marshal.GetDelegateForFunctionPointer<_GSGetConstantBuffers1>(lpVtbl->GSGetConstantBuffers1)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void PSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            Marshal.GetDelegateForFunctionPointer<_PSGetConstantBuffers1>(lpVtbl->PSGetConstantBuffers1)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void CSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            Marshal.GetDelegateForFunctionPointer<_CSGetConstantBuffers1>(lpVtbl->CSGetConstantBuffers1)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void SwapDeviceContextState([NativeTypeName("ID3DDeviceContextState *")] ID3DDeviceContextState* pState, [NativeTypeName("ID3DDeviceContextState **")] ID3DDeviceContextState** ppPreviousState)
        {
            Marshal.GetDelegateForFunctionPointer<_SwapDeviceContextState>(lpVtbl->SwapDeviceContextState)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pState, ppPreviousState);
        }

        public void ClearView([NativeTypeName("ID3D11View *")] ID3D11View* pView, [NativeTypeName("const FLOAT [4]")] float* Color, [NativeTypeName("const D3D11_RECT *")] RECT* pRect, [NativeTypeName("UINT")] uint NumRects)
        {
            Marshal.GetDelegateForFunctionPointer<_ClearView>(lpVtbl->ClearView)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pView, Color, pRect, NumRects);
        }

        public void DiscardView1([NativeTypeName("ID3D11View *")] ID3D11View* pResourceView, [NativeTypeName("const D3D11_RECT *")] RECT* pRects, [NativeTypeName("UINT")] uint NumRects)
        {
            Marshal.GetDelegateForFunctionPointer<_DiscardView1>(lpVtbl->DiscardView1)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pResourceView, pRects, NumRects);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateTileMappings([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pTiledResource, [NativeTypeName("UINT")] uint NumTiledResourceRegions, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pTiledResourceRegionStartCoordinates, [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pTiledResourceRegionSizes, [NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pTilePool, [NativeTypeName("UINT")] uint NumRanges, [NativeTypeName("const UINT *")] uint* pRangeFlags, [NativeTypeName("const UINT *")] uint* pTilePoolStartOffsets, [NativeTypeName("const UINT *")] uint* pRangeTileCounts, [NativeTypeName("UINT")] uint Flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_UpdateTileMappings>(lpVtbl->UpdateTileMappings)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyTileMappings([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDestTiledResource, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pDestRegionStartCoordinate, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSourceTiledResource, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pSourceRegionStartCoordinate, [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pTileRegionSize, [NativeTypeName("UINT")] uint Flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_CopyTileMappings>(lpVtbl->CopyTileMappings)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }

        public void CopyTiles([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pTiledResource, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate, [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pTileRegionSize, [NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, [NativeTypeName("UINT")] uint Flags)
        {
            Marshal.GetDelegateForFunctionPointer<_CopyTiles>(lpVtbl->CopyTiles)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
        }

        public void UpdateTiles([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDestTiledResource, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pDestTileRegionStartCoordinate, [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pDestTileRegionSize, [NativeTypeName("const void *")] void* pSourceTileData, [NativeTypeName("UINT")] uint Flags)
        {
            Marshal.GetDelegateForFunctionPointer<_UpdateTiles>(lpVtbl->UpdateTiles)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDestTiledResource, pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileData, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeTilePool([NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pTilePool, [NativeTypeName("UINT64")] ulong NewSizeInBytes)
        {
            return Marshal.GetDelegateForFunctionPointer<_ResizeTilePool>(lpVtbl->ResizeTilePool)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pTilePool, NewSizeInBytes);
        }

        public void TiledResourceBarrier([NativeTypeName("ID3D11DeviceChild *")] ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrier, [NativeTypeName("ID3D11DeviceChild *")] ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrier)
        {
            Marshal.GetDelegateForFunctionPointer<_TiledResourceBarrier>(lpVtbl->TiledResourceBarrier)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pTiledResourceOrViewAccessBeforeBarrier, pTiledResourceOrViewAccessAfterBarrier);
        }

        [return: NativeTypeName("BOOL")]
        public int IsAnnotationEnabled()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsAnnotationEnabled>(lpVtbl->IsAnnotationEnabled)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        public void SetMarkerInt([NativeTypeName("LPCWSTR")] ushort* pLabel, [NativeTypeName("INT")] int Data)
        {
            Marshal.GetDelegateForFunctionPointer<_SetMarkerInt>(lpVtbl->SetMarkerInt)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pLabel, Data);
        }

        public void BeginEventInt([NativeTypeName("LPCWSTR")] ushort* pLabel, [NativeTypeName("INT")] int Data)
        {
            Marshal.GetDelegateForFunctionPointer<_BeginEventInt>(lpVtbl->BeginEventInt)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pLabel, Data);
        }

        public void EndEvent()
        {
            Marshal.GetDelegateForFunctionPointer<_EndEvent>(lpVtbl->EndEvent)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        public void Flush1(D3D11_CONTEXT_TYPE ContextType, [NativeTypeName("HANDLE")] IntPtr hEvent)
        {
            Marshal.GetDelegateForFunctionPointer<_Flush1>(lpVtbl->Flush1)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ContextType, hEvent);
        }

        public void SetHardwareProtectionState([NativeTypeName("BOOL")] int HwProtectionEnable)
        {
            Marshal.GetDelegateForFunctionPointer<_SetHardwareProtectionState>(lpVtbl->SetHardwareProtectionState)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), HwProtectionEnable);
        }

        public void GetHardwareProtectionState([NativeTypeName("BOOL *")] int* pHwProtectionEnable)
        {
            Marshal.GetDelegateForFunctionPointer<_GetHardwareProtectionState>(lpVtbl->GetHardwareProtectionState)((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pHwProtectionEnable);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
            public IntPtr GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public IntPtr VSSetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public IntPtr PSSetShaderResources;

            [NativeTypeName("void (ID3D11PixelShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public IntPtr PSSetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public IntPtr PSSetSamplers;

            [NativeTypeName("void (ID3D11VertexShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public IntPtr VSSetShader;

            [NativeTypeName("void (UINT, UINT, INT) __attribute__((stdcall))")]
            public IntPtr DrawIndexed;

            [NativeTypeName("void (UINT, UINT) __attribute__((stdcall))")]
            public IntPtr Draw;

            [NativeTypeName("HRESULT (ID3D11Resource *, UINT, D3D11_MAP, UINT, D3D11_MAPPED_SUBRESOURCE *) __attribute__((stdcall))")]
            public IntPtr Map;

            [NativeTypeName("void (ID3D11Resource *, UINT) __attribute__((stdcall))")]
            public IntPtr Unmap;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public IntPtr PSSetConstantBuffers;

            [NativeTypeName("void (ID3D11InputLayout *) __attribute__((stdcall))")]
            public IntPtr IASetInputLayout;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))")]
            public IntPtr IASetVertexBuffers;

            [NativeTypeName("void (ID3D11Buffer *, DXGI_FORMAT, UINT) __attribute__((stdcall))")]
            public IntPtr IASetIndexBuffer;

            [NativeTypeName("void (UINT, UINT, UINT, INT, UINT) __attribute__((stdcall))")]
            public IntPtr DrawIndexedInstanced;

            [NativeTypeName("void (UINT, UINT, UINT, UINT) __attribute__((stdcall))")]
            public IntPtr DrawInstanced;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public IntPtr GSSetConstantBuffers;

            [NativeTypeName("void (ID3D11GeometryShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public IntPtr GSSetShader;

            [NativeTypeName("void (D3D11_PRIMITIVE_TOPOLOGY) __attribute__((stdcall))")]
            public IntPtr IASetPrimitiveTopology;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public IntPtr VSSetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public IntPtr VSSetSamplers;

            [NativeTypeName("void (ID3D11Asynchronous *) __attribute__((stdcall))")]
            public IntPtr Begin;

            [NativeTypeName("void (ID3D11Asynchronous *) __attribute__((stdcall))")]
            public IntPtr End;

            [NativeTypeName("HRESULT (ID3D11Asynchronous *, void *, UINT, UINT) __attribute__((stdcall))")]
            public IntPtr GetData;

            [NativeTypeName("void (ID3D11Predicate *, BOOL) __attribute__((stdcall))")]
            public IntPtr SetPredication;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public IntPtr GSSetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public IntPtr GSSetSamplers;

            [NativeTypeName("void (UINT, ID3D11RenderTargetView *const *, ID3D11DepthStencilView *) __attribute__((stdcall))")]
            public IntPtr OMSetRenderTargets;

            [NativeTypeName("void (UINT, ID3D11RenderTargetView *const *, ID3D11DepthStencilView *, UINT, UINT, ID3D11UnorderedAccessView *const *, const UINT *) __attribute__((stdcall))")]
            public IntPtr OMSetRenderTargetsAndUnorderedAccessViews;

            [NativeTypeName("void (ID3D11BlendState *, const FLOAT *, UINT) __attribute__((stdcall))")]
            public IntPtr OMSetBlendState;

            [NativeTypeName("void (ID3D11DepthStencilState *, UINT) __attribute__((stdcall))")]
            public IntPtr OMSetDepthStencilState;

            [NativeTypeName("void (UINT, ID3D11Buffer *const *, const UINT *) __attribute__((stdcall))")]
            public IntPtr SOSetTargets;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr DrawAuto;

            [NativeTypeName("void (ID3D11Buffer *, UINT) __attribute__((stdcall))")]
            public IntPtr DrawIndexedInstancedIndirect;

            [NativeTypeName("void (ID3D11Buffer *, UINT) __attribute__((stdcall))")]
            public IntPtr DrawInstancedIndirect;

            [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
            public IntPtr Dispatch;

            [NativeTypeName("void (ID3D11Buffer *, UINT) __attribute__((stdcall))")]
            public IntPtr DispatchIndirect;

            [NativeTypeName("void (ID3D11RasterizerState *) __attribute__((stdcall))")]
            public IntPtr RSSetState;

            [NativeTypeName("void (UINT, const D3D11_VIEWPORT *) __attribute__((stdcall))")]
            public IntPtr RSSetViewports;

            [NativeTypeName("void (UINT, const D3D11_RECT *) __attribute__((stdcall))")]
            public IntPtr RSSetScissorRects;

            [NativeTypeName("void (ID3D11Resource *, UINT, UINT, UINT, UINT, ID3D11Resource *, UINT, const D3D11_BOX *) __attribute__((stdcall))")]
            public IntPtr CopySubresourceRegion;

            [NativeTypeName("void (ID3D11Resource *, ID3D11Resource *) __attribute__((stdcall))")]
            public IntPtr CopyResource;

            [NativeTypeName("void (ID3D11Resource *, UINT, const D3D11_BOX *, const void *, UINT, UINT) __attribute__((stdcall))")]
            public IntPtr UpdateSubresource;

            [NativeTypeName("void (ID3D11Buffer *, UINT, ID3D11UnorderedAccessView *) __attribute__((stdcall))")]
            public IntPtr CopyStructureCount;

            [NativeTypeName("void (ID3D11RenderTargetView *, const FLOAT *) __attribute__((stdcall))")]
            public IntPtr ClearRenderTargetView;

            [NativeTypeName("void (ID3D11UnorderedAccessView *, const UINT *) __attribute__((stdcall))")]
            public IntPtr ClearUnorderedAccessViewUint;

            [NativeTypeName("void (ID3D11UnorderedAccessView *, const FLOAT *) __attribute__((stdcall))")]
            public IntPtr ClearUnorderedAccessViewFloat;

            [NativeTypeName("void (ID3D11DepthStencilView *, UINT, FLOAT, UINT8) __attribute__((stdcall))")]
            public IntPtr ClearDepthStencilView;

            [NativeTypeName("void (ID3D11ShaderResourceView *) __attribute__((stdcall))")]
            public IntPtr GenerateMips;

            [NativeTypeName("void (ID3D11Resource *, FLOAT) __attribute__((stdcall))")]
            public IntPtr SetResourceMinLOD;

            [NativeTypeName("FLOAT (ID3D11Resource *) __attribute__((stdcall))")]
            public IntPtr GetResourceMinLOD;

            [NativeTypeName("void (ID3D11Resource *, UINT, ID3D11Resource *, UINT, DXGI_FORMAT) __attribute__((stdcall))")]
            public IntPtr ResolveSubresource;

            [NativeTypeName("void (ID3D11CommandList *, BOOL) __attribute__((stdcall))")]
            public IntPtr ExecuteCommandList;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public IntPtr HSSetShaderResources;

            [NativeTypeName("void (ID3D11HullShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public IntPtr HSSetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public IntPtr HSSetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public IntPtr HSSetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public IntPtr DSSetShaderResources;

            [NativeTypeName("void (ID3D11DomainShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public IntPtr DSSetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public IntPtr DSSetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public IntPtr DSSetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public IntPtr CSSetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11UnorderedAccessView *const *, const UINT *) __attribute__((stdcall))")]
            public IntPtr CSSetUnorderedAccessViews;

            [NativeTypeName("void (ID3D11ComputeShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public IntPtr CSSetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public IntPtr CSSetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public IntPtr CSSetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public IntPtr VSGetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public IntPtr PSGetShaderResources;

            [NativeTypeName("void (ID3D11PixelShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public IntPtr PSGetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public IntPtr PSGetSamplers;

            [NativeTypeName("void (ID3D11VertexShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public IntPtr VSGetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public IntPtr PSGetConstantBuffers;

            [NativeTypeName("void (ID3D11InputLayout **) __attribute__((stdcall))")]
            public IntPtr IAGetInputLayout;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr IAGetVertexBuffers;

            [NativeTypeName("void (ID3D11Buffer **, DXGI_FORMAT *, UINT *) __attribute__((stdcall))")]
            public IntPtr IAGetIndexBuffer;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public IntPtr GSGetConstantBuffers;

            [NativeTypeName("void (ID3D11GeometryShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public IntPtr GSGetShader;

            [NativeTypeName("void (D3D11_PRIMITIVE_TOPOLOGY *) __attribute__((stdcall))")]
            public IntPtr IAGetPrimitiveTopology;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public IntPtr VSGetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public IntPtr VSGetSamplers;

            [NativeTypeName("void (ID3D11Predicate **, BOOL *) __attribute__((stdcall))")]
            public IntPtr GetPredication;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public IntPtr GSGetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public IntPtr GSGetSamplers;

            [NativeTypeName("void (UINT, ID3D11RenderTargetView **, ID3D11DepthStencilView **) __attribute__((stdcall))")]
            public IntPtr OMGetRenderTargets;

            [NativeTypeName("void (UINT, ID3D11RenderTargetView **, ID3D11DepthStencilView **, UINT, UINT, ID3D11UnorderedAccessView **) __attribute__((stdcall))")]
            public IntPtr OMGetRenderTargetsAndUnorderedAccessViews;

            [NativeTypeName("void (ID3D11BlendState **, FLOAT *, UINT *) __attribute__((stdcall))")]
            public IntPtr OMGetBlendState;

            [NativeTypeName("void (ID3D11DepthStencilState **, UINT *) __attribute__((stdcall))")]
            public IntPtr OMGetDepthStencilState;

            [NativeTypeName("void (UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public IntPtr SOGetTargets;

            [NativeTypeName("void (ID3D11RasterizerState **) __attribute__((stdcall))")]
            public IntPtr RSGetState;

            [NativeTypeName("void (UINT *, D3D11_VIEWPORT *) __attribute__((stdcall))")]
            public IntPtr RSGetViewports;

            [NativeTypeName("void (UINT *, D3D11_RECT *) __attribute__((stdcall))")]
            public IntPtr RSGetScissorRects;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public IntPtr HSGetShaderResources;

            [NativeTypeName("void (ID3D11HullShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public IntPtr HSGetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public IntPtr HSGetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public IntPtr HSGetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public IntPtr DSGetShaderResources;

            [NativeTypeName("void (ID3D11DomainShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public IntPtr DSGetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public IntPtr DSGetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public IntPtr DSGetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public IntPtr CSGetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11UnorderedAccessView **) __attribute__((stdcall))")]
            public IntPtr CSGetUnorderedAccessViews;

            [NativeTypeName("void (ID3D11ComputeShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public IntPtr CSGetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public IntPtr CSGetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public IntPtr CSGetConstantBuffers;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr ClearState;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr Flush;

            [NativeTypeName("D3D11_DEVICE_CONTEXT_TYPE () __attribute__((stdcall))")]
            public new IntPtr GetType;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public IntPtr GetContextFlags;

            [NativeTypeName("HRESULT (BOOL, ID3D11CommandList **) __attribute__((stdcall))")]
            public IntPtr FinishCommandList;

            [NativeTypeName("void (ID3D11Resource *, UINT, UINT, UINT, UINT, ID3D11Resource *, UINT, const D3D11_BOX *, UINT) __attribute__((stdcall))")]
            public IntPtr CopySubresourceRegion1;

            [NativeTypeName("void (ID3D11Resource *, UINT, const D3D11_BOX *, const void *, UINT, UINT, UINT) __attribute__((stdcall))")]
            public IntPtr UpdateSubresource1;

            [NativeTypeName("void (ID3D11Resource *) __attribute__((stdcall))")]
            public IntPtr DiscardResource;

            [NativeTypeName("void (ID3D11View *) __attribute__((stdcall))")]
            public IntPtr DiscardView;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))")]
            public IntPtr VSSetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))")]
            public IntPtr HSSetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))")]
            public IntPtr DSSetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))")]
            public IntPtr GSSetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))")]
            public IntPtr PSSetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))")]
            public IntPtr CSSetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr VSGetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr HSGetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr DSGetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr GSGetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr PSGetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr CSGetConstantBuffers1;

            [NativeTypeName("void (ID3DDeviceContextState *, ID3DDeviceContextState **) __attribute__((stdcall))")]
            public IntPtr SwapDeviceContextState;

            [NativeTypeName("void (ID3D11View *, const FLOAT *, const D3D11_RECT *, UINT) __attribute__((stdcall))")]
            public IntPtr ClearView;

            [NativeTypeName("void (ID3D11View *, const D3D11_RECT *, UINT) __attribute__((stdcall))")]
            public IntPtr DiscardView1;

            [NativeTypeName("HRESULT (ID3D11Resource *, UINT, const D3D11_TILED_RESOURCE_COORDINATE *, const D3D11_TILE_REGION_SIZE *, ID3D11Buffer *, UINT, const UINT *, const UINT *, const UINT *, UINT) __attribute__((stdcall))")]
            public IntPtr UpdateTileMappings;

            [NativeTypeName("HRESULT (ID3D11Resource *, const D3D11_TILED_RESOURCE_COORDINATE *, ID3D11Resource *, const D3D11_TILED_RESOURCE_COORDINATE *, const D3D11_TILE_REGION_SIZE *, UINT) __attribute__((stdcall))")]
            public IntPtr CopyTileMappings;

            [NativeTypeName("void (ID3D11Resource *, const D3D11_TILED_RESOURCE_COORDINATE *, const D3D11_TILE_REGION_SIZE *, ID3D11Buffer *, UINT64, UINT) __attribute__((stdcall))")]
            public IntPtr CopyTiles;

            [NativeTypeName("void (ID3D11Resource *, const D3D11_TILED_RESOURCE_COORDINATE *, const D3D11_TILE_REGION_SIZE *, const void *, UINT) __attribute__((stdcall))")]
            public IntPtr UpdateTiles;

            [NativeTypeName("HRESULT (ID3D11Buffer *, UINT64) __attribute__((stdcall))")]
            public IntPtr ResizeTilePool;

            [NativeTypeName("void (ID3D11DeviceChild *, ID3D11DeviceChild *) __attribute__((stdcall))")]
            public IntPtr TiledResourceBarrier;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public IntPtr IsAnnotationEnabled;

            [NativeTypeName("void (LPCWSTR, INT) __attribute__((stdcall))")]
            public IntPtr SetMarkerInt;

            [NativeTypeName("void (LPCWSTR, INT) __attribute__((stdcall))")]
            public IntPtr BeginEventInt;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr EndEvent;

            [NativeTypeName("void (D3D11_CONTEXT_TYPE, HANDLE) __attribute__((stdcall))")]
            public IntPtr Flush1;

            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public IntPtr SetHardwareProtectionState;

            [NativeTypeName("void (BOOL *) __attribute__((stdcall))")]
            public IntPtr GetHardwareProtectionState;
        }
    }
}
