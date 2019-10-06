// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The text layout interface represents a block of text after it has been fully analyzed and formatted.
    /// All coordinates are in device independent pixels (DIPs).</summary>
    [Guid("1093C18F-8D5E-43F0-B064-0917311B525E")]
    public unsafe partial struct IDWriteTextLayout2
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteTextLayout2* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteTextLayout2* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteTextLayout2* This);

        /// <summary>Set alignment option of text relative to layout box's leading and trailing edge.</summary>
        /// <param name="textAlignment">Text alignment option</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTextAlignment(IDWriteTextLayout2* This, DWRITE_TEXT_ALIGNMENT textAlignment);

        /// <summary>Set alignment option of paragraph relative to layout box's top and bottom edge.</summary>
        /// <param name="paragraphAlignment">Paragraph alignment option</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetParagraphAlignment(IDWriteTextLayout2* This, DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment);

        /// <summary>Set word wrapping option.</summary>
        /// <param name="wordWrapping">Word wrapping option</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetWordWrapping(IDWriteTextLayout2* This, DWRITE_WORD_WRAPPING wordWrapping);

        /// <summary>Set paragraph reading direction.</summary>
        /// <param name="readingDirection">Text reading direction</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> The flow direction must be perpendicular to the reading direction. Setting both to a vertical direction or both to horizontal yields DWRITE_E_FLOWDIRECTIONCONFLICTS when calling GetMetrics or Draw.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetReadingDirection(IDWriteTextLayout2* This, DWRITE_READING_DIRECTION readingDirection);

        /// <summary>Set paragraph flow direction.</summary>
        /// <param name="flowDirection">Paragraph flow direction</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> The flow direction must be perpendicular to the reading direction. Setting both to a vertical direction or both to horizontal yields DWRITE_E_FLOWDIRECTIONCONFLICTS when calling GetMetrics or Draw.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFlowDirection(IDWriteTextLayout2* This, DWRITE_FLOW_DIRECTION flowDirection);

        /// <summary>Set incremental tab stop position.</summary>
        /// <param name="incrementalTabStop">The incremental tab stop value</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetIncrementalTabStop(IDWriteTextLayout2* This, [NativeTypeName("FLOAT")] float incrementalTabStop);

        /// <summary>Set trimming options for any trailing text exceeding the layout width or for any far text exceeding the layout height.</summary>
        /// <param name="trimmingOptions">Text trimming options.</param>
        /// <param name="trimmingSign">Application-defined omission sign. This parameter may be NULL if no trimming sign is desired.</param>
        /// <remarks> Any inline object can be used for the trimming sign, but CreateEllipsisTrimmingSign provides a typical ellipsis symbol. Trimming is also useful vertically for hiding partial lines.</remarks>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTrimming(IDWriteTextLayout2* This, DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject* trimmingSign = null);

        /// <summary>Set line spacing.</summary>
        /// <param name="lineSpacingMethod">How to determine line height.</param>
        /// <param name="lineSpacing">The line height, or rather distance between one baseline to another.</param>
        /// <param name="baseline">Distance from top of line to baseline. A reasonable ratio to lineSpacing is 80%.</param>
        /// <remarks> For the default method, spacing depends solely on the content. For uniform spacing, the given line height will override the content.</remarks>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLineSpacing(IDWriteTextLayout2* This, DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline);

        /// <summary>Get alignment option of text relative to layout box's leading and trailing edge.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_TEXT_ALIGNMENT _GetTextAlignment(IDWriteTextLayout2* This);

        /// <summary>Get alignment option of paragraph relative to layout box's top and bottom edge.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_PARAGRAPH_ALIGNMENT _GetParagraphAlignment(IDWriteTextLayout2* This);

        /// <summary>Get word wrapping option.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_WORD_WRAPPING _GetWordWrapping(IDWriteTextLayout2* This);

        /// <summary>Get paragraph reading direction.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_READING_DIRECTION _GetReadingDirection(IDWriteTextLayout2* This);

        /// <summary>Get paragraph flow direction.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FLOW_DIRECTION _GetFlowDirection(IDWriteTextLayout2* This);

        /// <summary>Get incremental tab stop position.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetIncrementalTabStop(IDWriteTextLayout2* This);

        /// <summary>Get trimming options for text overflowing the layout width.</summary>
        /// <param name="trimmingOptions">Text trimming options.</param>
        /// <param name="trimmingSign">Trimming omission sign. This parameter may be NULL.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTrimming(IDWriteTextLayout2* This, DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject** trimmingSign);

        /// <summary>Get line spacing.</summary>
        /// <param name="lineSpacingMethod">How line height is determined.</param>
        /// <param name="lineSpacing">The line height, or rather distance between one baseline to another.</param>
        /// <param name="baseline">Distance from top of line to baseline.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLineSpacing(IDWriteTextLayout2* This, DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT")] float* lineSpacing, [NativeTypeName("FLOAT")] float* baseline);

        /// <summary>Get the font collection.</summary>
        /// <param name="fontCollection">The current font collection.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontCollection(IDWriteTextLayout2* This, IDWriteFontCollection** fontCollection);

        /// <summary>Get the length of the font family name, in characters, not including the terminating NULL character.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetFontFamilyNameLength(IDWriteTextLayout2* This);

        /// <summary>Get a copy of the font family name.</summary>
        /// <param name="fontFamilyName">Character array that receives the current font family name</param>
        /// <param name="nameSize">Size of the character array in character count including the terminated NULL character.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFamilyName(IDWriteTextLayout2* This, [NativeTypeName("WCHAR[]")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize);

        /// <summary>Get the font weight.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_WEIGHT _GetFontWeight(IDWriteTextLayout2* This);

        /// <summary>Get the font style.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_STYLE _GetFontStyle(IDWriteTextLayout2* This);

        /// <summary>Get the font stretch.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_STRETCH _GetFontStretch(IDWriteTextLayout2* This);

        /// <summary>Get the font em height.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetFontSize(IDWriteTextLayout2* This);

        /// <summary>Get the length of the locale name, in characters, not including the terminating NULL character.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetLocaleNameLength(IDWriteTextLayout2* This);

        /// <summary>Get a copy of the locale name.</summary>
        /// <param name="localeName">Character array that receives the current locale name</param>
        /// <param name="nameSize">Size of the character array in character count including the terminated NULL character.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleName(IDWriteTextLayout2* This, [NativeTypeName("WCHAR[]")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize);

        /// <summary>Set layout maximum width</summary>
        /// <param name="maxWidth">Layout maximum width</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMaxWidth(IDWriteTextLayout2* This, [NativeTypeName("FLOAT")] float maxWidth);

        /// <summary>Set layout maximum height</summary>
        /// <param name="maxHeight">Layout maximum height</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMaxHeight(IDWriteTextLayout2* This, [NativeTypeName("FLOAT")] float maxHeight);

        /// <summary>Set the font collection.</summary>
        /// <param name="fontCollection">The font collection to set</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFontCollection(IDWriteTextLayout2* This, IDWriteFontCollection* fontCollection, DWRITE_TEXT_RANGE textRange);

        /// <summary>Set null-terminated font family name.</summary>
        /// <param name="fontFamilyName">Font family name</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFontFamilyName(IDWriteTextLayout2* This, [NativeTypeName("WCHAR[]")] ushort* fontFamilyName, DWRITE_TEXT_RANGE textRange);

        /// <summary>Set font weight.</summary>
        /// <param name="fontWeight">Font weight</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFontWeight(IDWriteTextLayout2* This, DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange);

        /// <summary>Set font style.</summary>
        /// <param name="fontStyle">Font style</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFontStyle(IDWriteTextLayout2* This, DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange);

        /// <summary>Set font stretch.</summary>
        /// <param name="fontStretch">font stretch</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFontStretch(IDWriteTextLayout2* This, DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange);

        /// <summary>Set font em height.</summary>
        /// <param name="fontSize">Font em height</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFontSize(IDWriteTextLayout2* This, [NativeTypeName("FLOAT")] float fontSize, DWRITE_TEXT_RANGE textRange);

        /// <summary>Set underline.</summary>
        /// <param name="hasUnderline">The Boolean flag indicates whether underline takes place</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetUnderline(IDWriteTextLayout2* This, [NativeTypeName("BOOL")] int hasUnderline, DWRITE_TEXT_RANGE textRange);

        /// <summary>Set strikethrough.</summary>
        /// <param name="hasStrikethrough">The Boolean flag indicates whether strikethrough takes place</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetStrikethrough(IDWriteTextLayout2* This, [NativeTypeName("BOOL")] int hasStrikethrough, DWRITE_TEXT_RANGE textRange);

        /// <summary>Set application-defined drawing effect.</summary>
        /// <param name="drawingEffect">Pointer to an application-defined drawing effect.</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> This drawing effect is associated with the specified range and will be passed back to the application via the callback when the range is drawn at drawing time.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDrawingEffect(IDWriteTextLayout2* This, IUnknown* drawingEffect, DWRITE_TEXT_RANGE textRange);

        /// <summary>Set inline object.</summary>
        /// <param name="inlineObject">Pointer to an application-implemented inline object.</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> This inline object applies to the specified range and will be passed back to the application via the DrawInlineObject callback when the range is drawn. Any text in that range will be suppressed.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetInlineObject(IDWriteTextLayout2* This, IDWriteInlineObject* inlineObject, DWRITE_TEXT_RANGE textRange);

        /// <summary>Set font typography features.</summary>
        /// <param name="typography">Pointer to font typography setting.</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTypography(IDWriteTextLayout2* This, IDWriteTypography* typography, DWRITE_TEXT_RANGE textRange);

        /// <summary>Set locale name.</summary>
        /// <param name="localeName">Locale name</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLocaleName(IDWriteTextLayout2* This, [NativeTypeName("WCHAR[]")] ushort* localeName, DWRITE_TEXT_RANGE textRange);

        /// <summary>Get layout maximum width</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetMaxWidth(IDWriteTextLayout2* This);

        /// <summary>Get layout maximum height</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetMaxHeight(IDWriteTextLayout2* This);

        /// <summary>Get the font collection where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="fontCollection">The current font collection</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontCollection1(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint currentPosition, IDWriteFontCollection** fontCollection, DWRITE_TEXT_RANGE* textRange = null);

        /// <summary>Get the length of the font family name where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="nameLength">Size of the character array in character count not including the terminated NULL character.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFamilyNameLength1(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null);

        /// <summary>Copy the font family name where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="fontFamilyName">Character array that receives the current font family name</param>
        /// <param name="nameSize">Size of the character array in character count including the terminated NULL character.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFamilyName1(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR[]")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null);

        /// <summary>Get the font weight where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="fontWeight">The current font weight</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontWeight1(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_WEIGHT* fontWeight, DWRITE_TEXT_RANGE* textRange = null);

        /// <summary>Get the font style where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="fontStyle">The current font style</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontStyle1(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STYLE* fontStyle, DWRITE_TEXT_RANGE* textRange = null);

        /// <summary>Get the font stretch where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="fontStretch">The current font stretch</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontStretch1(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STRETCH* fontStretch, DWRITE_TEXT_RANGE* textRange = null);

        /// <summary>Get the font em height where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="fontSize">The current font em height</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontSize1(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("FLOAT")] float* fontSize, DWRITE_TEXT_RANGE* textRange = null);

        /// <summary>Get the underline presence where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="hasUnderline">The Boolean flag indicates whether text is underlined.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetUnderline(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL")] int* hasUnderline, DWRITE_TEXT_RANGE* textRange = null);

        /// <summary>Get the strikethrough presence where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="hasStrikethrough">The Boolean flag indicates whether text has strikethrough.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetStrikethrough(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL")] int* hasStrikethrough, DWRITE_TEXT_RANGE* textRange = null);

        /// <summary>Get the application-defined drawing effect where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="drawingEffect">The current application-defined drawing effect.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDrawingEffect(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint currentPosition, IUnknown** drawingEffect, DWRITE_TEXT_RANGE* textRange = null);

        /// <summary>Get the inline object at the given position.</summary>
        /// <param name="currentPosition">The given text position.</param>
        /// <param name="inlineObject">The inline object.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetInlineObject(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint currentPosition, IDWriteInlineObject** inlineObject, DWRITE_TEXT_RANGE* textRange = null);

        /// <summary>Get the typography setting where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="typography">The current typography setting.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypography(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint currentPosition, IDWriteTypography** typography, DWRITE_TEXT_RANGE* textRange = null);

        /// <summary>Get the length of the locale name where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="nameLength">Size of the character array in character count not including the terminated NULL character.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleNameLength1(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null);

        /// <summary>Get the locale name where the current position is at.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="localeName">Character array that receives the current locale name</param>
        /// <param name="nameSize">Size of the character array in character count including the terminated NULL character.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleName1(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR[]")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null);

        /// <summary>Initiate drawing of the text.</summary>
        /// <param name="clientDrawingContext">An application defined value included in rendering callbacks.</param>
        /// <param name="renderer">The set of application-defined callbacks that do the actual rendering.</param>
        /// <param name="originX">X-coordinate of the layout's left side.</param>
        /// <param name="originY">Y-coordinate of the layout's top side.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Draw(IDWriteTextLayout2* This, [Optional] void* clientDrawingContext, IDWriteTextRenderer* renderer, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY);

        /// <summary>GetLineMetrics returns properties of each line.</summary>
        /// <param name="lineMetrics">The array to fill with line information.</param>
        /// <param name="maxLineCount">The maximum size of the lineMetrics array.</param>
        /// <param name="actualLineCount">The actual size of the lineMetrics array that is needed.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> If maxLineCount is not large enough E_NOT_SUFFICIENT_BUFFER, which is equivalent to HRESULT_FROM_WIN32(ERROR_INSUFFICIENT_BUFFER), is returned and *actualLineCount is set to the number of lines needed.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLineMetrics(IDWriteTextLayout2* This, [Optional, NativeTypeName("DWRITE_LINE_METRICS[]")] DWRITE_LINE_METRICS* lineMetrics, [NativeTypeName("UINT32")] uint maxLineCount, [NativeTypeName("UINT32")] uint* actualLineCount);

        /// <summary>GetMetrics retrieves overall metrics for the formatted string.</summary>
        /// <param name="textMetrics">The returned metrics.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> Drawing effects like underline and strikethrough do not contribute to the text size, which is essentially the sum of advance widths and line heights. Additionally, visible swashes and other graphic adornments may extend outside the returned width and height.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetrics(IDWriteTextLayout2* This, DWRITE_TEXT_METRICS* textMetrics);

        /// <summary>GetOverhangMetrics returns the overhangs (in DIPs) of the layout and all objects contained in it, including text glyphs and inline objects.</summary>
        /// <param name="overhangs">Overshoots of visible extents (in DIPs) outside the layout.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> Any underline and strikethrough do not contribute to the black box determination, since these are actually drawn by the renderer, which is allowed to draw them in any variety of styles.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetOverhangMetrics(IDWriteTextLayout2* This, DWRITE_OVERHANG_METRICS* overhangs);

        /// <summary>Retrieve logical properties and measurement of each cluster.</summary>
        /// <param name="clusterMetrics">The array to fill with cluster information.</param>
        /// <param name="maxClusterCount">The maximum size of the clusterMetrics array.</param>
        /// <param name="actualClusterCount">The actual size of the clusterMetrics array that is needed.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> If maxClusterCount is not large enough E_NOT_SUFFICIENT_BUFFER, which is equivalent to HRESULT_FROM_WIN32(ERROR_INSUFFICIENT_BUFFER), is returned and *actualClusterCount is set to the number of clusters needed.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClusterMetrics(IDWriteTextLayout2* This, [Optional, NativeTypeName("DWRITE_CLUSTER_METRICS[]")] DWRITE_CLUSTER_METRICS* clusterMetrics, [NativeTypeName("UINT32")] uint maxClusterCount, [NativeTypeName("UINT32")] uint* actualClusterCount);

        /// <summary>Determines the minimum possible width the layout can be set to without emergency breaking between the characters of whole words.</summary>
        /// <param name="minWidth">Minimum width.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DetermineMinWidth(IDWriteTextLayout2* This, [NativeTypeName("FLOAT")] float* minWidth);

        /// <summary>Given a coordinate (in DIPs) relative to the top-left of the layout box, this returns the corresponding hit-test metrics of the text string where the hit-test has occurred. This is useful for mapping mouse clicks to caret positions. When the given coordinate is outside the text string, the function sets the output value *isInside to false but returns the nearest character position.</summary>
        /// <param name="pointX">X coordinate to hit-test, relative to the top-left location of the layout box.</param>
        /// <param name="pointY">Y coordinate to hit-test, relative to the top-left location of the layout box.</param>
        /// <param name="isTrailingHit">Output flag indicating whether the hit-test location is at the leading or the trailing side of the character. When the output *isInside value is set to false, this value is set according to the output *position value to represent the edge closest to the hit-test location. </param>
        /// <param name="isInside">Output flag indicating whether the hit-test location is inside the text string. When false, the position nearest the text's edge is returned.</param>
        /// <param name="hitTestMetrics">Output geometry fully enclosing the hit-test location. When the output *isInside value is set to false, this public partial structure represents the geometry enclosing the edge closest to the hit-test location.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _HitTestPoint(IDWriteTextLayout2* This, [NativeTypeName("FLOAT")] float pointX, [NativeTypeName("FLOAT")] float pointY, [NativeTypeName("BOOL")] int* isTrailingHit, [NativeTypeName("BOOL")] int* isInside, DWRITE_HIT_TEST_METRICS* hitTestMetrics);

        /// <summary>Given a text position and whether the caret is on the leading or trailing edge of that position, this returns the corresponding coordinate (in DIPs) relative to the top-left of the layout box. This is most useful for drawing the caret's current position, but it could also be used to anchor an IME to the typed text or attach a floating menu near the point of interest. It may also be used to programmatically obtain the geometry of a particular text position for UI automation.</summary>
        /// <param name="textPosition">Text position to get the coordinate of.</param>
        /// <param name="isTrailingHit">Flag indicating whether the location is of the leading or the trailing side of the specified text position. </param>
        /// <param name="pointX">Output caret X, relative to the top-left of the layout box.</param>
        /// <param name="pointY">Output caret Y, relative to the top-left of the layout box.</param>
        /// <param name="hitTestMetrics">Output geometry fully enclosing the specified text position.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> When drawing a caret at the returned X,Y, it should be centered on X and drawn from the Y coordinate down. The height will be the size of the hit-tested text (which can vary in size within a line). Reading direction also affects which side of the character the caret is drawn. However, the returned X coordinate will be correct for either case. You can get a text length back that is larger than a single character. This happens for complex scripts when multiple characters form a single cluster, when diacritics join their base character, or when you test a surrogate pair.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _HitTestTextPosition(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("BOOL")] int isTrailingHit, [NativeTypeName("FLOAT")] float* pointX, [NativeTypeName("FLOAT")] float* pointY, DWRITE_HIT_TEST_METRICS* hitTestMetrics);

        /// <summary>The application calls this function to get a set of hit-test metrics corresponding to a range of text positions. The main usage for this is to draw highlighted selection of the text string. The function returns E_NOT_SUFFICIENT_BUFFER, which is equivalent to HRESULT_FROM_WIN32(ERROR_INSUFFICIENT_BUFFER), when the buffer size of hitTestMetrics is too small to hold all the regions calculated by the function. In such situation, the function sets the output value *actualHitTestMetricsCount to the number of geometries calculated. The application is responsible to allocate a new buffer of greater size and call the function again. A good value to use as an initial value for maxHitTestMetricsCount may be calculated from the following equation: maxHitTestMetricsCount = lineCount * maxBidiReorderingDepth where lineCount is obtained from the value of the output argument *actualLineCount from the function IDWriteTextLayout::GetLineMetrics, and the maxBidiReorderingDepth value from the DWRITE_TEXT_METRICS public partial structure of the output argument *textMetrics from the function IDWriteFactory::CreateTextLayout.</summary>
        /// <param name="textPosition">First text position of the specified range.</param>
        /// <param name="textLength">Number of positions of the specified range.</param>
        /// <param name="originX">Offset of the X origin (left of the layout box) which is added to each of the hit-test metrics returned.</param>
        /// <param name="originY">Offset of the Y origin (top of the layout box) which is added to each of the hit-test metrics returned.</param>
        /// <param name="hitTestMetrics">Pointer to a buffer of the output geometry fully enclosing the specified position range.</param>
        /// <param name="maxHitTestMetricsCount">Maximum number of distinct metrics it could hold in its buffer memory.</param>
        /// <param name="actualHitTestMetricsCount">Actual number of metrics returned or needed.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> There are no gaps in the returned metrics. While there could be visual gaps, depending on bidi ordering, each range is contiguous and reports all the text, including any hidden characters and trimmed text. The height of each returned range will be the same within each line, regardless of how the font sizes vary.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _HitTestTextRange(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, [Optional, NativeTypeName("DWRITE_HIT_TEST_METRICS[]")] DWRITE_HIT_TEST_METRICS* hitTestMetrics, [NativeTypeName("UINT32")] uint maxHitTestMetricsCount, [NativeTypeName("UINT32")] uint* actualHitTestMetricsCount);

        /// <summary>Enables/disables pair-kerning on the given range.</summary>
        /// <param name="isPairKerningEnabled">The Boolean flag indicates whether text is pair-kerned.</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPairKerning(IDWriteTextLayout2* This, [NativeTypeName("BOOL")] int isPairKerningEnabled, DWRITE_TEXT_RANGE textRange);

        /// <summary>Get whether or not pair-kerning is enabled at given position.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="isPairKerningEnabled">The Boolean flag indicates whether text is pair-kerned.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPairKerning(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL")] int* isPairKerningEnabled, DWRITE_TEXT_RANGE* textRange = null);

        /// <summary>Sets the spacing between characters.</summary>
        /// <param name="leadingSpacing">The spacing before each character, in reading order.</param>
        /// <param name="trailingSpacing">The spacing after each character, in reading order.</param>
        /// <param name="minimumAdvanceWidth">The minimum advance of each character, to prevent characters from becoming too thin or zero-width. This must be zero or greater.</param>
        /// <param name="textRange">Text range to which this change applies.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCharacterSpacing(IDWriteTextLayout2* This, [NativeTypeName("FLOAT")] float leadingSpacing, [NativeTypeName("FLOAT")] float trailingSpacing, [NativeTypeName("FLOAT")] float minimumAdvanceWidth, DWRITE_TEXT_RANGE textRange);

        /// <summary>Gets the spacing between characters.</summary>
        /// <param name="currentPosition">The current text position.</param>
        /// <param name="leadingSpacing">The spacing before each character, in reading order.</param>
        /// <param name="trailingSpacing">The spacing after each character, in reading order.</param>
        /// <param name="minimumAdvanceWidth">The minimum advance of each character, to prevent characters from becoming too thin or zero-width. This must be zero or greater.</param>
        /// <param name="textRange">The position range of the current format.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCharacterSpacing(IDWriteTextLayout2* This, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("FLOAT")] float* leadingSpacing, [NativeTypeName("FLOAT")] float* trailingSpacing, [NativeTypeName("FLOAT")] float* minimumAdvanceWidth, DWRITE_TEXT_RANGE* textRange = null);

        /// <summary>GetMetrics retrieves overall metrics for the formatted string.</summary>
        /// <param name="textMetrics">The returned metrics.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> Drawing effects like underline and strikethrough do not contribute to the text size, which is essentially the sum of advance widths and line heights. Additionally, visible swashes and other graphic adornments may extend outside the returned width and height.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetrics1(IDWriteTextLayout2* This, DWRITE_TEXT_METRICS1* textMetrics);

        /// <summary>Set the preferred orientation of glyphs when using a vertical reading direction.</summary>
        /// <param name="glyphOrientation">Preferred glyph orientation.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetVerticalGlyphOrientation(IDWriteTextLayout2* This, DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation);

        /// <summary>Get the preferred orientation of glyphs when using a vertical reading direction.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_VERTICAL_GLYPH_ORIENTATION _GetVerticalGlyphOrientation(IDWriteTextLayout2* This);

        /// <summary>Set whether or not the last word on the last line is wrapped.</summary>
        /// <param name="isLastLineWrappingEnabled">Line wrapping option.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLastLineWrapping(IDWriteTextLayout2* This, [NativeTypeName("BOOL")] int isLastLineWrappingEnabled);

        /// <summary>Get whether or not the last word on the last line is wrapped.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetLastLineWrapping(IDWriteTextLayout2* This);

        /// <summary>Set how the glyphs align to the edges the margin. Default behavior is to align glyphs using their default glyphs metrics which include side bearings.</summary>
        /// <param name="opticalAlignment">Optical alignment option.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOpticalAlignment(IDWriteTextLayout2* This, DWRITE_OPTICAL_ALIGNMENT opticalAlignment);

        /// <summary>Get how the glyphs align to the edges the margin.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_OPTICAL_ALIGNMENT _GetOpticalAlignment(IDWriteTextLayout2* This);

        /// <summary>Apply a custom font fallback onto layout. If none is specified, layout uses the system fallback list.</summary>
        /// <param name="fontFallback">Custom font fallback created from IDWriteFontFallbackBuilder::CreateFontFallback or IDWriteFactory2::GetSystemFontFallback.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFontFallback(IDWriteTextLayout2* This, IDWriteFontFallback* fontFallback);

        /// <summary>Get the current font fallback object.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFallback(IDWriteTextLayout2* This, IDWriteFontFallback** fontFallback);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetTextAlignment>(lpVtbl->SetTextAlignment)(This, textAlignment);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetParagraphAlignment>(lpVtbl->SetParagraphAlignment)(This, paragraphAlignment);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetWordWrapping>(lpVtbl->SetWordWrapping)(This, wordWrapping);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetReadingDirection>(lpVtbl->SetReadingDirection)(This, readingDirection);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFlowDirection>(lpVtbl->SetFlowDirection)(This, flowDirection);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetIncrementalTabStop([NativeTypeName("FLOAT")] float incrementalTabStop)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetIncrementalTabStop>(lpVtbl->SetIncrementalTabStop)(This, incrementalTabStop);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTrimming(DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject* trimmingSign = null)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetTrimming>(lpVtbl->SetTrimming)(This, trimmingOptions, trimmingSign);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetLineSpacing>(lpVtbl->SetLineSpacing)(This, lineSpacingMethod, lineSpacing, baseline);
            }
        }

        public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTextAlignment>(lpVtbl->GetTextAlignment)(This);
            }
        }

        public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParagraphAlignment>(lpVtbl->GetParagraphAlignment)(This);
            }
        }

        public DWRITE_WORD_WRAPPING GetWordWrapping()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetWordWrapping>(lpVtbl->GetWordWrapping)(This);
            }
        }

        public DWRITE_READING_DIRECTION GetReadingDirection()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetReadingDirection>(lpVtbl->GetReadingDirection)(This);
            }
        }

        public DWRITE_FLOW_DIRECTION GetFlowDirection()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFlowDirection>(lpVtbl->GetFlowDirection)(This);
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetIncrementalTabStop()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetIncrementalTabStop>(lpVtbl->GetIncrementalTabStop)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTrimming(DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject** trimmingSign)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTrimming>(lpVtbl->GetTrimming)(This, trimmingOptions, trimmingSign);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing(DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT")] float* lineSpacing, [NativeTypeName("FLOAT")] float* baseline)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLineSpacing>(lpVtbl->GetLineSpacing)(This, lineSpacingMethod, lineSpacing, baseline);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection(IDWriteFontCollection** fontCollection)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontCollection>(lpVtbl->GetFontCollection)(This, fontCollection);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyNameLength()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyNameLength>(lpVtbl->GetFontFamilyNameLength)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("WCHAR[]")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyName>(lpVtbl->GetFontFamilyName)(This, fontFamilyName, nameSize);
            }
        }

        public DWRITE_FONT_WEIGHT GetFontWeight()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontWeight>(lpVtbl->GetFontWeight)(This);
            }
        }

        public DWRITE_FONT_STYLE GetFontStyle()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontStyle>(lpVtbl->GetFontStyle)(This);
            }
        }

        public DWRITE_FONT_STRETCH GetFontStretch()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontStretch>(lpVtbl->GetFontStretch)(This);
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetFontSize()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontSize>(lpVtbl->GetFontSize)(This);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetLocaleNameLength()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocaleNameLength>(lpVtbl->GetLocaleNameLength)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("WCHAR[]")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocaleName>(lpVtbl->GetLocaleName)(This, localeName, nameSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMaxWidth([NativeTypeName("FLOAT")] float maxWidth)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetMaxWidth>(lpVtbl->SetMaxWidth)(This, maxWidth);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMaxHeight([NativeTypeName("FLOAT")] float maxHeight)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetMaxHeight>(lpVtbl->SetMaxHeight)(This, maxHeight);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontCollection(IDWriteFontCollection* fontCollection, DWRITE_TEXT_RANGE textRange)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFontCollection>(lpVtbl->SetFontCollection)(This, fontCollection, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontFamilyName([NativeTypeName("WCHAR[]")] ushort* fontFamilyName, DWRITE_TEXT_RANGE textRange)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFontFamilyName>(lpVtbl->SetFontFamilyName)(This, fontFamilyName, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontWeight(DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFontWeight>(lpVtbl->SetFontWeight)(This, fontWeight, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontStyle(DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFontStyle>(lpVtbl->SetFontStyle)(This, fontStyle, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontStretch(DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFontStretch>(lpVtbl->SetFontStretch)(This, fontStretch, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontSize([NativeTypeName("FLOAT")] float fontSize, DWRITE_TEXT_RANGE textRange)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFontSize>(lpVtbl->SetFontSize)(This, fontSize, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUnderline([NativeTypeName("BOOL")] int hasUnderline, DWRITE_TEXT_RANGE textRange)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetUnderline>(lpVtbl->SetUnderline)(This, hasUnderline, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStrikethrough([NativeTypeName("BOOL")] int hasStrikethrough, DWRITE_TEXT_RANGE textRange)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetStrikethrough>(lpVtbl->SetStrikethrough)(This, hasStrikethrough, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDrawingEffect(IUnknown* drawingEffect, DWRITE_TEXT_RANGE textRange)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetDrawingEffect>(lpVtbl->SetDrawingEffect)(This, drawingEffect, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInlineObject(IDWriteInlineObject* inlineObject, DWRITE_TEXT_RANGE textRange)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetInlineObject>(lpVtbl->SetInlineObject)(This, inlineObject, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTypography(IDWriteTypography* typography, DWRITE_TEXT_RANGE textRange)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetTypography>(lpVtbl->SetTypography)(This, typography, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLocaleName([NativeTypeName("WCHAR[]")] ushort* localeName, DWRITE_TEXT_RANGE textRange)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetLocaleName>(lpVtbl->SetLocaleName)(This, localeName, textRange);
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetMaxWidth()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMaxWidth>(lpVtbl->GetMaxWidth)(This);
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetMaxHeight()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMaxHeight>(lpVtbl->GetMaxHeight)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection1([NativeTypeName("UINT32")] uint currentPosition, IDWriteFontCollection** fontCollection, DWRITE_TEXT_RANGE* textRange = null)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontCollection1>(lpVtbl->GetFontCollection1)(This, currentPosition, fontCollection, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyNameLength1([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyNameLength1>(lpVtbl->GetFontFamilyNameLength1)(This, currentPosition, nameLength, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName1([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR[]")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyName1>(lpVtbl->GetFontFamilyName1)(This, currentPosition, fontFamilyName, nameSize, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontWeight1([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_WEIGHT* fontWeight, DWRITE_TEXT_RANGE* textRange = null)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontWeight1>(lpVtbl->GetFontWeight1)(This, currentPosition, fontWeight, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontStyle1([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STYLE* fontStyle, DWRITE_TEXT_RANGE* textRange = null)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontStyle1>(lpVtbl->GetFontStyle1)(This, currentPosition, fontStyle, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontStretch1([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STRETCH* fontStretch, DWRITE_TEXT_RANGE* textRange = null)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontStretch1>(lpVtbl->GetFontStretch1)(This, currentPosition, fontStretch, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontSize1([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("FLOAT")] float* fontSize, DWRITE_TEXT_RANGE* textRange = null)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontSize1>(lpVtbl->GetFontSize1)(This, currentPosition, fontSize, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnderline([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL")] int* hasUnderline, DWRITE_TEXT_RANGE* textRange = null)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetUnderline>(lpVtbl->GetUnderline)(This, currentPosition, hasUnderline, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStrikethrough([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL")] int* hasStrikethrough, DWRITE_TEXT_RANGE* textRange = null)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStrikethrough>(lpVtbl->GetStrikethrough)(This, currentPosition, hasStrikethrough, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDrawingEffect([NativeTypeName("UINT32")] uint currentPosition, IUnknown** drawingEffect, DWRITE_TEXT_RANGE* textRange = null)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDrawingEffect>(lpVtbl->GetDrawingEffect)(This, currentPosition, drawingEffect, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInlineObject([NativeTypeName("UINT32")] uint currentPosition, IDWriteInlineObject** inlineObject, DWRITE_TEXT_RANGE* textRange = null)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetInlineObject>(lpVtbl->GetInlineObject)(This, currentPosition, inlineObject, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypography([NativeTypeName("UINT32")] uint currentPosition, IDWriteTypography** typography, DWRITE_TEXT_RANGE* textRange = null)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypography>(lpVtbl->GetTypography)(This, currentPosition, typography, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleNameLength1([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocaleNameLength1>(lpVtbl->GetLocaleNameLength1)(This, currentPosition, nameLength, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName1([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR[]")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocaleName1>(lpVtbl->GetLocaleName1)(This, currentPosition, localeName, nameSize, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Draw([Optional] void* clientDrawingContext, IDWriteTextRenderer* renderer, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Draw>(lpVtbl->Draw)(This, clientDrawingContext, renderer, originX, originY);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineMetrics([Optional, NativeTypeName("DWRITE_LINE_METRICS[]")] DWRITE_LINE_METRICS* lineMetrics, [NativeTypeName("UINT32")] uint maxLineCount, [NativeTypeName("UINT32")] uint* actualLineCount)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLineMetrics>(lpVtbl->GetLineMetrics)(This, lineMetrics, maxLineCount, actualLineCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetrics(DWRITE_TEXT_METRICS* textMetrics)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetrics>(lpVtbl->GetMetrics)(This, textMetrics);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOverhangMetrics(DWRITE_OVERHANG_METRICS* overhangs)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetOverhangMetrics>(lpVtbl->GetOverhangMetrics)(This, overhangs);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClusterMetrics([Optional, NativeTypeName("DWRITE_CLUSTER_METRICS[]")] DWRITE_CLUSTER_METRICS* clusterMetrics, [NativeTypeName("UINT32")] uint maxClusterCount, [NativeTypeName("UINT32")] uint* actualClusterCount)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetClusterMetrics>(lpVtbl->GetClusterMetrics)(This, clusterMetrics, maxClusterCount, actualClusterCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DetermineMinWidth([NativeTypeName("FLOAT")] float* minWidth)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DetermineMinWidth>(lpVtbl->DetermineMinWidth)(This, minWidth);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int HitTestPoint([NativeTypeName("FLOAT")] float pointX, [NativeTypeName("FLOAT")] float pointY, [NativeTypeName("BOOL")] int* isTrailingHit, [NativeTypeName("BOOL")] int* isInside, DWRITE_HIT_TEST_METRICS* hitTestMetrics)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_HitTestPoint>(lpVtbl->HitTestPoint)(This, pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int HitTestTextPosition([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("BOOL")] int isTrailingHit, [NativeTypeName("FLOAT")] float* pointX, [NativeTypeName("FLOAT")] float* pointY, DWRITE_HIT_TEST_METRICS* hitTestMetrics)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_HitTestTextPosition>(lpVtbl->HitTestTextPosition)(This, textPosition, isTrailingHit, pointX, pointY, hitTestMetrics);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int HitTestTextRange([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, [Optional, NativeTypeName("DWRITE_HIT_TEST_METRICS[]")] DWRITE_HIT_TEST_METRICS* hitTestMetrics, [NativeTypeName("UINT32")] uint maxHitTestMetricsCount, [NativeTypeName("UINT32")] uint* actualHitTestMetricsCount)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_HitTestTextRange>(lpVtbl->HitTestTextRange)(This, textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPairKerning([NativeTypeName("BOOL")] int isPairKerningEnabled, DWRITE_TEXT_RANGE textRange)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPairKerning>(lpVtbl->SetPairKerning)(This, isPairKerningEnabled, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPairKerning([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL")] int* isPairKerningEnabled, DWRITE_TEXT_RANGE* textRange = null)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPairKerning>(lpVtbl->GetPairKerning)(This, currentPosition, isPairKerningEnabled, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCharacterSpacing([NativeTypeName("FLOAT")] float leadingSpacing, [NativeTypeName("FLOAT")] float trailingSpacing, [NativeTypeName("FLOAT")] float minimumAdvanceWidth, DWRITE_TEXT_RANGE textRange)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetCharacterSpacing>(lpVtbl->SetCharacterSpacing)(This, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCharacterSpacing([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("FLOAT")] float* leadingSpacing, [NativeTypeName("FLOAT")] float* trailingSpacing, [NativeTypeName("FLOAT")] float* minimumAdvanceWidth, DWRITE_TEXT_RANGE* textRange = null)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCharacterSpacing>(lpVtbl->GetCharacterSpacing)(This, currentPosition, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetrics1(DWRITE_TEXT_METRICS1* textMetrics)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetrics1>(lpVtbl->GetMetrics1)(This, textMetrics);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetVerticalGlyphOrientation>(lpVtbl->SetVerticalGlyphOrientation)(This, glyphOrientation);
            }
        }

        public DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVerticalGlyphOrientation>(lpVtbl->GetVerticalGlyphOrientation)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLastLineWrapping([NativeTypeName("BOOL")] int isLastLineWrappingEnabled)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetLastLineWrapping>(lpVtbl->SetLastLineWrapping)(This, isLastLineWrappingEnabled);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int GetLastLineWrapping()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLastLineWrapping>(lpVtbl->GetLastLineWrapping)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetOpticalAlignment>(lpVtbl->SetOpticalAlignment)(This, opticalAlignment);
            }
        }

        public DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment()
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetOpticalAlignment>(lpVtbl->GetOpticalAlignment)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontFallback(IDWriteFontFallback* fontFallback)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFontFallback>(lpVtbl->SetFontFallback)(This, fontFallback);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFallback(IDWriteFontFallback** fontFallback)
        {
            fixed (IDWriteTextLayout2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFallback>(lpVtbl->GetFontFallback)(This, fontFallback);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

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

            public IntPtr SetPairKerning;

            public IntPtr GetPairKerning;

            public IntPtr SetCharacterSpacing;

            public IntPtr GetCharacterSpacing;

            public IntPtr GetMetrics1;

            public IntPtr SetVerticalGlyphOrientation;

            public IntPtr GetVerticalGlyphOrientation;

            public IntPtr SetLastLineWrapping;

            public IntPtr GetLastLineWrapping;

            public IntPtr SetOpticalAlignment;

            public IntPtr GetOpticalAlignment;

            public IntPtr SetFontFallback;

            public IntPtr GetFontFallback;
        }
    }
}
