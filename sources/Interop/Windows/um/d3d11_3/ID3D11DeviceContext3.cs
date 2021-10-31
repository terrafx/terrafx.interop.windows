// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B4E3C01D-E79E-4637-91B2-510E9F4C9B8F")]
    [NativeTypeName("struct ID3D11DeviceContext3 : ID3D11DeviceContext2")]
    [NativeInheritance("ID3D11DeviceContext2")]
    public unsafe partial struct ID3D11DeviceContext3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext3*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11DeviceContext3*, uint>)(lpVtbl[1]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11DeviceContext3*, uint>)(lpVtbl[2]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext3*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext3*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext3*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void VSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[7]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void PSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[8]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void PSSetShader(ID3D11PixelShader* pPixelShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[9]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pPixelShader, ppClassInstances, NumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public void PSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[10]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void VSSetShader(ID3D11VertexShader* pVertexShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[11]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pVertexShader, ppClassInstances, NumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void DrawIndexed([NativeTypeName("UINT")] uint IndexCount, [NativeTypeName("UINT")] uint StartIndexLocation, [NativeTypeName("INT")] int BaseVertexLocation)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, int, void>)(lpVtbl[12]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), IndexCount, StartIndexLocation, BaseVertexLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void Draw([NativeTypeName("UINT")] uint VertexCount, [NativeTypeName("UINT")] uint StartVertexLocation)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, void>)(lpVtbl[13]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), VertexCount, StartVertexLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int Map(ID3D11Resource* pResource, [NativeTypeName("UINT")] uint Subresource, D3D11_MAP MapType, [NativeTypeName("UINT")] uint MapFlags, D3D11_MAPPED_SUBRESOURCE* pMappedResource)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Resource*, uint, D3D11_MAP, uint, D3D11_MAPPED_SUBRESOURCE*, int>)(lpVtbl[14]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pResource, Subresource, MapType, MapFlags, pMappedResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public void Unmap(ID3D11Resource* pResource, [NativeTypeName("UINT")] uint Subresource)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Resource*, uint, void>)(lpVtbl[15]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pResource, Subresource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public void PSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[16]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void IASetInputLayout(ID3D11InputLayout* pInputLayout)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11InputLayout*, void>)(lpVtbl[17]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pInputLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void IASetVertexBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppVertexBuffers, [NativeTypeName("const UINT *")] uint* pStrides, [NativeTypeName("const UINT *")] uint* pOffsets)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[18]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void IASetIndexBuffer(ID3D11Buffer* pIndexBuffer, DXGI_FORMAT Format, [NativeTypeName("UINT")] uint Offset)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Buffer*, DXGI_FORMAT, uint, void>)(lpVtbl[19]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pIndexBuffer, Format, Offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void DrawIndexedInstanced([NativeTypeName("UINT")] uint IndexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartIndexLocation, [NativeTypeName("INT")] int BaseVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, uint, int, uint, void>)(lpVtbl[20]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void DrawInstanced([NativeTypeName("UINT")] uint VertexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, uint, uint, void>)(lpVtbl[21]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void GSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[22]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void GSSetShader(ID3D11GeometryShader* pShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[23]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pShader, ppClassInstances, NumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public void IASetPrimitiveTopology([NativeTypeName("D3D11_PRIMITIVE_TOPOLOGY")] D3D_PRIMITIVE_TOPOLOGY Topology)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, D3D_PRIMITIVE_TOPOLOGY, void>)(lpVtbl[24]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), Topology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public void VSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[25]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public void VSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[26]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public void Begin(ID3D11Asynchronous* pAsync)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Asynchronous*, void>)(lpVtbl[27]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pAsync);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public void End(ID3D11Asynchronous* pAsync)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Asynchronous*, void>)(lpVtbl[28]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pAsync);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int GetData(ID3D11Asynchronous* pAsync, void* pData, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("UINT")] uint GetDataFlags)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Asynchronous*, void*, uint, uint, int>)(lpVtbl[29]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pAsync, pData, DataSize, GetDataFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public void SetPredication(ID3D11Predicate* pPredicate, BOOL PredicateValue)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Predicate*, BOOL, void>)(lpVtbl[30]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pPredicate, PredicateValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public void GSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[31]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public void GSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[32]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public void OMSetRenderTargets([NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11RenderTargetView *const *")] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)(lpVtbl[33]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), NumViews, ppRenderTargetViews, pDepthStencilView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public void OMSetRenderTargetsAndUnorderedAccessViews([NativeTypeName("UINT")] uint NumRTVs, [NativeTypeName("ID3D11RenderTargetView *const *")] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, [NativeTypeName("UINT")] uint UAVStartSlot, [NativeTypeName("UINT")] uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView *const *")] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [NativeTypeName("const UINT *")] uint* pUAVInitialCounts)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)(lpVtbl[34]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public void OMSetBlendState(ID3D11BlendState* pBlendState, [NativeTypeName("const FLOAT [4]")] float* BlendFactor, [NativeTypeName("UINT")] uint SampleMask)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11BlendState*, float*, uint, void>)(lpVtbl[35]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pBlendState, BlendFactor, SampleMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public void OMSetDepthStencilState(ID3D11DepthStencilState* pDepthStencilState, [NativeTypeName("UINT")] uint StencilRef)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11DepthStencilState*, uint, void>)(lpVtbl[36]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDepthStencilState, StencilRef);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public void SOSetTargets([NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppSOTargets, [NativeTypeName("const UINT *")] uint* pOffsets)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, ID3D11Buffer**, uint*, void>)(lpVtbl[37]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), NumBuffers, ppSOTargets, pOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public void DrawAuto()
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, void>)(lpVtbl[38]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public void DrawIndexedInstancedIndirect(ID3D11Buffer* pBufferForArgs, [NativeTypeName("UINT")] uint AlignedByteOffsetForArgs)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Buffer*, uint, void>)(lpVtbl[39]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pBufferForArgs, AlignedByteOffsetForArgs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public void DrawInstancedIndirect(ID3D11Buffer* pBufferForArgs, [NativeTypeName("UINT")] uint AlignedByteOffsetForArgs)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Buffer*, uint, void>)(lpVtbl[40]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pBufferForArgs, AlignedByteOffsetForArgs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public void Dispatch([NativeTypeName("UINT")] uint ThreadGroupCountX, [NativeTypeName("UINT")] uint ThreadGroupCountY, [NativeTypeName("UINT")] uint ThreadGroupCountZ)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, uint, void>)(lpVtbl[41]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public void DispatchIndirect(ID3D11Buffer* pBufferForArgs, [NativeTypeName("UINT")] uint AlignedByteOffsetForArgs)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Buffer*, uint, void>)(lpVtbl[42]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pBufferForArgs, AlignedByteOffsetForArgs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public void RSSetState(ID3D11RasterizerState* pRasterizerState)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11RasterizerState*, void>)(lpVtbl[43]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pRasterizerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public void RSSetViewports([NativeTypeName("UINT")] uint NumViewports, [NativeTypeName("const D3D11_VIEWPORT *")] D3D11_VIEWPORT* pViewports)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, D3D11_VIEWPORT*, void>)(lpVtbl[44]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public void RSSetScissorRects([NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D11_RECT *")] RECT* pRects)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, RECT*, void>)(lpVtbl[45]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), NumRects, pRects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public void CopySubresourceRegion(ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("UINT")] uint DstZ, ID3D11Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pSrcBox)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, D3D11_BOX*, void>)(lpVtbl[46]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public void CopyResource(ID3D11Resource* pDstResource, ID3D11Resource* pSrcResource)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Resource*, ID3D11Resource*, void>)(lpVtbl[47]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDstResource, pSrcResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public void UpdateSubresource(ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Resource*, uint, D3D11_BOX*, void*, uint, uint, void>)(lpVtbl[48]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public void CopyStructureCount(ID3D11Buffer* pDstBuffer, [NativeTypeName("UINT")] uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)(lpVtbl[49]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDstBuffer, DstAlignedByteOffset, pSrcView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public void ClearRenderTargetView(ID3D11RenderTargetView* pRenderTargetView, [NativeTypeName("const FLOAT [4]")] float* ColorRGBA)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11RenderTargetView*, float*, void>)(lpVtbl[50]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pRenderTargetView, ColorRGBA);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public void ClearUnorderedAccessViewUint(ID3D11UnorderedAccessView* pUnorderedAccessView, [NativeTypeName("const UINT [4]")] uint* Values)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11UnorderedAccessView*, uint*, void>)(lpVtbl[51]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pUnorderedAccessView, Values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public void ClearUnorderedAccessViewFloat(ID3D11UnorderedAccessView* pUnorderedAccessView, [NativeTypeName("const FLOAT [4]")] float* Values)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11UnorderedAccessView*, float*, void>)(lpVtbl[52]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pUnorderedAccessView, Values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public void ClearDepthStencilView(ID3D11DepthStencilView* pDepthStencilView, [NativeTypeName("UINT")] uint ClearFlags, [NativeTypeName("FLOAT")] float Depth, [NativeTypeName("UINT8")] byte Stencil)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11DepthStencilView*, uint, float, byte, void>)(lpVtbl[53]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDepthStencilView, ClearFlags, Depth, Stencil);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public void GenerateMips(ID3D11ShaderResourceView* pShaderResourceView)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11ShaderResourceView*, void>)(lpVtbl[54]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pShaderResourceView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public void SetResourceMinLOD(ID3D11Resource* pResource, [NativeTypeName("FLOAT")] float MinLOD)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Resource*, float, void>)(lpVtbl[55]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pResource, MinLOD);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("FLOAT")]
        public float GetResourceMinLOD(ID3D11Resource* pResource)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Resource*, float>)(lpVtbl[56]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public void ResolveSubresource(ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, ID3D11Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, DXGI_FORMAT Format)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Resource*, uint, ID3D11Resource*, uint, DXGI_FORMAT, void>)(lpVtbl[57]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public void ExecuteCommandList(ID3D11CommandList* pCommandList, BOOL RestoreContextState)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11CommandList*, BOOL, void>)(lpVtbl[58]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pCommandList, RestoreContextState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public void HSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[59]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public void HSSetShader(ID3D11HullShader* pHullShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[60]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pHullShader, ppClassInstances, NumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public void HSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[61]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public void HSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[62]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public void DSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[63]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public void DSSetShader(ID3D11DomainShader* pDomainShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[64]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDomainShader, ppClassInstances, NumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public void DSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[65]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public void DSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[66]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public void CSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[67]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public void CSSetUnorderedAccessViews([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView *const *")] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [NativeTypeName("const UINT *")] uint* pUAVInitialCounts)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)(lpVtbl[68]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public void CSSetShader(ID3D11ComputeShader* pComputeShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT")] uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[69]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pComputeShader, ppClassInstances, NumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public void CSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[70]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public void CSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[71]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        public void VSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[72]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public void PSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[73]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public void PSGetShader(ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[74]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppPixelShader, ppClassInstances, pNumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public void PSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[75]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        public void VSGetShader(ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[76]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppVertexShader, ppClassInstances, pNumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        public void PSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[77]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        public void IAGetInputLayout(ID3D11InputLayout** ppInputLayout)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11InputLayout**, void>)(lpVtbl[78]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppInputLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        public void IAGetVertexBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, ID3D11Buffer** ppVertexBuffers, [NativeTypeName("UINT *")] uint* pStrides, [NativeTypeName("UINT *")] uint* pOffsets)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[79]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public void IAGetIndexBuffer(ID3D11Buffer** pIndexBuffer, DXGI_FORMAT* Format, [NativeTypeName("UINT *")] uint* Offset)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Buffer**, DXGI_FORMAT*, uint*, void>)(lpVtbl[80]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pIndexBuffer, Format, Offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        public void GSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[81]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        public void GSGetShader(ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[82]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppGeometryShader, ppClassInstances, pNumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        public void IAGetPrimitiveTopology([NativeTypeName("D3D11_PRIMITIVE_TOPOLOGY *")] D3D_PRIMITIVE_TOPOLOGY* pTopology)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, D3D_PRIMITIVE_TOPOLOGY*, void>)(lpVtbl[83]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pTopology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        public void VSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[84]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        public void VSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[85]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        public void GetPredication(ID3D11Predicate** ppPredicate, BOOL* pPredicateValue)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Predicate**, BOOL*, void>)(lpVtbl[86]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppPredicate, pPredicateValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        public void GSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[87]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        public void GSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[88]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        public void OMGetRenderTargets([NativeTypeName("UINT")] uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)(lpVtbl[89]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), NumViews, ppRenderTargetViews, ppDepthStencilView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        public void OMGetRenderTargetsAndUnorderedAccessViews([NativeTypeName("UINT")] uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, [NativeTypeName("UINT")] uint UAVStartSlot, [NativeTypeName("UINT")] uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)(lpVtbl[90]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        public void OMGetBlendState(ID3D11BlendState** ppBlendState, [NativeTypeName("FLOAT [4]")] float* BlendFactor, [NativeTypeName("UINT *")] uint* pSampleMask)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11BlendState**, float*, uint*, void>)(lpVtbl[91]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppBlendState, BlendFactor, pSampleMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        public void OMGetDepthStencilState(ID3D11DepthStencilState** ppDepthStencilState, [NativeTypeName("UINT *")] uint* pStencilRef)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11DepthStencilState**, uint*, void>)(lpVtbl[92]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppDepthStencilState, pStencilRef);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        public void SOGetTargets([NativeTypeName("UINT")] uint NumBuffers, ID3D11Buffer** ppSOTargets)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, ID3D11Buffer**, void>)(lpVtbl[93]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), NumBuffers, ppSOTargets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        public void RSGetState(ID3D11RasterizerState** ppRasterizerState)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11RasterizerState**, void>)(lpVtbl[94]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppRasterizerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        public void RSGetViewports([NativeTypeName("UINT *")] uint* pNumViewports, D3D11_VIEWPORT* pViewports)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint*, D3D11_VIEWPORT*, void>)(lpVtbl[95]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pNumViewports, pViewports);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        public void RSGetScissorRects([NativeTypeName("UINT *")] uint* pNumRects, [NativeTypeName("D3D11_RECT *")] RECT* pRects)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint*, RECT*, void>)(lpVtbl[96]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pNumRects, pRects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        public void HSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[97]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        public void HSGetShader(ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[98]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppHullShader, ppClassInstances, pNumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        public void HSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[99]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        public void HSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[100]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        public void DSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[101]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        public void DSGetShader(ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[102]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppDomainShader, ppClassInstances, pNumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        public void DSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[103]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        public void DSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[104]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        public void CSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[105]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        public void CSGetUnorderedAccessViews([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11UnorderedAccessView**, void>)(lpVtbl[106]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumUAVs, ppUnorderedAccessViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        public void CSGetShader(ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, [NativeTypeName("UINT *")] uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[107]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ppComputeShader, ppClassInstances, pNumClassInstances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        public void CSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[108]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        public void CSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[109]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        public void ClearState()
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, void>)(lpVtbl[110]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(111)]
        public void Flush()
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, void>)(lpVtbl[111]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(112)]
        public new D3D11_DEVICE_CONTEXT_TYPE GetType()
        {
            return ((delegate* unmanaged<ID3D11DeviceContext3*, D3D11_DEVICE_CONTEXT_TYPE>)(lpVtbl[112]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(113)]
        [return: NativeTypeName("UINT")]
        public uint GetContextFlags()
        {
            return ((delegate* unmanaged<ID3D11DeviceContext3*, uint>)(lpVtbl[113]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(114)]
        [return: NativeTypeName("HRESULT")]
        public int FinishCommandList(BOOL RestoreDeferredContextState, ID3D11CommandList** ppCommandList)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext3*, BOOL, ID3D11CommandList**, int>)(lpVtbl[114]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), RestoreDeferredContextState, ppCommandList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(115)]
        public void CopySubresourceRegion1(ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("UINT")] uint DstZ, ID3D11Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pSrcBox, [NativeTypeName("UINT")] uint CopyFlags)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, D3D11_BOX*, uint, void>)(lpVtbl[115]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(116)]
        public void UpdateSubresource1(ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch, [NativeTypeName("UINT")] uint CopyFlags)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Resource*, uint, D3D11_BOX*, void*, uint, uint, uint, void>)(lpVtbl[116]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(117)]
        public void DiscardResource(ID3D11Resource* pResource)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Resource*, void>)(lpVtbl[117]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(118)]
        public void DiscardView(ID3D11View* pResourceView)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11View*, void>)(lpVtbl[118]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pResourceView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(119)]
        public void VSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[119]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(120)]
        public void HSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[120]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(121)]
        public void DSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[121]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(122)]
        public void GSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[122]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(123)]
        public void PSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[123]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(124)]
        public void CSSetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers, [NativeTypeName("const UINT *")] uint* pFirstConstant, [NativeTypeName("const UINT *")] uint* pNumConstants)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[124]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(125)]
        public void VSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[125]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(126)]
        public void HSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[126]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(127)]
        public void DSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[127]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(128)]
        public void GSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[128]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(129)]
        public void PSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[129]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(130)]
        public void CSGetConstantBuffers1([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, ID3D11Buffer** ppConstantBuffers, [NativeTypeName("UINT *")] uint* pFirstConstant, [NativeTypeName("UINT *")] uint* pNumConstants)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[130]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(131)]
        public void SwapDeviceContextState(ID3DDeviceContextState* pState, ID3DDeviceContextState** ppPreviousState)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)(lpVtbl[131]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pState, ppPreviousState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(132)]
        public void ClearView(ID3D11View* pView, [NativeTypeName("const FLOAT [4]")] float* Color, [NativeTypeName("const D3D11_RECT *")] RECT* pRect, [NativeTypeName("UINT")] uint NumRects)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11View*, float*, RECT*, uint, void>)(lpVtbl[132]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pView, Color, pRect, NumRects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(133)]
        public void DiscardView1(ID3D11View* pResourceView, [NativeTypeName("const D3D11_RECT *")] RECT* pRects, [NativeTypeName("UINT")] uint NumRects)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11View*, RECT*, uint, void>)(lpVtbl[133]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pResourceView, pRects, NumRects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(134)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateTileMappings(ID3D11Resource* pTiledResource, [NativeTypeName("UINT")] uint NumTiledResourceRegions, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pTiledResourceRegionStartCoordinates, [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, [NativeTypeName("UINT")] uint NumRanges, [NativeTypeName("const UINT *")] uint* pRangeFlags, [NativeTypeName("const UINT *")] uint* pTilePoolStartOffsets, [NativeTypeName("const UINT *")] uint* pRangeTileCounts, [NativeTypeName("UINT")] uint Flags)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Resource*, uint, D3D11_TILED_RESOURCE_COORDINATE*, D3D11_TILE_REGION_SIZE*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)(lpVtbl[134]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(135)]
        [return: NativeTypeName("HRESULT")]
        public int CopyTileMappings(ID3D11Resource* pDestTiledResource, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pSourceRegionStartCoordinate, [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pTileRegionSize, [NativeTypeName("UINT")] uint Flags)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Resource*, D3D11_TILED_RESOURCE_COORDINATE*, ID3D11Resource*, D3D11_TILED_RESOURCE_COORDINATE*, D3D11_TILE_REGION_SIZE*, uint, int>)(lpVtbl[135]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(136)]
        public void CopyTiles(ID3D11Resource* pTiledResource, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate, [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pTileRegionSize, ID3D11Buffer* pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, [NativeTypeName("UINT")] uint Flags)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Resource*, D3D11_TILED_RESOURCE_COORDINATE*, D3D11_TILE_REGION_SIZE*, ID3D11Buffer*, ulong, uint, void>)(lpVtbl[136]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(137)]
        public void UpdateTiles(ID3D11Resource* pDestTiledResource, [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")] D3D11_TILED_RESOURCE_COORDINATE* pDestTileRegionStartCoordinate, [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pDestTileRegionSize, [NativeTypeName("const void *")] void* pSourceTileData, [NativeTypeName("UINT")] uint Flags)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Resource*, D3D11_TILED_RESOURCE_COORDINATE*, D3D11_TILE_REGION_SIZE*, void*, uint, void>)(lpVtbl[137]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pDestTiledResource, pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileData, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(138)]
        [return: NativeTypeName("HRESULT")]
        public int ResizeTilePool(ID3D11Buffer* pTilePool, [NativeTypeName("UINT64")] ulong NewSizeInBytes)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11Buffer*, ulong, int>)(lpVtbl[138]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pTilePool, NewSizeInBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(139)]
        public void TiledResourceBarrier(ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrier, ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrier)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ID3D11DeviceChild*, ID3D11DeviceChild*, void>)(lpVtbl[139]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pTiledResourceOrViewAccessBeforeBarrier, pTiledResourceOrViewAccessAfterBarrier);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(140)]
        public BOOL IsAnnotationEnabled()
        {
            return ((delegate* unmanaged<ID3D11DeviceContext3*, int>)(lpVtbl[140]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(141)]
        public void SetMarkerInt([NativeTypeName("LPCWSTR")] ushort* pLabel, [NativeTypeName("INT")] int Data)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ushort*, int, void>)(lpVtbl[141]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pLabel, Data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(142)]
        public void BeginEventInt([NativeTypeName("LPCWSTR")] ushort* pLabel, [NativeTypeName("INT")] int Data)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, ushort*, int, void>)(lpVtbl[142]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pLabel, Data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(143)]
        public void EndEvent()
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, void>)(lpVtbl[143]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(144)]
        public void Flush1(D3D11_CONTEXT_TYPE ContextType, [NativeTypeName("HANDLE")] IntPtr hEvent)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, D3D11_CONTEXT_TYPE, IntPtr, void>)(lpVtbl[144]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), ContextType, hEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(145)]
        public void SetHardwareProtectionState(BOOL HwProtectionEnable)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, BOOL, void>)(lpVtbl[145]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), HwProtectionEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(146)]
        public void GetHardwareProtectionState(BOOL* pHwProtectionEnable)
        {
            ((delegate* unmanaged<ID3D11DeviceContext3*, BOOL*, void>)(lpVtbl[146]))((ID3D11DeviceContext3*)Unsafe.AsPointer(ref this), pHwProtectionEnable);
        }
    }
}
