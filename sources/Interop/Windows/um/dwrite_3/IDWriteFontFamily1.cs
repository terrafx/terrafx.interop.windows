// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>The IDWriteFontFamily interface represents a set of fonts that share the same design but are differentiated by weight, stretch, and style.</summary>
    [Guid("DA20D8EF-812A-4C43-9802-62EC4ABD7ADF")]
    public unsafe struct IDWriteFontFamily1
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteFontFamily1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteFontFamily1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteFontFamily1* This
        );
        #endregion

        #region IDWriteFontList Delegates
        /// <summary>Gets the font collection that contains the fonts.</summary>
        /// <param name="fontCollection">Receives a pointer to the font collection object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontCollection(
            [In] IDWriteFontFamily1* This,
            [Out] IDWriteFontCollection** fontCollection
        );

        /// <summary>Gets the number of fonts in the font list.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetFontCount(
            [In] IDWriteFontFamily1* This
        );

        /// <summary>Gets a font given its zero-based index.</summary>
        /// <param name="index">Zero-based index of the font in the font list.</param>
        /// <param name="font">Receives a pointer to the newly created font object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFont(
            [In] IDWriteFontFamily1* This,
            [In, NativeTypeName("UINT32")] uint index,
            [Out] IDWriteFont** font
        );
        #endregion

        #region IDWriteFontFamily Delegates
        /// <summary>Creates a localized strings object that contains the family names for the font family, indexed by locale name.</summary>
        /// <param name="names">Receives a pointer to the newly created localized strings object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFamilyNames(
            [In] IDWriteFontFamily1* This,
            [Out] IDWriteLocalizedStrings** names
        );

        /// <summary>Gets the font that best matches the specified properties.</summary>
        /// <param name="weight">Requested font weight.</param>
        /// <param name="stretch">Requested font stretch.</param>
        /// <param name="style">Requested font style.</param>
        /// <param name="matchingFont">Receives a pointer to the newly created font object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFirstMatchingFont(
            [In] IDWriteFontFamily1* This,
            [In] DWRITE_FONT_WEIGHT weight,
            [In] DWRITE_FONT_STRETCH stretch,
            [In] DWRITE_FONT_STYLE style,
            [Out] IDWriteFont** matchingFont
        );

        /// <summary>Gets a list of fonts in the font family ranked in order of how well they match the specified properties.</summary>
        /// <param name="weight">Requested font weight.</param>
        /// <param name="stretch">Requested font stretch.</param>
        /// <param name="style">Requested font style.</param>
        /// <param name="matchingFonts">Receives a pointer to the newly created font list object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMatchingFonts(
            [In] IDWriteFontFamily1* This,
            [In] DWRITE_FONT_WEIGHT weight,
            [In] DWRITE_FONT_STRETCH stretch,
            [In] DWRITE_FONT_STYLE style,
            [Out] IDWriteFontList** matchingFonts
        );
        #endregion

        #region Delegates
        /// <summary>Gets the current locality of a font given its zero-based index.</summary>
        /// <param name="listIndex">Zero-based index of the font in the font list.</param>
        /// <remarks> The locality enumeration. For fully local files, the result will always be DWRITE_LOCALITY_LOCAL. For downloadable files, the result depends on how much of the file has been downloaded, and GetFont() fails if the locality is REMOTE and potentially fails if PARTIAL. The application can explicitly ask for the font to be enqueued for download via EnqueueFontDownloadRequest followed by BeginDownload().</remarks>
        /// <returns> The locality enumeration.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_LOCALITY _GetFontLocality(
            [In] IDWriteFontFamily1* This,
            [In, NativeTypeName("UINT32")] uint listIndex
        );

        /// <summary>Gets a font given its zero-based index.</summary>
        /// <param name="listIndex">Zero-based index of the font in the font list.</param>
        /// <param name="font">Receives a pointer to the newly created font object.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFont1(
            [In] IDWriteFontFamily1* This,
            [In, NativeTypeName("UINT32")] uint listIndex,
            [Out] IDWriteFont3** font
        );

        /// <summary>Gets a font face reference given its zero-based index.</summary>
        /// <param name="listIndex">Zero-based index of the font in the font list.</param>
        /// <param name="fontFaceReference">Receives a pointer to the newly created font face reference object.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontFaceReference(
            [In] IDWriteFontFamily1* This,
            [In, NativeTypeName("UINT32")] uint listIndex,
            [Out] IDWriteFontFaceReference** fontFaceReference
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteFontFamily1* This = &this)
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
            fixed (IDWriteFontFamily1* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region IDWriteFontList Methods
        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection(
            [Out] IDWriteFontCollection** fontCollection
        )
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return MarshalFunction<_GetFontCollection>(lpVtbl->GetFontCollection)(
                    This,
                    fontCollection
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontCount()
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return MarshalFunction<_GetFontCount>(lpVtbl->GetFontCount)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFont(
            [In, NativeTypeName("UINT32")] uint index,
            [Out] IDWriteFont** font
        )
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return MarshalFunction<_GetFont>(lpVtbl->GetFont)(
                    This,
                    index,
                    font
                );
            }
        }
        #endregion

        #region IDWriteFontFamily Methods
        [return: NativeTypeName("HRESULT")]
        public int GetFamilyNames(
            [Out] IDWriteLocalizedStrings** names
        )
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return MarshalFunction<_GetFamilyNames>(lpVtbl->GetFamilyNames)(
                    This,
                    names
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFirstMatchingFont(
            [In] DWRITE_FONT_WEIGHT weight,
            [In] DWRITE_FONT_STRETCH stretch,
            [In] DWRITE_FONT_STYLE style,
            [Out] IDWriteFont** matchingFont
        )
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return MarshalFunction<_GetFirstMatchingFont>(lpVtbl->GetFirstMatchingFont)(
                    This,
                    weight,
                    stretch,
                    style,
                    matchingFont
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts(
            [In] DWRITE_FONT_WEIGHT weight,
            [In] DWRITE_FONT_STRETCH stretch,
            [In] DWRITE_FONT_STYLE style,
            [Out] IDWriteFontList** matchingFonts
        )
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return MarshalFunction<_GetMatchingFonts>(lpVtbl->GetMatchingFonts)(
                    This,
                    weight,
                    stretch,
                    style,
                    matchingFonts
                );
            }
        }
        #endregion

        #region Methods
        public DWRITE_LOCALITY GetFontLocality(
            [In, NativeTypeName("UINT32")] uint listIndex
        )
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return MarshalFunction<_GetFontLocality>(lpVtbl->GetFontLocality)(
                    This,
                    listIndex
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFont1(
            [In, NativeTypeName("UINT32")] uint listIndex,
            [Out] IDWriteFont3** font
        )
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return MarshalFunction<_GetFont1>(lpVtbl->GetFont1)(
                    This,
                    listIndex,
                    font
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference(
            [In, NativeTypeName("UINT32")] uint listIndex,
            [Out] IDWriteFontFaceReference** fontFaceReference
        )
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return MarshalFunction<_GetFontFaceReference>(lpVtbl->GetFontFaceReference)(
                    This,
                    listIndex,
                    fontFaceReference
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region IDWriteFontList Fields
            public IntPtr GetFontCollection;

            public IntPtr GetFontCount;

            public IntPtr GetFont;
            #endregion

            #region IDWriteFontFamily Fields
            public IntPtr GetFamilyNames;

            public IntPtr GetFirstMatchingFont;

            public IntPtr GetMatchingFonts;
            #endregion

            #region Fields
            public IntPtr GetFontLocality;

            public IntPtr GetFont1;

            public IntPtr GetFontFaceReference;
            #endregion
        }
        #endregion
    }
}
