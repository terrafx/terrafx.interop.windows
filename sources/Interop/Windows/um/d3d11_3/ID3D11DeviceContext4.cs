// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("917600DA-F58C-4C33-98D8-3E15B390FA24")]
    public unsafe partial struct ID3D11DeviceContext4
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            lpVtbl->GetDevice((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return lpVtbl->SetPrivateDataInterface((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), guid, pData);
        }

        public void VSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            lpVtbl->VSSetConstantBuffers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void PSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            lpVtbl->PSSetShaderResources((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void PSSetShader([NativeTypeName("ID3D11PixelShader *")] ID3D11PixelShader* pPixelShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            lpVtbl->PSSetShader((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pPixelShader, ppClassInstances, NumClassInstances);
        }

        public void PSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            lpVtbl->PSSetSamplers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void VSSetShader([NativeTypeName("ID3D11VertexShader *")] ID3D11VertexShader* pVertexShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            lpVtbl->VSSetShader((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pVertexShader, ppClassInstances, NumClassInstances);
        }

        public void DrawIndexed([NativeTypeName("UINT")] uint IndexCount, [NativeTypeName("UINT")] uint StartIndexLocation, [NativeTypeName("INT")] int BaseVertexLocation)
        {
            lpVtbl->DrawIndexed((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), IndexCount, StartIndexLocation, BaseVertexLocation);
        }

        public void Draw([NativeTypeName("UINT")] uint VertexCount, [NativeTypeName("UINT")] uint StartVertexLocation)
        {
            lpVtbl->Draw((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), VertexCount, StartVertexLocation);
        }

        [return: NativeTypeName("HRESULT")]
        public int Map([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("UINT")] uint Subresource, D3D11_MAP MapType, [NativeTypeName("UINT")] uint MapFlags, [NativeTypeName("D3D11_MAPPED_SUBRESOURCE *")] D3D11_MAPPED_SUBRESOURCE* pMappedResource)
        {
            return lpVtbl->Map((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pResource, Subresource, MapType, MapFlags, pMappedResource);
        }

        public void Unmap([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("UINT")] uint Subresource)
        {
            lpVtbl->Unmap((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pResource, Subresource);
        }

        public void PSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            lpVtbl->PSSetConstantBuffers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void IASetInputLayout([NativeTypeName("ID3D11InputLayout *")] ID3D11InputLayout* pInputLayout)
        {
            lpVtbl->IASetInputLayout((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pInputLayout);
        }

        public void IASetVertexBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppVertexBuffers, [NativeTypeName("const UINT *")] uint* pStrides, [NativeTypeName("const UINT *")] uint* pOffsets)
        {
            lpVtbl->IASetVertexBuffers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        public void IASetIndexBuffer([NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pIndexBuffer, DXGI_FORMAT Format, [NativeTypeName("UINT")] uint Offset)
        {
            lpVtbl->IASetIndexBuffer((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pIndexBuffer, Format, Offset);
        }

        public void DrawIndexedInstanced([NativeTypeName("UINT")] uint IndexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartIndexLocation, [NativeTypeName("INT")] int BaseVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation)
        {
            lpVtbl->DrawIndexedInstanced((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
        }

        public void DrawInstanced([NativeTypeName("UINT")] uint VertexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation)
        {
            lpVtbl->DrawInstanced((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
        }

        public void GSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            lpVtbl->GSSetConstantBuffers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void GSSetShader([NativeTypeName("ID3D11GeometryShader *")] ID3D11GeometryShader* pShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            lpVtbl->GSSetShader((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pShader, ppClassInstances, NumClassInstances);
        }

        public void IASetPrimitiveTopology([NativeTypeName("D3D11_PRIMITIVE_TOPOLOGY")] D3D_PRIMITIVE_TOPOLOGY Topology)
        {
            lpVtbl->IASetPrimitiveTopology((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), Topology);
        }

        public void VSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            lpVtbl->VSSetShaderResources((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void VSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            lpVtbl->VSSetSamplers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void Begin([NativeTypeName("ID3D11Asynchronous *")] ID3D11Asynchronous* pAsync)
        {
            lpVtbl->Begin((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pAsync);
        }

        public void End([NativeTypeName("ID3D11Asynchronous *")] ID3D11Asynchronous* pAsync)
        {
            lpVtbl->End((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pAsync);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("ID3D11Asynchronous *")] ID3D11Asynchronous* pAsync, [NativeTypeName("void *")] void* pData, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("UINT")] uint GetDataFlags)
        {
            return lpVtbl->GetData((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pAsync, pData, DataSize, GetDataFlags);
        }

        public void SetPredication([NativeTypeName("ID3D11Predicate *")] ID3D11Predicate* pPredicate, [NativeTypeName("BOOL")] int PredicateValue)
        {
            lpVtbl->SetPredication((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pPredicate, PredicateValue);
        }

        public void GSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            lpVtbl->GSSetShaderResources((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void GSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            lpVtbl->GSSetSamplers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void OMSetRenderTargets([NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11RenderTargetView *const *")] ID3D11RenderTargetView** ppRenderTargetViews, [NativeTypeName("ID3D11DepthStencilView *")] ID3D11DepthStencilView* pDepthStencilView)
        {
            lpVtbl->OMSetRenderTargets((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), NumViews, ppRenderTargetViews, pDepthStencilView);
        }

        public void OMSetRenderTargetsAndUnorderedAccessViews([NativeTypeName("UINT")] uint NumRTVs, [NativeTypeName("ID3D11RenderTargetView *const *")] ID3D11RenderTargetView** ppRenderTargetViews, [NativeTypeName("ID3D11DepthStencilView *")] ID3D11DepthStencilView* pDepthStencilView, [NativeTypeName("UINT")] uint UAVStartSlot, [NativeTypeName("UINT")] uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView *const *")] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [NativeTypeName("const UINT *")] uint* pUAVInitialCounts)
        {
            lpVtbl->OMSetRenderTargetsAndUnorderedAccessViews((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }

        public void OMSetBlendState([NativeTypeName("ID3D11BlendState *")] ID3D11BlendState* pBlendState, [NativeTypeName("const FLOAT [4]")] float* BlendFactor, [NativeTypeName("UINT")] uint SampleMask)
        {
            lpVtbl->OMSetBlendState((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pBlendState, BlendFactor, SampleMask);
        }

        public void OMSetDepthStencilState([NativeTypeName("ID3D11DepthStencilState *")] ID3D11DepthStencilState* pDepthStencilState, [NativeTypeName("UINT")] uint StencilRef)
        {
            lpVtbl->OMSetDepthStencilState((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pDepthStencilState, StencilRef);
        }

        public void SOSetTargets([NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppSOTargets, [NativeTypeName("const UINT *")] uint* pOffsets)
        {
            lpVtbl->SOSetTargets((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), NumBuffers, ppSOTargets, pOffsets);
        }

        public void DrawAuto()
        {
            lpVtbl->DrawAuto((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this));
        }

        public void DrawIndexedInstancedIndirect([NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pBufferForArgs, [NativeTypeName("UINT")] uint AlignedByteOffsetForArgs)
        {
            lpVtbl->DrawIndexedInstancedIndirect((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pBufferForArgs, AlignedByteOffsetForArgs);
        }

        public void DrawInstancedIndirect([NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pBufferForArgs, [NativeTypeName("UINT")] uint AlignedByteOffsetForArgs)
        {
            lpVtbl->DrawInstancedIndirect((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pBufferForArgs, AlignedByteOffsetForArgs);
        }

        public void Dispatch([NativeTypeName("UINT")] uint ThreadGroupCountX, [NativeTypeName("UINT")] uint ThreadGroupCountY, [NativeTypeName("UINT")] uint ThreadGroupCountZ)
        {
            lpVtbl->Dispatch((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
        }

        public void DispatchIndirect([NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pBufferForArgs, [NativeTypeName("UINT")] uint AlignedByteOffsetForArgs)
        {
            lpVtbl->DispatchIndirect((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pBufferForArgs, AlignedByteOffsetForArgs);
        }

        public void RSSetState([NativeTypeName("ID3D11RasterizerState *")] ID3D11RasterizerState* pRasterizerState)
        {
            lpVtbl->RSSetState((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pRasterizerState);
        }

        public void RSSetViewports([NativeTypeName("UINT")] uint NumViewports, [NativeTypeName("const D3D11_VIEWPORT *")] D3D11_VIEWPORT* pViewports)
        {
            lpVtbl->RSSetViewports((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
        }

        public void RSSetScissorRects([NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D11_RECT *")] RECT* pRects)
        {
            lpVtbl->RSSetScissorRects((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), NumRects, pRects);
        }

        public void CopySubresourceRegion([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("UINT")] uint DstZ, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pSrcBox)
        {
            lpVtbl->CopySubresourceRegion((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
        }

        public void CopyResource([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSrcResource)
        {
            lpVtbl->CopyResource((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pDstResource, pSrcResource);
        }

        public void UpdateSubresource([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch)
        {
            lpVtbl->UpdateSubresource((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        public void CopyStructureCount([NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pDstBuffer, [NativeTypeName("UINT")] uint DstAlignedByteOffset, [NativeTypeName("ID3D11UnorderedAccessView *")] ID3D11UnorderedAccessView* pSrcView)
        {
            lpVtbl->CopyStructureCount((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pDstBuffer, DstAlignedByteOffset, pSrcView);
        }

        public void ClearRenderTargetView([NativeTypeName("ID3D11RenderTargetView *")] ID3D11RenderTargetView* pRenderTargetView, [NativeTypeName("const FLOAT [4]")] float* ColorRGBA)
        {
            lpVtbl->ClearRenderTargetView((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pRenderTargetView, ColorRGBA);
        }

        public void ClearUnorderedAccessViewUint([NativeTypeName("ID3D11UnorderedAccessView *")] ID3D11UnorderedAccessView* pUnorderedAccessView, [NativeTypeName("const UINT [4]")] uint* Values)
        {
            lpVtbl->ClearUnorderedAccessViewUint((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pUnorderedAccessView, Values);
        }

        public void ClearUnorderedAccessViewFloat([NativeTypeName("ID3D11UnorderedAccessView *")] ID3D11UnorderedAccessView* pUnorderedAccessView, [NativeTypeName("const FLOAT [4]")] float* Values)
        {
            lpVtbl->ClearUnorderedAccessViewFloat((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pUnorderedAccessView, Values);
        }

        public void ClearDepthStencilView([NativeTypeName("ID3D11DepthStencilView *")] ID3D11DepthStencilView* pDepthStencilView, [NativeTypeName("UINT")] uint ClearFlags, [NativeTypeName("FLOAT")] float Depth, [NativeTypeName("UINT8")] byte Stencil)
        {
            lpVtbl->ClearDepthStencilView((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pDepthStencilView, ClearFlags, Depth, Stencil);
        }

        public void GenerateMips([NativeTypeName("ID3D11ShaderResourceView *")] ID3D11ShaderResourceView* pShaderResourceView)
        {
            lpVtbl->GenerateMips((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pShaderResourceView);
        }

        public void SetResourceMinLOD([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("FLOAT")] float MinLOD)
        {
            lpVtbl->SetResourceMinLOD((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pResource, MinLOD);
        }

        [return: NativeTypeName("FLOAT")]
        public float GetResourceMinLOD([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource)
        {
            return lpVtbl->GetResourceMinLOD((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pResource);
        }

        public void ResolveSubresource([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, DXGI_FORMAT Format)
        {
            lpVtbl->ResolveSubresource((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
        }

        public void ExecuteCommandList([NativeTypeName("ID3D11CommandList *")] ID3D11CommandList* pCommandList, [NativeTypeName("BOOL")] int RestoreContextState)
        {
            lpVtbl->ExecuteCommandList((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pCommandList, RestoreContextState);
        }

        public void HSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            lpVtbl->HSSetShaderResources((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void HSSetShader([NativeTypeName("ID3D11HullShader *")] ID3D11HullShader* pHullShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            lpVtbl->HSSetShader((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pHullShader, ppClassInstances, NumClassInstances);
        }

        public void HSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            lpVtbl->HSSetSamplers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void HSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            lpVtbl->HSSetConstantBuffers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void DSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            lpVtbl->DSSetShaderResources((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void DSSetShader([NativeTypeName("ID3D11DomainShader *")] ID3D11DomainShader* pDomainShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            lpVtbl->DSSetShader((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pDomainShader, ppClassInstances, NumClassInstances);
        }

        public void DSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            lpVtbl->DSSetSamplers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void DSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            lpVtbl->DSSetConstantBuffers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void CSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            lpVtbl->CSSetShaderResources((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void CSSetUnorderedAccessViews([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView *const *")] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [NativeTypeName("const UINT *")] uint* pUAVInitialCounts)
        {
            lpVtbl->CSSetUnorderedAccessViews((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }

        public void CSSetShader([NativeTypeName("ID3D11ComputeShader *")] ID3D11ComputeShader* pComputeShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            lpVtbl->CSSetShader((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pComputeShader, ppClassInstances, NumClassInstances);
        }

        public void CSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            lpVtbl->CSSetSamplers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void CSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            lpVtbl->CSSetConstantBuffers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void VSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers)
        {
            lpVtbl->VSGetConstantBuffers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void PSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            lpVtbl->PSGetShaderResources((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void PSGetShader([NativeTypeName("ID3D11PixelShader **")] ID3D11PixelShader** ppPixelShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            lpVtbl->PSGetShader((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), ppPixelShader, ppClassInstances, pNumClassInstances);
        }

        public void PSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers)
        {
            lpVtbl->PSGetSamplers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void VSGetShader([NativeTypeName("ID3D11VertexShader **")] ID3D11VertexShader** ppVertexShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            lpVtbl->VSGetShader((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), ppVertexShader, ppClassInstances, pNumClassInstances);
        }

        public void PSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers)
        {
            lpVtbl->PSGetConstantBuffers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void IAGetInputLayout([NativeTypeName("ID3D11InputLayout **")] ID3D11InputLayout** ppInputLayout)
        {
            lpVtbl->IAGetInputLayout((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), ppInputLayout);
        }

        public void IAGetVertexBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppVertexBuffers, [NativeTypeName("UINT *")] uint* pStrides, [NativeTypeName("UINT *")] uint* pOffsets)
        {
            lpVtbl->IAGetVertexBuffers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        public void IAGetIndexBuffer([NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** pIndexBuffer, [NativeTypeName("DXGI_FORMAT *")] DXGI_FORMAT* Format, [NativeTypeName("UINT *")] uint* Offset)
        {
            lpVtbl->IAGetIndexBuffer((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pIndexBuffer, Format, Offset);
        }

        public void GSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers)
        {
            lpVtbl->GSGetConstantBuffers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void GSGetShader([NativeTypeName("ID3D11GeometryShader **")] ID3D11GeometryShader** ppGeometryShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            lpVtbl->GSGetShader((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), ppGeometryShader, ppClassInstances, pNumClassInstances);
        }

        public void IAGetPrimitiveTopology([NativeTypeName("D3D11_PRIMITIVE_TOPOLOGY *")] D3D_PRIMITIVE_TOPOLOGY* pTopology)
        {
            lpVtbl->IAGetPrimitiveTopology((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pTopology);
        }

        public void VSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            lpVtbl->VSGetShaderResources((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void VSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers)
        {
            lpVtbl->VSGetSamplers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void GetPredication([NativeTypeName("ID3D11Predicate **")] ID3D11Predicate** ppPredicate, [NativeTypeName("BOOL *")] int* pPredicateValue)
        {
            lpVtbl->GetPredication((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), ppPredicate, pPredicateValue);
        }

        public void GSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            lpVtbl->GSGetShaderResources((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void GSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers)
        {
            lpVtbl->GSGetSamplers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void OMGetRenderTargets([NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11RenderTargetView **")] ID3D11RenderTargetView** ppRenderTargetViews, [NativeTypeName("ID3D11DepthStencilView **")] ID3D11DepthStencilView** ppDepthStencilView)
        {
            lpVtbl->OMGetRenderTargets((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), NumViews, ppRenderTargetViews, ppDepthStencilView);
        }

        public void OMGetRenderTargetsAndUnorderedAccessViews([NativeTypeName("UINT")] uint NumRTVs, [NativeTypeName("ID3D11RenderTargetView **")] ID3D11RenderTargetView** ppRenderTargetViews, [NativeTypeName("ID3D11DepthStencilView **")] ID3D11DepthStencilView** ppDepthStencilView, [NativeTypeName("UINT")] uint UAVStartSlot, [NativeTypeName("UINT")] uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView **")] ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            lpVtbl->OMGetRenderTargetsAndUnorderedAccessViews((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
        }

        public void OMGetBlendState([NativeTypeName("ID3D11BlendState **")] ID3D11BlendState** ppBlendState, [NativeTypeName("FLOAT [4]")] float* BlendFactor, [NativeTypeName("UINT *")] uint* pSampleMask)
        {
            lpVtbl->OMGetBlendState((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), ppBlendState, BlendFactor, pSampleMask);
        }

        public void OMGetDepthStencilState([NativeTypeName("ID3D11DepthStencilState **")] ID3D11DepthStencilState** ppDepthStencilState, [NativeTypeName("UINT *")] uint* pStencilRef)
        {
            lpVtbl->OMGetDepthStencilState((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), ppDepthStencilState, pStencilRef);
        }

        public void SOGetTargets([NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppSOTargets)
        {
            lpVtbl->SOGetTargets((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), NumBuffers, ppSOTargets);
        }

        public void RSGetState([NativeTypeName("ID3D11RasterizerState **")] ID3D11RasterizerState** ppRasterizerState)
        {
            lpVtbl->RSGetState((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), ppRasterizerState);
        }

        public void RSGetViewports([NativeTypeName("UINT *")] uint* pNumViewports, [NativeTypeName("D3D11_VIEWPORT *")] D3D11_VIEWPORT* pViewports)
        {
            lpVtbl->RSGetViewports((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pNumViewports, pViewports);
        }

        public void RSGetScissorRects([NativeTypeName("UINT *")] uint* pNumRects, [NativeTypeName("D3D11_RECT *")] RECT* pRects)
        {
            lpVtbl->RSGetScissorRects((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pNumRects, pRects);
        }

        public void HSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            lpVtbl->HSGetShaderResources((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void HSGetShader([NativeTypeName("ID3D11HullShader **")] ID3D11HullShader** ppHullShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            lpVtbl->HSGetShader((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), ppHullShader, ppClassInstances, pNumClassInstances);
        }

        public void HSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers)
        {
            lpVtbl->HSGetSamplers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void HSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers)
        {
            lpVtbl->HSGetConstantBuffers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void DSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            lpVtbl->DSGetShaderResources((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void DSGetShader([NativeTypeName("ID3D11DomainShader **")] ID3D11DomainShader** ppDomainShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            lpVtbl->DSGetShader((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), ppDomainShader, ppClassInstances, pNumClassInstances);
        }

        public void DSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers)
        {
            lpVtbl->DSGetSamplers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void DSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers)
        {
            lpVtbl->DSGetConstantBuffers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void CSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            lpVtbl->CSGetShaderResources((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        public void CSGetUnorderedAccessViews([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView **")] ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            lpVtbl->CSGetUnorderedAccessViews((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumUAVs, ppUnorderedAccessViews);
        }

        public void CSGetShader([NativeTypeName("ID3D11ComputeShader **")] ID3D11ComputeShader** ppComputeShader, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            lpVtbl->CSGetShader((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), ppComputeShader, ppClassInstances, pNumClassInstances);
        }

        public void CSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplers)
        {
            lpVtbl->CSGetSamplers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        public void CSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers)
        {
            lpVtbl->CSGetConstantBuffers((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        public void ClearState()
        {
            lpVtbl->ClearState((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this));
        }

        public void Flush()
        {
            lpVtbl->Flush((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this));
        }

        public new D3D11_DEVICE_CONTEXT_TYPE GetType()
        {
            return lpVtbl->GetType((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetContextFlags()
        {
            return lpVtbl->GetContextFlags((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int FinishCommandList([NativeTypeName("BOOL")] int RestoreDeferredContextState, [NativeTypeName("ID3D11CommandList **")] ID3D11CommandList** ppCommandList)
        {
            return lpVtbl->FinishCommandList((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), RestoreDeferredContextState, ppCommandList);
        }

        public void CopySubresourceRegion1([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("UINT")] uint DstZ, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pSrcBox, [NativeTypeName("UINT")] uint CopyFlags)
        {
            lpVtbl->CopySubresourceRegion1((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
        }

        public void UpdateSubresource1([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch, [NativeTypeName("UINT")] uint CopyFlags)
        {
            lpVtbl->UpdateSubresource1((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
        }

        public void DiscardResource([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource)
        {
            lpVtbl->DiscardResource((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pResource);
        }

        public void DiscardView([NativeTypeName("ID3D11View *")] ID3D11View* pResourceView)
        {
            lpVtbl->DiscardView((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pResourceView);
        }

        public void VSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            lpVtbl->VSSetConstantBuffers1((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void HSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            lpVtbl->HSSetConstantBuffers1((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void DSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            lpVtbl->DSSetConstantBuffers1((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void GSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            lpVtbl->GSSetConstantBuffers1((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void PSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            lpVtbl->PSSetConstantBuffers1((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void CSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            lpVtbl->CSSetConstantBuffers1((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void VSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            lpVtbl->VSGetConstantBuffers1((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void HSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            lpVtbl->HSGetConstantBuffers1((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void DSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            lpVtbl->DSGetConstantBuffers1((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void GSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            lpVtbl->GSGetConstantBuffers1((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void PSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            lpVtbl->PSGetConstantBuffers1((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void CSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            lpVtbl->CSGetConstantBuffers1((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        public void SwapDeviceContextState([NativeTypeName("ID3DDeviceContextState *")] ID3DDeviceContextState* pState, [NativeTypeName("ID3DDeviceContextState **")] ID3DDeviceContextState** ppPreviousState)
        {
            lpVtbl->SwapDeviceContextState((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pState, ppPreviousState);
        }

        public void ClearView([NativeTypeName("ID3D11View *")] ID3D11View* pView, [NativeTypeName("const FLOAT [4]")] float* Color, [NativeTypeName("const D3D11_RECT *")] RECT* pRect, [NativeTypeName("UINT")] uint NumRects)
        {
            lpVtbl->ClearView((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pView, Color, pRect, NumRects);
        }

        public void DiscardView1([NativeTypeName("ID3D11View *")] ID3D11View* pResourceView, [NativeTypeName("const D3D11_RECT *")] RECT* pRects, [NativeTypeName("UINT")] uint NumRects)
        {
            lpVtbl->DiscardView1((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pResourceView, pRects, NumRects);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateTileMappings([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pTiledResource, [NativeTypeName("UINT")] uint NumTiledResourceRegions, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pTiledResourceRegionStartCoordinates, [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pTiledResourceRegionSizes, [NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pTilePool, [NativeTypeName("UINT")] uint NumRanges, [NativeTypeName("const UINT *")] uint* pRangeFlags, [NativeTypeName("const UINT *")] uint* pTilePoolStartOffsets, [NativeTypeName("const UINT *")] uint* pRangeTileCounts, [NativeTypeName("UINT")] uint Flags)
        {
            return lpVtbl->UpdateTileMappings((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyTileMappings([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDestTiledResource, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pDestRegionStartCoordinate, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSourceTiledResource, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pSourceRegionStartCoordinate, [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pTileRegionSize, [NativeTypeName("UINT")] uint Flags)
        {
            return lpVtbl->CopyTileMappings((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }

        public void CopyTiles([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pTiledResource, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate, [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pTileRegionSize, [NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, [NativeTypeName("UINT")] uint Flags)
        {
            lpVtbl->CopyTiles((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
        }

        public void UpdateTiles([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDestTiledResource, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pDestTileRegionStartCoordinate, [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pDestTileRegionSize, [NativeTypeName("const void *")] void* pSourceTileData, [NativeTypeName("UINT")] uint Flags)
        {
            lpVtbl->UpdateTiles((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pDestTiledResource, pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileData, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeTilePool([NativeTypeName("ID3D11Buffer *")] ID3D11Buffer* pTilePool, [NativeTypeName("UINT64")] ulong NewSizeInBytes)
        {
            return lpVtbl->ResizeTilePool((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pTilePool, NewSizeInBytes);
        }

        public void TiledResourceBarrier([NativeTypeName("ID3D11DeviceChild *")] ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrier, [NativeTypeName("ID3D11DeviceChild *")] ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrier)
        {
            lpVtbl->TiledResourceBarrier((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pTiledResourceOrViewAccessBeforeBarrier, pTiledResourceOrViewAccessAfterBarrier);
        }

        [return: NativeTypeName("BOOL")]
        public int IsAnnotationEnabled()
        {
            return lpVtbl->IsAnnotationEnabled((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this));
        }

        public void SetMarkerInt([NativeTypeName("LPCWSTR")] ushort* pLabel, [NativeTypeName("INT")] int Data)
        {
            lpVtbl->SetMarkerInt((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pLabel, Data);
        }

        public void BeginEventInt([NativeTypeName("LPCWSTR")] ushort* pLabel, [NativeTypeName("INT")] int Data)
        {
            lpVtbl->BeginEventInt((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pLabel, Data);
        }

        public void EndEvent()
        {
            lpVtbl->EndEvent((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this));
        }

        public void Flush1(D3D11_CONTEXT_TYPE ContextType, [NativeTypeName("HANDLE")] IntPtr hEvent)
        {
            lpVtbl->Flush1((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), ContextType, hEvent);
        }

        public void SetHardwareProtectionState([NativeTypeName("BOOL")] int HwProtectionEnable)
        {
            lpVtbl->SetHardwareProtectionState((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), HwProtectionEnable);
        }

        public void GetHardwareProtectionState([NativeTypeName("BOOL *")] int* pHwProtectionEnable)
        {
            lpVtbl->GetHardwareProtectionState((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pHwProtectionEnable);
        }

        [return: NativeTypeName("HRESULT")]
        public int Signal([NativeTypeName("ID3D11Fence *")] ID3D11Fence* pFence, [NativeTypeName("UINT64")] ulong Value)
        {
            return lpVtbl->Signal((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pFence, Value);
        }

        [return: NativeTypeName("HRESULT")]
        public int Wait([NativeTypeName("ID3D11Fence *")] ID3D11Fence* pFence, [NativeTypeName("UINT64")] ulong Value)
        {
            return lpVtbl->Wait((ID3D11DeviceContext4*)Unsafe.AsPointer(ref this), pFence, Value);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint> Release;

            [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Device**, void> GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void> VSSetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void> PSSetShaderResources;

            [NativeTypeName("void (ID3D11PixelShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void> PSSetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void> PSSetSamplers;

            [NativeTypeName("void (ID3D11VertexShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void> VSSetShader;

            [NativeTypeName("void (UINT, UINT, INT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, int, void> DrawIndexed;

            [NativeTypeName("void (UINT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, void> Draw;

            [NativeTypeName("HRESULT (ID3D11Resource *, UINT, D3D11_MAP, UINT, D3D11_MAPPED_SUBRESOURCE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Resource*, uint, D3D11_MAP, uint, D3D11_MAPPED_SUBRESOURCE*, int> Map;

            [NativeTypeName("void (ID3D11Resource *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Resource*, uint, void> Unmap;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void> PSSetConstantBuffers;

            [NativeTypeName("void (ID3D11InputLayout *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11InputLayout*, void> IASetInputLayout;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void> IASetVertexBuffers;

            [NativeTypeName("void (ID3D11Buffer *, DXGI_FORMAT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Buffer*, DXGI_FORMAT, uint, void> IASetIndexBuffer;

            [NativeTypeName("void (UINT, UINT, UINT, INT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, uint, int, uint, void> DrawIndexedInstanced;

            [NativeTypeName("void (UINT, UINT, UINT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, uint, uint, void> DrawInstanced;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void> GSSetConstantBuffers;

            [NativeTypeName("void (ID3D11GeometryShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void> GSSetShader;

            [NativeTypeName("void (D3D11_PRIMITIVE_TOPOLOGY) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, D3D_PRIMITIVE_TOPOLOGY, void> IASetPrimitiveTopology;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void> VSSetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void> VSSetSamplers;

            [NativeTypeName("void (ID3D11Asynchronous *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Asynchronous*, void> Begin;

            [NativeTypeName("void (ID3D11Asynchronous *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Asynchronous*, void> End;

            [NativeTypeName("HRESULT (ID3D11Asynchronous *, void *, UINT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Asynchronous*, void*, uint, uint, int> GetData;

            [NativeTypeName("void (ID3D11Predicate *, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Predicate*, int, void> SetPredication;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void> GSSetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void> GSSetSamplers;

            [NativeTypeName("void (UINT, ID3D11RenderTargetView *const *, ID3D11DepthStencilView *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void> OMSetRenderTargets;

            [NativeTypeName("void (UINT, ID3D11RenderTargetView *const *, ID3D11DepthStencilView *, UINT, UINT, ID3D11UnorderedAccessView *const *, const UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void> OMSetRenderTargetsAndUnorderedAccessViews;

            [NativeTypeName("void (ID3D11BlendState *, const FLOAT *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11BlendState*, float*, uint, void> OMSetBlendState;

            [NativeTypeName("void (ID3D11DepthStencilState *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11DepthStencilState*, uint, void> OMSetDepthStencilState;

            [NativeTypeName("void (UINT, ID3D11Buffer *const *, const UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, ID3D11Buffer**, uint*, void> SOSetTargets;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, void> DrawAuto;

            [NativeTypeName("void (ID3D11Buffer *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Buffer*, uint, void> DrawIndexedInstancedIndirect;

            [NativeTypeName("void (ID3D11Buffer *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Buffer*, uint, void> DrawInstancedIndirect;

            [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, uint, void> Dispatch;

            [NativeTypeName("void (ID3D11Buffer *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Buffer*, uint, void> DispatchIndirect;

            [NativeTypeName("void (ID3D11RasterizerState *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11RasterizerState*, void> RSSetState;

            [NativeTypeName("void (UINT, const D3D11_VIEWPORT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, D3D11_VIEWPORT*, void> RSSetViewports;

            [NativeTypeName("void (UINT, const D3D11_RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, RECT*, void> RSSetScissorRects;

            [NativeTypeName("void (ID3D11Resource *, UINT, UINT, UINT, UINT, ID3D11Resource *, UINT, const D3D11_BOX *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, D3D11_BOX*, void> CopySubresourceRegion;

            [NativeTypeName("void (ID3D11Resource *, ID3D11Resource *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Resource*, ID3D11Resource*, void> CopyResource;

            [NativeTypeName("void (ID3D11Resource *, UINT, const D3D11_BOX *, const void *, UINT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Resource*, uint, D3D11_BOX*, void*, uint, uint, void> UpdateSubresource;

            [NativeTypeName("void (ID3D11Buffer *, UINT, ID3D11UnorderedAccessView *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void> CopyStructureCount;

            [NativeTypeName("void (ID3D11RenderTargetView *, const FLOAT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11RenderTargetView*, float*, void> ClearRenderTargetView;

            [NativeTypeName("void (ID3D11UnorderedAccessView *, const UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, uint*, void> ClearUnorderedAccessViewUint;

            [NativeTypeName("void (ID3D11UnorderedAccessView *, const FLOAT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, float*, void> ClearUnorderedAccessViewFloat;

            [NativeTypeName("void (ID3D11DepthStencilView *, UINT, FLOAT, UINT8) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11DepthStencilView*, uint, float, byte, void> ClearDepthStencilView;

            [NativeTypeName("void (ID3D11ShaderResourceView *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11ShaderResourceView*, void> GenerateMips;

            [NativeTypeName("void (ID3D11Resource *, FLOAT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Resource*, float, void> SetResourceMinLOD;

            [NativeTypeName("FLOAT (ID3D11Resource *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Resource*, float> GetResourceMinLOD;

            [NativeTypeName("void (ID3D11Resource *, UINT, ID3D11Resource *, UINT, DXGI_FORMAT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Resource*, uint, ID3D11Resource*, uint, DXGI_FORMAT, void> ResolveSubresource;

            [NativeTypeName("void (ID3D11CommandList *, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11CommandList*, int, void> ExecuteCommandList;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void> HSSetShaderResources;

            [NativeTypeName("void (ID3D11HullShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void> HSSetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void> HSSetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void> HSSetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void> DSSetShaderResources;

            [NativeTypeName("void (ID3D11DomainShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void> DSSetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void> DSSetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void> DSSetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void> CSSetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11UnorderedAccessView *const *, const UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11UnorderedAccessView**, uint*, void> CSSetUnorderedAccessViews;

            [NativeTypeName("void (ID3D11ComputeShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void> CSSetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void> CSSetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void> CSSetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void> VSGetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void> PSGetShaderResources;

            [NativeTypeName("void (ID3D11PixelShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void> PSGetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void> PSGetSamplers;

            [NativeTypeName("void (ID3D11VertexShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void> VSGetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void> PSGetConstantBuffers;

            [NativeTypeName("void (ID3D11InputLayout **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11InputLayout**, void> IAGetInputLayout;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void> IAGetVertexBuffers;

            [NativeTypeName("void (ID3D11Buffer **, DXGI_FORMAT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Buffer**, DXGI_FORMAT*, uint*, void> IAGetIndexBuffer;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void> GSGetConstantBuffers;

            [NativeTypeName("void (ID3D11GeometryShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void> GSGetShader;

            [NativeTypeName("void (D3D11_PRIMITIVE_TOPOLOGY *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, D3D_PRIMITIVE_TOPOLOGY*, void> IAGetPrimitiveTopology;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void> VSGetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void> VSGetSamplers;

            [NativeTypeName("void (ID3D11Predicate **, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Predicate**, int*, void> GetPredication;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void> GSGetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void> GSGetSamplers;

            [NativeTypeName("void (UINT, ID3D11RenderTargetView **, ID3D11DepthStencilView **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void> OMGetRenderTargets;

            [NativeTypeName("void (UINT, ID3D11RenderTargetView **, ID3D11DepthStencilView **, UINT, UINT, ID3D11UnorderedAccessView **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void> OMGetRenderTargetsAndUnorderedAccessViews;

            [NativeTypeName("void (ID3D11BlendState **, FLOAT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11BlendState**, float*, uint*, void> OMGetBlendState;

            [NativeTypeName("void (ID3D11DepthStencilState **, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11DepthStencilState**, uint*, void> OMGetDepthStencilState;

            [NativeTypeName("void (UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, ID3D11Buffer**, void> SOGetTargets;

            [NativeTypeName("void (ID3D11RasterizerState **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11RasterizerState**, void> RSGetState;

            [NativeTypeName("void (UINT *, D3D11_VIEWPORT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint*, D3D11_VIEWPORT*, void> RSGetViewports;

            [NativeTypeName("void (UINT *, D3D11_RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint*, RECT*, void> RSGetScissorRects;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void> HSGetShaderResources;

            [NativeTypeName("void (ID3D11HullShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void> HSGetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void> HSGetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void> HSGetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void> DSGetShaderResources;

            [NativeTypeName("void (ID3D11DomainShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void> DSGetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void> DSGetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void> DSGetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void> CSGetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11UnorderedAccessView **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11UnorderedAccessView**, void> CSGetUnorderedAccessViews;

            [NativeTypeName("void (ID3D11ComputeShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void> CSGetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void> CSGetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void> CSGetConstantBuffers;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, void> ClearState;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, void> Flush;

            [NativeTypeName("D3D11_DEVICE_CONTEXT_TYPE () __attribute__((stdcall))")]
            public new delegate* stdcall<ID3D11DeviceContext4*, D3D11_DEVICE_CONTEXT_TYPE> GetType;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint> GetContextFlags;

            [NativeTypeName("HRESULT (BOOL, ID3D11CommandList **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, int, ID3D11CommandList**, int> FinishCommandList;

            [NativeTypeName("void (ID3D11Resource *, UINT, UINT, UINT, UINT, ID3D11Resource *, UINT, const D3D11_BOX *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, D3D11_BOX*, uint, void> CopySubresourceRegion1;

            [NativeTypeName("void (ID3D11Resource *, UINT, const D3D11_BOX *, const void *, UINT, UINT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Resource*, uint, D3D11_BOX*, void*, uint, uint, uint, void> UpdateSubresource1;

            [NativeTypeName("void (ID3D11Resource *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Resource*, void> DiscardResource;

            [NativeTypeName("void (ID3D11View *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11View*, void> DiscardView;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void> VSSetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void> HSSetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void> DSSetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void> GSSetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void> PSSetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void> CSSetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void> VSGetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void> HSGetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void> DSGetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void> GSGetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void> PSGetConstantBuffers1;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void> CSGetConstantBuffers1;

            [NativeTypeName("void (ID3DDeviceContextState *, ID3DDeviceContextState **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3DDeviceContextState*, ID3DDeviceContextState**, void> SwapDeviceContextState;

            [NativeTypeName("void (ID3D11View *, const FLOAT *, const D3D11_RECT *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11View*, float*, RECT*, uint, void> ClearView;

            [NativeTypeName("void (ID3D11View *, const D3D11_RECT *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11View*, RECT*, uint, void> DiscardView1;

            [NativeTypeName("HRESULT (ID3D11Resource *, UINT, const D3D11_TILED_RESOURCE_COORDINATE *, const D3D11_TILE_REGION_SIZE *, ID3D11Buffer *, UINT, const UINT *, const UINT *, const UINT *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Resource*, uint, D3D11_TILED_RESOURCE_COORDINATE*, D3D11_TILE_REGION_SIZE*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int> UpdateTileMappings;

            [NativeTypeName("HRESULT (ID3D11Resource *, const D3D11_TILED_RESOURCE_COORDINATE *, ID3D11Resource *, const D3D11_TILED_RESOURCE_COORDINATE *, const D3D11_TILE_REGION_SIZE *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Resource*, D3D11_TILED_RESOURCE_COORDINATE*, ID3D11Resource*, D3D11_TILED_RESOURCE_COORDINATE*, D3D11_TILE_REGION_SIZE*, uint, int> CopyTileMappings;

            [NativeTypeName("void (ID3D11Resource *, const D3D11_TILED_RESOURCE_COORDINATE *, const D3D11_TILE_REGION_SIZE *, ID3D11Buffer *, UINT64, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Resource*, D3D11_TILED_RESOURCE_COORDINATE*, D3D11_TILE_REGION_SIZE*, ID3D11Buffer*, ulong, uint, void> CopyTiles;

            [NativeTypeName("void (ID3D11Resource *, const D3D11_TILED_RESOURCE_COORDINATE *, const D3D11_TILE_REGION_SIZE *, const void *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Resource*, D3D11_TILED_RESOURCE_COORDINATE*, D3D11_TILE_REGION_SIZE*, void*, uint, void> UpdateTiles;

            [NativeTypeName("HRESULT (ID3D11Buffer *, UINT64) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Buffer*, ulong, int> ResizeTilePool;

            [NativeTypeName("void (ID3D11DeviceChild *, ID3D11DeviceChild *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11DeviceChild*, ID3D11DeviceChild*, void> TiledResourceBarrier;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, int> IsAnnotationEnabled;

            [NativeTypeName("void (LPCWSTR, INT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ushort*, int, void> SetMarkerInt;

            [NativeTypeName("void (LPCWSTR, INT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ushort*, int, void> BeginEventInt;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, void> EndEvent;

            [NativeTypeName("void (D3D11_CONTEXT_TYPE, HANDLE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, D3D11_CONTEXT_TYPE, IntPtr, void> Flush1;

            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, int, void> SetHardwareProtectionState;

            [NativeTypeName("void (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, int*, void> GetHardwareProtectionState;

            [NativeTypeName("HRESULT (ID3D11Fence *, UINT64) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Fence*, ulong, int> Signal;

            [NativeTypeName("HRESULT (ID3D11Fence *, UINT64) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11DeviceContext4*, ID3D11Fence*, ulong, int> Wait;
        }
    }
}
