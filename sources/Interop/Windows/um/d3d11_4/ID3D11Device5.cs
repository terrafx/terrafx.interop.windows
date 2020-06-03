// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8FFDE202-A0E7-45DF-9E01-E837801B5EA0")]
    public unsafe partial struct ID3D11Device5
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D11Device5*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Device5*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D11Device5*, uint>)(lpVtbl[1]))((ID3D11Device5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D11Device5*, uint>)(lpVtbl[2]))((ID3D11Device5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBuffer([NativeTypeName("const D3D11_BUFFER_DESC *")] D3D11_BUFFER_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppBuffer)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_BUFFER_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Buffer**, int>)(lpVtbl[3]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTexture1D([NativeTypeName("const D3D11_TEXTURE1D_DESC *")] D3D11_TEXTURE1D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture1D **")] ID3D11Texture1D** ppTexture1D)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_TEXTURE1D_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Texture1D**, int>)(lpVtbl[4]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture1D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTexture2D([NativeTypeName("const D3D11_TEXTURE2D_DESC *")] D3D11_TEXTURE2D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture2D **")] ID3D11Texture2D** ppTexture2D)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_TEXTURE2D_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Texture2D**, int>)(lpVtbl[5]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture2D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTexture3D([NativeTypeName("const D3D11_TEXTURE3D_DESC *")] D3D11_TEXTURE3D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture3D **")] ID3D11Texture3D** ppTexture3D)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_TEXTURE3D_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Texture3D**, int>)(lpVtbl[6]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateShaderResourceView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_SHADER_RESOURCE_VIEW_DESC *")] D3D11_SHADER_RESOURCE_VIEW_DESC* pDesc, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppSRView)
        {
            return ((delegate* stdcall<ID3D11Device5*, ID3D11Resource*, D3D11_SHADER_RESOURCE_VIEW_DESC*, ID3D11ShaderResourceView**, int>)(lpVtbl[7]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pResource, pDesc, ppSRView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateUnorderedAccessView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_UNORDERED_ACCESS_VIEW_DESC *")] D3D11_UNORDERED_ACCESS_VIEW_DESC* pDesc, [NativeTypeName("ID3D11UnorderedAccessView **")] ID3D11UnorderedAccessView** ppUAView)
        {
            return ((delegate* stdcall<ID3D11Device5*, ID3D11Resource*, D3D11_UNORDERED_ACCESS_VIEW_DESC*, ID3D11UnorderedAccessView**, int>)(lpVtbl[8]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pResource, pDesc, ppUAView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRenderTargetView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_RENDER_TARGET_VIEW_DESC *")] D3D11_RENDER_TARGET_VIEW_DESC* pDesc, [NativeTypeName("ID3D11RenderTargetView **")] ID3D11RenderTargetView** ppRTView)
        {
            return ((delegate* stdcall<ID3D11Device5*, ID3D11Resource*, D3D11_RENDER_TARGET_VIEW_DESC*, ID3D11RenderTargetView**, int>)(lpVtbl[9]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pResource, pDesc, ppRTView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDepthStencilView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_DEPTH_STENCIL_VIEW_DESC *")] D3D11_DEPTH_STENCIL_VIEW_DESC* pDesc, [NativeTypeName("ID3D11DepthStencilView **")] ID3D11DepthStencilView** ppDepthStencilView)
        {
            return ((delegate* stdcall<ID3D11Device5*, ID3D11Resource*, D3D11_DEPTH_STENCIL_VIEW_DESC*, ID3D11DepthStencilView**, int>)(lpVtbl[10]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pResource, pDesc, ppDepthStencilView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInputLayout([NativeTypeName("const D3D11_INPUT_ELEMENT_DESC *")] D3D11_INPUT_ELEMENT_DESC* pInputElementDescs, [NativeTypeName("UINT")] uint NumElements, [NativeTypeName("const void *")] void* pShaderBytecodeWithInputSignature, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11InputLayout **")] ID3D11InputLayout** ppInputLayout)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_INPUT_ELEMENT_DESC*, uint, void*, nuint, ID3D11InputLayout**, int>)(lpVtbl[11]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pInputElementDescs, NumElements, pShaderBytecodeWithInputSignature, BytecodeLength, ppInputLayout);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVertexShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11VertexShader **")] ID3D11VertexShader** ppVertexShader)
        {
            return ((delegate* stdcall<ID3D11Device5*, void*, nuint, ID3D11ClassLinkage*, ID3D11VertexShader**, int>)(lpVtbl[12]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppVertexShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11GeometryShader **")] ID3D11GeometryShader** ppGeometryShader)
        {
            return ((delegate* stdcall<ID3D11Device5*, void*, nuint, ID3D11ClassLinkage*, ID3D11GeometryShader**, int>)(lpVtbl[13]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppGeometryShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryShaderWithStreamOutput([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("const D3D11_SO_DECLARATION_ENTRY *")] D3D11_SO_DECLARATION_ENTRY* pSODeclaration, [NativeTypeName("UINT")] uint NumEntries, [NativeTypeName("const UINT *")] uint* pBufferStrides, [NativeTypeName("UINT")] uint NumStrides, [NativeTypeName("UINT")] uint RasterizedStream, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11GeometryShader **")] ID3D11GeometryShader** ppGeometryShader)
        {
            return ((delegate* stdcall<ID3D11Device5*, void*, nuint, D3D11_SO_DECLARATION_ENTRY*, uint, uint*, uint, uint, ID3D11ClassLinkage*, ID3D11GeometryShader**, int>)(lpVtbl[14]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pSODeclaration, NumEntries, pBufferStrides, NumStrides, RasterizedStream, pClassLinkage, ppGeometryShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePixelShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11PixelShader **")] ID3D11PixelShader** ppPixelShader)
        {
            return ((delegate* stdcall<ID3D11Device5*, void*, nuint, ID3D11ClassLinkage*, ID3D11PixelShader**, int>)(lpVtbl[15]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppPixelShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHullShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11HullShader **")] ID3D11HullShader** ppHullShader)
        {
            return ((delegate* stdcall<ID3D11Device5*, void*, nuint, ID3D11ClassLinkage*, ID3D11HullShader**, int>)(lpVtbl[16]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppHullShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDomainShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11DomainShader **")] ID3D11DomainShader** ppDomainShader)
        {
            return ((delegate* stdcall<ID3D11Device5*, void*, nuint, ID3D11ClassLinkage*, ID3D11DomainShader**, int>)(lpVtbl[17]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppDomainShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComputeShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11ComputeShader **")] ID3D11ComputeShader** ppComputeShader)
        {
            return ((delegate* stdcall<ID3D11Device5*, void*, nuint, ID3D11ClassLinkage*, ID3D11ComputeShader**, int>)(lpVtbl[18]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppComputeShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateClassLinkage([NativeTypeName("ID3D11ClassLinkage **")] ID3D11ClassLinkage** ppLinkage)
        {
            return ((delegate* stdcall<ID3D11Device5*, ID3D11ClassLinkage**, int>)(lpVtbl[19]))((ID3D11Device5*)Unsafe.AsPointer(ref this), ppLinkage);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlendState([NativeTypeName("const D3D11_BLEND_DESC *")] D3D11_BLEND_DESC* pBlendStateDesc, [NativeTypeName("ID3D11BlendState **")] ID3D11BlendState** ppBlendState)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_BLEND_DESC*, ID3D11BlendState**, int>)(lpVtbl[20]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pBlendStateDesc, ppBlendState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDepthStencilState([NativeTypeName("const D3D11_DEPTH_STENCIL_DESC *")] D3D11_DEPTH_STENCIL_DESC* pDepthStencilDesc, [NativeTypeName("ID3D11DepthStencilState **")] ID3D11DepthStencilState** ppDepthStencilState)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_DEPTH_STENCIL_DESC*, ID3D11DepthStencilState**, int>)(lpVtbl[21]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pDepthStencilDesc, ppDepthStencilState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRasterizerState([NativeTypeName("const D3D11_RASTERIZER_DESC *")] D3D11_RASTERIZER_DESC* pRasterizerDesc, [NativeTypeName("ID3D11RasterizerState **")] ID3D11RasterizerState** ppRasterizerState)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_RASTERIZER_DESC*, ID3D11RasterizerState**, int>)(lpVtbl[22]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pRasterizerDesc, ppRasterizerState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSamplerState([NativeTypeName("const D3D11_SAMPLER_DESC *")] D3D11_SAMPLER_DESC* pSamplerDesc, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplerState)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_SAMPLER_DESC*, ID3D11SamplerState**, int>)(lpVtbl[23]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pSamplerDesc, ppSamplerState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQuery([NativeTypeName("const D3D11_QUERY_DESC *")] D3D11_QUERY_DESC* pQueryDesc, [NativeTypeName("ID3D11Query **")] ID3D11Query** ppQuery)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_QUERY_DESC*, ID3D11Query**, int>)(lpVtbl[24]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pQueryDesc, ppQuery);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePredicate([NativeTypeName("const D3D11_QUERY_DESC *")] D3D11_QUERY_DESC* pPredicateDesc, [NativeTypeName("ID3D11Predicate **")] ID3D11Predicate** ppPredicate)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_QUERY_DESC*, ID3D11Predicate**, int>)(lpVtbl[25]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pPredicateDesc, ppPredicate);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCounter([NativeTypeName("const D3D11_COUNTER_DESC *")] D3D11_COUNTER_DESC* pCounterDesc, [NativeTypeName("ID3D11Counter **")] ID3D11Counter** ppCounter)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_COUNTER_DESC*, ID3D11Counter**, int>)(lpVtbl[26]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pCounterDesc, ppCounter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeferredContext([NativeTypeName("UINT")] uint ContextFlags, [NativeTypeName("ID3D11DeviceContext **")] ID3D11DeviceContext** ppDeferredContext)
        {
            return ((delegate* stdcall<ID3D11Device5*, uint, ID3D11DeviceContext**, int>)(lpVtbl[27]))((ID3D11Device5*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedResource([NativeTypeName("HANDLE")] IntPtr hResource, [NativeTypeName("const IID &")] Guid* ReturnedInterface, [NativeTypeName("void **")] void** ppResource)
        {
            return ((delegate* stdcall<ID3D11Device5*, IntPtr, Guid*, void**, int>)(lpVtbl[28]))((ID3D11Device5*)Unsafe.AsPointer(ref this), hResource, ReturnedInterface, ppResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFormatSupport(DXGI_FORMAT Format, [NativeTypeName("UINT *")] uint* pFormatSupport)
        {
            return ((delegate* stdcall<ID3D11Device5*, DXGI_FORMAT, uint*, int>)(lpVtbl[29]))((ID3D11Device5*)Unsafe.AsPointer(ref this), Format, pFormatSupport);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckMultisampleQualityLevels(DXGI_FORMAT Format, [NativeTypeName("UINT")] uint SampleCount, [NativeTypeName("UINT *")] uint* pNumQualityLevels)
        {
            return ((delegate* stdcall<ID3D11Device5*, DXGI_FORMAT, uint, uint*, int>)(lpVtbl[30]))((ID3D11Device5*)Unsafe.AsPointer(ref this), Format, SampleCount, pNumQualityLevels);
        }

        public void CheckCounterInfo([NativeTypeName("D3D11_COUNTER_INFO *")] D3D11_COUNTER_INFO* pCounterInfo)
        {
            ((delegate* stdcall<ID3D11Device5*, D3D11_COUNTER_INFO*, void>)(lpVtbl[31]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pCounterInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckCounter([NativeTypeName("const D3D11_COUNTER_DESC *")] D3D11_COUNTER_DESC* pDesc, [NativeTypeName("D3D11_COUNTER_TYPE *")] D3D11_COUNTER_TYPE* pType, [NativeTypeName("UINT *")] uint* pActiveCounters, [NativeTypeName("LPSTR")] sbyte* szName, [NativeTypeName("UINT *")] uint* pNameLength, [NativeTypeName("LPSTR")] sbyte* szUnits, [NativeTypeName("UINT *")] uint* pUnitsLength, [NativeTypeName("LPSTR")] sbyte* szDescription, [NativeTypeName("UINT *")] uint* pDescriptionLength)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_COUNTER_DESC*, D3D11_COUNTER_TYPE*, uint*, sbyte*, uint*, sbyte*, uint*, sbyte*, uint*, int>)(lpVtbl[32]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pDesc, pType, pActiveCounters, szName, pNameLength, szUnits, pUnitsLength, szDescription, pDescriptionLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D3D11_FEATURE Feature, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_FEATURE, void*, uint, int>)(lpVtbl[33]))((ID3D11Device5*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D11Device5*, Guid*, uint*, void*, int>)(lpVtbl[34]))((ID3D11Device5*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D11Device5*, Guid*, uint, void*, int>)(lpVtbl[35]))((ID3D11Device5*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* stdcall<ID3D11Device5*, Guid*, IUnknown*, int>)(lpVtbl[36]))((ID3D11Device5*)Unsafe.AsPointer(ref this), guid, pData);
        }

        public D3D_FEATURE_LEVEL GetFeatureLevel()
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D_FEATURE_LEVEL>)(lpVtbl[37]))((ID3D11Device5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetCreationFlags()
        {
            return ((delegate* stdcall<ID3D11Device5*, uint>)(lpVtbl[38]))((ID3D11Device5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceRemovedReason()
        {
            return ((delegate* stdcall<ID3D11Device5*, int>)(lpVtbl[39]))((ID3D11Device5*)Unsafe.AsPointer(ref this));
        }

        public void GetImmediateContext([NativeTypeName("ID3D11DeviceContext **")] ID3D11DeviceContext** ppImmediateContext)
        {
            ((delegate* stdcall<ID3D11Device5*, ID3D11DeviceContext**, void>)(lpVtbl[40]))((ID3D11Device5*)Unsafe.AsPointer(ref this), ppImmediateContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetExceptionMode([NativeTypeName("UINT")] uint RaiseFlags)
        {
            return ((delegate* stdcall<ID3D11Device5*, uint, int>)(lpVtbl[41]))((ID3D11Device5*)Unsafe.AsPointer(ref this), RaiseFlags);
        }

        [return: NativeTypeName("UINT")]
        public uint GetExceptionMode()
        {
            return ((delegate* stdcall<ID3D11Device5*, uint>)(lpVtbl[42]))((ID3D11Device5*)Unsafe.AsPointer(ref this));
        }

        public void GetImmediateContext1([NativeTypeName("ID3D11DeviceContext1 **")] ID3D11DeviceContext1** ppImmediateContext)
        {
            ((delegate* stdcall<ID3D11Device5*, ID3D11DeviceContext1**, void>)(lpVtbl[43]))((ID3D11Device5*)Unsafe.AsPointer(ref this), ppImmediateContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeferredContext1([NativeTypeName("UINT")] uint ContextFlags, [NativeTypeName("ID3D11DeviceContext1 **")] ID3D11DeviceContext1** ppDeferredContext)
        {
            return ((delegate* stdcall<ID3D11Device5*, uint, ID3D11DeviceContext1**, int>)(lpVtbl[44]))((ID3D11Device5*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlendState1([NativeTypeName("const D3D11_BLEND_DESC1 *")] D3D11_BLEND_DESC1* pBlendStateDesc, [NativeTypeName("ID3D11BlendState1 **")] ID3D11BlendState1** ppBlendState)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_BLEND_DESC1*, ID3D11BlendState1**, int>)(lpVtbl[45]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pBlendStateDesc, ppBlendState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRasterizerState1([NativeTypeName("const D3D11_RASTERIZER_DESC1 *")] D3D11_RASTERIZER_DESC1* pRasterizerDesc, [NativeTypeName("ID3D11RasterizerState1 **")] ID3D11RasterizerState1** ppRasterizerState)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_RASTERIZER_DESC1*, ID3D11RasterizerState1**, int>)(lpVtbl[46]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pRasterizerDesc, ppRasterizerState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContextState([NativeTypeName("UINT")] uint Flags, [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels, [NativeTypeName("UINT")] uint FeatureLevels, [NativeTypeName("UINT")] uint SDKVersion, [NativeTypeName("const IID &")] Guid* EmulatedInterface, [NativeTypeName("D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pChosenFeatureLevel, [NativeTypeName("ID3DDeviceContextState **")] ID3DDeviceContextState** ppContextState)
        {
            return ((delegate* stdcall<ID3D11Device5*, uint, D3D_FEATURE_LEVEL*, uint, uint, Guid*, D3D_FEATURE_LEVEL*, ID3DDeviceContextState**, int>)(lpVtbl[47]))((ID3D11Device5*)Unsafe.AsPointer(ref this), Flags, pFeatureLevels, FeatureLevels, SDKVersion, EmulatedInterface, pChosenFeatureLevel, ppContextState);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedResource1([NativeTypeName("HANDLE")] IntPtr hResource, [NativeTypeName("const IID &")] Guid* returnedInterface, [NativeTypeName("void **")] void** ppResource)
        {
            return ((delegate* stdcall<ID3D11Device5*, IntPtr, Guid*, void**, int>)(lpVtbl[48]))((ID3D11Device5*)Unsafe.AsPointer(ref this), hResource, returnedInterface, ppResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedResourceByName([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("const IID &")] Guid* returnedInterface, [NativeTypeName("void **")] void** ppResource)
        {
            return ((delegate* stdcall<ID3D11Device5*, ushort*, uint, Guid*, void**, int>)(lpVtbl[49]))((ID3D11Device5*)Unsafe.AsPointer(ref this), lpName, dwDesiredAccess, returnedInterface, ppResource);
        }

        public void GetImmediateContext2([NativeTypeName("ID3D11DeviceContext2 **")] ID3D11DeviceContext2** ppImmediateContext)
        {
            ((delegate* stdcall<ID3D11Device5*, ID3D11DeviceContext2**, void>)(lpVtbl[50]))((ID3D11Device5*)Unsafe.AsPointer(ref this), ppImmediateContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeferredContext2([NativeTypeName("UINT")] uint ContextFlags, [NativeTypeName("ID3D11DeviceContext2 **")] ID3D11DeviceContext2** ppDeferredContext)
        {
            return ((delegate* stdcall<ID3D11Device5*, uint, ID3D11DeviceContext2**, int>)(lpVtbl[51]))((ID3D11Device5*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
        }

        public void GetResourceTiling([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pTiledResource, [NativeTypeName("UINT *")] uint* pNumTilesForEntireResource, [NativeTypeName("D3D11_PACKED_MIP_DESC *")] D3D11_PACKED_MIP_DESC* pPackedMipDesc, [NativeTypeName("D3D11_TILE_SHAPE *")] D3D11_TILE_SHAPE* pStandardTileShapeForNonPackedMips, [NativeTypeName("UINT *")] uint* pNumSubresourceTilings, [NativeTypeName("UINT")] uint FirstSubresourceTilingToGet, [NativeTypeName("D3D11_SUBRESOURCE_TILING *")] D3D11_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips)
        {
            ((delegate* stdcall<ID3D11Device5*, ID3D11Resource*, uint*, D3D11_PACKED_MIP_DESC*, D3D11_TILE_SHAPE*, uint*, uint, D3D11_SUBRESOURCE_TILING*, void>)(lpVtbl[52]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckMultisampleQualityLevels1(DXGI_FORMAT Format, [NativeTypeName("UINT")] uint SampleCount, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumQualityLevels)
        {
            return ((delegate* stdcall<ID3D11Device5*, DXGI_FORMAT, uint, uint, uint*, int>)(lpVtbl[53]))((ID3D11Device5*)Unsafe.AsPointer(ref this), Format, SampleCount, Flags, pNumQualityLevels);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTexture2D1([NativeTypeName("const D3D11_TEXTURE2D_DESC1 *")] D3D11_TEXTURE2D_DESC1* pDesc1, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture2D1 **")] ID3D11Texture2D1** ppTexture2D)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_TEXTURE2D_DESC1*, D3D11_SUBRESOURCE_DATA*, ID3D11Texture2D1**, int>)(lpVtbl[54]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pDesc1, pInitialData, ppTexture2D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTexture3D1([NativeTypeName("const D3D11_TEXTURE3D_DESC1 *")] D3D11_TEXTURE3D_DESC1* pDesc1, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture3D1 **")] ID3D11Texture3D1** ppTexture3D)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_TEXTURE3D_DESC1*, D3D11_SUBRESOURCE_DATA*, ID3D11Texture3D1**, int>)(lpVtbl[55]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pDesc1, pInitialData, ppTexture3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRasterizerState2([NativeTypeName("const D3D11_RASTERIZER_DESC2 *")] D3D11_RASTERIZER_DESC2* pRasterizerDesc, [NativeTypeName("ID3D11RasterizerState2 **")] ID3D11RasterizerState2** ppRasterizerState)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_RASTERIZER_DESC2*, ID3D11RasterizerState2**, int>)(lpVtbl[56]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pRasterizerDesc, ppRasterizerState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateShaderResourceView1([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_SHADER_RESOURCE_VIEW_DESC1 *")] D3D11_SHADER_RESOURCE_VIEW_DESC1* pDesc1, [NativeTypeName("ID3D11ShaderResourceView1 **")] ID3D11ShaderResourceView1** ppSRView1)
        {
            return ((delegate* stdcall<ID3D11Device5*, ID3D11Resource*, D3D11_SHADER_RESOURCE_VIEW_DESC1*, ID3D11ShaderResourceView1**, int>)(lpVtbl[57]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pResource, pDesc1, ppSRView1);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateUnorderedAccessView1([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_UNORDERED_ACCESS_VIEW_DESC1 *")] D3D11_UNORDERED_ACCESS_VIEW_DESC1* pDesc1, [NativeTypeName("ID3D11UnorderedAccessView1 **")] ID3D11UnorderedAccessView1** ppUAView1)
        {
            return ((delegate* stdcall<ID3D11Device5*, ID3D11Resource*, D3D11_UNORDERED_ACCESS_VIEW_DESC1*, ID3D11UnorderedAccessView1**, int>)(lpVtbl[58]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pResource, pDesc1, ppUAView1);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRenderTargetView1([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_RENDER_TARGET_VIEW_DESC1 *")] D3D11_RENDER_TARGET_VIEW_DESC1* pDesc1, [NativeTypeName("ID3D11RenderTargetView1 **")] ID3D11RenderTargetView1** ppRTView1)
        {
            return ((delegate* stdcall<ID3D11Device5*, ID3D11Resource*, D3D11_RENDER_TARGET_VIEW_DESC1*, ID3D11RenderTargetView1**, int>)(lpVtbl[59]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pResource, pDesc1, ppRTView1);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQuery1([NativeTypeName("const D3D11_QUERY_DESC1 *")] D3D11_QUERY_DESC1* pQueryDesc1, [NativeTypeName("ID3D11Query1 **")] ID3D11Query1** ppQuery1)
        {
            return ((delegate* stdcall<ID3D11Device5*, D3D11_QUERY_DESC1*, ID3D11Query1**, int>)(lpVtbl[60]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pQueryDesc1, ppQuery1);
        }

        public void GetImmediateContext3([NativeTypeName("ID3D11DeviceContext3 **")] ID3D11DeviceContext3** ppImmediateContext)
        {
            ((delegate* stdcall<ID3D11Device5*, ID3D11DeviceContext3**, void>)(lpVtbl[61]))((ID3D11Device5*)Unsafe.AsPointer(ref this), ppImmediateContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeferredContext3([NativeTypeName("UINT")] uint ContextFlags, [NativeTypeName("ID3D11DeviceContext3 **")] ID3D11DeviceContext3** ppDeferredContext)
        {
            return ((delegate* stdcall<ID3D11Device5*, uint, ID3D11DeviceContext3**, int>)(lpVtbl[62]))((ID3D11Device5*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
        }

        public void WriteToSubresource([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch)
        {
            ((delegate* stdcall<ID3D11Device5*, ID3D11Resource*, uint, D3D11_BOX*, void*, uint, uint, void>)(lpVtbl[63]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        public void ReadFromSubresource([NativeTypeName("void *")] void* pDstData, [NativeTypeName("UINT")] uint DstRowPitch, [NativeTypeName("UINT")] uint DstDepthPitch, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pSrcBox)
        {
            ((delegate* stdcall<ID3D11Device5*, void*, uint, uint, ID3D11Resource*, uint, D3D11_BOX*, void>)(lpVtbl[64]))((ID3D11Device5*)Unsafe.AsPointer(ref this), pDstData, DstRowPitch, DstDepthPitch, pSrcResource, SrcSubresource, pSrcBox);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterDeviceRemovedEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* stdcall<ID3D11Device5*, IntPtr, uint*, int>)(lpVtbl[65]))((ID3D11Device5*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        public void UnregisterDeviceRemoved([NativeTypeName("DWORD")] uint dwCookie)
        {
            ((delegate* stdcall<ID3D11Device5*, uint, void>)(lpVtbl[66]))((ID3D11Device5*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedFence([NativeTypeName("HANDLE")] IntPtr hFence, [NativeTypeName("const IID &")] Guid* ReturnedInterface, [NativeTypeName("void **")] void** ppFence)
        {
            return ((delegate* stdcall<ID3D11Device5*, IntPtr, Guid*, void**, int>)(lpVtbl[67]))((ID3D11Device5*)Unsafe.AsPointer(ref this), hFence, ReturnedInterface, ppFence);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFence([NativeTypeName("UINT64")] ulong InitialValue, D3D11_FENCE_FLAG Flags, [NativeTypeName("const IID &")] Guid* ReturnedInterface, [NativeTypeName("void **")] void** ppFence)
        {
            return ((delegate* stdcall<ID3D11Device5*, ulong, D3D11_FENCE_FLAG, Guid*, void**, int>)(lpVtbl[68]))((ID3D11Device5*)Unsafe.AsPointer(ref this), InitialValue, Flags, ReturnedInterface, ppFence);
        }
    }
}
