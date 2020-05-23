// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("577AD2A0-9FC7-4DDA-8B18-DAB810140052")]
    public unsafe partial struct ID2D1EffectContext2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1EffectContext2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1EffectContext2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1EffectContext2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetDpi(ID2D1EffectContext2* pThis, [NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEffect(ID2D1EffectContext2* pThis, [NativeTypeName("const IID &")] Guid* effectId, [NativeTypeName("ID2D1Effect **")] ID2D1Effect** effect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMaximumSupportedFeatureLevel(ID2D1EffectContext2* pThis, [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* featureLevels, [NativeTypeName("UINT32")] uint featureLevelsCount, [NativeTypeName("D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* maximumSupportedFeatureLevel);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTransformNodeFromEffect(ID2D1EffectContext2* pThis, [NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("ID2D1TransformNode **")] ID2D1TransformNode** transformNode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBlendTransform(ID2D1EffectContext2* pThis, [NativeTypeName("UINT32")] uint numInputs, [NativeTypeName("const D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* blendDescription, [NativeTypeName("ID2D1BlendTransform **")] ID2D1BlendTransform** transform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBorderTransform(ID2D1EffectContext2* pThis, D2D1_EXTEND_MODE extendModeX, D2D1_EXTEND_MODE extendModeY, [NativeTypeName("ID2D1BorderTransform **")] ID2D1BorderTransform** transform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateOffsetTransform(ID2D1EffectContext2* pThis, [NativeTypeName("D2D1_POINT_2L")] POINT offset, [NativeTypeName("ID2D1OffsetTransform **")] ID2D1OffsetTransform** transform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBoundsAdjustmentTransform(ID2D1EffectContext2* pThis, [NativeTypeName("const D2D1_RECT_L *")] RECT* outputRectangle, [NativeTypeName("ID2D1BoundsAdjustmentTransform **")] ID2D1BoundsAdjustmentTransform** transform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LoadPixelShader(ID2D1EffectContext2* pThis, [NativeTypeName("const GUID &")] Guid* shaderId, [NativeTypeName("const BYTE *")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LoadVertexShader(ID2D1EffectContext2* pThis, [NativeTypeName("const GUID &")] Guid* resourceId, [NativeTypeName("const BYTE *")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LoadComputeShader(ID2D1EffectContext2* pThis, [NativeTypeName("const GUID &")] Guid* resourceId, [NativeTypeName("const BYTE *")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsShaderLoaded(ID2D1EffectContext2* pThis, [NativeTypeName("const GUID &")] Guid* shaderId);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateResourceTexture(ID2D1EffectContext2* pThis, [NativeTypeName("const GUID *")] Guid* resourceId, [NativeTypeName("const D2D1_RESOURCE_TEXTURE_PROPERTIES *")] D2D1_RESOURCE_TEXTURE_PROPERTIES* resourceTextureProperties, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("const UINT32 *")] uint* strides, [NativeTypeName("UINT32")] uint dataSize, [NativeTypeName("ID2D1ResourceTexture **")] ID2D1ResourceTexture** resourceTexture);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindResourceTexture(ID2D1EffectContext2* pThis, [NativeTypeName("const GUID *")] Guid* resourceId, [NativeTypeName("ID2D1ResourceTexture **")] ID2D1ResourceTexture** resourceTexture);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVertexBuffer(ID2D1EffectContext2* pThis, [NativeTypeName("const D2D1_VERTEX_BUFFER_PROPERTIES *")] D2D1_VERTEX_BUFFER_PROPERTIES* vertexBufferProperties, [NativeTypeName("const GUID *")] Guid* resourceId, [NativeTypeName("const D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES *")] D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES* customVertexBufferProperties, [NativeTypeName("ID2D1VertexBuffer **")] ID2D1VertexBuffer** buffer);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindVertexBuffer(ID2D1EffectContext2* pThis, [NativeTypeName("const GUID *")] Guid* resourceId, [NativeTypeName("ID2D1VertexBuffer **")] ID2D1VertexBuffer** buffer);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContext(ID2D1EffectContext2* pThis, D2D1_COLOR_SPACE space, [NativeTypeName("const BYTE *")] byte* profile, [NativeTypeName("UINT32")] uint profileSize, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContextFromFilename(ID2D1EffectContext2* pThis, [NativeTypeName("PCWSTR")] ushort* filename, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContextFromWicColorContext(ID2D1EffectContext2* pThis, [NativeTypeName("IWICColorContext *")] IWICColorContext* wicColorContext, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckFeatureSupport(ID2D1EffectContext2* pThis, D2D1_FEATURE feature, [NativeTypeName("void *")] void* featureSupportData, [NativeTypeName("UINT32")] uint featureSupportDataSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsBufferPrecisionSupported(ID2D1EffectContext2* pThis, D2D1_BUFFER_PRECISION bufferPrecision);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateLookupTable3D(ID2D1EffectContext2* pThis, D2D1_BUFFER_PRECISION precision, [NativeTypeName("const UINT32 *")] uint* extents, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("const UINT32 *")] uint* strides, [NativeTypeName("ID2D1LookupTable3D **")] ID2D1LookupTable3D** lookupTable);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContextFromDxgiColorSpace(ID2D1EffectContext2* pThis, DXGI_COLOR_SPACE_TYPE colorSpace, [NativeTypeName("ID2D1ColorContext1 **")] ID2D1ColorContext1** colorContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContextFromSimpleColorProfile(ID2D1EffectContext2* pThis, [NativeTypeName("const D2D1_SIMPLE_COLOR_PROFILE *")] D2D1_SIMPLE_COLOR_PROFILE* simpleProfile, [NativeTypeName("ID2D1ColorContext1 **")] ID2D1ColorContext1** colorContext);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this));
        }

        public void GetDpi([NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDpi>(lpVtbl->GetDpi)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEffect([NativeTypeName("const IID &")] Guid* effectId, [NativeTypeName("ID2D1Effect **")] ID2D1Effect** effect)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateEffect>(lpVtbl->CreateEffect)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), effectId, effect);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaximumSupportedFeatureLevel([NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* featureLevels, [NativeTypeName("UINT32")] uint featureLevelsCount, [NativeTypeName("D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* maximumSupportedFeatureLevel)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMaximumSupportedFeatureLevel>(lpVtbl->GetMaximumSupportedFeatureLevel)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), featureLevels, featureLevelsCount, maximumSupportedFeatureLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransformNodeFromEffect([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("ID2D1TransformNode **")] ID2D1TransformNode** transformNode)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTransformNodeFromEffect>(lpVtbl->CreateTransformNodeFromEffect)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), effect, transformNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlendTransform([NativeTypeName("UINT32")] uint numInputs, [NativeTypeName("const D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* blendDescription, [NativeTypeName("ID2D1BlendTransform **")] ID2D1BlendTransform** transform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBlendTransform>(lpVtbl->CreateBlendTransform)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), numInputs, blendDescription, transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBorderTransform(D2D1_EXTEND_MODE extendModeX, D2D1_EXTEND_MODE extendModeY, [NativeTypeName("ID2D1BorderTransform **")] ID2D1BorderTransform** transform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBorderTransform>(lpVtbl->CreateBorderTransform)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), extendModeX, extendModeY, transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateOffsetTransform([NativeTypeName("D2D1_POINT_2L")] POINT offset, [NativeTypeName("ID2D1OffsetTransform **")] ID2D1OffsetTransform** transform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateOffsetTransform>(lpVtbl->CreateOffsetTransform)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), offset, transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBoundsAdjustmentTransform([NativeTypeName("const D2D1_RECT_L *")] RECT* outputRectangle, [NativeTypeName("ID2D1BoundsAdjustmentTransform **")] ID2D1BoundsAdjustmentTransform** transform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBoundsAdjustmentTransform>(lpVtbl->CreateBoundsAdjustmentTransform)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), outputRectangle, transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadPixelShader([NativeTypeName("const GUID &")] Guid* shaderId, [NativeTypeName("const BYTE *")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_LoadPixelShader>(lpVtbl->LoadPixelShader)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), shaderId, shaderBuffer, shaderBufferCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadVertexShader([NativeTypeName("const GUID &")] Guid* resourceId, [NativeTypeName("const BYTE *")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_LoadVertexShader>(lpVtbl->LoadVertexShader)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), resourceId, shaderBuffer, shaderBufferCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadComputeShader([NativeTypeName("const GUID &")] Guid* resourceId, [NativeTypeName("const BYTE *")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_LoadComputeShader>(lpVtbl->LoadComputeShader)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), resourceId, shaderBuffer, shaderBufferCount);
        }

        [return: NativeTypeName("BOOL")]
        public int IsShaderLoaded([NativeTypeName("const GUID &")] Guid* shaderId)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsShaderLoaded>(lpVtbl->IsShaderLoaded)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), shaderId);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateResourceTexture([NativeTypeName("const GUID *")] Guid* resourceId, [NativeTypeName("const D2D1_RESOURCE_TEXTURE_PROPERTIES *")] D2D1_RESOURCE_TEXTURE_PROPERTIES* resourceTextureProperties, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("const UINT32 *")] uint* strides, [NativeTypeName("UINT32")] uint dataSize, [NativeTypeName("ID2D1ResourceTexture **")] ID2D1ResourceTexture** resourceTexture)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateResourceTexture>(lpVtbl->CreateResourceTexture)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), resourceId, resourceTextureProperties, data, strides, dataSize, resourceTexture);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindResourceTexture([NativeTypeName("const GUID *")] Guid* resourceId, [NativeTypeName("ID2D1ResourceTexture **")] ID2D1ResourceTexture** resourceTexture)
        {
            return Marshal.GetDelegateForFunctionPointer<_FindResourceTexture>(lpVtbl->FindResourceTexture)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), resourceId, resourceTexture);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVertexBuffer([NativeTypeName("const D2D1_VERTEX_BUFFER_PROPERTIES *")] D2D1_VERTEX_BUFFER_PROPERTIES* vertexBufferProperties, [NativeTypeName("const GUID *")] Guid* resourceId, [NativeTypeName("const D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES *")] D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES* customVertexBufferProperties, [NativeTypeName("ID2D1VertexBuffer **")] ID2D1VertexBuffer** buffer)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVertexBuffer>(lpVtbl->CreateVertexBuffer)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), vertexBufferProperties, resourceId, customVertexBufferProperties, buffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindVertexBuffer([NativeTypeName("const GUID *")] Guid* resourceId, [NativeTypeName("ID2D1VertexBuffer **")] ID2D1VertexBuffer** buffer)
        {
            return Marshal.GetDelegateForFunctionPointer<_FindVertexBuffer>(lpVtbl->FindVertexBuffer)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), resourceId, buffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext(D2D1_COLOR_SPACE space, [NativeTypeName("const BYTE *")] byte* profile, [NativeTypeName("UINT32")] uint profileSize, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateColorContext>(lpVtbl->CreateColorContext)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), space, profile, profileSize, colorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromFilename([NativeTypeName("PCWSTR")] ushort* filename, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateColorContextFromFilename>(lpVtbl->CreateColorContextFromFilename)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), filename, colorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromWicColorContext([NativeTypeName("IWICColorContext *")] IWICColorContext* wicColorContext, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateColorContextFromWicColorContext>(lpVtbl->CreateColorContextFromWicColorContext)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), wicColorContext, colorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D2D1_FEATURE feature, [NativeTypeName("void *")] void* featureSupportData, [NativeTypeName("UINT32")] uint featureSupportDataSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckFeatureSupport>(lpVtbl->CheckFeatureSupport)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), feature, featureSupportData, featureSupportDataSize);
        }

        [return: NativeTypeName("BOOL")]
        public int IsBufferPrecisionSupported(D2D1_BUFFER_PRECISION bufferPrecision)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsBufferPrecisionSupported>(lpVtbl->IsBufferPrecisionSupported)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), bufferPrecision);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLookupTable3D(D2D1_BUFFER_PRECISION precision, [NativeTypeName("const UINT32 *")] uint* extents, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("const UINT32 *")] uint* strides, [NativeTypeName("ID2D1LookupTable3D **")] ID2D1LookupTable3D** lookupTable)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateLookupTable3D>(lpVtbl->CreateLookupTable3D)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), precision, extents, data, dataCount, strides, lookupTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromDxgiColorSpace(DXGI_COLOR_SPACE_TYPE colorSpace, [NativeTypeName("ID2D1ColorContext1 **")] ID2D1ColorContext1** colorContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateColorContextFromDxgiColorSpace>(lpVtbl->CreateColorContextFromDxgiColorSpace)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), colorSpace, colorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromSimpleColorProfile([NativeTypeName("const D2D1_SIMPLE_COLOR_PROFILE *")] D2D1_SIMPLE_COLOR_PROFILE* simpleProfile, [NativeTypeName("ID2D1ColorContext1 **")] ID2D1ColorContext1** colorContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateColorContextFromSimpleColorProfile>(lpVtbl->CreateColorContextFromSimpleColorProfile)((ID2D1EffectContext2*)Unsafe.AsPointer(ref this), simpleProfile, colorContext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (FLOAT *, FLOAT *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDpi;

            [NativeTypeName("HRESULT (const IID &, ID2D1Effect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateEffect;

            [NativeTypeName("HRESULT (const D3D_FEATURE_LEVEL *, UINT32, D3D_FEATURE_LEVEL *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMaximumSupportedFeatureLevel;

            [NativeTypeName("HRESULT (ID2D1Effect *, ID2D1TransformNode **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTransformNodeFromEffect;

            [NativeTypeName("HRESULT (UINT32, const D2D1_BLEND_DESCRIPTION *, ID2D1BlendTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateBlendTransform;

            [NativeTypeName("HRESULT (D2D1_EXTEND_MODE, D2D1_EXTEND_MODE, ID2D1BorderTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateBorderTransform;

            [NativeTypeName("HRESULT (D2D1_POINT_2L, ID2D1OffsetTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateOffsetTransform;

            [NativeTypeName("HRESULT (const D2D1_RECT_L *, ID2D1BoundsAdjustmentTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateBoundsAdjustmentTransform;

            [NativeTypeName("HRESULT (const GUID &, const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr LoadPixelShader;

            [NativeTypeName("HRESULT (const GUID &, const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr LoadVertexShader;

            [NativeTypeName("HRESULT (const GUID &, const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr LoadComputeShader;

            [NativeTypeName("BOOL (const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsShaderLoaded;

            [NativeTypeName("HRESULT (const GUID *, const D2D1_RESOURCE_TEXTURE_PROPERTIES *, const BYTE *, const UINT32 *, UINT32, ID2D1ResourceTexture **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateResourceTexture;

            [NativeTypeName("HRESULT (const GUID *, ID2D1ResourceTexture **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FindResourceTexture;

            [NativeTypeName("HRESULT (const D2D1_VERTEX_BUFFER_PROPERTIES *, const GUID *, const D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES *, ID2D1VertexBuffer **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateVertexBuffer;

            [NativeTypeName("HRESULT (const GUID *, ID2D1VertexBuffer **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FindVertexBuffer;

            [NativeTypeName("HRESULT (D2D1_COLOR_SPACE, const BYTE *, UINT32, ID2D1ColorContext **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateColorContext;

            [NativeTypeName("HRESULT (PCWSTR, ID2D1ColorContext **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateColorContextFromFilename;

            [NativeTypeName("HRESULT (IWICColorContext *, ID2D1ColorContext **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateColorContextFromWicColorContext;

            [NativeTypeName("HRESULT (D2D1_FEATURE, void *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CheckFeatureSupport;

            [NativeTypeName("BOOL (D2D1_BUFFER_PRECISION) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsBufferPrecisionSupported;

            [NativeTypeName("HRESULT (D2D1_BUFFER_PRECISION, const UINT32 *, const BYTE *, UINT32, const UINT32 *, ID2D1LookupTable3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateLookupTable3D;

            [NativeTypeName("HRESULT (DXGI_COLOR_SPACE_TYPE, ID2D1ColorContext1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateColorContextFromDxgiColorSpace;

            [NativeTypeName("HRESULT (const D2D1_SIMPLE_COLOR_PROFILE *, ID2D1ColorContext1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateColorContextFromSimpleColorProfile;
        }
    }
}
