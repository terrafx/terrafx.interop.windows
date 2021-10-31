// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B7E4C0F-342C-4106-A19F-4F2704F689F0")]
    [NativeTypeName("struct ID3D10Device : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D10Device
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D10Device*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10Device*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D10Device*, uint>)(lpVtbl[1]))((ID3D10Device*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D10Device*, uint>)(lpVtbl[2]))((ID3D10Device*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void VSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D10Buffer *const *")] ID3D10Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10Buffer**, void>)(lpVtbl[3]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void PSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D10ShaderResourceView *const *")] ID3D10ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10ShaderResourceView**, void>)(lpVtbl[4]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void PSSetShader(ID3D10PixelShader* pPixelShader)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10PixelShader*, void>)(lpVtbl[5]))((ID3D10Device*)Unsafe.AsPointer(ref this), pPixelShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void PSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D10SamplerState *const *")] ID3D10SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10SamplerState**, void>)(lpVtbl[6]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void VSSetShader(ID3D10VertexShader* pVertexShader)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10VertexShader*, void>)(lpVtbl[7]))((ID3D10Device*)Unsafe.AsPointer(ref this), pVertexShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void DrawIndexed(uint IndexCount, uint StartIndexLocation, int BaseVertexLocation)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, int, void>)(lpVtbl[8]))((ID3D10Device*)Unsafe.AsPointer(ref this), IndexCount, StartIndexLocation, BaseVertexLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void Draw(uint VertexCount, uint StartVertexLocation)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, void>)(lpVtbl[9]))((ID3D10Device*)Unsafe.AsPointer(ref this), VertexCount, StartVertexLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public void PSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D10Buffer *const *")] ID3D10Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10Buffer**, void>)(lpVtbl[10]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void IASetInputLayout(ID3D10InputLayout* pInputLayout)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10InputLayout*, void>)(lpVtbl[11]))((ID3D10Device*)Unsafe.AsPointer(ref this), pInputLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void IASetVertexBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D10Buffer *const *")] ID3D10Buffer** ppVertexBuffers, [NativeTypeName("const UINT *")] uint* pStrides, [NativeTypeName("const UINT *")] uint* pOffsets)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10Buffer**, uint*, uint*, void>)(lpVtbl[12]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void IASetIndexBuffer(ID3D10Buffer* pIndexBuffer, DXGI_FORMAT Format, uint Offset)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10Buffer*, DXGI_FORMAT, uint, void>)(lpVtbl[13]))((ID3D10Device*)Unsafe.AsPointer(ref this), pIndexBuffer, Format, Offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, uint, int, uint, void>)(lpVtbl[14]))((ID3D10Device*)Unsafe.AsPointer(ref this), IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, uint, uint, void>)(lpVtbl[15]))((ID3D10Device*)Unsafe.AsPointer(ref this), VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public void GSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D10Buffer *const *")] ID3D10Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10Buffer**, void>)(lpVtbl[16]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void GSSetShader(ID3D10GeometryShader* pShader)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10GeometryShader*, void>)(lpVtbl[17]))((ID3D10Device*)Unsafe.AsPointer(ref this), pShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void IASetPrimitiveTopology([NativeTypeName("D3D10_PRIMITIVE_TOPOLOGY")] D3D_PRIMITIVE_TOPOLOGY Topology)
        {
            ((delegate* unmanaged<ID3D10Device*, D3D_PRIMITIVE_TOPOLOGY, void>)(lpVtbl[18]))((ID3D10Device*)Unsafe.AsPointer(ref this), Topology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void VSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D10ShaderResourceView *const *")] ID3D10ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10ShaderResourceView**, void>)(lpVtbl[19]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void VSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D10SamplerState *const *")] ID3D10SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10SamplerState**, void>)(lpVtbl[20]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void SetPredication(ID3D10Predicate* pPredicate, BOOL PredicateValue)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10Predicate*, BOOL, void>)(lpVtbl[21]))((ID3D10Device*)Unsafe.AsPointer(ref this), pPredicate, PredicateValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void GSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D10ShaderResourceView *const *")] ID3D10ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10ShaderResourceView**, void>)(lpVtbl[22]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void GSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D10SamplerState *const *")] ID3D10SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10SamplerState**, void>)(lpVtbl[23]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public void OMSetRenderTargets(uint NumViews, [NativeTypeName("ID3D10RenderTargetView *const *")] ID3D10RenderTargetView** ppRenderTargetViews, ID3D10DepthStencilView* pDepthStencilView)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, ID3D10RenderTargetView**, ID3D10DepthStencilView*, void>)(lpVtbl[24]))((ID3D10Device*)Unsafe.AsPointer(ref this), NumViews, ppRenderTargetViews, pDepthStencilView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public void OMSetBlendState(ID3D10BlendState* pBlendState, [NativeTypeName("const FLOAT [4]")] float* BlendFactor, uint SampleMask)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10BlendState*, float*, uint, void>)(lpVtbl[25]))((ID3D10Device*)Unsafe.AsPointer(ref this), pBlendState, BlendFactor, SampleMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public void OMSetDepthStencilState(ID3D10DepthStencilState* pDepthStencilState, uint StencilRef)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10DepthStencilState*, uint, void>)(lpVtbl[26]))((ID3D10Device*)Unsafe.AsPointer(ref this), pDepthStencilState, StencilRef);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public void SOSetTargets(uint NumBuffers, [NativeTypeName("ID3D10Buffer *const *")] ID3D10Buffer** ppSOTargets, [NativeTypeName("const UINT *")] uint* pOffsets)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, ID3D10Buffer**, uint*, void>)(lpVtbl[27]))((ID3D10Device*)Unsafe.AsPointer(ref this), NumBuffers, ppSOTargets, pOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public void DrawAuto()
        {
            ((delegate* unmanaged<ID3D10Device*, void>)(lpVtbl[28]))((ID3D10Device*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public void RSSetState(ID3D10RasterizerState* pRasterizerState)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10RasterizerState*, void>)(lpVtbl[29]))((ID3D10Device*)Unsafe.AsPointer(ref this), pRasterizerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public void RSSetViewports(uint NumViewports, [NativeTypeName("const D3D10_VIEWPORT *")] D3D10_VIEWPORT* pViewports)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, D3D10_VIEWPORT*, void>)(lpVtbl[30]))((ID3D10Device*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public void RSSetScissorRects(uint NumRects, [NativeTypeName("const D3D10_RECT *")] RECT* pRects)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, RECT*, void>)(lpVtbl[31]))((ID3D10Device*)Unsafe.AsPointer(ref this), NumRects, pRects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public void CopySubresourceRegion(ID3D10Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D10Resource* pSrcResource, uint SrcSubresource, [NativeTypeName("const D3D10_BOX *")] D3D10_BOX* pSrcBox)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10Resource*, uint, uint, uint, uint, ID3D10Resource*, uint, D3D10_BOX*, void>)(lpVtbl[32]))((ID3D10Device*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public void CopyResource(ID3D10Resource* pDstResource, ID3D10Resource* pSrcResource)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10Resource*, ID3D10Resource*, void>)(lpVtbl[33]))((ID3D10Device*)Unsafe.AsPointer(ref this), pDstResource, pSrcResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public void UpdateSubresource(ID3D10Resource* pDstResource, uint DstSubresource, [NativeTypeName("const D3D10_BOX *")] D3D10_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10Resource*, uint, D3D10_BOX*, void*, uint, uint, void>)(lpVtbl[34]))((ID3D10Device*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public void ClearRenderTargetView(ID3D10RenderTargetView* pRenderTargetView, [NativeTypeName("const FLOAT [4]")] float* ColorRGBA)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10RenderTargetView*, float*, void>)(lpVtbl[35]))((ID3D10Device*)Unsafe.AsPointer(ref this), pRenderTargetView, ColorRGBA);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public void ClearDepthStencilView(ID3D10DepthStencilView* pDepthStencilView, uint ClearFlags, float Depth, [NativeTypeName("UINT8")] byte Stencil)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10DepthStencilView*, uint, float, byte, void>)(lpVtbl[36]))((ID3D10Device*)Unsafe.AsPointer(ref this), pDepthStencilView, ClearFlags, Depth, Stencil);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public void GenerateMips(ID3D10ShaderResourceView* pShaderResourceView)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10ShaderResourceView*, void>)(lpVtbl[37]))((ID3D10Device*)Unsafe.AsPointer(ref this), pShaderResourceView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public void ResolveSubresource(ID3D10Resource* pDstResource, uint DstSubresource, ID3D10Resource* pSrcResource, uint SrcSubresource, DXGI_FORMAT Format)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10Resource*, uint, ID3D10Resource*, uint, DXGI_FORMAT, void>)(lpVtbl[38]))((ID3D10Device*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public void VSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D10Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10Buffer**, void>)(lpVtbl[39]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public void PSGetShaderResources(uint StartSlot, uint NumViews, ID3D10ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10ShaderResourceView**, void>)(lpVtbl[40]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public void PSGetShader(ID3D10PixelShader** ppPixelShader)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10PixelShader**, void>)(lpVtbl[41]))((ID3D10Device*)Unsafe.AsPointer(ref this), ppPixelShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public void PSGetSamplers(uint StartSlot, uint NumSamplers, ID3D10SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10SamplerState**, void>)(lpVtbl[42]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public void VSGetShader(ID3D10VertexShader** ppVertexShader)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10VertexShader**, void>)(lpVtbl[43]))((ID3D10Device*)Unsafe.AsPointer(ref this), ppVertexShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public void PSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D10Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10Buffer**, void>)(lpVtbl[44]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public void IAGetInputLayout(ID3D10InputLayout** ppInputLayout)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10InputLayout**, void>)(lpVtbl[45]))((ID3D10Device*)Unsafe.AsPointer(ref this), ppInputLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D10Buffer** ppVertexBuffers, uint* pStrides, uint* pOffsets)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10Buffer**, uint*, uint*, void>)(lpVtbl[46]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public void IAGetIndexBuffer(ID3D10Buffer** pIndexBuffer, DXGI_FORMAT* Format, uint* Offset)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10Buffer**, DXGI_FORMAT*, uint*, void>)(lpVtbl[47]))((ID3D10Device*)Unsafe.AsPointer(ref this), pIndexBuffer, Format, Offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public void GSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D10Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10Buffer**, void>)(lpVtbl[48]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public void GSGetShader(ID3D10GeometryShader** ppGeometryShader)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10GeometryShader**, void>)(lpVtbl[49]))((ID3D10Device*)Unsafe.AsPointer(ref this), ppGeometryShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public void IAGetPrimitiveTopology([NativeTypeName("D3D10_PRIMITIVE_TOPOLOGY *")] D3D_PRIMITIVE_TOPOLOGY* pTopology)
        {
            ((delegate* unmanaged<ID3D10Device*, D3D_PRIMITIVE_TOPOLOGY*, void>)(lpVtbl[50]))((ID3D10Device*)Unsafe.AsPointer(ref this), pTopology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public void VSGetShaderResources(uint StartSlot, uint NumViews, ID3D10ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10ShaderResourceView**, void>)(lpVtbl[51]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public void VSGetSamplers(uint StartSlot, uint NumSamplers, ID3D10SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10SamplerState**, void>)(lpVtbl[52]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public void GetPredication(ID3D10Predicate** ppPredicate, BOOL* pPredicateValue)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10Predicate**, BOOL*, void>)(lpVtbl[53]))((ID3D10Device*)Unsafe.AsPointer(ref this), ppPredicate, pPredicateValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public void GSGetShaderResources(uint StartSlot, uint NumViews, ID3D10ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10ShaderResourceView**, void>)(lpVtbl[54]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public void GSGetSamplers(uint StartSlot, uint NumSamplers, ID3D10SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, ID3D10SamplerState**, void>)(lpVtbl[55]))((ID3D10Device*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public void OMGetRenderTargets(uint NumViews, ID3D10RenderTargetView** ppRenderTargetViews, ID3D10DepthStencilView** ppDepthStencilView)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, ID3D10RenderTargetView**, ID3D10DepthStencilView**, void>)(lpVtbl[56]))((ID3D10Device*)Unsafe.AsPointer(ref this), NumViews, ppRenderTargetViews, ppDepthStencilView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public void OMGetBlendState(ID3D10BlendState** ppBlendState, [NativeTypeName("FLOAT [4]")] float* BlendFactor, uint* pSampleMask)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10BlendState**, float*, uint*, void>)(lpVtbl[57]))((ID3D10Device*)Unsafe.AsPointer(ref this), ppBlendState, BlendFactor, pSampleMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public void OMGetDepthStencilState(ID3D10DepthStencilState** ppDepthStencilState, uint* pStencilRef)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10DepthStencilState**, uint*, void>)(lpVtbl[58]))((ID3D10Device*)Unsafe.AsPointer(ref this), ppDepthStencilState, pStencilRef);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public void SOGetTargets(uint NumBuffers, ID3D10Buffer** ppSOTargets, uint* pOffsets)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, ID3D10Buffer**, uint*, void>)(lpVtbl[59]))((ID3D10Device*)Unsafe.AsPointer(ref this), NumBuffers, ppSOTargets, pOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public void RSGetState(ID3D10RasterizerState** ppRasterizerState)
        {
            ((delegate* unmanaged<ID3D10Device*, ID3D10RasterizerState**, void>)(lpVtbl[60]))((ID3D10Device*)Unsafe.AsPointer(ref this), ppRasterizerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public void RSGetViewports(uint* NumViewports, D3D10_VIEWPORT* pViewports)
        {
            ((delegate* unmanaged<ID3D10Device*, uint*, D3D10_VIEWPORT*, void>)(lpVtbl[61]))((ID3D10Device*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public void RSGetScissorRects(uint* NumRects, [NativeTypeName("D3D10_RECT *")] RECT* pRects)
        {
            ((delegate* unmanaged<ID3D10Device*, uint*, RECT*, void>)(lpVtbl[62]))((ID3D10Device*)Unsafe.AsPointer(ref this), NumRects, pRects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT GetDeviceRemovedReason()
        {
            return ((delegate* unmanaged<ID3D10Device*, int>)(lpVtbl[63]))((ID3D10Device*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT SetExceptionMode(uint RaiseFlags)
        {
            return ((delegate* unmanaged<ID3D10Device*, uint, int>)(lpVtbl[64]))((ID3D10Device*)Unsafe.AsPointer(ref this), RaiseFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public uint GetExceptionMode()
        {
            return ((delegate* unmanaged<ID3D10Device*, uint>)(lpVtbl[65]))((ID3D10Device*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D10Device*, Guid*, uint*, void*, int>)(lpVtbl[66]))((ID3D10Device*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D10Device*, Guid*, uint, void*, int>)(lpVtbl[67]))((ID3D10Device*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D10Device*, Guid*, IUnknown*, int>)(lpVtbl[68]))((ID3D10Device*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public void ClearState()
        {
            ((delegate* unmanaged<ID3D10Device*, void>)(lpVtbl[69]))((ID3D10Device*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public void Flush()
        {
            ((delegate* unmanaged<ID3D10Device*, void>)(lpVtbl[70]))((ID3D10Device*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public HRESULT CreateBuffer([NativeTypeName("const D3D10_BUFFER_DESC *")] D3D10_BUFFER_DESC* pDesc, [NativeTypeName("const D3D10_SUBRESOURCE_DATA *")] D3D10_SUBRESOURCE_DATA* pInitialData, ID3D10Buffer** ppBuffer)
        {
            return ((delegate* unmanaged<ID3D10Device*, D3D10_BUFFER_DESC*, D3D10_SUBRESOURCE_DATA*, ID3D10Buffer**, int>)(lpVtbl[71]))((ID3D10Device*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        public HRESULT CreateTexture1D([NativeTypeName("const D3D10_TEXTURE1D_DESC *")] D3D10_TEXTURE1D_DESC* pDesc, [NativeTypeName("const D3D10_SUBRESOURCE_DATA *")] D3D10_SUBRESOURCE_DATA* pInitialData, ID3D10Texture1D** ppTexture1D)
        {
            return ((delegate* unmanaged<ID3D10Device*, D3D10_TEXTURE1D_DESC*, D3D10_SUBRESOURCE_DATA*, ID3D10Texture1D**, int>)(lpVtbl[72]))((ID3D10Device*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture1D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public HRESULT CreateTexture2D([NativeTypeName("const D3D10_TEXTURE2D_DESC *")] D3D10_TEXTURE2D_DESC* pDesc, [NativeTypeName("const D3D10_SUBRESOURCE_DATA *")] D3D10_SUBRESOURCE_DATA* pInitialData, ID3D10Texture2D** ppTexture2D)
        {
            return ((delegate* unmanaged<ID3D10Device*, D3D10_TEXTURE2D_DESC*, D3D10_SUBRESOURCE_DATA*, ID3D10Texture2D**, int>)(lpVtbl[73]))((ID3D10Device*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture2D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public HRESULT CreateTexture3D([NativeTypeName("const D3D10_TEXTURE3D_DESC *")] D3D10_TEXTURE3D_DESC* pDesc, [NativeTypeName("const D3D10_SUBRESOURCE_DATA *")] D3D10_SUBRESOURCE_DATA* pInitialData, ID3D10Texture3D** ppTexture3D)
        {
            return ((delegate* unmanaged<ID3D10Device*, D3D10_TEXTURE3D_DESC*, D3D10_SUBRESOURCE_DATA*, ID3D10Texture3D**, int>)(lpVtbl[74]))((ID3D10Device*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public HRESULT CreateShaderResourceView(ID3D10Resource* pResource, [NativeTypeName("const D3D10_SHADER_RESOURCE_VIEW_DESC *")] D3D10_SHADER_RESOURCE_VIEW_DESC* pDesc, ID3D10ShaderResourceView** ppSRView)
        {
            return ((delegate* unmanaged<ID3D10Device*, ID3D10Resource*, D3D10_SHADER_RESOURCE_VIEW_DESC*, ID3D10ShaderResourceView**, int>)(lpVtbl[75]))((ID3D10Device*)Unsafe.AsPointer(ref this), pResource, pDesc, ppSRView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        public HRESULT CreateRenderTargetView(ID3D10Resource* pResource, [NativeTypeName("const D3D10_RENDER_TARGET_VIEW_DESC *")] D3D10_RENDER_TARGET_VIEW_DESC* pDesc, ID3D10RenderTargetView** ppRTView)
        {
            return ((delegate* unmanaged<ID3D10Device*, ID3D10Resource*, D3D10_RENDER_TARGET_VIEW_DESC*, ID3D10RenderTargetView**, int>)(lpVtbl[76]))((ID3D10Device*)Unsafe.AsPointer(ref this), pResource, pDesc, ppRTView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        public HRESULT CreateDepthStencilView(ID3D10Resource* pResource, [NativeTypeName("const D3D10_DEPTH_STENCIL_VIEW_DESC *")] D3D10_DEPTH_STENCIL_VIEW_DESC* pDesc, ID3D10DepthStencilView** ppDepthStencilView)
        {
            return ((delegate* unmanaged<ID3D10Device*, ID3D10Resource*, D3D10_DEPTH_STENCIL_VIEW_DESC*, ID3D10DepthStencilView**, int>)(lpVtbl[77]))((ID3D10Device*)Unsafe.AsPointer(ref this), pResource, pDesc, ppDepthStencilView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        public HRESULT CreateInputLayout([NativeTypeName("const D3D10_INPUT_ELEMENT_DESC *")] D3D10_INPUT_ELEMENT_DESC* pInputElementDescs, uint NumElements, [NativeTypeName("const void *")] void* pShaderBytecodeWithInputSignature, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D10InputLayout** ppInputLayout)
        {
            return ((delegate* unmanaged<ID3D10Device*, D3D10_INPUT_ELEMENT_DESC*, uint, void*, nuint, ID3D10InputLayout**, int>)(lpVtbl[78]))((ID3D10Device*)Unsafe.AsPointer(ref this), pInputElementDescs, NumElements, pShaderBytecodeWithInputSignature, BytecodeLength, ppInputLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        public HRESULT CreateVertexShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D10VertexShader** ppVertexShader)
        {
            return ((delegate* unmanaged<ID3D10Device*, void*, nuint, ID3D10VertexShader**, int>)(lpVtbl[79]))((ID3D10Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, ppVertexShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public HRESULT CreateGeometryShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D10GeometryShader** ppGeometryShader)
        {
            return ((delegate* unmanaged<ID3D10Device*, void*, nuint, ID3D10GeometryShader**, int>)(lpVtbl[80]))((ID3D10Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, ppGeometryShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        public HRESULT CreateGeometryShaderWithStreamOutput([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("const D3D10_SO_DECLARATION_ENTRY *")] D3D10_SO_DECLARATION_ENTRY* pSODeclaration, uint NumEntries, uint OutputStreamStride, ID3D10GeometryShader** ppGeometryShader)
        {
            return ((delegate* unmanaged<ID3D10Device*, void*, nuint, D3D10_SO_DECLARATION_ENTRY*, uint, uint, ID3D10GeometryShader**, int>)(lpVtbl[81]))((ID3D10Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pSODeclaration, NumEntries, OutputStreamStride, ppGeometryShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        public HRESULT CreatePixelShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D10PixelShader** ppPixelShader)
        {
            return ((delegate* unmanaged<ID3D10Device*, void*, nuint, ID3D10PixelShader**, int>)(lpVtbl[82]))((ID3D10Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, ppPixelShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        public HRESULT CreateBlendState([NativeTypeName("const D3D10_BLEND_DESC *")] D3D10_BLEND_DESC* pBlendStateDesc, ID3D10BlendState** ppBlendState)
        {
            return ((delegate* unmanaged<ID3D10Device*, D3D10_BLEND_DESC*, ID3D10BlendState**, int>)(lpVtbl[83]))((ID3D10Device*)Unsafe.AsPointer(ref this), pBlendStateDesc, ppBlendState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        public HRESULT CreateDepthStencilState([NativeTypeName("const D3D10_DEPTH_STENCIL_DESC *")] D3D10_DEPTH_STENCIL_DESC* pDepthStencilDesc, ID3D10DepthStencilState** ppDepthStencilState)
        {
            return ((delegate* unmanaged<ID3D10Device*, D3D10_DEPTH_STENCIL_DESC*, ID3D10DepthStencilState**, int>)(lpVtbl[84]))((ID3D10Device*)Unsafe.AsPointer(ref this), pDepthStencilDesc, ppDepthStencilState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        public HRESULT CreateRasterizerState([NativeTypeName("const D3D10_RASTERIZER_DESC *")] D3D10_RASTERIZER_DESC* pRasterizerDesc, ID3D10RasterizerState** ppRasterizerState)
        {
            return ((delegate* unmanaged<ID3D10Device*, D3D10_RASTERIZER_DESC*, ID3D10RasterizerState**, int>)(lpVtbl[85]))((ID3D10Device*)Unsafe.AsPointer(ref this), pRasterizerDesc, ppRasterizerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        public HRESULT CreateSamplerState([NativeTypeName("const D3D10_SAMPLER_DESC *")] D3D10_SAMPLER_DESC* pSamplerDesc, ID3D10SamplerState** ppSamplerState)
        {
            return ((delegate* unmanaged<ID3D10Device*, D3D10_SAMPLER_DESC*, ID3D10SamplerState**, int>)(lpVtbl[86]))((ID3D10Device*)Unsafe.AsPointer(ref this), pSamplerDesc, ppSamplerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        public HRESULT CreateQuery([NativeTypeName("const D3D10_QUERY_DESC *")] D3D10_QUERY_DESC* pQueryDesc, ID3D10Query** ppQuery)
        {
            return ((delegate* unmanaged<ID3D10Device*, D3D10_QUERY_DESC*, ID3D10Query**, int>)(lpVtbl[87]))((ID3D10Device*)Unsafe.AsPointer(ref this), pQueryDesc, ppQuery);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        public HRESULT CreatePredicate([NativeTypeName("const D3D10_QUERY_DESC *")] D3D10_QUERY_DESC* pPredicateDesc, ID3D10Predicate** ppPredicate)
        {
            return ((delegate* unmanaged<ID3D10Device*, D3D10_QUERY_DESC*, ID3D10Predicate**, int>)(lpVtbl[88]))((ID3D10Device*)Unsafe.AsPointer(ref this), pPredicateDesc, ppPredicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        public HRESULT CreateCounter([NativeTypeName("const D3D10_COUNTER_DESC *")] D3D10_COUNTER_DESC* pCounterDesc, ID3D10Counter** ppCounter)
        {
            return ((delegate* unmanaged<ID3D10Device*, D3D10_COUNTER_DESC*, ID3D10Counter**, int>)(lpVtbl[89]))((ID3D10Device*)Unsafe.AsPointer(ref this), pCounterDesc, ppCounter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        public HRESULT CheckFormatSupport(DXGI_FORMAT Format, uint* pFormatSupport)
        {
            return ((delegate* unmanaged<ID3D10Device*, DXGI_FORMAT, uint*, int>)(lpVtbl[90]))((ID3D10Device*)Unsafe.AsPointer(ref this), Format, pFormatSupport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        public HRESULT CheckMultisampleQualityLevels(DXGI_FORMAT Format, uint SampleCount, uint* pNumQualityLevels)
        {
            return ((delegate* unmanaged<ID3D10Device*, DXGI_FORMAT, uint, uint*, int>)(lpVtbl[91]))((ID3D10Device*)Unsafe.AsPointer(ref this), Format, SampleCount, pNumQualityLevels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        public void CheckCounterInfo(D3D10_COUNTER_INFO* pCounterInfo)
        {
            ((delegate* unmanaged<ID3D10Device*, D3D10_COUNTER_INFO*, void>)(lpVtbl[92]))((ID3D10Device*)Unsafe.AsPointer(ref this), pCounterInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        public HRESULT CheckCounter([NativeTypeName("const D3D10_COUNTER_DESC *")] D3D10_COUNTER_DESC* pDesc, D3D10_COUNTER_TYPE* pType, uint* pActiveCounters, [NativeTypeName("LPSTR")] sbyte* szName, uint* pNameLength, [NativeTypeName("LPSTR")] sbyte* szUnits, uint* pUnitsLength, [NativeTypeName("LPSTR")] sbyte* szDescription, uint* pDescriptionLength)
        {
            return ((delegate* unmanaged<ID3D10Device*, D3D10_COUNTER_DESC*, D3D10_COUNTER_TYPE*, uint*, sbyte*, uint*, sbyte*, uint*, sbyte*, uint*, int>)(lpVtbl[93]))((ID3D10Device*)Unsafe.AsPointer(ref this), pDesc, pType, pActiveCounters, szName, pNameLength, szUnits, pUnitsLength, szDescription, pDescriptionLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        public uint GetCreationFlags()
        {
            return ((delegate* unmanaged<ID3D10Device*, uint>)(lpVtbl[94]))((ID3D10Device*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        public HRESULT OpenSharedResource(HANDLE hResource, [NativeTypeName("const IID &")] Guid* ReturnedInterface, void** ppResource)
        {
            return ((delegate* unmanaged<ID3D10Device*, HANDLE, Guid*, void**, int>)(lpVtbl[95]))((ID3D10Device*)Unsafe.AsPointer(ref this), hResource, ReturnedInterface, ppResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        public void SetTextFilterSize(uint Width, uint Height)
        {
            ((delegate* unmanaged<ID3D10Device*, uint, uint, void>)(lpVtbl[96]))((ID3D10Device*)Unsafe.AsPointer(ref this), Width, Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        public void GetTextFilterSize(uint* pWidth, uint* pHeight)
        {
            ((delegate* unmanaged<ID3D10Device*, uint*, uint*, void>)(lpVtbl[97]))((ID3D10Device*)Unsafe.AsPointer(ref this), pWidth, pHeight);
        }
    }
}
