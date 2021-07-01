// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D9F916B-27DC-4AD7-B4F1-64945340F563")]
    [NativeTypeName("struct ID2D1EffectContext : IUnknown")]
    public unsafe partial struct ID2D1EffectContext
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, uint>)(lpVtbl[1]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, uint>)(lpVtbl[2]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDpi([NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY)
        {
            ((delegate* unmanaged<ID2D1EffectContext*, float*, float*, void>)(lpVtbl[3]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEffect([NativeTypeName("const IID &")] Guid* effectId, ID2D1Effect** effect)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, ID2D1Effect**, int>)(lpVtbl[4]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), effectId, effect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaximumSupportedFeatureLevel([NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* featureLevels, [NativeTypeName("UINT32")] uint featureLevelsCount, D3D_FEATURE_LEVEL* maximumSupportedFeatureLevel)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, D3D_FEATURE_LEVEL*, uint, D3D_FEATURE_LEVEL*, int>)(lpVtbl[5]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), featureLevels, featureLevelsCount, maximumSupportedFeatureLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTransformNodeFromEffect(ID2D1Effect* effect, ID2D1TransformNode** transformNode)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, ID2D1Effect*, ID2D1TransformNode**, int>)(lpVtbl[6]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), effect, transformNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBlendTransform([NativeTypeName("UINT32")] uint numInputs, [NativeTypeName("const D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* blendDescription, ID2D1BlendTransform** transform)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, uint, D2D1_BLEND_DESCRIPTION*, ID2D1BlendTransform**, int>)(lpVtbl[7]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), numInputs, blendDescription, transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBorderTransform(D2D1_EXTEND_MODE extendModeX, D2D1_EXTEND_MODE extendModeY, ID2D1BorderTransform** transform)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, D2D1_EXTEND_MODE, D2D1_EXTEND_MODE, ID2D1BorderTransform**, int>)(lpVtbl[8]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), extendModeX, extendModeY, transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateOffsetTransform([NativeTypeName("D2D1_POINT_2L")] POINT offset, ID2D1OffsetTransform** transform)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, POINT, ID2D1OffsetTransform**, int>)(lpVtbl[9]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), offset, transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBoundsAdjustmentTransform([NativeTypeName("const D2D1_RECT_L *")] RECT* outputRectangle, ID2D1BoundsAdjustmentTransform** transform)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, RECT*, ID2D1BoundsAdjustmentTransform**, int>)(lpVtbl[10]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), outputRectangle, transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoadPixelShader([NativeTypeName("const GUID &")] Guid* shaderId, [NativeTypeName("const BYTE *")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, byte*, uint, int>)(lpVtbl[11]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), shaderId, shaderBuffer, shaderBufferCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoadVertexShader([NativeTypeName("const GUID &")] Guid* resourceId, [NativeTypeName("const BYTE *")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, byte*, uint, int>)(lpVtbl[12]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), resourceId, shaderBuffer, shaderBufferCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoadComputeShader([NativeTypeName("const GUID &")] Guid* resourceId, [NativeTypeName("const BYTE *")] byte* shaderBuffer, [NativeTypeName("UINT32")] uint shaderBufferCount)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, byte*, uint, int>)(lpVtbl[13]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), resourceId, shaderBuffer, shaderBufferCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsShaderLoaded([NativeTypeName("const GUID &")] Guid* shaderId)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, int>)(lpVtbl[14]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), shaderId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateResourceTexture([NativeTypeName("const GUID *")] Guid* resourceId, [NativeTypeName("const D2D1_RESOURCE_TEXTURE_PROPERTIES *")] D2D1_RESOURCE_TEXTURE_PROPERTIES* resourceTextureProperties, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("const UINT32 *")] uint* strides, [NativeTypeName("UINT32")] uint dataSize, ID2D1ResourceTexture** resourceTexture)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, D2D1_RESOURCE_TEXTURE_PROPERTIES*, byte*, uint*, uint, ID2D1ResourceTexture**, int>)(lpVtbl[15]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), resourceId, resourceTextureProperties, data, strides, dataSize, resourceTexture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindResourceTexture([NativeTypeName("const GUID *")] Guid* resourceId, ID2D1ResourceTexture** resourceTexture)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, ID2D1ResourceTexture**, int>)(lpVtbl[16]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), resourceId, resourceTexture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVertexBuffer([NativeTypeName("const D2D1_VERTEX_BUFFER_PROPERTIES *")] D2D1_VERTEX_BUFFER_PROPERTIES* vertexBufferProperties, [NativeTypeName("const GUID *")] Guid* resourceId, [NativeTypeName("const D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES *")] D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES* customVertexBufferProperties, ID2D1VertexBuffer** buffer)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, D2D1_VERTEX_BUFFER_PROPERTIES*, Guid*, D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES*, ID2D1VertexBuffer**, int>)(lpVtbl[17]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), vertexBufferProperties, resourceId, customVertexBufferProperties, buffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindVertexBuffer([NativeTypeName("const GUID *")] Guid* resourceId, ID2D1VertexBuffer** buffer)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, Guid*, ID2D1VertexBuffer**, int>)(lpVtbl[18]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), resourceId, buffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext(D2D1_COLOR_SPACE space, [NativeTypeName("const BYTE *")] byte* profile, [NativeTypeName("UINT32")] uint profileSize, ID2D1ColorContext** colorContext)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, D2D1_COLOR_SPACE, byte*, uint, ID2D1ColorContext**, int>)(lpVtbl[19]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), space, profile, profileSize, colorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromFilename([NativeTypeName("PCWSTR")] ushort* filename, ID2D1ColorContext** colorContext)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, ushort*, ID2D1ColorContext**, int>)(lpVtbl[20]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), filename, colorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromWicColorContext(IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, IWICColorContext*, ID2D1ColorContext**, int>)(lpVtbl[21]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), wicColorContext, colorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D2D1_FEATURE feature, void* featureSupportData, [NativeTypeName("UINT32")] uint featureSupportDataSize)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, D2D1_FEATURE, void*, uint, int>)(lpVtbl[22]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), feature, featureSupportData, featureSupportDataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsBufferPrecisionSupported(D2D1_BUFFER_PRECISION bufferPrecision)
        {
            return ((delegate* unmanaged<ID2D1EffectContext*, D2D1_BUFFER_PRECISION, int>)(lpVtbl[23]))((ID2D1EffectContext*)Unsafe.AsPointer(ref this), bufferPrecision);
        }
    }
}
