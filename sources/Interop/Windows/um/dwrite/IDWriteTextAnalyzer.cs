// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B7E6163E-7F46-43B4-84B3-E4E6249C365D")]
    public unsafe partial struct IDWriteTextAnalyzer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteTextAnalyzer*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteTextAnalyzer*, uint>)(lpVtbl[1]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteTextAnalyzer*, uint>)(lpVtbl[2]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeScript([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink)
        {
            return ((delegate* stdcall<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)(lpVtbl[3]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeBidi([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink)
        {
            return ((delegate* stdcall<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)(lpVtbl[4]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeNumberSubstitution([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink)
        {
            return ((delegate* stdcall<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)(lpVtbl[5]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeLineBreakpoints([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink)
        {
            return ((delegate* stdcall<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)(lpVtbl[6]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphs([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("IDWriteNumberSubstitution *")] IDWriteNumberSubstitution* numberSubstitution, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("UINT32")] uint maxGlyphCount, [NativeTypeName("UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT16 *")] ushort* glyphIndices, [NativeTypeName("DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32 *")] uint* actualGlyphCount)
        {
            return ((delegate* stdcall<IDWriteTextAnalyzer*, ushort*, uint, IDWriteFontFace*, int, int, DWRITE_SCRIPT_ANALYSIS*, ushort*, IDWriteNumberSubstitution*, DWRITE_TYPOGRAPHIC_FEATURES**, uint*, uint, uint, ushort*, DWRITE_SHAPING_TEXT_PROPERTIES*, ushort*, DWRITE_SHAPING_GLYPH_PROPERTIES*, uint*, int>)(lpVtbl[7]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), textString, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphPlacements([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT *")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets)
        {
            return ((delegate* stdcall<IDWriteTextAnalyzer*, ushort*, ushort*, DWRITE_SHAPING_TEXT_PROPERTIES*, uint, ushort*, DWRITE_SHAPING_GLYPH_PROPERTIES*, uint, IDWriteFontFace*, float, int, int, DWRITE_SCRIPT_ANALYSIS*, ushort*, DWRITE_TYPOGRAPHIC_FEATURES**, uint*, uint, float*, DWRITE_GLYPH_OFFSET*, int>)(lpVtbl[8]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphPlacements([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT *")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets)
        {
            return ((delegate* stdcall<IDWriteTextAnalyzer*, ushort*, ushort*, DWRITE_SHAPING_TEXT_PROPERTIES*, uint, ushort*, DWRITE_SHAPING_GLYPH_PROPERTIES*, uint, IDWriteFontFace*, float, float, DWRITE_MATRIX*, int, int, int, DWRITE_SCRIPT_ANALYSIS*, ushort*, DWRITE_TYPOGRAPHIC_FEATURES**, uint*, uint, float*, DWRITE_GLYPH_OFFSET*, int>)(lpVtbl[9]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }
    }
}
