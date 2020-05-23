// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("553A9FF3-5693-4DF7-B52B-74806F7F2EB9")]
    public unsafe partial struct IDWriteTextAnalyzer2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteTextAnalyzer2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteTextAnalyzer2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteTextAnalyzer2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AnalyzeScript(IDWriteTextAnalyzer2* pThis, [NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AnalyzeBidi(IDWriteTextAnalyzer2* pThis, [NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AnalyzeNumberSubstitution(IDWriteTextAnalyzer2* pThis, [NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AnalyzeLineBreakpoints(IDWriteTextAnalyzer2* pThis, [NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGlyphs(IDWriteTextAnalyzer2* pThis, [NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("IDWriteNumberSubstitution *")] IDWriteNumberSubstitution* numberSubstitution, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("UINT32")] uint maxGlyphCount, [NativeTypeName("UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT16 *")] ushort* glyphIndices, [NativeTypeName("DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32 *")] uint* actualGlyphCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGlyphPlacements(IDWriteTextAnalyzer2* pThis, [NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT *")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGdiCompatibleGlyphPlacements(IDWriteTextAnalyzer2* pThis, [NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT *")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ApplyCharacterSpacing(IDWriteTextAnalyzer2* pThis, [NativeTypeName("FLOAT")] float leadingSpacing, [NativeTypeName("FLOAT")] float trailingSpacing, [NativeTypeName("FLOAT")] float minimumAdvanceWidth, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, [NativeTypeName("FLOAT *")] float* modifiedGlyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* modifiedGlyphOffsets);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBaseline(IDWriteTextAnalyzer2* pThis, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, DWRITE_BASELINE baseline, [NativeTypeName("BOOL")] int isVertical, [NativeTypeName("BOOL")] int isSimulationAllowed, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("INT32 *")] int* baselineCoordinate, [NativeTypeName("BOOL *")] int* exists);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AnalyzeVerticalGlyphOrientation(IDWriteTextAnalyzer2* pThis, [NativeTypeName("IDWriteTextAnalysisSource1 *")] IDWriteTextAnalysisSource1* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink1 *")] IDWriteTextAnalysisSink1* analysisSink);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGlyphOrientationTransform(IDWriteTextAnalyzer2* pThis, DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("DWRITE_MATRIX *")] DWRITE_MATRIX* transform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetScriptProperties(IDWriteTextAnalyzer2* pThis, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("DWRITE_SCRIPT_PROPERTIES *")] DWRITE_SCRIPT_PROPERTIES* scriptProperties);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTextComplexity(IDWriteTextAnalyzer2* pThis, [NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("BOOL *")] int* isTextSimple, [NativeTypeName("UINT32 *")] uint* textLengthRead, [NativeTypeName("UINT16 *")] ushort* glyphIndices);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetJustificationOpportunities(IDWriteTextAnalyzer2* pThis, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, [NativeTypeName("DWRITE_JUSTIFICATION_OPPORTUNITY *")] DWRITE_JUSTIFICATION_OPPORTUNITY* justificationOpportunities);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _JustifyGlyphAdvances(IDWriteTextAnalyzer2* pThis, [NativeTypeName("FLOAT")] float lineWidth, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const DWRITE_JUSTIFICATION_OPPORTUNITY *")] DWRITE_JUSTIFICATION_OPPORTUNITY* justificationOpportunities, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("FLOAT *")] float* justifiedGlyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* justifiedGlyphOffsets);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetJustifiedGlyphs(IDWriteTextAnalyzer2* pThis, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("UINT32")] uint maxGlyphCount, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const FLOAT *")] float* justifiedGlyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* justifiedGlyphOffsets, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, [NativeTypeName("UINT32 *")] uint* actualGlyphCount, [NativeTypeName("UINT16 *")] ushort* modifiedClusterMap, [NativeTypeName("UINT16 *")] ushort* modifiedGlyphIndices, [NativeTypeName("FLOAT *")] float* modifiedGlyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* modifiedGlyphOffsets);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGlyphOrientationTransform1(IDWriteTextAnalyzer2* pThis, DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, [NativeTypeName("DWRITE_MATRIX *")] DWRITE_MATRIX* transform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypographicFeatures(IDWriteTextAnalyzer2* pThis, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint maxTagCount, [NativeTypeName("UINT32 *")] uint* actualTagCount, [NativeTypeName("DWRITE_FONT_FEATURE_TAG *")] DWRITE_FONT_FEATURE_TAG* tags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckTypographicFeature(IDWriteTextAnalyzer2* pThis, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, DWRITE_FONT_FEATURE_TAG featureTag, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT8 *")] byte* featureApplies);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeScript([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink)
        {
            return Marshal.GetDelegateForFunctionPointer<_AnalyzeScript>(lpVtbl->AnalyzeScript)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeBidi([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink)
        {
            return Marshal.GetDelegateForFunctionPointer<_AnalyzeBidi>(lpVtbl->AnalyzeBidi)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeNumberSubstitution([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink)
        {
            return Marshal.GetDelegateForFunctionPointer<_AnalyzeNumberSubstitution>(lpVtbl->AnalyzeNumberSubstitution)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeLineBreakpoints([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink)
        {
            return Marshal.GetDelegateForFunctionPointer<_AnalyzeLineBreakpoints>(lpVtbl->AnalyzeLineBreakpoints)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphs([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("IDWriteNumberSubstitution *")] IDWriteNumberSubstitution* numberSubstitution, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("UINT32")] uint maxGlyphCount, [NativeTypeName("UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT16 *")] ushort* glyphIndices, [NativeTypeName("DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32 *")] uint* actualGlyphCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGlyphs>(lpVtbl->GetGlyphs)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), textString, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphPlacements([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT *")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGlyphPlacements>(lpVtbl->GetGlyphPlacements)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphPlacements([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT *")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGdiCompatibleGlyphPlacements>(lpVtbl->GetGdiCompatibleGlyphPlacements)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        [return: NativeTypeName("HRESULT")]
        public int ApplyCharacterSpacing([NativeTypeName("FLOAT")] float leadingSpacing, [NativeTypeName("FLOAT")] float trailingSpacing, [NativeTypeName("FLOAT")] float minimumAdvanceWidth, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, [NativeTypeName("FLOAT *")] float* modifiedGlyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* modifiedGlyphOffsets)
        {
            return Marshal.GetDelegateForFunctionPointer<_ApplyCharacterSpacing>(lpVtbl->ApplyCharacterSpacing)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), leadingSpacing, trailingSpacing, minimumAdvanceWidth, textLength, glyphCount, clusterMap, glyphAdvances, glyphOffsets, glyphProperties, modifiedGlyphAdvances, modifiedGlyphOffsets);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBaseline([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, DWRITE_BASELINE baseline, [NativeTypeName("BOOL")] int isVertical, [NativeTypeName("BOOL")] int isSimulationAllowed, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("INT32 *")] int* baselineCoordinate, [NativeTypeName("BOOL *")] int* exists)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBaseline>(lpVtbl->GetBaseline)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, exists);
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeVerticalGlyphOrientation([NativeTypeName("IDWriteTextAnalysisSource1 *")] IDWriteTextAnalysisSource1* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink1 *")] IDWriteTextAnalysisSink1* analysisSink)
        {
            return Marshal.GetDelegateForFunctionPointer<_AnalyzeVerticalGlyphOrientation>(lpVtbl->AnalyzeVerticalGlyphOrientation)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphOrientationTransform(DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("DWRITE_MATRIX *")] DWRITE_MATRIX* transform)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGlyphOrientationTransform>(lpVtbl->GetGlyphOrientationTransform)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), glyphOrientationAngle, isSideways, transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetScriptProperties(DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("DWRITE_SCRIPT_PROPERTIES *")] DWRITE_SCRIPT_PROPERTIES* scriptProperties)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetScriptProperties>(lpVtbl->GetScriptProperties)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), scriptAnalysis, scriptProperties);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTextComplexity([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("BOOL *")] int* isTextSimple, [NativeTypeName("UINT32 *")] uint* textLengthRead, [NativeTypeName("UINT16 *")] ushort* glyphIndices)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTextComplexity>(lpVtbl->GetTextComplexity)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), textString, textLength, fontFace, isTextSimple, textLengthRead, glyphIndices);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetJustificationOpportunities([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, [NativeTypeName("DWRITE_JUSTIFICATION_OPPORTUNITY *")] DWRITE_JUSTIFICATION_OPPORTUNITY* justificationOpportunities)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetJustificationOpportunities>(lpVtbl->GetJustificationOpportunities)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), fontFace, fontEmSize, scriptAnalysis, textLength, glyphCount, textString, clusterMap, glyphProperties, justificationOpportunities);
        }

        [return: NativeTypeName("HRESULT")]
        public int JustifyGlyphAdvances([NativeTypeName("FLOAT")] float lineWidth, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const DWRITE_JUSTIFICATION_OPPORTUNITY *")] DWRITE_JUSTIFICATION_OPPORTUNITY* justificationOpportunities, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("FLOAT *")] float* justifiedGlyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* justifiedGlyphOffsets)
        {
            return Marshal.GetDelegateForFunctionPointer<_JustifyGlyphAdvances>(lpVtbl->JustifyGlyphAdvances)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), lineWidth, glyphCount, justificationOpportunities, glyphAdvances, glyphOffsets, justifiedGlyphAdvances, justifiedGlyphOffsets);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetJustifiedGlyphs([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("UINT32")] uint maxGlyphCount, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const FLOAT *")] float* justifiedGlyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* justifiedGlyphOffsets, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, [NativeTypeName("UINT32 *")] uint* actualGlyphCount, [NativeTypeName("UINT16 *")] ushort* modifiedClusterMap, [NativeTypeName("UINT16 *")] ushort* modifiedGlyphIndices, [NativeTypeName("FLOAT *")] float* modifiedGlyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* modifiedGlyphOffsets)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetJustifiedGlyphs>(lpVtbl->GetJustifiedGlyphs)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), fontFace, fontEmSize, scriptAnalysis, textLength, glyphCount, maxGlyphCount, clusterMap, glyphIndices, glyphAdvances, justifiedGlyphAdvances, justifiedGlyphOffsets, glyphProperties, actualGlyphCount, modifiedClusterMap, modifiedGlyphIndices, modifiedGlyphAdvances, modifiedGlyphOffsets);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphOrientationTransform(DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, [NativeTypeName("DWRITE_MATRIX *")] DWRITE_MATRIX* transform)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGlyphOrientationTransform1>(lpVtbl->GetGlyphOrientationTransform1)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), glyphOrientationAngle, isSideways, originX, originY, transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypographicFeatures([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint maxTagCount, [NativeTypeName("UINT32 *")] uint* actualTagCount, [NativeTypeName("DWRITE_FONT_FEATURE_TAG *")] DWRITE_FONT_FEATURE_TAG* tags)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypographicFeatures>(lpVtbl->GetTypographicFeatures)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), fontFace, scriptAnalysis, localeName, maxTagCount, actualTagCount, tags);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckTypographicFeature([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, DWRITE_FONT_FEATURE_TAG featureTag, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT8 *")] byte* featureApplies)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckTypographicFeature>(lpVtbl->CheckTypographicFeature)((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), fontFace, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureApplies);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteTextAnalysisSink *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AnalyzeScript;

            [NativeTypeName("HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteTextAnalysisSink *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AnalyzeBidi;

            [NativeTypeName("HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteTextAnalysisSink *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AnalyzeNumberSubstitution;

            [NativeTypeName("HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteTextAnalysisSink *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AnalyzeLineBreakpoints;

            [NativeTypeName("HRESULT (const WCHAR *, UINT32, IDWriteFontFace *, BOOL, BOOL, const DWRITE_SCRIPT_ANALYSIS *, const WCHAR *, IDWriteNumberSubstitution *, const DWRITE_TYPOGRAPHIC_FEATURES **, const UINT32 *, UINT32, UINT32, UINT16 *, DWRITE_SHAPING_TEXT_PROPERTIES *, UINT16 *, DWRITE_SHAPING_GLYPH_PROPERTIES *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGlyphs;

            [NativeTypeName("HRESULT (const WCHAR *, const UINT16 *, DWRITE_SHAPING_TEXT_PROPERTIES *, UINT32, const UINT16 *, const DWRITE_SHAPING_GLYPH_PROPERTIES *, UINT32, IDWriteFontFace *, FLOAT, BOOL, BOOL, const DWRITE_SCRIPT_ANALYSIS *, const WCHAR *, const DWRITE_TYPOGRAPHIC_FEATURES **, const UINT32 *, UINT32, FLOAT *, DWRITE_GLYPH_OFFSET *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGlyphPlacements;

            [NativeTypeName("HRESULT (const WCHAR *, const UINT16 *, DWRITE_SHAPING_TEXT_PROPERTIES *, UINT32, const UINT16 *, const DWRITE_SHAPING_GLYPH_PROPERTIES *, UINT32, IDWriteFontFace *, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, BOOL, BOOL, const DWRITE_SCRIPT_ANALYSIS *, const WCHAR *, const DWRITE_TYPOGRAPHIC_FEATURES **, const UINT32 *, UINT32, FLOAT *, DWRITE_GLYPH_OFFSET *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGdiCompatibleGlyphPlacements;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, UINT32, UINT32, const UINT16 *, const FLOAT *, const DWRITE_GLYPH_OFFSET *, const DWRITE_SHAPING_GLYPH_PROPERTIES *, FLOAT *, DWRITE_GLYPH_OFFSET *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ApplyCharacterSpacing;

            [NativeTypeName("HRESULT (IDWriteFontFace *, DWRITE_BASELINE, BOOL, BOOL, DWRITE_SCRIPT_ANALYSIS, const WCHAR *, INT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetBaseline;

            [NativeTypeName("HRESULT (IDWriteTextAnalysisSource1 *, UINT32, UINT32, IDWriteTextAnalysisSink1 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AnalyzeVerticalGlyphOrientation;

            [NativeTypeName("HRESULT (DWRITE_GLYPH_ORIENTATION_ANGLE, BOOL, DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGlyphOrientationTransform;

            [NativeTypeName("HRESULT (DWRITE_SCRIPT_ANALYSIS, DWRITE_SCRIPT_PROPERTIES *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetScriptProperties;

            [NativeTypeName("HRESULT (const WCHAR *, UINT32, IDWriteFontFace *, BOOL *, UINT32 *, UINT16 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTextComplexity;

            [NativeTypeName("HRESULT (IDWriteFontFace *, FLOAT, DWRITE_SCRIPT_ANALYSIS, UINT32, UINT32, const WCHAR *, const UINT16 *, const DWRITE_SHAPING_GLYPH_PROPERTIES *, DWRITE_JUSTIFICATION_OPPORTUNITY *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetJustificationOpportunities;

            [NativeTypeName("HRESULT (FLOAT, UINT32, const DWRITE_JUSTIFICATION_OPPORTUNITY *, const FLOAT *, const DWRITE_GLYPH_OFFSET *, FLOAT *, DWRITE_GLYPH_OFFSET *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr JustifyGlyphAdvances;

            [NativeTypeName("HRESULT (IDWriteFontFace *, FLOAT, DWRITE_SCRIPT_ANALYSIS, UINT32, UINT32, UINT32, const UINT16 *, const UINT16 *, const FLOAT *, const FLOAT *, const DWRITE_GLYPH_OFFSET *, const DWRITE_SHAPING_GLYPH_PROPERTIES *, UINT32 *, UINT16 *, UINT16 *, FLOAT *, DWRITE_GLYPH_OFFSET *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetJustifiedGlyphs;

            [NativeTypeName("HRESULT (DWRITE_GLYPH_ORIENTATION_ANGLE, BOOL, FLOAT, FLOAT, DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGlyphOrientationTransform1;

            [NativeTypeName("HRESULT (IDWriteFontFace *, DWRITE_SCRIPT_ANALYSIS, const WCHAR *, UINT32, UINT32 *, DWRITE_FONT_FEATURE_TAG *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTypographicFeatures;

            [NativeTypeName("HRESULT (IDWriteFontFace *, DWRITE_SCRIPT_ANALYSIS, const WCHAR *, DWRITE_FONT_FEATURE_TAG, UINT32, const UINT16 *, UINT8 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CheckTypographicFeature;
        }
    }
}
