// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The internal context handed to effect authors to create transforms from effects and any other operation tied to context which is not useful to the application facing API.</summary>
    [Guid("84AB595A-FC81-4546-BACD-E8EF4D8ABE7A")]
    public unsafe struct ID2D1EffectContext1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1EffectContext1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1EffectContext1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1EffectContext1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDpi(ID2D1EffectContext1* This, [NativeTypeName("FLOAT")] float* dpiX, [NativeTypeName("FLOAT")] float* dpiY);

        /// <summary>Create a new effect, the effect must either be built in or previously registered through ID2D1Factory1::RegisterEffect.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEffect(ID2D1EffectContext1* This, [NativeTypeName("REFCLSID")] Guid* effectId, ID2D1Effect** effect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMaximumSupportedFeatureLevel(ID2D1EffectContext1* This, [NativeTypeName("D3D_FEATURE_LEVEL[]")] D3D_FEATURE_LEVEL* featureLevels, [NativeTypeName("UINT32")] uint featureLevelsCount, D3D_FEATURE_LEVEL* maximumSupportedFeatureLevel);

        /// <summary>Create a transform node from the passed in effect.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTransformNodeFromEffect(ID2D1EffectContext1* This, ID2D1Effect* effect, ID2D1TransformNode** transformNode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBlendTransform(ID2D1EffectContext1* This, [NativeTypeName("UINT32")] uint numInputs, D2D1_BLEND_DESCRIPTION* blendDescription, ID2D1BlendTransform** transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBorderTransform(ID2D1EffectContext1* This, D2D1_EXTEND_MODE extendModeX, D2D1_EXTEND_MODE extendModeY, ID2D1BorderTransform** transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateOffsetTransform(ID2D1EffectContext1* This, [NativeTypeName("D2D1_POINT_2L")] POINT offset, ID2D1OffsetTransform** transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBoundsAdjustmentTransform(ID2D1EffectContext1* This, [NativeTypeName("D2D1_RECT_L")] RECT* outputRectangle, ID2D1BoundsAdjustmentTransform** transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LoadPixelShader(ID2D1EffectContext1* This, [NativeTypeName("REFGUID")] Guid* shaderId, [NativeTypeName("BYTE[]")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LoadVertexShader(ID2D1EffectContext1* This, [NativeTypeName("REFGUID")] Guid* resourceId, [NativeTypeName("BYTE[]")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LoadComputeShader(ID2D1EffectContext1* This, [NativeTypeName("REFGUID")] Guid* resourceId, [NativeTypeName("BYTE[]")]  byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsShaderLoaded(ID2D1EffectContext1* This, [NativeTypeName("REFGUID")] Guid* shaderId);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateResourceTexture(ID2D1EffectContext1* This, [Optional, NativeTypeName("GUID")] Guid* resourceId, D2D1_RESOURCE_TEXTURE_PROPERTIES* resourceTextureProperties, [Optional, NativeTypeName("BYTE[]")] byte* data, [Optional, NativeTypeName("UINT32[]")] uint* strides, [NativeTypeName("UINT32")] uint dataSize, ID2D1ResourceTexture** resourceTexture);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindResourceTexture(ID2D1EffectContext1* This, [NativeTypeName("GUID")] Guid* resourceId, ID2D1ResourceTexture** resourceTexture);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVertexBuffer(ID2D1EffectContext1* This, D2D1_VERTEX_BUFFER_PROPERTIES* vertexBufferProperties, [Optional, NativeTypeName("GUID")] Guid* resourceId, [Optional] D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES* customVertexBufferProperties, ID2D1VertexBuffer** buffer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindVertexBuffer(ID2D1EffectContext1* This, [NativeTypeName("GUID")] Guid* resourceId, ID2D1VertexBuffer** buffer);

        /// <summary>Creates a color context from a color space.  If the space is Custom, the context is initialized from the profile/profileSize arguments.  Otherwise the context is initialized with the profile bytes associated with the space and profile/profileSize are ignored.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContext(ID2D1EffectContext1* This, D2D1_COLOR_SPACE space, [Optional, NativeTypeName("BYTE[]")] byte* profile, [NativeTypeName("UINT32")] uint profileSize, ID2D1ColorContext** colorContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContextFromFilename(ID2D1EffectContext1* This, [NativeTypeName("PCWSTR")] char* filename, ID2D1ColorContext** colorContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContextFromWicColorContext(ID2D1EffectContext1* This, IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckFeatureSupport(ID2D1EffectContext1* This, D2D1_FEATURE feature, void* featureSupportData, [NativeTypeName("UINT32")] uint featureSupportDataSize);

        /// <summary>Indicates whether the buffer precision is supported by D2D.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsBufferPrecisionSupported(ID2D1EffectContext1* This, D2D1_BUFFER_PRECISION bufferPrecision);

        /// <summary>Creates a 3D lookup table for mapping a 3-channel input to a 3-channel output. The table data must be provided in 4-channel format.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateLookupTable3D(ID2D1EffectContext1* This, D2D1_BUFFER_PRECISION precision, [NativeTypeName("UINT32[]")] uint* extents, [NativeTypeName("BYTE[]")] byte* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("UINT32[]")] uint* strides, ID2D1LookupTable3D** lookupTable);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetDpi([NativeTypeName("FLOAT")] float* dpiX, [NativeTypeName("FLOAT")] float* dpiY)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDpi>(lpVtbl->GetDpi)(This, dpiX, dpiY);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEffect([NativeTypeName("REFCLSID")] Guid* effectId, ID2D1Effect** effect)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateEffect>(lpVtbl->CreateEffect)(This, effectId, effect);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaximumSupportedFeatureLevel([NativeTypeName("D3D_FEATURE_LEVEL[]")] D3D_FEATURE_LEVEL* featureLevels, [NativeTypeName("UINT32")] uint featureLevelsCount, D3D_FEATURE_LEVEL* maximumSupportedFeatureLevel)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMaximumSupportedFeatureLevel>(lpVtbl->GetMaximumSupportedFeatureLevel)(This, featureLevels, featureLevelsCount, maximumSupportedFeatureLevel);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransformNodeFromEffect(ID2D1Effect* effect, ID2D1TransformNode** transformNode)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateTransformNodeFromEffect>(lpVtbl->CreateTransformNodeFromEffect)(This, effect, transformNode);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlendTransform([NativeTypeName("UINT32")] uint numInputs, D2D1_BLEND_DESCRIPTION* blendDescription, ID2D1BlendTransform** transform)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBlendTransform>(lpVtbl->CreateBlendTransform)(This, numInputs, blendDescription, transform);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBorderTransform(D2D1_EXTEND_MODE extendModeX, D2D1_EXTEND_MODE extendModeY, ID2D1BorderTransform** transform)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBorderTransform>(lpVtbl->CreateBorderTransform)(This, extendModeX, extendModeY, transform);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateOffsetTransform([NativeTypeName("D2D1_POINT_2L")] POINT offset, ID2D1OffsetTransform** transform)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateOffsetTransform>(lpVtbl->CreateOffsetTransform)(This, offset, transform);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBoundsAdjustmentTransform([NativeTypeName("D2D1_RECT_L")] RECT* outputRectangle, ID2D1BoundsAdjustmentTransform** transform)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBoundsAdjustmentTransform>(lpVtbl->CreateBoundsAdjustmentTransform)(This, outputRectangle, transform);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadPixelShader([NativeTypeName("REFGUID")] Guid* shaderId, [NativeTypeName("BYTE[]")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_LoadPixelShader>(lpVtbl->LoadPixelShader)(This, shaderId, shaderBuffer, shaderBufferCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadVertexShader([NativeTypeName("REFGUID")] Guid* resourceId, [NativeTypeName("BYTE[]")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_LoadVertexShader>(lpVtbl->LoadVertexShader)(This, resourceId, shaderBuffer, shaderBufferCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadComputeShader([NativeTypeName("REFGUID")] Guid* resourceId, [NativeTypeName("BYTE[]")]  byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_LoadComputeShader>(lpVtbl->LoadComputeShader)(This, resourceId, shaderBuffer, shaderBufferCount);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsShaderLoaded([NativeTypeName("REFGUID")] Guid* shaderId)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsShaderLoaded>(lpVtbl->IsShaderLoaded)(This, shaderId);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateResourceTexture([Optional, NativeTypeName("GUID")] Guid* resourceId, D2D1_RESOURCE_TEXTURE_PROPERTIES* resourceTextureProperties, [Optional, NativeTypeName("BYTE[]")] byte* data, [Optional, NativeTypeName("UINT32[]")] uint* strides, [NativeTypeName("UINT32")] uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateResourceTexture>(lpVtbl->CreateResourceTexture)(This, resourceId, resourceTextureProperties, data, strides, dataSize, resourceTexture);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FindResourceTexture([NativeTypeName("GUID")] Guid* resourceId, ID2D1ResourceTexture** resourceTexture)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FindResourceTexture>(lpVtbl->FindResourceTexture)(This, resourceId, resourceTexture);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVertexBuffer(D2D1_VERTEX_BUFFER_PROPERTIES* vertexBufferProperties, [Optional, NativeTypeName("GUID")] Guid* resourceId, [Optional] D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateVertexBuffer>(lpVtbl->CreateVertexBuffer)(This, vertexBufferProperties, resourceId, customVertexBufferProperties, buffer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FindVertexBuffer([NativeTypeName("GUID")] Guid* resourceId, ID2D1VertexBuffer** buffer)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FindVertexBuffer>(lpVtbl->FindVertexBuffer)(This, resourceId, buffer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext(D2D1_COLOR_SPACE space, [Optional, NativeTypeName("BYTE[]")] byte* profile, [NativeTypeName("UINT32")] uint profileSize, ID2D1ColorContext** colorContext)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateColorContext>(lpVtbl->CreateColorContext)(This, space, profile, profileSize, colorContext);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromFilename([NativeTypeName("PCWSTR")] char* filename, ID2D1ColorContext** colorContext)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateColorContextFromFilename>(lpVtbl->CreateColorContextFromFilename)(This, filename, colorContext);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromWicColorContext(IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateColorContextFromWicColorContext>(lpVtbl->CreateColorContextFromWicColorContext)(This, wicColorContext, colorContext);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D2D1_FEATURE feature, void* featureSupportData, [NativeTypeName("UINT32")] uint featureSupportDataSize)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CheckFeatureSupport>(lpVtbl->CheckFeatureSupport)(This, feature, featureSupportData, featureSupportDataSize);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsBufferPrecisionSupported(D2D1_BUFFER_PRECISION bufferPrecision)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsBufferPrecisionSupported>(lpVtbl->IsBufferPrecisionSupported)(This, bufferPrecision);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLookupTable3D(D2D1_BUFFER_PRECISION precision, [NativeTypeName("UINT32[]")] uint* extents, [NativeTypeName("BYTE[]")] byte* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("UINT32[]")] uint* strides, ID2D1LookupTable3D** lookupTable)
        {
            fixed (ID2D1EffectContext1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateLookupTable3D>(lpVtbl->CreateLookupTable3D)(This, precision, extents, data, dataCount, strides, lookupTable);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetDpi;

            public IntPtr CreateEffect;

            public IntPtr GetMaximumSupportedFeatureLevel;

            public IntPtr CreateTransformNodeFromEffect;

            public IntPtr CreateBlendTransform;

            public IntPtr CreateBorderTransform;

            public IntPtr CreateOffsetTransform;

            public IntPtr CreateBoundsAdjustmentTransform;

            public IntPtr LoadPixelShader;

            public IntPtr LoadVertexShader;

            public IntPtr LoadComputeShader;

            public IntPtr IsShaderLoaded;

            public IntPtr CreateResourceTexture;

            public IntPtr FindResourceTexture;

            public IntPtr CreateVertexBuffer;

            public IntPtr FindVertexBuffer;

            public IntPtr CreateColorContext;

            public IntPtr CreateColorContextFromFilename;

            public IntPtr CreateColorContextFromWicColorContext;

            public IntPtr CheckFeatureSupport;

            public IntPtr IsBufferPrecisionSupported;

            public IntPtr CreateLookupTable3D;
        }
    }
}
