// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Interop.Windows;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>The interface that represents an absolute reference to a font face. It contains font face type, appropriate file references and face identification data. Various font data such as metrics, names and glyph outlines is obtained from IDWriteFontFace.</summary>
    [Guid("D37D7598-09BE-4222-A236-2081341CC1F2")]
    public unsafe struct IDWriteFontFace3
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteFontFace3* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteFontFace3* This
        );
        #endregion

        #region IDWriteFontFace Delegates
        /// <summary>Obtains the file format type of a font face.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_FACE_TYPE __GetType(
            [In] IDWriteFontFace3* This
        );

        /// <summary>Obtains the font files representing a font face.</summary>
        /// <param name="numberOfFiles">The number of files representing the font face.</param>
        /// <param name="fontFiles">User provided array that stores pointers to font files representing the font face. This parameter can be NULL if the user is only interested in the number of files representing the font face. This API increments reference count of the font file pointers returned according to COM conventions, and the client should release them when finished.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFiles(
            [In] IDWriteFontFace3* This,
            [In, Out, NativeTypeName("UINT32")] uint* numberOfFiles,
            [Out] IDWriteFontFile** fontFiles = null
        );

        /// <summary>Obtains the zero-based index of the font face in its font file or files. If the font files contain a single face, the return value is zero.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetIndex(
            [In] IDWriteFontFace3* This
        );

        /// <summary>Obtains the algorithmic style simulation flags of a font face.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_SIMULATIONS _GetSimulations(
            [In] IDWriteFontFace3* This
        );

        /// <summary>Determines whether the font is a symbol font.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _IsSymbolFont(
            [In] IDWriteFontFace3* This
        );

        /// <summary>Obtains design units and common metrics for the font face. These metrics are applicable to all the glyphs within a fontface and are used by applications for layout calculations.</summary>
        /// <param name="fontFaceMetrics">Points to a DWRITE_FONT_METRICS public structure to fill in. The metrics returned by this function are in font design units.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetMetrics(
            [In] IDWriteFontFace3* This,
            [Out] DWRITE_FONT_METRICS* fontFaceMetrics
        );

        /// <summary>Obtains the number of glyphs in the font face.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT16")]
        public /* static */ delegate ushort _GetGlyphCount(
            [In] IDWriteFontFace3* This
        );

        /// <summary>Obtains ideal glyph metrics in font design units. Design glyphs metrics are used for glyph positioning.</summary>
        /// <param name="glyphIndices">An array of glyph indices to compute the metrics for.</param>
        /// <param name="glyphCount">The number of elements in the glyphIndices array.</param>
        /// <param name="glyphMetrics">Array of DWRITE_GLYPH_METRICS public structures filled by this function. The metrics returned by this function are in font design units.</param>
        /// <param name="isSideways">Indicates whether the font is being used in a sideways run. This can affect the glyph metrics if the font has oblique simulation because sideways oblique simulation differs from non-sideways oblique simulation.</param>
        /// <returns>Standard HRESULT error code. If any of the input glyph indices are outside of the valid glyph index range for the current font face, E_INVALIDARG will be returned.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDesignGlyphMetrics(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("UINT16[]")] ushort* glyphIndices,
            [In, NativeTypeName("UINT32")] uint glyphCount,
            [Out] DWRITE_GLYPH_METRICS* glyphMetrics,
            [In, NativeTypeName("BOOL")] int isSideways = FALSE
        );

        /// <summary>Returns the nominal mapping of UTF-32 Unicode code points to glyph indices as defined by the font 'cmap' table. Note that this mapping is primarily provided for line layout engines built on top of the physical font API. Because of OpenType glyph substitution and line layout character substitution, the nominal conversion does not always correspond to how a Unicode string will map to glyph indices when rendering using a particular font face. Also, note that Unicode Variation Selectors provide for alternate mappings for character to glyph. This call will always return the default variant.</summary>
        /// <param name="codePoints">An array of UTF-32 code points to obtain nominal glyph indices from.</param>
        /// <param name="codePointCount">The number of elements in the codePoints array.</param>
        /// <param name="glyphIndices">Array of nominal glyph indices filled by this function.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetGlyphIndices(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("UINT32[]")] uint* codePoints,
            [In, NativeTypeName("UINT32")] uint codePointCount,
            [Out, NativeTypeName("UINT16")] ushort* glyphIndices
        );

        /// <summary>Finds the specified OpenType font table if it exists and returns a pointer to it. The function accesses the underlying font data via the IDWriteFontFileStream interface implemented by the font file loader.</summary>
        /// <param name="openTypeTableTag">Four character tag of table to find. Use the DWRITE_MAKE_OPENTYPE_TAG() macro to create it. Unlike GDI, it does not support the special TTCF and null tags to access the whole font.</param>
        /// <param name="tableData">Pointer to base of table in memory. The pointer is only valid so long as the FontFace used to get the font table still exists (not any other FontFace, even if it actually refers to the same physical font).</param>
        /// <param name="tableSize">Byte size of table.</param>
        /// <param name="tableContext">Opaque context which must be freed by calling ReleaseFontTable. The context actually comes from the lower level IDWriteFontFileStream, which may be implemented by the application or DWrite itself. It is possible for a NULL tableContext to be returned, especially if the implementation directly memory maps the whole file. Nevertheless, always release it later, and do not use it as a test for function success. The same table can be queried multiple times, but each returned context can be different, so release each separately.</param>
        /// <param name="exists">True if table exists.</param>
        /// <returns>Standard HRESULT error code.If a table can not be found, the function will not return an error, but the size will be 0, table NULL, and exists = FALSE. The context does not need to be freed if the table was not found.</returns>
        /// <remarks>The context for the same tag may be different for each call,so each one must be held and released separately.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _TryGetFontTable(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("UINT32")] uint openTypeTableTag,
            [Out] void** tableData,
            [Out, NativeTypeName("UINT32")] uint* tableSize,
            [Out] void** tableContext,
            [Out, NativeTypeName("BOOL")] int* exists
        );

        /// <summary>Releases the table obtained earlier from TryGetFontTable.</summary>
        /// <param name="tableContext">Opaque context from TryGetFontTable.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _ReleaseFontTable(
            [In] IDWriteFontFace3* This,
            [In] void* tableContext
        );

        /// <summary>Computes the outline of a run of glyphs by calling back to the outline sink interface.</summary>
        /// <param name="emSize">Logical size of the font in DIP units. A DIP ("device-independent pixel") equals 1/96 inch.</param>
        /// <param name="glyphIndices">Array of glyph indices.</param>
        /// <param name="glyphAdvances">Optional array of glyph advances in DIPs.</param>
        /// <param name="glyphOffsets">Optional array of glyph offsets.</param>
        /// <param name="glyphCount">Number of glyphs.</param>
        /// <param name="isSideways">If true, specifies that glyphs are rotated 90 degrees to the left and vertical metrics are used. A client can render a vertical run by specifying isSideways = true and rotating the resulting geometry 90 degrees to the right using a transform.</param>
        /// <param name="isRightToLeft">If true, specifies that the advance direction is right to left. By default, the advance direction is left to right.</param>
        /// <param name="geometrySink">Interface the function calls back to draw each element of the geometry.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetGlyphRunOutline(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("FLOAT")] float emSize,
            [In, NativeTypeName("UINT16[]")] ushort* glyphIndices,
            [In, Optional, NativeTypeName("FLOAT[]")] float* glyphAdvances,
            [In, Optional, NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* glyphOffsets,
            [In, NativeTypeName("UINT32")] uint glyphCount,
            [In, NativeTypeName("BOOL")] int isSideways,
            [In, NativeTypeName("BOOL")] int isRightToLeft,
            [In, NativeTypeName("IDWriteGeometrySink")] ID2D1SimplifiedGeometrySink* geometrySink
        );

        /// <summary>Determines the recommended rendering mode for the font given the specified size and rendering parameters.</summary>
        /// <param name="emSize">Logical size of the font in DIP units. A DIP ("device-independent pixel") equals 1/96 inch.</param>
        /// <param name="pixelsPerDip">Number of physical pixels per DIP. For example, if the DPI of the rendering surface is 96 this value is 1.0f. If the DPI is 120, this value is 120.0f/96.</param>
        /// <param name="measuringMode">Specifies measuring mode that will be used for glyphs in the font. Renderer implementations may choose different rendering modes for given measuring modes, but best results are seen when the corresponding modes match: DWRITE_RENDERING_MODE_CLEARTYPE_NATURAL for DWRITE_MEASURING_MODE_NATURAL DWRITE_RENDERING_MODE_CLEARTYPE_GDI_CLASSIC for DWRITE_MEASURING_MODE_GDI_CLASSIC DWRITE_RENDERING_MODE_CLEARTYPE_GDI_NATURAL for DWRITE_MEASURING_MODE_GDI_NATURAL</param>
        /// <param name="renderingParams">Rendering parameters object. This parameter is necessary in case the rendering parameters object overrides the rendering mode.</param>
        /// <param name="renderingMode">Receives the recommended rendering mode to use.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetRecommendedRenderingMode(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("FLOAT")] float emSize,
            [In, NativeTypeName("FLOAT")] float pixelsPerDip,
            [In] DWRITE_MEASURING_MODE measuringMode,
            [In] IDWriteRenderingParams* renderingParams,
            [Out] DWRITE_RENDERING_MODE* renderingMode
        );

        /// <summary>Obtains design units and common metrics for the font face. These metrics are applicable to all the glyphs within a fontface and are used by applications for layout calculations.</summary>
        /// <param name="emSize">Logical size of the font in DIP units. A DIP ("device-independent pixel") equals 1/96 inch.</param>
        /// <param name="pixelsPerDip">Number of physical pixels per DIP. For example, if the DPI of the rendering surface is 96 this value is 1.0f. If the DPI is 120, this value is 120.0f/96.</param>
        /// <param name="transform">Optional transform applied to the glyphs and their positions. This transform is applied after the scaling specified by the font size and pixelsPerDip.</param>
        /// <param name="fontFaceMetrics">Points to a DWRITE_FONT_METRICS public structure to fill in. The metrics returned by this function are in font design units.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetGdiCompatibleMetrics(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("FLOAT")] float emSize,
            [In, NativeTypeName("FLOAT")] float pixelsPerDip,
            [In, Optional] DWRITE_MATRIX* transform,
            [Out] DWRITE_FONT_METRICS* fontFaceMetrics
        );

        /// <summary>Obtains glyph metrics in font design units with the return values compatible with what GDI would produce. Glyphs metrics are used for positioning of individual glyphs.</summary>
        /// <param name="emSize">Logical size of the font in DIP units. A DIP ("device-independent pixel") equals 1/96 inch.</param>
        /// <param name="pixelsPerDip">Number of physical pixels per DIP. For example, if the DPI of the rendering surface is 96 this value is 1.0f. If the DPI is 120, this value is 120.0f/96.</param>
        /// <param name="transform">Optional transform applied to the glyphs and their positions. This transform is applied after the scaling specified by the font size and pixelsPerDip.</param>
        /// <param name="useGdiNatural"> When set to FALSE, the metrics are the same as the metrics of GDI aliased text. When set to TRUE, the metrics are the same as the metrics of text measured by GDI using a font created with CLEARTYPE_NATURAL_QUALITY.</param>
        /// <param name="glyphIndices">An array of glyph indices to compute the metrics for.</param>
        /// <param name="glyphCount">The number of elements in the glyphIndices array.</param>
        /// <param name="glyphMetrics">Array of DWRITE_GLYPH_METRICS public structures filled by this function. The metrics returned by this function are in font design units.</param>
        /// <param name="isSideways">Indicates whether the font is being used in a sideways run. This can affect the glyph metrics if the font has oblique simulation because sideways oblique simulation differs from non-sideways oblique simulation.</param>
        /// <returns>Standard HRESULT error code. If any of the input glyph indices are outside of the valid glyph index range for the current font face, E_INVALIDARG will be returned.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetGdiCompatibleGlyphMetrics(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("FLOAT")] float emSize,
            [In, NativeTypeName("FLOAT")] float pixelsPerDip,
            [In, Optional] DWRITE_MATRIX* transform,
            [In, NativeTypeName("BOOL")] int useGdiNatural,
            [In, NativeTypeName("UINT16[]")] ushort* glyphIndices,
            [In, NativeTypeName("UINT32")] uint glyphCount,
            [Out, NativeTypeName("DWRITE_GLYPH_METRICS[]")] DWRITE_GLYPH_METRICS* glyphMetrics,
            [In, NativeTypeName("BOOL")] int isSideways = FALSE
        );
        #endregion

        #region IDWriteFontFace1 Delegates
        /// <summary>Gets common metrics for the font in design units. These metrics are applicable to all the glyphs within a font, and are used by applications for layout calculations.</summary>
        /// <param name="fontMetrics">Metrics public structure to fill in.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetMetrics1(
            [In] IDWriteFontFace3* This,
            [Out] DWRITE_FONT_METRICS1* fontMetrics
        );

        /// <summary>Gets common metrics for the font in design units. These metrics are applicable to all the glyphs within a font, and are used by applications for layout calculations.</summary>
        /// <param name="emSize">Logical size of the font in DIP units. A DIP ("device-independent pixel") equals 1/96 inch.</param>
        /// <param name="pixelsPerDip">Number of physical pixels per DIP. For example, if the DPI of the rendering surface is 96 this value is 1.0f. If the DPI is 120, this value is 120.0f/96.</param>
        /// <param name="transform">Optional transform applied to the glyphs and their positions. This transform is applied after the scaling specified by the font size and pixelsPerDip.</param>
        /// <param name="fontMetrics">Font metrics public structure to fill in.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetGdiCompatibleMetrics1(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("FLOAT")] float emSize,
            [In, NativeTypeName("FLOAT")] float pixelsPerDip,
            [In, Optional] DWRITE_MATRIX* transform,
            [Out] DWRITE_FONT_METRICS1* fontMetrics
        );

        /// <summary>Gets caret metrics for the font in design units. These are used by text editors for drawing the correct caret placement/slant.</summary>
        /// <param name="caretMetrics">Metrics public structure to fill in.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetCaretMetrics(
            [In] IDWriteFontFace3* This,
            [Out] DWRITE_CARET_METRICS* caretMetrics
        );

        /// <summary>Returns the list of character ranges supported by the font, which is useful for scenarios like character picking, glyph display, and efficient font selection lookup. This is similar to GDI's GetFontUnicodeRanges, except that it returns the full Unicode range, not just 16-bit UCS-2.</summary>
        /// <param name="maxRangeCount">Maximum number of character ranges passed in from the client.</param>
        /// <param name="unicodeRanges">Array of character ranges.</param>
        /// <param name="actualRangeCount">Actual number of character ranges, regardless of the maximum count.</param>
        /// <remarks> These ranges are from the cmap, not the OS/2::ulCodePageRange1.</remarks>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetUnicodeRanges(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("UINT32")] uint maxRangeCount,
            [Out, Optional, NativeTypeName("DWRITE_UNICODE_RANGE[]")] DWRITE_UNICODE_RANGE* unicodeRanges,
            [Out, NativeTypeName("UINT32")] uint* actualRangeCount
        );

        /// <summary>Returns true if the font is monospaced, meaning its characters are the same fixed-pitch width (non-proportional).</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _IsMonospacedFont(
            [In] IDWriteFontFace3* This
        );

        /// <summary>Returns the advances in design units for a sequences of glyphs.</summary>
        /// <param name="glyphCount">Number of glyphs to retrieve advances for.</param>
        /// <param name="glyphIndices">Array of glyph id's to retrieve advances for.</param>
        /// <param name="glyphAdvances">Returned advances in font design units for each glyph.</param>
        /// <param name="isSideways">Retrieve the glyph's vertical advance height rather than horizontal advance widths.</param>
        /// <remarks> This is equivalent to calling GetGlyphMetrics and using only the advance width/height.</remarks>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDesignGlyphAdvances(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("UINT32")] uint glyphCount,
            [In, NativeTypeName("UINT16[]")] ushort* glyphIndices,
            [Out, NativeTypeName("INT32[]")] int* glyphAdvances,
            [In, NativeTypeName("BOOL")] int isSideways = FALSE
        );

        /// <summary>Returns the pixel-aligned advances for a sequences of glyphs, the same as GetGdiCompatibleGlyphMetrics would return.</summary>
        /// <param name="emSize">Logical size of the font in DIP units. A DIP ("device-independent pixel") equals 1/96 inch.</param>
        /// <param name="pixelsPerDip">Number of physical pixels per DIP. For example, if the DPI of the rendering surface is 96 this value is 1.0f. If the DPI is 120, this value is 120.0f/96.</param>
        /// <param name="transform">Optional transform applied to the glyphs and their positions. This transform is applied after the scaling specified by the font size and pixelsPerDip.</param>
        /// <param name="useGdiNatural">When FALSE, the metrics are the same as GDI aliased text (DWRITE_MEASURING_MODE_GDI_CLASSIC). When TRUE, the metrics are the same as those measured by GDI using a font using CLEARTYPE_NATURAL_QUALITY (DWRITE_MEASURING_MODE_GDI_NATURAL).</param>
        /// <param name="isSideways">Retrieve the glyph's vertical advances rather than horizontal advances.</param>
        /// <param name="glyphCount">Total glyphs to retrieve adjustments for.</param>
        /// <param name="glyphIndices">Array of glyph id's to retrieve advances.</param>
        /// <param name="glyphAdvances">Returned advances in font design units for each glyph.</param>
        /// <remarks> This is equivalent to calling GetGdiCompatibleGlyphMetrics and using only the advance width/height. Like GetGdiCompatibleGlyphMetrics, these are in design units, meaning they must be scaled down by DWRITE_FONT_METRICS::designUnitsPerEm.</remarks>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetGdiCompatibleGlyphAdvances(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("FLOAT")] float emSize,
            [In, NativeTypeName("FLOAT")] float pixelsPerDip,
            [In, Optional] DWRITE_MATRIX* transform,
            [In, NativeTypeName("BOOL")] int useGdiNatural,
            [In, NativeTypeName("BOOL")] int isSideways,
            [In, NativeTypeName("UINT32")] uint glyphCount,
            [In, NativeTypeName("UINT16[]")] ushort* glyphIndices,
            [Out, NativeTypeName("INT32[]")] int* glyphAdvances
        );

        /// <summary>Retrieves the kerning pair adjustments from the font's kern table.</summary>
        /// <param name="glyphCount">Number of glyphs to retrieve adjustments for.</param>
        /// <param name="glyphIndices">Array of glyph id's to retrieve adjustments for.</param>
        /// <param name="glyphAdvanceAdjustments">Returned advances in font design units for each glyph. The last glyph adjustment is zero.</param>
        /// <remarks> This is not a direct replacement for GDI's character based GetKerningPairs, but it serves the same role, without the client needing to cache them locally. It also uses glyph id's directly rather than UCS-2 characters (how the kern table actually stores them) which avoids glyph collapse and ambiguity, such as the dash and hyphen, or space and non-breaking space.</remarks>
        /// <remarks> Newer fonts may have only GPOS kerning instead of the legacy pair table kerning. Such fonts, like Gabriola, will only return 0's for adjustments. This function does not virtualize and flatten these GPOS entries into kerning pairs.</remarks>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetKerningPairAdjustments(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("UINT32")] uint glyphCount,
            [In, NativeTypeName("UINT16[]")] ushort* glyphIndices,
            [Out, NativeTypeName("INT32[]")] int* glyphAdvanceAdjustments
        );

        /// <summary>Returns whether or not the font supports pair-kerning.</summary>
        /// <remarks> If the font does not support pair table kerning, there is no need to call GetKerningPairAdjustments (it would be all zeroes).</remarks>
        /// <returns> Whether the font supports kerning pairs.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _HasKerningPairs(
            [In] IDWriteFontFace3* This
        );

        /// <summary>Determines the recommended text rendering mode to be used based on the font, size, world transform, and measuring mode.</summary>
        /// <param name="fontEmSize">Logical font size in DIPs.</param>
        /// <param name="dpiX">Number of pixels per logical inch in the horizontal direction.</param>
        /// <param name="dpiY">Number of pixels per logical inch in the vertical direction.</param>
        /// <param name="transform">Specifies the world transform.</param>
        /// <param name="outlineThreshold">Specifies the quality of the graphics system's outline rendering, affects the size threshold above which outline rendering is used.</param>
        /// <param name="measuringMode">Specifies the method used to measure during text layout. For proper glyph spacing, the function returns a rendering mode that is compatible with the specified measuring mode.</param>
        /// <param name="renderingMode">Receives the recommended rendering mode.</param>
        /// <remarks> This method should be used to determine the actual rendering mode in cases where the rendering mode of the rendering params object is DWRITE_RENDERING_MODE_DEFAULT.</remarks>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetRecommendedRenderingMode1(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("FLOAT")] float fontEmSize,
            [In, NativeTypeName("FLOAT")] float dpiX,
            [In, NativeTypeName("FLOAT")] float dpiY,
            [In, Optional] DWRITE_MATRIX* transform,
            [In, NativeTypeName("BOOL")] int isSideways,
            [In] DWRITE_OUTLINE_THRESHOLD outlineThreshold,
            [In] DWRITE_MEASURING_MODE measuringMode,
            [Out] DWRITE_RENDERING_MODE* renderingMode
        );

        /// <summary>Retrieves the vertical forms of the nominal glyphs retrieved from GetGlyphIndices, using the font's 'vert' table. This is used in CJK vertical layout so the correct characters are shown.</summary>
        /// <param name="glyphCount">Number of glyphs to retrieve.</param>
        /// <param name="nominalGlyphIndices">Original glyph indices from cmap.</param>
        /// <param name="verticalGlyphIndices">The vertical form of glyph indices.</param>
        /// <remarks> Call GetGlyphIndices to get the nominal glyph indices, followed by calling this to remap the to the substituted forms, when the run is sideways, and the font has vertical glyph variants.</remarks>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetVerticalGlyphVariants(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("UINT32")] uint glyphCount,
            [In, NativeTypeName("UINT16[]")] ushort* nominalGlyphIndices,
            [Out, NativeTypeName("UINT16[]")] ushort* verticalGlyphIndices
        );

        /// <summary>Returns whether or not the font has any vertical glyph variants.</summary>
        /// <remarks> For OpenType fonts, this will return true if the font contains a 'vert' feature.</remarks>
        /// <returns> True if the font contains vertical glyph variants.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _HasVerticalGlyphVariants(
            [In] IDWriteFontFace3* This
        );
        #endregion

        #region IDWriteFontFace2 Delegates
        /// <summary>Returns TRUE if the font contains tables that can provide color information (including COLR, CPAL, SVG, CBDT, sbix  tables), or FALSE if not. Note that TRUE is returned even in the case when the font tables contain only grayscale images.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _IsColorFont(
            [In] IDWriteFontFace3* This
        );

        /// <summary>Returns the number of color palettes defined by the font. The return value is zero if the font has no color information. Color fonts must have at least one palette, with palette index zero being the default.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetColorPaletteCount(
            [In] IDWriteFontFace3* This
        );

        /// <summary>Returns the number of entries in each color palette. All color palettes in a font have the same number of palette entries. The return value is zero if the font has no color information.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetPaletteEntryCount(
            [In] IDWriteFontFace3* This
        );

        /// <summary>Reads color values from the font's color palette.</summary>
        /// <param name="colorPaletteIndex">Zero-based index of the color palette. If the font does not have a palette with the specified index, the method returns DWRITE_E_NOCOLOR.</param>
        /// <param name="firstEntryIndex">Zero-based index of the first palette entry to read.</param>
        /// <param name="entryCount">Number of palette entries to read.</param>
        /// <param name="paletteEntries">Array that receives the color values.</param>
        /// <returns> Standard HRESULT error code. The return value is E_INVALIDARG if firstEntryIndex + entryCount is greater than the actual number of palette entries as returned by GetPaletteEntryCount. The return value is DWRITE_E_NOCOLOR if the font does not have a palette with the specified palette index.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPaletteEntries(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("UINT32")] uint colorPaletteIndex,
            [In, NativeTypeName("UINT32")] uint firstEntryIndex,
            [In, NativeTypeName("UINT32")] uint entryCount,
            [Out, NativeTypeName("DWRITE_COLOR_F[]")] DXGI_RGBA* paletteEntries
        );

        /// <summary>Determines the recommended text rendering and grid-fit mode to be used based on the font, size, world transform, and measuring mode.</summary>
        /// <param name="fontEmSize">Logical font size in DIPs.</param>
        /// <param name="dpiX">Number of pixels per logical inch in the horizontal direction.</param>
        /// <param name="dpiY">Number of pixels per logical inch in the vertical direction.</param>
        /// <param name="transform">Specifies the world transform.</param>
        /// <param name="outlineThreshold">Specifies the quality of the graphics system's outline rendering, affects the size threshold above which outline rendering is used.</param>
        /// <param name="measuringMode">Specifies the method used to measure during text layout. For proper glyph spacing, the function returns a rendering mode that is compatible with the specified measuring mode.</param>
        /// <param name="renderingParams">Rendering parameters object. This parameter is necessary in case the rendering parameters object overrides the rendering mode.</param>
        /// <param name="renderingMode">Receives the recommended rendering mode.</param>
        /// <param name="gridFitMode">Receives the recommended grid-fit mode.</param>
        /// <remarks> This method should be used to determine the actual rendering mode in cases where the rendering mode of the rendering params object is DWRITE_RENDERING_MODE_DEFAULT, and the actual grid-fit mode when the rendering params object is DWRITE_GRID_FIT_MODE_DEFAULT.</remarks>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetRecommendedRenderingMode2(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("FLOAT")] float fontEmSize,
            [In, NativeTypeName("FLOAT")] float dpiX,
            [In, NativeTypeName("FLOAT")] float dpiY,
            [In, Optional] DWRITE_MATRIX* transform,
            [In, NativeTypeName("BOOL")] int isSideways,
            [In] DWRITE_OUTLINE_THRESHOLD outlineThreshold,
            [In] DWRITE_MEASURING_MODE measuringMode,
            [In, Optional] IDWriteRenderingParams* renderingParams,
            [Out] DWRITE_RENDERING_MODE* renderingMode,
            [Out] DWRITE_GRID_FIT_MODE* gridFitMode
        );
        #endregion

        #region Delegates
        /// <summary>Return a font face reference identifying this font.</summary>
        /// <param name="fontFaceReference">A uniquely identifying reference to a font face.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontFaceReference(
            [In] IDWriteFontFace3* This,
            [Out] IDWriteFontFaceReference** fontFaceReference
        );

        /// <summary>Gets the PANOSE values from the font, used for font selection and matching.</summary>
        /// <param name="panose">PANOSE public structure to fill in.</param>
        /// <remarks> The function does not simulate these, such as substituting a weight or proportion inferred on other values. If the font does not specify them, they are all set to 'any' (0).</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetPanose(
            [In] IDWriteFontFace3* This,
            [Out] DWRITE_PANOSE* panose
        );

        /// <summary>Gets the weight of the specified font.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_WEIGHT _GetWeight(
            [In] IDWriteFontFace3* This
        );

        /// <summary>Gets the stretch (aka. width) of the specified font.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_STRETCH _GetStretch(
            [In] IDWriteFontFace3* This
        );

        /// <summary>Gets the style (aka. slope) of the specified font.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_STYLE _GetStyle(
            [In] IDWriteFontFace3* This
        );

        /// <summary>Creates an localized strings object that contains the family names for the font family, indexed by locale name.</summary>
        /// <param name="names">Receives a pointer to the newly created localized strings object.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFamilyNames(
            [In] IDWriteFontFace3* This,
            [Out] IDWriteLocalizedStrings** names
        );

        /// <summary>Gets a localized strings collection containing the face names for the font (e.g., Regular or Bold), indexed by locale name.</summary>
        /// <param name="names">Receives a pointer to the newly created localized strings object.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFaceNames(
            [In] IDWriteFontFace3* This,
            [Out] IDWriteLocalizedStrings** names
        );

        /// <summary>Gets a localized strings collection containing the specified informational strings, indexed by locale name.</summary>
        /// <param name="informationalStringID">Identifies the string to get.</param>
        /// <param name="informationalStrings">Receives a pointer to the newly created localized strings object.</param>
        /// <param name="exists">Receives the value TRUE if the font contains the specified string ID or FALSE if not.</param>
        /// <returns> Standard HRESULT error code. If the font does not contain the specified string, the return value is S_OK but informationalStrings receives a NULL pointer and exists receives the value FALSE.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetInformationalStrings(
            [In] IDWriteFontFace3* This,
            [In] DWRITE_INFORMATIONAL_STRING_ID informationalStringID,
            [Out] IDWriteLocalizedStrings** informationalStrings,
            [Out, NativeTypeName("BOOL")] int* exists
        );

        /// <summary>Determines whether the font supports the specified character.</summary>
        /// <param name="unicodeValue">Unicode (UCS-4) character value.</param>
        /// <returns> Returns TRUE if the font has the specified character, FALSE if not.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _HasCharacter(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("UINT32")] uint unicodeValue
        );

        /// <summary>Determines the recommended text rendering and grid-fit mode to be used based on the font, size, world transform, and measuring mode.</summary>
        /// <param name="fontEmSize">Logical font size in DIPs.</param>
        /// <param name="dpiX">Number of pixels per logical inch in the horizontal direction.</param>
        /// <param name="dpiY">Number of pixels per logical inch in the vertical direction.</param>
        /// <param name="transform">Specifies the world transform.</param>
        /// <param name="outlineThreshold">Specifies the quality of the graphics system's outline rendering, affects the size threshold above which outline rendering is used.</param>
        /// <param name="measuringMode">Specifies the method used to measure during text layout. For proper glyph spacing, the function returns a rendering mode that is compatible with the specified measuring mode.</param>
        /// <param name="renderingParams">Rendering parameters object. This parameter is necessary in case the rendering parameters object overrides the rendering mode.</param>
        /// <param name="renderingMode">Receives the recommended rendering mode.</param>
        /// <param name="gridFitMode">Receives the recommended grid-fit mode.</param>
        /// <remarks> This method should be used to determine the actual rendering mode in cases where the rendering mode of the rendering params object is DWRITE_RENDERING_MODE_DEFAULT, and the actual grid-fit mode when the rendering params object is DWRITE_GRID_FIT_MODE_DEFAULT.</remarks>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetRecommendedRenderingMode3(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("FLOAT")] float fontEmSize,
            [In, NativeTypeName("FLOAT")] float dpiX,
            [In, NativeTypeName("FLOAT")] float dpiY,
            [In, Optional] DWRITE_MATRIX* transform,
            [In, NativeTypeName("BOOL")] int isSideways,
            [In] DWRITE_OUTLINE_THRESHOLD outlineThreshold,
            [In] DWRITE_MEASURING_MODE measuringMode,
            [In, Optional] IDWriteRenderingParams* renderingParams,
            [Out] DWRITE_RENDERING_MODE1* renderingMode,
            [Out] DWRITE_GRID_FIT_MODE* gridFitMode
        );

        /// <summary>Determines whether the character is locally downloaded from the font.</summary>
        /// <param name="unicodeValue">Unicode (UCS-4) character value.</param>
        /// <returns> Returns TRUE if the font has the specified character locally available, FALSE if not or if the font does not support that character.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _IsCharacterLocal(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("UINT32")] uint unicodeValue
        );

        /// <summary>Determines whether the glyph is locally downloaded from the font.</summary>
        /// <param name="glyphId">Glyph identifier.</param>
        /// <returns> Returns TRUE if the font has the specified glyph locally available.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _IsGlyphLocal(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("UINT16")] ushort glyphId
        );

        /// <summary>Determines whether the specified characters are local.</summary>
        /// <param name="characters">Array of characters.</param>
        /// <param name="characterCount">The number of elements in the character array.</param>
        /// <param name="enqueueIfNotLocal">Specifies whether to enqueue a download request if any of the specified characters are not local.</param>
        /// <param name="isLocal">Receives TRUE if all of the specified characters are local, FALSE if any of the specified characters are remote.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AreCharactersLocal(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("WCHAR[]")] char* characters,
            [In, NativeTypeName("UINT32")] uint characterCount,
            [In, NativeTypeName("BOOL")] int enqueueIfNotLocal,
            [Out, NativeTypeName("BOOL")] int* isLocal
        );

        /// <summary>Determines whether the specified glyphs are local.</summary>
        /// <param name="glyphIndices">Array of glyph indices.</param>
        /// <param name="glyphCount">The number of elements in the glyph index array.</param>
        /// <param name="enqueueIfNotLocal">Specifies whether to enqueue a download request if any of the specified glyphs are not local.</param>
        /// <param name="isLocal">Receives TRUE if all of the specified glyphs are local, FALSE if any of the specified glyphs are remote.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AreGlyphsLocal(
            [In] IDWriteFontFace3* This,
            [In, NativeTypeName("UINT16[]")] ushort* glyphIndices,
            [In, NativeTypeName("UINT32")] uint glyphCount,
            [In, NativeTypeName("BOOL")] int enqueueIfNotLocal,
            [Out, NativeTypeName("BOOL")] int* isLocal
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region IDWriteFontFace Methods
        public DWRITE_FONT_FACE_TYPE _GetType()
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<__GetType>(lpVtbl->_GetType)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFiles(
            [In, Out, NativeTypeName("UINT32")] uint* numberOfFiles,
            [Out] IDWriteFontFile** fontFiles = null
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetFiles>(lpVtbl->GetFiles)(
                    This,
                    numberOfFiles,
                    fontFiles
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetIndex()
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetIndex>(lpVtbl->GetIndex)(
                    This
                );
            }
        }

        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetSimulations>(lpVtbl->GetSimulations)(
                    This
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsSymbolFont()
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_IsSymbolFont>(lpVtbl->IsSymbolFont)(
                    This
                );
            }
        }

        public void GetMetrics(
            [Out] DWRITE_FONT_METRICS* fontFaceMetrics
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                MarshalFunction<_GetMetrics>(lpVtbl->GetMetrics)(
                    This,
                    fontFaceMetrics
                );
            }
        }

        [return: NativeTypeName("UINT16")]
        public ushort GetGlyphCount()
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetGlyphCount>(lpVtbl->GetGlyphCount)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesignGlyphMetrics(
            [In, NativeTypeName("UINT16[]")] ushort* glyphIndices,
            [In, NativeTypeName("UINT32")] uint glyphCount,
            [Out] DWRITE_GLYPH_METRICS* glyphMetrics,
            [In, NativeTypeName("BOOL")] int isSideways = FALSE
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetDesignGlyphMetrics>(lpVtbl->GetDesignGlyphMetrics)(
                    This,
                    glyphIndices,
                    glyphCount,
                    glyphMetrics,
                    isSideways
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphIndices(
            [In, NativeTypeName("UINT32[]")] uint* codePoints,
            [In, NativeTypeName("UINT32")] uint codePointCount,
            [Out, NativeTypeName("UINT16")] ushort* glyphIndices
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetGlyphIndices>(lpVtbl->GetGlyphIndices)(
                    This,
                    codePoints,
                    codePointCount,
                    glyphIndices
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int TryGetFontTable(
            [In, NativeTypeName("UINT32")] uint openTypeTableTag,
            [Out] void** tableData,
            [Out, NativeTypeName("UINT32")] uint* tableSize,
            [Out] void** tableContext,
            [Out, NativeTypeName("BOOL")] int* exists
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_TryGetFontTable>(lpVtbl->TryGetFontTable)(
                    This,
                    openTypeTableTag,
                    tableData,
                    tableSize,
                    tableContext,
                    exists
                );
            }
        }

        public void ReleaseFontTable(
            [In] void* tableContext
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                MarshalFunction<_ReleaseFontTable>(lpVtbl->ReleaseFontTable)(
                    This,
                    tableContext
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphRunOutline(
            [In, NativeTypeName("FLOAT")] float emSize,
            [In, NativeTypeName("UINT16[]")] ushort* glyphIndices,
            [In, Optional, NativeTypeName("FLOAT[]")] float* glyphAdvances,
            [In, Optional, NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* glyphOffsets,
            [In, NativeTypeName("UINT32")] uint glyphCount,
            [In, NativeTypeName("BOOL")] int isSideways,
            [In, NativeTypeName("BOOL")] int isRightToLeft,
            [In, NativeTypeName("IDWriteGeometrySink")] ID2D1SimplifiedGeometrySink* geometrySink
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetGlyphRunOutline>(lpVtbl->GetGlyphRunOutline)(
                    This,
                    emSize,
                    glyphIndices,
                    glyphAdvances,
                    glyphOffsets,
                    glyphCount,
                    isSideways,
                    isRightToLeft,
                    geometrySink
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode(
            [In, NativeTypeName("FLOAT")] float emSize,
            [In, NativeTypeName("FLOAT")] float pixelsPerDip,
            [In] DWRITE_MEASURING_MODE measuringMode,
            [In] IDWriteRenderingParams* renderingParams,
            [Out] DWRITE_RENDERING_MODE* renderingMode
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetRecommendedRenderingMode>(lpVtbl->GetRecommendedRenderingMode)(
                    This,
                    emSize,
                    pixelsPerDip,
                    measuringMode,
                    renderingParams,
                    renderingMode
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleMetrics(
            [In, NativeTypeName("FLOAT")] float emSize,
            [In, NativeTypeName("FLOAT")] float pixelsPerDip,
            [In, Optional] DWRITE_MATRIX* transform,
            [Out] DWRITE_FONT_METRICS* fontFaceMetrics
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetGdiCompatibleMetrics>(lpVtbl->GetGdiCompatibleMetrics)(
                    This,
                    emSize,
                    pixelsPerDip,
                    transform,
                    fontFaceMetrics
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphMetrics(
            [In, NativeTypeName("FLOAT")] float emSize,
            [In, NativeTypeName("FLOAT")] float pixelsPerDip,
            [In, Optional] DWRITE_MATRIX* transform,
            [In, NativeTypeName("BOOL")] int useGdiNatural,
            [In, NativeTypeName("UINT16[]")] ushort* glyphIndices,
            [In, NativeTypeName("UINT32")] uint glyphCount,
            [Out, NativeTypeName("DWRITE_GLYPH_METRICS[]")] DWRITE_GLYPH_METRICS* glyphMetrics,
            [In, NativeTypeName("BOOL")] int isSideways = FALSE
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetGdiCompatibleGlyphMetrics>(lpVtbl->GetGdiCompatibleGlyphMetrics)(
                    This,
                    emSize,
                    pixelsPerDip,
                    transform,
                    useGdiNatural,
                    glyphIndices,
                    glyphCount,
                    glyphMetrics,
                    isSideways
                );
            }
        }
        #endregion

        #region IDWriteFontFace1 Methods
        public void GetMetrics1(
            [Out] DWRITE_FONT_METRICS1* fontMetrics
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                MarshalFunction<_GetMetrics1>(lpVtbl->GetMetrics1)(
                    This,
                    fontMetrics
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleMetrics1(
            [In, NativeTypeName("FLOAT")] float emSize,
            [In, NativeTypeName("FLOAT")] float pixelsPerDip,
            [In, Optional] DWRITE_MATRIX* transform,
            [Out] DWRITE_FONT_METRICS1* fontMetrics
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetGdiCompatibleMetrics1>(lpVtbl->GetGdiCompatibleMetrics1)(
                    This,
                    emSize,
                    pixelsPerDip,
                    transform,
                    fontMetrics
                );
            }
        }

        public void GetCaretMetrics(
            [Out] DWRITE_CARET_METRICS* caretMetrics
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                MarshalFunction<_GetCaretMetrics>(lpVtbl->GetCaretMetrics)(
                    This,
                    caretMetrics
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnicodeRanges(
            [In, NativeTypeName("UINT32")] uint maxRangeCount,
            [Out, Optional, NativeTypeName("DWRITE_UNICODE_RANGE[]")] DWRITE_UNICODE_RANGE* unicodeRanges,
            [Out, NativeTypeName("UINT32")] uint* actualRangeCount
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetUnicodeRanges>(lpVtbl->GetUnicodeRanges)(
                    This,
                    maxRangeCount,
                    unicodeRanges,
                    actualRangeCount
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsMonospacedFont()
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_IsMonospacedFont>(lpVtbl->IsMonospacedFont)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesignGlyphAdvances(
            [In, NativeTypeName("UINT32")] uint glyphCount,
            [In, NativeTypeName("UINT16[]")] ushort* glyphIndices,
            [Out, NativeTypeName("INT32[]")] int* glyphAdvances,
            [In, NativeTypeName("BOOL")] int isSideways = FALSE
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetDesignGlyphAdvances>(lpVtbl->GetDesignGlyphAdvances)(
                    This,
                    glyphCount,
                    glyphIndices,
                    glyphAdvances,
                    isSideways
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphAdvances(
            [In, NativeTypeName("FLOAT")] float emSize,
            [In, NativeTypeName("FLOAT")] float pixelsPerDip,
            [In, Optional] DWRITE_MATRIX* transform,
            [In, NativeTypeName("BOOL")] int useGdiNatural,
            [In, NativeTypeName("BOOL")] int isSideways,
            [In, NativeTypeName("UINT32")] uint glyphCount,
            [In, NativeTypeName("UINT16[]")] ushort* glyphIndices,
            [Out, NativeTypeName("INT32[]")] int* glyphAdvances
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetGdiCompatibleGlyphAdvances>(lpVtbl->GetGdiCompatibleGlyphAdvances)(
                    This,
                    emSize,
                    pixelsPerDip,
                    transform,
                    useGdiNatural,
                    isSideways,
                    glyphCount,
                    glyphIndices,
                    glyphAdvances
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetKerningPairAdjustments(
            [In, NativeTypeName("UINT32")] uint glyphCount,
            [In, NativeTypeName("UINT16[]")] ushort* glyphIndices,
            [Out, NativeTypeName("INT32[]")] int* glyphAdvanceAdjustments
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetKerningPairAdjustments>(lpVtbl->GetKerningPairAdjustments)(
                    This,
                    glyphCount,
                    glyphIndices,
                    glyphAdvanceAdjustments
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int HasKerningPairs()
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_HasKerningPairs>(lpVtbl->HasKerningPairs)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode1(
            [In, NativeTypeName("FLOAT")] float fontEmSize,
            [In, NativeTypeName("FLOAT")] float dpiX,
            [In, NativeTypeName("FLOAT")] float dpiY,
            [In, Optional] DWRITE_MATRIX* transform,
            [In, NativeTypeName("BOOL")] int isSideways,
            [In] DWRITE_OUTLINE_THRESHOLD outlineThreshold,
            [In] DWRITE_MEASURING_MODE measuringMode,
            [Out] DWRITE_RENDERING_MODE* renderingMode
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetRecommendedRenderingMode1>(lpVtbl->GetRecommendedRenderingMode1)(
                    This,
                    fontEmSize,
                    dpiX,
                    dpiY,
                    transform,
                    isSideways,
                    outlineThreshold,
                    measuringMode,
                    renderingMode
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVerticalGlyphVariants(
            [In, NativeTypeName("UINT32")] uint glyphCount,
            [In, NativeTypeName("UINT16[]")] ushort* nominalGlyphIndices,
            [Out, NativeTypeName("UINT16[]")] ushort* verticalGlyphIndices
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetVerticalGlyphVariants>(lpVtbl->GetVerticalGlyphVariants)(
                    This,
                    glyphCount,
                    nominalGlyphIndices,
                    verticalGlyphIndices
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int HasVerticalGlyphVariants()
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_HasVerticalGlyphVariants>(lpVtbl->HasVerticalGlyphVariants)(
                    This
                );
            }
        }
        #endregion

        #region IDWriteFontFace2 Methods
        [return: NativeTypeName("BOOL")]
        public int IsColorFont()
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_IsColorFont>(lpVtbl->IsColorFont)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetColorPaletteCount()
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetColorPaletteCount>(lpVtbl->GetColorPaletteCount)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPaletteEntryCount()
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetPaletteEntryCount>(lpVtbl->GetPaletteEntryCount)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPaletteEntries(
            [In, NativeTypeName("UINT32")] uint colorPaletteIndex,
            [In, NativeTypeName("UINT32")] uint firstEntryIndex,
            [In, NativeTypeName("UINT32")] uint entryCount,
            [Out, NativeTypeName("DWRITE_COLOR_F[]")] DXGI_RGBA* paletteEntries
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetPaletteEntries>(lpVtbl->GetPaletteEntries)(
                    This,
                    colorPaletteIndex,
                    firstEntryIndex,
                    entryCount,
                    paletteEntries
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode2(
            [In, NativeTypeName("FLOAT")] float fontEmSize,
            [In, NativeTypeName("FLOAT")] float dpiX,
            [In, NativeTypeName("FLOAT")] float dpiY,
            [In, Optional] DWRITE_MATRIX* transform,
            [In, NativeTypeName("BOOL")] int isSideways,
            [In] DWRITE_OUTLINE_THRESHOLD outlineThreshold,
            [In] DWRITE_MEASURING_MODE measuringMode,
            [In, Optional] IDWriteRenderingParams* renderingParams,
            [Out] DWRITE_RENDERING_MODE* renderingMode,
            [Out] DWRITE_GRID_FIT_MODE* gridFitMode
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetRecommendedRenderingMode2>(lpVtbl->GetRecommendedRenderingMode2)(
                    This,
                    fontEmSize,
                    dpiX,
                    dpiY,
                    transform,
                    isSideways,
                    outlineThreshold,
                    measuringMode,
                    renderingParams,
                    renderingMode,
                    gridFitMode
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference(
            [Out] IDWriteFontFaceReference** fontFaceReference
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetFontFaceReference>(lpVtbl->GetFontFaceReference)(
                    This,
                    fontFaceReference
                );
            }
        }

        public void GetPanose(
            [Out] DWRITE_PANOSE* panose
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                MarshalFunction<_GetPanose>(lpVtbl->GetPanose)(
                    This,
                    panose
                );
            }
        }

        public DWRITE_FONT_WEIGHT GetWeight()
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetWeight>(lpVtbl->GetWeight)(
                    This
                );
            }
        }

        public DWRITE_FONT_STRETCH GetStretch()
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetStretch>(lpVtbl->GetStretch)(
                    This
                );
            }
        }

        public DWRITE_FONT_STYLE GetStyle()
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetStyle>(lpVtbl->GetStyle)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFamilyNames(
            [Out] IDWriteLocalizedStrings** names
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetFamilyNames>(lpVtbl->GetFamilyNames)(
                    This,
                    names
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFaceNames(
            [Out] IDWriteLocalizedStrings** names
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetFaceNames>(lpVtbl->GetFaceNames)(
                    This,
                    names
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInformationalStrings(
            [In] DWRITE_INFORMATIONAL_STRING_ID informationalStringID,
            [Out] IDWriteLocalizedStrings** informationalStrings,
            [Out, NativeTypeName("BOOL")] int* exists
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetInformationalStrings>(lpVtbl->GetInformationalStrings)(
                    This,
                    informationalStringID,
                    informationalStrings,
                    exists
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int HasCharacter(
            [In, NativeTypeName("UINT32")] uint unicodeValue
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_HasCharacter>(lpVtbl->HasCharacter)(
                    This,
                    unicodeValue
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode3(
            [In, NativeTypeName("FLOAT")] float fontEmSize,
            [In, NativeTypeName("FLOAT")] float dpiX,
            [In, NativeTypeName("FLOAT")] float dpiY,
            [In, Optional] DWRITE_MATRIX* transform,
            [In, NativeTypeName("BOOL")] int isSideways,
            [In] DWRITE_OUTLINE_THRESHOLD outlineThreshold,
            [In] DWRITE_MEASURING_MODE measuringMode,
            [In, Optional] IDWriteRenderingParams* renderingParams,
            [Out] DWRITE_RENDERING_MODE1* renderingMode,
            [Out] DWRITE_GRID_FIT_MODE* gridFitMode
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_GetRecommendedRenderingMode3>(lpVtbl->GetRecommendedRenderingMode3)(
                    This,
                    fontEmSize,
                    dpiX,
                    dpiY,
                    transform,
                    isSideways,
                    outlineThreshold,
                    measuringMode,
                    renderingParams,
                    renderingMode,
                    gridFitMode
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsCharacterLocal(
            [In, NativeTypeName("UINT32")] uint unicodeValue
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_IsCharacterLocal>(lpVtbl->IsCharacterLocal)(
                    This,
                    unicodeValue
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsGlyphLocal(
            [In, NativeTypeName("UINT16")] ushort glyphId
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_IsGlyphLocal>(lpVtbl->IsGlyphLocal)(
                    This,
                    glyphId
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AreCharactersLocal(
            [In, NativeTypeName("WCHAR[]")] char* characters,
            [In, NativeTypeName("UINT32")] uint characterCount,
            [In, NativeTypeName("BOOL")] int enqueueIfNotLocal,
            [Out, NativeTypeName("BOOL")] int* isLocal
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_AreCharactersLocal>(lpVtbl->AreCharactersLocal)(
                    This,
                    characters,
                    characterCount,
                    enqueueIfNotLocal,
                    isLocal
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AreGlyphsLocal(
            [In, NativeTypeName("UINT16[]")] ushort* glyphIndices,
            [In, NativeTypeName("UINT32")] uint glyphCount,
            [In, NativeTypeName("BOOL")] int enqueueIfNotLocal,
            [Out, NativeTypeName("BOOL")] int* isLocal
        )
        {
            fixed (IDWriteFontFace3* This = &this)
            {
                return MarshalFunction<_AreGlyphsLocal>(lpVtbl->AreGlyphsLocal)(
                    This,
                    glyphIndices,
                    glyphCount,
                    enqueueIfNotLocal,
                    isLocal
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region IDWriteFontFace Fields
            public IntPtr _GetType;

            public IntPtr GetFiles;

            public IntPtr GetIndex;

            public IntPtr GetSimulations;

            public IntPtr IsSymbolFont;

            public IntPtr GetMetrics;

            public IntPtr GetGlyphCount;

            public IntPtr GetDesignGlyphMetrics;

            public IntPtr GetGlyphIndices;

            public IntPtr TryGetFontTable;

            public IntPtr ReleaseFontTable;

            public IntPtr GetGlyphRunOutline;

            public IntPtr GetRecommendedRenderingMode;

            public IntPtr GetGdiCompatibleMetrics;

            public IntPtr GetGdiCompatibleGlyphMetrics;
            #endregion

            #region IDWriteFontFace1 Fields
            public IntPtr GetMetrics1;

            public IntPtr GetGdiCompatibleMetrics1;

            public IntPtr GetCaretMetrics;

            public IntPtr GetUnicodeRanges;

            public IntPtr IsMonospacedFont;

            public IntPtr GetDesignGlyphAdvances;

            public IntPtr GetGdiCompatibleGlyphAdvances;

            public IntPtr GetKerningPairAdjustments;

            public IntPtr HasKerningPairs;

            public IntPtr GetRecommendedRenderingMode1;

            public IntPtr GetVerticalGlyphVariants;

            public IntPtr HasVerticalGlyphVariants;
            #endregion

            #region IDWriteFontFace2 Fields
            public IntPtr IsColorFont;

            public IntPtr GetColorPaletteCount;

            public IntPtr GetPaletteEntryCount;

            public IntPtr GetPaletteEntries;

            public IntPtr GetRecommendedRenderingMode2;
            #endregion

            #region Fields
            public IntPtr GetFontFaceReference;

            public IntPtr GetPanose;

            public IntPtr GetWeight;

            public IntPtr GetStretch;

            public IntPtr GetStyle;

            public IntPtr GetFamilyNames;

            public IntPtr GetFaceNames;

            public IntPtr GetInformationalStrings;

            public IntPtr HasCharacter;

            public IntPtr GetRecommendedRenderingMode3;

            public IntPtr IsCharacterLocal;

            public IntPtr IsGlyphLocal;

            public IntPtr AreCharactersLocal;

            public IntPtr AreGlyphsLocal;
            #endregion
        }
        #endregion
    }
}
