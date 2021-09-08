// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A71EFDB4-9FDB-4838-AD90-CFC3BE8C3DAF")]
    [NativeTypeName("struct IDWriteFontFace1 : IDWriteFontFace")]
    [NativeInheritance("IDWriteFontFace")]
    public unsafe partial struct IDWriteFontFace1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, uint>)(lpVtbl[1]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, uint>)(lpVtbl[2]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public new DWRITE_FONT_FACE_TYPE GetType()
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, DWRITE_FONT_FACE_TYPE>)(lpVtbl[3]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetFiles([NativeTypeName("UINT32 *")] uint* numberOfFiles, IDWriteFontFile** fontFiles)
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, uint*, IDWriteFontFile**, int>)(lpVtbl[4]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), numberOfFiles, fontFiles);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("UINT32")]
        public uint GetIndex()
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, uint>)(lpVtbl[5]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, DWRITE_FONT_SIMULATIONS>)(lpVtbl[6]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("BOOL")]
        public int IsSymbolFont()
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, int>)(lpVtbl[7]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void GetMetrics(DWRITE_FONT_METRICS* fontFaceMetrics)
        {
            ((delegate* unmanaged<IDWriteFontFace1*, DWRITE_FONT_METRICS*, void>)(lpVtbl[8]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), fontFaceMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("UINT16")]
        public ushort GetGlyphCount()
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, ushort>)(lpVtbl[9]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesignGlyphMetrics([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = 0)
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, ushort*, uint, DWRITE_GLYPH_METRICS*, int, int>)(lpVtbl[10]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, glyphMetrics, isSideways);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlyphIndices([NativeTypeName("const UINT32 *")] uint* codePoints, [NativeTypeName("UINT32")] uint codePointCount, [NativeTypeName("UINT16 *")] ushort* glyphIndices)
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, uint*, uint, ushort*, int>)(lpVtbl[11]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), codePoints, codePointCount, glyphIndices);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int TryGetFontTable([NativeTypeName("UINT32")] uint openTypeTableTag, [NativeTypeName("const void **")] void** tableData, [NativeTypeName("UINT32 *")] uint* tableSize, void** tableContext, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, uint, void**, uint*, void**, int*, int>)(lpVtbl[12]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), openTypeTableTag, tableData, tableSize, tableContext, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void ReleaseFontTable(void* tableContext)
        {
            ((delegate* unmanaged<IDWriteFontFace1*, void*, void>)(lpVtbl[13]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), tableContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlyphRunOutline([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("IDWriteGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, float, ushort*, float*, DWRITE_GLYPH_OFFSET*, uint, int, int, ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[14]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode)
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, float, float, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, int>)(lpVtbl[15]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_FONT_METRICS* fontFaceMetrics)
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS*, int>)(lpVtbl[16]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontFaceMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = 0)
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, float, float, DWRITE_MATRIX*, int, ushort*, uint, DWRITE_GLYPH_METRICS*, int, int>)(lpVtbl[17]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void GetMetrics(DWRITE_FONT_METRICS1* fontMetrics)
        {
            ((delegate* unmanaged<IDWriteFontFace1*, DWRITE_FONT_METRICS1*, void>)(lpVtbl[18]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), fontMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_FONT_METRICS1* fontMetrics)
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS1*, int>)(lpVtbl[19]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void GetCaretMetrics(DWRITE_CARET_METRICS* caretMetrics)
        {
            ((delegate* unmanaged<IDWriteFontFace1*, DWRITE_CARET_METRICS*, void>)(lpVtbl[20]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), caretMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnicodeRanges([NativeTypeName("UINT32")] uint maxRangeCount, DWRITE_UNICODE_RANGE* unicodeRanges, [NativeTypeName("UINT32 *")] uint* actualRangeCount)
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, uint, DWRITE_UNICODE_RANGE*, uint*, int>)(lpVtbl[21]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), maxRangeCount, unicodeRanges, actualRangeCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("BOOL")]
        public int IsMonospacedFont()
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, int>)(lpVtbl[22]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesignGlyphAdvances([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances, [NativeTypeName("BOOL")] int isSideways = 0)
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, uint, ushort*, int*, int, int>)(lpVtbl[23]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvances, isSideways);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphAdvances([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances)
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, float, float, DWRITE_MATRIX*, int, int, uint, ushort*, int*, int>)(lpVtbl[24]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int GetKerningPairAdjustments([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvanceAdjustments)
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, uint, ushort*, int*, int>)(lpVtbl[25]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvanceAdjustments);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("BOOL")]
        public int HasKerningPairs()
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, int>)(lpVtbl[26]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, DWRITE_RENDERING_MODE* renderingMode)
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, float, float, float, DWRITE_MATRIX*, int, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, DWRITE_RENDERING_MODE*, int>)(lpVtbl[27]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int GetVerticalGlyphVariants([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* nominalGlyphIndices, [NativeTypeName("UINT16 *")] ushort* verticalGlyphIndices)
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, uint, ushort*, ushort*, int>)(lpVtbl[28]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this), glyphCount, nominalGlyphIndices, verticalGlyphIndices);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("BOOL")]
        public int HasVerticalGlyphVariants()
        {
            return ((delegate* unmanaged<IDWriteFontFace1*, int>)(lpVtbl[29]))((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }
    }
}
