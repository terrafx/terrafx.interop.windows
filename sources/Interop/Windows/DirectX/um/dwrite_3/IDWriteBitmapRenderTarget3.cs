// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDWriteBitmapRenderTarget3.xml' path='doc/member[@name="IDWriteBitmapRenderTarget3"]/*' />
[Guid("AEEC37DB-C337-40F1-8E2A-9A41B167B238")]
[NativeTypeName("struct IDWriteBitmapRenderTarget3 : IDWriteBitmapRenderTarget2")]
[NativeInheritance("IDWriteBitmapRenderTarget2")]
public unsafe partial struct IDWriteBitmapRenderTarget3 : IDWriteBitmapRenderTarget3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteBitmapRenderTarget3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteBitmapRenderTarget3*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteBitmapRenderTarget3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteBitmapRenderTarget3*, uint>)(lpVtbl[1]))((IDWriteBitmapRenderTarget3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteBitmapRenderTarget3*, uint>)(lpVtbl[2]))((IDWriteBitmapRenderTarget3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteBitmapRenderTarget.DrawGlyphRun" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DrawGlyphRun(float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, IDWriteRenderingParams* renderingParams, COLORREF textColor, RECT* blackBoxRect = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteBitmapRenderTarget3*, float, float, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, IDWriteRenderingParams*, COLORREF, RECT*, int>)(lpVtbl[3]))((IDWriteBitmapRenderTarget3*)Unsafe.AsPointer(ref this), baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParams, textColor, blackBoxRect);
    }

    /// <inheritdoc cref="IDWriteBitmapRenderTarget.GetMemoryDC" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HDC GetMemoryDC()
    {
        return ((HDC)(((delegate* unmanaged[MemberFunction]<IDWriteBitmapRenderTarget3*, void*>)(lpVtbl[4]))((IDWriteBitmapRenderTarget3*)Unsafe.AsPointer(ref this))));
    }

    /// <inheritdoc cref="IDWriteBitmapRenderTarget.GetPixelsPerDip" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public float GetPixelsPerDip()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteBitmapRenderTarget3*, float>)(lpVtbl[5]))((IDWriteBitmapRenderTarget3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteBitmapRenderTarget.SetPixelsPerDip" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPixelsPerDip(float pixelsPerDip)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteBitmapRenderTarget3*, float, int>)(lpVtbl[6]))((IDWriteBitmapRenderTarget3*)Unsafe.AsPointer(ref this), pixelsPerDip);
    }

    /// <inheritdoc cref="IDWriteBitmapRenderTarget.GetCurrentTransform" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCurrentTransform(DWRITE_MATRIX* transform)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteBitmapRenderTarget3*, DWRITE_MATRIX*, int>)(lpVtbl[7]))((IDWriteBitmapRenderTarget3*)Unsafe.AsPointer(ref this), transform);
    }

    /// <inheritdoc cref="IDWriteBitmapRenderTarget.SetCurrentTransform" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetCurrentTransform([NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteBitmapRenderTarget3*, DWRITE_MATRIX*, int>)(lpVtbl[8]))((IDWriteBitmapRenderTarget3*)Unsafe.AsPointer(ref this), transform);
    }

    /// <inheritdoc cref="IDWriteBitmapRenderTarget.GetSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSize(SIZE* size)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteBitmapRenderTarget3*, SIZE*, int>)(lpVtbl[9]))((IDWriteBitmapRenderTarget3*)Unsafe.AsPointer(ref this), size);
    }

    /// <inheritdoc cref="IDWriteBitmapRenderTarget.Resize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Resize([NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteBitmapRenderTarget3*, uint, uint, int>)(lpVtbl[10]))((IDWriteBitmapRenderTarget3*)Unsafe.AsPointer(ref this), width, height);
    }

    /// <inheritdoc cref="IDWriteBitmapRenderTarget1.GetTextAntialiasMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public DWRITE_TEXT_ANTIALIAS_MODE GetTextAntialiasMode()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteBitmapRenderTarget3*, DWRITE_TEXT_ANTIALIAS_MODE>)(lpVtbl[11]))((IDWriteBitmapRenderTarget3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteBitmapRenderTarget1.SetTextAntialiasMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetTextAntialiasMode(DWRITE_TEXT_ANTIALIAS_MODE antialiasMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteBitmapRenderTarget3*, DWRITE_TEXT_ANTIALIAS_MODE, int>)(lpVtbl[12]))((IDWriteBitmapRenderTarget3*)Unsafe.AsPointer(ref this), antialiasMode);
    }

    /// <inheritdoc cref="IDWriteBitmapRenderTarget2.GetBitmapData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetBitmapData(DWRITE_BITMAP_DATA_BGRA32* bitmapData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteBitmapRenderTarget3*, DWRITE_BITMAP_DATA_BGRA32*, int>)(lpVtbl[13]))((IDWriteBitmapRenderTarget3*)Unsafe.AsPointer(ref this), bitmapData);
    }

    /// <include file='IDWriteBitmapRenderTarget3.xml' path='doc/member[@name="IDWriteBitmapRenderTarget3.GetPaintFeatureLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public DWRITE_PAINT_FEATURE_LEVEL GetPaintFeatureLevel()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteBitmapRenderTarget3*, DWRITE_PAINT_FEATURE_LEVEL>)(lpVtbl[14]))((IDWriteBitmapRenderTarget3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteBitmapRenderTarget3.xml' path='doc/member[@name="IDWriteBitmapRenderTarget3.DrawPaintGlyphRun"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT DrawPaintGlyphRun(float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, COLORREF textColor, [NativeTypeName("UINT32")] uint colorPaletteIndex = 0, RECT* blackBoxRect = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteBitmapRenderTarget3*, float, float, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_IMAGE_FORMATS, COLORREF, uint, RECT*, int>)(lpVtbl[15]))((IDWriteBitmapRenderTarget3*)Unsafe.AsPointer(ref this), baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphImageFormat, textColor, colorPaletteIndex, blackBoxRect);
    }

    /// <include file='IDWriteBitmapRenderTarget3.xml' path='doc/member[@name="IDWriteBitmapRenderTarget3.DrawGlyphRunWithColorSupport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT DrawGlyphRunWithColorSupport(float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, IDWriteRenderingParams* renderingParams, COLORREF textColor, [NativeTypeName("UINT32")] uint colorPaletteIndex = 0, RECT* blackBoxRect = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteBitmapRenderTarget3*, float, float, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, IDWriteRenderingParams*, COLORREF, uint, RECT*, int>)(lpVtbl[16]))((IDWriteBitmapRenderTarget3*)Unsafe.AsPointer(ref this), baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParams, textColor, colorPaletteIndex, blackBoxRect);
    }

    public interface Interface : IDWriteBitmapRenderTarget2.Interface
    {
        [VtblIndex(14)]
        DWRITE_PAINT_FEATURE_LEVEL GetPaintFeatureLevel();

        [VtblIndex(15)]
        HRESULT DrawPaintGlyphRun(float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, COLORREF textColor, [NativeTypeName("UINT32")] uint colorPaletteIndex = 0, RECT* blackBoxRect = null);

        [VtblIndex(16)]
        HRESULT DrawGlyphRunWithColorSupport(float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, IDWriteRenderingParams* renderingParams, COLORREF textColor, [NativeTypeName("UINT32")] uint colorPaletteIndex = 0, RECT* blackBoxRect = null);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (FLOAT, FLOAT, DWRITE_MEASURING_MODE, const DWRITE_GLYPH_RUN *, IDWriteRenderingParams *, COLORREF, RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, float, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, IDWriteRenderingParams*, COLORREF, RECT*, int> DrawGlyphRun;

        [NativeTypeName("HDC () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*> GetMemoryDC;

        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float> GetPixelsPerDip;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> SetPixelsPerDip;

        [NativeTypeName("HRESULT (DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_MATRIX*, int> GetCurrentTransform;

        [NativeTypeName("HRESULT (const DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_MATRIX*, int> SetCurrentTransform;

        [NativeTypeName("HRESULT (SIZE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SIZE*, int> GetSize;

        [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, int> Resize;

        [NativeTypeName("DWRITE_TEXT_ANTIALIAS_MODE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_TEXT_ANTIALIAS_MODE> GetTextAntialiasMode;

        [NativeTypeName("HRESULT (DWRITE_TEXT_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_TEXT_ANTIALIAS_MODE, int> SetTextAntialiasMode;

        [NativeTypeName("HRESULT (DWRITE_BITMAP_DATA_BGRA32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_BITMAP_DATA_BGRA32*, int> GetBitmapData;

        [NativeTypeName("DWRITE_PAINT_FEATURE_LEVEL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_PAINT_FEATURE_LEVEL> GetPaintFeatureLevel;

        [NativeTypeName("HRESULT (FLOAT, FLOAT, DWRITE_MEASURING_MODE, const DWRITE_GLYPH_RUN *, DWRITE_GLYPH_IMAGE_FORMATS, COLORREF, UINT32, RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, float, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_IMAGE_FORMATS, COLORREF, uint, RECT*, int> DrawPaintGlyphRun;

        [NativeTypeName("HRESULT (FLOAT, FLOAT, DWRITE_MEASURING_MODE, const DWRITE_GLYPH_RUN *, IDWriteRenderingParams *, COLORREF, UINT32, RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, float, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, IDWriteRenderingParams*, COLORREF, uint, RECT*, int> DrawGlyphRunWithColorSupport;
    }
}
