// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The root factory interface for all of D2D's objects.</summary>
    [Guid("06152247-6F50-465A-9245-118BFD3B6007")]
    public unsafe partial struct ID2D1Factory
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1Factory* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1Factory* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1Factory* This);

        /// <summary>Cause the factory to refresh any system metrics that it might have been snapped on factory creation.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReloadSystemMetrics(ID2D1Factory* This);

        /// <summary>Retrieves the current desktop DPI. To refresh this, call ReloadSystemMetrics.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDesktopDpi(ID2D1Factory* This, [NativeTypeName("FLOAT")] float* dpiX, [NativeTypeName("FLOAT")] float* dpiY);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRectangleGeometry(ID2D1Factory* This, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rectangle, ID2D1RectangleGeometry** rectangleGeometry);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRoundedRectangleGeometry(ID2D1Factory* This, D2D1_ROUNDED_RECT* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEllipseGeometry(ID2D1Factory* This, D2D1_ELLIPSE* ellipse, ID2D1EllipseGeometry** ellipseGeometry);

        /// <summary>Create a geometry which holds other geometries.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGeometryGroup(ID2D1Factory* This, D2D1_FILL_MODE fillMode, [NativeTypeName("ID2D1Geometry*[]")] ID2D1Geometry** geometries, [NativeTypeName("UINT32")] uint geometriesCount, ID2D1GeometryGroup** geometryGroup);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTransformedGeometry(ID2D1Factory* This, ID2D1Geometry* sourceGeometry, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform, ID2D1TransformedGeometry** transformedGeometry);

        /// <summary>Returns an initially empty path geometry interface. A geometry sink is created off the interface to populate it.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePathGeometry(ID2D1Factory* This, ID2D1PathGeometry** pathGeometry);

        /// <summary>Allows a non-default stroke style to be specified for a given geometry at draw time.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStrokeStyle(ID2D1Factory* This, D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties, [Optional, NativeTypeName("FLOAT[]")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, ID2D1StrokeStyle** strokeStyle);

        /// <summary>Creates a new drawing state block, this can be used in subsequent SaveDrawingState and RestoreDrawingState operations on the render target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDrawingStateBlock(ID2D1Factory* This, [Optional] D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription, [Optional] IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock);

        /// <summary>Creates a render target which is a source of bitmaps.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateWicBitmapRenderTarget(ID2D1Factory* This, IWICBitmap* target, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget);

        /// <summary>Creates a render target that appears on the display.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateHwndRenderTarget(ID2D1Factory* This, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget);

        /// <summary>Creates a render target that draws to a DXGI Surface. The device that owns the surface is used for rendering.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDxgiSurfaceRenderTarget(ID2D1Factory* This, IDXGISurface* dxgiSurface, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget);

        /// <summary>Creates a render target that draws to a GDI device context.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDCRenderTarget(ID2D1Factory* This, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReloadSystemMetrics()
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ReloadSystemMetrics>(lpVtbl->ReloadSystemMetrics)(This);
            }
        }

        public void GetDesktopDpi([NativeTypeName("FLOAT")] float* dpiX, [NativeTypeName("FLOAT")] float* dpiY)
        {
            fixed (ID2D1Factory* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDesktopDpi>(lpVtbl->GetDesktopDpi)(This, dpiX, dpiY);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRectangleGeometry([NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rectangle, ID2D1RectangleGeometry** rectangleGeometry)
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateRectangleGeometry>(lpVtbl->CreateRectangleGeometry)(This, rectangle, rectangleGeometry);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRoundedRectangleGeometry(D2D1_ROUNDED_RECT* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateRoundedRectangleGeometry>(lpVtbl->CreateRoundedRectangleGeometry)(This, roundedRectangle, roundedRectangleGeometry);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEllipseGeometry(D2D1_ELLIPSE* ellipse, ID2D1EllipseGeometry** ellipseGeometry)
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateEllipseGeometry>(lpVtbl->CreateEllipseGeometry)(This, ellipse, ellipseGeometry);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryGroup(D2D1_FILL_MODE fillMode, [NativeTypeName("ID2D1Geometry*[]")] ID2D1Geometry** geometries, [NativeTypeName("UINT32")] uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateGeometryGroup>(lpVtbl->CreateGeometryGroup)(This, fillMode, geometries, geometriesCount, geometryGroup);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform, ID2D1TransformedGeometry** transformedGeometry)
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateTransformedGeometry>(lpVtbl->CreateTransformedGeometry)(This, sourceGeometry, transform, transformedGeometry);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePathGeometry(ID2D1PathGeometry** pathGeometry)
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePathGeometry>(lpVtbl->CreatePathGeometry)(This, pathGeometry);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStrokeStyle(D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties, [Optional, NativeTypeName("FLOAT[]")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, ID2D1StrokeStyle** strokeStyle)
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateStrokeStyle>(lpVtbl->CreateStrokeStyle)(This, strokeStyleProperties, dashes, dashesCount, strokeStyle);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock([Optional] D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription, [Optional] IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDrawingStateBlock>(lpVtbl->CreateDrawingStateBlock)(This, drawingStateDescription, textRenderingParams, drawingStateBlock);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateWicBitmapRenderTarget(IWICBitmap* target, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateWicBitmapRenderTarget>(lpVtbl->CreateWicBitmapRenderTarget)(This, target, renderTargetProperties, renderTarget);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHwndRenderTarget(D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateHwndRenderTarget>(lpVtbl->CreateHwndRenderTarget)(This, renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDxgiSurfaceRenderTarget(IDXGISurface* dxgiSurface, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDxgiSurfaceRenderTarget>(lpVtbl->CreateDxgiSurfaceRenderTarget)(This, dxgiSurface, renderTargetProperties, renderTarget);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDCRenderTarget(D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
        {
            fixed (ID2D1Factory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDCRenderTarget>(lpVtbl->CreateDCRenderTarget)(This, renderTargetProperties, dcRenderTarget);
            }
        }

        public partial struct Vtbl
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
