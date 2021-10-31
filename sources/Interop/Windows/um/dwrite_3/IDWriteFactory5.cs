// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("958DB99A-BE2A-4F09-AF7D-65189803D1D3")]
    [NativeTypeName("struct IDWriteFactory5 : IDWriteFactory4")]
    [NativeInheritance("IDWriteFactory4")]
    public unsafe partial struct IDWriteFactory5
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFactory5*, uint>)(lpVtbl[1]))((IDWriteFactory5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFactory5*, uint>)(lpVtbl[2]))((IDWriteFactory5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetSystemFontCollection(IDWriteFontCollection** fontCollection, [Optional] BOOL checkForUpdates)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteFontCollection**, BOOL, int>)(lpVtbl[3]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, [NativeTypeName("const void *")] void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, IDWriteFontCollection** fontCollection)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)(lpVtbl[4]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), collectionLoader, collectionKey, collectionKeySize, fontCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT RegisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteFontCollectionLoader*, int>)(lpVtbl[5]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontCollectionLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT UnregisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteFontCollectionLoader*, int>)(lpVtbl[6]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontCollectionLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CreateFontFileReference([NativeTypeName("const WCHAR *")] ushort* filePath, [NativeTypeName("const FILETIME *")] FILETIME* lastWriteTime, IDWriteFontFile** fontFile)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, ushort*, FILETIME*, IDWriteFontFile**, int>)(lpVtbl[7]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, fontFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT CreateCustomFontFileReference([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)(lpVtbl[8]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT CreateFontFace(DWRITE_FONT_FACE_TYPE fontFaceType, [NativeTypeName("UINT32")] uint numberOfFiles, [NativeTypeName("IDWriteFontFile *const *")] IDWriteFontFile** fontFiles, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, IDWriteFontFace** fontFace)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, DWRITE_FONT_FACE_TYPE, uint, IDWriteFontFile**, uint, DWRITE_FONT_SIMULATIONS, IDWriteFontFace**, int>)(lpVtbl[9]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT CreateRenderingParams(IDWriteRenderingParams** renderingParams)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteRenderingParams**, int>)(lpVtbl[10]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT CreateMonitorRenderingParams(HMONITOR monitor, IDWriteRenderingParams** renderingParams)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, HMONITOR, IDWriteRenderingParams**, int>)(lpVtbl[11]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), monitor, renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT CreateCustomRenderingParams([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, IDWriteRenderingParams** renderingParams)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams**, int>)(lpVtbl[12]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT RegisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteFontFileLoader*, int>)(lpVtbl[13]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontFileLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT UnregisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteFontFileLoader*, int>)(lpVtbl[14]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontFileLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT CreateTextFormat([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, [NativeTypeName("FLOAT")] float fontSize, [NativeTypeName("const WCHAR *")] ushort* localeName, IDWriteTextFormat** textFormat)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, ushort*, IDWriteFontCollection*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STYLE, DWRITE_FONT_STRETCH, float, ushort*, IDWriteTextFormat**, int>)(lpVtbl[15]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT CreateTypography(IDWriteTypography** typography)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteTypography**, int>)(lpVtbl[16]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), typography);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetGdiInterop(IDWriteGdiInterop** gdiInterop)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteGdiInterop**, int>)(lpVtbl[17]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), gdiInterop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT CreateTextLayout([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float maxWidth, [NativeTypeName("FLOAT")] float maxHeight, IDWriteTextLayout** textLayout)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, ushort*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)(lpVtbl[18]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT CreateGdiCompatibleTextLayout([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float layoutWidth, [NativeTypeName("FLOAT")] float layoutHeight, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL useGdiNatural, IDWriteTextLayout** textLayout)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, ushort*, uint, IDWriteTextFormat*, float, float, float, DWRITE_MATRIX*, BOOL, IDWriteTextLayout**, int>)(lpVtbl[19]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteTextFormat*, IDWriteInlineObject**, int>)(lpVtbl[20]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), textFormat, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT CreateTextAnalyzer(IDWriteTextAnalyzer** textAnalyzer)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteTextAnalyzer**, int>)(lpVtbl[21]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), textAnalyzer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT CreateNumberSubstitution(DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, [NativeTypeName("const WCHAR *")] ushort* localeName, BOOL ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, DWRITE_NUMBER_SUBSTITUTION_METHOD, ushort*, BOOL, IDWriteNumberSubstitution**, int>)(lpVtbl[22]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT CreateGlyphRunAnalysis([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, DWRITE_GLYPH_RUN*, float, DWRITE_MATRIX*, DWRITE_RENDERING_MODE, DWRITE_MEASURING_MODE, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[23]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT GetEudcFontCollection(IDWriteFontCollection** fontCollection, [Optional] BOOL checkForUpdates)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteFontCollection**, BOOL, int>)(lpVtbl[24]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT CreateCustomRenderingParams([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float enhancedContrastGrayscale, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, IDWriteRenderingParams1** renderingParams)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, float, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams1**, int>)(lpVtbl[25]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, enhancedContrastGrayscale, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT GetSystemFontFallback(IDWriteFontFallback** fontFallback)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteFontFallback**, int>)(lpVtbl[26]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT CreateFontFallbackBuilder(IDWriteFontFallbackBuilder** fontFallbackBuilder)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteFontFallbackBuilder**, int>)(lpVtbl[27]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontFallbackBuilder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT TranslateColorGlyphRun([NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* worldToDeviceTransform, [NativeTypeName("UINT32")] uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, float, float, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, DWRITE_MEASURING_MODE, DWRITE_MATRIX*, uint, IDWriteColorGlyphRunEnumerator**, int>)(lpVtbl[28]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT CreateCustomRenderingParams([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float grayscaleEnhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, DWRITE_GRID_FIT_MODE gridFitMode, IDWriteRenderingParams2** renderingParams)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, float, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, DWRITE_GRID_FIT_MODE, IDWriteRenderingParams2**, int>)(lpVtbl[29]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT CreateGlyphRunAnalysis([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, DWRITE_GRID_FIT_MODE gridFitMode, DWRITE_TEXT_ANTIALIAS_MODE antialiasMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, DWRITE_GLYPH_RUN*, DWRITE_MATRIX*, DWRITE_RENDERING_MODE, DWRITE_MEASURING_MODE, DWRITE_GRID_FIT_MODE, DWRITE_TEXT_ANTIALIAS_MODE, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[30]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT CreateGlyphRunAnalysis([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_MEASURING_MODE measuringMode, DWRITE_GRID_FIT_MODE gridFitMode, DWRITE_TEXT_ANTIALIAS_MODE antialiasMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, DWRITE_GLYPH_RUN*, DWRITE_MATRIX*, DWRITE_RENDERING_MODE1, DWRITE_MEASURING_MODE, DWRITE_GRID_FIT_MODE, DWRITE_TEXT_ANTIALIAS_MODE, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[31]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT CreateCustomRenderingParams([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float grayscaleEnhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_GRID_FIT_MODE gridFitMode, IDWriteRenderingParams3** renderingParams)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, float, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE1, DWRITE_GRID_FIT_MODE, IDWriteRenderingParams3**, int>)(lpVtbl[32]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT CreateFontFaceReference([NativeTypeName("const WCHAR *")] ushort* filePath, [NativeTypeName("const FILETIME *")] FILETIME* lastWriteTime, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, IDWriteFontFaceReference** fontFaceReference)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, ushort*, FILETIME*, uint, DWRITE_FONT_SIMULATIONS, IDWriteFontFaceReference**, int>)(lpVtbl[34]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, faceIndex, fontSimulations, fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT CreateFontFaceReference(IDWriteFontFile* fontFile, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, IDWriteFontFaceReference** fontFaceReference)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteFontFile*, uint, DWRITE_FONT_SIMULATIONS, IDWriteFontFaceReference**, int>)(lpVtbl[33]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontFile, faceIndex, fontSimulations, fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT GetSystemFontSet(IDWriteFontSet** fontSet)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteFontSet**, int>)(lpVtbl[35]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT CreateFontSetBuilder(IDWriteFontSetBuilder** fontSetBuilder)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteFontSetBuilder**, int>)(lpVtbl[36]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontSetBuilder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT CreateFontCollectionFromFontSet(IDWriteFontSet* fontSet, IDWriteFontCollection1** fontCollection)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteFontSet*, IDWriteFontCollection1**, int>)(lpVtbl[37]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontSet, fontCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT GetSystemFontCollection(BOOL includeDownloadableFonts, IDWriteFontCollection1** fontCollection, [Optional] BOOL checkForUpdates)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, BOOL, IDWriteFontCollection1**, BOOL, int>)(lpVtbl[38]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), includeDownloadableFonts, fontCollection, checkForUpdates);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT GetFontDownloadQueue(IDWriteFontDownloadQueue** fontDownloadQueue)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteFontDownloadQueue**, int>)(lpVtbl[39]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontDownloadQueue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT TranslateColorGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, DWRITE_GLYPH_IMAGE_FORMATS desiredGlyphImageFormats, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* worldAndDpiTransform, [NativeTypeName("UINT32")] uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator1** colorLayers)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, DWRITE_GLYPH_IMAGE_FORMATS, DWRITE_MEASURING_MODE, DWRITE_MATRIX*, uint, IDWriteColorGlyphRunEnumerator1**, int>)(lpVtbl[40]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, glyphRunDescription, desiredGlyphImageFormats, measuringMode, worldAndDpiTransform, colorPaletteIndex, colorLayers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT ComputeGlyphOrigins([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* worldAndDpiTransform, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* glyphOrigins)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, DWRITE_GLYPH_RUN*, DWRITE_MEASURING_MODE, D2D_POINT_2F, DWRITE_MATRIX*, D2D_POINT_2F*, int>)(lpVtbl[42]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), glyphRun, measuringMode, baselineOrigin, worldAndDpiTransform, glyphOrigins);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT ComputeGlyphOrigins([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* glyphOrigins)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, DWRITE_GLYPH_RUN*, D2D_POINT_2F, D2D_POINT_2F*, int>)(lpVtbl[41]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), glyphRun, baselineOrigin, glyphOrigins);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT CreateFontSetBuilder(IDWriteFontSetBuilder1** fontSetBuilder)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteFontSetBuilder1**, int>)(lpVtbl[43]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontSetBuilder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT CreateInMemoryFontFileLoader(IDWriteInMemoryFontFileLoader** newLoader)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, IDWriteInMemoryFontFileLoader**, int>)(lpVtbl[44]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), newLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT CreateHttpFontFileLoader([NativeTypeName("const wchar_t *")] ushort* referrerUrl, [NativeTypeName("const wchar_t *")] ushort* extraHeaders, IDWriteRemoteFontFileLoader** newLoader)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, ushort*, ushort*, IDWriteRemoteFontFileLoader**, int>)(lpVtbl[45]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), referrerUrl, extraHeaders, newLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public DWRITE_CONTAINER_TYPE AnalyzeContainerType([NativeTypeName("const void *")] void* fileData, [NativeTypeName("UINT32")] uint fileDataSize)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, void*, uint, DWRITE_CONTAINER_TYPE>)(lpVtbl[46]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fileData, fileDataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT UnpackFontFile(DWRITE_CONTAINER_TYPE containerType, [NativeTypeName("const void *")] void* fileData, [NativeTypeName("UINT32")] uint fileDataSize, IDWriteFontFileStream** unpackedFontStream)
        {
            return ((delegate* unmanaged<IDWriteFactory5*, DWRITE_CONTAINER_TYPE, void*, uint, IDWriteFontFileStream**, int>)(lpVtbl[47]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), containerType, fileData, fileDataSize, unpackedFontStream);
        }
    }
}
