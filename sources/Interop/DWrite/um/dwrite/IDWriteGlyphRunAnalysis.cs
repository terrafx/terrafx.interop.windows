// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7D97DBF7-E085-42D4-81E3-6A883BDED118")]
    public unsafe partial struct IDWriteGlyphRunAnalysis
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteGlyphRunAnalysis* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteGlyphRunAnalysis* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteGlyphRunAnalysis* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAlphaTextureBounds(IDWriteGlyphRunAnalysis* pThis, DWRITE_TEXTURE_TYPE textureType, [NativeTypeName("RECT *")] RECT* textureBounds);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateAlphaTexture(IDWriteGlyphRunAnalysis* pThis, DWRITE_TEXTURE_TYPE textureType, [NativeTypeName("const RECT *")] RECT* textureBounds, [NativeTypeName("BYTE *")] byte* alphaValues, [NativeTypeName("UINT32")] uint bufferSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAlphaBlendParams(IDWriteGlyphRunAnalysis* pThis, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* renderingParams, [NativeTypeName("FLOAT *")] float* blendGamma, [NativeTypeName("FLOAT *")] float* blendEnhancedContrast, [NativeTypeName("FLOAT *")] float* blendClearTypeLevel);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAlphaTextureBounds(DWRITE_TEXTURE_TYPE textureType, [NativeTypeName("RECT *")] RECT* textureBounds)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAlphaTextureBounds>(lpVtbl->GetAlphaTextureBounds)((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this), textureType, textureBounds);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateAlphaTexture(DWRITE_TEXTURE_TYPE textureType, [NativeTypeName("const RECT *")] RECT* textureBounds, [NativeTypeName("BYTE *")] byte* alphaValues, [NativeTypeName("UINT32")] uint bufferSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateAlphaTexture>(lpVtbl->CreateAlphaTexture)((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this), textureType, textureBounds, alphaValues, bufferSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAlphaBlendParams([NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* renderingParams, [NativeTypeName("FLOAT *")] float* blendGamma, [NativeTypeName("FLOAT *")] float* blendEnhancedContrast, [NativeTypeName("FLOAT *")] float* blendClearTypeLevel)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAlphaBlendParams>(lpVtbl->GetAlphaBlendParams)((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this), renderingParams, blendGamma, blendEnhancedContrast, blendClearTypeLevel);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DWRITE_TEXTURE_TYPE, RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetAlphaTextureBounds;

            [NativeTypeName("HRESULT (DWRITE_TEXTURE_TYPE, const RECT *, BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateAlphaTexture;

            [NativeTypeName("HRESULT (IDWriteRenderingParams *, FLOAT *, FLOAT *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetAlphaBlendParams;
        }
    }
}
