// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    /// <summary>The root factory interface for all DWrite objects.</summary>
    [Guid("30572F99-DAC6-41DB-A16E-0486307E606A")]
    public unsafe partial struct IDWriteFactory1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFactory1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFactory1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFactory1* This);

        /// <summary>Gets a font collection representing the set of installed fonts.</summary>
        /// <param name="fontCollection">Receives a pointer to the system font collection object, or NULL in case of failure.</param>
        /// <param name="checkForUpdates">If this parameter is nonzero, the function performs an immediate check for changes to the set of installed fonts. If this parameter is FALSE, the function will still detect changes if the font cache service is running, but there may be some latency. For example, an application might specify TRUE if it has itself just installed a font and wants to be sure the font collection contains that font.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSystemFontCollection(IDWriteFactory1* This, IDWriteFontCollection** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = FALSE);

        /// <summary>Creates a font collection using a custom font collection loader.</summary>
        /// <param name="collectionLoader">Application-defined font collection loader, which must have been previously registered using RegisterFontCollectionLoader.</param>
        /// <param name="collectionKey">Key used by the loader to identify a collection of font files.</param>
        /// <param name="collectionKeySize">Size in bytes of the collection key.</param>
        /// <param name="fontCollection">Receives a pointer to the system font collection object, or NULL in case of failure.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCustomFontCollection(IDWriteFactory1* This, IDWriteFontCollectionLoader* collectionLoader, void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, IDWriteFontCollection** fontCollection);

        /// <summary>Registers a custom font collection loader with the factory object.</summary>
        /// <param name="fontCollectionLoader">Application-defined font collection loader.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterFontCollectionLoader(IDWriteFactory1* This, IDWriteFontCollectionLoader* fontCollectionLoader);

        /// <summary>Unregisters a custom font collection loader that was previously registered using RegisterFontCollectionLoader.</summary>
        /// <param name="fontCollectionLoader">Application-defined font collection loader.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnregisterFontCollectionLoader(IDWriteFactory1* This, IDWriteFontCollectionLoader* fontCollectionLoader);

        /// <summary>CreateFontFileReference creates a font file reference object from a local font file.</summary>
        /// <param name="filePath">Absolute file path. Subsequent operations on the constructed object may fail if the user provided filePath doesn't correspond to a valid file on the disk.</param>
        /// <param name="lastWriteTime">Last modified time of the input file path. If the parameter is omitted, the function will access the font file to obtain its last write time, so the clients are encouraged to specify this value to avoid extra disk access. Subsequent operations on the constructed object may fail if the user provided lastWriteTime doesn't match the file on the disk.</param>
        /// <param name="fontFile">Contains newly created font file reference object, or NULL in case of failure.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFileReference(IDWriteFactory1* This, [NativeTypeName("WCHAR[]")] ushort* filePath, [Optional] FILETIME* lastWriteTime, IDWriteFontFile** fontFile);

        /// <summary>CreateCustomFontFileReference creates a reference to an application specific font file resource. This function enables an application or a document to use a font without having to install it on the system. The fontFileReferenceKey has to be unique only in the scope of the fontFileLoader used in this call.</summary>
        /// <param name="fontFileReferenceKey">Font file reference key that uniquely identifies the font file resource during the lifetime of fontFileLoader.</param>
        /// <param name="fontFileReferenceKeySize">Size of font file reference key in bytes.</param>
        /// <param name="fontFileLoader">Font file loader that will be used by the font system to load data from the file identified by fontFileReferenceKey.</param>
        /// <param name="fontFile">Contains the newly created font file object, or NULL in case of failure.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> This function is provided for cases when an application or a document needs to use a font without having to install it on the system. fontFileReferenceKey has to be unique only in the scope of the fontFileLoader used in this call.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCustomFontFileReference(IDWriteFactory1* This, void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile);

        /// <summary>Creates a font face object.</summary>
        /// <param name="fontFaceType">The file format of the font face.</param>
        /// <param name="numberOfFiles">The number of font files required to represent the font face.</param>
        /// <param name="fontFiles">Font files representing the font face. Since IDWriteFontFace maintains its own references to the input font file objects, it's OK to release them after this call.</param>
        /// <param name="faceIndex">The zero based index of a font face in cases when the font files contain a collection of font faces. If the font files contain a single face, this value should be zero.</param>
        /// <param name="fontFaceSimulationFlags">Font face simulation flags for algorithmic emboldening and italicization.</param>
        /// <param name="fontFace">Contains the newly created font face object, or NULL in case of failure.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFace(IDWriteFactory1* This, DWRITE_FONT_FACE_TYPE fontFaceType, [NativeTypeName("UINT32")] uint numberOfFiles, [NativeTypeName("IDWriteFontFile*[]")] IDWriteFontFile** fontFiles, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, IDWriteFontFace** fontFace);

        /// <summary>Creates a rendering parameters object with default settings for the primary monitor.</summary>
        /// <param name="renderingParams">Holds the newly created rendering parameters object, or NULL in case of failure.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRenderingParams(IDWriteFactory1* This, IDWriteRenderingParams** renderingParams);

        /// <summary>Creates a rendering parameters object with default settings for the specified monitor.</summary>
        /// <param name="monitor">The monitor to read the default values from.</param>
        /// <param name="renderingParams">Holds the newly created rendering parameters object, or NULL in case of failure.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMonitorRenderingParams(IDWriteFactory1* This, [NativeTypeName("HMONITOR")] IntPtr monitor, IDWriteRenderingParams** renderingParams);

        /// <summary>Creates a rendering parameters object with the specified properties.</summary>
        /// <param name="gamma">The gamma value used for gamma correction, which must be greater than zero and cannot exceed 256.</param>
        /// <param name="enhancedContrast">The amount of contrast enhancement, zero or greater.</param>
        /// <param name="clearTypeLevel">The degree of ClearType level, from 0.0f (no ClearType) to 1.0f (full ClearType).</param>
        /// <param name="pixelGeometry">The geometry of a device pixel.</param>
        /// <param name="renderingMode">Method of rendering glyphs. In most cases, this should be DWRITE_RENDERING_MODE_DEFAULT to automatically use an appropriate mode.</param>
        /// <param name="renderingParams">Holds the newly created rendering parameters object, or NULL in case of failure.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCustomRenderingParams(IDWriteFactory1* This, [NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, IDWriteRenderingParams** renderingParams);

        /// <summary>Registers a font file loader with DirectWrite.</summary>
        /// <param name="fontFileLoader">Pointer to the implementation of the IDWriteFontFileLoader for a particular file resource type.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> This function registers a font file loader with DirectWrite. Font file loader interface handles loading font file resources of a particular type from a key. The font file loader interface is recommended to be implemented by a singleton object. A given instance can only be registered once. Succeeding attempts will return an error that it has already been registered. IMPORTANT: font file loader implementations must not register themselves with DirectWrite inside their constructors and must not unregister themselves in their destructors, because registration and unregistration operations increment and decrement the object reference count respectively. Instead, registration and unregistration of font file loaders with DirectWrite should be performed outside of the font file loader implementation as a separate step.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterFontFileLoader(IDWriteFactory1* This, IDWriteFontFileLoader* fontFileLoader);

        /// <summary>Unregisters a font file loader that was previously registered with the DirectWrite font system using RegisterFontFileLoader.</summary>
        /// <param name="fontFileLoader">Pointer to the file loader that was previously registered with the DirectWrite font system using RegisterFontFileLoader.</param>
        /// <returns>This function will succeed if the user loader is requested to be removed. It will fail if the pointer to the file loader identifies a standard DirectWrite loader, or a loader that is never registered or has already been unregistered.</returns>
        /// <remarks> This function unregisters font file loader callbacks with the DirectWrite font system. The font file loader interface is recommended to be implemented by a singleton object. IMPORTANT: font file loader implementations must not register themselves with DirectWrite inside their constructors and must not unregister themselves in their destructors, because registration and unregistration operations increment and decrement the object reference count respectively. Instead, registration and unregistration of font file loaders with DirectWrite should be performed outside of the font file loader implementation as a separate step.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnregisterFontFileLoader(IDWriteFactory1* This, IDWriteFontFileLoader* fontFileLoader);

        /// <summary>Create a text format object used for text layout.</summary>
        /// <param name="fontFamilyName">Name of the font family</param>
        /// <param name="fontCollection">Font collection. NULL indicates the system font collection.</param>
        /// <param name="fontWeight">Font weight</param>
        /// <param name="fontStyle">Font style</param>
        /// <param name="fontStretch">Font stretch</param>
        /// <param name="fontSize">Logical size of the font in DIP units. A DIP ("device-independent pixel") equals 1/96 inch.</param>
        /// <param name="localeName">Locale name</param>
        /// <param name="textFormat">Contains newly created text format object, or NULL in case of failure.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTextFormat(IDWriteFactory1* This, [NativeTypeName("WCHAR[]")] ushort* fontFamilyName, [Optional] IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, [NativeTypeName("FLOAT")] float fontSize, [NativeTypeName("WCHAR[]")] ushort* localeName, IDWriteTextFormat** textFormat);

        /// <summary>Create a typography object used in conjunction with text format for text layout.</summary>
        /// <param name="typography">Contains newly created typography object, or NULL in case of failure.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTypography(IDWriteFactory1* This, IDWriteTypography** typography);

        /// <summary>Create an object used for interoperability with GDI.</summary>
        /// <param name="gdiInterop">Receives the GDI interop object if successful, or NULL in case of failure.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGdiInterop(IDWriteFactory1* This, IDWriteGdiInterop** gdiInterop);

        /// <summary>CreateTextLayout takes a string, format, and associated constraints and produces an object representing the fully analyzed and formatted result.</summary>
        /// <param name="string">The string to layout.</param>
        /// <param name="stringLength">The length of the string.</param>
        /// <param name="textFormat">The format to apply to the string.</param>
        /// <param name="maxWidth">Width of the layout box.</param>
        /// <param name="maxHeight">Height of the layout box.</param>
        /// <param name="textLayout">The resultant object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTextLayout(IDWriteFactory1* This, [NativeTypeName("WCHAR[]")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float maxWidth, [NativeTypeName("FLOAT")] float maxHeight, IDWriteTextLayout** textLayout);

        /// <summary>CreateGdiCompatibleTextLayout takes a string, format, and associated constraints and produces and object representing the result formatted for a particular display resolution and measuring mode. The resulting text layout should only be used for the intended resolution, and for cases where text scalability is desired, CreateTextLayout should be used instead.</summary>
        /// <param name="string">The string to layout.</param>
        /// <param name="stringLength">The length of the string.</param>
        /// <param name="textFormat">The format to apply to the string.</param>
        /// <param name="layoutWidth">Width of the layout box.</param>
        /// <param name="layoutHeight">Height of the layout box.</param>
        /// <param name="pixelsPerDip">Number of physical pixels per DIP. For example, if rendering onto a 96 DPI device then pixelsPerDip is 1. If rendering onto a 120 DPI device then pixelsPerDip is 120/96.</param>
        /// <param name="transform">Optional transform applied to the glyphs and their positions. This transform is applied after the scaling specified the font size and pixelsPerDip.</param>
        /// <param name="useGdiNatural"> When set to FALSE, instructs the text layout to use the same metrics as GDI aliased text. When set to TRUE, instructs the text layout to use the same metrics as text measured by GDI using a font created with CLEARTYPE_NATURAL_QUALITY.</param>
        /// <param name="textLayout">The resultant object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGdiCompatibleTextLayout(IDWriteFactory1* This, [NativeTypeName("WCHAR[]")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float layoutWidth, [NativeTypeName("FLOAT")] float layoutHeight, [NativeTypeName("FLOAT")] float pixelsPerDip, [Optional] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, IDWriteTextLayout** textLayout);

        /// <summary>The application may call this function to create an inline object for trimming, using an ellipsis as the omission sign. The ellipsis will be created using the current settings of the format, including base font, style, and any effects. Alternate omission signs can be created by the application by implementing IDWriteInlineObject.</summary>
        /// <param name="textFormat">Text format used as a template for the omission sign.</param>
        /// <param name="trimmingSign">Created omission sign.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEllipsisTrimmingSign(IDWriteFactory1* This, IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign);

        /// <summary>Return an interface to perform text analysis with.</summary>
        /// <param name="textAnalyzer">The resultant object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTextAnalyzer(IDWriteFactory1* This, IDWriteTextAnalyzer** textAnalyzer);

        /// <summary>Creates a number substitution object using a locale name, substitution method, and whether to ignore user overrides (uses NLS defaults for the given culture instead).</summary>
        /// <param name="substitutionMethod">Method of number substitution to use.</param>
        /// <param name="localeName">Which locale to obtain the digits from.</param>
        /// <param name="ignoreUserOverride">Ignore the user's settings and use the locale defaults</param>
        /// <param name="numberSubstitution">Receives a pointer to the newly created object.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateNumberSubstitution(IDWriteFactory1* This, DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, [NativeTypeName("WCHAR[]")] ushort* localeName, [NativeTypeName("BOOL")] int ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution);

        /// <summary>Creates a glyph run analysis object, which encapsulates information used to render a glyph run.</summary>
        /// <param name="glyphRun">Structure specifying the properties of the glyph run.</param>
        /// <param name="pixelsPerDip">Number of physical pixels per DIP. For example, if rendering onto a 96 DPI bitmap then pixelsPerDip is 1. If rendering onto a 120 DPI bitmap then pixelsPerDip is 120/96.</param>
        /// <param name="transform">Optional transform applied to the glyphs and their positions. This transform is applied after the scaling specified by the emSize and pixelsPerDip.</param>
        /// <param name="renderingMode">Specifies the rendering mode, which must be one of the raster rendering modes (i.e., not default and not outline).</param>
        /// <param name="measuringMode">Specifies the method to measure glyphs.</param>
        /// <param name="baselineOriginX">Horizontal position of the baseline origin, in DIPs.</param>
        /// <param name="baselineOriginY">Vertical position of the baseline origin, in DIPs.</param>
        /// <param name="glyphRunAnalysis">Receives a pointer to the newly created object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGlyphRunAnalysis(IDWriteFactory1* This, DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("FLOAT")] float pixelsPerDip, [Optional] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis);

        /// <summary>Gets a font collection representing the set of end-user defined custom fonts.</summary>
        /// <param name="fontCollection">Receives a pointer to the EUDC font collection object, or NULL in case of failure.</param>
        /// <param name="checkForUpdates">If this parameter is nonzero, the function performs an immediate check for changes to the set of EUDC fonts. If this parameter is FALSE, the function will still detect changes, but there may be some latency. For example, an application might specify TRUE if it has itself just modified a font and wants to be sure the font collection contains that font.</param>
        /// <returns> Standard HRESULT error code. Note that if no EUDC is set on the system, the returned collection will be empty, meaning it will return success but GetFontFamilyCount will be zero.</returns>
        /// <remarks> Querying via IDWriteFontCollection::FindFamilyName for a specific family (like MS Gothic) will return the matching family-specific EUDC font if one exists. Querying for "" will return the global EUDC font. For example, if you were matching an EUDC character within a run of the base font PMingLiu, you would retrieve the corresponding EUDC font face using GetEudcFontCollection, then FindFamilyName with "PMingLiu", followed by GetFontFamily and CreateFontFace.
        /// Be aware that eudcedit.exe can create placeholder empty glyphs that have zero advance width and no glyph outline. Although they are present in the font (HasCharacter returns true), you are best to ignore these and continue on with font fallback in your layout if the metrics for the glyph are zero.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEudcFontCollection(IDWriteFactory1* This, IDWriteFontCollection** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = FALSE);

        /// <summary>Creates a rendering parameters object with the specified properties.</summary>
        /// <param name="gamma">The gamma value used for gamma correction, which must be greater than zero and cannot exceed 256.</param>
        /// <param name="enhancedContrast">The amount of contrast enhancement, zero or greater.</param>
        /// <param name="enhancedContrastGrayscale">The amount of contrast enhancement to use for grayscale antialiasing, zero or greater.</param>
        /// <param name="clearTypeLevel">The degree of ClearType level, from 0.0f (no ClearType) to 1.0f (full ClearType).</param>
        /// <param name="pixelGeometry">The geometry of a device pixel.</param>
        /// <param name="renderingMode">Method of rendering glyphs. In most cases, this should be DWRITE_RENDERING_MODE_DEFAULT to automatically use an appropriate mode.</param>
        /// <param name="renderingParams">Holds the newly created rendering parameters object, or NULL in case of failure.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCustomRenderingParams1(IDWriteFactory1* This, [NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float enhancedContrastGrayscale, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, IDWriteRenderingParams1** renderingParams);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSystemFontCollection(IDWriteFontCollection** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = FALSE)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSystemFontCollection>(lpVtbl->GetSystemFontCollection)(This, fontCollection, checkForUpdates);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, IDWriteFontCollection** fontCollection)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateCustomFontCollection>(lpVtbl->CreateCustomFontCollection)(This, collectionLoader, collectionKey, collectionKeySize, fontCollection);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterFontCollectionLoader>(lpVtbl->RegisterFontCollectionLoader)(This, fontCollectionLoader);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_UnregisterFontCollectionLoader>(lpVtbl->UnregisterFontCollectionLoader)(This, fontCollectionLoader);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFileReference([NativeTypeName("WCHAR[]")] ushort* filePath, [Optional] FILETIME* lastWriteTime, IDWriteFontFile** fontFile)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFontFileReference>(lpVtbl->CreateFontFileReference)(This, filePath, lastWriteTime, fontFile);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCustomFontFileReference(void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateCustomFontFileReference>(lpVtbl->CreateCustomFontFileReference)(This, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace(DWRITE_FONT_FACE_TYPE fontFaceType, [NativeTypeName("UINT32")] uint numberOfFiles, [NativeTypeName("IDWriteFontFile*[]")] IDWriteFontFile** fontFiles, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, IDWriteFontFace** fontFace)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFontFace>(lpVtbl->CreateFontFace)(This, fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRenderingParams(IDWriteRenderingParams** renderingParams)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateRenderingParams>(lpVtbl->CreateRenderingParams)(This, renderingParams);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMonitorRenderingParams([NativeTypeName("HMONITOR")] IntPtr monitor, IDWriteRenderingParams** renderingParams)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateMonitorRenderingParams>(lpVtbl->CreateMonitorRenderingParams)(This, monitor, renderingParams);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCustomRenderingParams([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, IDWriteRenderingParams** renderingParams)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateCustomRenderingParams>(lpVtbl->CreateCustomRenderingParams)(This, gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterFontFileLoader>(lpVtbl->RegisterFontFileLoader)(This, fontFileLoader);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_UnregisterFontFileLoader>(lpVtbl->UnregisterFontFileLoader)(This, fontFileLoader);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTextFormat([NativeTypeName("WCHAR[]")] ushort* fontFamilyName, [Optional] IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, [NativeTypeName("FLOAT")] float fontSize, [NativeTypeName("WCHAR[]")] ushort* localeName, IDWriteTextFormat** textFormat)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateTextFormat>(lpVtbl->CreateTextFormat)(This, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTypography(IDWriteTypography** typography)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateTypography>(lpVtbl->CreateTypography)(This, typography);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiInterop(IDWriteGdiInterop** gdiInterop)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGdiInterop>(lpVtbl->GetGdiInterop)(This, gdiInterop);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTextLayout([NativeTypeName("WCHAR[]")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float maxWidth, [NativeTypeName("FLOAT")] float maxHeight, IDWriteTextLayout** textLayout)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateTextLayout>(lpVtbl->CreateTextLayout)(This, @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGdiCompatibleTextLayout([NativeTypeName("WCHAR[]")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float layoutWidth, [NativeTypeName("FLOAT")] float layoutHeight, [NativeTypeName("FLOAT")] float pixelsPerDip, [Optional] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, IDWriteTextLayout** textLayout)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateGdiCompatibleTextLayout>(lpVtbl->CreateGdiCompatibleTextLayout)(This, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateEllipsisTrimmingSign>(lpVtbl->CreateEllipsisTrimmingSign)(This, textFormat, trimmingSign);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTextAnalyzer(IDWriteTextAnalyzer** textAnalyzer)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateTextAnalyzer>(lpVtbl->CreateTextAnalyzer)(This, textAnalyzer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateNumberSubstitution(DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, [NativeTypeName("WCHAR[]")] ushort* localeName, [NativeTypeName("BOOL")] int ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateNumberSubstitution>(lpVtbl->CreateNumberSubstitution)(This, substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGlyphRunAnalysis(DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("FLOAT")] float pixelsPerDip, [Optional] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateGlyphRunAnalysis>(lpVtbl->CreateGlyphRunAnalysis)(This, glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEudcFontCollection(IDWriteFontCollection** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = FALSE)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEudcFontCollection>(lpVtbl->GetEudcFontCollection)(This, fontCollection, checkForUpdates);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCustomRenderingParams1([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float enhancedContrastGrayscale, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, IDWriteRenderingParams1** renderingParams)
        {
            fixed (IDWriteFactory1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateCustomRenderingParams1>(lpVtbl->CreateCustomRenderingParams1)(This, gamma, enhancedContrast, enhancedContrastGrayscale, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetSystemFontCollection;

            public IntPtr CreateCustomFontCollection;

            public IntPtr RegisterFontCollectionLoader;

            public IntPtr UnregisterFontCollectionLoader;

            public IntPtr CreateFontFileReference;

            public IntPtr CreateCustomFontFileReference;

            public IntPtr CreateFontFace;

            public IntPtr CreateRenderingParams;

            public IntPtr CreateMonitorRenderingParams;

            public IntPtr CreateCustomRenderingParams;

            public IntPtr RegisterFontFileLoader;

            public IntPtr UnregisterFontFileLoader;

            public IntPtr CreateTextFormat;

            public IntPtr CreateTypography;

            public IntPtr GetGdiInterop;

            public IntPtr CreateTextLayout;

            public IntPtr CreateGdiCompatibleTextLayout;

            public IntPtr CreateEllipsisTrimmingSign;

            public IntPtr CreateTextAnalyzer;

            public IntPtr CreateNumberSubstitution;

            public IntPtr CreateGlyphRunAnalysis;

            public IntPtr GetEudcFontCollection;

            public IntPtr CreateCustomRenderingParams1;
        }
    }
}
