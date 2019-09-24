// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The text analyzer interface represents a set of application-defined callbacks that perform rendering of text, inline objects, and decorations such as underlines.</summary>
    [Guid("553A9FF3-5693-4DF7-B52B-74806F7F2EB9")]
    public unsafe struct IDWriteTextAnalyzer2
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteTextAnalyzer2* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteTextAnalyzer2* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteTextAnalyzer2* This);

        /// <summary>Analyzes a text range for script boundaries, reading text attributes from the source and reporting the Unicode script ID to the sink callback SetScript.</summary>
        /// <param name="analysisSource">Source object to analyze.</param>
        /// <param name="textPosition">Starting position within the source object.</param>
        /// <param name="textLength">Length to analyze.</param>
        /// <param name="analysisSink">Callback object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AnalyzeScript(IDWriteTextAnalyzer2* This, IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink);

        /// <summary>Analyzes a text range for script directionality, reading attributes from the source and reporting levels to the sink callback SetBidiLevel.</summary>
        /// <param name="analysisSource">Source object to analyze.</param>
        /// <param name="textPosition">Starting position within the source object.</param>
        /// <param name="textLength">Length to analyze.</param>
        /// <param name="analysisSink">Callback object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> While the function can handle multiple paragraphs, the text range should not arbitrarily split the middle of paragraphs. Otherwise the returned levels may be wrong, since the Bidi algorithm is meant to apply to the paragraph as a whole.</remarks>
        /// <remarks> Embedded control codes (LRE/LRO/RLE/RLO/PDF) are taken into account.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AnalyzeBidi(IDWriteTextAnalyzer2* This, IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink);

        /// <summary>Analyzes a text range for spans where number substitution is applicable, reading attributes from the source and reporting substitutable ranges to the sink callback SetNumberSubstitution.</summary>
        /// <param name="analysisSource">Source object to analyze.</param>
        /// <param name="textPosition">Starting position within the source object.</param>
        /// <param name="textLength">Length to analyze.</param>
        /// <param name="analysisSink">Callback object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> While the function can handle multiple ranges of differing number substitutions, the text ranges should not arbitrarily split the middle of numbers. Otherwise it will treat the numbers separately and will not translate any intervening punctuation.</remarks>
        /// <remarks> Embedded control codes (LRE/LRO/RLE/RLO/PDF) are taken into account.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AnalyzeNumberSubstitution(IDWriteTextAnalyzer2* This, IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink);

        /// <summary>Analyzes a text range for potential breakpoint opportunities, reading attributes from the source and reporting breakpoint opportunities to the sink callback SetLineBreakpoints.</summary>
        /// <param name="analysisSource">Source object to analyze.</param>
        /// <param name="textPosition">Starting position within the source object.</param>
        /// <param name="textLength">Length to analyze.</param>
        /// <param name="analysisSink">Callback object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> While the function can handle multiple paragraphs, the text range should not arbitrarily split the middle of paragraphs, unless the given text span is considered a whole unit. Otherwise the returned properties for the first and last characters will inappropriately allow breaks.</remarks>
        /// <remarks> Special cases include the first, last, and surrogate characters. Any text span is treated as if adjacent to inline objects on either side. So the rules with contingent-break opportunities are used, where the edge between text and inline objects is always treated as a potential break opportunity, dependent on any overriding rules of the adjacent objects to prohibit or force the break (see Unicode TR #14). Surrogate pairs never break between.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AnalyzeLineBreakpoints(IDWriteTextAnalyzer2* This, IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink);

        /// <summary>Parses the input text string and maps it to the set of glyphs and associated glyph data according to the font and the writing system's rendering rules.</summary>
        /// <param name="textString">The string to convert to glyphs.</param>
        /// <param name="textLength">The length of textString.</param>
        /// <param name="fontFace">The font face to get glyphs from.</param>
        /// <param name="isSideways">Set to true if the text is intended to be drawn vertically.</param>
        /// <param name="isRightToLeft">Set to TRUE for right-to-left text.</param>
        /// <param name="scriptAnalysis">Script analysis result from AnalyzeScript.</param>
        /// <param name="localeName">The locale to use when selecting glyphs. e.g. the same character may map to different glyphs for ja-jp vs zh-chs. If this is NULL then the default mapping based on the script is used.</param>
        /// <param name="numberSubstitution">Optional number substitution which selects the appropriate glyphs for digits and related numeric characters, depending on the results obtained from AnalyzeNumberSubstitution. Passing null indicates that no substitution is needed and that the digits should receive nominal glyphs.</param>
        /// <param name="features">An array of pointers to the sets of typographic features to use in each feature range.</param>
        /// <param name="featureRangeLengths">The length of each feature range, in characters. The sum of all lengths should be equal to textLength.</param>
        /// <param name="featureRanges">The number of feature ranges.</param>
        /// <param name="maxGlyphCount">The maximum number of glyphs that can be returned.</param>
        /// <param name="clusterMap">The mapping from character ranges to glyph ranges.</param>
        /// <param name="textProps">Per-character output properties.</param>
        /// <param name="glyphIndices">Output glyph indices.</param>
        /// <param name="glyphProps">Per-glyph output properties.</param>
        /// <param name="actualGlyphCount">The actual number of glyphs returned if the call succeeds.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> Note that the mapping from characters to glyphs is, in general, many- to-many.  The recommended estimate for the per-glyph output buffers is (3 * textLength / 2 + 16).  This is not guaranteed to be sufficient. The value of the actualGlyphCount parameter is only valid if the call succeeds.  In the event that maxGlyphCount is not big enough E_NOT_SUFFICIENT_BUFFER, which is equivalent to HRESULT_FROM_WIN32(ERROR_INSUFFICIENT_BUFFER), will be returned.  The application should allocate a larger buffer and try again.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGlyphs(IDWriteTextAnalyzer2* This, [NativeTypeName("WCHAR[]")] ushort* textString, [NativeTypeName("UINT32")] uint textLength, IDWriteFontFace* fontFace, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [Optional, NativeTypeName("WCHAR[]")] ushort* localeName, [Optional] IDWriteNumberSubstitution* numberSubstitution, [Optional, NativeTypeName("DWRITE_TYPOGRAPHIC_FEATURES*[]")] DWRITE_TYPOGRAPHIC_FEATURES** features, [Optional, NativeTypeName("UINT32[]")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("UINT32")] uint maxGlyphCount, [NativeTypeName("UINT16[]")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES[]")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT16[]")] ushort* glyphIndices, [NativeTypeName("DWRITE_SHAPING_GLYPH_PROPERTIES[]")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint* actualGlyphCount);

        /// <summary>Place glyphs output from the GetGlyphs method according to the font and the writing system's rendering rules.</summary>
        /// <param name="textString">The original string the glyphs came from.</param>
        /// <param name="clusterMap">The mapping from character ranges to glyph ranges. Returned by GetGlyphs.</param>
        /// <param name="textProps">Per-character properties. Returned by GetGlyphs.</param>
        /// <param name="textLength">The length of textString.</param>
        /// <param name="glyphIndices">Glyph indices. See GetGlyphs</param>
        /// <param name="glyphProps">Per-glyph properties. See GetGlyphs</param>
        /// <param name="glyphCount">The number of glyphs.</param>
        /// <param name="fontFace">The font face the glyphs came from.</param>
        /// <param name="fontEmSize">Logical font size in DIP's.</param>
        /// <param name="isSideways">Set to true if the text is intended to be drawn vertically.</param>
        /// <param name="isRightToLeft">Set to TRUE for right-to-left text.</param>
        /// <param name="scriptAnalysis">Script analysis result from AnalyzeScript.</param>
        /// <param name="localeName">The locale to use when selecting glyphs. e.g. the same character may map to different glyphs for ja-jp vs zh-chs. If this is NULL then the default mapping based on the script is used.</param>
        /// <param name="features">An array of pointers to the sets of typographic features to use in each feature range.</param>
        /// <param name="featureRangeLengths">The length of each feature range, in characters. The sum of all lengths should be equal to textLength.</param>
        /// <param name="featureRanges">The number of feature ranges.</param>
        /// <param name="glyphAdvances">The advance width of each glyph.</param>
        /// <param name="glyphOffsets">The offset of the origin of each glyph.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGlyphPlacements(IDWriteTextAnalyzer2* This, [NativeTypeName("WCHAR[]")] ushort* textString, [NativeTypeName("UINT16[]")] ushort* clusterMap, DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT16[]")] ushort* glyphIndices, [NativeTypeName("DWRITE_SHAPING_GLYPH_PROPERTIES[]")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [Optional, NativeTypeName("WCHAR[]")] ushort* localeName, [Optional, NativeTypeName("DWRITE_TYPOGRAPHIC_FEATURES*[]")] DWRITE_TYPOGRAPHIC_FEATURES** features, [Optional, NativeTypeName("UINT32[]")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT[]")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* glyphOffsets);

        /// <summary>Place glyphs output from the GetGlyphs method according to the font and the writing system's rendering rules.</summary>
        /// <param name="textString">The original string the glyphs came from.</param>
        /// <param name="clusterMap">The mapping from character ranges to glyph ranges. Returned by GetGlyphs.</param>
        /// <param name="textProps">Per-character properties. Returned by GetGlyphs.</param>
        /// <param name="textLength">The length of textString.</param>
        /// <param name="glyphIndices">Glyph indices. See GetGlyphs</param>
        /// <param name="glyphProps">Per-glyph properties. See GetGlyphs</param>
        /// <param name="glyphCount">The number of glyphs.</param>
        /// <param name="fontFace">The font face the glyphs came from.</param>
        /// <param name="fontEmSize">Logical font size in DIP's.</param>
        /// <param name="pixelsPerDip">Number of physical pixels per DIP. For example, if the DPI of the rendering surface is 96 this value is 1.0f. If the DPI is 120, this value is 120.0f/96.</param>
        /// <param name="transform">Optional transform applied to the glyphs and their positions. This transform is applied after the scaling specified by the font size and pixelsPerDip.</param>
        /// <param name="useGdiNatural"> When set to FALSE, the metrics are the same as the metrics of GDI aliased text. When set to TRUE, the metrics are the same as the metrics of text measured by GDI using a font created with CLEARTYPE_NATURAL_QUALITY.</param>
        /// <param name="isSideways">Set to true if the text is intended to be drawn vertically.</param>
        /// <param name="isRightToLeft">Set to TRUE for right-to-left text.</param>
        /// <param name="scriptAnalysis">Script analysis result from AnalyzeScript.</param>
        /// <param name="localeName">The locale to use when selecting glyphs. e.g. the same character may map to different glyphs for ja-jp vs zh-chs. If this is NULL then the default mapping based on the script is used.</param>
        /// <param name="features">An array of pointers to the sets of typographic features to use in each feature range.</param>
        /// <param name="featureRangeLengths">The length of each feature range, in characters. The sum of all lengths should be equal to textLength.</param>
        /// <param name="featureRanges">The number of feature ranges.</param>
        /// <param name="glyphAdvances">The advance width of each glyph.</param>
        /// <param name="glyphOffsets">The offset of the origin of each glyph.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGdiCompatibleGlyphPlacements(IDWriteTextAnalyzer2* This, [NativeTypeName("WCHAR[]")] ushort* textString, [NativeTypeName("UINT16[]")] ushort* clusterMap, DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT16[]")] ushort* glyphIndices, DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [Optional] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [Optional, NativeTypeName("WCHAR[]")] ushort* localeName, [Optional, NativeTypeName("DWRITE_TYPOGRAPHIC_FEATURES*[]")] DWRITE_TYPOGRAPHIC_FEATURES** features, [Optional, NativeTypeName("UINT32[]")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT[]")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* glyphOffsets);

        /// <summary>Applies spacing between characters, properly adjusting glyph clusters and diacritics.</summary>
        /// <param name="leadingSpacing">The spacing before each character, in reading order.</param>
        /// <param name="trailingSpacing">The spacing after each character, in reading order.</param>
        /// <param name="minimumAdvanceWidth">The minimum advance of each character, to prevent characters from becoming too thin or zero-width. This must be zero or greater.</param>
        /// <param name="textLength">The length of the clustermap and original text.</param>
        /// <param name="glyphCount">The number of glyphs.</param>
        /// <param name="clusterMap">Mapping from character ranges to glyph ranges.</param>
        /// <param name="glyphAdvances">The advance width of each glyph.</param>
        /// <param name="glyphOffsets">The offset of the origin of each glyph.</param>
        /// <param name="glyphProperties">Properties of each glyph, from GetGlyphs.</param>
        /// <param name="modifiedGlyphAdvances">The new advance width of each glyph.</param>
        /// <param name="modifiedGlyphOffsets">The new offset of the origin of each glyph.</param>
        /// <remarks> The input and output advances/offsets are allowed to alias the same array.</remarks>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ApplyCharacterSpacing(IDWriteTextAnalyzer2* This, [NativeTypeName("FLOAT")] float leadingSpacing, [NativeTypeName("FLOAT")] float trailingSpacing, [NativeTypeName("FLOAT")] float minimumAdvanceWidth, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("UINT16[]")] ushort* clusterMap, [NativeTypeName("FLOAT[]")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("DWRITE_SHAPING_GLYPH_PROPERTIES[]")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, [NativeTypeName("FLOAT[]")] float* modifiedGlyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* modifiedGlyphOffsets);

        /// <summary>Retrieves the given baseline from the font.</summary>
        /// <param name="fontFace">The font face to read.</param>
        /// <param name="baseline">The baseline of interest.</param>
        /// <param name="isVertical">Whether the baseline is vertical or horizontal.</param>
        /// <param name="isSimulationAllowed">Simulate the baseline if it is missing in the font.</param>
        /// <param name="scriptAnalysis">Script analysis result from AnalyzeScript.</param>
        /// <param name="localeName">The language of the run.</param>
        /// <param name="baselineCoordinate">The baseline coordinate value in design units.</param>
        /// <param name="exists">Whether the returned baseline exists in the font.</param>
        /// <remarks> If the baseline does not exist in the font, it is not considered an error, but the function will return exists = false. You may then use heuristics to calculate the missing base, or, if the flag simulationAllowed is true, the function will compute a reasonable approximation for you.</remarks>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBaseline(IDWriteTextAnalyzer2* This, IDWriteFontFace* fontFace, DWRITE_BASELINE baseline, [NativeTypeName("BOOL")] int isVertical, [NativeTypeName("BOOL")] int isSimulationAllowed, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [Optional, NativeTypeName("WCHAR[]")] ushort* localeName, [NativeTypeName("INT32")] int* baselineCoordinate, [NativeTypeName("BOOL")] int* exists);

        /// <summary>Analyzes a text range for script orientation, reading text and attributes from the source and reporting results to the sink.</summary>
        /// <param name="analysisSource">Source object to analyze.</param>
        /// <param name="textPosition">Starting position within the source object.</param>
        /// <param name="textLength">Length to analyze.</param>
        /// <param name="analysisSink">Callback object.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> All bidi analysis should be resolved before calling this.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AnalyzeVerticalGlyphOrientation(IDWriteTextAnalyzer2* This, IDWriteTextAnalysisSource1* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink1* analysisSink);

        /// <summary>Returns 2x3 transform matrix for the respective angle to draw the glyph run.</summary>
        /// <param name="glyphOrientationAngle">The angle reported into SetGlyphOrientation.</param>
        /// <param name="isSideways">Whether the run's glyphs are sideways or not.</param>
        /// <param name="transform">Returned transform.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> The returned displacement is zero.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGlyphOrientationTransform(IDWriteTextAnalyzer2* This, DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, [NativeTypeName("BOOL")] int isSideways, DWRITE_MATRIX* transform);

        /// <summary>Returns the properties for a given script.</summary>
        /// <param name="scriptAnalysis">The script for a run of text returned from IDWriteTextAnalyzer::AnalyzeScript.</param>
        /// <param name="scriptProperties">Information for the script.</param>
        /// <returns> Returns properties for the given script. If the script is invalid, it returns generic properties for the unknown script and E_INVALIDARG.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetScriptProperties(IDWriteTextAnalyzer2* This, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, DWRITE_SCRIPT_PROPERTIES* scriptProperties);

        /// <summary>Determines the complexity of text, and whether or not full script shaping needs to be called (GetGlyphs).</summary>
        /// <param name="fontFace">The font face to read.</param>
        /// <param name="textLength">Length of the text to check.</param>
        /// <param name="textString">The text to check for complexity. This string may be UTF-16, but any supplementary characters will be considered complex.</param>
        /// <param name="isTextSimple">If true, the text is simple, and the glyphIndices array will already have the nominal glyphs for you. Otherwise you need to call GetGlyphs to properly shape complex scripts and OpenType features.</param>
        /// <param name="textLengthRead">The length read of the text run with the same complexity, simple or complex. You may call again from that point onward.</param>
        /// <param name="glyphIndices">Optional glyph indices for the text. If the function returned that the text was simple, you already have the glyphs you need. Otherwise the glyph indices are not meaningful, and you should call shaping instead.</param>
        /// <remarks> Text is not simple if the characters are part of a script that has complex shaping requirements, require bidi analysis, combine with other characters, reside in the supplementary planes, or have glyphs which participate in standard OpenType features. The length returned will not split combining marks from their base characters.</remarks>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTextComplexity(IDWriteTextAnalyzer2* This, [NativeTypeName("WCHAR[]")] ushort* textString, [NativeTypeName("UINT32")] uint textLength, IDWriteFontFace* fontFace, [NativeTypeName("BOOL")] int* isTextSimple, [NativeTypeName("UINT32")] uint* textLengthRead, [NativeTypeName("UINT16")] ushort* glyphIndices = null);

        /// <summary>Retrieves justification opportunity information for each of the glyphs given the text and shaping glyph properties.</summary>
        /// <param name="fontFace">Font face that was used for shaping. This is mainly important for returning correct results of the kashida width.</param>
        /// <param name="fontEmSize">Font em size used for the glyph run.</param>
        /// <param name="scriptAnalysis">Script of the text from the itemizer.</param>
        /// <param name="textLength">Length of the text.</param>
        /// <param name="glyphCount">Number of glyphs.</param>
        /// <param name="textString">Characters used to produce the glyphs.</param>
        /// <param name="clusterMap">Clustermap produced from shaping.</param>
        /// <param name="glyphProperties">Glyph properties produced from shaping.</param>
        /// <param name="justificationOpportunities">Receives information for the allowed justification expansion/compression for each glyph.</param>
        /// <remarks> This function is called per-run, after shaping is done via GetGlyphs(). Note this function only supports natural metrics (DWRITE_MEASURING_MODE_NATURAL).</remarks>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetJustificationOpportunities(IDWriteTextAnalyzer2* This, [Optional] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("WCHAR[]")] ushort* textString, [NativeTypeName("UINT16[]")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_GLYPH_PROPERTIES[]")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, [NativeTypeName("DWRITE_JUSTIFICATION_OPPORTUNITY[]")] DWRITE_JUSTIFICATION_OPPORTUNITY* justificationOpportunities);

        /// <summary>Justifies an array of glyph advances to fit the line width.</summary>
        /// <param name="lineWidth">Width of the line.</param>
        /// <param name="glyphCount">Number of glyphs.</param>
        /// <param name="justificationOpportunities">Opportunities per glyph. Call GetJustificationOpportunities() to get suitable opportunities according to script.</param>
        /// <param name="glyphAdvances">Original glyph advances from shaping.</param>
        /// <param name="glyphOffsets">Original glyph offsets from shaping.</param>
        /// <param name="justifiedGlyphAdvances">Justified glyph advances.</param>
        /// <param name="justifiedGlyphOffsets">Justified glyph offsets.</param>
        /// <remarks> This is called after all the opportunities have been collected, and it spans across the entire line. The input and output arrays are allowed to alias each other, permitting in-place update.</remarks>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _JustifyGlyphAdvances(IDWriteTextAnalyzer2* This, [NativeTypeName("FLOAT")] float lineWidth, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_JUSTIFICATION_OPPORTUNITY* justificationOpportunities, [NativeTypeName("FLOAT[]")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("FLOAT[]")] float* justifiedGlyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* justifiedGlyphOffsets = null);

        /// <summary>Fills in new glyphs for complex scripts where justification increased the advances of glyphs, such as Arabic with kashida.</summary>
        /// <param name="fontFace">Font face used for shaping.</param>
        /// <param name="fontEmSize">Font em size used for the glyph run.</param>
        /// <param name="scriptAnalysis">Script of the text from the itemizer.</param>
        /// <param name="textLength">Length of the text.</param>
        /// <param name="glyphCount">Number of glyphs.</param>
        /// <param name="maxGlyphCount">Maximum number of output glyphs allocated by caller.</param>
        /// <param name="clusterMap">Clustermap produced from shaping.</param>
        /// <param name="glyphIndices">Original glyphs produced from shaping.</param>
        /// <param name="glyphAdvances">Original glyph advances produced from shaping.</param>
        /// <param name="justifiedGlyphAdvances">Justified glyph advances from JustifyGlyphAdvances().</param>
        /// <param name="justifiedGlyphOffsets">Justified glyph offsets from JustifyGlyphAdvances().</param>
        /// <param name="glyphProperties">Properties of each glyph, from GetGlyphs.</param>
        /// <param name="actualGlyphCount">The new glyph count written to the modified arrays, or the needed glyph count if the size is not large enough.</param>
        /// <param name="modifiedClusterMap">Updated clustermap.</param>
        /// <param name="modifiedGlyphIndices">Updated glyphs with new glyphs inserted where needed.</param>
        /// <param name="modifiedGlyphAdvances">Updated glyph advances.</param>
        /// <param name="modifiedGlyphOffsets">Updated glyph offsets.</param>
        /// <remarks> This is called after the line has been justified, and it is per-run. It only needs to be called if the script has a specific justification character via GetScriptProperties, and it is mainly for cursive scripts like Arabic. If maxGlyphCount is not large enough, the error E_NOT_SUFFICIENT_BUFFER will be returned, with actualGlyphCount holding the final/needed glyph count.</remarks>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetJustifiedGlyphs(IDWriteTextAnalyzer2* This, [Optional] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("UINT32")] uint maxGlyphCount, [Optional, NativeTypeName("UINT16[]")] ushort* clusterMap, [NativeTypeName("UINT16[]")] ushort* glyphIndices, [NativeTypeName("FLOAT[]")] float* glyphAdvances, [NativeTypeName("FLOAT[]")] float* justifiedGlyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* justifiedGlyphOffsets, [NativeTypeName("DWRITE_SHAPING_GLYPH_PROPERTIES[]")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, [NativeTypeName("UINT32")] uint* actualGlyphCount, [Optional, NativeTypeName("UINT16[]")] ushort* modifiedClusterMap, [NativeTypeName("UINT16[]")] ushort* modifiedGlyphIndices, [NativeTypeName("FLOAT[]")] float* modifiedGlyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* modifiedGlyphOffsets);

        /// <summary>Returns 2x3 transform matrix for the respective angle to draw the glyph run or other object.</summary>
        /// <param name="glyphOrientationAngle">The angle reported to one of the application callbacks, including IDWriteTextAnalysisSink1::SetGlyphOrientation and IDWriteTextRenderer1::Draw*.</param>
        /// <param name="isSideways">Whether the run's glyphs are sideways or not.</param>
        /// <param name="originX">X origin of the element, be it a glyph run or underline or other.</param>
        /// <param name="originY">Y origin of the element, be it a glyph run or underline or other.</param>
        /// <param name="transform">Returned transform.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> This rotates around the given origin x and y, returning a translation component such that the glyph run, text decoration, or inline object is drawn with the right orientation at the expected coordinate.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGlyphOrientationTransform1(IDWriteTextAnalyzer2* This, DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, DWRITE_MATRIX* transform);

        /// <summary>Returns a list of typographic feature tags for the given script and language.</summary>
        /// <param name="fontFace">The font face to get features from.</param>
        /// <param name="scriptAnalysis">Script analysis result from AnalyzeScript.</param>
        /// <param name="localeName">The locale to use when selecting the feature, such en-us or ja-jp.</param>
        /// <param name="maxTagCount">Maximum tag count.</param>
        /// <param name="actualTagCount">Actual tag count. If greater than maxTagCount, E_NOT_SUFFICIENT_BUFFER is returned, and the call should be retried with a larger buffer.</param>
        /// <param name="tags">Feature tag list.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypographicFeatures(IDWriteTextAnalyzer2* This, IDWriteFontFace* fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [Optional, NativeTypeName("WCHAR[]")] ushort* localeName, [NativeTypeName("UINT32")] uint maxTagCount, [NativeTypeName("UINT32")] uint* actualTagCount, [NativeTypeName("DWRITE_FONT_FEATURE_TAG[]")] DWRITE_FONT_FEATURE_TAG* tags);

        /// <summary>Returns an array of which glyphs are affected by a given feature.</summary>
        /// <param name="fontFace">The font face to read glyph information from.</param>
        /// <param name="scriptAnalysis">Script analysis result from AnalyzeScript.</param>
        /// <param name="localeName">The locale to use when selecting the feature, such en-us or ja-jp.</param>
        /// <param name="featureTag">OpenType feature name to use, which may be one of the DWRITE_FONT_FEATURE_TAG values or a custom feature using DWRITE_MAKE_OPENTYPE_TAG.</param>
        /// <param name="glyphCount">Number of glyph indices to check.</param>
        /// <param name="glyphIndices">Glyph indices to check for feature application.</param>
        /// <param name="featureApplies">Output of which glyphs are affected by the feature, where for each glyph affected, the respective array index will be 1. The result is returned per-glyph without regard to neighboring context of adjacent glyphs.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckTypographicFeature(IDWriteTextAnalyzer2* This, IDWriteFontFace* fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [Optional, NativeTypeName("WCHAR[]")] ushort* localeName, DWRITE_FONT_FEATURE_TAG featureTag, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("UINT16[]")] ushort* glyphIndices, [NativeTypeName("UINT8[]")] byte* featureApplies);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeScript(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AnalyzeScript>(lpVtbl->AnalyzeScript)(This, analysisSource, textPosition, textLength, analysisSink);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeBidi(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AnalyzeBidi>(lpVtbl->AnalyzeBidi)(This, analysisSource, textPosition, textLength, analysisSink);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeNumberSubstitution(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AnalyzeNumberSubstitution>(lpVtbl->AnalyzeNumberSubstitution)(This, analysisSource, textPosition, textLength, analysisSink);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeLineBreakpoints(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AnalyzeLineBreakpoints>(lpVtbl->AnalyzeLineBreakpoints)(This, analysisSource, textPosition, textLength, analysisSink);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphs([NativeTypeName("WCHAR[]")] ushort* textString, [NativeTypeName("UINT32")] uint textLength, IDWriteFontFace* fontFace, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [Optional, NativeTypeName("WCHAR[]")] ushort* localeName, [Optional] IDWriteNumberSubstitution* numberSubstitution, [Optional, NativeTypeName("DWRITE_TYPOGRAPHIC_FEATURES*[]")] DWRITE_TYPOGRAPHIC_FEATURES** features, [Optional, NativeTypeName("UINT32[]")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("UINT32")] uint maxGlyphCount, [NativeTypeName("UINT16[]")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES[]")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT16[]")] ushort* glyphIndices, [NativeTypeName("DWRITE_SHAPING_GLYPH_PROPERTIES[]")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint* actualGlyphCount)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGlyphs>(lpVtbl->GetGlyphs)(This, textString, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphPlacements([NativeTypeName("WCHAR[]")] ushort* textString, [NativeTypeName("UINT16[]")] ushort* clusterMap, DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT16[]")] ushort* glyphIndices, [NativeTypeName("DWRITE_SHAPING_GLYPH_PROPERTIES[]")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [Optional, NativeTypeName("WCHAR[]")] ushort* localeName, [Optional, NativeTypeName("DWRITE_TYPOGRAPHIC_FEATURES*[]")] DWRITE_TYPOGRAPHIC_FEATURES** features, [Optional, NativeTypeName("UINT32[]")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT[]")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* glyphOffsets)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGlyphPlacements>(lpVtbl->GetGlyphPlacements)(This, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphPlacements([NativeTypeName("WCHAR[]")] ushort* textString, [NativeTypeName("UINT16[]")] ushort* clusterMap, DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT16[]")] ushort* glyphIndices, DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [Optional] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [Optional, NativeTypeName("WCHAR[]")] ushort* localeName, [Optional, NativeTypeName("DWRITE_TYPOGRAPHIC_FEATURES*[]")] DWRITE_TYPOGRAPHIC_FEATURES** features, [Optional, NativeTypeName("UINT32[]")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT[]")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* glyphOffsets)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGdiCompatibleGlyphPlacements>(lpVtbl->GetGdiCompatibleGlyphPlacements)(This, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ApplyCharacterSpacing([NativeTypeName("FLOAT")] float leadingSpacing, [NativeTypeName("FLOAT")] float trailingSpacing, [NativeTypeName("FLOAT")] float minimumAdvanceWidth, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("UINT16[]")] ushort* clusterMap, [NativeTypeName("FLOAT[]")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("DWRITE_SHAPING_GLYPH_PROPERTIES[]")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, [NativeTypeName("FLOAT[]")] float* modifiedGlyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* modifiedGlyphOffsets)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ApplyCharacterSpacing>(lpVtbl->ApplyCharacterSpacing)(This, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textLength, glyphCount, clusterMap, glyphAdvances, glyphOffsets, glyphProperties, modifiedGlyphAdvances, modifiedGlyphOffsets);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBaseline(IDWriteFontFace* fontFace, DWRITE_BASELINE baseline, [NativeTypeName("BOOL")] int isVertical, [NativeTypeName("BOOL")] int isSimulationAllowed, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [Optional, NativeTypeName("WCHAR[]")] ushort* localeName, [NativeTypeName("INT32")] int* baselineCoordinate, [NativeTypeName("BOOL")] int* exists)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBaseline>(lpVtbl->GetBaseline)(This, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, exists);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeVerticalGlyphOrientation(IDWriteTextAnalysisSource1* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink1* analysisSink)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AnalyzeVerticalGlyphOrientation>(lpVtbl->AnalyzeVerticalGlyphOrientation)(This, analysisSource, textPosition, textLength, analysisSink);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphOrientationTransform(DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, [NativeTypeName("BOOL")] int isSideways, DWRITE_MATRIX* transform)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGlyphOrientationTransform>(lpVtbl->GetGlyphOrientationTransform)(This, glyphOrientationAngle, isSideways, transform);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetScriptProperties(DWRITE_SCRIPT_ANALYSIS scriptAnalysis, DWRITE_SCRIPT_PROPERTIES* scriptProperties)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetScriptProperties>(lpVtbl->GetScriptProperties)(This, scriptAnalysis, scriptProperties);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTextComplexity([NativeTypeName("WCHAR[]")] ushort* textString, [NativeTypeName("UINT32")] uint textLength, IDWriteFontFace* fontFace, [NativeTypeName("BOOL")] int* isTextSimple, [NativeTypeName("UINT32")] uint* textLengthRead, [NativeTypeName("UINT16")] ushort* glyphIndices = null)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTextComplexity>(lpVtbl->GetTextComplexity)(This, textString, textLength, fontFace, isTextSimple, textLengthRead, glyphIndices);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetJustificationOpportunities([Optional] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("WCHAR[]")] ushort* textString, [NativeTypeName("UINT16[]")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_GLYPH_PROPERTIES[]")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, [NativeTypeName("DWRITE_JUSTIFICATION_OPPORTUNITY[]")] DWRITE_JUSTIFICATION_OPPORTUNITY* justificationOpportunities)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetJustificationOpportunities>(lpVtbl->GetJustificationOpportunities)(This, fontFace, fontEmSize, scriptAnalysis, textLength, glyphCount, textString, clusterMap, glyphProperties, justificationOpportunities);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int JustifyGlyphAdvances([NativeTypeName("FLOAT")] float lineWidth, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_JUSTIFICATION_OPPORTUNITY* justificationOpportunities, [NativeTypeName("FLOAT[]")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("FLOAT[]")] float* justifiedGlyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* justifiedGlyphOffsets = null)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_JustifyGlyphAdvances>(lpVtbl->JustifyGlyphAdvances)(This, lineWidth, glyphCount, justificationOpportunities, glyphAdvances, glyphOffsets, justifiedGlyphAdvances, justifiedGlyphOffsets);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetJustifiedGlyphs([Optional] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("UINT32")] uint maxGlyphCount, [Optional, NativeTypeName("UINT16[]")] ushort* clusterMap, [NativeTypeName("UINT16[]")] ushort* glyphIndices, [NativeTypeName("FLOAT[]")] float* glyphAdvances, [NativeTypeName("FLOAT[]")] float* justifiedGlyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* justifiedGlyphOffsets, [NativeTypeName("DWRITE_SHAPING_GLYPH_PROPERTIES[]")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, [NativeTypeName("UINT32")] uint* actualGlyphCount, [Optional, NativeTypeName("UINT16[]")] ushort* modifiedClusterMap, [NativeTypeName("UINT16[]")] ushort* modifiedGlyphIndices, [NativeTypeName("FLOAT[]")] float* modifiedGlyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* modifiedGlyphOffsets)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetJustifiedGlyphs>(lpVtbl->GetJustifiedGlyphs)(This, fontFace, fontEmSize, scriptAnalysis, textLength, glyphCount, maxGlyphCount, clusterMap, glyphIndices, glyphAdvances, justifiedGlyphAdvances, justifiedGlyphOffsets, glyphProperties, actualGlyphCount, modifiedClusterMap, modifiedGlyphIndices, modifiedGlyphAdvances, modifiedGlyphOffsets);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphOrientationTransform1(DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, DWRITE_MATRIX* transform)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGlyphOrientationTransform1>(lpVtbl->GetGlyphOrientationTransform1)(This, glyphOrientationAngle, isSideways, originX, originY, transform);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypographicFeatures(IDWriteFontFace* fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [Optional, NativeTypeName("WCHAR[]")] ushort* localeName, [NativeTypeName("UINT32")] uint maxTagCount, [NativeTypeName("UINT32")] uint* actualTagCount, [NativeTypeName("DWRITE_FONT_FEATURE_TAG[]")] DWRITE_FONT_FEATURE_TAG* tags)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypographicFeatures>(lpVtbl->GetTypographicFeatures)(This, fontFace, scriptAnalysis, localeName, maxTagCount, actualTagCount, tags);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckTypographicFeature(IDWriteFontFace* fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [Optional, NativeTypeName("WCHAR[]")] ushort* localeName, DWRITE_FONT_FEATURE_TAG featureTag, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("UINT16[]")] ushort* glyphIndices, [NativeTypeName("UINT8[]")] byte* featureApplies)
        {
            fixed (IDWriteTextAnalyzer2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CheckTypographicFeature>(lpVtbl->CheckTypographicFeature)(This, fontFace, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureApplies);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr AnalyzeScript;

            public IntPtr AnalyzeBidi;

            public IntPtr AnalyzeNumberSubstitution;

            public IntPtr AnalyzeLineBreakpoints;

            public IntPtr GetGlyphs;

            public IntPtr GetGlyphPlacements;

            public IntPtr GetGdiCompatibleGlyphPlacements;

            public IntPtr ApplyCharacterSpacing;

            public IntPtr GetBaseline;

            public IntPtr AnalyzeVerticalGlyphOrientation;

            public IntPtr GetGlyphOrientationTransform;

            public IntPtr GetScriptProperties;

            public IntPtr GetTextComplexity;

            public IntPtr GetJustificationOpportunities;

            public IntPtr JustifyGlyphAdvances;

            public IntPtr GetJustifiedGlyphs;

            public IntPtr GetGlyphOrientationTransform1;

            public IntPtr GetTypographicFeatures;

            public IntPtr CheckTypographicFeature;
        }
    }
}
