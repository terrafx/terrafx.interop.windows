// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>The root factory interface for all of D2D's objects.</summary>
    [Guid("06152247-6F50-465A-9245-118BFD3B6007")]
    public unsafe struct ID2D1Factory
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1Factory* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1Factory* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1Factory* This
        );

        /// <summary>Cause the factory to refresh any system metrics that it might have been snapped on factory creation.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ReloadSystemMetrics(
            [In] ID2D1Factory* This
        );

        /// <summary>Retrieves the current desktop DPI. To refresh this, call ReloadSystemMetrics.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetDesktopDpi(
            [In] ID2D1Factory* This,
            [Out, NativeTypeName("FLOAT")] float* dpiX,
            [Out, NativeTypeName("FLOAT")] float* dpiY
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateRectangleGeometry(
            [In] ID2D1Factory* This,
            [In, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rectangle,
            [Out] ID2D1RectangleGeometry** rectangleGeometry
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateRoundedRectangleGeometry(
            [In] ID2D1Factory* This,
            [In] D2D1_ROUNDED_RECT* roundedRectangle,
            [Out] ID2D1RoundedRectangleGeometry** roundedRectangleGeometry
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateEllipseGeometry(
            [In] ID2D1Factory* This,
            [In] D2D1_ELLIPSE* ellipse,
            [Out] ID2D1EllipseGeometry** ellipseGeometry
        );

        /// <summary>Create a geometry which holds other geometries.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateGeometryGroup(
            [In] ID2D1Factory* This,
            [In] D2D1_FILL_MODE fillMode,
            [In, NativeTypeName("ID2D1Geometry*[]")] ID2D1Geometry** geometries,
            [In, NativeTypeName("UINT32")] uint geometriesCount,
            [Out] ID2D1GeometryGroup** geometryGroup
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateTransformedGeometry(
            [In] ID2D1Factory* This,
            [In] ID2D1Geometry* sourceGeometry,
            [In, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform,
            [Out] ID2D1TransformedGeometry** transformedGeometry
        );

        /// <summary>Returns an initially empty path geometry interface. A geometry sink is created off the interface to populate it.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreatePathGeometry(
            [In] ID2D1Factory* This,
            [Out] ID2D1PathGeometry** pathGeometry
        );

        /// <summary>Allows a non-default stroke style to be specified for a given geometry at draw time.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateStrokeStyle(
            [In] ID2D1Factory* This,
            [In] D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties,
            [In, Optional, NativeTypeName("FLOAT[]")] float* dashes,
            [In, NativeTypeName("UINT32")] uint dashesCount,
            [Out] ID2D1StrokeStyle** strokeStyle
        );

        /// <summary>Creates a new drawing state block, this can be used in subsequent SaveDrawingState and RestoreDrawingState operations on the render target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDrawingStateBlock(
            [In] ID2D1Factory* This,
            [In, Optional] D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription,
            [In, Optional] IDWriteRenderingParams* textRenderingParams,
            [Out] ID2D1DrawingStateBlock** drawingStateBlock
        );

        /// <summary>Creates a render target which is a source of bitmaps.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateWicBitmapRenderTarget(
            [In] ID2D1Factory* This,
            [In] IWICBitmap* target,
            [In] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
            [Out] ID2D1RenderTarget** renderTarget
        );

        /// <summary>Creates a render target that appears on the display.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateHwndRenderTarget(
            [In] ID2D1Factory* This,
            [In] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
            [In] D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties,
            [Out] ID2D1HwndRenderTarget** hwndRenderTarget
        );

        /// <summary>Creates a render target that draws to a DXGI Surface. The device that owns the surface is used for rendering.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDxgiSurfaceRenderTarget(
            [In] ID2D1Factory* This,
            [In] IDXGISurface* dxgiSurface,
            [In] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
            [Out] ID2D1RenderTarget** renderTarget
        );

        /// <summary>Creates a render target that draws to a GDI device context.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDCRenderTarget(
            [In] ID2D1Factory* This,
            [In] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
            [Out] ID2D1DCRenderTarget** dcRenderTarget
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1Factory* This = &this)
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
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReloadSystemMetrics()
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ReloadSystemMetrics>(lpVtbl->ReloadSystemMetrics)(
                    This
                );
            }
        }

        public void GetDesktopDpi(
            [Out, NativeTypeName("FLOAT")] float* dpiX,
            [Out, NativeTypeName("FLOAT")] float* dpiY
        )
        {
            fixed (ID2D1Factory* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDesktopDpi>(lpVtbl->GetDesktopDpi)(
                    This,
                    dpiX,
                    dpiY
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRectangleGeometry(
            [In, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rectangle,
            [Out] ID2D1RectangleGeometry** rectangleGeometry
        )
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateRectangleGeometry>(lpVtbl->CreateRectangleGeometry)(
                    This,
                    rectangle,
                    rectangleGeometry
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRoundedRectangleGeometry(
            [In] D2D1_ROUNDED_RECT* roundedRectangle,
            [Out] ID2D1RoundedRectangleGeometry** roundedRectangleGeometry
        )
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateRoundedRectangleGeometry>(lpVtbl->CreateRoundedRectangleGeometry)(
                    This,
                    roundedRectangle,
                    roundedRectangleGeometry
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEllipseGeometry(
            [In] D2D1_ELLIPSE* ellipse,
            [Out] ID2D1EllipseGeometry** ellipseGeometry
        )
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateEllipseGeometry>(lpVtbl->CreateEllipseGeometry)(
                    This,
                    ellipse,
                    ellipseGeometry
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryGroup(
            [In] D2D1_FILL_MODE fillMode,
            [In, NativeTypeName("ID2D1Geometry*[]")] ID2D1Geometry** geometries,
            [In, NativeTypeName("UINT32")] uint geometriesCount,
            [Out] ID2D1GeometryGroup** geometryGroup
        )
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateGeometryGroup>(lpVtbl->CreateGeometryGroup)(
                    This,
                    fillMode,
                    geometries,
                    geometriesCount,
                    geometryGroup
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransformedGeometry(
            [In] ID2D1Geometry* sourceGeometry,
            [In, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform,
            [Out] ID2D1TransformedGeometry** transformedGeometry
        )
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateTransformedGeometry>(lpVtbl->CreateTransformedGeometry)(
                    This,
                    sourceGeometry,
                    transform,
                    transformedGeometry
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePathGeometry(
            [Out] ID2D1PathGeometry** pathGeometry
        )
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePathGeometry>(lpVtbl->CreatePathGeometry)(
                    This,
                    pathGeometry
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStrokeStyle(
            [In] D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties,
            [In, Optional, NativeTypeName("FLOAT[]")] float* dashes,
            [In, NativeTypeName("UINT32")] uint dashesCount,
            [Out] ID2D1StrokeStyle** strokeStyle
        )
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateStrokeStyle>(lpVtbl->CreateStrokeStyle)(
                    This,
                    strokeStyleProperties,
                    dashes,
                    dashesCount,
                    strokeStyle
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock(
            [In, Optional] D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription,
            [In, Optional] IDWriteRenderingParams* textRenderingParams,
            [Out] ID2D1DrawingStateBlock** drawingStateBlock
        )
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDrawingStateBlock>(lpVtbl->CreateDrawingStateBlock)(
                    This,
                    drawingStateDescription,
                    textRenderingParams,
                    drawingStateBlock
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateWicBitmapRenderTarget(
            [In] IWICBitmap* target,
            [In] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
            [Out] ID2D1RenderTarget** renderTarget
        )
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateWicBitmapRenderTarget>(lpVtbl->CreateWicBitmapRenderTarget)(
                    This,
                    target,
                    renderTargetProperties,
                    renderTarget
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHwndRenderTarget(
            [In] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
            [In] D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties,
            [Out] ID2D1HwndRenderTarget** hwndRenderTarget
        )
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateHwndRenderTarget>(lpVtbl->CreateHwndRenderTarget)(
                    This,
                    renderTargetProperties,
                    hwndRenderTargetProperties,
                    hwndRenderTarget
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDxgiSurfaceRenderTarget(
            [In] IDXGISurface* dxgiSurface,
            [In] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
            [Out] ID2D1RenderTarget** renderTarget
        )
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDxgiSurfaceRenderTarget>(lpVtbl->CreateDxgiSurfaceRenderTarget)(
                    This,
                    dxgiSurface,
                    renderTargetProperties,
                    renderTarget
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDCRenderTarget(
            [In] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
            [Out] ID2D1DCRenderTarget** dcRenderTarget
        )
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDCRenderTarget>(lpVtbl->CreateDCRenderTarget)(
                    This,
                    renderTargetProperties,
                    dcRenderTarget
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr ReloadSystemMetrics;

            public IntPtr GetDesktopDpi;

            public IntPtr CreateRectangleGeometry;

            public IntPtr CreateRoundedRectangleGeometry;

            public IntPtr CreateEllipseGeometry;

            public IntPtr CreateGeometryGroup;

            public IntPtr CreateTransformedGeometry;

            public IntPtr CreatePathGeometry;

            public IntPtr CreateStrokeStyle;

            public IntPtr CreateDrawingStateBlock;

            public IntPtr CreateWicBitmapRenderTarget;

            public IntPtr CreateHwndRenderTarget;

            public IntPtr CreateDxgiSurfaceRenderTarget;

            public IntPtr CreateDCRenderTarget;
        }
    }
}
