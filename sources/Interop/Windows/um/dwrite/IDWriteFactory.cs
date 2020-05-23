// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B859EE5A-D838-4B5B-A2E8-1ADC7D93DB48")]
    public unsafe partial struct IDWriteFactory
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFactory* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFactory* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFactory* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSystemFontCollection(IDWriteFactory* pThis, [NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = 0);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCustomFontCollection(IDWriteFactory* pThis, [NativeTypeName("IDWriteFontCollectionLoader *")] IDWriteFontCollectionLoader* collectionLoader, [NativeTypeName("const void *")] void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, [NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterFontCollectionLoader(IDWriteFactory* pThis, [NativeTypeName("IDWriteFontCollectionLoader *")] IDWriteFontCollectionLoader* fontCollectionLoader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnregisterFontCollectionLoader(IDWriteFactory* pThis, [NativeTypeName("IDWriteFontCollectionLoader *")] IDWriteFontCollectionLoader* fontCollectionLoader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFileReference(IDWriteFactory* pThis, [NativeTypeName("const WCHAR *")] ushort* filePath, [NativeTypeName("const FILETIME *")] FILETIME* lastWriteTime, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCustomFontFileReference(IDWriteFactory* pThis, [NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("IDWriteFontFileLoader *")] IDWriteFontFileLoader* fontFileLoader, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFace(IDWriteFactory* pThis, DWRITE_FONT_FACE_TYPE fontFaceType, [NativeTypeName("UINT32")] uint numberOfFiles, [NativeTypeName("IDWriteFontFile *const *")] IDWriteFontFile** fontFiles, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, [NativeTypeName("IDWriteFontFace **")] IDWriteFontFace** fontFace);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRenderingParams(IDWriteFactory* pThis, [NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** renderingParams);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMonitorRenderingParams(IDWriteFactory* pThis, [NativeTypeName("HMONITOR")] IntPtr monitor, [NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** renderingParams);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCustomRenderingParams(IDWriteFactory* pThis, [NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, [NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** renderingParams);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterFontFileLoader(IDWriteFactory* pThis, [NativeTypeName("IDWriteFontFileLoader *")] IDWriteFontFileLoader* fontFileLoader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnregisterFontFileLoader(IDWriteFactory* pThis, [NativeTypeName("IDWriteFontFileLoader *")] IDWriteFontFileLoader* fontFileLoader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTextFormat(IDWriteFactory* pThis, [NativeTypeName("const WCHAR *")] ushort* fontFamilyName, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, [NativeTypeName("FLOAT")] float fontSize, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("IDWriteTextFormat **")] IDWriteTextFormat** textFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTypography(IDWriteFactory* pThis, [NativeTypeName("IDWriteTypography **")] IDWriteTypography** typography);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGdiInterop(IDWriteFactory* pThis, [NativeTypeName("IDWriteGdiInterop **")] IDWriteGdiInterop** gdiInterop);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTextLayout(IDWriteFactory* pThis, [NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float maxWidth, [NativeTypeName("FLOAT")] float maxHeight, [NativeTypeName("IDWriteTextLayout **")] IDWriteTextLayout** textLayout);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGdiCompatibleTextLayout(IDWriteFactory* pThis, [NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float layoutWidth, [NativeTypeName("FLOAT")] float layoutHeight, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("IDWriteTextLayout **")] IDWriteTextLayout** textLayout);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEllipsisTrimmingSign(IDWriteFactory* pThis, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** trimmingSign);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTextAnalyzer(IDWriteFactory* pThis, [NativeTypeName("IDWriteTextAnalyzer **")] IDWriteTextAnalyzer** textAnalyzer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateNumberSubstitution(IDWriteFactory* pThis, DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("BOOL")] int ignoreUserOverride, [NativeTypeName("IDWriteNumberSubstitution **")] IDWriteNumberSubstitution** numberSubstitution);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGlyphRunAnalysis(IDWriteFactory* pThis, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("IDWriteGlyphRunAnalysis **")] IDWriteGlyphRunAnalysis** glyphRunAnalysis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSystemFontCollection([NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSystemFontCollection>(lpVtbl->GetSystemFontCollection)((IDWriteFactory*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCustomFontCollection([NativeTypeName("IDWriteFontCollectionLoader *")] IDWriteFontCollectionLoader* collectionLoader, [NativeTypeName("const void *")] void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, [NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCustomFontCollection>(lpVtbl->CreateCustomFontCollection)((IDWriteFactory*)Unsafe.AsPointer(ref this), collectionLoader, collectionKey, collectionKeySize, fontCollection);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterFontCollectionLoader([NativeTypeName("IDWriteFontCollectionLoader *")] IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterFontCollectionLoader>(lpVtbl->RegisterFontCollectionLoader)((IDWriteFactory*)Unsafe.AsPointer(ref this), fontCollectionLoader);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterFontCollectionLoader([NativeTypeName("IDWriteFontCollectionLoader *")] IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            return Marshal.GetDelegateForFunctionPointer<_UnregisterFontCollectionLoader>(lpVtbl->UnregisterFontCollectionLoader)((IDWriteFactory*)Unsafe.AsPointer(ref this), fontCollectionLoader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFileReference([NativeTypeName("const WCHAR *")] ushort* filePath, [NativeTypeName("const FILETIME *")] FILETIME* lastWriteTime, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontFileReference>(lpVtbl->CreateFontFileReference)((IDWriteFactory*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, fontFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCustomFontFileReference([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("IDWriteFontFileLoader *")] IDWriteFontFileLoader* fontFileLoader, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCustomFontFileReference>(lpVtbl->CreateCustomFontFileReference)((IDWriteFactory*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace(DWRITE_FONT_FACE_TYPE fontFaceType, [NativeTypeName("UINT32")] uint numberOfFiles, [NativeTypeName("IDWriteFontFile *const *")] IDWriteFontFile** fontFiles, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, [NativeTypeName("IDWriteFontFace **")] IDWriteFontFace** fontFace)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontFace>(lpVtbl->CreateFontFace)((IDWriteFactory*)Unsafe.AsPointer(ref this), fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRenderingParams([NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** renderingParams)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRenderingParams>(lpVtbl->CreateRenderingParams)((IDWriteFactory*)Unsafe.AsPointer(ref this), renderingParams);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMonitorRenderingParams([NativeTypeName("HMONITOR")] IntPtr monitor, [NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** renderingParams)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateMonitorRenderingParams>(lpVtbl->CreateMonitorRenderingParams)((IDWriteFactory*)Unsafe.AsPointer(ref this), monitor, renderingParams);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCustomRenderingParams([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, [NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** renderingParams)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCustomRenderingParams>(lpVtbl->CreateCustomRenderingParams)((IDWriteFactory*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterFontFileLoader([NativeTypeName("IDWriteFontFileLoader *")] IDWriteFontFileLoader* fontFileLoader)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterFontFileLoader>(lpVtbl->RegisterFontFileLoader)((IDWriteFactory*)Unsafe.AsPointer(ref this), fontFileLoader);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterFontFileLoader([NativeTypeName("IDWriteFontFileLoader *")] IDWriteFontFileLoader* fontFileLoader)
        {
            return Marshal.GetDelegateForFunctionPointer<_UnregisterFontFileLoader>(lpVtbl->UnregisterFontFileLoader)((IDWriteFactory*)Unsafe.AsPointer(ref this), fontFileLoader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTextFormat([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, [NativeTypeName("FLOAT")] float fontSize, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("IDWriteTextFormat **")] IDWriteTextFormat** textFormat)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTextFormat>(lpVtbl->CreateTextFormat)((IDWriteFactory*)Unsafe.AsPointer(ref this), fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTypography([NativeTypeName("IDWriteTypography **")] IDWriteTypography** typography)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTypography>(lpVtbl->CreateTypography)((IDWriteFactory*)Unsafe.AsPointer(ref this), typography);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiInterop([NativeTypeName("IDWriteGdiInterop **")] IDWriteGdiInterop** gdiInterop)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGdiInterop>(lpVtbl->GetGdiInterop)((IDWriteFactory*)Unsafe.AsPointer(ref this), gdiInterop);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTextLayout([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float maxWidth, [NativeTypeName("FLOAT")] float maxHeight, [NativeTypeName("IDWriteTextLayout **")] IDWriteTextLayout** textLayout)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTextLayout>(lpVtbl->CreateTextLayout)((IDWriteFactory*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGdiCompatibleTextLayout([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float layoutWidth, [NativeTypeName("FLOAT")] float layoutHeight, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("IDWriteTextLayout **")] IDWriteTextLayout** textLayout)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateGdiCompatibleTextLayout>(lpVtbl->CreateGdiCompatibleTextLayout)((IDWriteFactory*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEllipsisTrimmingSign([NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** trimmingSign)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateEllipsisTrimmingSign>(lpVtbl->CreateEllipsisTrimmingSign)((IDWriteFactory*)Unsafe.AsPointer(ref this), textFormat, trimmingSign);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTextAnalyzer([NativeTypeName("IDWriteTextAnalyzer **")] IDWriteTextAnalyzer** textAnalyzer)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTextAnalyzer>(lpVtbl->CreateTextAnalyzer)((IDWriteFactory*)Unsafe.AsPointer(ref this), textAnalyzer);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateNumberSubstitution(DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("BOOL")] int ignoreUserOverride, [NativeTypeName("IDWriteNumberSubstitution **")] IDWriteNumberSubstitution** numberSubstitution)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateNumberSubstitution>(lpVtbl->CreateNumberSubstitution)((IDWriteFactory*)Unsafe.AsPointer(ref this), substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGlyphRunAnalysis([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("IDWriteGlyphRunAnalysis **")] IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateGlyphRunAnalysis>(lpVtbl->CreateGlyphRunAnalysis)((IDWriteFactory*)Unsafe.AsPointer(ref this), glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
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
        }
    }
}
