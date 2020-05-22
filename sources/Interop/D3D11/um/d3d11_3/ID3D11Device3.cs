// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A05C8C37-D2C6-4732-B3A0-9CE0B0DC9AE6")]
    public unsafe partial struct ID3D11Device3
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11Device3* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11Device3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11Device3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBuffer(ID3D11Device3* pThis, [NativeTypeName("const D3D11_BUFFER_DESC *")] D3D11_BUFFER_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppBuffer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTexture1D(ID3D11Device3* pThis, [NativeTypeName("const D3D11_TEXTURE1D_DESC *")] D3D11_TEXTURE1D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture1D **")] ID3D11Texture1D** ppTexture1D);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTexture2D(ID3D11Device3* pThis, [NativeTypeName("const D3D11_TEXTURE2D_DESC *")] D3D11_TEXTURE2D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture2D **")] ID3D11Texture2D** ppTexture2D);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTexture3D(ID3D11Device3* pThis, [NativeTypeName("const D3D11_TEXTURE3D_DESC *")] D3D11_TEXTURE3D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture3D **")] ID3D11Texture3D** ppTexture3D);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateShaderResourceView(ID3D11Device3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_SHADER_RESOURCE_VIEW_DESC *")] D3D11_SHADER_RESOURCE_VIEW_DESC* pDesc, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppSRView);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateUnorderedAccessView(ID3D11Device3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_UNORDERED_ACCESS_VIEW_DESC *")] D3D11_UNORDERED_ACCESS_VIEW_DESC* pDesc, [NativeTypeName("ID3D11UnorderedAccessView **")] ID3D11UnorderedAccessView** ppUAView);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRenderTargetView(ID3D11Device3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_RENDER_TARGET_VIEW_DESC *")] D3D11_RENDER_TARGET_VIEW_DESC* pDesc, [NativeTypeName("ID3D11RenderTargetView **")] ID3D11RenderTargetView** ppRTView);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDepthStencilView(ID3D11Device3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_DEPTH_STENCIL_VIEW_DESC *")] D3D11_DEPTH_STENCIL_VIEW_DESC* pDesc, [NativeTypeName("ID3D11DepthStencilView **")] ID3D11DepthStencilView** ppDepthStencilView);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInputLayout(ID3D11Device3* pThis, [NativeTypeName("const D3D11_INPUT_ELEMENT_DESC *")] D3D11_INPUT_ELEMENT_DESC* pInputElementDescs, [NativeTypeName("UINT")] uint NumElements, [NativeTypeName("const void *")] void* pShaderBytecodeWithInputSignature, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11InputLayout **")] ID3D11InputLayout** ppInputLayout);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVertexShader(ID3D11Device3* pThis, [NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11VertexShader **")] ID3D11VertexShader** ppVertexShader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGeometryShader(ID3D11Device3* pThis, [NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11GeometryShader **")] ID3D11GeometryShader** ppGeometryShader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGeometryShaderWithStreamOutput(ID3D11Device3* pThis, [NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("const D3D11_SO_DECLARATION_ENTRY *")] D3D11_SO_DECLARATION_ENTRY* pSODeclaration, [NativeTypeName("UINT")] uint NumEntries, [NativeTypeName("const UINT *")] uint* pBufferStrides, [NativeTypeName("UINT")] uint NumStrides, [NativeTypeName("UINT")] uint RasterizedStream, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11GeometryShader **")] ID3D11GeometryShader** ppGeometryShader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePixelShader(ID3D11Device3* pThis, [NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11PixelShader **")] ID3D11PixelShader** ppPixelShader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateHullShader(ID3D11Device3* pThis, [NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11HullShader **")] ID3D11HullShader** ppHullShader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDomainShader(ID3D11Device3* pThis, [NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11DomainShader **")] ID3D11DomainShader** ppDomainShader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateComputeShader(ID3D11Device3* pThis, [NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11ComputeShader **")] ID3D11ComputeShader** ppComputeShader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateClassLinkage(ID3D11Device3* pThis, [NativeTypeName("ID3D11ClassLinkage **")] ID3D11ClassLinkage** ppLinkage);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBlendState(ID3D11Device3* pThis, [NativeTypeName("const D3D11_BLEND_DESC *")] D3D11_BLEND_DESC* pBlendStateDesc, [NativeTypeName("ID3D11BlendState **")] ID3D11BlendState** ppBlendState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDepthStencilState(ID3D11Device3* pThis, [NativeTypeName("const D3D11_DEPTH_STENCIL_DESC *")] D3D11_DEPTH_STENCIL_DESC* pDepthStencilDesc, [NativeTypeName("ID3D11DepthStencilState **")] ID3D11DepthStencilState** ppDepthStencilState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRasterizerState(ID3D11Device3* pThis, [NativeTypeName("const D3D11_RASTERIZER_DESC *")] D3D11_RASTERIZER_DESC* pRasterizerDesc, [NativeTypeName("ID3D11RasterizerState **")] ID3D11RasterizerState** ppRasterizerState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSamplerState(ID3D11Device3* pThis, [NativeTypeName("const D3D11_SAMPLER_DESC *")] D3D11_SAMPLER_DESC* pSamplerDesc, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplerState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateQuery(ID3D11Device3* pThis, [NativeTypeName("const D3D11_QUERY_DESC *")] D3D11_QUERY_DESC* pQueryDesc, [NativeTypeName("ID3D11Query **")] ID3D11Query** ppQuery);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePredicate(ID3D11Device3* pThis, [NativeTypeName("const D3D11_QUERY_DESC *")] D3D11_QUERY_DESC* pPredicateDesc, [NativeTypeName("ID3D11Predicate **")] ID3D11Predicate** ppPredicate);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCounter(ID3D11Device3* pThis, [NativeTypeName("const D3D11_COUNTER_DESC *")] D3D11_COUNTER_DESC* pCounterDesc, [NativeTypeName("ID3D11Counter **")] ID3D11Counter** ppCounter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDeferredContext(ID3D11Device3* pThis, [NativeTypeName("UINT")] uint ContextFlags, [NativeTypeName("ID3D11DeviceContext **")] ID3D11DeviceContext** ppDeferredContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenSharedResource(ID3D11Device3* pThis, [NativeTypeName("HANDLE")] IntPtr hResource, [NativeTypeName("const IID &")] Guid* ReturnedInterface, [NativeTypeName("void **")] void** ppResource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckFormatSupport(ID3D11Device3* pThis, DXGI_FORMAT Format, [NativeTypeName("UINT *")] uint* pFormatSupport);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckMultisampleQualityLevels(ID3D11Device3* pThis, DXGI_FORMAT Format, [NativeTypeName("UINT")] uint SampleCount, [NativeTypeName("UINT *")] uint* pNumQualityLevels);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _CheckCounterInfo(ID3D11Device3* pThis, [NativeTypeName("D3D11_COUNTER_INFO *")] D3D11_COUNTER_INFO* pCounterInfo);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckCounter(ID3D11Device3* pThis, [NativeTypeName("const D3D11_COUNTER_DESC *")] D3D11_COUNTER_DESC* pDesc, [NativeTypeName("D3D11_COUNTER_TYPE *")] D3D11_COUNTER_TYPE* pType, [NativeTypeName("UINT *")] uint* pActiveCounters, [NativeTypeName("LPSTR")] sbyte* szName, [NativeTypeName("UINT *")] uint* pNameLength, [NativeTypeName("LPSTR")] sbyte* szUnits, [NativeTypeName("UINT *")] uint* pUnitsLength, [NativeTypeName("LPSTR")] sbyte* szDescription, [NativeTypeName("UINT *")] uint* pDescriptionLength);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckFeatureSupport(ID3D11Device3* pThis, D3D11_FEATURE Feature, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D11Device3* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D11Device3* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D11Device3* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D_FEATURE_LEVEL _GetFeatureLevel(ID3D11Device3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetCreationFlags(ID3D11Device3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceRemovedReason(ID3D11Device3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetImmediateContext(ID3D11Device3* pThis, [NativeTypeName("ID3D11DeviceContext **")] ID3D11DeviceContext** ppImmediateContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetExceptionMode(ID3D11Device3* pThis, [NativeTypeName("UINT")] uint RaiseFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetExceptionMode(ID3D11Device3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetImmediateContext1(ID3D11Device3* pThis, [NativeTypeName("ID3D11DeviceContext1 **")] ID3D11DeviceContext1** ppImmediateContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDeferredContext1(ID3D11Device3* pThis, [NativeTypeName("UINT")] uint ContextFlags, [NativeTypeName("ID3D11DeviceContext1 **")] ID3D11DeviceContext1** ppDeferredContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBlendState1(ID3D11Device3* pThis, [NativeTypeName("const D3D11_BLEND_DESC1 *")] D3D11_BLEND_DESC1* pBlendStateDesc, [NativeTypeName("ID3D11BlendState1 **")] ID3D11BlendState1** ppBlendState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRasterizerState1(ID3D11Device3* pThis, [NativeTypeName("const D3D11_RASTERIZER_DESC1 *")] D3D11_RASTERIZER_DESC1* pRasterizerDesc, [NativeTypeName("ID3D11RasterizerState1 **")] ID3D11RasterizerState1** ppRasterizerState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDeviceContextState(ID3D11Device3* pThis, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels, [NativeTypeName("UINT")] uint FeatureLevels, [NativeTypeName("UINT")] uint SDKVersion, [NativeTypeName("const IID &")] Guid* EmulatedInterface, [NativeTypeName("D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pChosenFeatureLevel, [NativeTypeName("ID3DDeviceContextState **")] ID3DDeviceContextState** ppContextState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenSharedResource1(ID3D11Device3* pThis, [NativeTypeName("HANDLE")] IntPtr hResource, [NativeTypeName("const IID &")] Guid* returnedInterface, [NativeTypeName("void **")] void** ppResource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenSharedResourceByName(ID3D11Device3* pThis, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("const IID &")] Guid* returnedInterface, [NativeTypeName("void **")] void** ppResource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetImmediateContext2(ID3D11Device3* pThis, [NativeTypeName("ID3D11DeviceContext2 **")] ID3D11DeviceContext2** ppImmediateContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDeferredContext2(ID3D11Device3* pThis, [NativeTypeName("UINT")] uint ContextFlags, [NativeTypeName("ID3D11DeviceContext2 **")] ID3D11DeviceContext2** ppDeferredContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetResourceTiling(ID3D11Device3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pTiledResource, [NativeTypeName("UINT *")] uint* pNumTilesForEntireResource, [NativeTypeName("D3D11_PACKED_MIP_DESC *")] D3D11_PACKED_MIP_DESC* pPackedMipDesc, [NativeTypeName("D3D11_TILE_SHAPE *")] D3D11_TILE_SHAPE* pStandardTileShapeForNonPackedMips, [NativeTypeName("UINT *")] uint* pNumSubresourceTilings, [NativeTypeName("UINT")] uint FirstSubresourceTilingToGet, [NativeTypeName("D3D11_SUBRESOURCE_TILING *")] D3D11_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckMultisampleQualityLevels1(ID3D11Device3* pThis, DXGI_FORMAT Format, [NativeTypeName("UINT")] uint SampleCount, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumQualityLevels);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTexture2D1(ID3D11Device3* pThis, [NativeTypeName("const D3D11_TEXTURE2D_DESC1 *")] D3D11_TEXTURE2D_DESC1* pDesc1, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture2D1 **")] ID3D11Texture2D1** ppTexture2D);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTexture3D1(ID3D11Device3* pThis, [NativeTypeName("const D3D11_TEXTURE3D_DESC1 *")] D3D11_TEXTURE3D_DESC1* pDesc1, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture3D1 **")] ID3D11Texture3D1** ppTexture3D);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRasterizerState2(ID3D11Device3* pThis, [NativeTypeName("const D3D11_RASTERIZER_DESC2 *")] D3D11_RASTERIZER_DESC2* pRasterizerDesc, [NativeTypeName("ID3D11RasterizerState2 **")] ID3D11RasterizerState2** ppRasterizerState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateShaderResourceView1(ID3D11Device3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_SHADER_RESOURCE_VIEW_DESC1 *")] D3D11_SHADER_RESOURCE_VIEW_DESC1* pDesc1, [NativeTypeName("ID3D11ShaderResourceView1 **")] ID3D11ShaderResourceView1** ppSRView1);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateUnorderedAccessView1(ID3D11Device3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_UNORDERED_ACCESS_VIEW_DESC1 *")] D3D11_UNORDERED_ACCESS_VIEW_DESC1* pDesc1, [NativeTypeName("ID3D11UnorderedAccessView1 **")] ID3D11UnorderedAccessView1** ppUAView1);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRenderTargetView1(ID3D11Device3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_RENDER_TARGET_VIEW_DESC1 *")] D3D11_RENDER_TARGET_VIEW_DESC1* pDesc1, [NativeTypeName("ID3D11RenderTargetView1 **")] ID3D11RenderTargetView1** ppRTView1);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateQuery1(ID3D11Device3* pThis, [NativeTypeName("const D3D11_QUERY_DESC1 *")] D3D11_QUERY_DESC1* pQueryDesc1, [NativeTypeName("ID3D11Query1 **")] ID3D11Query1** ppQuery1);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetImmediateContext3(ID3D11Device3* pThis, [NativeTypeName("ID3D11DeviceContext3 **")] ID3D11DeviceContext3** ppImmediateContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDeferredContext3(ID3D11Device3* pThis, [NativeTypeName("UINT")] uint ContextFlags, [NativeTypeName("ID3D11DeviceContext3 **")] ID3D11DeviceContext3** ppDeferredContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _WriteToSubresource(ID3D11Device3* pThis, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ReadFromSubresource(ID3D11Device3* pThis, [NativeTypeName("void *")] void* pDstData, [NativeTypeName("UINT")] uint DstRowPitch, [NativeTypeName("UINT")] uint DstDepthPitch, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pSrcBox);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11Device3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11Device3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11Device3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBuffer([NativeTypeName("const D3D11_BUFFER_DESC *")] D3D11_BUFFER_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppBuffer)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBuffer>(lpVtbl->CreateBuffer)((ID3D11Device3*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTexture1D([NativeTypeName("const D3D11_TEXTURE1D_DESC *")] D3D11_TEXTURE1D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture1D **")] ID3D11Texture1D** ppTexture1D)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTexture1D>(lpVtbl->CreateTexture1D)((ID3D11Device3*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture1D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTexture2D([NativeTypeName("const D3D11_TEXTURE2D_DESC *")] D3D11_TEXTURE2D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture2D **")] ID3D11Texture2D** ppTexture2D)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTexture2D>(lpVtbl->CreateTexture2D)((ID3D11Device3*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture2D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTexture3D([NativeTypeName("const D3D11_TEXTURE3D_DESC *")] D3D11_TEXTURE3D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture3D **")] ID3D11Texture3D** ppTexture3D)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTexture3D>(lpVtbl->CreateTexture3D)((ID3D11Device3*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateShaderResourceView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_SHADER_RESOURCE_VIEW_DESC *")] D3D11_SHADER_RESOURCE_VIEW_DESC* pDesc, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppSRView)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateShaderResourceView>(lpVtbl->CreateShaderResourceView)((ID3D11Device3*)Unsafe.AsPointer(ref this), pResource, pDesc, ppSRView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateUnorderedAccessView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_UNORDERED_ACCESS_VIEW_DESC *")] D3D11_UNORDERED_ACCESS_VIEW_DESC* pDesc, [NativeTypeName("ID3D11UnorderedAccessView **")] ID3D11UnorderedAccessView** ppUAView)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateUnorderedAccessView>(lpVtbl->CreateUnorderedAccessView)((ID3D11Device3*)Unsafe.AsPointer(ref this), pResource, pDesc, ppUAView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRenderTargetView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_RENDER_TARGET_VIEW_DESC *")] D3D11_RENDER_TARGET_VIEW_DESC* pDesc, [NativeTypeName("ID3D11RenderTargetView **")] ID3D11RenderTargetView** ppRTView)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRenderTargetView>(lpVtbl->CreateRenderTargetView)((ID3D11Device3*)Unsafe.AsPointer(ref this), pResource, pDesc, ppRTView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDepthStencilView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_DEPTH_STENCIL_VIEW_DESC *")] D3D11_DEPTH_STENCIL_VIEW_DESC* pDesc, [NativeTypeName("ID3D11DepthStencilView **")] ID3D11DepthStencilView** ppDepthStencilView)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDepthStencilView>(lpVtbl->CreateDepthStencilView)((ID3D11Device3*)Unsafe.AsPointer(ref this), pResource, pDesc, ppDepthStencilView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInputLayout([NativeTypeName("const D3D11_INPUT_ELEMENT_DESC *")] D3D11_INPUT_ELEMENT_DESC* pInputElementDescs, [NativeTypeName("UINT")] uint NumElements, [NativeTypeName("const void *")] void* pShaderBytecodeWithInputSignature, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11InputLayout **")] ID3D11InputLayout** ppInputLayout)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateInputLayout>(lpVtbl->CreateInputLayout)((ID3D11Device3*)Unsafe.AsPointer(ref this), pInputElementDescs, NumElements, pShaderBytecodeWithInputSignature, BytecodeLength, ppInputLayout);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVertexShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11VertexShader **")] ID3D11VertexShader** ppVertexShader)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVertexShader>(lpVtbl->CreateVertexShader)((ID3D11Device3*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppVertexShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11GeometryShader **")] ID3D11GeometryShader** ppGeometryShader)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateGeometryShader>(lpVtbl->CreateGeometryShader)((ID3D11Device3*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppGeometryShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryShaderWithStreamOutput([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("const D3D11_SO_DECLARATION_ENTRY *")] D3D11_SO_DECLARATION_ENTRY* pSODeclaration, [NativeTypeName("UINT")] uint NumEntries, [NativeTypeName("const UINT *")] uint* pBufferStrides, [NativeTypeName("UINT")] uint NumStrides, [NativeTypeName("UINT")] uint RasterizedStream, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11GeometryShader **")] ID3D11GeometryShader** ppGeometryShader)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateGeometryShaderWithStreamOutput>(lpVtbl->CreateGeometryShaderWithStreamOutput)((ID3D11Device3*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pSODeclaration, NumEntries, pBufferStrides, NumStrides, RasterizedStream, pClassLinkage, ppGeometryShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePixelShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11PixelShader **")] ID3D11PixelShader** ppPixelShader)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreatePixelShader>(lpVtbl->CreatePixelShader)((ID3D11Device3*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppPixelShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHullShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11HullShader **")] ID3D11HullShader** ppHullShader)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateHullShader>(lpVtbl->CreateHullShader)((ID3D11Device3*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppHullShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDomainShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11DomainShader **")] ID3D11DomainShader** ppDomainShader)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDomainShader>(lpVtbl->CreateDomainShader)((ID3D11Device3*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppDomainShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComputeShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11ComputeShader **")] ID3D11ComputeShader** ppComputeShader)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateComputeShader>(lpVtbl->CreateComputeShader)((ID3D11Device3*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppComputeShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateClassLinkage([NativeTypeName("ID3D11ClassLinkage **")] ID3D11ClassLinkage** ppLinkage)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateClassLinkage>(lpVtbl->CreateClassLinkage)((ID3D11Device3*)Unsafe.AsPointer(ref this), ppLinkage);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlendState([NativeTypeName("const D3D11_BLEND_DESC *")] D3D11_BLEND_DESC* pBlendStateDesc, [NativeTypeName("ID3D11BlendState **")] ID3D11BlendState** ppBlendState)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBlendState>(lpVtbl->CreateBlendState)((ID3D11Device3*)Unsafe.AsPointer(ref this), pBlendStateDesc, ppBlendState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDepthStencilState([NativeTypeName("const D3D11_DEPTH_STENCIL_DESC *")] D3D11_DEPTH_STENCIL_DESC* pDepthStencilDesc, [NativeTypeName("ID3D11DepthStencilState **")] ID3D11DepthStencilState** ppDepthStencilState)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDepthStencilState>(lpVtbl->CreateDepthStencilState)((ID3D11Device3*)Unsafe.AsPointer(ref this), pDepthStencilDesc, ppDepthStencilState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRasterizerState([NativeTypeName("const D3D11_RASTERIZER_DESC *")] D3D11_RASTERIZER_DESC* pRasterizerDesc, [NativeTypeName("ID3D11RasterizerState **")] ID3D11RasterizerState** ppRasterizerState)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRasterizerState>(lpVtbl->CreateRasterizerState)((ID3D11Device3*)Unsafe.AsPointer(ref this), pRasterizerDesc, ppRasterizerState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSamplerState([NativeTypeName("const D3D11_SAMPLER_DESC *")] D3D11_SAMPLER_DESC* pSamplerDesc, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplerState)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSamplerState>(lpVtbl->CreateSamplerState)((ID3D11Device3*)Unsafe.AsPointer(ref this), pSamplerDesc, ppSamplerState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQuery([NativeTypeName("const D3D11_QUERY_DESC *")] D3D11_QUERY_DESC* pQueryDesc, [NativeTypeName("ID3D11Query **")] ID3D11Query** ppQuery)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateQuery>(lpVtbl->CreateQuery)((ID3D11Device3*)Unsafe.AsPointer(ref this), pQueryDesc, ppQuery);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePredicate([NativeTypeName("const D3D11_QUERY_DESC *")] D3D11_QUERY_DESC* pPredicateDesc, [NativeTypeName("ID3D11Predicate **")] ID3D11Predicate** ppPredicate)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreatePredicate>(lpVtbl->CreatePredicate)((ID3D11Device3*)Unsafe.AsPointer(ref this), pPredicateDesc, ppPredicate);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCounter([NativeTypeName("const D3D11_COUNTER_DESC *")] D3D11_COUNTER_DESC* pCounterDesc, [NativeTypeName("ID3D11Counter **")] ID3D11Counter** ppCounter)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCounter>(lpVtbl->CreateCounter)((ID3D11Device3*)Unsafe.AsPointer(ref this), pCounterDesc, ppCounter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeferredContext([NativeTypeName("UINT")] uint ContextFlags, [NativeTypeName("ID3D11DeviceContext **")] ID3D11DeviceContext** ppDeferredContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDeferredContext>(lpVtbl->CreateDeferredContext)((ID3D11Device3*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedResource([NativeTypeName("HANDLE")] IntPtr hResource, [NativeTypeName("const IID &")] Guid* ReturnedInterface, [NativeTypeName("void **")] void** ppResource)
        {
            return Marshal.GetDelegateForFunctionPointer<_OpenSharedResource>(lpVtbl->OpenSharedResource)((ID3D11Device3*)Unsafe.AsPointer(ref this), hResource, ReturnedInterface, ppResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFormatSupport(DXGI_FORMAT Format, [NativeTypeName("UINT *")] uint* pFormatSupport)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckFormatSupport>(lpVtbl->CheckFormatSupport)((ID3D11Device3*)Unsafe.AsPointer(ref this), Format, pFormatSupport);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckMultisampleQualityLevels(DXGI_FORMAT Format, [NativeTypeName("UINT")] uint SampleCount, [NativeTypeName("UINT *")] uint* pNumQualityLevels)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckMultisampleQualityLevels>(lpVtbl->CheckMultisampleQualityLevels)((ID3D11Device3*)Unsafe.AsPointer(ref this), Format, SampleCount, pNumQualityLevels);
        }

        public void CheckCounterInfo([NativeTypeName("D3D11_COUNTER_INFO *")] D3D11_COUNTER_INFO* pCounterInfo)
        {
            Marshal.GetDelegateForFunctionPointer<_CheckCounterInfo>(lpVtbl->CheckCounterInfo)((ID3D11Device3*)Unsafe.AsPointer(ref this), pCounterInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckCounter([NativeTypeName("const D3D11_COUNTER_DESC *")] D3D11_COUNTER_DESC* pDesc, [NativeTypeName("D3D11_COUNTER_TYPE *")] D3D11_COUNTER_TYPE* pType, [NativeTypeName("UINT *")] uint* pActiveCounters, [NativeTypeName("LPSTR")] sbyte* szName, [NativeTypeName("UINT *")] uint* pNameLength, [NativeTypeName("LPSTR")] sbyte* szUnits, [NativeTypeName("UINT *")] uint* pUnitsLength, [NativeTypeName("LPSTR")] sbyte* szDescription, [NativeTypeName("UINT *")] uint* pDescriptionLength)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckCounter>(lpVtbl->CheckCounter)((ID3D11Device3*)Unsafe.AsPointer(ref this), pDesc, pType, pActiveCounters, szName, pNameLength, szUnits, pUnitsLength, szDescription, pDescriptionLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D3D11_FEATURE Feature, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckFeatureSupport>(lpVtbl->CheckFeatureSupport)((ID3D11Device3*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((ID3D11Device3*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((ID3D11Device3*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((ID3D11Device3*)Unsafe.AsPointer(ref this), guid, pData);
        }

        public D3D_FEATURE_LEVEL GetFeatureLevel()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFeatureLevel>(lpVtbl->GetFeatureLevel)((ID3D11Device3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetCreationFlags()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCreationFlags>(lpVtbl->GetCreationFlags)((ID3D11Device3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceRemovedReason()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDeviceRemovedReason>(lpVtbl->GetDeviceRemovedReason)((ID3D11Device3*)Unsafe.AsPointer(ref this));
        }

        public void GetImmediateContext([NativeTypeName("ID3D11DeviceContext **")] ID3D11DeviceContext** ppImmediateContext)
        {
            Marshal.GetDelegateForFunctionPointer<_GetImmediateContext>(lpVtbl->GetImmediateContext)((ID3D11Device3*)Unsafe.AsPointer(ref this), ppImmediateContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetExceptionMode([NativeTypeName("UINT")] uint RaiseFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetExceptionMode>(lpVtbl->SetExceptionMode)((ID3D11Device3*)Unsafe.AsPointer(ref this), RaiseFlags);
        }

        [return: NativeTypeName("UINT")]
        public uint GetExceptionMode()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetExceptionMode>(lpVtbl->GetExceptionMode)((ID3D11Device3*)Unsafe.AsPointer(ref this));
        }

        public void GetImmediateContext1([NativeTypeName("ID3D11DeviceContext1 **")] ID3D11DeviceContext1** ppImmediateContext)
        {
            Marshal.GetDelegateForFunctionPointer<_GetImmediateContext1>(lpVtbl->GetImmediateContext1)((ID3D11Device3*)Unsafe.AsPointer(ref this), ppImmediateContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeferredContext1([NativeTypeName("UINT")] uint ContextFlags, [NativeTypeName("ID3D11DeviceContext1 **")] ID3D11DeviceContext1** ppDeferredContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDeferredContext1>(lpVtbl->CreateDeferredContext1)((ID3D11Device3*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlendState1([NativeTypeName("const D3D11_BLEND_DESC1 *")] D3D11_BLEND_DESC1* pBlendStateDesc, [NativeTypeName("ID3D11BlendState1 **")] ID3D11BlendState1** ppBlendState)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBlendState1>(lpVtbl->CreateBlendState1)((ID3D11Device3*)Unsafe.AsPointer(ref this), pBlendStateDesc, ppBlendState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRasterizerState1([NativeTypeName("const D3D11_RASTERIZER_DESC1 *")] D3D11_RASTERIZER_DESC1* pRasterizerDesc, [NativeTypeName("ID3D11RasterizerState1 **")] ID3D11RasterizerState1** ppRasterizerState)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRasterizerState1>(lpVtbl->CreateRasterizerState1)((ID3D11Device3*)Unsafe.AsPointer(ref this), pRasterizerDesc, ppRasterizerState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContextState([NativeTypeName("UINT")] uint Flags, [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels, [NativeTypeName("UINT")] uint FeatureLevels, [NativeTypeName("UINT")] uint SDKVersion, [NativeTypeName("const IID &")] Guid* EmulatedInterface, [NativeTypeName("D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pChosenFeatureLevel, [NativeTypeName("ID3DDeviceContextState **")] ID3DDeviceContextState** ppContextState)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDeviceContextState>(lpVtbl->CreateDeviceContextState)((ID3D11Device3*)Unsafe.AsPointer(ref this), Flags, pFeatureLevels, FeatureLevels, SDKVersion, EmulatedInterface, pChosenFeatureLevel, ppContextState);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedResource1([NativeTypeName("HANDLE")] IntPtr hResource, [NativeTypeName("const IID &")] Guid* returnedInterface, [NativeTypeName("void **")] void** ppResource)
        {
            return Marshal.GetDelegateForFunctionPointer<_OpenSharedResource1>(lpVtbl->OpenSharedResource1)((ID3D11Device3*)Unsafe.AsPointer(ref this), hResource, returnedInterface, ppResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedResourceByName([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("const IID &")] Guid* returnedInterface, [NativeTypeName("void **")] void** ppResource)
        {
            return Marshal.GetDelegateForFunctionPointer<_OpenSharedResourceByName>(lpVtbl->OpenSharedResourceByName)((ID3D11Device3*)Unsafe.AsPointer(ref this), lpName, dwDesiredAccess, returnedInterface, ppResource);
        }

        public void GetImmediateContext2([NativeTypeName("ID3D11DeviceContext2 **")] ID3D11DeviceContext2** ppImmediateContext)
        {
            Marshal.GetDelegateForFunctionPointer<_GetImmediateContext2>(lpVtbl->GetImmediateContext2)((ID3D11Device3*)Unsafe.AsPointer(ref this), ppImmediateContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeferredContext2([NativeTypeName("UINT")] uint ContextFlags, [NativeTypeName("ID3D11DeviceContext2 **")] ID3D11DeviceContext2** ppDeferredContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDeferredContext2>(lpVtbl->CreateDeferredContext2)((ID3D11Device3*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
        }

        public void GetResourceTiling([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pTiledResource, [NativeTypeName("UINT *")] uint* pNumTilesForEntireResource, [NativeTypeName("D3D11_PACKED_MIP_DESC *")] D3D11_PACKED_MIP_DESC* pPackedMipDesc, [NativeTypeName("D3D11_TILE_SHAPE *")] D3D11_TILE_SHAPE* pStandardTileShapeForNonPackedMips, [NativeTypeName("UINT *")] uint* pNumSubresourceTilings, [NativeTypeName("UINT")] uint FirstSubresourceTilingToGet, [NativeTypeName("D3D11_SUBRESOURCE_TILING *")] D3D11_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips)
        {
            Marshal.GetDelegateForFunctionPointer<_GetResourceTiling>(lpVtbl->GetResourceTiling)((ID3D11Device3*)Unsafe.AsPointer(ref this), pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckMultisampleQualityLevels1(DXGI_FORMAT Format, [NativeTypeName("UINT")] uint SampleCount, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumQualityLevels)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckMultisampleQualityLevels1>(lpVtbl->CheckMultisampleQualityLevels1)((ID3D11Device3*)Unsafe.AsPointer(ref this), Format, SampleCount, Flags, pNumQualityLevels);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTexture2D1([NativeTypeName("const D3D11_TEXTURE2D_DESC1 *")] D3D11_TEXTURE2D_DESC1* pDesc1, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture2D1 **")] ID3D11Texture2D1** ppTexture2D)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTexture2D1>(lpVtbl->CreateTexture2D1)((ID3D11Device3*)Unsafe.AsPointer(ref this), pDesc1, pInitialData, ppTexture2D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTexture3D1([NativeTypeName("const D3D11_TEXTURE3D_DESC1 *")] D3D11_TEXTURE3D_DESC1* pDesc1, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture3D1 **")] ID3D11Texture3D1** ppTexture3D)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTexture3D1>(lpVtbl->CreateTexture3D1)((ID3D11Device3*)Unsafe.AsPointer(ref this), pDesc1, pInitialData, ppTexture3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRasterizerState2([NativeTypeName("const D3D11_RASTERIZER_DESC2 *")] D3D11_RASTERIZER_DESC2* pRasterizerDesc, [NativeTypeName("ID3D11RasterizerState2 **")] ID3D11RasterizerState2** ppRasterizerState)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRasterizerState2>(lpVtbl->CreateRasterizerState2)((ID3D11Device3*)Unsafe.AsPointer(ref this), pRasterizerDesc, ppRasterizerState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateShaderResourceView1([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_SHADER_RESOURCE_VIEW_DESC1 *")] D3D11_SHADER_RESOURCE_VIEW_DESC1* pDesc1, [NativeTypeName("ID3D11ShaderResourceView1 **")] ID3D11ShaderResourceView1** ppSRView1)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateShaderResourceView1>(lpVtbl->CreateShaderResourceView1)((ID3D11Device3*)Unsafe.AsPointer(ref this), pResource, pDesc1, ppSRView1);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateUnorderedAccessView1([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_UNORDERED_ACCESS_VIEW_DESC1 *")] D3D11_UNORDERED_ACCESS_VIEW_DESC1* pDesc1, [NativeTypeName("ID3D11UnorderedAccessView1 **")] ID3D11UnorderedAccessView1** ppUAView1)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateUnorderedAccessView1>(lpVtbl->CreateUnorderedAccessView1)((ID3D11Device3*)Unsafe.AsPointer(ref this), pResource, pDesc1, ppUAView1);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRenderTargetView1([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_RENDER_TARGET_VIEW_DESC1 *")] D3D11_RENDER_TARGET_VIEW_DESC1* pDesc1, [NativeTypeName("ID3D11RenderTargetView1 **")] ID3D11RenderTargetView1** ppRTView1)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRenderTargetView1>(lpVtbl->CreateRenderTargetView1)((ID3D11Device3*)Unsafe.AsPointer(ref this), pResource, pDesc1, ppRTView1);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQuery1([NativeTypeName("const D3D11_QUERY_DESC1 *")] D3D11_QUERY_DESC1* pQueryDesc1, [NativeTypeName("ID3D11Query1 **")] ID3D11Query1** ppQuery1)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateQuery1>(lpVtbl->CreateQuery1)((ID3D11Device3*)Unsafe.AsPointer(ref this), pQueryDesc1, ppQuery1);
        }

        public void GetImmediateContext3([NativeTypeName("ID3D11DeviceContext3 **")] ID3D11DeviceContext3** ppImmediateContext)
        {
            Marshal.GetDelegateForFunctionPointer<_GetImmediateContext3>(lpVtbl->GetImmediateContext3)((ID3D11Device3*)Unsafe.AsPointer(ref this), ppImmediateContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeferredContext3([NativeTypeName("UINT")] uint ContextFlags, [NativeTypeName("ID3D11DeviceContext3 **")] ID3D11DeviceContext3** ppDeferredContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDeferredContext3>(lpVtbl->CreateDeferredContext3)((ID3D11Device3*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
        }

        public void WriteToSubresource([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch)
        {
            Marshal.GetDelegateForFunctionPointer<_WriteToSubresource>(lpVtbl->WriteToSubresource)((ID3D11Device3*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        public void ReadFromSubresource([NativeTypeName("void *")] void* pDstData, [NativeTypeName("UINT")] uint DstRowPitch, [NativeTypeName("UINT")] uint DstDepthPitch, [NativeTypeName("ID3D11Resource *")] ID3D11Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pSrcBox)
        {
            Marshal.GetDelegateForFunctionPointer<_ReadFromSubresource>(lpVtbl->ReadFromSubresource)((ID3D11Device3*)Unsafe.AsPointer(ref this), pDstData, DstRowPitch, DstDepthPitch, pSrcResource, SrcSubresource, pSrcBox);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const D3D11_BUFFER_DESC *, const D3D11_SUBRESOURCE_DATA *, ID3D11Buffer **) __attribute__((stdcall))")]
            public IntPtr CreateBuffer;

            [NativeTypeName("HRESULT (const D3D11_TEXTURE1D_DESC *, const D3D11_SUBRESOURCE_DATA *, ID3D11Texture1D **) __attribute__((stdcall))")]
            public IntPtr CreateTexture1D;

            [NativeTypeName("HRESULT (const D3D11_TEXTURE2D_DESC *, const D3D11_SUBRESOURCE_DATA *, ID3D11Texture2D **) __attribute__((stdcall))")]
            public IntPtr CreateTexture2D;

            [NativeTypeName("HRESULT (const D3D11_TEXTURE3D_DESC *, const D3D11_SUBRESOURCE_DATA *, ID3D11Texture3D **) __attribute__((stdcall))")]
            public IntPtr CreateTexture3D;

            [NativeTypeName("HRESULT (ID3D11Resource *, const D3D11_SHADER_RESOURCE_VIEW_DESC *, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public IntPtr CreateShaderResourceView;

            [NativeTypeName("HRESULT (ID3D11Resource *, const D3D11_UNORDERED_ACCESS_VIEW_DESC *, ID3D11UnorderedAccessView **) __attribute__((stdcall))")]
            public IntPtr CreateUnorderedAccessView;

            [NativeTypeName("HRESULT (ID3D11Resource *, const D3D11_RENDER_TARGET_VIEW_DESC *, ID3D11RenderTargetView **) __attribute__((stdcall))")]
            public IntPtr CreateRenderTargetView;

            [NativeTypeName("HRESULT (ID3D11Resource *, const D3D11_DEPTH_STENCIL_VIEW_DESC *, ID3D11DepthStencilView **) __attribute__((stdcall))")]
            public IntPtr CreateDepthStencilView;

            [NativeTypeName("HRESULT (const D3D11_INPUT_ELEMENT_DESC *, UINT, const void *, SIZE_T, ID3D11InputLayout **) __attribute__((stdcall))")]
            public IntPtr CreateInputLayout;

            [NativeTypeName("HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11VertexShader **) __attribute__((stdcall))")]
            public IntPtr CreateVertexShader;

            [NativeTypeName("HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11GeometryShader **) __attribute__((stdcall))")]
            public IntPtr CreateGeometryShader;

            [NativeTypeName("HRESULT (const void *, SIZE_T, const D3D11_SO_DECLARATION_ENTRY *, UINT, const UINT *, UINT, UINT, ID3D11ClassLinkage *, ID3D11GeometryShader **) __attribute__((stdcall))")]
            public IntPtr CreateGeometryShaderWithStreamOutput;

            [NativeTypeName("HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11PixelShader **) __attribute__((stdcall))")]
            public IntPtr CreatePixelShader;

            [NativeTypeName("HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11HullShader **) __attribute__((stdcall))")]
            public IntPtr CreateHullShader;

            [NativeTypeName("HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11DomainShader **) __attribute__((stdcall))")]
            public IntPtr CreateDomainShader;

            [NativeTypeName("HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11ComputeShader **) __attribute__((stdcall))")]
            public IntPtr CreateComputeShader;

            [NativeTypeName("HRESULT (ID3D11ClassLinkage **) __attribute__((stdcall))")]
            public IntPtr CreateClassLinkage;

            [NativeTypeName("HRESULT (const D3D11_BLEND_DESC *, ID3D11BlendState **) __attribute__((stdcall))")]
            public IntPtr CreateBlendState;

            [NativeTypeName("HRESULT (const D3D11_DEPTH_STENCIL_DESC *, ID3D11DepthStencilState **) __attribute__((stdcall))")]
            public IntPtr CreateDepthStencilState;

            [NativeTypeName("HRESULT (const D3D11_RASTERIZER_DESC *, ID3D11RasterizerState **) __attribute__((stdcall))")]
            public IntPtr CreateRasterizerState;

            [NativeTypeName("HRESULT (const D3D11_SAMPLER_DESC *, ID3D11SamplerState **) __attribute__((stdcall))")]
            public IntPtr CreateSamplerState;

            [NativeTypeName("HRESULT (const D3D11_QUERY_DESC *, ID3D11Query **) __attribute__((stdcall))")]
            public IntPtr CreateQuery;

            [NativeTypeName("HRESULT (const D3D11_QUERY_DESC *, ID3D11Predicate **) __attribute__((stdcall))")]
            public IntPtr CreatePredicate;

            [NativeTypeName("HRESULT (const D3D11_COUNTER_DESC *, ID3D11Counter **) __attribute__((stdcall))")]
            public IntPtr CreateCounter;

            [NativeTypeName("HRESULT (UINT, ID3D11DeviceContext **) __attribute__((stdcall))")]
            public IntPtr CreateDeferredContext;

            [NativeTypeName("HRESULT (HANDLE, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr OpenSharedResource;

            [NativeTypeName("HRESULT (DXGI_FORMAT, UINT *) __attribute__((stdcall))")]
            public IntPtr CheckFormatSupport;

            [NativeTypeName("HRESULT (DXGI_FORMAT, UINT, UINT *) __attribute__((stdcall))")]
            public IntPtr CheckMultisampleQualityLevels;

            [NativeTypeName("void (D3D11_COUNTER_INFO *) __attribute__((stdcall))")]
            public IntPtr CheckCounterInfo;

            [NativeTypeName("HRESULT (const D3D11_COUNTER_DESC *, D3D11_COUNTER_TYPE *, UINT *, LPSTR, UINT *, LPSTR, UINT *, LPSTR, UINT *) __attribute__((stdcall))")]
            public IntPtr CheckCounter;

            [NativeTypeName("HRESULT (D3D11_FEATURE, void *, UINT) __attribute__((stdcall))")]
            public IntPtr CheckFeatureSupport;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("D3D_FEATURE_LEVEL () __attribute__((stdcall))")]
            public IntPtr GetFeatureLevel;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public IntPtr GetCreationFlags;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr GetDeviceRemovedReason;

            [NativeTypeName("void (ID3D11DeviceContext **) __attribute__((stdcall))")]
            public IntPtr GetImmediateContext;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr SetExceptionMode;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public IntPtr GetExceptionMode;

            [NativeTypeName("void (ID3D11DeviceContext1 **) __attribute__((stdcall))")]
            public IntPtr GetImmediateContext1;

            [NativeTypeName("HRESULT (UINT, ID3D11DeviceContext1 **) __attribute__((stdcall))")]
            public IntPtr CreateDeferredContext1;

            [NativeTypeName("HRESULT (const D3D11_BLEND_DESC1 *, ID3D11BlendState1 **) __attribute__((stdcall))")]
            public IntPtr CreateBlendState1;

            [NativeTypeName("HRESULT (const D3D11_RASTERIZER_DESC1 *, ID3D11RasterizerState1 **) __attribute__((stdcall))")]
            public IntPtr CreateRasterizerState1;

            [NativeTypeName("HRESULT (UINT, const D3D_FEATURE_LEVEL *, UINT, UINT, const IID &, D3D_FEATURE_LEVEL *, ID3DDeviceContextState **) __attribute__((stdcall))")]
            public IntPtr CreateDeviceContextState;

            [NativeTypeName("HRESULT (HANDLE, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr OpenSharedResource1;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr OpenSharedResourceByName;

            [NativeTypeName("void (ID3D11DeviceContext2 **) __attribute__((stdcall))")]
            public IntPtr GetImmediateContext2;

            [NativeTypeName("HRESULT (UINT, ID3D11DeviceContext2 **) __attribute__((stdcall))")]
            public IntPtr CreateDeferredContext2;

            [NativeTypeName("void (ID3D11Resource *, UINT *, D3D11_PACKED_MIP_DESC *, D3D11_TILE_SHAPE *, UINT *, UINT, D3D11_SUBRESOURCE_TILING *) __attribute__((stdcall))")]
            public IntPtr GetResourceTiling;

            [NativeTypeName("HRESULT (DXGI_FORMAT, UINT, UINT, UINT *) __attribute__((stdcall))")]
            public IntPtr CheckMultisampleQualityLevels1;

            [NativeTypeName("HRESULT (const D3D11_TEXTURE2D_DESC1 *, const D3D11_SUBRESOURCE_DATA *, ID3D11Texture2D1 **) __attribute__((stdcall))")]
            public IntPtr CreateTexture2D1;

            [NativeTypeName("HRESULT (const D3D11_TEXTURE3D_DESC1 *, const D3D11_SUBRESOURCE_DATA *, ID3D11Texture3D1 **) __attribute__((stdcall))")]
            public IntPtr CreateTexture3D1;

            [NativeTypeName("HRESULT (const D3D11_RASTERIZER_DESC2 *, ID3D11RasterizerState2 **) __attribute__((stdcall))")]
            public IntPtr CreateRasterizerState2;

            [NativeTypeName("HRESULT (ID3D11Resource *, const D3D11_SHADER_RESOURCE_VIEW_DESC1 *, ID3D11ShaderResourceView1 **) __attribute__((stdcall))")]
            public IntPtr CreateShaderResourceView1;

            [NativeTypeName("HRESULT (ID3D11Resource *, const D3D11_UNORDERED_ACCESS_VIEW_DESC1 *, ID3D11UnorderedAccessView1 **) __attribute__((stdcall))")]
            public IntPtr CreateUnorderedAccessView1;

            [NativeTypeName("HRESULT (ID3D11Resource *, const D3D11_RENDER_TARGET_VIEW_DESC1 *, ID3D11RenderTargetView1 **) __attribute__((stdcall))")]
            public IntPtr CreateRenderTargetView1;

            [NativeTypeName("HRESULT (const D3D11_QUERY_DESC1 *, ID3D11Query1 **) __attribute__((stdcall))")]
            public IntPtr CreateQuery1;

            [NativeTypeName("void (ID3D11DeviceContext3 **) __attribute__((stdcall))")]
            public IntPtr GetImmediateContext3;

            [NativeTypeName("HRESULT (UINT, ID3D11DeviceContext3 **) __attribute__((stdcall))")]
            public IntPtr CreateDeferredContext3;

            [NativeTypeName("void (ID3D11Resource *, UINT, const D3D11_BOX *, const void *, UINT, UINT) __attribute__((stdcall))")]
            public IntPtr WriteToSubresource;

            [NativeTypeName("void (void *, UINT, UINT, ID3D11Resource *, UINT, const D3D11_BOX *) __attribute__((stdcall))")]
            public IntPtr ReadFromSubresource;
        }
    }
}
