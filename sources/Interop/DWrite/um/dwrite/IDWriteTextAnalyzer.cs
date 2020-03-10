// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B7E6163E-7F46-43B4-84B3-E4E6249C365D")]
    public unsafe partial struct IDWriteTextAnalyzer
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteTextAnalyzer* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteTextAnalyzer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteTextAnalyzer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AnalyzeScript(IDWriteTextAnalyzer* pThis, [NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AnalyzeBidi(IDWriteTextAnalyzer* pThis, [NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AnalyzeNumberSubstitution(IDWriteTextAnalyzer* pThis, [NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AnalyzeLineBreakpoints(IDWriteTextAnalyzer* pThis, [NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGlyphs(IDWriteTextAnalyzer* pThis, [NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("IDWriteNumberSubstitution *")] IDWriteNumberSubstitution* numberSubstitution, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("UINT32")] uint maxGlyphCount, [NativeTypeName("UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT16 *")] ushort* glyphIndices, [NativeTypeName("DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32 *")] uint* actualGlyphCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGlyphPlacements(IDWriteTextAnalyzer* pThis, [NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT *")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGdiCompatibleGlyphPlacements(IDWriteTextAnalyzer* pThis, [NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT *")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeScript([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink)
        {
            return Marshal.GetDelegateForFunctionPointer<_AnalyzeScript>(lpVtbl->AnalyzeScript)((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeBidi([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink)
        {
            return Marshal.GetDelegateForFunctionPointer<_AnalyzeBidi>(lpVtbl->AnalyzeBidi)((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeNumberSubstitution([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink)
        {
            return Marshal.GetDelegateForFunctionPointer<_AnalyzeNumberSubstitution>(lpVtbl->AnalyzeNumberSubstitution)((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int AnalyzeLineBreakpoints([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteTextAnalysisSink *")] IDWriteTextAnalysisSink* analysisSink)
        {
            return Marshal.GetDelegateForFunctionPointer<_AnalyzeLineBreakpoints>(lpVtbl->AnalyzeLineBreakpoints)((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphs([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("IDWriteNumberSubstitution *")] IDWriteNumberSubstitution* numberSubstitution, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("UINT32")] uint maxGlyphCount, [NativeTypeName("UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT16 *")] ushort* glyphIndices, [NativeTypeName("DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32 *")] uint* actualGlyphCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGlyphs>(lpVtbl->GetGlyphs)((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), textString, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphPlacements([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT *")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGlyphPlacements>(lpVtbl->GetGlyphPlacements)((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphPlacements([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("DWRITE_SHAPING_TEXT_PROPERTIES *")] DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT *")] float* glyphAdvances, [NativeTypeName("DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGdiCompatibleGlyphPlacements>(lpVtbl->GetGdiCompatibleGlyphPlacements)((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
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
        }
    }
}
