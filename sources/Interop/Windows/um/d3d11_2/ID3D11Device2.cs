// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9D06DFFA-D1E5-4D07-83A8-1BB123F2F841")]
    [NativeTypeName("struct ID3D11Device2 : ID3D11Device1")]
    [NativeInheritance("ID3D11Device1")]
    public unsafe partial struct ID3D11Device2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11Device2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Device2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11Device2*, uint>)(lpVtbl[1]))((ID3D11Device2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11Device2*, uint>)(lpVtbl[2]))((ID3D11Device2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBuffer([NativeTypeName("const D3D11_BUFFER_DESC *")] D3D11_BUFFER_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Buffer** ppBuffer)
        {
            return ((delegate* unmanaged<ID3D11Device2*, D3D11_BUFFER_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Buffer**, int>)(lpVtbl[3]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTexture1D([NativeTypeName("const D3D11_TEXTURE1D_DESC *")] D3D11_TEXTURE1D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Texture1D** ppTexture1D)
        {
            return ((delegate* unmanaged<ID3D11Device2*, D3D11_TEXTURE1D_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Texture1D**, int>)(lpVtbl[4]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture1D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTexture2D([NativeTypeName("const D3D11_TEXTURE2D_DESC *")] D3D11_TEXTURE2D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Texture2D** ppTexture2D)
        {
            return ((delegate* unmanaged<ID3D11Device2*, D3D11_TEXTURE2D_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Texture2D**, int>)(lpVtbl[5]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture2D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTexture3D([NativeTypeName("const D3D11_TEXTURE3D_DESC *")] D3D11_TEXTURE3D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Texture3D** ppTexture3D)
        {
            return ((delegate* unmanaged<ID3D11Device2*, D3D11_TEXTURE3D_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Texture3D**, int>)(lpVtbl[6]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int CreateShaderResourceView(ID3D11Resource* pResource, [NativeTypeName("const D3D11_SHADER_RESOURCE_VIEW_DESC *")] D3D11_SHADER_RESOURCE_VIEW_DESC* pDesc, ID3D11ShaderResourceView** ppSRView)
        {
            return ((delegate* unmanaged<ID3D11Device2*, ID3D11Resource*, D3D11_SHADER_RESOURCE_VIEW_DESC*, ID3D11ShaderResourceView**, int>)(lpVtbl[7]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pResource, pDesc, ppSRView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int CreateUnorderedAccessView(ID3D11Resource* pResource, [NativeTypeName("const D3D11_UNORDERED_ACCESS_VIEW_DESC *")] D3D11_UNORDERED_ACCESS_VIEW_DESC* pDesc, ID3D11UnorderedAccessView** ppUAView)
        {
            return ((delegate* unmanaged<ID3D11Device2*, ID3D11Resource*, D3D11_UNORDERED_ACCESS_VIEW_DESC*, ID3D11UnorderedAccessView**, int>)(lpVtbl[8]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pResource, pDesc, ppUAView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRenderTargetView(ID3D11Resource* pResource, [NativeTypeName("const D3D11_RENDER_TARGET_VIEW_DESC *")] D3D11_RENDER_TARGET_VIEW_DESC* pDesc, ID3D11RenderTargetView** ppRTView)
        {
            return ((delegate* unmanaged<ID3D11Device2*, ID3D11Resource*, D3D11_RENDER_TARGET_VIEW_DESC*, ID3D11RenderTargetView**, int>)(lpVtbl[9]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pResource, pDesc, ppRTView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDepthStencilView(ID3D11Resource* pResource, [NativeTypeName("const D3D11_DEPTH_STENCIL_VIEW_DESC *")] D3D11_DEPTH_STENCIL_VIEW_DESC* pDesc, ID3D11DepthStencilView** ppDepthStencilView)
        {
            return ((delegate* unmanaged<ID3D11Device2*, ID3D11Resource*, D3D11_DEPTH_STENCIL_VIEW_DESC*, ID3D11DepthStencilView**, int>)(lpVtbl[10]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pResource, pDesc, ppDepthStencilView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInputLayout([NativeTypeName("const D3D11_INPUT_ELEMENT_DESC *")] D3D11_INPUT_ELEMENT_DESC* pInputElementDescs, [NativeTypeName("UINT")] uint NumElements, [NativeTypeName("const void *")] void* pShaderBytecodeWithInputSignature, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D11InputLayout** ppInputLayout)
        {
            return ((delegate* unmanaged<ID3D11Device2*, D3D11_INPUT_ELEMENT_DESC*, uint, void*, nuint, ID3D11InputLayout**, int>)(lpVtbl[11]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pInputElementDescs, NumElements, pShaderBytecodeWithInputSignature, BytecodeLength, ppInputLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVertexShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11VertexShader** ppVertexShader)
        {
            return ((delegate* unmanaged<ID3D11Device2*, void*, nuint, ID3D11ClassLinkage*, ID3D11VertexShader**, int>)(lpVtbl[12]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppVertexShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11GeometryShader** ppGeometryShader)
        {
            return ((delegate* unmanaged<ID3D11Device2*, void*, nuint, ID3D11ClassLinkage*, ID3D11GeometryShader**, int>)(lpVtbl[13]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppGeometryShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryShaderWithStreamOutput([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("const D3D11_SO_DECLARATION_ENTRY *")] D3D11_SO_DECLARATION_ENTRY* pSODeclaration, [NativeTypeName("UINT")] uint NumEntries, [NativeTypeName("const UINT *")] uint* pBufferStrides, [NativeTypeName("UINT")] uint NumStrides, [NativeTypeName("UINT")] uint RasterizedStream, ID3D11ClassLinkage* pClassLinkage, ID3D11GeometryShader** ppGeometryShader)
        {
            return ((delegate* unmanaged<ID3D11Device2*, void*, nuint, D3D11_SO_DECLARATION_ENTRY*, uint, uint*, uint, uint, ID3D11ClassLinkage*, ID3D11GeometryShader**, int>)(lpVtbl[14]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pSODeclaration, NumEntries, pBufferStrides, NumStrides, RasterizedStream, pClassLinkage, ppGeometryShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePixelShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11PixelShader** ppPixelShader)
        {
            return ((delegate* unmanaged<ID3D11Device2*, void*, nuint, ID3D11ClassLinkage*, ID3D11PixelShader**, int>)(lpVtbl[15]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppPixelShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int CreateHullShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11HullShader** ppHullShader)
        {
            return ((delegate* unmanaged<ID3D11Device2*, void*, nuint, ID3D11ClassLinkage*, ID3D11HullShader**, int>)(lpVtbl[16]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppHullShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDomainShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11DomainShader** ppDomainShader)
        {
            return ((delegate* unmanaged<ID3D11Device2*, void*, nuint, ID3D11ClassLinkage*, ID3D11DomainShader**, int>)(lpVtbl[17]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppDomainShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int CreateComputeShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11ComputeShader** ppComputeShader)
        {
            return ((delegate* unmanaged<ID3D11Device2*, void*, nuint, ID3D11ClassLinkage*, ID3D11ComputeShader**, int>)(lpVtbl[18]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppComputeShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int CreateClassLinkage(ID3D11ClassLinkage** ppLinkage)
        {
            return ((delegate* unmanaged<ID3D11Device2*, ID3D11ClassLinkage**, int>)(lpVtbl[19]))((ID3D11Device2*)Unsafe.AsPointer(ref this), ppLinkage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBlendState([NativeTypeName("const D3D11_BLEND_DESC *")] D3D11_BLEND_DESC* pBlendStateDesc, ID3D11BlendState** ppBlendState)
        {
            return ((delegate* unmanaged<ID3D11Device2*, D3D11_BLEND_DESC*, ID3D11BlendState**, int>)(lpVtbl[20]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pBlendStateDesc, ppBlendState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDepthStencilState([NativeTypeName("const D3D11_DEPTH_STENCIL_DESC *")] D3D11_DEPTH_STENCIL_DESC* pDepthStencilDesc, ID3D11DepthStencilState** ppDepthStencilState)
        {
            return ((delegate* unmanaged<ID3D11Device2*, D3D11_DEPTH_STENCIL_DESC*, ID3D11DepthStencilState**, int>)(lpVtbl[21]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pDepthStencilDesc, ppDepthStencilState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRasterizerState([NativeTypeName("const D3D11_RASTERIZER_DESC *")] D3D11_RASTERIZER_DESC* pRasterizerDesc, ID3D11RasterizerState** ppRasterizerState)
        {
            return ((delegate* unmanaged<ID3D11Device2*, D3D11_RASTERIZER_DESC*, ID3D11RasterizerState**, int>)(lpVtbl[22]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pRasterizerDesc, ppRasterizerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSamplerState([NativeTypeName("const D3D11_SAMPLER_DESC *")] D3D11_SAMPLER_DESC* pSamplerDesc, ID3D11SamplerState** ppSamplerState)
        {
            return ((delegate* unmanaged<ID3D11Device2*, D3D11_SAMPLER_DESC*, ID3D11SamplerState**, int>)(lpVtbl[23]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pSamplerDesc, ppSamplerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQuery([NativeTypeName("const D3D11_QUERY_DESC *")] D3D11_QUERY_DESC* pQueryDesc, ID3D11Query** ppQuery)
        {
            return ((delegate* unmanaged<ID3D11Device2*, D3D11_QUERY_DESC*, ID3D11Query**, int>)(lpVtbl[24]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pQueryDesc, ppQuery);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePredicate([NativeTypeName("const D3D11_QUERY_DESC *")] D3D11_QUERY_DESC* pPredicateDesc, ID3D11Predicate** ppPredicate)
        {
            return ((delegate* unmanaged<ID3D11Device2*, D3D11_QUERY_DESC*, ID3D11Predicate**, int>)(lpVtbl[25]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pPredicateDesc, ppPredicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCounter([NativeTypeName("const D3D11_COUNTER_DESC *")] D3D11_COUNTER_DESC* pCounterDesc, ID3D11Counter** ppCounter)
        {
            return ((delegate* unmanaged<ID3D11Device2*, D3D11_COUNTER_DESC*, ID3D11Counter**, int>)(lpVtbl[26]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pCounterDesc, ppCounter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDeferredContext([NativeTypeName("UINT")] uint ContextFlags, ID3D11DeviceContext** ppDeferredContext)
        {
            return ((delegate* unmanaged<ID3D11Device2*, uint, ID3D11DeviceContext**, int>)(lpVtbl[27]))((ID3D11Device2*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int OpenSharedResource([NativeTypeName("HANDLE")] IntPtr hResource, [NativeTypeName("const IID &")] Guid* ReturnedInterface, void** ppResource)
        {
            return ((delegate* unmanaged<ID3D11Device2*, IntPtr, Guid*, void**, int>)(lpVtbl[28]))((ID3D11Device2*)Unsafe.AsPointer(ref this), hResource, ReturnedInterface, ppResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int CheckFormatSupport(DXGI_FORMAT Format, [NativeTypeName("UINT *")] uint* pFormatSupport)
        {
            return ((delegate* unmanaged<ID3D11Device2*, DXGI_FORMAT, uint*, int>)(lpVtbl[29]))((ID3D11Device2*)Unsafe.AsPointer(ref this), Format, pFormatSupport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int CheckMultisampleQualityLevels(DXGI_FORMAT Format, [NativeTypeName("UINT")] uint SampleCount, [NativeTypeName("UINT *")] uint* pNumQualityLevels)
        {
            return ((delegate* unmanaged<ID3D11Device2*, DXGI_FORMAT, uint, uint*, int>)(lpVtbl[30]))((ID3D11Device2*)Unsafe.AsPointer(ref this), Format, SampleCount, pNumQualityLevels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public void CheckCounterInfo(D3D11_COUNTER_INFO* pCounterInfo)
        {
            ((delegate* unmanaged<ID3D11Device2*, D3D11_COUNTER_INFO*, void>)(lpVtbl[31]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pCounterInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int CheckCounter([NativeTypeName("const D3D11_COUNTER_DESC *")] D3D11_COUNTER_DESC* pDesc, D3D11_COUNTER_TYPE* pType, [NativeTypeName("UINT *")] uint* pActiveCounters, [NativeTypeName("LPSTR")] sbyte* szName, [NativeTypeName("UINT *")] uint* pNameLength, [NativeTypeName("LPSTR")] sbyte* szUnits, [NativeTypeName("UINT *")] uint* pUnitsLength, [NativeTypeName("LPSTR")] sbyte* szDescription, [NativeTypeName("UINT *")] uint* pDescriptionLength)
        {
            return ((delegate* unmanaged<ID3D11Device2*, D3D11_COUNTER_DESC*, D3D11_COUNTER_TYPE*, uint*, sbyte*, uint*, sbyte*, uint*, sbyte*, uint*, int>)(lpVtbl[32]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pDesc, pType, pActiveCounters, szName, pNameLength, szUnits, pUnitsLength, szDescription, pDescriptionLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D3D11_FEATURE Feature, void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return ((delegate* unmanaged<ID3D11Device2*, D3D11_FEATURE, void*, uint, int>)(lpVtbl[33]))((ID3D11Device2*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11Device2*, Guid*, uint*, void*, int>)(lpVtbl[34]))((ID3D11Device2*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11Device2*, Guid*, uint, void*, int>)(lpVtbl[35]))((ID3D11Device2*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11Device2*, Guid*, IUnknown*, int>)(lpVtbl[36]))((ID3D11Device2*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public D3D_FEATURE_LEVEL GetFeatureLevel()
        {
            return ((delegate* unmanaged<ID3D11Device2*, D3D_FEATURE_LEVEL>)(lpVtbl[37]))((ID3D11Device2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("UINT")]
        public uint GetCreationFlags()
        {
            return ((delegate* unmanaged<ID3D11Device2*, uint>)(lpVtbl[38]))((ID3D11Device2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceRemovedReason()
        {
            return ((delegate* unmanaged<ID3D11Device2*, int>)(lpVtbl[39]))((ID3D11Device2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public void GetImmediateContext(ID3D11DeviceContext** ppImmediateContext)
        {
            ((delegate* unmanaged<ID3D11Device2*, ID3D11DeviceContext**, void>)(lpVtbl[40]))((ID3D11Device2*)Unsafe.AsPointer(ref this), ppImmediateContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int SetExceptionMode([NativeTypeName("UINT")] uint RaiseFlags)
        {
            return ((delegate* unmanaged<ID3D11Device2*, uint, int>)(lpVtbl[41]))((ID3D11Device2*)Unsafe.AsPointer(ref this), RaiseFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("UINT")]
        public uint GetExceptionMode()
        {
            return ((delegate* unmanaged<ID3D11Device2*, uint>)(lpVtbl[42]))((ID3D11Device2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public void GetImmediateContext1(ID3D11DeviceContext1** ppImmediateContext)
        {
            ((delegate* unmanaged<ID3D11Device2*, ID3D11DeviceContext1**, void>)(lpVtbl[43]))((ID3D11Device2*)Unsafe.AsPointer(ref this), ppImmediateContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDeferredContext1([NativeTypeName("UINT")] uint ContextFlags, ID3D11DeviceContext1** ppDeferredContext)
        {
            return ((delegate* unmanaged<ID3D11Device2*, uint, ID3D11DeviceContext1**, int>)(lpVtbl[44]))((ID3D11Device2*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBlendState1([NativeTypeName("const D3D11_BLEND_DESC1 *")] D3D11_BLEND_DESC1* pBlendStateDesc, ID3D11BlendState1** ppBlendState)
        {
            return ((delegate* unmanaged<ID3D11Device2*, D3D11_BLEND_DESC1*, ID3D11BlendState1**, int>)(lpVtbl[45]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pBlendStateDesc, ppBlendState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRasterizerState1([NativeTypeName("const D3D11_RASTERIZER_DESC1 *")] D3D11_RASTERIZER_DESC1* pRasterizerDesc, ID3D11RasterizerState1** ppRasterizerState)
        {
            return ((delegate* unmanaged<ID3D11Device2*, D3D11_RASTERIZER_DESC1*, ID3D11RasterizerState1**, int>)(lpVtbl[46]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pRasterizerDesc, ppRasterizerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContextState([NativeTypeName("UINT")] uint Flags, [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels, [NativeTypeName("UINT")] uint FeatureLevels, [NativeTypeName("UINT")] uint SDKVersion, [NativeTypeName("const IID &")] Guid* EmulatedInterface, D3D_FEATURE_LEVEL* pChosenFeatureLevel, ID3DDeviceContextState** ppContextState)
        {
            return ((delegate* unmanaged<ID3D11Device2*, uint, D3D_FEATURE_LEVEL*, uint, uint, Guid*, D3D_FEATURE_LEVEL*, ID3DDeviceContextState**, int>)(lpVtbl[47]))((ID3D11Device2*)Unsafe.AsPointer(ref this), Flags, pFeatureLevels, FeatureLevels, SDKVersion, EmulatedInterface, pChosenFeatureLevel, ppContextState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int OpenSharedResource1([NativeTypeName("HANDLE")] IntPtr hResource, [NativeTypeName("const IID &")] Guid* returnedInterface, void** ppResource)
        {
            return ((delegate* unmanaged<ID3D11Device2*, IntPtr, Guid*, void**, int>)(lpVtbl[48]))((ID3D11Device2*)Unsafe.AsPointer(ref this), hResource, returnedInterface, ppResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int OpenSharedResourceByName([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("const IID &")] Guid* returnedInterface, void** ppResource)
        {
            return ((delegate* unmanaged<ID3D11Device2*, ushort*, uint, Guid*, void**, int>)(lpVtbl[49]))((ID3D11Device2*)Unsafe.AsPointer(ref this), lpName, dwDesiredAccess, returnedInterface, ppResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public void GetImmediateContext2(ID3D11DeviceContext2** ppImmediateContext)
        {
            ((delegate* unmanaged<ID3D11Device2*, ID3D11DeviceContext2**, void>)(lpVtbl[50]))((ID3D11Device2*)Unsafe.AsPointer(ref this), ppImmediateContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDeferredContext2([NativeTypeName("UINT")] uint ContextFlags, ID3D11DeviceContext2** ppDeferredContext)
        {
            return ((delegate* unmanaged<ID3D11Device2*, uint, ID3D11DeviceContext2**, int>)(lpVtbl[51]))((ID3D11Device2*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public void GetResourceTiling(ID3D11Resource* pTiledResource, [NativeTypeName("UINT *")] uint* pNumTilesForEntireResource, D3D11_PACKED_MIP_DESC* pPackedMipDesc, D3D11_TILE_SHAPE* pStandardTileShapeForNonPackedMips, [NativeTypeName("UINT *")] uint* pNumSubresourceTilings, [NativeTypeName("UINT")] uint FirstSubresourceTilingToGet, D3D11_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips)
        {
            ((delegate* unmanaged<ID3D11Device2*, ID3D11Resource*, uint*, D3D11_PACKED_MIP_DESC*, D3D11_TILE_SHAPE*, uint*, uint, D3D11_SUBRESOURCE_TILING*, void>)(lpVtbl[52]))((ID3D11Device2*)Unsafe.AsPointer(ref this), pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int CheckMultisampleQualityLevels1(DXGI_FORMAT Format, [NativeTypeName("UINT")] uint SampleCount, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumQualityLevels)
        {
            return ((delegate* unmanaged<ID3D11Device2*, DXGI_FORMAT, uint, uint, uint*, int>)(lpVtbl[53]))((ID3D11Device2*)Unsafe.AsPointer(ref this), Format, SampleCount, Flags, pNumQualityLevels);
        }
    }
}
