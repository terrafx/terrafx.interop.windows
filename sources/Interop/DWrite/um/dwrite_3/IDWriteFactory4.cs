// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4B0B5BD3-0797-4549-8AC5-FE915CC53856")]
    public unsafe partial struct IDWriteFactory4
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFactory4* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFactory4* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFactory4* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSystemFontCollection(IDWriteFactory4* pThis, [NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = 0);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCustomFontCollection(IDWriteFactory4* pThis, [NativeTypeName("IDWriteFontCollectionLoader *")] IDWriteFontCollectionLoader* collectionLoader, [NativeTypeName("const void *")] void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, [NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterFontCollectionLoader(IDWriteFactory4* pThis, [NativeTypeName("IDWriteFontCollectionLoader *")] IDWriteFontCollectionLoader* fontCollectionLoader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnregisterFontCollectionLoader(IDWriteFactory4* pThis, [NativeTypeName("IDWriteFontCollectionLoader *")] IDWriteFontCollectionLoader* fontCollectionLoader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFileReference(IDWriteFactory4* pThis, [NativeTypeName("const WCHAR *")] ushort* filePath, [NativeTypeName("const FILETIME *")] FILETIME* lastWriteTime, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCustomFontFileReference(IDWriteFactory4* pThis, [NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("IDWriteFontFileLoader *")] IDWriteFontFileLoader* fontFileLoader, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFace(IDWriteFactory4* pThis, DWRITE_FONT_FACE_TYPE fontFaceType, [NativeTypeName("UINT32")] uint numberOfFiles, [NativeTypeName("IDWriteFontFile *const *")] IDWriteFontFile** fontFiles, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, [NativeTypeName("IDWriteFontFace **")] IDWriteFontFace** fontFace);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRenderingParams(IDWriteFactory4* pThis, [NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** renderingParams);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMonitorRenderingParams(IDWriteFactory4* pThis, [NativeTypeName("HMONITOR")] IntPtr monitor, [NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** renderingParams);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCustomRenderingParams(IDWriteFactory4* pThis, [NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, [NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** renderingParams);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterFontFileLoader(IDWriteFactory4* pThis, [NativeTypeName("IDWriteFontFileLoader *")] IDWriteFontFileLoader* fontFileLoader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnregisterFontFileLoader(IDWriteFactory4* pThis, [NativeTypeName("IDWriteFontFileLoader *")] IDWriteFontFileLoader* fontFileLoader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTextFormat(IDWriteFactory4* pThis, [NativeTypeName("const WCHAR *")] ushort* fontFamilyName, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, [NativeTypeName("FLOAT")] float fontSize, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("IDWriteTextFormat **")] IDWriteTextFormat** textFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTypography(IDWriteFactory4* pThis, [NativeTypeName("IDWriteTypography **")] IDWriteTypography** typography);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGdiInterop(IDWriteFactory4* pThis, [NativeTypeName("IDWriteGdiInterop **")] IDWriteGdiInterop** gdiInterop);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTextLayout(IDWriteFactory4* pThis, [NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float maxWidth, [NativeTypeName("FLOAT")] float maxHeight, [NativeTypeName("IDWriteTextLayout **")] IDWriteTextLayout** textLayout);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGdiCompatibleTextLayout(IDWriteFactory4* pThis, [NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float layoutWidth, [NativeTypeName("FLOAT")] float layoutHeight, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("IDWriteTextLayout **")] IDWriteTextLayout** textLayout);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEllipsisTrimmingSign(IDWriteFactory4* pThis, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** trimmingSign);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTextAnalyzer(IDWriteFactory4* pThis, [NativeTypeName("IDWriteTextAnalyzer **")] IDWriteTextAnalyzer** textAnalyzer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateNumberSubstitution(IDWriteFactory4* pThis, DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("BOOL")] int ignoreUserOverride, [NativeTypeName("IDWriteNumberSubstitution **")] IDWriteNumberSubstitution** numberSubstitution);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGlyphRunAnalysis(IDWriteFactory4* pThis, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("IDWriteGlyphRunAnalysis **")] IDWriteGlyphRunAnalysis** glyphRunAnalysis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEudcFontCollection(IDWriteFactory4* pThis, [NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = 0);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCustomRenderingParams1(IDWriteFactory4* pThis, [NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float enhancedContrastGrayscale, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, [NativeTypeName("IDWriteRenderingParams1 **")] IDWriteRenderingParams1** renderingParams);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSystemFontFallback(IDWriteFactory4* pThis, [NativeTypeName("IDWriteFontFallback **")] IDWriteFontFallback** fontFallback);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFallbackBuilder(IDWriteFactory4* pThis, [NativeTypeName("IDWriteFontFallbackBuilder **")] IDWriteFontFallbackBuilder** fontFallbackBuilder);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TranslateColorGlyphRun(IDWriteFactory4* pThis, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* worldToDeviceTransform, [NativeTypeName("UINT32")] uint colorPaletteIndex, [NativeTypeName("IDWriteColorGlyphRunEnumerator **")] IDWriteColorGlyphRunEnumerator** colorLayers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCustomRenderingParams2(IDWriteFactory4* pThis, [NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float grayscaleEnhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, DWRITE_GRID_FIT_MODE gridFitMode, [NativeTypeName("IDWriteRenderingParams2 **")] IDWriteRenderingParams2** renderingParams);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGlyphRunAnalysis1(IDWriteFactory4* pThis, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, DWRITE_GRID_FIT_MODE gridFitMode, DWRITE_TEXT_ANTIALIAS_MODE antialiasMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("IDWriteGlyphRunAnalysis **")] IDWriteGlyphRunAnalysis** glyphRunAnalysis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGlyphRunAnalysis2(IDWriteFactory4* pThis, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_MEASURING_MODE measuringMode, DWRITE_GRID_FIT_MODE gridFitMode, DWRITE_TEXT_ANTIALIAS_MODE antialiasMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("IDWriteGlyphRunAnalysis **")] IDWriteGlyphRunAnalysis** glyphRunAnalysis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCustomRenderingParams3(IDWriteFactory4* pThis, [NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float grayscaleEnhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_GRID_FIT_MODE gridFitMode, [NativeTypeName("IDWriteRenderingParams3 **")] IDWriteRenderingParams3** renderingParams);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFaceReference(IDWriteFactory4* pThis, [NativeTypeName("const WCHAR *")] ushort* filePath, [NativeTypeName("const FILETIME *")] FILETIME* lastWriteTime, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("IDWriteFontFaceReference **")] IDWriteFontFaceReference** fontFaceReference);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFaceReference1(IDWriteFactory4* pThis, [NativeTypeName("IDWriteFontFile *")] IDWriteFontFile* fontFile, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("IDWriteFontFaceReference **")] IDWriteFontFaceReference** fontFaceReference);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSystemFontSet(IDWriteFactory4* pThis, [NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** fontSet);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontSetBuilder(IDWriteFactory4* pThis, [NativeTypeName("IDWriteFontSetBuilder **")] IDWriteFontSetBuilder** fontSetBuilder);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontCollectionFromFontSet(IDWriteFactory4* pThis, [NativeTypeName("IDWriteFontSet *")] IDWriteFontSet* fontSet, [NativeTypeName("IDWriteFontCollection1 **")] IDWriteFontCollection1** fontCollection);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSystemFontCollection1(IDWriteFactory4* pThis, [NativeTypeName("BOOL")] int includeDownloadableFonts, [NativeTypeName("IDWriteFontCollection1 **")] IDWriteFontCollection1** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = 0);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontDownloadQueue(IDWriteFactory4* pThis, [NativeTypeName("IDWriteFontDownloadQueue **")] IDWriteFontDownloadQueue** fontDownloadQueue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TranslateColorGlyphRun1(IDWriteFactory4* pThis, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, DWRITE_GLYPH_IMAGE_FORMATS desiredGlyphImageFormats, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* worldAndDpiTransform, [NativeTypeName("UINT32")] uint colorPaletteIndex, [NativeTypeName("IDWriteColorGlyphRunEnumerator1 **")] IDWriteColorGlyphRunEnumerator1** colorLayers);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ComputeGlyphOrigins(IDWriteFactory4* pThis, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* worldAndDpiTransform, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* glyphOrigins);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ComputeGlyphOrigins1(IDWriteFactory4* pThis, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* glyphOrigins);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteFactory4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteFactory4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteFactory4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSystemFontCollection([NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSystemFontCollection>(lpVtbl->GetSystemFontCollection)((IDWriteFactory4*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCustomFontCollection([NativeTypeName("IDWriteFontCollectionLoader *")] IDWriteFontCollectionLoader* collectionLoader, [NativeTypeName("const void *")] void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, [NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCustomFontCollection>(lpVtbl->CreateCustomFontCollection)((IDWriteFactory4*)Unsafe.AsPointer(ref this), collectionLoader, collectionKey, collectionKeySize, fontCollection);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterFontCollectionLoader([NativeTypeName("IDWriteFontCollectionLoader *")] IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterFontCollectionLoader>(lpVtbl->RegisterFontCollectionLoader)((IDWriteFactory4*)Unsafe.AsPointer(ref this), fontCollectionLoader);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterFontCollectionLoader([NativeTypeName("IDWriteFontCollectionLoader *")] IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            return Marshal.GetDelegateForFunctionPointer<_UnregisterFontCollectionLoader>(lpVtbl->UnregisterFontCollectionLoader)((IDWriteFactory4*)Unsafe.AsPointer(ref this), fontCollectionLoader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFileReference([NativeTypeName("const WCHAR *")] ushort* filePath, [NativeTypeName("const FILETIME *")] FILETIME* lastWriteTime, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontFileReference>(lpVtbl->CreateFontFileReference)((IDWriteFactory4*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, fontFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCustomFontFileReference([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("IDWriteFontFileLoader *")] IDWriteFontFileLoader* fontFileLoader, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCustomFontFileReference>(lpVtbl->CreateCustomFontFileReference)((IDWriteFactory4*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace(DWRITE_FONT_FACE_TYPE fontFaceType, [NativeTypeName("UINT32")] uint numberOfFiles, [NativeTypeName("IDWriteFontFile *const *")] IDWriteFontFile** fontFiles, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, [NativeTypeName("IDWriteFontFace **")] IDWriteFontFace** fontFace)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontFace>(lpVtbl->CreateFontFace)((IDWriteFactory4*)Unsafe.AsPointer(ref this), fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRenderingParams([NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** renderingParams)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRenderingParams>(lpVtbl->CreateRenderingParams)((IDWriteFactory4*)Unsafe.AsPointer(ref this), renderingParams);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMonitorRenderingParams([NativeTypeName("HMONITOR")] IntPtr monitor, [NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** renderingParams)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateMonitorRenderingParams>(lpVtbl->CreateMonitorRenderingParams)((IDWriteFactory4*)Unsafe.AsPointer(ref this), monitor, renderingParams);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCustomRenderingParams([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, [NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** renderingParams)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCustomRenderingParams>(lpVtbl->CreateCustomRenderingParams)((IDWriteFactory4*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterFontFileLoader([NativeTypeName("IDWriteFontFileLoader *")] IDWriteFontFileLoader* fontFileLoader)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterFontFileLoader>(lpVtbl->RegisterFontFileLoader)((IDWriteFactory4*)Unsafe.AsPointer(ref this), fontFileLoader);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterFontFileLoader([NativeTypeName("IDWriteFontFileLoader *")] IDWriteFontFileLoader* fontFileLoader)
        {
            return Marshal.GetDelegateForFunctionPointer<_UnregisterFontFileLoader>(lpVtbl->UnregisterFontFileLoader)((IDWriteFactory4*)Unsafe.AsPointer(ref this), fontFileLoader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTextFormat([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, [NativeTypeName("FLOAT")] float fontSize, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("IDWriteTextFormat **")] IDWriteTextFormat** textFormat)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTextFormat>(lpVtbl->CreateTextFormat)((IDWriteFactory4*)Unsafe.AsPointer(ref this), fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTypography([NativeTypeName("IDWriteTypography **")] IDWriteTypography** typography)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTypography>(lpVtbl->CreateTypography)((IDWriteFactory4*)Unsafe.AsPointer(ref this), typography);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiInterop([NativeTypeName("IDWriteGdiInterop **")] IDWriteGdiInterop** gdiInterop)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGdiInterop>(lpVtbl->GetGdiInterop)((IDWriteFactory4*)Unsafe.AsPointer(ref this), gdiInterop);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTextLayout([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float maxWidth, [NativeTypeName("FLOAT")] float maxHeight, [NativeTypeName("IDWriteTextLayout **")] IDWriteTextLayout** textLayout)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTextLayout>(lpVtbl->CreateTextLayout)((IDWriteFactory4*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGdiCompatibleTextLayout([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float layoutWidth, [NativeTypeName("FLOAT")] float layoutHeight, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("IDWriteTextLayout **")] IDWriteTextLayout** textLayout)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateGdiCompatibleTextLayout>(lpVtbl->CreateGdiCompatibleTextLayout)((IDWriteFactory4*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEllipsisTrimmingSign([NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** trimmingSign)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateEllipsisTrimmingSign>(lpVtbl->CreateEllipsisTrimmingSign)((IDWriteFactory4*)Unsafe.AsPointer(ref this), textFormat, trimmingSign);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTextAnalyzer([NativeTypeName("IDWriteTextAnalyzer **")] IDWriteTextAnalyzer** textAnalyzer)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTextAnalyzer>(lpVtbl->CreateTextAnalyzer)((IDWriteFactory4*)Unsafe.AsPointer(ref this), textAnalyzer);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateNumberSubstitution(DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("BOOL")] int ignoreUserOverride, [NativeTypeName("IDWriteNumberSubstitution **")] IDWriteNumberSubstitution** numberSubstitution)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateNumberSubstitution>(lpVtbl->CreateNumberSubstitution)((IDWriteFactory4*)Unsafe.AsPointer(ref this), substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGlyphRunAnalysis([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("IDWriteGlyphRunAnalysis **")] IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateGlyphRunAnalysis>(lpVtbl->CreateGlyphRunAnalysis)((IDWriteFactory4*)Unsafe.AsPointer(ref this), glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEudcFontCollection([NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEudcFontCollection>(lpVtbl->GetEudcFontCollection)((IDWriteFactory4*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCustomRenderingParams([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float enhancedContrastGrayscale, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, [NativeTypeName("IDWriteRenderingParams1 **")] IDWriteRenderingParams1** renderingParams)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCustomRenderingParams1>(lpVtbl->CreateCustomRenderingParams1)((IDWriteFactory4*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, enhancedContrastGrayscale, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSystemFontFallback([NativeTypeName("IDWriteFontFallback **")] IDWriteFontFallback** fontFallback)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSystemFontFallback>(lpVtbl->GetSystemFontFallback)((IDWriteFactory4*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFallbackBuilder([NativeTypeName("IDWriteFontFallbackBuilder **")] IDWriteFontFallbackBuilder** fontFallbackBuilder)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontFallbackBuilder>(lpVtbl->CreateFontFallbackBuilder)((IDWriteFactory4*)Unsafe.AsPointer(ref this), fontFallbackBuilder);
        }

        [return: NativeTypeName("HRESULT")]
        public int TranslateColorGlyphRun([NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* worldToDeviceTransform, [NativeTypeName("UINT32")] uint colorPaletteIndex, [NativeTypeName("IDWriteColorGlyphRunEnumerator **")] IDWriteColorGlyphRunEnumerator** colorLayers)
        {
            return Marshal.GetDelegateForFunctionPointer<_TranslateColorGlyphRun>(lpVtbl->TranslateColorGlyphRun)((IDWriteFactory4*)Unsafe.AsPointer(ref this), baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCustomRenderingParams([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float grayscaleEnhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, DWRITE_GRID_FIT_MODE gridFitMode, [NativeTypeName("IDWriteRenderingParams2 **")] IDWriteRenderingParams2** renderingParams)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCustomRenderingParams2>(lpVtbl->CreateCustomRenderingParams2)((IDWriteFactory4*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, renderingParams);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGlyphRunAnalysis([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, DWRITE_GRID_FIT_MODE gridFitMode, DWRITE_TEXT_ANTIALIAS_MODE antialiasMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("IDWriteGlyphRunAnalysis **")] IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateGlyphRunAnalysis1>(lpVtbl->CreateGlyphRunAnalysis1)((IDWriteFactory4*)Unsafe.AsPointer(ref this), glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGlyphRunAnalysis([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_MEASURING_MODE measuringMode, DWRITE_GRID_FIT_MODE gridFitMode, DWRITE_TEXT_ANTIALIAS_MODE antialiasMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("IDWriteGlyphRunAnalysis **")] IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateGlyphRunAnalysis2>(lpVtbl->CreateGlyphRunAnalysis2)((IDWriteFactory4*)Unsafe.AsPointer(ref this), glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCustomRenderingParams([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float grayscaleEnhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_GRID_FIT_MODE gridFitMode, [NativeTypeName("IDWriteRenderingParams3 **")] IDWriteRenderingParams3** renderingParams)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCustomRenderingParams3>(lpVtbl->CreateCustomRenderingParams3)((IDWriteFactory4*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, renderingParams);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceReference([NativeTypeName("const WCHAR *")] ushort* filePath, [NativeTypeName("const FILETIME *")] FILETIME* lastWriteTime, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("IDWriteFontFaceReference **")] IDWriteFontFaceReference** fontFaceReference)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontFaceReference>(lpVtbl->CreateFontFaceReference)((IDWriteFactory4*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, faceIndex, fontSimulations, fontFaceReference);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceReference([NativeTypeName("IDWriteFontFile *")] IDWriteFontFile* fontFile, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("IDWriteFontFaceReference **")] IDWriteFontFaceReference** fontFaceReference)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontFaceReference1>(lpVtbl->CreateFontFaceReference1)((IDWriteFactory4*)Unsafe.AsPointer(ref this), fontFile, faceIndex, fontSimulations, fontFaceReference);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSystemFontSet([NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** fontSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSystemFontSet>(lpVtbl->GetSystemFontSet)((IDWriteFactory4*)Unsafe.AsPointer(ref this), fontSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontSetBuilder([NativeTypeName("IDWriteFontSetBuilder **")] IDWriteFontSetBuilder** fontSetBuilder)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontSetBuilder>(lpVtbl->CreateFontSetBuilder)((IDWriteFactory4*)Unsafe.AsPointer(ref this), fontSetBuilder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontCollectionFromFontSet([NativeTypeName("IDWriteFontSet *")] IDWriteFontSet* fontSet, [NativeTypeName("IDWriteFontCollection1 **")] IDWriteFontCollection1** fontCollection)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontCollectionFromFontSet>(lpVtbl->CreateFontCollectionFromFontSet)((IDWriteFactory4*)Unsafe.AsPointer(ref this), fontSet, fontCollection);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSystemFontCollection([NativeTypeName("BOOL")] int includeDownloadableFonts, [NativeTypeName("IDWriteFontCollection1 **")] IDWriteFontCollection1** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSystemFontCollection1>(lpVtbl->GetSystemFontCollection1)((IDWriteFactory4*)Unsafe.AsPointer(ref this), includeDownloadableFonts, fontCollection, checkForUpdates);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontDownloadQueue([NativeTypeName("IDWriteFontDownloadQueue **")] IDWriteFontDownloadQueue** fontDownloadQueue)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontDownloadQueue>(lpVtbl->GetFontDownloadQueue)((IDWriteFactory4*)Unsafe.AsPointer(ref this), fontDownloadQueue);
        }

        [return: NativeTypeName("HRESULT")]
        public int TranslateColorGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, DWRITE_GLYPH_IMAGE_FORMATS desiredGlyphImageFormats, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* worldAndDpiTransform, [NativeTypeName("UINT32")] uint colorPaletteIndex, [NativeTypeName("IDWriteColorGlyphRunEnumerator1 **")] IDWriteColorGlyphRunEnumerator1** colorLayers)
        {
            return Marshal.GetDelegateForFunctionPointer<_TranslateColorGlyphRun1>(lpVtbl->TranslateColorGlyphRun1)((IDWriteFactory4*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, glyphRunDescription, desiredGlyphImageFormats, measuringMode, worldAndDpiTransform, colorPaletteIndex, colorLayers);
        }

        [return: NativeTypeName("HRESULT")]
        public int ComputeGlyphOrigins([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* worldAndDpiTransform, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* glyphOrigins)
        {
            return Marshal.GetDelegateForFunctionPointer<_ComputeGlyphOrigins>(lpVtbl->ComputeGlyphOrigins)((IDWriteFactory4*)Unsafe.AsPointer(ref this), glyphRun, measuringMode, baselineOrigin, worldAndDpiTransform, glyphOrigins);
        }

        [return: NativeTypeName("HRESULT")]
        public int ComputeGlyphOrigins([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* glyphOrigins)
        {
            return Marshal.GetDelegateForFunctionPointer<_ComputeGlyphOrigins1>(lpVtbl->ComputeGlyphOrigins1)((IDWriteFactory4*)Unsafe.AsPointer(ref this), glyphRun, baselineOrigin, glyphOrigins);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IDWriteFontCollection **, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSystemFontCollection;

            [NativeTypeName("HRESULT (IDWriteFontCollectionLoader *, const void *, UINT32, IDWriteFontCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateCustomFontCollection;

            [NativeTypeName("HRESULT (IDWriteFontCollectionLoader *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr RegisterFontCollectionLoader;

            [NativeTypeName("HRESULT (IDWriteFontCollectionLoader *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr UnregisterFontCollectionLoader;

            [NativeTypeName("HRESULT (const WCHAR *, const FILETIME *, IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontFileReference;

            [NativeTypeName("HRESULT (const void *, UINT32, IDWriteFontFileLoader *, IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateCustomFontFileReference;

            [NativeTypeName("HRESULT (DWRITE_FONT_FACE_TYPE, UINT32, IDWriteFontFile *const *, UINT32, DWRITE_FONT_SIMULATIONS, IDWriteFontFace **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontFace;

            [NativeTypeName("HRESULT (IDWriteRenderingParams **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateRenderingParams;

            [NativeTypeName("HRESULT (HMONITOR, IDWriteRenderingParams **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateMonitorRenderingParams;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateCustomRenderingParams;

            [NativeTypeName("HRESULT (IDWriteFontFileLoader *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr RegisterFontFileLoader;

            [NativeTypeName("HRESULT (IDWriteFontFileLoader *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr UnregisterFontFileLoader;

            [NativeTypeName("HRESULT (const WCHAR *, IDWriteFontCollection *, DWRITE_FONT_WEIGHT, DWRITE_FONT_STYLE, DWRITE_FONT_STRETCH, FLOAT, const WCHAR *, IDWriteTextFormat **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTextFormat;

            [NativeTypeName("HRESULT (IDWriteTypography **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTypography;

            [NativeTypeName("HRESULT (IDWriteGdiInterop **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGdiInterop;

            [NativeTypeName("HRESULT (const WCHAR *, UINT32, IDWriteTextFormat *, FLOAT, FLOAT, IDWriteTextLayout **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTextLayout;

            [NativeTypeName("HRESULT (const WCHAR *, UINT32, IDWriteTextFormat *, FLOAT, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, IDWriteTextLayout **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateGdiCompatibleTextLayout;

            [NativeTypeName("HRESULT (IDWriteTextFormat *, IDWriteInlineObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateEllipsisTrimmingSign;

            [NativeTypeName("HRESULT (IDWriteTextAnalyzer **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTextAnalyzer;

            [NativeTypeName("HRESULT (DWRITE_NUMBER_SUBSTITUTION_METHOD, const WCHAR *, BOOL, IDWriteNumberSubstitution **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateNumberSubstitution;

            [NativeTypeName("HRESULT (const DWRITE_GLYPH_RUN *, FLOAT, const DWRITE_MATRIX *, DWRITE_RENDERING_MODE, DWRITE_MEASURING_MODE, FLOAT, FLOAT, IDWriteGlyphRunAnalysis **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateGlyphRunAnalysis;

            [NativeTypeName("HRESULT (IDWriteFontCollection **, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetEudcFontCollection;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, FLOAT, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateCustomRenderingParams1;

            [NativeTypeName("HRESULT (IDWriteFontFallback **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSystemFontFallback;

            [NativeTypeName("HRESULT (IDWriteFontFallbackBuilder **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontFallbackBuilder;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_GLYPH_RUN *, const DWRITE_GLYPH_RUN_DESCRIPTION *, DWRITE_MEASURING_MODE, const DWRITE_MATRIX *, UINT32, IDWriteColorGlyphRunEnumerator **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr TranslateColorGlyphRun;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, FLOAT, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, DWRITE_GRID_FIT_MODE, IDWriteRenderingParams2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateCustomRenderingParams2;

            [NativeTypeName("HRESULT (const DWRITE_GLYPH_RUN *, const DWRITE_MATRIX *, DWRITE_RENDERING_MODE, DWRITE_MEASURING_MODE, DWRITE_GRID_FIT_MODE, DWRITE_TEXT_ANTIALIAS_MODE, FLOAT, FLOAT, IDWriteGlyphRunAnalysis **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateGlyphRunAnalysis1;

            [NativeTypeName("HRESULT (const DWRITE_GLYPH_RUN *, const DWRITE_MATRIX *, DWRITE_RENDERING_MODE1, DWRITE_MEASURING_MODE, DWRITE_GRID_FIT_MODE, DWRITE_TEXT_ANTIALIAS_MODE, FLOAT, FLOAT, IDWriteGlyphRunAnalysis **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateGlyphRunAnalysis2;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, FLOAT, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE1, DWRITE_GRID_FIT_MODE, IDWriteRenderingParams3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateCustomRenderingParams3;

            [NativeTypeName("HRESULT (const WCHAR *, const FILETIME *, UINT32, DWRITE_FONT_SIMULATIONS, IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontFaceReference;

            [NativeTypeName("HRESULT (IDWriteFontFile *, UINT32, DWRITE_FONT_SIMULATIONS, IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontFaceReference1;

            [NativeTypeName("HRESULT (IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSystemFontSet;

            [NativeTypeName("HRESULT (IDWriteFontSetBuilder **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontSetBuilder;

            [NativeTypeName("HRESULT (IDWriteFontSet *, IDWriteFontCollection1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontCollectionFromFontSet;

            [NativeTypeName("HRESULT (BOOL, IDWriteFontCollection1 **, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSystemFontCollection1;

            [NativeTypeName("HRESULT (IDWriteFontDownloadQueue **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontDownloadQueue;

            [NativeTypeName("HRESULT (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, const DWRITE_GLYPH_RUN_DESCRIPTION *, DWRITE_GLYPH_IMAGE_FORMATS, DWRITE_MEASURING_MODE, const DWRITE_MATRIX *, UINT32, IDWriteColorGlyphRunEnumerator1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr TranslateColorGlyphRun1;

            [NativeTypeName("HRESULT (const DWRITE_GLYPH_RUN *, DWRITE_MEASURING_MODE, D2D1_POINT_2F, const DWRITE_MATRIX *, D2D1_POINT_2F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ComputeGlyphOrigins;

            [NativeTypeName("HRESULT (const DWRITE_GLYPH_RUN *, D2D1_POINT_2F, D2D1_POINT_2F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ComputeGlyphOrigins1;
        }
    }
}
