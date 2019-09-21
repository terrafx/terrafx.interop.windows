// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>The text layout interface represents a block of text after it has been fully analyzed and formatted.
    /// All coordinates are in device independent pixels (DIPs).</summary>
    [Guid("1093C18F-8D5E-43F0-B064-0917311B525E")]
    public unsafe struct IDWriteTextLayout2
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteTextLayout2* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteTextLayout2* This
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
            [In] IDWriteTextLayout2* This,
            [In] DWRITE_TEXT_ALIGNMENT textAlignment
        );

        /// <summary>Set alignment option of paragraph relative to layout box's top and bottom edge.</summary>
        /// <param name="paragraphAlignment">Paragraph alignment option</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetParagraphAlignment(
            [In] IDWriteTextLayout2* This,
            [In] DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment
        );

        /// <summary>Set word wrapping option.</summary>
        /// <param name="wordWrapping">Word wrapping option</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetWordWrapping(
            [In] IDWriteTextLayout2* This,
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
            [In] IDWriteTextLayout2* This,
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
            [In] IDWriteTextLayout2* This,
            [In] DWRITE_FLOW_DIRECTION flowDirection
        );

        /// <summary>Set incremental tab stop position.</summary>
        /// <param name="incrementalTabStop">The incremental tab stop value</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetIncrementalTabStop(
            [In] IDWriteTextLayout2* This,
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
            [In] IDWriteTextLayout2* This,
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
            [In] IDWriteTextLayout2* This,
            [In] DWRITE_LINE_SPACING_METHOD lineSpacingMethod,
            [In, NativeTypeName("FLOAT")] float lineSpacing,
            [In, NativeTypeName("FLOAT")] float baseline
        );

        /// <summary>Get alignment option of text relative to layout box's leading and trailing edge.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_TEXT_ALIGNMENT _GetTextAlignment(
            [In] IDWriteTextLayout2* This
        );

        /// <summary>Get alignment option of paragraph relative to layout box's top and bottom edge.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_PARAGRAPH_ALIGNMENT _GetParagraphAlignment(
            [In] IDWriteTextLayout2* This
        );

        /// <summary>Get word wrapping option.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_WORD_WRAPPING _GetWordWrapping(
            [In] IDWriteTextLayout2* This
        );

        /// <summary>Get paragraph reading direction.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_READING_DIRECTION _GetReadingDirection(
            [In] IDWriteTextLayout2* This
        );

        /// <summary>Get paragraph flow direction.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FLOW_DIRECTION _GetFlowDirection(
            [In] IDWriteTextLayout2* This
        );

        /// <summary>Get incremental tab stop position.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetIncrementalTabStop(
            [In] IDWriteTextLayout2* This
        );

        /// <summary>Get trimming options for text overflowing the layout width.</summary>
        /// <param name="trimmingOptions">Text trimming options.</param>
        /// <param name="trimmingSign">Trimming omission sign. This parameter may be NULL.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetTrimming(
            [In] IDWriteTextLayout2* This,
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
            [In] IDWriteTextLayout2* This,
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
            [In] IDWriteTextLayout2* This,
            [Out] IDWriteFontCollection** fontCollection
        );

        /// <summary>Get the length of the font family name, in characters, not including the terminating NULL character.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetFontFamilyNameLength(
            [In] IDWriteTextLayout2* This
        );

        /// <summary>Get a copy of the font family name.</summary>
        /// <param name="fontFamilyName">Character array that receives the current font family name</param>
        /// <param name="nameSize">Size of the character array in character count including the terminated NULL character.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontFamilyName(
            [In] IDWriteTextLayout2* This,
            [Out, NativeTypeName("WCHAR[]")] char* fontFamilyName,
            [In, NativeTypeName("UINT32")] uint nameSize
        );

        /// <summary>Get the font weight.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_WEIGHT _GetFontWeight(
            [In] IDWriteTextLayout2* This
        );

        /// <summary>Get the font style.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_STYLE _GetFontStyle(
            [In] IDWriteTextLayout2* This
        );

        /// <summary>Get the font stretch.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_STRETCH _GetFontStretch(
            [In] IDWriteTextLayout2* This
        );

        /// <summary>Get the font em height.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetFontSize(
            [In] IDWriteTextLayout2* This
        );

        /// <summary>Get the length of the locale name, in characters, not including the terminating NULL character.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetLocaleNameLength(
            [In] IDWriteTextLayout2* This
        );

        /// <summary>Get a copy of the locale name.</summary>
        /// <param name="localeName">Character array that receives the current locale name</param>
        /// <param name="nameSize">Size of the character array in character count including the terminated NULL character.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetLocaleName(
            [In] IDWriteTextLayout2* This,
            [Out, NativeTypeName("WCHAR[]")] char* localeName,
            [In, NativeTypeName("UINT32")] uint nameSize
        );
        #endregion

        #region IDWriteTextLayout Delegates
        /// <summary>Set layout maximum width</summary>
        /// <param name="maxWidth">Layout maximum width</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetMaxWidth(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("FLOAT")] float maxWidth
        );

        /// <summary>Set layout maximum height</summary>
        /// <param name="maxHeight">Layout maximum height</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetMaxHeight(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("FLOAT")] float maxHeight
        );

        /// <summary>Set the font collection.</summary>
        /// <param name="fontCollection">The font collection to set</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetFontCollection(
            [In] IDWriteTextLayout2* This,
            [In] IDWriteFontCollection* fontCollection,
            [In] DWRITE_TEXT_RANGE textRange
        );

        /// <summary>Set null-terminated font family name.</summary>
        /// <param name="fontFamilyName">Font family name</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetFontFamilyName(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("WCHAR[]")] char* fontFamilyName,
            [In] DWRITE_TEXT_RANGE textRange
        );

        /// <summary>Set font weight.</summary>
        /// <param name="fontWeight">Font weight</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetFontWeight(
            [In] IDWriteTextLayout2* This,
            [In] DWRITE_FONT_WEIGHT fontWeight,
            [In] DWRITE_TEXT_RANGE textRange
        );

        /// <summary>Set font style.</summary>
        /// <param name="fontStyle">Font style</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetFontStyle(
            [In] IDWriteTextLayout2* This,
            [In] DWRITE_FONT_STYLE fontStyle,
            [In] DWRITE_TEXT_RANGE textRange
        );

        /// <summary>Set font stretch.</summary>
        /// <param name="fontStretch">font stretch</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetFontStretch(
            [In] IDWriteTextLayout2* This,
            [In] DWRITE_FONT_STRETCH fontStretch,
            [In] DWRITE_TEXT_RANGE textRange
        );

        /// <summary>Set font em height.</summary>
        /// <param name="fontSize">Font em height</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetFontSize(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("FLOAT")] float fontSize,
            [In] DWRITE_TEXT_RANGE textRange
        );

        /// <summary>Set underline.</summary>
        /// <param name="hasUnderline">The Boolean flag indicates whether underline takes place</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetUnderline(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("BOOL")] int hasUnderline,
            [In] DWRITE_TEXT_RANGE textRange
        );

        /// <summary>Set strikethrough.</summary>
        /// <param name="hasStrikethrough">The Boolean flag indicates whether strikethrough takes place</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetStrikethrough(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("BOOL")] int hasStrikethrough,
            [In] DWRITE_TEXT_RANGE textRange
        );

        /// <summary>Set application-defined drawing effect.</summary>
        /// <param name="drawingEffect">Pointer to an application-defined drawing effect.</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> This drawing effect is associated with the specified range and will be passed back to the application via the callback when the range is drawn at drawing time.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetDrawingEffect(
            [In] IDWriteTextLayout2* This,
            [In] IUnknown* drawingEffect,
            [In] DWRITE_TEXT_RANGE textRange
        );

        /// <summary>Set inline object.</summary>
        /// <param name="inlineObject">Pointer to an application-implemented inline object.</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> This inline object applies to the specified range and will be passed back to the application via the DrawInlineObject callback when the range is drawn. Any text in that range will be suppressed.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetInlineObject(
            [In] IDWriteTextLayout2* This,
            [In] IDWriteInlineObject* inlineObject,
            [In] DWRITE_TEXT_RANGE textRange
        );

        /// <summary>Set font typography features.</summary>
        /// <param name="typography">Pointer to font typography setting.</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetTypography(
            [In] IDWriteTextLayout2* This,
            [In] IDWriteTypography* typography,
            [In] DWRITE_TEXT_RANGE textRange
        );

        /// <summary>Set locale name.</summary>
        /// <param name="localeName">Locale name</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetLocaleName(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("WCHAR[]")] char* localeName,
            [In] DWRITE_TEXT_RANGE textRange
        );

        /// <summary>Get layout maximum width</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetMaxWidth(
            [In] IDWriteTextLayout2* This
        );

        /// <summary>Get layout maximum height</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetMaxHeight(
            [In] IDWriteTextLayout2* This
        );

        /// <summary>Get the font collection where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="fontCollection">The current font collection</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontCollection1(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out] IDWriteFontCollection** fontCollection,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        );

        /// <summary>Get the length of the font family name where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="nameLength">Size of the character array in character count not including the terminated NULL character.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontFamilyNameLength1(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("UINT32")] uint* nameLength,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        );

        /// <summary>Copy the font family name where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="fontFamilyName">Character array that receives the current font family name</param>
        /// <param name="nameSize">Size of the character array in character count including the terminated NULL character.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontFamilyName1(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("WCHAR[]")] char* fontFamilyName,
            [In, NativeTypeName("UINT32")] uint nameSize,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        );

        /// <summary>Get the font weight where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="fontWeight">The current font weight</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontWeight1(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out] DWRITE_FONT_WEIGHT* fontWeight,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        );

        /// <summary>Get the font style where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="fontStyle">The current font style</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontStyle1(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out] DWRITE_FONT_STYLE* fontStyle,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        );

        /// <summary>Get the font stretch where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="fontStretch">The current font stretch</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontStretch1(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out] DWRITE_FONT_STRETCH* fontStretch,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        );

        /// <summary>Get the font em height where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="fontSize">The current font em height</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontSize1(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("FLOAT")] float* fontSize,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        );

        /// <summary>Get the underline presence where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="hasUnderline">The Boolean flag indicates whether text is underlined.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetUnderline(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("BOOL")] int* hasUnderline,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        );

        /// <summary>Get the strikethrough presence where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="hasStrikethrough">The Boolean flag indicates whether text has strikethrough.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetStrikethrough(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("BOOL")] int* hasStrikethrough,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        );

        /// <summary>Get the application-defined drawing effect where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="drawingEffect">The current application-defined drawing effect.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDrawingEffect(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out] IUnknown** drawingEffect,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        );

        /// <summary>Get the inline object at the given position.</summary>
        /// <param name="currentPosition">The given text position.</param>
        /// <param name="inlineObject">The inline object.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetInlineObject(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out] IDWriteInlineObject** inlineObject,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        );

        /// <summary>Get the typography setting where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="typography">The current typography setting.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetTypography(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out] IDWriteTypography** typography,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        );

        /// <summary>Get the length of the locale name where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="nameLength">Size of the character array in character count not including the terminated NULL character.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetLocaleNameLength1(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("UINT32")] uint* nameLength,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        );

        /// <summary>Get the locale name where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="localeName">Character array that receives the current locale name</param>
        /// <param name="nameSize">Size of the character array in character count including the terminated NULL character.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetLocaleName1(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("WCHAR[]")] char* localeName,
            [In, NativeTypeName("UINT32")] uint nameSize,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        );

        /// <summary>Initiate drawing of the text.</summary>
        /// <param name="clientDrawingContext">An application defined value included in rendering callbacks.</param>
        /// <param name="renderer">The set of application-defined callbacks that do the actual rendering.</param>
        /// <param name="originX">X-coordinate of the layout's left side.</param>
        /// <param name="originY">Y-coordinate of the layout's top side.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Draw(
            [In] IDWriteTextLayout2* This,
            [In, Optional] void* clientDrawingContext,
            [In] IDWriteTextRenderer* renderer,
            [In, NativeTypeName("FLOAT")] float originX,
            [In, NativeTypeName("FLOAT")] float originY
        );

        /// <summary>GetLineMetrics returns properties of each line.</summary>
        /// <param name="lineMetrics">The array to fill with line information.</param>
        /// <param name="maxLineCount">The maximum size of the lineMetrics array.</param>
        /// <param name="actualLineCount">The actual size of the lineMetrics array that is needed.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> If maxLineCount is not large enough E_NOT_SUFFICIENT_BUFFER, which is equivalent to HRESULT_FROM_WIN32(ERROR_INSUFFICIENT_BUFFER), is returned and *actualLineCount is set to the number of lines needed.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetLineMetrics(
            [In] IDWriteTextLayout2* This,
            [Out, Optional, NativeTypeName("DWRITE_LINE_METRICS[]")] DWRITE_LINE_METRICS* lineMetrics,
            [In, NativeTypeName("UINT32")] uint maxLineCount,
            [Out, NativeTypeName("UINT32")] uint* actualLineCount
        );

        /// <summary>GetMetrics retrieves overall metrics for the formatted string.</summary>
        /// <param name="textMetrics">The returned metrics.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> Drawing effects like underline and strikethrough do not contribute to the text size, which is essentially the sum of advance widths and line heights. Additionally, visible swashes and other graphic adornments may extend outside the returned width and height.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMetrics(
            [In] IDWriteTextLayout2* This,
            [Out] DWRITE_TEXT_METRICS* textMetrics
        );

        /// <summary>GetOverhangMetrics returns the overhangs (in DIPs) of the layout and all objects contained in it, including text glyphs and inline objects.</summary>
        /// <param name="overhangs">Overshoots of visible extents (in DIPs) outside the layout.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> Any underline and strikethrough do not contribute to the black box determination, since these are actually drawn by the renderer, which is allowed to draw them in any variety of styles.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetOverhangMetrics(
            [In] IDWriteTextLayout2* This,
            [Out] DWRITE_OVERHANG_METRICS* overhangs
        );

        /// <summary>Retrieve logical properties and measurement of each cluster.</summary>
        /// <param name="clusterMetrics">The array to fill with cluster information.</param>
        /// <param name="maxClusterCount">The maximum size of the clusterMetrics array.</param>
        /// <param name="actualClusterCount">The actual size of the clusterMetrics array that is needed.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> If maxClusterCount is not large enough E_NOT_SUFFICIENT_BUFFER, which is equivalent to HRESULT_FROM_WIN32(ERROR_INSUFFICIENT_BUFFER), is returned and *actualClusterCount is set to the number of clusters needed.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetClusterMetrics(
            [In] IDWriteTextLayout2* This,
            [Out, Optional, NativeTypeName("DWRITE_CLUSTER_METRICS[]")] DWRITE_CLUSTER_METRICS* clusterMetrics,
            [In, NativeTypeName("UINT32")] uint maxClusterCount,
            [Out, NativeTypeName("UINT32")] uint* actualClusterCount
        );

        /// <summary>Determines the minimum possible width the layout can be set to without emergency breaking between the characters of whole words.</summary>
        /// <param name="minWidth">Minimum width.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DetermineMinWidth(
            [In] IDWriteTextLayout2* This,
            [Out, NativeTypeName("FLOAT")] float* minWidth
        );

        /// <summary>Given a coordinate (in DIPs) relative to the top-left of the layout box, this returns the corresponding hit-test metrics of the text string where the hit-test has occurred. This is useful for mapping mouse clicks to caret positions. When the given coordinate is outside the text string, the function sets the output value *isInside to false but returns the nearest character position.</summary>
        /// <param name="pointX">X coordinate to hit-test, relative to the top-left location of the layout box.</param>
        /// <param name="pointY">Y coordinate to hit-test, relative to the top-left location of the layout box.</param>
        /// <param name="isTrailingHit">Output flag indicating whether the hit-test location is at the leading or the trailing side of the character. When the output *isInside value is set to false, this value is set according to the output *position value to represent the edge closest to the hit-test location. </param>
        /// <param name="isInside">Output flag indicating whether the hit-test location is inside the text string. When false, the position nearest the text's edge is returned.</param>
        /// <param name="hitTestMetrics">Output geometry fully enclosing the hit-test location. When the output *isInside value is set to false, this public structure represents the geometry enclosing the edge closest to the hit-test location.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _HitTestPoint(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("FLOAT")] float pointX,
            [In, NativeTypeName("FLOAT")] float pointY,
            [Out, NativeTypeName("BOOL")] int* isTrailingHit,
            [Out, NativeTypeName("BOOL")] int* isInside,
            [Out] DWRITE_HIT_TEST_METRICS* hitTestMetrics
        );

        /// <summary>Given a text position and whether the caret is on the leading or trailing edge of that position, this returns the corresponding coordinate (in DIPs) relative to the top-left of the layout box. This is most useful for drawing the caret's current position, but it could also be used to anchor an IME to the typed text or attach a floating menu near the point of interest. It may also be used to programmatically obtain the geometry of a particular text position for UI automation.</summary>
        /// <param name="textPosition">Text position to get the coordinate of.</param>
        /// <param name="isTrailingHit">Flag indicating whether the location is of the leading or the trailing side of the specified text position. </param>
        /// <param name="pointX">Output caret X, relative to the top-left of the layout box.</param>
        /// <param name="pointY">Output caret Y, relative to the top-left of the layout box.</param>
        /// <param name="hitTestMetrics">Output geometry fully enclosing the specified text position.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> When drawing a caret at the returned X,Y, it should be centered on X and drawn from the Y coordinate down. The height will be the size of the hit-tested text (which can vary in size within a line). Reading direction also affects which side of the character the caret is drawn. However, the returned X coordinate will be correct for either case. You can get a text length back that is larger than a single character. This happens for complex scripts when multiple characters form a single cluster, when diacritics join their base character, or when you test a surrogate pair.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _HitTestTextPosition(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint textPosition,
            [In, NativeTypeName("BOOL")] int isTrailingHit,
            [Out, NativeTypeName("FLOAT")] float* pointX,
            [Out, NativeTypeName("FLOAT")] float* pointY,
            [Out] DWRITE_HIT_TEST_METRICS* hitTestMetrics
        );

        /// <summary>The application calls this function to get a set of hit-test metrics corresponding to a range of text positions. The main usage for this is to draw highlighted selection of the text string. The function returns E_NOT_SUFFICIENT_BUFFER, which is equivalent to HRESULT_FROM_WIN32(ERROR_INSUFFICIENT_BUFFER), when the buffer size of hitTestMetrics is too small to hold all the regions calculated by the function. In such situation, the function sets the output value *actualHitTestMetricsCount to the number of geometries calculated. The application is responsible to allocate a new buffer of greater size and call the function again. A good value to use as an initial value for maxHitTestMetricsCount may be calculated from the following equation: maxHitTestMetricsCount = lineCount * maxBidiReorderingDepth where lineCount is obtained from the value of the output argument *actualLineCount from the function IDWriteTextLayout::GetLineMetrics, and the maxBidiReorderingDepth value from the DWRITE_TEXT_METRICS public structure of the output argument *textMetrics from the function IDWriteFactory::CreateTextLayout.</summary>
        /// <param name="textPosition">First text position of the specified range.</param>
        /// <param name="textLength">Number of positions of the specified range.</param>
        /// <param name="originX">Offset of the X origin (left of the layout box) which is added to each of the hit-test metrics returned.</param>
        /// <param name="originY">Offset of the Y origin (top of the layout box) which is added to each of the hit-test metrics returned.</param>
        /// <param name="hitTestMetrics">Pointer to a buffer of the output geometry fully enclosing the specified position range.</param>
        /// <param name="maxHitTestMetricsCount">Maximum number of distinct metrics it could hold in its buffer memory.</param>
        /// <param name="actualHitTestMetricsCount">Actual number of metrics returned or needed.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> There are no gaps in the returned metrics. While there could be visual gaps, depending on bidi ordering, each range is contiguous and reports all the text, including any hidden characters and trimmed text. The height of each returned range will be the same within each line, regardless of how the font sizes vary.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _HitTestTextRange(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint textPosition,
            [In, NativeTypeName("UINT32")] uint textLength,
            [In, NativeTypeName("FLOAT")] float originX,
            [In, NativeTypeName("FLOAT")] float originY,
            [Out, Optional, NativeTypeName("DWRITE_HIT_TEST_METRICS[]")] DWRITE_HIT_TEST_METRICS* hitTestMetrics,
            [In, NativeTypeName("UINT32")] uint maxHitTestMetricsCount,
            [Out, NativeTypeName("UINT32")] uint* actualHitTestMetricsCount
        );
        #endregion

        #region IDWriteTextLayout1 Delegates
        /// <summary>Enables/disables pair-kerning on the given range.</summary>
        /// <param name="isPairKerningEnabled">The Boolean flag indicates whether text is pair-kerned.</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPairKerning(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("BOOL")] int isPairKerningEnabled,
            [In] DWRITE_TEXT_RANGE textRange
        );

        /// <summary>Get whether or not pair-kerning is enabled at given position.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="isPairKerningEnabled">The Boolean flag indicates whether text is pair-kerned.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPairKerning(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("BOOL")] int* isPairKerningEnabled,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        );

        /// <summary>Sets the spacing between characters.</summary>
        /// <param name="leadingSpacing">The spacing before each character, in reading order.</param>
        /// <param name="trailingSpacing">The spacing after each character, in reading order.</param>
        /// <param name="minimumAdvanceWidth">The minimum advance of each character, to prevent characters from becoming too thin or zero-width. This must be zero or greater.</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetCharacterSpacing(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("FLOAT")] float leadingSpacing,
            [In, NativeTypeName("FLOAT")] float trailingSpacing,
            [In, NativeTypeName("FLOAT")] float minimumAdvanceWidth,
            [In] DWRITE_TEXT_RANGE textRange
        );

        /// <summary>Gets the spacing between characters.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="leadingSpacing">The spacing before each character, in reading order.</param>
        /// <param name="trailingSpacing">The spacing after each character, in reading order.</param>
        /// <param name="minimumAdvanceWidth">The minimum advance of each character, to prevent characters from becoming too thin or zero-width. This must be zero or greater.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetCharacterSpacing(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("FLOAT")] float* leadingSpacing,
            [Out, NativeTypeName("FLOAT")] float* trailingSpacing,
            [Out, NativeTypeName("FLOAT")] float* minimumAdvanceWidth,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        );
        #endregion

        #region Delegates
        /// <summary>GetMetrics retrieves overall metrics for the formatted string.</summary>
        /// <param name="textMetrics">The returned metrics.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> Drawing effects like underline and strikethrough do not contribute to the text size, which is essentially the sum of advance widths and line heights. Additionally, visible swashes and other graphic adornments may extend outside the returned width and height.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMetrics1(
            [In] IDWriteTextLayout2* This,
            [Out] DWRITE_TEXT_METRICS1* textMetrics
        );

        /// <summary>Set the preferred orientation of glyphs when using a vertical reading direction.</summary>
        /// <param name="glyphOrientation">Preferred glyph orientation.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetVerticalGlyphOrientation(
            [In] IDWriteTextLayout2* This,
            [In] DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation
        );

        /// <summary>Get the preferred orientation of glyphs when using a vertical reading direction.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_VERTICAL_GLYPH_ORIENTATION _GetVerticalGlyphOrientation(
            [In] IDWriteTextLayout2* This
        );

        /// <summary>Set whether or not the last word on the last line is wrapped.</summary>
        /// <param name="isLastLineWrappingEnabled">Line wrapping option.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetLastLineWrapping(
            [In] IDWriteTextLayout2* This,
            [In, NativeTypeName("BOOL")] int isLastLineWrappingEnabled
        );

        /// <summary>Get whether or not the last word on the last line is wrapped.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _GetLastLineWrapping(
            [In] IDWriteTextLayout2* This
        );

        /// <summary>Set how the glyphs align to the edges the margin. Default behavior is to align glyphs using their default glyphs metrics which include side bearings.</summary>
        /// <param name="opticalAlignment">Optical alignment option.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetOpticalAlignment(
            [In] IDWriteTextLayout2* This,
            [In] DWRITE_OPTICAL_ALIGNMENT opticalAlignment
        );

        /// <summary>Get how the glyphs align to the edges the margin.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_OPTICAL_ALIGNMENT _GetOpticalAlignment(
            [In] IDWriteTextLayout2* This
        );

        /// <summary>Apply a custom font fallback onto layout. If none is specified, layout uses the system fallback list.</summary>
        /// <param name="fontFallback">Custom font fallback created from IDWriteFontFallbackBuilder::CreateFontFallback or IDWriteFactory2::GetSystemFontFallback.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetFontFallback(
            [In] IDWriteTextLayout2* This,
            [In] IDWriteFontFallback* fontFallback
        );

        /// <summary>Get the current font fallback object.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontFallback(
            [In] IDWriteTextLayout2* This,
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
            fixed (IDWriteTextLayout2* This = &this)
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
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
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
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetTextAlignment>(lpVtbl->SetTextAlignment)(
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
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetParagraphAlignment>(lpVtbl->SetParagraphAlignment)(
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
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetWordWrapping>(lpVtbl->SetWordWrapping)(
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
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetReadingDirection>(lpVtbl->SetReadingDirection)(
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
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFlowDirection>(lpVtbl->SetFlowDirection)(
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
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetIncrementalTabStop>(lpVtbl->SetIncrementalTabStop)(
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
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetTrimming>(lpVtbl->SetTrimming)(
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
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetLineSpacing>(lpVtbl->SetLineSpacing)(
                    This,
                    lineSpacingMethod,
                    lineSpacing,
                    baseline
                );
            }
        }

        public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTextAlignment>(lpVtbl->GetTextAlignment)(
                    This
                );
            }
        }

        public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParagraphAlignment>(lpVtbl->GetParagraphAlignment)(
                    This
                );
            }
        }

        public DWRITE_WORD_WRAPPING GetWordWrapping()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetWordWrapping>(lpVtbl->GetWordWrapping)(
                    This
                );
            }
        }

        public DWRITE_READING_DIRECTION GetReadingDirection()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetReadingDirection>(lpVtbl->GetReadingDirection)(
                    This
                );
            }
        }

        public DWRITE_FLOW_DIRECTION GetFlowDirection()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFlowDirection>(lpVtbl->GetFlowDirection)(
                    This
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetIncrementalTabStop()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetIncrementalTabStop>(lpVtbl->GetIncrementalTabStop)(
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
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTrimming>(lpVtbl->GetTrimming)(
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
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLineSpacing>(lpVtbl->GetLineSpacing)(
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
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontCollection>(lpVtbl->GetFontCollection)(
                    This,
                    fontCollection
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyNameLength()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyNameLength>(lpVtbl->GetFontFamilyNameLength)(
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
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyName>(lpVtbl->GetFontFamilyName)(
                    This,
                    fontFamilyName,
                    nameSize
                );
            }
        }

        public DWRITE_FONT_WEIGHT GetFontWeight()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontWeight>(lpVtbl->GetFontWeight)(
                    This
                );
            }
        }

        public DWRITE_FONT_STYLE GetFontStyle()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontStyle>(lpVtbl->GetFontStyle)(
                    This
                );
            }
        }

        public DWRITE_FONT_STRETCH GetFontStretch()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontStretch>(lpVtbl->GetFontStretch)(
                    This
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetFontSize()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontSize>(lpVtbl->GetFontSize)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetLocaleNameLength()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocaleNameLength>(lpVtbl->GetLocaleNameLength)(
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
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocaleName>(lpVtbl->GetLocaleName)(
                    This,
                    localeName,
                    nameSize
                );
            }
        }
        #endregion

        #region IDWriteTextLayout Methods
        [return: NativeTypeName("HRESULT")]
        public int SetMaxWidth(
            [In, NativeTypeName("FLOAT")] float maxWidth
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetMaxWidth>(lpVtbl->SetMaxWidth)(
                    This,
                    maxWidth
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMaxHeight(
            [In, NativeTypeName("FLOAT")] float maxHeight
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetMaxHeight>(lpVtbl->SetMaxHeight)(
                    This,
                    maxHeight
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontCollection(
            [In] IDWriteFontCollection* fontCollection,
            [In] DWRITE_TEXT_RANGE textRange
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFontCollection>(lpVtbl->SetFontCollection)(
                    This,
                    fontCollection,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontFamilyName(
            [In, NativeTypeName("WCHAR[]")] char* fontFamilyName,
            [In] DWRITE_TEXT_RANGE textRange
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFontFamilyName>(lpVtbl->SetFontFamilyName)(
                    This,
                    fontFamilyName,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontWeight(
            [In] DWRITE_FONT_WEIGHT fontWeight,
            [In] DWRITE_TEXT_RANGE textRange
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFontWeight>(lpVtbl->SetFontWeight)(
                    This,
                    fontWeight,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontStyle(
            [In] DWRITE_FONT_STYLE fontStyle,
            [In] DWRITE_TEXT_RANGE textRange
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFontStyle>(lpVtbl->SetFontStyle)(
                    This,
                    fontStyle,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontStretch(
            [In] DWRITE_FONT_STRETCH fontStretch,
            [In] DWRITE_TEXT_RANGE textRange
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFontStretch>(lpVtbl->SetFontStretch)(
                    This,
                    fontStretch,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontSize(
            [In, NativeTypeName("FLOAT")] float fontSize,
            [In] DWRITE_TEXT_RANGE textRange
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFontSize>(lpVtbl->SetFontSize)(
                    This,
                    fontSize,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUnderline(
            [In, NativeTypeName("BOOL")] int hasUnderline,
            [In] DWRITE_TEXT_RANGE textRange
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetUnderline>(lpVtbl->SetUnderline)(
                    This,
                    hasUnderline,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStrikethrough(
            [In, NativeTypeName("BOOL")] int hasStrikethrough,
            [In] DWRITE_TEXT_RANGE textRange
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetStrikethrough>(lpVtbl->SetStrikethrough)(
                    This,
                    hasStrikethrough,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDrawingEffect(
            [In] IUnknown* drawingEffect,
            [In] DWRITE_TEXT_RANGE textRange
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetDrawingEffect>(lpVtbl->SetDrawingEffect)(
                    This,
                    drawingEffect,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInlineObject(
            [In] IDWriteInlineObject* inlineObject,
            [In] DWRITE_TEXT_RANGE textRange
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetInlineObject>(lpVtbl->SetInlineObject)(
                    This,
                    inlineObject,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTypography(
            [In] IDWriteTypography* typography,
            [In] DWRITE_TEXT_RANGE textRange
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetTypography>(lpVtbl->SetTypography)(
                    This,
                    typography,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLocaleName(
            [In, NativeTypeName("WCHAR[]")] char* localeName,
            [In] DWRITE_TEXT_RANGE textRange
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetLocaleName>(lpVtbl->SetLocaleName)(
                    This,
                    localeName,
                    textRange
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetMaxWidth()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMaxWidth>(lpVtbl->GetMaxWidth)(
                    This
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetMaxHeight()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMaxHeight>(lpVtbl->GetMaxHeight)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection1(
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out] IDWriteFontCollection** fontCollection,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontCollection1>(lpVtbl->GetFontCollection1)(
                    This,
                    currentPosition,
                    fontCollection,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyNameLength1(
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("UINT32")] uint* nameLength,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyNameLength1>(lpVtbl->GetFontFamilyNameLength1)(
                    This,
                    currentPosition,
                    nameLength,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName1(
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("WCHAR[]")] char* fontFamilyName,
            [In, NativeTypeName("UINT32")] uint nameSize,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyName1>(lpVtbl->GetFontFamilyName1)(
                    This,
                    currentPosition,
                    fontFamilyName,
                    nameSize,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontWeight1(
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out] DWRITE_FONT_WEIGHT* fontWeight,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontWeight1>(lpVtbl->GetFontWeight1)(
                    This,
                    currentPosition,
                    fontWeight,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontStyle1(
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out] DWRITE_FONT_STYLE* fontStyle,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontStyle1>(lpVtbl->GetFontStyle1)(
                    This,
                    currentPosition,
                    fontStyle,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontStretch1(
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out] DWRITE_FONT_STRETCH* fontStretch,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontStretch1>(lpVtbl->GetFontStretch1)(
                    This,
                    currentPosition,
                    fontStretch,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontSize1(
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("FLOAT")] float* fontSize,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontSize1>(lpVtbl->GetFontSize1)(
                    This,
                    currentPosition,
                    fontSize,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnderline(
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("BOOL")] int* hasUnderline,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetUnderline>(lpVtbl->GetUnderline)(
                    This,
                    currentPosition,
                    hasUnderline,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStrikethrough(
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("BOOL")] int* hasStrikethrough,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStrikethrough>(lpVtbl->GetStrikethrough)(
                    This,
                    currentPosition,
                    hasStrikethrough,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDrawingEffect(
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out] IUnknown** drawingEffect,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDrawingEffect>(lpVtbl->GetDrawingEffect)(
                    This,
                    currentPosition,
                    drawingEffect,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInlineObject(
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out] IDWriteInlineObject** inlineObject,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetInlineObject>(lpVtbl->GetInlineObject)(
                    This,
                    currentPosition,
                    inlineObject,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypography(
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out] IDWriteTypography** typography,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypography>(lpVtbl->GetTypography)(
                    This,
                    currentPosition,
                    typography,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleNameLength1(
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("UINT32")] uint* nameLength,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocaleNameLength1>(lpVtbl->GetLocaleNameLength1)(
                    This,
                    currentPosition,
                    nameLength,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName1(
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("WCHAR[]")] char* localeName,
            [In, NativeTypeName("UINT32")] uint nameSize,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocaleName1>(lpVtbl->GetLocaleName1)(
                    This,
                    currentPosition,
                    localeName,
                    nameSize,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Draw(
            [In, Optional] void* clientDrawingContext,
            [In] IDWriteTextRenderer* renderer,
            [In, NativeTypeName("FLOAT")] float originX,
            [In, NativeTypeName("FLOAT")] float originY
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Draw>(lpVtbl->Draw)(
                    This,
                    clientDrawingContext,
                    renderer,
                    originX,
                    originY
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineMetrics(
            [Out, Optional, NativeTypeName("DWRITE_LINE_METRICS[]")] DWRITE_LINE_METRICS* lineMetrics,
            [In, NativeTypeName("UINT32")] uint maxLineCount,
            [Out, NativeTypeName("UINT32")] uint* actualLineCount
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLineMetrics>(lpVtbl->GetLineMetrics)(
                    This,
                    lineMetrics,
                    maxLineCount,
                    actualLineCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetrics(
            [Out] DWRITE_TEXT_METRICS* textMetrics
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetrics>(lpVtbl->GetMetrics)(
                    This,
                    textMetrics
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOverhangMetrics(
            [Out] DWRITE_OVERHANG_METRICS* overhangs
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetOverhangMetrics>(lpVtbl->GetOverhangMetrics)(
                    This,
                    overhangs
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClusterMetrics(
            [Out, Optional, NativeTypeName("DWRITE_CLUSTER_METRICS[]")] DWRITE_CLUSTER_METRICS* clusterMetrics,
            [In, NativeTypeName("UINT32")] uint maxClusterCount,
            [Out, NativeTypeName("UINT32")] uint* actualClusterCount
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetClusterMetrics>(lpVtbl->GetClusterMetrics)(
                    This,
                    clusterMetrics,
                    maxClusterCount,
                    actualClusterCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DetermineMinWidth(
            [Out, NativeTypeName("FLOAT")] float* minWidth
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DetermineMinWidth>(lpVtbl->DetermineMinWidth)(
                    This,
                    minWidth
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int HitTestPoint(
            [In, NativeTypeName("FLOAT")] float pointX,
            [In, NativeTypeName("FLOAT")] float pointY,
            [Out, NativeTypeName("BOOL")] int* isTrailingHit,
            [Out, NativeTypeName("BOOL")] int* isInside,
            [Out] DWRITE_HIT_TEST_METRICS* hitTestMetrics
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_HitTestPoint>(lpVtbl->HitTestPoint)(
                    This,
                    pointX,
                    pointY,
                    isTrailingHit,
                    isInside,
                    hitTestMetrics
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int HitTestTextPosition(
            [In, NativeTypeName("UINT32")] uint textPosition,
            [In, NativeTypeName("BOOL")] int isTrailingHit,
            [Out, NativeTypeName("FLOAT")] float* pointX,
            [Out, NativeTypeName("FLOAT")] float* pointY,
            [Out] DWRITE_HIT_TEST_METRICS* hitTestMetrics
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_HitTestTextPosition>(lpVtbl->HitTestTextPosition)(
                    This,
                    textPosition,
                    isTrailingHit,
                    pointX,
                    pointY,
                    hitTestMetrics
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int HitTestTextRange(
            [In, NativeTypeName("UINT32")] uint textPosition,
            [In, NativeTypeName("UINT32")] uint textLength,
            [In, NativeTypeName("FLOAT")] float originX,
            [In, NativeTypeName("FLOAT")] float originY,
            [Out, Optional, NativeTypeName("DWRITE_HIT_TEST_METRICS[]")] DWRITE_HIT_TEST_METRICS* hitTestMetrics,
            [In, NativeTypeName("UINT32")] uint maxHitTestMetricsCount,
            [Out, NativeTypeName("UINT32")] uint* actualHitTestMetricsCount
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_HitTestTextRange>(lpVtbl->HitTestTextRange)(
                    This,
                    textPosition,
                    textLength,
                    originX,
                    originY,
                    hitTestMetrics,
                    maxHitTestMetricsCount,
                    actualHitTestMetricsCount
                );
            }
        }
        #endregion

        #region IDWriteTextLayout1 Methods
        [return: NativeTypeName("HRESULT")]
        public int SetPairKerning(
            [In, NativeTypeName("BOOL")] int isPairKerningEnabled,
            [In] DWRITE_TEXT_RANGE textRange
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPairKerning>(lpVtbl->SetPairKerning)(
                    This,
                    isPairKerningEnabled,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPairKerning(
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("BOOL")] int* isPairKerningEnabled,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPairKerning>(lpVtbl->GetPairKerning)(
                    This,
                    currentPosition,
                    isPairKerningEnabled,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCharacterSpacing(
            [In, NativeTypeName("FLOAT")] float leadingSpacing,
            [In, NativeTypeName("FLOAT")] float trailingSpacing,
            [In, NativeTypeName("FLOAT")] float minimumAdvanceWidth,
            [In] DWRITE_TEXT_RANGE textRange
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetCharacterSpacing>(lpVtbl->SetCharacterSpacing)(
                    This,
                    leadingSpacing,
                    trailingSpacing,
                    minimumAdvanceWidth,
                    textRange
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCharacterSpacing(
            [In, NativeTypeName("UINT32")] uint currentPosition,
            [Out, NativeTypeName("FLOAT")] float* leadingSpacing,
            [Out, NativeTypeName("FLOAT")] float* trailingSpacing,
            [Out, NativeTypeName("FLOAT")] float* minimumAdvanceWidth,
            [Out] DWRITE_TEXT_RANGE* textRange = null
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCharacterSpacing>(lpVtbl->GetCharacterSpacing)(
                    This,
                    currentPosition,
                    leadingSpacing,
                    trailingSpacing,
                    minimumAdvanceWidth,
                    textRange
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int GetMetrics1(
            [Out] DWRITE_TEXT_METRICS1* textMetrics
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetrics1>(lpVtbl->GetMetrics1)(
                    This,
                    textMetrics
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVerticalGlyphOrientation(
            [In] DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetVerticalGlyphOrientation>(lpVtbl->SetVerticalGlyphOrientation)(
                    This,
                    glyphOrientation
                );
            }
        }

        public DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVerticalGlyphOrientation>(lpVtbl->GetVerticalGlyphOrientation)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLastLineWrapping(
            [In, NativeTypeName("BOOL")] int isLastLineWrappingEnabled
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetLastLineWrapping>(lpVtbl->SetLastLineWrapping)(
                    This,
                    isLastLineWrappingEnabled
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int GetLastLineWrapping()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLastLineWrapping>(lpVtbl->GetLastLineWrapping)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOpticalAlignment(
            [In] DWRITE_OPTICAL_ALIGNMENT opticalAlignment
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetOpticalAlignment>(lpVtbl->SetOpticalAlignment)(
                    This,
                    opticalAlignment
                );
            }
        }

        public DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetOpticalAlignment>(lpVtbl->GetOpticalAlignment)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontFallback(
            [In] IDWriteFontFallback* fontFallback
        )
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFontFallback>(lpVtbl->SetFontFallback)(
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
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFallback>(lpVtbl->GetFontFallback)(
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

            #region IDWriteTextLayout Fields
            public IntPtr SetMaxWidth;

            public IntPtr SetMaxHeight;

            public IntPtr SetFontCollection;

            public IntPtr SetFontFamilyName;

            public IntPtr SetFontWeight;

            public IntPtr SetFontStyle;

            public IntPtr SetFontStretch;

            public IntPtr SetFontSize;

            public IntPtr SetUnderline;

            public IntPtr SetStrikethrough;

            public IntPtr SetDrawingEffect;

            public IntPtr SetInlineObject;

            public IntPtr SetTypography;

            public IntPtr SetLocaleName;

            public IntPtr GetMaxWidth;

            public IntPtr GetMaxHeight;

            public IntPtr GetFontCollection1;

            public IntPtr GetFontFamilyNameLength1;

            public IntPtr GetFontFamilyName1;

            public IntPtr GetFontWeight1;

            public IntPtr GetFontStyle1;

            public IntPtr GetFontStretch1;

            public IntPtr GetFontSize1;

            public IntPtr GetUnderline;

            public IntPtr GetStrikethrough;

            public IntPtr GetDrawingEffect;

            public IntPtr GetInlineObject;

            public IntPtr GetTypography;

            public IntPtr GetLocaleNameLength1;

            public IntPtr GetLocaleName1;

            public IntPtr Draw;

            public IntPtr GetLineMetrics;

            public IntPtr GetMetrics;

            public IntPtr GetOverhangMetrics;

            public IntPtr GetClusterMetrics;

            public IntPtr DetermineMinWidth;

            public IntPtr HitTestPoint;

            public IntPtr HitTestTextPosition;

            public IntPtr HitTestTextRange;
            #endregion

            #region IDWriteTextLayout1 Fields
            public IntPtr SetPairKerning;

            public IntPtr GetPairKerning;

            public IntPtr SetCharacterSpacing;

            public IntPtr GetCharacterSpacing;
            #endregion

            #region Fields
            public IntPtr GetMetrics1;

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
