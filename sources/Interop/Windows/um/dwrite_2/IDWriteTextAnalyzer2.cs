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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeScript([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink)
        {
            return lpVtbl->AnalyzeScript((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeBidi([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink)
        {
            return lpVtbl->AnalyzeBidi((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeNumberSubstitution([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink)
        {
            return lpVtbl->AnalyzeNumberSubstitution((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeLineBreakpoints([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink)
        {
            return lpVtbl->AnalyzeLineBreakpoints((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphs([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("IDWriteNumberSubstitution *")] IDWriteNumberSubstitution* numberSubstitution, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("UINT32")] uint maxGlyphCount, [NativeTypeName("UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT16 *")] ushort* glyphIndices, [NativeTypeName("DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32 *")] uint* actualGlyphCount)
        {
            return lpVtbl->GetGlyphs((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), textString, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphPlacements([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT *")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets)
        {
            return lpVtbl->GetGlyphPlacements((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphPlacements([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT *")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets)
        {
            return lpVtbl->GetGdiCompatibleGlyphPlacements((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        [return: NativeTypeName("HRESULT")]
        public int ApplyCharacterSpacing([NativeTypeName("FLOAT")] float leadingSpacing, [NativeTypeName("FLOAT")] float trailingSpacing, [NativeTypeName("FLOAT")] float minimumAdvanceWidth, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, [NativeTypeName("FLOAT *")] float* modifiedGlyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* modifiedGlyphOffsets)
        {
            return lpVtbl->ApplyCharacterSpacing((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), leadingSpacing, trailingSpacing, minimumAdvanceWidth, textLength, glyphCount, clusterMap, glyphAdvances, glyphOffsets, glyphProperties, modifiedGlyphAdvances, modifiedGlyphOffsets);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBaseline([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, DWRITE_BASELINE baseline, [NativeTypeName("BOOL")] int isVertical, [NativeTypeName("BOOL")] int isSimulationAllowed, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("INT32 *")] int* baselineCoordinate, [NativeTypeName("BOOL *")] int* exists)
        {
            return lpVtbl->GetBaseline((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, exists);
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeVerticalGlyphOrientation([NativeTypeName("IDWriteTextAnalysisSource1 *")] IDWriteTextAnalysisSource1* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink1 *")] IDWriteTextAnalysisSink1* analysisSink)
        {
            return lpVtbl->AnalyzeVerticalGlyphOrientation((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphOrientationTransform(DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("DWRITE_MATRIX *")] DWRITE_MATRIX* transform)
        {
            return lpVtbl->GetGlyphOrientationTransform((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), glyphOrientationAngle, isSideways, transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetScriptProperties(DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("DWRITE_SCRIPT_PROPERTIES *")] DWRITE_SCRIPT_PROPERTIES* scriptProperties)
        {
            return lpVtbl->GetScriptProperties((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), scriptAnalysis, scriptProperties);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTextComplexity([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("BOOL *")] int* isTextSimple, [NativeTypeName("UINT32 *")] uint* textLengthRead, [NativeTypeName("UINT16 *")] ushort* glyphIndices)
        {
            return lpVtbl->GetTextComplexity((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), textString, textLength, fontFace, isTextSimple, textLengthRead, glyphIndices);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetJustificationOpportunities([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, [NativeTypeName("DWRITE_JUSTIFICATION_OPPORTUNITY *")] DWRITE_JUSTIFICATION_OPPORTUNITY* justificationOpportunities)
        {
            return lpVtbl->GetJustificationOpportunities((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), fontFace, fontEmSize, scriptAnalysis, textLength, glyphCount, textString, clusterMap, glyphProperties, justificationOpportunities);
        }

        [return: NativeTypeName("HRESULT")]
        public int JustifyGlyphAdvances([NativeTypeName("FLOAT")] float lineWidth, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const DWRITE_JUSTIFICATION_OPPORTUNITY *")] DWRITE_JUSTIFICATION_OPPORTUNITY* justificationOpportunities, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("FLOAT *")] float* justifiedGlyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* justifiedGlyphOffsets)
        {
            return lpVtbl->JustifyGlyphAdvances((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), lineWidth, glyphCount, justificationOpportunities, glyphAdvances, glyphOffsets, justifiedGlyphAdvances, justifiedGlyphOffsets);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetJustifiedGlyphs([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("UINT32")] uint maxGlyphCount, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const FLOAT *")] float* justifiedGlyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* justifiedGlyphOffsets, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, [NativeTypeName("UINT32 *")] uint* actualGlyphCount, [NativeTypeName("UINT16 *")] ushort* modifiedClusterMap, [NativeTypeName("UINT16 *")] ushort* modifiedGlyphIndices, [NativeTypeName("FLOAT *")] float* modifiedGlyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* modifiedGlyphOffsets)
        {
            return lpVtbl->GetJustifiedGlyphs((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), fontFace, fontEmSize, scriptAnalysis, textLength, glyphCount, maxGlyphCount, clusterMap, glyphIndices, glyphAdvances, justifiedGlyphAdvances, justifiedGlyphOffsets, glyphProperties, actualGlyphCount, modifiedClusterMap, modifiedGlyphIndices, modifiedGlyphAdvances, modifiedGlyphOffsets);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphOrientationTransform(DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, [NativeTypeName("DWRITE_MATRIX *")] DWRITE_MATRIX* transform)
        {
            return lpVtbl->GetGlyphOrientationTransform1((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), glyphOrientationAngle, isSideways, originX, originY, transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypographicFeatures([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint maxTagCount, [NativeTypeName("UINT32 *")] uint* actualTagCount, [NativeTypeName("DWRITE_FONT_FEATURE_TAG *")] DWRITE_FONT_FEATURE_TAG* tags)
        {
            return lpVtbl->GetTypographicFeatures((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), fontFace, scriptAnalysis, localeName, maxTagCount, actualTagCount, tags);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckTypographicFeature([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, DWRITE_FONT_FEATURE_TAG featureTag, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT8 *")] byte* featureApplies)
        {
            return lpVtbl->CheckTypographicFeature((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), fontFace, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureApplies);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, uint> Release;

            [NativeTypeName("HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteTextAnalysisSink *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int> AnalyzeScript;

            [NativeTypeName("HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteTextAnalysisSink *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int> AnalyzeBidi;

            [NativeTypeName("HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteTextAnalysisSink *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int> AnalyzeNumberSubstitution;

            [NativeTypeName("HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteTextAnalysisSink *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int> AnalyzeLineBreakpoints;

            [NativeTypeName("HRESULT (const WCHAR *, UINT32, IDWriteFontFace *, BOOL, BOOL, const DWRITE_SCRIPT_ANALYSIS *, const WCHAR *, IDWriteNumberSubstitution *, const DWRITE_TYPOGRAPHIC_FEATURES **, const UINT32 *, UINT32, UINT32, UINT16 *, DWRITE_SHAPING_TEXT_PROPERTIES *, UINT16 *, DWRITE_SHAPING_GLYPH_PROPERTIES *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, ushort*, uint, IDWriteFontFace*, int, int, DWRITE_SCRIPT_ANALYSIS*, ushort*, IDWriteNumberSubstitution*, DWRITE_TYPOGRAPHIC_FEATURES**, uint*, uint, uint, ushort*, DWRITE_SHAPING_TEXT_PROPERTIES*, ushort*, DWRITE_SHAPING_GLYPH_PROPERTIES*, uint*, int> GetGlyphs;

            [NativeTypeName("HRESULT (const WCHAR *, const UINT16 *, DWRITE_SHAPING_TEXT_PROPERTIES *, UINT32, const UINT16 *, const DWRITE_SHAPING_GLYPH_PROPERTIES *, UINT32, IDWriteFontFace *, FLOAT, BOOL, BOOL, const DWRITE_SCRIPT_ANALYSIS *, const WCHAR *, const DWRITE_TYPOGRAPHIC_FEATURES **, const UINT32 *, UINT32, FLOAT *, DWRITE_GLYPH_OFFSET *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, ushort*, ushort*, DWRITE_SHAPING_TEXT_PROPERTIES*, uint, ushort*, DWRITE_SHAPING_GLYPH_PROPERTIES*, uint, IDWriteFontFace*, float, int, int, DWRITE_SCRIPT_ANALYSIS*, ushort*, DWRITE_TYPOGRAPHIC_FEATURES**, uint*, uint, float*, DWRITE_GLYPH_OFFSET*, int> GetGlyphPlacements;

            [NativeTypeName("HRESULT (const WCHAR *, const UINT16 *, DWRITE_SHAPING_TEXT_PROPERTIES *, UINT32, const UINT16 *, const DWRITE_SHAPING_GLYPH_PROPERTIES *, UINT32, IDWriteFontFace *, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, BOOL, BOOL, const DWRITE_SCRIPT_ANALYSIS *, const WCHAR *, const DWRITE_TYPOGRAPHIC_FEATURES **, const UINT32 *, UINT32, FLOAT *, DWRITE_GLYPH_OFFSET *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, ushort*, ushort*, DWRITE_SHAPING_TEXT_PROPERTIES*, uint, ushort*, DWRITE_SHAPING_GLYPH_PROPERTIES*, uint, IDWriteFontFace*, float, float, DWRITE_MATRIX*, int, int, int, DWRITE_SCRIPT_ANALYSIS*, ushort*, DWRITE_TYPOGRAPHIC_FEATURES**, uint*, uint, float*, DWRITE_GLYPH_OFFSET*, int> GetGdiCompatibleGlyphPlacements;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, UINT32, UINT32, const UINT16 *, const FLOAT *, const DWRITE_GLYPH_OFFSET *, const DWRITE_SHAPING_GLYPH_PROPERTIES *, FLOAT *, DWRITE_GLYPH_OFFSET *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, float, float, float, uint, uint, ushort*, float*, DWRITE_GLYPH_OFFSET*, DWRITE_SHAPING_GLYPH_PROPERTIES*, float*, DWRITE_GLYPH_OFFSET*, int> ApplyCharacterSpacing;

            [NativeTypeName("HRESULT (IDWriteFontFace *, DWRITE_BASELINE, BOOL, BOOL, DWRITE_SCRIPT_ANALYSIS, const WCHAR *, INT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, IDWriteFontFace*, DWRITE_BASELINE, int, int, DWRITE_SCRIPT_ANALYSIS, ushort*, int*, int*, int> GetBaseline;

            [NativeTypeName("HRESULT (IDWriteTextAnalysisSource1 *, UINT32, UINT32, IDWriteTextAnalysisSink1 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource1*, uint, uint, IDWriteTextAnalysisSink1*, int> AnalyzeVerticalGlyphOrientation;

            [NativeTypeName("HRESULT (DWRITE_GLYPH_ORIENTATION_ANGLE, BOOL, DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, DWRITE_GLYPH_ORIENTATION_ANGLE, int, DWRITE_MATRIX*, int> GetGlyphOrientationTransform;

            [NativeTypeName("HRESULT (DWRITE_SCRIPT_ANALYSIS, DWRITE_SCRIPT_PROPERTIES *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, DWRITE_SCRIPT_ANALYSIS, DWRITE_SCRIPT_PROPERTIES*, int> GetScriptProperties;

            [NativeTypeName("HRESULT (const WCHAR *, UINT32, IDWriteFontFace *, BOOL *, UINT32 *, UINT16 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, ushort*, uint, IDWriteFontFace*, int*, uint*, ushort*, int> GetTextComplexity;

            [NativeTypeName("HRESULT (IDWriteFontFace *, FLOAT, DWRITE_SCRIPT_ANALYSIS, UINT32, UINT32, const WCHAR *, const UINT16 *, const DWRITE_SHAPING_GLYPH_PROPERTIES *, DWRITE_JUSTIFICATION_OPPORTUNITY *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, IDWriteFontFace*, float, DWRITE_SCRIPT_ANALYSIS, uint, uint, ushort*, ushort*, DWRITE_SHAPING_GLYPH_PROPERTIES*, DWRITE_JUSTIFICATION_OPPORTUNITY*, int> GetJustificationOpportunities;

            [NativeTypeName("HRESULT (FLOAT, UINT32, const DWRITE_JUSTIFICATION_OPPORTUNITY *, const FLOAT *, const DWRITE_GLYPH_OFFSET *, FLOAT *, DWRITE_GLYPH_OFFSET *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, float, uint, DWRITE_JUSTIFICATION_OPPORTUNITY*, float*, DWRITE_GLYPH_OFFSET*, float*, DWRITE_GLYPH_OFFSET*, int> JustifyGlyphAdvances;

            [NativeTypeName("HRESULT (IDWriteFontFace *, FLOAT, DWRITE_SCRIPT_ANALYSIS, UINT32, UINT32, UINT32, const UINT16 *, const UINT16 *, const FLOAT *, const FLOAT *, const DWRITE_GLYPH_OFFSET *, const DWRITE_SHAPING_GLYPH_PROPERTIES *, UINT32 *, UINT16 *, UINT16 *, FLOAT *, DWRITE_GLYPH_OFFSET *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, IDWriteFontFace*, float, DWRITE_SCRIPT_ANALYSIS, uint, uint, uint, ushort*, ushort*, float*, float*, DWRITE_GLYPH_OFFSET*, DWRITE_SHAPING_GLYPH_PROPERTIES*, uint*, ushort*, ushort*, float*, DWRITE_GLYPH_OFFSET*, int> GetJustifiedGlyphs;

            [NativeTypeName("HRESULT (DWRITE_GLYPH_ORIENTATION_ANGLE, BOOL, FLOAT, FLOAT, DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, DWRITE_GLYPH_ORIENTATION_ANGLE, int, float, float, DWRITE_MATRIX*, int> GetGlyphOrientationTransform1;

            [NativeTypeName("HRESULT (IDWriteFontFace *, DWRITE_SCRIPT_ANALYSIS, const WCHAR *, UINT32, UINT32 *, DWRITE_FONT_FEATURE_TAG *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, IDWriteFontFace*, DWRITE_SCRIPT_ANALYSIS, ushort*, uint, uint*, DWRITE_FONT_FEATURE_TAG*, int> GetTypographicFeatures;

            [NativeTypeName("HRESULT (IDWriteFontFace *, DWRITE_SCRIPT_ANALYSIS, const WCHAR *, DWRITE_FONT_FEATURE_TAG, UINT32, const UINT16 *, UINT8 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteTextAnalyzer2*, IDWriteFontFace*, DWRITE_SCRIPT_ANALYSIS, ushort*, DWRITE_FONT_FEATURE_TAG, uint, ushort*, byte*, int> CheckTypographicFeature;
        }
    }
}
