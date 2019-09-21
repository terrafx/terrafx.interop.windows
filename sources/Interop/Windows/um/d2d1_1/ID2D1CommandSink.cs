// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>Caller-supplied implementation of an interface to receive the recorded command list.</summary>
    [Guid("54D7898A-A061-40A7-BEC7-E465BCBA2C4F")]
    public unsafe struct ID2D1CommandSink
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1CommandSink* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1CommandSink* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1CommandSink* This
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _BeginDraw(
            [In] ID2D1CommandSink* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _EndDraw(
            [In] ID2D1CommandSink* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetAntialiasMode(
            [In] ID2D1CommandSink* This,
            [In] D2D1_ANTIALIAS_MODE antialiasMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetTags(
            [In] ID2D1CommandSink* This,
            [In, NativeTypeName("D2D1_TAG")] ulong tag1,
            [In, NativeTypeName("D2D1_TAG")] ulong tag2
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetTextAntialiasMode(
            [In] ID2D1CommandSink* This,
            [In] D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetTextRenderingParams(
            [In] ID2D1CommandSink* This,
            [In] IDWriteRenderingParams* textRenderingParams = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetTransform(
            [In] ID2D1CommandSink* This,
            [In, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrimitiveBlend(
            [In] ID2D1CommandSink* This,
            [In] D2D1_PRIMITIVE_BLEND primitiveBlend
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetUnitMode(
            [In] ID2D1CommandSink* This,
            [In] D2D1_UNIT_MODE unitMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Clear(
            [In] ID2D1CommandSink* This,
            [In, NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DrawGlyphRun(
            [In] ID2D1CommandSink* This,
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin,
            [In] DWRITE_GLYPH_RUN* glyphRun,
            [In, Optional] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription,
            [In] ID2D1Brush* foregroundBrush,
            [In] DWRITE_MEASURING_MODE measuringMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DrawLine(
            [In] ID2D1CommandSink* This,
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0,
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1,
            [In] ID2D1Brush* brush,
            [In, NativeTypeName("FLOAT")] float strokeWidth,
            [In] ID2D1StrokeStyle* strokeStyle = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DrawGeometry(
            [In] ID2D1CommandSink* This,
            [In] ID2D1Geometry* geometry,
            [In] ID2D1Brush* brush,
            [In, NativeTypeName("FLOAT")] float strokeWidth,
            [In] ID2D1StrokeStyle* strokeStyle = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DrawRectangle(
            [In] ID2D1CommandSink* This,
            [In, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rect,
            [In] ID2D1Brush* brush,
            [In, NativeTypeName("FLOAT")] float strokeWidth,
            [In] ID2D1StrokeStyle* strokeStyle = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DrawBitmap(
            [In] ID2D1CommandSink* This,
            [In] ID2D1Bitmap* bitmap,
            [In, Optional, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle,
            [In, NativeTypeName("FLOAT")] float opacity,
            [In] D2D1_INTERPOLATION_MODE interpolationMode,
            [In, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null,
            [In, NativeTypeName("D2D1_MATRIX_4X4_F")] D2D_MATRIX_4X4_F* perspectiveTransform = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DrawImage(
            [In] ID2D1CommandSink* This,
            [In] ID2D1Image* image,
            [In, Optional, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* targetOffset,
            [In, Optional, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* imageRectangle,
            [In] D2D1_INTERPOLATION_MODE interpolationMode,
            [In] D2D1_COMPOSITE_MODE compositeMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DrawGdiMetafile(
            [In] ID2D1CommandSink* This,
            [In] ID2D1GdiMetafile* gdiMetafile,
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* targetOffset = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _FillMesh(
            [In] ID2D1CommandSink* This,
            [In] ID2D1Mesh* mesh,
            [In] ID2D1Brush* brush
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _FillOpacityMask(
            [In] ID2D1CommandSink* This,
            [In] ID2D1Bitmap* opacityMask,
            [In] ID2D1Brush* brush,
            [In, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle = null,
            [In, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _FillGeometry(
            [In] ID2D1CommandSink* This,
            [In] ID2D1Geometry* geometry,
            [In] ID2D1Brush* brush,
            [In] ID2D1Brush* opacityBrush = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _FillRectangle(
            [In] ID2D1CommandSink* This,
            [In, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rect,
            [In] ID2D1Brush* brush
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PushAxisAlignedClip(
            [In] ID2D1CommandSink* This,
            [In, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* clipRect,
            [In] D2D1_ANTIALIAS_MODE antialiasMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PushLayer(
            [In] ID2D1CommandSink* This,
            [In] D2D1_LAYER_PARAMETERS1* layerParameters1,
            [In] ID2D1Layer* layer = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PopAxisAlignedClip(
            [In] ID2D1CommandSink* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PopLayer(
            [In] ID2D1CommandSink* This
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1CommandSink* This = &this)
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
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int BeginDraw()
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_BeginDraw>(lpVtbl->BeginDraw)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EndDraw()
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EndDraw>(lpVtbl->EndDraw)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAntialiasMode(
            [In] D2D1_ANTIALIAS_MODE antialiasMode
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetAntialiasMode>(lpVtbl->SetAntialiasMode)(
                    This,
                    antialiasMode
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTags(
            [In, NativeTypeName("D2D1_TAG")] ulong tag1,
            [In, NativeTypeName("D2D1_TAG")] ulong tag2
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetTags>(lpVtbl->SetTags)(
                    This,
                    tag1,
                    tag2
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextAntialiasMode(
            [In] D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetTextAntialiasMode>(lpVtbl->SetTextAntialiasMode)(
                    This,
                    textAntialiasMode
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextRenderingParams(
            [In] IDWriteRenderingParams* textRenderingParams = null
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetTextRenderingParams>(lpVtbl->SetTextRenderingParams)(
                    This,
                    textRenderingParams
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransform(
            [In, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetTransform>(lpVtbl->SetTransform)(
                    This,
                    transform
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrimitiveBlend(
            [In] D2D1_PRIMITIVE_BLEND primitiveBlend
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrimitiveBlend>(lpVtbl->SetPrimitiveBlend)(
                    This,
                    primitiveBlend
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUnitMode(
            [In] D2D1_UNIT_MODE unitMode
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetUnitMode>(lpVtbl->SetUnitMode)(
                    This,
                    unitMode
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Clear(
            [In, NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color = null
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Clear>(lpVtbl->Clear)(
                    This,
                    color
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawGlyphRun(
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin,
            [In] DWRITE_GLYPH_RUN* glyphRun,
            [In, Optional] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription,
            [In] ID2D1Brush* foregroundBrush,
            [In] DWRITE_MEASURING_MODE measuringMode
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DrawGlyphRun>(lpVtbl->DrawGlyphRun)(
                    This,
                    baselineOrigin,
                    glyphRun,
                    glyphRunDescription,
                    foregroundBrush,
                    measuringMode
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawLine(
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0,
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1,
            [In] ID2D1Brush* brush,
            [In, NativeTypeName("FLOAT")] float strokeWidth,
            [In] ID2D1StrokeStyle* strokeStyle = null
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DrawLine>(lpVtbl->DrawLine)(
                    This,
                    point0,
                    point1,
                    brush,
                    strokeWidth,
                    strokeStyle
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawGeometry(
            [In] ID2D1Geometry* geometry,
            [In] ID2D1Brush* brush,
            [In, NativeTypeName("FLOAT")] float strokeWidth,
            [In] ID2D1StrokeStyle* strokeStyle = null
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DrawGeometry>(lpVtbl->DrawGeometry)(
                    This,
                    geometry,
                    brush,
                    strokeWidth,
                    strokeStyle
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawRectangle(
            [In, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rect,
            [In] ID2D1Brush* brush,
            [In, NativeTypeName("FLOAT")] float strokeWidth,
            [In] ID2D1StrokeStyle* strokeStyle = null
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DrawRectangle>(lpVtbl->DrawRectangle)(
                    This,
                    rect,
                    brush,
                    strokeWidth,
                    strokeStyle
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawBitmap(
            [In] ID2D1Bitmap* bitmap,
            [In, Optional, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle,
            [In, NativeTypeName("FLOAT")] float opacity,
            [In] D2D1_INTERPOLATION_MODE interpolationMode,
            [In, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null,
            [In, NativeTypeName("D2D1_MATRIX_4X4_F")] D2D_MATRIX_4X4_F* perspectiveTransform = null
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DrawBitmap>(lpVtbl->DrawBitmap)(
                    This,
                    bitmap,
                    destinationRectangle,
                    opacity,
                    interpolationMode,
                    sourceRectangle,
                    perspectiveTransform
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawImage(
            [In] ID2D1Image* image,
            [In, Optional, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* targetOffset,
            [In, Optional, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* imageRectangle,
            [In] D2D1_INTERPOLATION_MODE interpolationMode,
            [In] D2D1_COMPOSITE_MODE compositeMode
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DrawImage>(lpVtbl->DrawImage)(
                    This,
                    image,
                    targetOffset,
                    imageRectangle,
                    interpolationMode,
                    compositeMode
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawGdiMetafile(
            [In] ID2D1GdiMetafile* gdiMetafile,
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* targetOffset = null
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DrawGdiMetafile>(lpVtbl->DrawGdiMetafile)(
                    This,
                    gdiMetafile,
                    targetOffset
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FillMesh(
            [In] ID2D1Mesh* mesh,
            [In] ID2D1Brush* brush
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FillMesh>(lpVtbl->FillMesh)(
                    This,
                    mesh,
                    brush
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FillOpacityMask(
            [In] ID2D1Bitmap* opacityMask,
            [In] ID2D1Brush* brush,
            [In, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle = null,
            [In, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FillOpacityMask>(lpVtbl->FillOpacityMask)(
                    This,
                    opacityMask,
                    brush,
                    destinationRectangle,
                    sourceRectangle
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FillGeometry(
            [In] ID2D1Geometry* geometry,
            [In] ID2D1Brush* brush,
            [In] ID2D1Brush* opacityBrush = null
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FillGeometry>(lpVtbl->FillGeometry)(
                    This,
                    geometry,
                    brush,
                    opacityBrush
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FillRectangle(
            [In, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rect,
            [In] ID2D1Brush* brush
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FillRectangle>(lpVtbl->FillRectangle)(
                    This,
                    rect,
                    brush
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushAxisAlignedClip(
            [In, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* clipRect,
            [In] D2D1_ANTIALIAS_MODE antialiasMode
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushAxisAlignedClip>(lpVtbl->PushAxisAlignedClip)(
                    This,
                    clipRect,
                    antialiasMode
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushLayer(
            [In] D2D1_LAYER_PARAMETERS1* layerParameters1,
            [In] ID2D1Layer* layer = null
        )
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushLayer>(lpVtbl->PushLayer)(
                    This,
                    layerParameters1,
                    layer
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PopAxisAlignedClip()
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PopAxisAlignedClip>(lpVtbl->PopAxisAlignedClip)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PopLayer()
        {
            fixed (ID2D1CommandSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PopLayer>(lpVtbl->PopLayer)(
                    This
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

            #region Fields
            public IntPtr BeginDraw;

            public IntPtr EndDraw;

            public IntPtr SetAntialiasMode;

            public IntPtr SetTags;

            public IntPtr SetTextAntialiasMode;

            public IntPtr SetTextRenderingParams;

            public IntPtr SetTransform;

            public IntPtr SetPrimitiveBlend;

            public IntPtr SetUnitMode;

            public IntPtr Clear;

            public IntPtr DrawGlyphRun;

            public IntPtr DrawLine;

            public IntPtr DrawGeometry;

            public IntPtr DrawRectangle;

            public IntPtr DrawBitmap;

            public IntPtr DrawImage;

            public IntPtr DrawGdiMetafile;

            public IntPtr FillMesh;

            public IntPtr FillOpacityMask;

            public IntPtr FillGeometry;

            public IntPtr FillRectangle;

            public IntPtr PushAxisAlignedClip;

            public IntPtr PushLayer;

            public IntPtr PopAxisAlignedClip;

            public IntPtr PopLayer;
            #endregion
        }
        #endregion
    }
}
