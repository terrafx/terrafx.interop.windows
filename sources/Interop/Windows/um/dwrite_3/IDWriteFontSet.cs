// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("53585141-D9F8-4095-8321-D73CF6BD116B")]
    public unsafe struct IDWriteFontSet
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteFontSet* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteFontSet* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteFontSet* This
        );

        /// <summary>Get the number of total fonts in the set.</summary>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetFontCount(
            [In] IDWriteFontSet* This
        );

        /// <summary>Get a reference to the font at this index, which may be local or remote.</summary>
        /// <param name="listIndex">Zero-based index of the font.</param>
        /// <param name="fontFaceReference">Receives a pointer the font face reference object, or nullptr on failure.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontFaceReference(
            [In] IDWriteFontSet* This,
            [In, NativeTypeName("UINT32")] uint listIndex,
            [Out] IDWriteFontFaceReference** fontFaceReference
        );

        /// <summary>Gets the index of the matching font face reference in the font set, with the same file, face index, and simulations.</summary>
        /// <param name="fontFaceReference">Font face reference object that specifies the physical font.</param>
        /// <param name="listIndex">Receives the zero-based index of the matching font if the font was found, or UINT_MAX otherwise.</param>
        /// <param name="exists">Receives TRUE if the font exists or FALSE otherwise.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _FindFontFaceReference(
            [In] IDWriteFontSet* This,
            [In] IDWriteFontFaceReference* fontFaceReference,
            [Out, NativeTypeName("UINT32")] uint* listIndex,
            [Out, NativeTypeName("BOOL")] int* exists
        );

        /// <summary>Gets the index of the matching font face reference in the font set, with the same file, face index, and simulations.</summary>
        /// <param name="fontFace">Font face object that specifies the physical font.</param>
        /// <param name="listIndex">Receives the zero-based index of the matching font if the font was found, or UINT_MAX otherwise.</param>
        /// <param name="exists">Receives TRUE if the font exists or FALSE otherwise.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _FindFontFace(
            [In] IDWriteFontSet* This,
            [In] IDWriteFontFace* fontFace,
            [Out, NativeTypeName("UINT32")] uint* listIndex,
            [Out, NativeTypeName("BOOL")] int* exists
        );

        /// <summary>Returns the property values of a specific font item index.</summary>
        /// <param name="listIndex">Zero-based index of the font.</param>
        /// <param name="propertyId">Font property of interest.</param>
        /// <param name="exists">Receives the value TRUE if the font contains the specified property identifier or FALSE if not.</param>
        /// <param name="values">Receives a pointer to the newly created localized strings object, or nullptr on failure or non-existent property.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPropertyValues(
            [In] IDWriteFontSet* This,
            [In, NativeTypeName("UINT32")] uint listIndex,
            [In] DWRITE_FONT_PROPERTY_ID propertyId,
            [Out, NativeTypeName("BOOL")] int* exists,
            [Out] IDWriteLocalizedStrings** values
        );

        /// <summary>Returns all unique property values in the set, which can be used for purposes such as displaying a family list or tag cloud. Values are returned in priority order according to the language list, such that if a font contains more than one localized name, the preferred one will be returned.</summary>
        /// <param name="propertyID">Font property of interest.</param>
        /// <param name="preferredLocaleNames">List of semicolon delimited language names in preferred order. When a particular string like font family has more than one localized name, the first match is returned.</param>
        /// <param name="values">Receives a pointer to the newly created strings list.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> For example, suppose the font set includes the Meiryo family, which has both Japanese and English family names. The returned list of distinct family names would include either the Japanese name (if "ja-jp" was specified as a preferred locale) or the English name (in all other cases).</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPropertyValues1(
            [In] IDWriteFontSet* This,
            [In] DWRITE_FONT_PROPERTY_ID propertyID,
            [In, NativeTypeName("WCHAR[]")] char* preferredLocaleNames,
            [Out] IDWriteStringList** values
        );

        /// <summary>Returns all unique property values in the set, which can be used for purposes such as displaying a family list or tag cloud. All values are returned regardless of language, including all localized names.</summary>
        /// <param name="propertyID">Font property of interest.</param>
        /// <param name="values">Receives a pointer to the newly created strings list.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> For example, suppose the font set includes the Meiryo family, which has both Japanese and English family names. The returned list of distinct family names would include both the Japanese and English names.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPropertyValues2(
            [In] IDWriteFontSet* This,
            [In] DWRITE_FONT_PROPERTY_ID propertyID,
            [Out] IDWriteStringList** values
        );

        /// <summary>Returns how many times a given property value occurs in the set.</summary>
        /// <param name="property">Font property of interest.</param>
        /// <param name="propertyOccurrenceCount">How many times that property occurs.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> For example, the family name "Segoe UI" may return a count of 12, whereas Harrington only has 1.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPropertyOccurrenceCount(
            [In] IDWriteFontSet* This,
            [In] DWRITE_FONT_PROPERTY* property,
            [Out, NativeTypeName("UINT32")] uint* propertyOccurrenceCount
        );

        /// <summary>Returns a subset of fonts filtered by the given properties.</summary>
        /// <param name="properties">List of properties to filter using.</param>
        /// <param name="propertyCount">How many properties to filter.</param>
        /// <param name="filteredSet">Subset of fonts that match the properties, or nullptr on failure.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> If no fonts matched the filter, the subset will be empty (GetFontCount returns 0), but the function does not return an error. The subset will always be equal to or less than the original set.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMatchingFonts(
            [In] IDWriteFontSet* This,
            [In, NativeTypeName("DWRITE_FONT_PROPERTY[]")] DWRITE_FONT_PROPERTY* properties,
            [In, NativeTypeName("UINT32")] uint propertyCount,
            [Out] IDWriteFontSet** filteredSet
        );

        /// <summary>Returns a list of fonts within the given WWS family prioritized by WWS distance.</summary>
        /// <param name="familyName">Neutral or localized family name of font.</param>
        /// <param name="fontWeight">Weight of font.</param>
        /// <param name="fontStretch">Stretch of font.</param>
        /// <param name="fontStyle">Slope of font.</param>
        /// <param name="filteredSet">Subset of fonts that match the properties, or nullptr on failure.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> The returned list can include simulated bold and oblique variants, which would be useful for font fallback selection.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMatchingFonts1(
            [In] IDWriteFontSet* This,
            [In, NativeTypeName("WCHAR[]")] char* familyName,
            [In] DWRITE_FONT_WEIGHT fontWeight,
            [In] DWRITE_FONT_STRETCH fontStretch,
            [In] DWRITE_FONT_STYLE fontStyle,
            [Out] IDWriteFontSet** filteredSet
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteFontSet* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteFontSet* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontSet* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontCount()
        {
            fixed (IDWriteFontSet* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontCount>(lpVtbl->GetFontCount)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference(
            [In, NativeTypeName("UINT32")] uint listIndex,
            [Out] IDWriteFontFaceReference** fontFaceReference
        )
        {
            fixed (IDWriteFontSet* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFaceReference>(lpVtbl->GetFontFaceReference)(
                    This,
                    listIndex,
                    fontFaceReference
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FindFontFaceReference(
            [In] IDWriteFontFaceReference* fontFaceReference,
            [Out, NativeTypeName("UINT32")] uint* listIndex,
            [Out, NativeTypeName("BOOL")] int* exists
        )
        {
            fixed (IDWriteFontSet* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FindFontFaceReference>(lpVtbl->FindFontFaceReference)(
                    This,
                    fontFaceReference,
                    listIndex,
                    exists
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FindFontFace(
            [In] IDWriteFontFace* fontFace,
            [Out, NativeTypeName("UINT32")] uint* listIndex,
            [Out, NativeTypeName("BOOL")] int* exists
        )
        {
            fixed (IDWriteFontSet* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FindFontFace>(lpVtbl->FindFontFace)(
                    This,
                    fontFace,
                    listIndex,
                    exists
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyValues(
            [In, NativeTypeName("UINT32")] uint listIndex,
            [In] DWRITE_FONT_PROPERTY_ID propertyId,
            [Out, NativeTypeName("BOOL")] int* exists,
            [Out] IDWriteLocalizedStrings** values
        )
        {
            fixed (IDWriteFontSet* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPropertyValues>(lpVtbl->GetPropertyValues)(
                    This,
                    listIndex,
                    propertyId,
                    exists,
                    values
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyValues1(
            [In] DWRITE_FONT_PROPERTY_ID propertyID,
            [In, NativeTypeName("WCHAR[]")] char* preferredLocaleNames,
            [Out] IDWriteStringList** values
        )
        {
            fixed (IDWriteFontSet* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPropertyValues1>(lpVtbl->GetPropertyValues1)(
                    This,
                    propertyID,
                    preferredLocaleNames,
                    values
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyValues2(
            [In] DWRITE_FONT_PROPERTY_ID propertyID,
            [Out] IDWriteStringList** values
        )
        {
            fixed (IDWriteFontSet* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPropertyValues2>(lpVtbl->GetPropertyValues2)(
                    This,
                    propertyID,
                    values
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyOccurrenceCount(
            [In] DWRITE_FONT_PROPERTY* property,
            [Out, NativeTypeName("UINT32")] uint* propertyOccurrenceCount
        )
        {
            fixed (IDWriteFontSet* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPropertyOccurrenceCount>(lpVtbl->GetPropertyOccurrenceCount)(
                    This,
                    property,
                    propertyOccurrenceCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts(
            [In, NativeTypeName("DWRITE_FONT_PROPERTY[]")] DWRITE_FONT_PROPERTY* properties,
            [In, NativeTypeName("UINT32")] uint propertyCount,
            [Out] IDWriteFontSet** filteredSet
        )
        {
            fixed (IDWriteFontSet* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMatchingFonts>(lpVtbl->GetMatchingFonts)(
                    This,
                    properties,
                    propertyCount,
                    filteredSet
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts1(
            [In, NativeTypeName("WCHAR[]")] char* familyName,
            [In] DWRITE_FONT_WEIGHT fontWeight,
            [In] DWRITE_FONT_STRETCH fontStretch,
            [In] DWRITE_FONT_STYLE fontStyle,
            [Out] IDWriteFontSet** filteredSet
        )
        {
            fixed (IDWriteFontSet* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMatchingFonts1>(lpVtbl->GetMatchingFonts1)(
                    This,
                    familyName,
                    fontWeight,
                    fontStretch,
                    fontStyle,
                    filteredSet
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFontCount;

            public IntPtr GetFontFaceReference;

            public IntPtr FindFontFaceReference;

            public IntPtr FindFontFace;

            public IntPtr GetPropertyValues;

            public IntPtr GetPropertyValues1;

            public IntPtr GetPropertyValues2;

            public IntPtr GetPropertyOccurrenceCount;

            public IntPtr GetMatchingFonts;

            public IntPtr GetMatchingFonts1;
        }
    }
}
