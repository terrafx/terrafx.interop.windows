// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>The format of text used for text layout.</summary>
    /// <remarks> This object may not be thread-safe and it may carry the state of text format change.</remarks>
    [Guid("5F174B49-0D8B-4CFB-8BCA-F1CCE9D06C67")]
    public unsafe struct IDWriteTextFormat1
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteTextFormat1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteTextFormat1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteTextFormat1* This
        );
        #endregion

        #region IDWriteTextFormat Delegates
        /// <summary>Set alignment option of text relative to layout box's leading and trailing edge.</summary>
        /// <param name="textAlignment">Text alignment option</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetTextAlignment(
            [In] IDWriteTextFormat1* This,
            [In] DWRITE_TEXT_ALIGNMENT textAlignment
        );

        /// <summary>Set alignment option of paragraph relative to layout box's top and bottom edge.</summary>
        /// <param name="paragraphAlignment">Paragraph alignment option</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetParagraphAlignment(
            [In] IDWriteTextFormat1* This,
            [In] DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment
        );

        /// <summary>Set word wrapping option.</summary>
        /// <param name="wordWrapping">Word wrapping option</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetWordWrapping(
            [In] IDWriteTextFormat1* This,
            [In] DWRITE_WORD_WRAPPING wordWrapping
        );

        /// <summary>Set paragraph reading direction.</summary>
        /// <param name="readingDirection">Text reading direction</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> The flow direction must be perpendicular to the reading direction. Setting both to a vertical direction or both to horizontal yields DWRITE_E_FLOWDIRECTIONCONFLICTS when calling GetMetrics or Draw.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetReadingDirection(
            [In] IDWriteTextFormat1* This,
            [In] DWRITE_READING_DIRECTION readingDirection
        );

        /// <summary>Set paragraph flow direction.</summary>
        /// <param name="flowDirection">Paragraph flow direction</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> The flow direction must be perpendicular to the reading direction. Setting both to a vertical direction or both to horizontal yields DWRITE_E_FLOWDIRECTIONCONFLICTS when calling GetMetrics or Draw.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetFlowDirection(
            [In] IDWriteTextFormat1* This,
            [In] DWRITE_FLOW_DIRECTION flowDirection
        );

        /// <summary>Set incremental tab stop position.</summary>
        /// <param name="incrementalTabStop">The incremental tab stop value</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetIncrementalTabStop(
            [In] IDWriteTextFormat1* This,
            [In, NativeTypeName("FLOAT")] float incrementalTabStop
        );

        /// <summary>Set trimming options for any trailing text exceeding the layout width or for any far text exceeding the layout height.</summary>
        /// <param name="trimmingOptions">Text trimming options.</param>
        /// <param name="trimmingSign">Application-defined omission sign. This parameter may be NULL if no trimming sign is desired.</param>
        /// <remarks> Any inline object can be used for the trimming sign, but CreateEllipsisTrimmingSign provides a typical ellipsis symbol. Trimming is also useful vertically for hiding partial lines.</remarks>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetTrimming(
            [In] IDWriteTextFormat1* This,
            [In] DWRITE_TRIMMING* trimmingOptions,
            [In] IDWriteInlineObject* trimmingSign = null
        );

        /// <summary>Set line spacing.</summary>
        /// <param name="lineSpacingMethod">How to determine line height.</param>
        /// <param name="lineSpacing">The line height, or rather distance between one baseline to another.</param>
        /// <param name="baseline">Distance from top of line to baseline. A reasonable ratio to lineSpacing is 80%.</param>
        /// <remarks> For the default method, spacing depends solely on the content. For uniform spacing, the given line height will override the content.</remarks>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetLineSpacing(
            [In] IDWriteTextFormat1* This,
            [In] DWRITE_LINE_SPACING_METHOD lineSpacingMethod,
            [In, NativeTypeName("FLOAT")] float lineSpacing,
            [In, NativeTypeName("FLOAT")] float baseline
        );

        /// <summary>Get alignment option of text relative to layout box's leading and trailing edge.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_TEXT_ALIGNMENT _GetTextAlignment(
            [In] IDWriteTextFormat1* This
        );

        /// <summary>Get alignment option of paragraph relative to layout box's top and bottom edge.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_PARAGRAPH_ALIGNMENT _GetParagraphAlignment(
            [In] IDWriteTextFormat1* This
        );

        /// <summary>Get word wrapping option.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_WORD_WRAPPING _GetWordWrapping(
            [In] IDWriteTextFormat1* This
        );

        /// <summary>Get paragraph reading direction.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_READING_DIRECTION _GetReadingDirection(
            [In] IDWriteTextFormat1* This
        );

        /// <summary>Get paragraph flow direction.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FLOW_DIRECTION _GetFlowDirection(
            [In] IDWriteTextFormat1* This
        );

        /// <summary>Get incremental tab stop position.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetIncrementalTabStop(
            [In] IDWriteTextFormat1* This
        );

        /// <summary>Get trimming options for text overflowing the layout width.</summary>
        /// <param name="trimmingOptions">Text trimming options.</param>
        /// <param name="trimmingSign">Trimming omission sign. This parameter may be NULL.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetTrimming(
            [In] IDWriteTextFormat1* This,
            [Out] DWRITE_TRIMMING* trimmingOptions,
            [Out] IDWriteInlineObject** trimmingSign
        );

        /// <summary>Get line spacing.</summary>
        /// <param name="lineSpacingMethod">How line height is determined.</param>
        /// <param name="lineSpacing">The line height, or rather distance between one baseline to another.</param>
        /// <param name="baseline">Distance from top of line to baseline.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetLineSpacing(
            [In] IDWriteTextFormat1* This,
            [Out] DWRITE_LINE_SPACING_METHOD* lineSpacingMethod,
            [Out, NativeTypeName("FLOAT")] float* lineSpacing,
            [Out, NativeTypeName("FLOAT")] float* baseline
        );

        /// <summary>Get the font collection.</summary>
        /// <param name="fontCollection">The current font collection.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontCollection(
            [In] IDWriteTextFormat1* This,
            [Out] IDWriteFontCollection** fontCollection
        );

        /// <summary>Get the length of the font family name, in characters, not including the terminating NULL character.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetFontFamilyNameLength(
            [In] IDWriteTextFormat1* This
        );

        /// <summary>Get a copy of the font family name.</summary>
        /// <param name="fontFamilyName">Character array that receives the current font family name</param>
        /// <param name="nameSize">Size of the character array in character count including the terminated NULL character.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontFamilyName(
            [In] IDWriteTextFormat1* This,
            [Out, NativeTypeName("WCHAR[]")] char* fontFamilyName,
            [In, NativeTypeName("UINT32")] uint nameSize
        );

        /// <summary>Get the font weight.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_WEIGHT _GetFontWeight(
            [In] IDWriteTextFormat1* This
        );

        /// <summary>Get the font style.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_STYLE _GetFontStyle(
            [In] IDWriteTextFormat1* This
        );

        /// <summary>Get the font stretch.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_STRETCH _GetFontStretch(
            [In] IDWriteTextFormat1* This
        );

        /// <summary>Get the font em height.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetFontSize(
            [In] IDWriteTextFormat1* This
        );

        /// <summary>Get the length of the locale name, in characters, not including the terminating NULL character.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetLocaleNameLength(
            [In] IDWriteTextFormat1* This
        );

        /// <summary>Get a copy of the locale name.</summary>
        /// <param name="localeName">Character array that receives the current locale name</param>
        /// <param name="nameSize">Size of the character array in character count including the terminated NULL character.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetLocaleName(
            [In] IDWriteTextFormat1* This,
            [Out, NativeTypeName("WCHAR[]")] char* localeName,
            [In, NativeTypeName("UINT32")] uint nameSize
        );
        #endregion

        #region Delegates
        /// <summary>Set the preferred orientation of glyphs when using a vertical reading direction.</summary>
        /// <param name="glyphOrientation">Preferred glyph orientation.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetVerticalGlyphOrientation(
            [In] IDWriteTextFormat1* This,
            [In] DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation
        );

        /// <summary>Get the preferred orientation of glyphs when using a vertical reading direction.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_VERTICAL_GLYPH_ORIENTATION _GetVerticalGlyphOrientation(
            [In] IDWriteTextFormat1* This
        );

        /// <summary>Set whether or not the last word on the last line is wrapped.</summary>
        /// <param name="isLastLineWrappingEnabled">Line wrapping option.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetLastLineWrapping(
            [In] IDWriteTextFormat1* This,
            [In, NativeTypeName("BOOL")] int isLastLineWrappingEnabled
        );

        /// <summary>Get whether or not the last word on the last line is wrapped.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _GetLastLineWrapping(
            [In] IDWriteTextFormat1* This
        );

        /// <summary>Set how the glyphs align to the edges the margin. Default behavior is to align glyphs using their default glyphs metrics which include side bearings.</summary>
        /// <param name="opticalAlignment">Optical alignment option.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetOpticalAlignment(
            [In] IDWriteTextFormat1* This,
            [In] DWRITE_OPTICAL_ALIGNMENT opticalAlignment
        );

        /// <summary>Get how the glyphs align to the edges the margin.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_OPTICAL_ALIGNMENT _GetOpticalAlignment(
            [In] IDWriteTextFormat1* This
        );

        /// <summary>Apply a custom font fallback onto layout. If none is specified, layout uses the system fallback list.</summary>
        /// <param name="fontFallback">Custom font fallback created from IDWriteFontFallbackBuilder::CreateFontFallback or from IDWriteFactory2::GetSystemFontFallback.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetFontFallback(
            [In] IDWriteTextFormat1* This,
            [In] IDWriteFontFallback* fontFallback
        );

        /// <summary>Get the current font fallback object.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontFallback(
            [In] IDWriteTextFormat1* This,
            [Out] IDWriteFontFallback** fontFallback
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
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
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region IDWriteTextFormat Methods
        [return: NativeTypeName("HRESULT")]
        public int SetTextAlignment(
            [In] DWRITE_TEXT_ALIGNMENT textAlignment
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_SetTextAlignment>(lpVtbl->SetTextAlignment)(
                    This,
                    textAlignment
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetParagraphAlignment(
            [In] DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_SetParagraphAlignment>(lpVtbl->SetParagraphAlignment)(
                    This,
                    paragraphAlignment
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWordWrapping(
            [In] DWRITE_WORD_WRAPPING wordWrapping
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_SetWordWrapping>(lpVtbl->SetWordWrapping)(
                    This,
                    wordWrapping
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetReadingDirection(
            [In] DWRITE_READING_DIRECTION readingDirection
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_SetReadingDirection>(lpVtbl->SetReadingDirection)(
                    This,
                    readingDirection
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFlowDirection(
            [In] DWRITE_FLOW_DIRECTION flowDirection
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_SetFlowDirection>(lpVtbl->SetFlowDirection)(
                    This,
                    flowDirection
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetIncrementalTabStop(
            [In, NativeTypeName("FLOAT")] float incrementalTabStop
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_SetIncrementalTabStop>(lpVtbl->SetIncrementalTabStop)(
                    This,
                    incrementalTabStop
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTrimming(
            [In] DWRITE_TRIMMING* trimmingOptions,
            [In] IDWriteInlineObject* trimmingSign = null
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_SetTrimming>(lpVtbl->SetTrimming)(
                    This,
                    trimmingOptions,
                    trimmingSign
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing(
            [In] DWRITE_LINE_SPACING_METHOD lineSpacingMethod,
            [In, NativeTypeName("FLOAT")] float lineSpacing,
            [In, NativeTypeName("FLOAT")] float baseline
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_SetLineSpacing>(lpVtbl->SetLineSpacing)(
                    This,
                    lineSpacingMethod,
                    lineSpacing,
                    baseline
                );
            }
        }

        public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetTextAlignment>(lpVtbl->GetTextAlignment)(
                    This
                );
            }
        }

        public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetParagraphAlignment>(lpVtbl->GetParagraphAlignment)(
                    This
                );
            }
        }

        public DWRITE_WORD_WRAPPING GetWordWrapping()
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetWordWrapping>(lpVtbl->GetWordWrapping)(
                    This
                );
            }
        }

        public DWRITE_READING_DIRECTION GetReadingDirection()
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetReadingDirection>(lpVtbl->GetReadingDirection)(
                    This
                );
            }
        }

        public DWRITE_FLOW_DIRECTION GetFlowDirection()
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetFlowDirection>(lpVtbl->GetFlowDirection)(
                    This
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetIncrementalTabStop()
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetIncrementalTabStop>(lpVtbl->GetIncrementalTabStop)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTrimming(
            [Out] DWRITE_TRIMMING* trimmingOptions,
            [Out] IDWriteInlineObject** trimmingSign
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetTrimming>(lpVtbl->GetTrimming)(
                    This,
                    trimmingOptions,
                    trimmingSign
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing(
            [Out] DWRITE_LINE_SPACING_METHOD* lineSpacingMethod,
            [Out, NativeTypeName("FLOAT")] float* lineSpacing,
            [Out, NativeTypeName("FLOAT")] float* baseline
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetLineSpacing>(lpVtbl->GetLineSpacing)(
                    This,
                    lineSpacingMethod,
                    lineSpacing,
                    baseline
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection(
            [Out] IDWriteFontCollection** fontCollection
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetFontCollection>(lpVtbl->GetFontCollection)(
                    This,
                    fontCollection
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyNameLength()
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetFontFamilyNameLength>(lpVtbl->GetFontFamilyNameLength)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName(
            [Out, NativeTypeName("WCHAR[]")] char* fontFamilyName,
            [In, NativeTypeName("UINT32")] uint nameSize
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetFontFamilyName>(lpVtbl->GetFontFamilyName)(
                    This,
                    fontFamilyName,
                    nameSize
                );
            }
        }

        public DWRITE_FONT_WEIGHT GetFontWeight()
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetFontWeight>(lpVtbl->GetFontWeight)(
                    This
                );
            }
        }

        public DWRITE_FONT_STYLE GetFontStyle()
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetFontStyle>(lpVtbl->GetFontStyle)(
                    This
                );
            }
        }

        public DWRITE_FONT_STRETCH GetFontStretch()
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetFontStretch>(lpVtbl->GetFontStretch)(
                    This
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetFontSize()
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetFontSize>(lpVtbl->GetFontSize)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetLocaleNameLength()
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetLocaleNameLength>(lpVtbl->GetLocaleNameLength)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName(
            [Out, NativeTypeName("WCHAR[]")] char* localeName,
            [In, NativeTypeName("UINT32")] uint nameSize
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetLocaleName>(lpVtbl->GetLocaleName)(
                    This,
                    localeName,
                    nameSize
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int SetVerticalGlyphOrientation(
            [In] DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_SetVerticalGlyphOrientation>(lpVtbl->SetVerticalGlyphOrientation)(
                    This,
                    glyphOrientation
                );
            }
        }

        public DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation()
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetVerticalGlyphOrientation>(lpVtbl->GetVerticalGlyphOrientation)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLastLineWrapping(
            [In, NativeTypeName("BOOL")] int isLastLineWrappingEnabled
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_SetLastLineWrapping>(lpVtbl->SetLastLineWrapping)(
                    This,
                    isLastLineWrappingEnabled
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int GetLastLineWrapping()
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetLastLineWrapping>(lpVtbl->GetLastLineWrapping)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOpticalAlignment(
            [In] DWRITE_OPTICAL_ALIGNMENT opticalAlignment
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_SetOpticalAlignment>(lpVtbl->SetOpticalAlignment)(
                    This,
                    opticalAlignment
                );
            }
        }

        public DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment()
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetOpticalAlignment>(lpVtbl->GetOpticalAlignment)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontFallback(
            [In] IDWriteFontFallback* fontFallback
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_SetFontFallback>(lpVtbl->SetFontFallback)(
                    This,
                    fontFallback
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFallback(
            [Out] IDWriteFontFallback** fontFallback
        )
        {
            fixed (IDWriteTextFormat1* This = &this)
            {
                return MarshalFunction<_GetFontFallback>(lpVtbl->GetFontFallback)(
                    This,
                    fontFallback
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

            #region IDWriteTextFormat Fields
            public IntPtr SetTextAlignment;

            public IntPtr SetParagraphAlignment;

            public IntPtr SetWordWrapping;

            public IntPtr SetReadingDirection;

            public IntPtr SetFlowDirection;

            public IntPtr SetIncrementalTabStop;

            public IntPtr SetTrimming;

            public IntPtr SetLineSpacing;

            public IntPtr GetTextAlignment;

            public IntPtr GetParagraphAlignment;

            public IntPtr GetWordWrapping;

            public IntPtr GetReadingDirection;

            public IntPtr GetFlowDirection;

            public IntPtr GetIncrementalTabStop;

            public IntPtr GetTrimming;

            public IntPtr GetLineSpacing;

            public IntPtr GetFontCollection;

            public IntPtr GetFontFamilyNameLength;

            public IntPtr GetFontFamilyName;

            public IntPtr GetFontWeight;

            public IntPtr GetFontStyle;

            public IntPtr GetFontStretch;

            public IntPtr GetFontSize;

            public IntPtr GetLocaleNameLength;

            public IntPtr GetLocaleName;
            #endregion

            #region Fields
            public IntPtr SetVerticalGlyphOrientation;

            public IntPtr GetVerticalGlyphOrientation;

            public IntPtr SetLastLineWrapping;

            public IntPtr GetLastLineWrapping;

            public IntPtr SetOpticalAlignment;

            public IntPtr GetOpticalAlignment;

            public IntPtr SetFontFallback;

            public IntPtr GetFontFallback;
            #endregion
        }
        #endregion
    }
}
