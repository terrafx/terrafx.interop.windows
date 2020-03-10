// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A71EFDB4-9FDB-4838-AD90-CFC3BE8C3DAF")]
    public unsafe partial struct IDWriteFontFace1
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontFace1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontFace1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontFace1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_FACE_TYPE _GetType(IDWriteFontFace1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFiles(IDWriteFontFace1* pThis, [NativeTypeName("UINT32 *")] uint* numberOfFiles, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFiles);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetIndex(IDWriteFontFace1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_SIMULATIONS _GetSimulations(IDWriteFontFace1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsSymbolFont(IDWriteFontFace1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetMetrics(IDWriteFontFace1* pThis, [NativeTypeName("DWRITE_FONT_METRICS *")] DWRITE_FONT_METRICS* fontFaceMetrics);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT16")]
        public delegate ushort _GetGlyphCount(IDWriteFontFace1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesignGlyphMetrics(IDWriteFontFace1* pThis, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("DWRITE_GLYPH_METRICS *")] DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = 0);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGlyphIndices(IDWriteFontFace1* pThis, [NativeTypeName("const UINT32 *")] uint* codePoints, [NativeTypeName("UINT32")] uint codePointCount, [NativeTypeName("UINT16 *")] ushort* glyphIndices);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TryGetFontTable(IDWriteFontFace1* pThis, [NativeTypeName("UINT32")] uint openTypeTableTag, [NativeTypeName("const void **")] void** tableData, [NativeTypeName("UINT32 *")] uint* tableSize, [NativeTypeName("void **")] void** tableContext, [NativeTypeName("BOOL *")] int* exists);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ReleaseFontTable(IDWriteFontFace1* pThis, [NativeTypeName("void *")] void* tableContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGlyphRunOutline(IDWriteFontFace1* pThis, [NativeTypeName("FLOAT")] float emSize, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("IDWriteGeometrySink *")] IUnknown* geometrySink);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRecommendedRenderingMode(IDWriteFontFace1* pThis, [NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* renderingParams, [NativeTypeName("DWRITE_RENDERING_MODE *")] DWRITE_RENDERING_MODE* renderingMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGdiCompatibleMetrics(IDWriteFontFace1* pThis, [NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("DWRITE_FONT_METRICS *")] DWRITE_FONT_METRICS* fontFaceMetrics);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGdiCompatibleGlyphMetrics(IDWriteFontFace1* pThis, [NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("DWRITE_GLYPH_METRICS *")] DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = 0);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetMetrics1(IDWriteFontFace1* pThis, [NativeTypeName("DWRITE_FONT_METRICS1 *")] DWRITE_FONT_METRICS1* fontMetrics);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGdiCompatibleMetrics1(IDWriteFontFace1* pThis, [NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("DWRITE_FONT_METRICS1 *")] DWRITE_FONT_METRICS1* fontMetrics);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetCaretMetrics(IDWriteFontFace1* pThis, [NativeTypeName("DWRITE_CARET_METRICS *")] DWRITE_CARET_METRICS* caretMetrics);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetUnicodeRanges(IDWriteFontFace1* pThis, [NativeTypeName("UINT32")] uint maxRangeCount, [NativeTypeName("DWRITE_UNICODE_RANGE *")] DWRITE_UNICODE_RANGE* unicodeRanges, [NativeTypeName("UINT32 *")] uint* actualRangeCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsMonospacedFont(IDWriteFontFace1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesignGlyphAdvances(IDWriteFontFace1* pThis, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances, [NativeTypeName("BOOL")] int isSideways = 0);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGdiCompatibleGlyphAdvances(IDWriteFontFace1* pThis, [NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetKerningPairAdjustments(IDWriteFontFace1* pThis, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvanceAdjustments);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _HasKerningPairs(IDWriteFontFace1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRecommendedRenderingMode1(IDWriteFontFace1* pThis, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("DWRITE_RENDERING_MODE *")] DWRITE_RENDERING_MODE* renderingMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVerticalGlyphVariants(IDWriteFontFace1* pThis, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* nominalGlyphIndices, [NativeTypeName("UINT16 *")] ushort* verticalGlyphIndices);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _HasVerticalGlyphVariants(IDWriteFontFace1* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        public new DWRITE_FONT_FACE_TYPE GetType()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetType>(lpVtbl->GetType)((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFiles([NativeTypeName("UINT32 *")] uint* numberOfFiles, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFiles)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFiles>(lpVtbl->GetFiles)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), numberOfFiles, fontFiles);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetIndex()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetIndex>(lpVtbl->GetIndex)((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSimulations>(lpVtbl->GetSimulations)((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsSymbolFont()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsSymbolFont>(lpVtbl->IsSymbolFont)((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        public void GetMetrics([NativeTypeName("DWRITE_FONT_METRICS *")] DWRITE_FONT_METRICS* fontFaceMetrics)
        {
            Marshal.GetDelegateForFunctionPointer<_GetMetrics>(lpVtbl->GetMetrics)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), fontFaceMetrics);
        }

        [return: NativeTypeName("UINT16")]
        public ushort GetGlyphCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGlyphCount>(lpVtbl->GetGlyphCount)((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesignGlyphMetrics([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("DWRITE_GLYPH_METRICS *")] DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesignGlyphMetrics>(lpVtbl->GetDesignGlyphMetrics)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, glyphMetrics, isSideways);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphIndices([NativeTypeName("const UINT32 *")] uint* codePoints, [NativeTypeName("UINT32")] uint codePointCount, [NativeTypeName("UINT16 *")] ushort* glyphIndices)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGlyphIndices>(lpVtbl->GetGlyphIndices)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), codePoints, codePointCount, glyphIndices);
        }

        [return: NativeTypeName("HRESULT")]
        public int TryGetFontTable([NativeTypeName("UINT32")] uint openTypeTableTag, [NativeTypeName("const void **")] void** tableData, [NativeTypeName("UINT32 *")] uint* tableSize, [NativeTypeName("void **")] void** tableContext, [NativeTypeName("BOOL *")] int* exists)
        {
            return Marshal.GetDelegateForFunctionPointer<_TryGetFontTable>(lpVtbl->TryGetFontTable)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), openTypeTableTag, tableData, tableSize, tableContext, exists);
        }

        public void ReleaseFontTable([NativeTypeName("void *")] void* tableContext)
        {
            Marshal.GetDelegateForFunctionPointer<_ReleaseFontTable>(lpVtbl->ReleaseFontTable)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), tableContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphRunOutline([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("IDWriteGeometrySink *")] IUnknown* geometrySink)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGlyphRunOutline>(lpVtbl->GetGlyphRunOutline)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* renderingParams, [NativeTypeName("DWRITE_RENDERING_MODE *")] DWRITE_RENDERING_MODE* renderingMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRecommendedRenderingMode>(lpVtbl->GetRecommendedRenderingMode)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("DWRITE_FONT_METRICS *")] DWRITE_FONT_METRICS* fontFaceMetrics)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGdiCompatibleMetrics>(lpVtbl->GetGdiCompatibleMetrics)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontFaceMetrics);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("DWRITE_GLYPH_METRICS *")] DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGdiCompatibleGlyphMetrics>(lpVtbl->GetGdiCompatibleGlyphMetrics)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
        }

        public void GetMetrics([NativeTypeName("DWRITE_FONT_METRICS1 *")] DWRITE_FONT_METRICS1* fontMetrics)
        {
            Marshal.GetDelegateForFunctionPointer<_GetMetrics1>(lpVtbl->GetMetrics1)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), fontMetrics);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("DWRITE_FONT_METRICS1 *")] DWRITE_FONT_METRICS1* fontMetrics)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGdiCompatibleMetrics1>(lpVtbl->GetGdiCompatibleMetrics1)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontMetrics);
        }

        public void GetCaretMetrics([NativeTypeName("DWRITE_CARET_METRICS *")] DWRITE_CARET_METRICS* caretMetrics)
        {
            Marshal.GetDelegateForFunctionPointer<_GetCaretMetrics>(lpVtbl->GetCaretMetrics)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), caretMetrics);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnicodeRanges([NativeTypeName("UINT32")] uint maxRangeCount, [NativeTypeName("DWRITE_UNICODE_RANGE *")] DWRITE_UNICODE_RANGE* unicodeRanges, [NativeTypeName("UINT32 *")] uint* actualRangeCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetUnicodeRanges>(lpVtbl->GetUnicodeRanges)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), maxRangeCount, unicodeRanges, actualRangeCount);
        }

        [return: NativeTypeName("BOOL")]
        public int IsMonospacedFont()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsMonospacedFont>(lpVtbl->IsMonospacedFont)((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesignGlyphAdvances([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances, [NativeTypeName("BOOL")] int isSideways = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesignGlyphAdvances>(lpVtbl->GetDesignGlyphAdvances)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvances, isSideways);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphAdvances([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGdiCompatibleGlyphAdvances>(lpVtbl->GetGdiCompatibleGlyphAdvances)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetKerningPairAdjustments([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvanceAdjustments)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetKerningPairAdjustments>(lpVtbl->GetKerningPairAdjustments)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvanceAdjustments);
        }

        [return: NativeTypeName("BOOL")]
        public int HasKerningPairs()
        {
            return Marshal.GetDelegateForFunctionPointer<_HasKerningPairs>(lpVtbl->HasKerningPairs)((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("DWRITE_RENDERING_MODE *")] DWRITE_RENDERING_MODE* renderingMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRecommendedRenderingMode1>(lpVtbl->GetRecommendedRenderingMode1)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVerticalGlyphVariants([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* nominalGlyphIndices, [NativeTypeName("UINT16 *")] ushort* verticalGlyphIndices)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVerticalGlyphVariants>(lpVtbl->GetVerticalGlyphVariants)((IDWriteFontFace1*)Unsafe.AsPointer(ref this), glyphCount, nominalGlyphIndices, verticalGlyphIndices);
        }

        [return: NativeTypeName("BOOL")]
        public int HasVerticalGlyphVariants()
        {
            return Marshal.GetDelegateForFunctionPointer<_HasVerticalGlyphVariants>(lpVtbl->HasVerticalGlyphVariants)((IDWriteFontFace1*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("DWRITE_FONT_FACE_TYPE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public new IntPtr GetType;

            [NativeTypeName("HRESULT (UINT32 *, IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFiles;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetIndex;

            [NativeTypeName("DWRITE_FONT_SIMULATIONS () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSimulations;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsSymbolFont;

            [NativeTypeName("void (DWRITE_FONT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMetrics;

            [NativeTypeName("UINT16 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGlyphCount;

            [NativeTypeName("HRESULT (const UINT16 *, UINT32, DWRITE_GLYPH_METRICS *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDesignGlyphMetrics;

            [NativeTypeName("HRESULT (const UINT32 *, UINT32, UINT16 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGlyphIndices;

            [NativeTypeName("HRESULT (UINT32, const void **, UINT32 *, void **, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr TryGetFontTable;

            [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ReleaseFontTable;

            [NativeTypeName("HRESULT (FLOAT, const UINT16 *, const FLOAT *, const DWRITE_GLYPH_OFFSET *, UINT32, BOOL, BOOL, IDWriteGeometrySink *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGlyphRunOutline;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, DWRITE_MEASURING_MODE, IDWriteRenderingParams *, DWRITE_RENDERING_MODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetRecommendedRenderingMode;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, DWRITE_FONT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGdiCompatibleMetrics;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, const UINT16 *, UINT32, DWRITE_GLYPH_METRICS *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGdiCompatibleGlyphMetrics;

            [NativeTypeName("void (DWRITE_FONT_METRICS1 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMetrics1;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, DWRITE_FONT_METRICS1 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGdiCompatibleMetrics1;

            [NativeTypeName("void (DWRITE_CARET_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetCaretMetrics;

            [NativeTypeName("HRESULT (UINT32, DWRITE_UNICODE_RANGE *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetUnicodeRanges;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsMonospacedFont;

            [NativeTypeName("HRESULT (UINT32, const UINT16 *, INT32 *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDesignGlyphAdvances;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, BOOL, UINT32, const UINT16 *, INT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGdiCompatibleGlyphAdvances;

            [NativeTypeName("HRESULT (UINT32, const UINT16 *, INT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetKerningPairAdjustments;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr HasKerningPairs;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, DWRITE_RENDERING_MODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetRecommendedRenderingMode1;

            [NativeTypeName("HRESULT (UINT32, const UINT16 *, UINT16 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetVerticalGlyphVariants;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr HasVerticalGlyphVariants;
        }
    }
}
