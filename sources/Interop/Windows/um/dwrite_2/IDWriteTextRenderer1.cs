// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The text renderer interface represents a set of application-defined callbacks that perform rendering of text, inline objects, and decorations such as underlines.</summary>
    [Guid("D3E0E934-22A0-427E-AAE4-7D9574B59DB1")]
    public unsafe struct IDWriteTextRenderer1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IDWriteTextRenderer1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IDWriteTextRenderer1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IDWriteTextRenderer1* This
        );

        /// <summary>Determines whether pixel snapping is disabled. The recommended default is FALSE, unless doing animation that requires subpixel vertical placement.</summary>
        /// <param name="clientDrawingContext">The context passed to IDWriteTextLayout::Draw.</param>
        /// <param name="isDisabled">Receives TRUE if pixel snapping is disabled or FALSE if it not.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsPixelSnappingDisabled(
            [In] IDWriteTextRenderer1* This,
            [In, Optional] void* clientDrawingContext,
            [Out, NativeTypeName("BOOL")] int* isDisabled
        );

        /// <summary>Gets the current transform that maps abstract coordinates to DIPs, which may disable pixel snapping upon any rotation or shear.</summary>
        /// <param name="clientDrawingContext">The context passed to IDWriteTextLayout::Draw.</param>
        /// <param name="transform">Receives the transform.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentTransform(
            [In] IDWriteTextRenderer1* This,
            [In, Optional] void* clientDrawingContext,
            [Out] DWRITE_MATRIX* transform
        );

        /// <summary>Gets the number of physical pixels per DIP. A DIP (device-independent pixel) is 1/96 inch, so the pixelsPerDip value is the number of logical pixels per inch divided by 96 (yielding a value of 1 for 96 DPI and 1.25 for 120).</summary>
        /// <param name="clientDrawingContext">The context passed to IDWriteTextLayout::Draw.</param>
        /// <param name="pixelsPerDip">Receives the number of physical pixels per DIP.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPixelsPerDip(
            [In] IDWriteTextRenderer1* This,
            [In, Optional] void* clientDrawingContext,
            [Out, NativeTypeName("FLOAT")] float* pixelsPerDip
        );

        /// <summary>IDWriteTextLayout::Draw calls this function to instruct the client to render a run of glyphs.</summary>
        /// <param name="clientDrawingContext">The context passed to IDWriteTextLayout::Draw.</param>
        /// <param name="baselineOriginX">X-coordinate of the baseline.</param>
        /// <param name="baselineOriginY">Y-coordinate of the baseline.</param>
        /// <param name="measuringMode">Specifies measuring mode for glyphs in the run. Renderer implementations may choose different rendering modes for given measuring modes, but best results are seen when the rendering mode matches the corresponding measuring mode: DWRITE_RENDERING_MODE_CLEARTYPE_NATURAL for DWRITE_MEASURING_MODE_NATURAL DWRITE_RENDERING_MODE_CLEARTYPE_GDI_CLASSIC for DWRITE_MEASURING_MODE_GDI_CLASSIC DWRITE_RENDERING_MODE_CLEARTYPE_GDI_NATURAL for DWRITE_MEASURING_MODE_GDI_NATURAL</param>
        /// <param name="glyphRun">The glyph run to draw.</param>
        /// <param name="glyphRunDescription">Properties of the characters associated with this run.</param>
        /// <param name="clientDrawingEffect">The drawing effect set in IDWriteTextLayout::SetDrawingEffect.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawGlyphRun(
            [In] IDWriteTextRenderer1* This,
            [In, Optional] void* clientDrawingContext,
            [In, NativeTypeName("FLOAT")] float baselineOriginX,
            [In, NativeTypeName("FLOAT")] float baselineOriginY,
            [In] DWRITE_MEASURING_MODE measuringMode,
            [In] DWRITE_GLYPH_RUN* glyphRun,
            [In] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription,
            [In] IUnknown* clientDrawingEffect = null
        );

        /// <summary>IDWriteTextLayout::Draw calls this function to instruct the client to draw an underline.</summary>
        /// <param name="clientDrawingContext">The context passed to IDWriteTextLayout::Draw.</param>
        /// <param name="baselineOriginX">X-coordinate of the baseline.</param>
        /// <param name="baselineOriginY">Y-coordinate of the baseline.</param>
        /// <param name="underline">Underline logical information.</param>
        /// <param name="clientDrawingEffect">The drawing effect set in IDWriteTextLayout::SetDrawingEffect.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> A single underline can be broken into multiple calls, depending on how the formatting changes attributes. If font sizes/styles change within an underline, the thickness and offset will be averaged weighted according to characters. To get the correct top coordinate of the underline rect, add underline::offset to the baseline's Y. Otherwise the underline will be immediately under the text. The x coordinate will always be passed as the left side, regardless of text directionality. This simplifies drawing and reduces the problem of round-off that could potentially cause gaps or a double stamped alpha blend. To avoid alpha overlap, round the end points to the nearest device pixel.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawUnderline(
            [In] IDWriteTextRenderer1* This,
            [In, Optional] void* clientDrawingContext,
            [In, NativeTypeName("FLOAT")] float baselineOriginX,
            [In, NativeTypeName("FLOAT")] float baselineOriginY,
            [In] DWRITE_UNDERLINE* underline,
            [In] IUnknown* clientDrawingEffect = null
        );

        /// <summary>IDWriteTextLayout::Draw calls this function to instruct the client to draw a strikethrough.</summary>
        /// <param name="clientDrawingContext">The context passed to IDWriteTextLayout::Draw.</param>
        /// <param name="baselineOriginX">X-coordinate of the baseline.</param>
        /// <param name="baselineOriginY">Y-coordinate of the baseline.</param>
        /// <param name="strikethrough">Strikethrough logical information.</param>
        /// <param name="clientDrawingEffect">The drawing effect set in IDWriteTextLayout::SetDrawingEffect.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> A single strikethrough can be broken into multiple calls, depending on how the formatting changes attributes. Strikethrough is not averaged across font sizes/styles changes. To get the correct top coordinate of the strikethrough rect, add strikethrough::offset to the baseline's Y. Like underlines, the x coordinate will always be passed as the left side, regardless of text directionality.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawStrikethrough(
            [In] IDWriteTextRenderer1* This,
            [In, Optional] void* clientDrawingContext,
            [In, NativeTypeName("FLOAT")] float baselineOriginX,
            [In, NativeTypeName("FLOAT")] float baselineOriginY,
            [In] DWRITE_STRIKETHROUGH* strikethrough,
            [In] IUnknown* clientDrawingEffect = null
        );

        /// <summary>IDWriteTextLayout::Draw calls this application callback when it needs to draw an inline object.</summary>
        /// <param name="clientDrawingContext">The context passed to IDWriteTextLayout::Draw.</param>
        /// <param name="originX">X-coordinate at the top-left corner of the inline object.</param>
        /// <param name="originY">Y-coordinate at the top-left corner of the inline object.</param>
        /// <param name="inlineObject">The object set using IDWriteTextLayout::SetInlineObject.</param>
        /// <param name="isSideways">The object should be drawn on its side.</param>
        /// <param name="isRightToLeft">The object is in an right-to-left context and should be drawn flipped.</param>
        /// <param name="clientDrawingEffect">The drawing effect set in IDWriteTextLayout::SetDrawingEffect.</param>
        /// <returns>Standard HRESULT error code.</returns>
        /// <remarks> The right-to-left flag is a hint for those cases where it would look strange for the image to be shown normally (like an arrow pointing to right to indicate a submenu).</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawInlineObject(
            [In] IDWriteTextRenderer1* This,
            [In, Optional] void* clientDrawingContext,
            [In, NativeTypeName("FLOAT")] float originX,
            [In, NativeTypeName("FLOAT")] float originY,
            [In] IDWriteInlineObject* inlineObject,
            [In, NativeTypeName("BOOL")] int isSideways,
            [In, NativeTypeName("BOOL")] int isRightToLeft,
            [In] IUnknown* clientDrawingEffect = null
        );

        /// <summary>IDWriteTextLayout::Draw calls this function to instruct the client to render a run of glyphs.</summary>
        /// <param name="clientDrawingContext">The context passed to IDWriteTextLayout::Draw.</param>
        /// <param name="baselineOriginX">X-coordinate of the baseline.</param>
        /// <param name="baselineOriginY">Y-coordinate of the baseline.</param>
        /// <param name="orientationAngle">Orientation of the glyph run.</param>
        /// <param name="measuringMode">Specifies measuring method for glyphs in the run. Renderer implementations may choose different rendering modes for given measuring methods, but best results are seen when the rendering mode matches the corresponding measuring mode: DWRITE_RENDERING_MODE_CLEARTYPE_NATURAL for DWRITE_MEASURING_MODE_NATURAL DWRITE_RENDERING_MODE_CLEARTYPE_GDI_CLASSIC for DWRITE_MEASURING_MODE_GDI_CLASSIC DWRITE_RENDERING_MODE_CLEARTYPE_GDI_NATURAL for DWRITE_MEASURING_MODE_GDI_NATURAL</param>
        /// <param name="glyphRun">The glyph run to draw.</param>
        /// <param name="glyphRunDescription">Properties of the characters associated with this run.</param>
        /// <param name="clientDrawingEffect">The drawing effect set in IDWriteTextLayout::SetDrawingEffect.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> If a non-identity orientation is passed, the glyph run should be rotated around the given baseline x and y coordinates. The function IDWriteAnalyzer2::GetGlyphOrientationTransform will return the necessary transform for you, which can be combined with any existing world transform on the drawing context.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawGlyphRun1(
            [In] IDWriteTextRenderer1* This,
            [In, Optional] void* clientDrawingContext,
            [In, NativeTypeName("FLOAT")] float baselineOriginX,
            [In, NativeTypeName("FLOAT")] float baselineOriginY,
            [In] DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle,
            [In] DWRITE_MEASURING_MODE measuringMode,
            [In] DWRITE_GLYPH_RUN* glyphRun,
            [In] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription,
            [In] IUnknown* clientDrawingEffect = null
        );

        /// <summary>IDWriteTextLayout::Draw calls this function to instruct the client to draw an underline.</summary>
        /// <param name="clientDrawingContext">The context passed to IDWriteTextLayout::Draw.</param>
        /// <param name="baselineOriginX">X-coordinate of the baseline.</param>
        /// <param name="baselineOriginY">Y-coordinate of the baseline.</param>
        /// <param name="orientationAngle">Orientation of the underline.</param>
        /// <param name="underline">Underline logical information.</param>
        /// <param name="clientDrawingEffect">The drawing effect set in IDWriteTextLayout::SetDrawingEffect.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> A single underline can be broken into multiple calls, depending on how the formatting changes attributes. If font sizes/styles change within an underline, the thickness and offset will be averaged weighted according to characters.
        /// To get the correct top coordinate of the underline rect, add underline::offset to the baseline's Y. Otherwise the underline will be immediately under the text. The x coordinate will always be passed as the left side, regardless of text directionality. This simplifies drawing and reduces the problem of round-off that could potentially cause gaps or a double stamped alpha blend. To avoid alpha overlap, round the end points to the nearest device pixel.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawUnderline1(
            [In] IDWriteTextRenderer1* This,
            [In, Optional] void* clientDrawingContext,
            [In, NativeTypeName("FLOAT")] float baselineOriginX,
            [In, NativeTypeName("FLOAT")] float baselineOriginY,
            [In] DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle,
            [In] DWRITE_UNDERLINE* underline,
            [In] IUnknown* clientDrawingEffect = null
        );

        /// <summary>IDWriteTextLayout::Draw calls this function to instruct the client to draw a strikethrough.</summary>
        /// <param name="clientDrawingContext">The context passed to IDWriteTextLayout::Draw.</param>
        /// <param name="baselineOriginX">X-coordinate of the baseline.</param>
        /// <param name="baselineOriginY">Y-coordinate of the baseline.</param>
        /// <param name="orientationAngle">Orientation of the strikethrough.</param>
        /// <param name="strikethrough">Strikethrough logical information.</param>
        /// <param name="clientDrawingEffect">The drawing effect set in IDWriteTextLayout::SetDrawingEffect.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> A single strikethrough can be broken into multiple calls, depending on how the formatting changes attributes. Strikethrough is not averaged across font sizes/styles changes. To get the correct top coordinate of the strikethrough rect, add strikethrough::offset to the baseline's Y. Like underlines, the x coordinate will always be passed as the left side, regardless of text directionality.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawStrikethrough1(
            [In] IDWriteTextRenderer1* This,
            [In, Optional] void* clientDrawingContext,
            [In, NativeTypeName("FLOAT")] float baselineOriginX,
            [In, NativeTypeName("FLOAT")] float baselineOriginY,
            [In] DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle,
            [In] DWRITE_STRIKETHROUGH* strikethrough,
            [In] IUnknown* clientDrawingEffect = null
        );

        /// <summary>IDWriteTextLayout::Draw calls this application callback when it needs to draw an inline object.</summary>
        /// <param name="clientDrawingContext">The context passed to IDWriteTextLayout::Draw.</param>
        /// <param name="originX">X-coordinate at the top-left corner of the inline object.</param>
        /// <param name="originY">Y-coordinate at the top-left corner of the inline object.</param>
        /// <param name="orientationAngle">Orientation of the inline object.</param>
        /// <param name="inlineObject">The object set using IDWriteTextLayout::SetInlineObject.</param>
        /// <param name="isSideways">The object should be drawn on its side.</param>
        /// <param name="isRightToLeft">The object is in an right-to-left context and should be drawn flipped.</param>
        /// <param name="clientDrawingEffect">The drawing effect set in IDWriteTextLayout::SetDrawingEffect.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> The right-to-left flag is a hint to draw the appropriate visual for that reading direction. For example, it would look strange to draw an arrow pointing to the right to indicate a submenu. The sideways flag similarly hints that the object is drawn in a different orientation. If a non-identity orientation is passed, the top left of the inline object should be rotated around the given x and y coordinates. IDWriteAnalyzer2::GetGlyphOrientationTransform returns the necessary transform for this.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawInlineObject1(
            [In] IDWriteTextRenderer1* This,
            [In, Optional] void* clientDrawingContext,
            [In, NativeTypeName("FLOAT")] float originX,
            [In, NativeTypeName("FLOAT")] float originY,
            [In] DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle,
            [In] IDWriteInlineObject* inlineObject,
            [In, NativeTypeName("BOOL")] int isSideways,
            [In, NativeTypeName("BOOL")] int isRightToLeft,
            [In] IUnknown* clientDrawingEffect = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteTextRenderer1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteTextRenderer1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteTextRenderer1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int IsPixelSnappingDisabled(
            [In, Optional] void* clientDrawingContext,
            [Out, NativeTypeName("BOOL")] int* isDisabled
        )
        {
            fixed (IDWriteTextRenderer1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsPixelSnappingDisabled>(lpVtbl->IsPixelSnappingDisabled)(
                    This,
                    clientDrawingContext,
                    isDisabled
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentTransform(
            [In, Optional] void* clientDrawingContext,
            [Out] DWRITE_MATRIX* transform
        )
        {
            fixed (IDWriteTextRenderer1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCurrentTransform>(lpVtbl->GetCurrentTransform)(
                    This,
                    clientDrawingContext,
                    transform
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelsPerDip(
            [In, Optional] void* clientDrawingContext,
            [Out, NativeTypeName("FLOAT")] float* pixelsPerDip
        )
        {
            fixed (IDWriteTextRenderer1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPixelsPerDip>(lpVtbl->GetPixelsPerDip)(
                    This,
                    clientDrawingContext,
                    pixelsPerDip
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawGlyphRun(
            [In, Optional] void* clientDrawingContext,
            [In, NativeTypeName("FLOAT")] float baselineOriginX,
            [In, NativeTypeName("FLOAT")] float baselineOriginY,
            [In] DWRITE_MEASURING_MODE measuringMode,
            [In] DWRITE_GLYPH_RUN* glyphRun,
            [In] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription,
            [In] IUnknown* clientDrawingEffect = null
        )
        {
            fixed (IDWriteTextRenderer1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DrawGlyphRun>(lpVtbl->DrawGlyphRun)(
                    This,
                    clientDrawingContext,
                    baselineOriginX,
                    baselineOriginY,
                    measuringMode,
                    glyphRun,
                    glyphRunDescription,
                    clientDrawingEffect
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawUnderline(
            [In, Optional] void* clientDrawingContext,
            [In, NativeTypeName("FLOAT")] float baselineOriginX,
            [In, NativeTypeName("FLOAT")] float baselineOriginY,
            [In] DWRITE_UNDERLINE* underline,
            [In] IUnknown* clientDrawingEffect = null
        )
        {
            fixed (IDWriteTextRenderer1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DrawUnderline>(lpVtbl->DrawUnderline)(
                    This,
                    clientDrawingContext,
                    baselineOriginX,
                    baselineOriginY,
                    underline,
                    clientDrawingEffect
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawStrikethrough(
            [In, Optional] void* clientDrawingContext,
            [In, NativeTypeName("FLOAT")] float baselineOriginX,
            [In, NativeTypeName("FLOAT")] float baselineOriginY,
            [In] DWRITE_STRIKETHROUGH* strikethrough,
            [In] IUnknown* clientDrawingEffect = null
        )
        {
            fixed (IDWriteTextRenderer1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DrawStrikethrough>(lpVtbl->DrawStrikethrough)(
                    This,
                    clientDrawingContext,
                    baselineOriginX,
                    baselineOriginY,
                    strikethrough,
                    clientDrawingEffect
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawInlineObject(
            [In, Optional] void* clientDrawingContext,
            [In, NativeTypeName("FLOAT")] float originX,
            [In, NativeTypeName("FLOAT")] float originY,
            [In] IDWriteInlineObject* inlineObject,
            [In, NativeTypeName("BOOL")] int isSideways,
            [In, NativeTypeName("BOOL")] int isRightToLeft,
            [In] IUnknown* clientDrawingEffect = null
        )
        {
            fixed (IDWriteTextRenderer1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DrawInlineObject>(lpVtbl->DrawInlineObject)(
                    This,
                    clientDrawingContext,
                    originX,
                    originY,
                    inlineObject,
                    isSideways,
                    isRightToLeft,
                    clientDrawingEffect
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawGlyphRun1(
            [In, Optional] void* clientDrawingContext,
            [In, NativeTypeName("FLOAT")] float baselineOriginX,
            [In, NativeTypeName("FLOAT")] float baselineOriginY,
            [In] DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle,
            [In] DWRITE_MEASURING_MODE measuringMode,
            [In] DWRITE_GLYPH_RUN* glyphRun,
            [In] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription,
            [In] IUnknown* clientDrawingEffect = null
        )
        {
            fixed (IDWriteTextRenderer1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DrawGlyphRun1>(lpVtbl->DrawGlyphRun1)(
                    This,
                    clientDrawingContext,
                    baselineOriginX,
                    baselineOriginY,
                    orientationAngle,
                    measuringMode,
                    glyphRun,
                    glyphRunDescription,
                    clientDrawingEffect
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawUnderline1(
            [In, Optional] void* clientDrawingContext,
            [In, NativeTypeName("FLOAT")] float baselineOriginX,
            [In, NativeTypeName("FLOAT")] float baselineOriginY,
            [In] DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle,
            [In] DWRITE_UNDERLINE* underline,
            [In] IUnknown* clientDrawingEffect = null
        )
        {
            fixed (IDWriteTextRenderer1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DrawUnderline1>(lpVtbl->DrawUnderline1)(
                    This,
                    clientDrawingContext,
                    baselineOriginX,
                    baselineOriginY,
                    orientationAngle,
                    underline,
                    clientDrawingEffect
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawStrikethrough1(
            [In, Optional] void* clientDrawingContext,
            [In, NativeTypeName("FLOAT")] float baselineOriginX,
            [In, NativeTypeName("FLOAT")] float baselineOriginY,
            [In] DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle,
            [In] DWRITE_STRIKETHROUGH* strikethrough,
            [In] IUnknown* clientDrawingEffect = null
        )
        {
            fixed (IDWriteTextRenderer1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DrawStrikethrough1>(lpVtbl->DrawStrikethrough1)(
                    This,
                    clientDrawingContext,
                    baselineOriginX,
                    baselineOriginY,
                    orientationAngle,
                    strikethrough,
                    clientDrawingEffect
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawInlineObject1(
            [In, Optional] void* clientDrawingContext,
            [In, NativeTypeName("FLOAT")] float originX,
            [In, NativeTypeName("FLOAT")] float originY,
            [In] DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle,
            [In] IDWriteInlineObject* inlineObject,
            [In, NativeTypeName("BOOL")] int isSideways,
            [In, NativeTypeName("BOOL")] int isRightToLeft,
            [In] IUnknown* clientDrawingEffect = null
        )
        {
            fixed (IDWriteTextRenderer1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DrawInlineObject1>(lpVtbl->DrawInlineObject1)(
                    This,
                    clientDrawingContext,
                    originX,
                    originY,
                    orientationAngle,
                    inlineObject,
                    isSideways,
                    isRightToLeft,
                    clientDrawingEffect
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr IsPixelSnappingDisabled;

            public IntPtr GetCurrentTransform;

            public IntPtr GetPixelsPerDip;

            public IntPtr DrawGlyphRun;

            public IntPtr DrawUnderline;

            public IntPtr DrawStrikethrough;

            public IntPtr DrawInlineObject;

            public IntPtr DrawGlyphRun1;

            public IntPtr DrawUnderline1;

            public IntPtr DrawStrikethrough1;

            public IntPtr DrawInlineObject1;
        }
    }
}
