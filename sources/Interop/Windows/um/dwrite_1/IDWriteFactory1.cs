// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30572F99-DAC6-41DB-A16E-0486307E606A")]
    [NativeTypeName("struct IDWriteFactory1 : IDWriteFactory")]
    public unsafe partial struct IDWriteFactory1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFactory1*, uint>)(lpVtbl[1]))((IDWriteFactory1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFactory1*, uint>)(lpVtbl[2]))((IDWriteFactory1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSystemFontCollection(IDWriteFontCollection** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = 0)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, IDWriteFontCollection**, int, int>)(lpVtbl[3]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, [NativeTypeName("const void *")] void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, IDWriteFontCollection** fontCollection)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)(lpVtbl[4]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), collectionLoader, collectionKey, collectionKeySize, fontCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, IDWriteFontCollectionLoader*, int>)(lpVtbl[5]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontCollectionLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, IDWriteFontCollectionLoader*, int>)(lpVtbl[6]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontCollectionLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFileReference([NativeTypeName("const WCHAR *")] ushort* filePath, [NativeTypeName("const FILETIME *")] FILETIME* lastWriteTime, IDWriteFontFile** fontFile)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, ushort*, FILETIME*, IDWriteFontFile**, int>)(lpVtbl[7]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, fontFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCustomFontFileReference([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)(lpVtbl[8]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace(DWRITE_FONT_FACE_TYPE fontFaceType, [NativeTypeName("UINT32")] uint numberOfFiles, [NativeTypeName("IDWriteFontFile *const *")] IDWriteFontFile** fontFiles, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, IDWriteFontFace** fontFace)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, DWRITE_FONT_FACE_TYPE, uint, IDWriteFontFile**, uint, DWRITE_FONT_SIMULATIONS, IDWriteFontFace**, int>)(lpVtbl[9]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRenderingParams(IDWriteRenderingParams** renderingParams)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, IDWriteRenderingParams**, int>)(lpVtbl[10]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMonitorRenderingParams([NativeTypeName("HMONITOR")] IntPtr monitor, IDWriteRenderingParams** renderingParams)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, IntPtr, IDWriteRenderingParams**, int>)(lpVtbl[11]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), monitor, renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCustomRenderingParams([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, IDWriteRenderingParams** renderingParams)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams**, int>)(lpVtbl[12]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, IDWriteFontFileLoader*, int>)(lpVtbl[13]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontFileLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, IDWriteFontFileLoader*, int>)(lpVtbl[14]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontFileLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTextFormat([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, [NativeTypeName("FLOAT")] float fontSize, [NativeTypeName("const WCHAR *")] ushort* localeName, IDWriteTextFormat** textFormat)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, ushort*, IDWriteFontCollection*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STYLE, DWRITE_FONT_STRETCH, float, ushort*, IDWriteTextFormat**, int>)(lpVtbl[15]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTypography(IDWriteTypography** typography)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, IDWriteTypography**, int>)(lpVtbl[16]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), typography);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGdiInterop(IDWriteGdiInterop** gdiInterop)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, IDWriteGdiInterop**, int>)(lpVtbl[17]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), gdiInterop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTextLayout([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float maxWidth, [NativeTypeName("FLOAT")] float maxHeight, IDWriteTextLayout** textLayout)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, ushort*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)(lpVtbl[18]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGdiCompatibleTextLayout([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float layoutWidth, [NativeTypeName("FLOAT")] float layoutHeight, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, IDWriteTextLayout** textLayout)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, ushort*, uint, IDWriteTextFormat*, float, float, float, DWRITE_MATRIX*, int, IDWriteTextLayout**, int>)(lpVtbl[19]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, IDWriteTextFormat*, IDWriteInlineObject**, int>)(lpVtbl[20]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), textFormat, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTextAnalyzer(IDWriteTextAnalyzer** textAnalyzer)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, IDWriteTextAnalyzer**, int>)(lpVtbl[21]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), textAnalyzer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateNumberSubstitution(DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("BOOL")] int ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, DWRITE_NUMBER_SUBSTITUTION_METHOD, ushort*, int, IDWriteNumberSubstitution**, int>)(lpVtbl[22]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGlyphRunAnalysis([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, DWRITE_GLYPH_RUN*, float, DWRITE_MATRIX*, DWRITE_RENDERING_MODE, DWRITE_MEASURING_MODE, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[23]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEudcFontCollection(IDWriteFontCollection** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = 0)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, IDWriteFontCollection**, int, int>)(lpVtbl[24]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCustomRenderingParams([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float enhancedContrastGrayscale, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, IDWriteRenderingParams1** renderingParams)
        {
            return ((delegate* unmanaged<IDWriteFactory1*, float, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams1**, int>)(lpVtbl[25]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, enhancedContrastGrayscale, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
        }
    }
}
