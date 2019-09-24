// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The IDWriteTextRenderer interface represents a set of application-defined callbacks that perform rendering of text, inline objects, and decorations such as underlines.</summary>
    [Guid("EF8A8135-5CC6-45FE-8825-C5A0724EB819")]
    public unsafe struct IDWriteTextRenderer
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IDWriteTextRenderer* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IDWriteTextRenderer* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IDWriteTextRenderer* This
        );

        /// <summary>Determines whether pixel snapping is disabled. The recommended default is FALSE, unless doing animation that requires subpixel vertical placement.</summary>
        /// <param name="clientDrawingContext">The context passed to IDWriteTextLayout::Draw.</param>
        /// <param name="isDisabled">Receives TRUE if pixel snapping is disabled or FALSE if it not.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsPixelSnappingDisabled(
            [In] IDWriteTextRenderer* This,
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
            [In] IDWriteTextRenderer* This,
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
            [In] IDWriteTextRenderer* This,
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
            [In] IDWriteTextRenderer* This,
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
            [In] IDWriteTextRenderer* This,
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
            [In] IDWriteTextRenderer* This,
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
            [In] IDWriteTextRenderer* This,
            [In, Optional] void* clientDrawingContext,
            [In, NativeTypeName("FLOAT")] float originX,
            [In, NativeTypeName("FLOAT")] float originY,
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
            fixed (IDWriteTextRenderer* This = &this)
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
            fixed (IDWriteTextRenderer* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteTextRenderer* This = &this)
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
            fixed (IDWriteTextRenderer* This = &this)
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
            fixed (IDWriteTextRenderer* This = &this)
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
            fixed (IDWriteTextRenderer* This = &this)
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
            fixed (IDWriteTextRenderer* This = &this)
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
            fixed (IDWriteTextRenderer* This = &this)
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
            fixed (IDWriteTextRenderer* This = &this)
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
            fixed (IDWriteTextRenderer* This = &this)
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
        }
    }
}
