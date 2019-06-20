// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using TerraFX.Utilities;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>Interface that encapsulates information used to render a glyph run.</summary>
    [Guid("7D97DBF7-E085-42D4-81E3-6A883BDED118")]
    [Unmanaged]
    public unsafe struct IDWriteGlyphRunAnalysis
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteGlyphRunAnalysis* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteGlyphRunAnalysis* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteGlyphRunAnalysis* This
        );
        #endregion

        #region Delegates
        /// <summary>Gets the bounding rectangle of the physical pixels affected by the glyph run.</summary>
        /// <param name="textureType">Specifies the type of texture requested. If a bi-level texture is requested, the bounding rectangle includes only bi-level glyphs. Otherwise, the bounding rectangle includes only anti-aliased glyphs.</param>
        /// <param name="textureBounds">Receives the bounding rectangle, or an empty rectangle if there are no glyphs if the specified type.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetAlphaTextureBounds(
            [In] IDWriteGlyphRunAnalysis* This,
            [In] DWRITE_TEXTURE_TYPE textureType,
            [Out] RECT* textureBounds
        );

        /// <summary>Creates an alpha texture of the specified type.</summary>
        /// <param name="textureType">Specifies the type of texture requested. If a bi-level texture is requested, the texture contains only bi-level glyphs. Otherwise, the texture contains only anti-aliased glyphs.</param>
        /// <param name="textureBounds">Specifies the bounding rectangle of the texture, which can be different than the bounding rectangle returned by GetAlphaTextureBounds.</param>
        /// <param name="alphaValues">Receives the array of alpha values.</param>
        /// <param name="bufferSize">Size of the alphaValues array. The minimum size depends on the dimensions of the rectangle and the type of texture requested.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateAlphaTexture(
            [In] IDWriteGlyphRunAnalysis* This,
            [In] DWRITE_TEXTURE_TYPE textureType,
            [In] RECT* textureBounds,
            [Out, NativeTypeName("BYTE[]")] byte* alphaValues,
            [In, NativeTypeName("UINT32")] uint bufferSize
        );

        /// <summary>Gets properties required for ClearType blending.</summary>
        /// <param name="renderingParams">Rendering parameters object. In most cases, the values returned in the output parameters are based on the properties of this object. The exception is if a GDI-compatible rendering mode is specified.</param>
        /// <param name="blendGamma">Receives the gamma value to use for gamma correction.</param>
        /// <param name="blendEnhancedContrast">Receives the enhanced contrast value.</param>
        /// <param name="blendClearTypeLevel">Receives the ClearType level.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetAlphaBlendParams(
            [In] IDWriteGlyphRunAnalysis* This,
            [In] IDWriteRenderingParams* renderingParams,
            [Out, NativeTypeName("FLOAT")] float* blendGamma,
            [Out, NativeTypeName("FLOAT")] float* blendEnhancedContrast,
            [Out, NativeTypeName("FLOAT")] float* blendClearTypeLevel
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteGlyphRunAnalysis* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteGlyphRunAnalysis* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteGlyphRunAnalysis* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int GetAlphaTextureBounds(
            [In] DWRITE_TEXTURE_TYPE textureType,
            [Out] RECT* textureBounds
        )
        {
            fixed (IDWriteGlyphRunAnalysis* This = &this)
            {
                return MarshalFunction<_GetAlphaTextureBounds>(lpVtbl->GetAlphaTextureBounds)(
                    This,
                    textureType,
                    textureBounds
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateAlphaTexture(
            [In] DWRITE_TEXTURE_TYPE textureType,
            [In] RECT* textureBounds,
            [Out, NativeTypeName("BYTE[]")] byte* alphaValues,
            [In, NativeTypeName("UINT32")] uint bufferSize
        )
        {
            fixed (IDWriteGlyphRunAnalysis* This = &this)
            {
                return MarshalFunction<_CreateAlphaTexture>(lpVtbl->CreateAlphaTexture)(
                    This,
                    textureType,
                    textureBounds,
                    alphaValues,
                    bufferSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAlphaBlendParams(
            [In] IDWriteRenderingParams* renderingParams,
            [Out, NativeTypeName("FLOAT")] float* blendGamma,
            [Out, NativeTypeName("FLOAT")] float* blendEnhancedContrast,
            [Out, NativeTypeName("FLOAT")] float* blendClearTypeLevel
        )
        {
            fixed (IDWriteGlyphRunAnalysis* This = &this)
            {
                return MarshalFunction<_GetAlphaBlendParams>(lpVtbl->GetAlphaBlendParams)(
                    This,
                    renderingParams,
                    blendGamma,
                    blendEnhancedContrast,
                    blendClearTypeLevel
                );
            }
        }
        #endregion

        #region Structs
        [Unmanaged]
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region Fields
            public IntPtr GetAlphaTextureBounds;

            public IntPtr CreateAlphaTexture;

            public IntPtr GetAlphaBlendParams;
            #endregion
        }
        #endregion
    }
}
