// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B859EE5A-D838-4B5B-A2E8-1ADC7D93DB48")]
    [NativeTypeName("struct IDWriteFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDWriteFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFactory*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFactory*, uint>)(lpVtbl[1]))((IDWriteFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFactory*, uint>)(lpVtbl[2]))((IDWriteFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetSystemFontCollection(IDWriteFontCollection** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = 0)
        {
            return ((delegate* unmanaged<IDWriteFactory*, IDWriteFontCollection**, int, int>)(lpVtbl[3]))((IDWriteFactory*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, [NativeTypeName("const void *")] void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, IDWriteFontCollection** fontCollection)
        {
            return ((delegate* unmanaged<IDWriteFactory*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)(lpVtbl[4]))((IDWriteFactory*)Unsafe.AsPointer(ref this), collectionLoader, collectionKey, collectionKeySize, fontCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            return ((delegate* unmanaged<IDWriteFactory*, IDWriteFontCollectionLoader*, int>)(lpVtbl[5]))((IDWriteFactory*)Unsafe.AsPointer(ref this), fontCollectionLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            return ((delegate* unmanaged<IDWriteFactory*, IDWriteFontCollectionLoader*, int>)(lpVtbl[6]))((IDWriteFactory*)Unsafe.AsPointer(ref this), fontCollectionLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFileReference([NativeTypeName("const WCHAR *")] ushort* filePath, [NativeTypeName("const FILETIME *")] FILETIME* lastWriteTime, IDWriteFontFile** fontFile)
        {
            return ((delegate* unmanaged<IDWriteFactory*, ushort*, FILETIME*, IDWriteFontFile**, int>)(lpVtbl[7]))((IDWriteFactory*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, fontFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCustomFontFileReference([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)
        {
            return ((delegate* unmanaged<IDWriteFactory*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)(lpVtbl[8]))((IDWriteFactory*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace(DWRITE_FONT_FACE_TYPE fontFaceType, [NativeTypeName("UINT32")] uint numberOfFiles, [NativeTypeName("IDWriteFontFile *const *")] IDWriteFontFile** fontFiles, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, IDWriteFontFace** fontFace)
        {
            return ((delegate* unmanaged<IDWriteFactory*, DWRITE_FONT_FACE_TYPE, uint, IDWriteFontFile**, uint, DWRITE_FONT_SIMULATIONS, IDWriteFontFace**, int>)(lpVtbl[9]))((IDWriteFactory*)Unsafe.AsPointer(ref this), fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRenderingParams(IDWriteRenderingParams** renderingParams)
        {
            return ((delegate* unmanaged<IDWriteFactory*, IDWriteRenderingParams**, int>)(lpVtbl[10]))((IDWriteFactory*)Unsafe.AsPointer(ref this), renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMonitorRenderingParams([NativeTypeName("HMONITOR")] IntPtr monitor, IDWriteRenderingParams** renderingParams)
        {
            return ((delegate* unmanaged<IDWriteFactory*, IntPtr, IDWriteRenderingParams**, int>)(lpVtbl[11]))((IDWriteFactory*)Unsafe.AsPointer(ref this), monitor, renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCustomRenderingParams([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, IDWriteRenderingParams** renderingParams)
        {
            return ((delegate* unmanaged<IDWriteFactory*, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams**, int>)(lpVtbl[12]))((IDWriteFactory*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
        {
            return ((delegate* unmanaged<IDWriteFactory*, IDWriteFontFileLoader*, int>)(lpVtbl[13]))((IDWriteFactory*)Unsafe.AsPointer(ref this), fontFileLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
        {
            return ((delegate* unmanaged<IDWriteFactory*, IDWriteFontFileLoader*, int>)(lpVtbl[14]))((IDWriteFactory*)Unsafe.AsPointer(ref this), fontFileLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTextFormat([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, [NativeTypeName("FLOAT")] float fontSize, [NativeTypeName("const WCHAR *")] ushort* localeName, IDWriteTextFormat** textFormat)
        {
            return ((delegate* unmanaged<IDWriteFactory*, ushort*, IDWriteFontCollection*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STYLE, DWRITE_FONT_STRETCH, float, ushort*, IDWriteTextFormat**, int>)(lpVtbl[15]))((IDWriteFactory*)Unsafe.AsPointer(ref this), fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTypography(IDWriteTypography** typography)
        {
            return ((delegate* unmanaged<IDWriteFactory*, IDWriteTypography**, int>)(lpVtbl[16]))((IDWriteFactory*)Unsafe.AsPointer(ref this), typography);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetGdiInterop(IDWriteGdiInterop** gdiInterop)
        {
            return ((delegate* unmanaged<IDWriteFactory*, IDWriteGdiInterop**, int>)(lpVtbl[17]))((IDWriteFactory*)Unsafe.AsPointer(ref this), gdiInterop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTextLayout([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float maxWidth, [NativeTypeName("FLOAT")] float maxHeight, IDWriteTextLayout** textLayout)
        {
            return ((delegate* unmanaged<IDWriteFactory*, ushort*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)(lpVtbl[18]))((IDWriteFactory*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGdiCompatibleTextLayout([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float layoutWidth, [NativeTypeName("FLOAT")] float layoutHeight, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, IDWriteTextLayout** textLayout)
        {
            return ((delegate* unmanaged<IDWriteFactory*, ushort*, uint, IDWriteTextFormat*, float, float, float, DWRITE_MATRIX*, int, IDWriteTextLayout**, int>)(lpVtbl[19]))((IDWriteFactory*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)
        {
            return ((delegate* unmanaged<IDWriteFactory*, IDWriteTextFormat*, IDWriteInlineObject**, int>)(lpVtbl[20]))((IDWriteFactory*)Unsafe.AsPointer(ref this), textFormat, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTextAnalyzer(IDWriteTextAnalyzer** textAnalyzer)
        {
            return ((delegate* unmanaged<IDWriteFactory*, IDWriteTextAnalyzer**, int>)(lpVtbl[21]))((IDWriteFactory*)Unsafe.AsPointer(ref this), textAnalyzer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int CreateNumberSubstitution(DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("BOOL")] int ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
        {
            return ((delegate* unmanaged<IDWriteFactory*, DWRITE_NUMBER_SUBSTITUTION_METHOD, ushort*, int, IDWriteNumberSubstitution**, int>)(lpVtbl[22]))((IDWriteFactory*)Unsafe.AsPointer(ref this), substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGlyphRunAnalysis([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            return ((delegate* unmanaged<IDWriteFactory*, DWRITE_GLYPH_RUN*, float, DWRITE_MATRIX*, DWRITE_RENDERING_MODE, DWRITE_MEASURING_MODE, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[23]))((IDWriteFactory*)Unsafe.AsPointer(ref this), glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
        }
    }
}
