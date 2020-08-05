// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5F49804D-7024-4D43-BFA9-D25984F53849")]
    [NativeTypeName("struct IDWriteFontFace : IUnknown")]
    public unsafe partial struct IDWriteFontFace
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteFontFace*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteFontFace*, uint>)(lpVtbl[1]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteFontFace*, uint>)(lpVtbl[2]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
        }

        public new DWRITE_FONT_FACE_TYPE GetType()
        {
            return ((delegate* stdcall<IDWriteFontFace*, DWRITE_FONT_FACE_TYPE>)(lpVtbl[3]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFiles([NativeTypeName("UINT32 *")] uint* numberOfFiles, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFiles)
        {
            return ((delegate* stdcall<IDWriteFontFace*, uint*, IDWriteFontFile**, int>)(lpVtbl[4]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), numberOfFiles, fontFiles);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetIndex()
        {
            return ((delegate* stdcall<IDWriteFontFace*, uint>)(lpVtbl[5]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            return ((delegate* stdcall<IDWriteFontFace*, DWRITE_FONT_SIMULATIONS>)(lpVtbl[6]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsSymbolFont()
        {
            return ((delegate* stdcall<IDWriteFontFace*, int>)(lpVtbl[7]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
        }

        public void GetMetrics([NativeTypeName("DWRITE_FONT_METRICS *")] DWRITE_FONT_METRICS* fontFaceMetrics)
        {
            ((delegate* stdcall<IDWriteFontFace*, DWRITE_FONT_METRICS*, void>)(lpVtbl[8]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), fontFaceMetrics);
        }

        [return: NativeTypeName("UINT16")]
        public ushort GetGlyphCount()
        {
            return ((delegate* stdcall<IDWriteFontFace*, ushort>)(lpVtbl[9]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesignGlyphMetrics([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("DWRITE_GLYPH_METRICS *")] DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = 0)
        {
            return ((delegate* stdcall<IDWriteFontFace*, ushort*, uint, DWRITE_GLYPH_METRICS*, int, int>)(lpVtbl[10]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, glyphMetrics, isSideways);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphIndices([NativeTypeName("const UINT32 *")] uint* codePoints, [NativeTypeName("UINT32")] uint codePointCount, [NativeTypeName("UINT16 *")] ushort* glyphIndices)
        {
            return ((delegate* stdcall<IDWriteFontFace*, uint*, uint, ushort*, int>)(lpVtbl[11]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), codePoints, codePointCount, glyphIndices);
        }

        [return: NativeTypeName("HRESULT")]
        public int TryGetFontTable([NativeTypeName("UINT32")] uint openTypeTableTag, [NativeTypeName("const void **")] void** tableData, [NativeTypeName("UINT32 *")] uint* tableSize, [NativeTypeName("void **")] void** tableContext, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* stdcall<IDWriteFontFace*, uint, void**, uint*, void**, int*, int>)(lpVtbl[12]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), openTypeTableTag, tableData, tableSize, tableContext, exists);
        }

        public void ReleaseFontTable([NativeTypeName("void *")] void* tableContext)
        {
            ((delegate* stdcall<IDWriteFontFace*, void*, void>)(lpVtbl[13]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), tableContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphRunOutline([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("IDWriteGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return ((delegate* stdcall<IDWriteFontFace*, float, ushort*, float*, DWRITE_GLYPH_OFFSET*, uint, int, int, ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[14]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* renderingParams, [NativeTypeName("DWRITE_RENDERING_MODE *")] DWRITE_RENDERING_MODE* renderingMode)
        {
            return ((delegate* stdcall<IDWriteFontFace*, float, float, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, int>)(lpVtbl[15]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("DWRITE_FONT_METRICS *")] DWRITE_FONT_METRICS* fontFaceMetrics)
        {
            return ((delegate* stdcall<IDWriteFontFace*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS*, int>)(lpVtbl[16]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontFaceMetrics);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("DWRITE_GLYPH_METRICS *")] DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = 0)
        {
            return ((delegate* stdcall<IDWriteFontFace*, float, float, DWRITE_MATRIX*, int, ushort*, uint, DWRITE_GLYPH_METRICS*, int, int>)(lpVtbl[17]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
        }
    }
}
