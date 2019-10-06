// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The IDWriteFontFamily interface represents a set of fonts that share the same design but are differentiated by weight, stretch, and style.</summary>
    [Guid("DA20D8EF-812A-4C43-9802-62EC4ABD7ADF")]
    public unsafe partial struct IDWriteFontFamily1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontFamily1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontFamily1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontFamily1* This);

        /// <summary>Gets the font collection that contains the fonts.</summary>
        /// <param name="fontCollection">Receives a pointer to the font collection object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontCollection(IDWriteFontFamily1* This, IDWriteFontCollection** fontCollection);

        /// <summary>Gets the number of fonts in the font list.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetFontCount(IDWriteFontFamily1* This);

        /// <summary>Gets a font given its zero-based index.</summary>
        /// <param name="index">Zero-based index of the font in the font list.</param>
        /// <param name="font">Receives a pointer to the newly created font object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFont(IDWriteFontFamily1* This, [NativeTypeName("UINT32")] uint index, IDWriteFont** font);

        /// <summary>Creates a localized strings object that contains the family names for the font family, indexed by locale name.</summary>
        /// <param name="names">Receives a pointer to the newly created localized strings object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFamilyNames(IDWriteFontFamily1* This, IDWriteLocalizedStrings** names);

        /// <summary>Gets the font that best matches the specified properties.</summary>
        /// <param name="weight">Requested font weight.</param>
        /// <param name="stretch">Requested font stretch.</param>
        /// <param name="style">Requested font style.</param>
        /// <param name="matchingFont">Receives a pointer to the newly created font object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFirstMatchingFont(IDWriteFontFamily1* This, DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, IDWriteFont** matchingFont);

        /// <summary>Gets a list of fonts in the font family ranked in order of how well they match the specified properties.</summary>
        /// <param name="weight">Requested font weight.</param>
        /// <param name="stretch">Requested font stretch.</param>
        /// <param name="style">Requested font style.</param>
        /// <param name="matchingFonts">Receives a pointer to the newly created font list object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMatchingFonts(IDWriteFontFamily1* This, DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, IDWriteFontList** matchingFonts);

        /// <summary>Gets the current locality of a font given its zero-based index.</summary>
        /// <param name="listIndex">Zero-based index of the font in the font list.</param>
        /// <remarks> The locality enumeration. For fully local files, the result will always be DWRITE_LOCALITY_LOCAL. For downloadable files, the result depends on how much of the file has been downloaded, and GetFont() fails if the locality is REMOTE and potentially fails if PARTIAL. The application can explicitly ask for the font to be enqueued for download via EnqueueFontDownloadRequest followed by BeginDownload().</remarks>
        /// <returns> The locality enumeration.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_LOCALITY _GetFontLocality(IDWriteFontFamily1* This, [NativeTypeName("UINT32")] uint listIndex);

        /// <summary>Gets a font given its zero-based index.</summary>
        /// <param name="listIndex">Zero-based index of the font in the font list.</param>
        /// <param name="font">Receives a pointer to the newly created font object.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFont1(IDWriteFontFamily1* This, [NativeTypeName("UINT32")] uint listIndex, IDWriteFont3** font);

        /// <summary>Gets a font face reference given its zero-based index.</summary>
        /// <param name="listIndex">Zero-based index of the font in the font list.</param>
        /// <param name="fontFaceReference">Receives a pointer to the newly created font face reference object.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFaceReference(IDWriteFontFamily1* This, [NativeTypeName("UINT32")] uint listIndex, IDWriteFontFaceReference** fontFaceReference);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection(IDWriteFontCollection** fontCollection)
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontCollection>(lpVtbl->GetFontCollection)(This, fontCollection);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontCount()
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontCount>(lpVtbl->GetFontCount)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFont([NativeTypeName("UINT32")] uint index, IDWriteFont** font)
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFont>(lpVtbl->GetFont)(This, index, font);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFamilyNames(IDWriteLocalizedStrings** names)
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFamilyNames>(lpVtbl->GetFamilyNames)(This, names);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFirstMatchingFont(DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, IDWriteFont** matchingFont)
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFirstMatchingFont>(lpVtbl->GetFirstMatchingFont)(This, weight, stretch, style, matchingFont);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts(DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, IDWriteFontList** matchingFonts)
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMatchingFonts>(lpVtbl->GetMatchingFonts)(This, weight, stretch, style, matchingFonts);
            }
        }

        public DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex)
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontLocality>(lpVtbl->GetFontLocality)(This, listIndex);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFont1([NativeTypeName("UINT32")] uint listIndex, IDWriteFont3** font)
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFont1>(lpVtbl->GetFont1)(This, listIndex, font);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFaceReference** fontFaceReference)
        {
            fixed (IDWriteFontFamily1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFaceReference>(lpVtbl->GetFontFaceReference)(This, listIndex, fontFaceReference);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFontCollection;

            public IntPtr GetFontCount;

            public IntPtr GetFont;

            public IntPtr GetFamilyNames;

            public IntPtr GetFirstMatchingFont;

            public IntPtr GetMatchingFonts;

            public IntPtr GetFontLocality;

            public IntPtr GetFont1;

            public IntPtr GetFontFaceReference;
        }
    }
}
