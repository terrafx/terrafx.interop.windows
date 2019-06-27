// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("3FF7715F-3CDC-4DC6-9B72-EC5621DCCAFD")]
    public unsafe struct IDWriteFontSetBuilder1
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteFontSetBuilder1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteFontSetBuilder1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteFontSetBuilder1* This
        );
        #endregion

        #region IDWriteFontSetBuilder Delegates
        /// <summary>Adds a reference to a font to the set being built. The necessary metadata will automatically be extracted from the font upon calling CreateFontSet.</summary>
        /// <param name="fontFaceReference">Font face reference object to add to the set.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AddFontFaceReference(
            [In] IDWriteFontSetBuilder1* This,
            [In] IDWriteFontFaceReference* fontFaceReference
        );

        /// <summary>Adds a reference to a font to the set being built. The caller supplies enough information to search on, avoiding the need to open the potentially non-local font. Any properties not supplied by the caller will be missing, and those properties will not be available as filters in GetMatchingFonts. GetPropertyValues for missing properties will return an empty string list. The properties passed should generally be consistent with the actual font contents, but they need not be. You could, for example, alias a font using a different name or unique identifier, or you could set custom tags not present in the actual font.</summary>
        /// <param name="fontFaceReference">Reference to the font.</param>
        /// <param name="properties">List of properties to associate with the reference.</param>
        /// <param name="propertyCount">How many properties are defined.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AddFontFaceReference1(
            [In] IDWriteFontSetBuilder1* This,
            [In] IDWriteFontFaceReference* fontFaceReference,
            [In, NativeTypeName("DWRITE_FONT_PROPERTY[]")] DWRITE_FONT_PROPERTY* properties,
            [In, NativeTypeName("UINT32")] uint propertyCount
        );

        /// <summary>Appends an existing font set to the one being built, allowing one to aggregate two sets or to essentially extend an existing one.</summary>
        /// <param name="fontSet">Font set to append font face references from.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AddFontSet(
            [In] IDWriteFontSetBuilder1* This,
            [In] IDWriteFontSet* fontSet
        );

        /// <summary>Creates a font set from all the font face references added so far via AddFontFaceReference.</summary>
        /// <param name="fontSet">Contains newly created font set object, or nullptr in case of failure.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> Creating a font set takes less time if the references were added with metadata rather than needing to extract the metadata from the font file.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateFontSet(
            [In] IDWriteFontSetBuilder1* This,
            [Out] IDWriteFontSet** fontSet
        );
        #endregion

        #region Delegates
        /// <summary>Adds references to all the fonts in the specified font file. The method parses the font file to determine the fonts and their properties.</summary>
        /// <param name="fontFile">Font file reference object to add to the set.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AddFontFile(
            [In] IDWriteFontSetBuilder1* This,
            [In] IDWriteFontFile* fontFile
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteFontSetBuilder1* This = &this)
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
            fixed (IDWriteFontSetBuilder1* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontSetBuilder1* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region IDWriteFontSetBuilder Methods
        [return: NativeTypeName("HRESULT")]
        public int AddFontFaceReference(
            [In] IDWriteFontFaceReference* fontFaceReference
        )
        {
            fixed (IDWriteFontSetBuilder1* This = &this)
            {
                return MarshalFunction<_AddFontFaceReference>(lpVtbl->AddFontFaceReference)(
                    This,
                    fontFaceReference
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontFaceReference1(
            [In] IDWriteFontFaceReference* fontFaceReference,
            [In, NativeTypeName("DWRITE_FONT_PROPERTY[]")] DWRITE_FONT_PROPERTY* properties,
            [In, NativeTypeName("UINT32")] uint propertyCount
        )
        {
            fixed (IDWriteFontSetBuilder1* This = &this)
            {
                return MarshalFunction<_AddFontFaceReference1>(lpVtbl->AddFontFaceReference1)(
                    This,
                    fontFaceReference,
                    properties,
                    propertyCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontSet(
            [In] IDWriteFontSet* fontSet
        )
        {
            fixed (IDWriteFontSetBuilder1* This = &this)
            {
                return MarshalFunction<_AddFontSet>(lpVtbl->AddFontSet)(
                    This,
                    fontSet
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontSet(
            [Out] IDWriteFontSet** fontSet
        )
        {
            fixed (IDWriteFontSetBuilder1* This = &this)
            {
                return MarshalFunction<_CreateFontSet>(lpVtbl->CreateFontSet)(
                    This,
                    fontSet
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int AddFontFile(
            [In] IDWriteFontFile* fontFile
        )
        {
            fixed (IDWriteFontSetBuilder1* This = &this)
            {
                return MarshalFunction<_AddFontFile>(lpVtbl->AddFontFile)(
                    This,
                    fontFile
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

            #region IDWriteFontSetBuilder Fields
            public IntPtr AddFontFaceReference;

            public IntPtr AddFontFaceReference1;

            public IntPtr AddFontSet;

            public IntPtr CreateFontSet;
            #endregion

            #region Fields
            public IntPtr AddFontFile;
            #endregion
        }
        #endregion
    }
}
