// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB6F6DDB-AC77-4E88-8253-819DF9BBF140")]
    [NativeTypeName("struct ID3D11Device : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11Device
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11Device*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Device*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11Device*, uint>)(lpVtbl[1]))((ID3D11Device*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11Device*, uint>)(lpVtbl[2]))((ID3D11Device*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateBuffer([NativeTypeName("const D3D11_BUFFER_DESC *")] D3D11_BUFFER_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Buffer** ppBuffer)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_BUFFER_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Buffer**, int>)(lpVtbl[3]))((ID3D11Device*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateTexture1D([NativeTypeName("const D3D11_TEXTURE1D_DESC *")] D3D11_TEXTURE1D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Texture1D** ppTexture1D)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_TEXTURE1D_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Texture1D**, int>)(lpVtbl[4]))((ID3D11Device*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture1D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreateTexture2D([NativeTypeName("const D3D11_TEXTURE2D_DESC *")] D3D11_TEXTURE2D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Texture2D** ppTexture2D)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_TEXTURE2D_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Texture2D**, int>)(lpVtbl[5]))((ID3D11Device*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture2D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateTexture3D([NativeTypeName("const D3D11_TEXTURE3D_DESC *")] D3D11_TEXTURE3D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Texture3D** ppTexture3D)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_TEXTURE3D_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Texture3D**, int>)(lpVtbl[6]))((ID3D11Device*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CreateShaderResourceView(ID3D11Resource* pResource, [NativeTypeName("const D3D11_SHADER_RESOURCE_VIEW_DESC *")] D3D11_SHADER_RESOURCE_VIEW_DESC* pDesc, ID3D11ShaderResourceView** ppSRView)
        {
            return ((delegate* unmanaged<ID3D11Device*, ID3D11Resource*, D3D11_SHADER_RESOURCE_VIEW_DESC*, ID3D11ShaderResourceView**, int>)(lpVtbl[7]))((ID3D11Device*)Unsafe.AsPointer(ref this), pResource, pDesc, ppSRView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT CreateUnorderedAccessView(ID3D11Resource* pResource, [NativeTypeName("const D3D11_UNORDERED_ACCESS_VIEW_DESC *")] D3D11_UNORDERED_ACCESS_VIEW_DESC* pDesc, ID3D11UnorderedAccessView** ppUAView)
        {
            return ((delegate* unmanaged<ID3D11Device*, ID3D11Resource*, D3D11_UNORDERED_ACCESS_VIEW_DESC*, ID3D11UnorderedAccessView**, int>)(lpVtbl[8]))((ID3D11Device*)Unsafe.AsPointer(ref this), pResource, pDesc, ppUAView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT CreateRenderTargetView(ID3D11Resource* pResource, [NativeTypeName("const D3D11_RENDER_TARGET_VIEW_DESC *")] D3D11_RENDER_TARGET_VIEW_DESC* pDesc, ID3D11RenderTargetView** ppRTView)
        {
            return ((delegate* unmanaged<ID3D11Device*, ID3D11Resource*, D3D11_RENDER_TARGET_VIEW_DESC*, ID3D11RenderTargetView**, int>)(lpVtbl[9]))((ID3D11Device*)Unsafe.AsPointer(ref this), pResource, pDesc, ppRTView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT CreateDepthStencilView(ID3D11Resource* pResource, [NativeTypeName("const D3D11_DEPTH_STENCIL_VIEW_DESC *")] D3D11_DEPTH_STENCIL_VIEW_DESC* pDesc, ID3D11DepthStencilView** ppDepthStencilView)
        {
            return ((delegate* unmanaged<ID3D11Device*, ID3D11Resource*, D3D11_DEPTH_STENCIL_VIEW_DESC*, ID3D11DepthStencilView**, int>)(lpVtbl[10]))((ID3D11Device*)Unsafe.AsPointer(ref this), pResource, pDesc, ppDepthStencilView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT CreateInputLayout([NativeTypeName("const D3D11_INPUT_ELEMENT_DESC *")] D3D11_INPUT_ELEMENT_DESC* pInputElementDescs, [NativeTypeName("UINT")] uint NumElements, [NativeTypeName("const void *")] void* pShaderBytecodeWithInputSignature, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D11InputLayout** ppInputLayout)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_INPUT_ELEMENT_DESC*, uint, void*, nuint, ID3D11InputLayout**, int>)(lpVtbl[11]))((ID3D11Device*)Unsafe.AsPointer(ref this), pInputElementDescs, NumElements, pShaderBytecodeWithInputSignature, BytecodeLength, ppInputLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT CreateVertexShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11VertexShader** ppVertexShader)
        {
            return ((delegate* unmanaged<ID3D11Device*, void*, nuint, ID3D11ClassLinkage*, ID3D11VertexShader**, int>)(lpVtbl[12]))((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppVertexShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT CreateGeometryShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11GeometryShader** ppGeometryShader)
        {
            return ((delegate* unmanaged<ID3D11Device*, void*, nuint, ID3D11ClassLinkage*, ID3D11GeometryShader**, int>)(lpVtbl[13]))((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppGeometryShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT CreateGeometryShaderWithStreamOutput([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("const D3D11_SO_DECLARATION_ENTRY *")] D3D11_SO_DECLARATION_ENTRY* pSODeclaration, [NativeTypeName("UINT")] uint NumEntries, [NativeTypeName("const UINT *")] uint* pBufferStrides, [NativeTypeName("UINT")] uint NumStrides, [NativeTypeName("UINT")] uint RasterizedStream, ID3D11ClassLinkage* pClassLinkage, ID3D11GeometryShader** ppGeometryShader)
        {
            return ((delegate* unmanaged<ID3D11Device*, void*, nuint, D3D11_SO_DECLARATION_ENTRY*, uint, uint*, uint, uint, ID3D11ClassLinkage*, ID3D11GeometryShader**, int>)(lpVtbl[14]))((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pSODeclaration, NumEntries, pBufferStrides, NumStrides, RasterizedStream, pClassLinkage, ppGeometryShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT CreatePixelShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11PixelShader** ppPixelShader)
        {
            return ((delegate* unmanaged<ID3D11Device*, void*, nuint, ID3D11ClassLinkage*, ID3D11PixelShader**, int>)(lpVtbl[15]))((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppPixelShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT CreateHullShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11HullShader** ppHullShader)
        {
            return ((delegate* unmanaged<ID3D11Device*, void*, nuint, ID3D11ClassLinkage*, ID3D11HullShader**, int>)(lpVtbl[16]))((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppHullShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT CreateDomainShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11DomainShader** ppDomainShader)
        {
            return ((delegate* unmanaged<ID3D11Device*, void*, nuint, ID3D11ClassLinkage*, ID3D11DomainShader**, int>)(lpVtbl[17]))((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppDomainShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT CreateComputeShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11ComputeShader** ppComputeShader)
        {
            return ((delegate* unmanaged<ID3D11Device*, void*, nuint, ID3D11ClassLinkage*, ID3D11ComputeShader**, int>)(lpVtbl[18]))((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppComputeShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT CreateClassLinkage(ID3D11ClassLinkage** ppLinkage)
        {
            return ((delegate* unmanaged<ID3D11Device*, ID3D11ClassLinkage**, int>)(lpVtbl[19]))((ID3D11Device*)Unsafe.AsPointer(ref this), ppLinkage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT CreateBlendState([NativeTypeName("const D3D11_BLEND_DESC *")] D3D11_BLEND_DESC* pBlendStateDesc, ID3D11BlendState** ppBlendState)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_BLEND_DESC*, ID3D11BlendState**, int>)(lpVtbl[20]))((ID3D11Device*)Unsafe.AsPointer(ref this), pBlendStateDesc, ppBlendState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT CreateDepthStencilState([NativeTypeName("const D3D11_DEPTH_STENCIL_DESC *")] D3D11_DEPTH_STENCIL_DESC* pDepthStencilDesc, ID3D11DepthStencilState** ppDepthStencilState)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_DEPTH_STENCIL_DESC*, ID3D11DepthStencilState**, int>)(lpVtbl[21]))((ID3D11Device*)Unsafe.AsPointer(ref this), pDepthStencilDesc, ppDepthStencilState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT CreateRasterizerState([NativeTypeName("const D3D11_RASTERIZER_DESC *")] D3D11_RASTERIZER_DESC* pRasterizerDesc, ID3D11RasterizerState** ppRasterizerState)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_RASTERIZER_DESC*, ID3D11RasterizerState**, int>)(lpVtbl[22]))((ID3D11Device*)Unsafe.AsPointer(ref this), pRasterizerDesc, ppRasterizerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT CreateSamplerState([NativeTypeName("const D3D11_SAMPLER_DESC *")] D3D11_SAMPLER_DESC* pSamplerDesc, ID3D11SamplerState** ppSamplerState)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_SAMPLER_DESC*, ID3D11SamplerState**, int>)(lpVtbl[23]))((ID3D11Device*)Unsafe.AsPointer(ref this), pSamplerDesc, ppSamplerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT CreateQuery([NativeTypeName("const D3D11_QUERY_DESC *")] D3D11_QUERY_DESC* pQueryDesc, ID3D11Query** ppQuery)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_QUERY_DESC*, ID3D11Query**, int>)(lpVtbl[24]))((ID3D11Device*)Unsafe.AsPointer(ref this), pQueryDesc, ppQuery);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT CreatePredicate([NativeTypeName("const D3D11_QUERY_DESC *")] D3D11_QUERY_DESC* pPredicateDesc, ID3D11Predicate** ppPredicate)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_QUERY_DESC*, ID3D11Predicate**, int>)(lpVtbl[25]))((ID3D11Device*)Unsafe.AsPointer(ref this), pPredicateDesc, ppPredicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT CreateCounter([NativeTypeName("const D3D11_COUNTER_DESC *")] D3D11_COUNTER_DESC* pCounterDesc, ID3D11Counter** ppCounter)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_COUNTER_DESC*, ID3D11Counter**, int>)(lpVtbl[26]))((ID3D11Device*)Unsafe.AsPointer(ref this), pCounterDesc, ppCounter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT CreateDeferredContext([NativeTypeName("UINT")] uint ContextFlags, ID3D11DeviceContext** ppDeferredContext)
        {
            return ((delegate* unmanaged<ID3D11Device*, uint, ID3D11DeviceContext**, int>)(lpVtbl[27]))((ID3D11Device*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT OpenSharedResource(HANDLE hResource, [NativeTypeName("const IID &")] Guid* ReturnedInterface, void** ppResource)
        {
            return ((delegate* unmanaged<ID3D11Device*, HANDLE, Guid*, void**, int>)(lpVtbl[28]))((ID3D11Device*)Unsafe.AsPointer(ref this), hResource, ReturnedInterface, ppResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT CheckFormatSupport(DXGI_FORMAT Format, [NativeTypeName("UINT *")] uint* pFormatSupport)
        {
            return ((delegate* unmanaged<ID3D11Device*, DXGI_FORMAT, uint*, int>)(lpVtbl[29]))((ID3D11Device*)Unsafe.AsPointer(ref this), Format, pFormatSupport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT CheckMultisampleQualityLevels(DXGI_FORMAT Format, [NativeTypeName("UINT")] uint SampleCount, [NativeTypeName("UINT *")] uint* pNumQualityLevels)
        {
            return ((delegate* unmanaged<ID3D11Device*, DXGI_FORMAT, uint, uint*, int>)(lpVtbl[30]))((ID3D11Device*)Unsafe.AsPointer(ref this), Format, SampleCount, pNumQualityLevels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public void CheckCounterInfo(D3D11_COUNTER_INFO* pCounterInfo)
        {
            ((delegate* unmanaged<ID3D11Device*, D3D11_COUNTER_INFO*, void>)(lpVtbl[31]))((ID3D11Device*)Unsafe.AsPointer(ref this), pCounterInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT CheckCounter([NativeTypeName("const D3D11_COUNTER_DESC *")] D3D11_COUNTER_DESC* pDesc, D3D11_COUNTER_TYPE* pType, [NativeTypeName("UINT *")] uint* pActiveCounters, [NativeTypeName("LPSTR")] sbyte* szName, [NativeTypeName("UINT *")] uint* pNameLength, [NativeTypeName("LPSTR")] sbyte* szUnits, [NativeTypeName("UINT *")] uint* pUnitsLength, [NativeTypeName("LPSTR")] sbyte* szDescription, [NativeTypeName("UINT *")] uint* pDescriptionLength)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_COUNTER_DESC*, D3D11_COUNTER_TYPE*, uint*, sbyte*, uint*, sbyte*, uint*, sbyte*, uint*, int>)(lpVtbl[32]))((ID3D11Device*)Unsafe.AsPointer(ref this), pDesc, pType, pActiveCounters, szName, pNameLength, szUnits, pUnitsLength, szDescription, pDescriptionLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT CheckFeatureSupport(D3D11_FEATURE Feature, void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_FEATURE, void*, uint, int>)(lpVtbl[33]))((ID3D11Device*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11Device*, Guid*, uint*, void*, int>)(lpVtbl[34]))((ID3D11Device*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11Device*, Guid*, uint, void*, int>)(lpVtbl[35]))((ID3D11Device*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11Device*, Guid*, IUnknown*, int>)(lpVtbl[36]))((ID3D11Device*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public D3D_FEATURE_LEVEL GetFeatureLevel()
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D_FEATURE_LEVEL>)(lpVtbl[37]))((ID3D11Device*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("UINT")]
        public uint GetCreationFlags()
        {
            return ((delegate* unmanaged<ID3D11Device*, uint>)(lpVtbl[38]))((ID3D11Device*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT GetDeviceRemovedReason()
        {
            return ((delegate* unmanaged<ID3D11Device*, int>)(lpVtbl[39]))((ID3D11Device*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public void GetImmediateContext(ID3D11DeviceContext** ppImmediateContext)
        {
            ((delegate* unmanaged<ID3D11Device*, ID3D11DeviceContext**, void>)(lpVtbl[40]))((ID3D11Device*)Unsafe.AsPointer(ref this), ppImmediateContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT SetExceptionMode([NativeTypeName("UINT")] uint RaiseFlags)
        {
            return ((delegate* unmanaged<ID3D11Device*, uint, int>)(lpVtbl[41]))((ID3D11Device*)Unsafe.AsPointer(ref this), RaiseFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("UINT")]
        public uint GetExceptionMode()
        {
            return ((delegate* unmanaged<ID3D11Device*, uint>)(lpVtbl[42]))((ID3D11Device*)Unsafe.AsPointer(ref this));
        }
    }
}
