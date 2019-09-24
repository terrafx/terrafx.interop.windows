// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Interface that encapsulates information used to render a glyph run.</summary>
    [Guid("7D97DBF7-E085-42D4-81E3-6A883BDED118")]
    public unsafe struct IDWriteGlyphRunAnalysis
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteGlyphRunAnalysis* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteGlyphRunAnalysis* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteGlyphRunAnalysis* This);

        /// <summary>Gets the bounding rectangle of the physical pixels affected by the glyph run.</summary>
        /// <param name="textureType">Specifies the type of texture requested. If a bi-level texture is requested, the bounding rectangle includes only bi-level glyphs. Otherwise, the bounding rectangle includes only anti-aliased glyphs.</param>
        /// <param name="textureBounds">Receives the bounding rectangle, or an empty rectangle if there are no glyphs if the specified type.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAlphaTextureBounds(IDWriteGlyphRunAnalysis* This, DWRITE_TEXTURE_TYPE textureType, RECT* textureBounds);

        /// <summary>Creates an alpha texture of the specified type.</summary>
        /// <param name="textureType">Specifies the type of texture requested. If a bi-level texture is requested, the texture contains only bi-level glyphs. Otherwise, the texture contains only anti-aliased glyphs.</param>
        /// <param name="textureBounds">Specifies the bounding rectangle of the texture, which can be different than the bounding rectangle returned by GetAlphaTextureBounds.</param>
        /// <param name="alphaValues">Receives the array of alpha values.</param>
        /// <param name="bufferSize">Size of the alphaValues array. The minimum size depends on the dimensions of the rectangle and the type of texture requested.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateAlphaTexture(IDWriteGlyphRunAnalysis* This, DWRITE_TEXTURE_TYPE textureType, RECT* textureBounds, [NativeTypeName("BYTE[]")] byte* alphaValues, [NativeTypeName("UINT32")] uint bufferSize);

        /// <summary>Gets properties required for ClearType blending.</summary>
        /// <param name="renderingParams">Rendering parameters object. In most cases, the values returned in the output parameters are based on the properties of this object. The exception is if a GDI-compatible rendering mode is specified.</param>
        /// <param name="blendGamma">Receives the gamma value to use for gamma correction.</param>
        /// <param name="blendEnhancedContrast">Receives the enhanced contrast value.</param>
        /// <param name="blendClearTypeLevel">Receives the ClearType level.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAlphaBlendParams(IDWriteGlyphRunAnalysis* This, IDWriteRenderingParams* renderingParams, [NativeTypeName("FLOAT")] float* blendGamma, [NativeTypeName("FLOAT")] float* blendEnhancedContrast, [NativeTypeName("FLOAT")] float* blendClearTypeLevel);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteGlyphRunAnalysis* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteGlyphRunAnalysis* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteGlyphRunAnalysis* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAlphaTextureBounds(DWRITE_TEXTURE_TYPE textureType, RECT* textureBounds)
        {
            fixed (IDWriteGlyphRunAnalysis* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAlphaTextureBounds>(lpVtbl->GetAlphaTextureBounds)(This, textureType, textureBounds);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateAlphaTexture(DWRITE_TEXTURE_TYPE textureType, RECT* textureBounds, [NativeTypeName("BYTE[]")] byte* alphaValues, [NativeTypeName("UINT32")] uint bufferSize)
        {
            fixed (IDWriteGlyphRunAnalysis* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateAlphaTexture>(lpVtbl->CreateAlphaTexture)(This, textureType, textureBounds, alphaValues, bufferSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAlphaBlendParams(IDWriteRenderingParams* renderingParams, [NativeTypeName("FLOAT")] float* blendGamma, [NativeTypeName("FLOAT")] float* blendEnhancedContrast, [NativeTypeName("FLOAT")] float* blendClearTypeLevel)
        {
            fixed (IDWriteGlyphRunAnalysis* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAlphaBlendParams>(lpVtbl->GetAlphaBlendParams)(This, renderingParams, blendGamma, blendEnhancedContrast, blendClearTypeLevel);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetAlphaTextureBounds;

            public IntPtr CreateAlphaTexture;

            public IntPtr GetAlphaBlendParams;
        }
    }
}
