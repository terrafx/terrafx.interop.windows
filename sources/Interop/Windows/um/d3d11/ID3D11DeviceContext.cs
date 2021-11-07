// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C0BFA96C-E089-44FB-8EAF-26F8796190DA")]
    [NativeTypeName("struct ID3D11DeviceContext : ID3D11DeviceChild")]
    [NativeInheritance("ID3D11DeviceChild")]
    public unsafe partial struct ID3D11DeviceContext : ID3D11DeviceContext.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, uint>)(lpVtbl[1]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, uint>)(lpVtbl[2]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void VSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[7]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void PSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[8]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void PSSetShader(ID3D11PixelShader* pPixelShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[9]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pPixelShader, ppClassInstances, NumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public void PSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[10]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void VSSetShader(ID3D11VertexShader* pVertexShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[11]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pVertexShader, ppClassInstances, NumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void DrawIndexed(uint IndexCount, uint StartIndexLocation, int BaseVertexLocation)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, int, void>)(lpVtbl[12]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), IndexCount, StartIndexLocation, BaseVertexLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void Draw(uint VertexCount, uint StartVertexLocation)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, void>)(lpVtbl[13]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), VertexCount, StartVertexLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT Map(ID3D11Resource* pResource, uint Subresource, D3D11_MAP MapType, uint MapFlags, D3D11_MAPPED_SUBRESOURCE* pMappedResource)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, uint, D3D11_MAP, uint, D3D11_MAPPED_SUBRESOURCE*, int>)(lpVtbl[14]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pResource, Subresource, MapType, MapFlags, pMappedResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public void Unmap(ID3D11Resource* pResource, uint Subresource)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, uint, void>)(lpVtbl[15]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pResource, Subresource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public void PSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[16]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void IASetInputLayout(ID3D11InputLayout* pInputLayout)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11InputLayout*, void>)(lpVtbl[17]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pInputLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void IASetVertexBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppVertexBuffers, [NativeTypeName("const UINT *")] uint* pStrides, [NativeTypeName("const UINT *")] uint* pOffsets)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[18]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void IASetIndexBuffer(ID3D11Buffer* pIndexBuffer, DXGI_FORMAT Format, uint Offset)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer*, DXGI_FORMAT, uint, void>)(lpVtbl[19]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pIndexBuffer, Format, Offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, uint, int, uint, void>)(lpVtbl[20]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, uint, uint, void>)(lpVtbl[21]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void GSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[22]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void GSSetShader(ID3D11GeometryShader* pShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[23]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pShader, ppClassInstances, NumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public void IASetPrimitiveTopology([NativeTypeName("D3D11_PRIMITIVE_TOPOLOGY")] D3D_PRIMITIVE_TOPOLOGY Topology)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, D3D_PRIMITIVE_TOPOLOGY, void>)(lpVtbl[24]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), Topology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public void VSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[25]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public void VSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[26]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public void Begin(ID3D11Asynchronous* pAsync)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Asynchronous*, void>)(lpVtbl[27]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pAsync);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public void End(ID3D11Asynchronous* pAsync)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Asynchronous*, void>)(lpVtbl[28]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pAsync);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT GetData(ID3D11Asynchronous* pAsync, void* pData, uint DataSize, uint GetDataFlags)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Asynchronous*, void*, uint, uint, int>)(lpVtbl[29]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pAsync, pData, DataSize, GetDataFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public void SetPredication(ID3D11Predicate* pPredicate, BOOL PredicateValue)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Predicate*, BOOL, void>)(lpVtbl[30]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pPredicate, PredicateValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public void GSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[31]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public void GSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[32]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public void OMSetRenderTargets(uint NumViews, [NativeTypeName("ID3D11RenderTargetView *const *")] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)(lpVtbl[33]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), NumViews, ppRenderTargetViews, pDepthStencilView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [NativeTypeName("ID3D11RenderTargetView *const *")] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView *const *")] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [NativeTypeName("const UINT *")] uint* pUAVInitialCounts)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)(lpVtbl[34]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public void OMSetBlendState(ID3D11BlendState* pBlendState, [NativeTypeName("const FLOAT [4]")] float* BlendFactor, uint SampleMask)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11BlendState*, float*, uint, void>)(lpVtbl[35]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pBlendState, BlendFactor, SampleMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public void OMSetDepthStencilState(ID3D11DepthStencilState* pDepthStencilState, uint StencilRef)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11DepthStencilState*, uint, void>)(lpVtbl[36]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pDepthStencilState, StencilRef);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public void SOSetTargets(uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppSOTargets, [NativeTypeName("const UINT *")] uint* pOffsets)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11Buffer**, uint*, void>)(lpVtbl[37]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), NumBuffers, ppSOTargets, pOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public void DrawAuto()
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, void>)(lpVtbl[38]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public void DrawIndexedInstancedIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer*, uint, void>)(lpVtbl[39]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pBufferForArgs, AlignedByteOffsetForArgs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public void DrawInstancedIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer*, uint, void>)(lpVtbl[40]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pBufferForArgs, AlignedByteOffsetForArgs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, uint, void>)(lpVtbl[41]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public void DispatchIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer*, uint, void>)(lpVtbl[42]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pBufferForArgs, AlignedByteOffsetForArgs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public void RSSetState(ID3D11RasterizerState* pRasterizerState)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11RasterizerState*, void>)(lpVtbl[43]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pRasterizerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public void RSSetViewports(uint NumViewports, [NativeTypeName("const D3D11_VIEWPORT *")] D3D11_VIEWPORT* pViewports)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, D3D11_VIEWPORT*, void>)(lpVtbl[44]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public void RSSetScissorRects(uint NumRects, [NativeTypeName("const D3D11_RECT *")] RECT* pRects)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, RECT*, void>)(lpVtbl[45]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), NumRects, pRects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public void CopySubresourceRegion(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pSrcBox)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, D3D11_BOX*, void>)(lpVtbl[46]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public void CopyResource(ID3D11Resource* pDstResource, ID3D11Resource* pSrcResource)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, ID3D11Resource*, void>)(lpVtbl[47]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pDstResource, pSrcResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public void UpdateSubresource(ID3D11Resource* pDstResource, uint DstSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, uint, D3D11_BOX*, void*, uint, uint, void>)(lpVtbl[48]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public void CopyStructureCount(ID3D11Buffer* pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)(lpVtbl[49]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pDstBuffer, DstAlignedByteOffset, pSrcView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public void ClearRenderTargetView(ID3D11RenderTargetView* pRenderTargetView, [NativeTypeName("const FLOAT [4]")] float* ColorRGBA)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11RenderTargetView*, float*, void>)(lpVtbl[50]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pRenderTargetView, ColorRGBA);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public void ClearUnorderedAccessViewUint(ID3D11UnorderedAccessView* pUnorderedAccessView, [NativeTypeName("const UINT [4]")] uint* Values)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11UnorderedAccessView*, uint*, void>)(lpVtbl[51]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pUnorderedAccessView, Values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public void ClearUnorderedAccessViewFloat(ID3D11UnorderedAccessView* pUnorderedAccessView, [NativeTypeName("const FLOAT [4]")] float* Values)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11UnorderedAccessView*, float*, void>)(lpVtbl[52]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pUnorderedAccessView, Values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public void ClearDepthStencilView(ID3D11DepthStencilView* pDepthStencilView, uint ClearFlags, float Depth, [NativeTypeName("UINT8")] byte Stencil)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11DepthStencilView*, uint, float, byte, void>)(lpVtbl[53]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pDepthStencilView, ClearFlags, Depth, Stencil);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public void GenerateMips(ID3D11ShaderResourceView* pShaderResourceView)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11ShaderResourceView*, void>)(lpVtbl[54]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pShaderResourceView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public void SetResourceMinLOD(ID3D11Resource* pResource, float MinLOD)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, float, void>)(lpVtbl[55]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pResource, MinLOD);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public float GetResourceMinLOD(ID3D11Resource* pResource)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, float>)(lpVtbl[56]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public void ResolveSubresource(ID3D11Resource* pDstResource, uint DstSubresource, ID3D11Resource* pSrcResource, uint SrcSubresource, DXGI_FORMAT Format)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, uint, ID3D11Resource*, uint, DXGI_FORMAT, void>)(lpVtbl[57]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public void ExecuteCommandList(ID3D11CommandList* pCommandList, BOOL RestoreContextState)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11CommandList*, BOOL, void>)(lpVtbl[58]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pCommandList, RestoreContextState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public void HSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[59]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public void HSSetShader(ID3D11HullShader* pHullShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[60]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pHullShader, ppClassInstances, NumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public void HSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[61]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public void HSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[62]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public void DSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[63]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public void DSSetShader(ID3D11DomainShader* pDomainShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[64]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pDomainShader, ppClassInstances, NumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public void DSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[65]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public void DSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[66]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public void CSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[67]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView *const *")] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [NativeTypeName("const UINT *")] uint* pUAVInitialCounts)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)(lpVtbl[68]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public void CSSetShader(ID3D11ComputeShader* pComputeShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[69]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pComputeShader, ppClassInstances, NumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public void CSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[70]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public void CSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[71]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        public void VSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[72]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public void PSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[73]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public void PSGetShader(ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[74]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppPixelShader, ppClassInstances, pNumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public void PSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[75]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        public void VSGetShader(ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[76]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppVertexShader, ppClassInstances, pNumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        public void PSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[77]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        public void IAGetInputLayout(ID3D11InputLayout** ppInputLayout)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11InputLayout**, void>)(lpVtbl[78]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppInputLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        public void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, uint* pOffsets)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[79]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public void IAGetIndexBuffer(ID3D11Buffer** pIndexBuffer, DXGI_FORMAT* Format, uint* Offset)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer**, DXGI_FORMAT*, uint*, void>)(lpVtbl[80]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pIndexBuffer, Format, Offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        public void GSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[81]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        public void GSGetShader(ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[82]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppGeometryShader, ppClassInstances, pNumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        public void IAGetPrimitiveTopology([NativeTypeName("D3D11_PRIMITIVE_TOPOLOGY *")] D3D_PRIMITIVE_TOPOLOGY* pTopology)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, D3D_PRIMITIVE_TOPOLOGY*, void>)(lpVtbl[83]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pTopology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        public void VSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[84]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        public void VSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[85]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        public void GetPredication(ID3D11Predicate** ppPredicate, BOOL* pPredicateValue)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Predicate**, BOOL*, void>)(lpVtbl[86]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppPredicate, pPredicateValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        public void GSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[87]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        public void GSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[88]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        public void OMGetRenderTargets(uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)(lpVtbl[89]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), NumViews, ppRenderTargetViews, ppDepthStencilView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        public void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)(lpVtbl[90]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        public void OMGetBlendState(ID3D11BlendState** ppBlendState, [NativeTypeName("FLOAT [4]")] float* BlendFactor, uint* pSampleMask)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11BlendState**, float*, uint*, void>)(lpVtbl[91]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppBlendState, BlendFactor, pSampleMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        public void OMGetDepthStencilState(ID3D11DepthStencilState** ppDepthStencilState, uint* pStencilRef)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11DepthStencilState**, uint*, void>)(lpVtbl[92]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppDepthStencilState, pStencilRef);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        public void SOGetTargets(uint NumBuffers, ID3D11Buffer** ppSOTargets)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11Buffer**, void>)(lpVtbl[93]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), NumBuffers, ppSOTargets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        public void RSGetState(ID3D11RasterizerState** ppRasterizerState)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11RasterizerState**, void>)(lpVtbl[94]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppRasterizerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        public void RSGetViewports(uint* pNumViewports, D3D11_VIEWPORT* pViewports)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint*, D3D11_VIEWPORT*, void>)(lpVtbl[95]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pNumViewports, pViewports);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        public void RSGetScissorRects(uint* pNumRects, [NativeTypeName("D3D11_RECT *")] RECT* pRects)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint*, RECT*, void>)(lpVtbl[96]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pNumRects, pRects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        public void HSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[97]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        public void HSGetShader(ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[98]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppHullShader, ppClassInstances, pNumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        public void HSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[99]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        public void HSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[100]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        public void DSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[101]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        public void DSGetShader(ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[102]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppDomainShader, ppClassInstances, pNumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        public void DSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[103]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        public void DSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[104]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        public void CSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[105]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        public void CSGetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11UnorderedAccessView**, void>)(lpVtbl[106]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumUAVs, ppUnorderedAccessViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        public void CSGetShader(ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[107]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppComputeShader, ppClassInstances, pNumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        public void CSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[108]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        public void CSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[109]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        public void ClearState()
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, void>)(lpVtbl[110]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(111)]
        public void Flush()
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, void>)(lpVtbl[111]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(112)]
        public new D3D11_DEVICE_CONTEXT_TYPE GetType()
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, D3D11_DEVICE_CONTEXT_TYPE>)(lpVtbl[112]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(113)]
        public uint GetContextFlags()
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, uint>)(lpVtbl[113]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(114)]
        public HRESULT FinishCommandList(BOOL RestoreDeferredContextState, ID3D11CommandList** ppCommandList)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, BOOL, ID3D11CommandList**, int>)(lpVtbl[114]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), RestoreDeferredContextState, ppCommandList);
        }

        public interface Interface : ID3D11DeviceChild.Interface
        {
            [VtblIndex(7)]
            void VSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers);

            [VtblIndex(8)]
            void PSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews);

            [VtblIndex(9)]
            void PSSetShader(ID3D11PixelShader* pPixelShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances);

            [VtblIndex(10)]
            void PSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers);

            [VtblIndex(11)]
            void VSSetShader(ID3D11VertexShader* pVertexShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances);

            [VtblIndex(12)]
            void DrawIndexed(uint IndexCount, uint StartIndexLocation, int BaseVertexLocation);

            [VtblIndex(13)]
            void Draw(uint VertexCount, uint StartVertexLocation);

            [VtblIndex(14)]
            HRESULT Map(ID3D11Resource* pResource, uint Subresource, D3D11_MAP MapType, uint MapFlags, D3D11_MAPPED_SUBRESOURCE* pMappedResource);

            [VtblIndex(15)]
            void Unmap(ID3D11Resource* pResource, uint Subresource);

            [VtblIndex(16)]
            void PSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers);

            [VtblIndex(17)]
            void IASetInputLayout(ID3D11InputLayout* pInputLayout);

            [VtblIndex(18)]
            void IASetVertexBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppVertexBuffers, [NativeTypeName("const UINT *")] uint* pStrides, [NativeTypeName("const UINT *")] uint* pOffsets);

            [VtblIndex(19)]
            void IASetIndexBuffer(ID3D11Buffer* pIndexBuffer, DXGI_FORMAT Format, uint Offset);

            [VtblIndex(20)]
            void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation);

            [VtblIndex(21)]
            void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation);

            [VtblIndex(22)]
            void GSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers);

            [VtblIndex(23)]
            void GSSetShader(ID3D11GeometryShader* pShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances);

            [VtblIndex(24)]
            void IASetPrimitiveTopology([NativeTypeName("D3D11_PRIMITIVE_TOPOLOGY")] D3D_PRIMITIVE_TOPOLOGY Topology);

            [VtblIndex(25)]
            void VSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews);

            [VtblIndex(26)]
            void VSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers);

            [VtblIndex(27)]
            void Begin(ID3D11Asynchronous* pAsync);

            [VtblIndex(28)]
            void End(ID3D11Asynchronous* pAsync);

            [VtblIndex(29)]
            HRESULT GetData(ID3D11Asynchronous* pAsync, void* pData, uint DataSize, uint GetDataFlags);

            [VtblIndex(30)]
            void SetPredication(ID3D11Predicate* pPredicate, BOOL PredicateValue);

            [VtblIndex(31)]
            void GSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews);

            [VtblIndex(32)]
            void GSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers);

            [VtblIndex(33)]
            void OMSetRenderTargets(uint NumViews, [NativeTypeName("ID3D11RenderTargetView *const *")] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView);

            [VtblIndex(34)]
            void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [NativeTypeName("ID3D11RenderTargetView *const *")] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView *const *")] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [NativeTypeName("const UINT *")] uint* pUAVInitialCounts);

            [VtblIndex(35)]
            void OMSetBlendState(ID3D11BlendState* pBlendState, [NativeTypeName("const FLOAT [4]")] float* BlendFactor, uint SampleMask);

            [VtblIndex(36)]
            void OMSetDepthStencilState(ID3D11DepthStencilState* pDepthStencilState, uint StencilRef);

            [VtblIndex(37)]
            void SOSetTargets(uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppSOTargets, [NativeTypeName("const UINT *")] uint* pOffsets);

            [VtblIndex(38)]
            void DrawAuto();

            [VtblIndex(39)]
            void DrawIndexedInstancedIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs);

            [VtblIndex(40)]
            void DrawInstancedIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs);

            [VtblIndex(41)]
            void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ);

            [VtblIndex(42)]
            void DispatchIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs);

            [VtblIndex(43)]
            void RSSetState(ID3D11RasterizerState* pRasterizerState);

            [VtblIndex(44)]
            void RSSetViewports(uint NumViewports, [NativeTypeName("const D3D11_VIEWPORT *")] D3D11_VIEWPORT* pViewports);

            [VtblIndex(45)]
            void RSSetScissorRects(uint NumRects, [NativeTypeName("const D3D11_RECT *")] RECT* pRects);

            [VtblIndex(46)]
            void CopySubresourceRegion(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pSrcBox);

            [VtblIndex(47)]
            void CopyResource(ID3D11Resource* pDstResource, ID3D11Resource* pSrcResource);

            [VtblIndex(48)]
            void UpdateSubresource(ID3D11Resource* pDstResource, uint DstSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch);

            [VtblIndex(49)]
            void CopyStructureCount(ID3D11Buffer* pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView);

            [VtblIndex(50)]
            void ClearRenderTargetView(ID3D11RenderTargetView* pRenderTargetView, [NativeTypeName("const FLOAT [4]")] float* ColorRGBA);

            [VtblIndex(51)]
            void ClearUnorderedAccessViewUint(ID3D11UnorderedAccessView* pUnorderedAccessView, [NativeTypeName("const UINT [4]")] uint* Values);

            [VtblIndex(52)]
            void ClearUnorderedAccessViewFloat(ID3D11UnorderedAccessView* pUnorderedAccessView, [NativeTypeName("const FLOAT [4]")] float* Values);

            [VtblIndex(53)]
            void ClearDepthStencilView(ID3D11DepthStencilView* pDepthStencilView, uint ClearFlags, float Depth, [NativeTypeName("UINT8")] byte Stencil);

            [VtblIndex(54)]
            void GenerateMips(ID3D11ShaderResourceView* pShaderResourceView);

            [VtblIndex(55)]
            void SetResourceMinLOD(ID3D11Resource* pResource, float MinLOD);

            [VtblIndex(56)]
            float GetResourceMinLOD(ID3D11Resource* pResource);

            [VtblIndex(57)]
            void ResolveSubresource(ID3D11Resource* pDstResource, uint DstSubresource, ID3D11Resource* pSrcResource, uint SrcSubresource, DXGI_FORMAT Format);

            [VtblIndex(58)]
            void ExecuteCommandList(ID3D11CommandList* pCommandList, BOOL RestoreContextState);

            [VtblIndex(59)]
            void HSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews);

            [VtblIndex(60)]
            void HSSetShader(ID3D11HullShader* pHullShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances);

            [VtblIndex(61)]
            void HSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers);

            [VtblIndex(62)]
            void HSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers);

            [VtblIndex(63)]
            void DSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews);

            [VtblIndex(64)]
            void DSSetShader(ID3D11DomainShader* pDomainShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances);

            [VtblIndex(65)]
            void DSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers);

            [VtblIndex(66)]
            void DSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers);

            [VtblIndex(67)]
            void CSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews);

            [VtblIndex(68)]
            void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView *const *")] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [NativeTypeName("const UINT *")] uint* pUAVInitialCounts);

            [VtblIndex(69)]
            void CSSetShader(ID3D11ComputeShader* pComputeShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances);

            [VtblIndex(70)]
            void CSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers);

            [VtblIndex(71)]
            void CSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers);

            [VtblIndex(72)]
            void VSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers);

            [VtblIndex(73)]
            void PSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews);

            [VtblIndex(74)]
            void PSGetShader(ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances);

            [VtblIndex(75)]
            void PSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers);

            [VtblIndex(76)]
            void VSGetShader(ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances);

            [VtblIndex(77)]
            void PSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers);

            [VtblIndex(78)]
            void IAGetInputLayout(ID3D11InputLayout** ppInputLayout);

            [VtblIndex(79)]
            void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, uint* pOffsets);

            [VtblIndex(80)]
            void IAGetIndexBuffer(ID3D11Buffer** pIndexBuffer, DXGI_FORMAT* Format, uint* Offset);

            [VtblIndex(81)]
            void GSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers);

            [VtblIndex(82)]
            void GSGetShader(ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances);

            [VtblIndex(83)]
            void IAGetPrimitiveTopology([NativeTypeName("D3D11_PRIMITIVE_TOPOLOGY *")] D3D_PRIMITIVE_TOPOLOGY* pTopology);

            [VtblIndex(84)]
            void VSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews);

            [VtblIndex(85)]
            void VSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers);

            [VtblIndex(86)]
            void GetPredication(ID3D11Predicate** ppPredicate, BOOL* pPredicateValue);

            [VtblIndex(87)]
            void GSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews);

            [VtblIndex(88)]
            void GSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers);

            [VtblIndex(89)]
            void OMGetRenderTargets(uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView);

            [VtblIndex(90)]
            void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews);

            [VtblIndex(91)]
            void OMGetBlendState(ID3D11BlendState** ppBlendState, [NativeTypeName("FLOAT [4]")] float* BlendFactor, uint* pSampleMask);

            [VtblIndex(92)]
            void OMGetDepthStencilState(ID3D11DepthStencilState** ppDepthStencilState, uint* pStencilRef);

            [VtblIndex(93)]
            void SOGetTargets(uint NumBuffers, ID3D11Buffer** ppSOTargets);

            [VtblIndex(94)]
            void RSGetState(ID3D11RasterizerState** ppRasterizerState);

            [VtblIndex(95)]
            void RSGetViewports(uint* pNumViewports, D3D11_VIEWPORT* pViewports);

            [VtblIndex(96)]
            void RSGetScissorRects(uint* pNumRects, [NativeTypeName("D3D11_RECT *")] RECT* pRects);

            [VtblIndex(97)]
            void HSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews);

            [VtblIndex(98)]
            void HSGetShader(ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances);

            [VtblIndex(99)]
            void HSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers);

            [VtblIndex(100)]
            void HSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers);

            [VtblIndex(101)]
            void DSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews);

            [VtblIndex(102)]
            void DSGetShader(ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances);

            [VtblIndex(103)]
            void DSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers);

            [VtblIndex(104)]
            void DSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers);

            [VtblIndex(105)]
            void CSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews);

            [VtblIndex(106)]
            void CSGetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews);

            [VtblIndex(107)]
            void CSGetShader(ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances);

            [VtblIndex(108)]
            void CSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers);

            [VtblIndex(109)]
            void CSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers);

            [VtblIndex(110)]
            void ClearState();

            [VtblIndex(111)]
            void Flush();

            [VtblIndex(112)]
            D3D11_DEVICE_CONTEXT_TYPE GetType();

            [VtblIndex(113)]
            uint GetContextFlags();

            [VtblIndex(114)]
            HRESULT FinishCommandList(BOOL RestoreDeferredContextState, ID3D11CommandList** ppCommandList);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint> Release;

            [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Device**, void> GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void> VSSetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void> PSSetShaderResources;

            [NativeTypeName("void (ID3D11PixelShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void> PSSetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void> PSSetSamplers;

            [NativeTypeName("void (ID3D11VertexShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void> VSSetShader;

            [NativeTypeName("void (UINT, UINT, INT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, int, void> DrawIndexed;

            [NativeTypeName("void (UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, void> Draw;

            [NativeTypeName("HRESULT (ID3D11Resource *, UINT, D3D11_MAP, UINT, D3D11_MAPPED_SUBRESOURCE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, uint, D3D11_MAP, uint, D3D11_MAPPED_SUBRESOURCE*, int> Map;

            [NativeTypeName("void (ID3D11Resource *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, uint, void> Unmap;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void> PSSetConstantBuffers;

            [NativeTypeName("void (ID3D11InputLayout *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11InputLayout*, void> IASetInputLayout;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void> IASetVertexBuffers;

            [NativeTypeName("void (ID3D11Buffer *, DXGI_FORMAT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer*, DXGI_FORMAT, uint, void> IASetIndexBuffer;

            [NativeTypeName("void (UINT, UINT, UINT, INT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, uint, int, uint, void> DrawIndexedInstanced;

            [NativeTypeName("void (UINT, UINT, UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, uint, uint, void> DrawInstanced;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void> GSSetConstantBuffers;

            [NativeTypeName("void (ID3D11GeometryShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void> GSSetShader;

            [NativeTypeName("void (D3D11_PRIMITIVE_TOPOLOGY) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, D3D_PRIMITIVE_TOPOLOGY, void> IASetPrimitiveTopology;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void> VSSetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void> VSSetSamplers;

            [NativeTypeName("void (ID3D11Asynchronous *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Asynchronous*, void> Begin;

            [NativeTypeName("void (ID3D11Asynchronous *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Asynchronous*, void> End;

            [NativeTypeName("HRESULT (ID3D11Asynchronous *, void *, UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Asynchronous*, void*, uint, uint, int> GetData;

            [NativeTypeName("void (ID3D11Predicate *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Predicate*, BOOL, void> SetPredication;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void> GSSetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void> GSSetSamplers;

            [NativeTypeName("void (UINT, ID3D11RenderTargetView *const *, ID3D11DepthStencilView *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void> OMSetRenderTargets;

            [NativeTypeName("void (UINT, ID3D11RenderTargetView *const *, ID3D11DepthStencilView *, UINT, UINT, ID3D11UnorderedAccessView *const *, const UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void> OMSetRenderTargetsAndUnorderedAccessViews;

            [NativeTypeName("void (ID3D11BlendState *, const FLOAT *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11BlendState*, float*, uint, void> OMSetBlendState;

            [NativeTypeName("void (ID3D11DepthStencilState *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11DepthStencilState*, uint, void> OMSetDepthStencilState;

            [NativeTypeName("void (UINT, ID3D11Buffer *const *, const UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11Buffer**, uint*, void> SOSetTargets;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, void> DrawAuto;

            [NativeTypeName("void (ID3D11Buffer *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer*, uint, void> DrawIndexedInstancedIndirect;

            [NativeTypeName("void (ID3D11Buffer *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer*, uint, void> DrawInstancedIndirect;

            [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, uint, void> Dispatch;

            [NativeTypeName("void (ID3D11Buffer *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer*, uint, void> DispatchIndirect;

            [NativeTypeName("void (ID3D11RasterizerState *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11RasterizerState*, void> RSSetState;

            [NativeTypeName("void (UINT, const D3D11_VIEWPORT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, D3D11_VIEWPORT*, void> RSSetViewports;

            [NativeTypeName("void (UINT, const D3D11_RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, RECT*, void> RSSetScissorRects;

            [NativeTypeName("void (ID3D11Resource *, UINT, UINT, UINT, UINT, ID3D11Resource *, UINT, const D3D11_BOX *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, D3D11_BOX*, void> CopySubresourceRegion;

            [NativeTypeName("void (ID3D11Resource *, ID3D11Resource *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, ID3D11Resource*, void> CopyResource;

            [NativeTypeName("void (ID3D11Resource *, UINT, const D3D11_BOX *, const void *, UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, uint, D3D11_BOX*, void*, uint, uint, void> UpdateSubresource;

            [NativeTypeName("void (ID3D11Buffer *, UINT, ID3D11UnorderedAccessView *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void> CopyStructureCount;

            [NativeTypeName("void (ID3D11RenderTargetView *, const FLOAT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11RenderTargetView*, float*, void> ClearRenderTargetView;

            [NativeTypeName("void (ID3D11UnorderedAccessView *, const UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11UnorderedAccessView*, uint*, void> ClearUnorderedAccessViewUint;

            [NativeTypeName("void (ID3D11UnorderedAccessView *, const FLOAT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11UnorderedAccessView*, float*, void> ClearUnorderedAccessViewFloat;

            [NativeTypeName("void (ID3D11DepthStencilView *, UINT, FLOAT, UINT8) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11DepthStencilView*, uint, float, byte, void> ClearDepthStencilView;

            [NativeTypeName("void (ID3D11ShaderResourceView *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11ShaderResourceView*, void> GenerateMips;

            [NativeTypeName("void (ID3D11Resource *, FLOAT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, float, void> SetResourceMinLOD;

            [NativeTypeName("FLOAT (ID3D11Resource *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, float> GetResourceMinLOD;

            [NativeTypeName("void (ID3D11Resource *, UINT, ID3D11Resource *, UINT, DXGI_FORMAT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, uint, ID3D11Resource*, uint, DXGI_FORMAT, void> ResolveSubresource;

            [NativeTypeName("void (ID3D11CommandList *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11CommandList*, BOOL, void> ExecuteCommandList;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void> HSSetShaderResources;

            [NativeTypeName("void (ID3D11HullShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void> HSSetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void> HSSetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void> HSSetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void> DSSetShaderResources;

            [NativeTypeName("void (ID3D11DomainShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void> DSSetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void> DSSetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void> DSSetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void> CSSetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11UnorderedAccessView *const *, const UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11UnorderedAccessView**, uint*, void> CSSetUnorderedAccessViews;

            [NativeTypeName("void (ID3D11ComputeShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void> CSSetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void> CSSetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void> CSSetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void> VSGetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void> PSGetShaderResources;

            [NativeTypeName("void (ID3D11PixelShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void> PSGetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void> PSGetSamplers;

            [NativeTypeName("void (ID3D11VertexShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void> VSGetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void> PSGetConstantBuffers;

            [NativeTypeName("void (ID3D11InputLayout **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11InputLayout**, void> IAGetInputLayout;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void> IAGetVertexBuffers;

            [NativeTypeName("void (ID3D11Buffer **, DXGI_FORMAT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer**, DXGI_FORMAT*, uint*, void> IAGetIndexBuffer;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void> GSGetConstantBuffers;

            [NativeTypeName("void (ID3D11GeometryShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void> GSGetShader;

            [NativeTypeName("void (D3D11_PRIMITIVE_TOPOLOGY *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, D3D_PRIMITIVE_TOPOLOGY*, void> IAGetPrimitiveTopology;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void> VSGetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void> VSGetSamplers;

            [NativeTypeName("void (ID3D11Predicate **, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11Predicate**, BOOL*, void> GetPredication;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void> GSGetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void> GSGetSamplers;

            [NativeTypeName("void (UINT, ID3D11RenderTargetView **, ID3D11DepthStencilView **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void> OMGetRenderTargets;

            [NativeTypeName("void (UINT, ID3D11RenderTargetView **, ID3D11DepthStencilView **, UINT, UINT, ID3D11UnorderedAccessView **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void> OMGetRenderTargetsAndUnorderedAccessViews;

            [NativeTypeName("void (ID3D11BlendState **, FLOAT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11BlendState**, float*, uint*, void> OMGetBlendState;

            [NativeTypeName("void (ID3D11DepthStencilState **, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11DepthStencilState**, uint*, void> OMGetDepthStencilState;

            [NativeTypeName("void (UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11Buffer**, void> SOGetTargets;

            [NativeTypeName("void (ID3D11RasterizerState **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11RasterizerState**, void> RSGetState;

            [NativeTypeName("void (UINT *, D3D11_VIEWPORT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint*, D3D11_VIEWPORT*, void> RSGetViewports;

            [NativeTypeName("void (UINT *, D3D11_RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint*, RECT*, void> RSGetScissorRects;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void> HSGetShaderResources;

            [NativeTypeName("void (ID3D11HullShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void> HSGetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void> HSGetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void> HSGetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void> DSGetShaderResources;

            [NativeTypeName("void (ID3D11DomainShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void> DSGetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void> DSGetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void> DSGetConstantBuffers;

            [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void> CSGetShaderResources;

            [NativeTypeName("void (UINT, UINT, ID3D11UnorderedAccessView **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11UnorderedAccessView**, void> CSGetUnorderedAccessViews;

            [NativeTypeName("void (ID3D11ComputeShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void> CSGetShader;

            [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void> CSGetSamplers;

            [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void> CSGetConstantBuffers;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, void> ClearState;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, void> Flush;

            [NativeTypeName("D3D11_DEVICE_CONTEXT_TYPE () __attribute__((stdcall))")]
            public new delegate* unmanaged<ID3D11DeviceContext*, D3D11_DEVICE_CONTEXT_TYPE> GetType;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, uint> GetContextFlags;

            [NativeTypeName("HRESULT (BOOL, ID3D11CommandList **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11DeviceContext*, BOOL, ID3D11CommandList**, int> FinishCommandList;
        }
    }
}
