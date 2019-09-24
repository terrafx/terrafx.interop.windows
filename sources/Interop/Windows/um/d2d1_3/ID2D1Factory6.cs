// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>Creates Direct2D resources. This interface also enables the creation of ID2D1Device5 objects.</summary>
    [Guid("F9976F46-F642-44C1-97CA-DA32EA2A2635")]
    public unsafe struct ID2D1Factory6
    {
        public readonly Vtbl* lpVtbl;

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1Factory6* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1Factory6* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1Factory6* This
        );

        /// <summary>Cause the factory to refresh any system metrics that it might have been snapped on factory creation.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ReloadSystemMetrics(
            [In] ID2D1Factory6* This
        );

        /// <summary>Retrieves the current desktop DPI. To refresh this, call ReloadSystemMetrics.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetDesktopDpi(
            [In] ID2D1Factory6* This,
            [Out, NativeTypeName("FLOAT")] float* dpiX,
            [Out, NativeTypeName("FLOAT")] float* dpiY
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateRectangleGeometry(
            [In] ID2D1Factory6* This,
            [In, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rectangle,
            [Out] ID2D1RectangleGeometry** rectangleGeometry
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateRoundedRectangleGeometry(
            [In] ID2D1Factory6* This,
            [In] D2D1_ROUNDED_RECT* roundedRectangle,
            [Out] ID2D1RoundedRectangleGeometry** roundedRectangleGeometry
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateEllipseGeometry(
            [In] ID2D1Factory6* This,
            [In] D2D1_ELLIPSE* ellipse,
            [Out] ID2D1EllipseGeometry** ellipseGeometry
        );

        /// <summary>Create a geometry which holds other geometries.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateGeometryGroup(
            [In] ID2D1Factory6* This,
            [In] D2D1_FILL_MODE fillMode,
            [In, NativeTypeName("ID2D1Geometry*[]")] ID2D1Geometry** geometries,
            [In, NativeTypeName("UINT32")] uint geometriesCount,
            [Out] ID2D1GeometryGroup** geometryGroup
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateTransformedGeometry(
            [In] ID2D1Factory6* This,
            [In] ID2D1Geometry* sourceGeometry,
            [In, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform,
            [Out] ID2D1TransformedGeometry** transformedGeometry
        );

        /// <summary>Returns an initially empty path geometry interface. A geometry sink is created off the interface to populate it.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreatePathGeometry(
            [In] ID2D1Factory6* This,
            [Out] ID2D1PathGeometry** pathGeometry
        );

        /// <summary>Allows a non-default stroke style to be specified for a given geometry at draw time.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateStrokeStyle(
            [In] ID2D1Factory6* This,
            [In] D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties,
            [In, Optional, NativeTypeName("FLOAT[]")] float* dashes,
            [In, NativeTypeName("UINT32")] uint dashesCount,
            [Out] ID2D1StrokeStyle** strokeStyle
        );

        /// <summary>Creates a new drawing state block, this can be used in subsequent SaveDrawingState and RestoreDrawingState operations on the render target.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDrawingStateBlock(
            [In] ID2D1Factory6* This,
            [In, Optional] D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription,
            [In, Optional] IDWriteRenderingParams* textRenderingParams,
            [Out] ID2D1DrawingStateBlock** drawingStateBlock
        );

        /// <summary>Creates a render target which is a source of bitmaps.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateWicBitmapRenderTarget(
            [In] ID2D1Factory6* This,
            [In] IWICBitmap* target,
            [In] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
            [Out] ID2D1RenderTarget** renderTarget
        );

        /// <summary>Creates a render target that appears on the display.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateHwndRenderTarget(
            [In] ID2D1Factory6* This,
            [In] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
            [In] D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties,
            [Out] ID2D1HwndRenderTarget** hwndRenderTarget
        );

        /// <summary>Creates a render target that draws to a DXGI Surface. The device that owns the surface is used for rendering.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDxgiSurfaceRenderTarget(
            [In] ID2D1Factory6* This,
            [In] IDXGISurface* dxgiSurface,
            [In] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
            [Out] ID2D1RenderTarget** renderTarget
        );

        /// <summary>Creates a render target that draws to a GDI device context.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDCRenderTarget(
            [In] ID2D1Factory6* This,
            [In] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
            [Out] ID2D1DCRenderTarget** dcRenderTarget
        );

        /// <summary>This creates a new Direct2D device from the given IDXGIDevice.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDevice(
            [In] ID2D1Factory6* This,
            [In] IDXGIDevice* dxgiDevice,
            [Out] ID2D1Device** d2dDevice
        );

        /// <summary>This creates a stroke style with the ability to preserve stroke width in various ways.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateStrokeStyle1(
            [In] ID2D1Factory6* This,
            [In] D2D1_STROKE_STYLE_PROPERTIES1* strokeStyleProperties,
            [In, Optional, NativeTypeName("FLOAT[]")] float* dashes,
            [In, NativeTypeName("UINT32")] uint dashesCount,
            [Out] ID2D1StrokeStyle1** strokeStyle
        );

        /// <summary>Creates a path geometry with new operational methods.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreatePathGeometry1(
            [In] ID2D1Factory6* This,
            [Out] ID2D1PathGeometry1** pathGeometry
        );

        /// <summary>Creates a new drawing state block, this can be used in subsequent SaveDrawingState and RestoreDrawingState operations on the render target.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDrawingStateBlock1(
            [In] ID2D1Factory6* This,
            [In, Optional] D2D1_DRAWING_STATE_DESCRIPTION1* drawingStateDescription,
            [In, Optional] IDWriteRenderingParams* textRenderingParams,
            [Out] ID2D1DrawingStateBlock1** drawingStateBlock
        );

        /// <summary>Creates a new GDI metafile.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateGdiMetafile(
            [In] ID2D1Factory6* This,
            [In] IStream* metafileStream,
            [Out] ID2D1GdiMetafile** metafile
        );

        /// <summary>This globally registers the given effect. The effect can later be instantiated by using the registered class id. The effect registration is reference counted.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RegisterEffectFromStream(
            [In] ID2D1Factory6* This,
            [In, NativeTypeName("REFCLSID")] Guid* classId,
            [In] IStream* propertyXml,
            [In, Optional] D2D1_PROPERTY_BINDING* bindings,
            [In, NativeTypeName("UINT32")] uint bindingsCount,
            [In] PD2D1_EFFECT_FACTORY effectFactory
        );

        /// <summary>This globally registers the given effect. The effect can later be instantiated by using the registered class id. The effect registration is reference counted.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RegisterEffectFromString(
            [In] ID2D1Factory6* This,
            [In, NativeTypeName("REFCLSID")] Guid* classId,
            [In, NativeTypeName("PCWSTR")] char* propertyXml,
            [In, Optional, NativeTypeName("D2D1_PROPERTY_BINDING[]")] D2D1_PROPERTY_BINDING* bindings,
            [In, NativeTypeName("UINT32")] uint bindingsCount,
            [In] PD2D1_EFFECT_FACTORY effectFactory
        );

        /// <summary>This unregisters the given effect by its class id, you need to call UnregisterEffect for every call to ID2D1Factory1::RegisterEffectFromStream and ID2D1Factory1::RegisterEffectFromString to completely unregister it.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _UnregisterEffect(
            [In] ID2D1Factory6* This,
            [In, NativeTypeName("REFCLSID")] Guid* classId
        );

        /// <summary>This returns all of the registered effects in the process, including any built-in effects.</summary>
        /// <param name="effectsReturned">The number of effects returned into the passed in effects array.</param>
        /// <param name="effectsRegistered">The number of effects currently registered in the system.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetRegisteredEffects(
            [In] ID2D1Factory6* This,
            [Out, Optional, NativeTypeName("CLSID[]")] Guid* effects,
            [In, NativeTypeName("UINT32")] uint effectsCount,
            [Out, NativeTypeName("UINT32")] uint* effectsReturned = null,
            [Out, NativeTypeName("UINT32")] uint* effectsRegistered = null
        );

        /// <summary>This retrieves the effect properties for the given effect, all of the effect properties will be set to a default value since an effect is not instantiated to implement the returned property interface.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetEffectProperties(
            [In] ID2D1Factory6* This,
            [In, NativeTypeName("REFCLSID")] Guid* effectId,
            [Out] ID2D1Properties** properties
        );

        /// <summary>This creates a new Direct2D device from the given IDXGIDevice.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDevice1(
            [In] ID2D1Factory6* This,
            [In] IDXGIDevice* dxgiDevice,
            [Out] ID2D1Device1** d2dDevice1
        );

        /// <summary>This creates a new Direct2D device from the given IDXGIDevice.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDevice2(
            [In] ID2D1Factory6* This,
            [In] IDXGIDevice* dxgiDevice,
            [Out] ID2D1Device2** d2dDevice2
        );

        /// <summary>This creates a new Direct2D device from the given IDXGIDevice.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDevice3(
            [In] ID2D1Factory6* This,
            [In] IDXGIDevice* dxgiDevice,
            [Out] ID2D1Device3** d2dDevice3
        );

        /// <summary>This creates a new Direct2D device from the given IDXGIDevice.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDevice4(
            [In] ID2D1Factory6* This,
            [In] IDXGIDevice* dxgiDevice,
            [Out] ID2D1Device4** d2dDevice4
        );

        /// <summary>This creates a new Direct2D device from the given IDXGIDevice.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDevice5(
            [In] ID2D1Factory6* This,
            [In] IDXGIDevice* dxgiDevice,
            [Out] ID2D1Device5** d2dDevice5
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1Factory6* This = &this)
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
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReloadSystemMetrics()
        {
            fixed (ID2D1Factory6* This = &this)
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
            fixed (ID2D1Factory6* This = &this)
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
            fixed (ID2D1Factory6* This = &this)
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
            fixed (ID2D1Factory6* This = &this)
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
            fixed (ID2D1Factory6* This = &this)
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
            fixed (ID2D1Factory6* This = &this)
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
            fixed (ID2D1Factory6* This = &this)
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
            fixed (ID2D1Factory6* This = &this)
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
            fixed (ID2D1Factory6* This = &this)
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
            fixed (ID2D1Factory6* This = &this)
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
            fixed (ID2D1Factory6* This = &this)
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
            fixed (ID2D1Factory6* This = &this)
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
            fixed (ID2D1Factory6* This = &this)
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
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDCRenderTarget>(lpVtbl->CreateDCRenderTarget)(
                    This,
                    renderTargetProperties,
                    dcRenderTarget
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDevice(
            [In] IDXGIDevice* dxgiDevice,
            [Out] ID2D1Device** d2dDevice
        )
        {
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDevice>(lpVtbl->CreateDevice)(
                    This,
                    dxgiDevice,
                    d2dDevice
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStrokeStyle1(
            [In] D2D1_STROKE_STYLE_PROPERTIES1* strokeStyleProperties,
            [In, Optional, NativeTypeName("FLOAT[]")] float* dashes,
            [In, NativeTypeName("UINT32")] uint dashesCount,
            [Out] ID2D1StrokeStyle1** strokeStyle
        )
        {
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateStrokeStyle1>(lpVtbl->CreateStrokeStyle1)(
                    This,
                    strokeStyleProperties,
                    dashes,
                    dashesCount,
                    strokeStyle
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePathGeometry1(
            [Out] ID2D1PathGeometry1** pathGeometry
        )
        {
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePathGeometry1>(lpVtbl->CreatePathGeometry1)(
                    This,
                    pathGeometry
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock1(
            [In, Optional] D2D1_DRAWING_STATE_DESCRIPTION1* drawingStateDescription,
            [In, Optional] IDWriteRenderingParams* textRenderingParams,
            [Out] ID2D1DrawingStateBlock1** drawingStateBlock
        )
        {
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDrawingStateBlock1>(lpVtbl->CreateDrawingStateBlock1)(
                    This,
                    drawingStateDescription,
                    textRenderingParams,
                    drawingStateBlock
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGdiMetafile(
            [In] IStream* metafileStream,
            [Out] ID2D1GdiMetafile** metafile
        )
        {
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateGdiMetafile>(lpVtbl->CreateGdiMetafile)(
                    This,
                    metafileStream,
                    metafile
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterEffectFromStream(
            [In, NativeTypeName("REFCLSID")] Guid* classId,
            [In] IStream* propertyXml,
            [In, Optional] D2D1_PROPERTY_BINDING* bindings,
            [In, NativeTypeName("UINT32")] uint bindingsCount,
            [In] PD2D1_EFFECT_FACTORY effectFactory
        )
        {
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterEffectFromStream>(lpVtbl->RegisterEffectFromStream)(
                    This,
                    classId,
                    propertyXml,
                    bindings,
                    bindingsCount,
                    effectFactory
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterEffectFromString(
            [In, NativeTypeName("REFCLSID")] Guid* classId,
            [In, NativeTypeName("PCWSTR")] char* propertyXml,
            [In, Optional, NativeTypeName("D2D1_PROPERTY_BINDING[]")] D2D1_PROPERTY_BINDING* bindings,
            [In, NativeTypeName("UINT32")] uint bindingsCount,
            [In] PD2D1_EFFECT_FACTORY effectFactory
        )
        {
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterEffectFromString>(lpVtbl->RegisterEffectFromString)(
                    This,
                    classId,
                    propertyXml,
                    bindings,
                    bindingsCount,
                    effectFactory
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterEffect(
            [In, NativeTypeName("REFCLSID")] Guid* classId
        )
        {
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_UnregisterEffect>(lpVtbl->UnregisterEffect)(
                    This,
                    classId
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRegisteredEffects(
            [Out, Optional, NativeTypeName("CLSID[]")] Guid* effects,
            [In, NativeTypeName("UINT32")] uint effectsCount,
            [Out, NativeTypeName("UINT32")] uint* effectsReturned = null,
            [Out, NativeTypeName("UINT32")] uint* effectsRegistered = null
        )
        {
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRegisteredEffects>(lpVtbl->GetRegisteredEffects)(
                    This,
                    effects,
                    effectsCount,
                    effectsReturned,
                    effectsRegistered
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEffectProperties(
            [In, NativeTypeName("REFCLSID")] Guid* effectId,
            [Out] ID2D1Properties** properties
        )
        {
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEffectProperties>(lpVtbl->GetEffectProperties)(
                    This,
                    effectId,
                    properties
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDevice1(
            [In] IDXGIDevice* dxgiDevice,
            [Out] ID2D1Device1** d2dDevice1
        )
        {
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDevice1>(lpVtbl->CreateDevice1)(
                    This,
                    dxgiDevice,
                    d2dDevice1
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDevice2(
            [In] IDXGIDevice* dxgiDevice,
            [Out] ID2D1Device2** d2dDevice2
        )
        {
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDevice2>(lpVtbl->CreateDevice2)(
                    This,
                    dxgiDevice,
                    d2dDevice2
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDevice3(
            [In] IDXGIDevice* dxgiDevice,
            [Out] ID2D1Device3** d2dDevice3
        )
        {
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDevice3>(lpVtbl->CreateDevice3)(
                    This,
                    dxgiDevice,
                    d2dDevice3
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDevice4(
            [In] IDXGIDevice* dxgiDevice,
            [Out] ID2D1Device4** d2dDevice4
        )
        {
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDevice4>(lpVtbl->CreateDevice4)(
                    This,
                    dxgiDevice,
                    d2dDevice4
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDevice5(
            [In] IDXGIDevice* dxgiDevice,
            [Out] ID2D1Device5** d2dDevice5
        )
        {
            fixed (ID2D1Factory6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDevice5>(lpVtbl->CreateDevice5)(
                    This,
                    dxgiDevice,
                    d2dDevice5
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

            public IntPtr CreateDevice;

            public IntPtr CreateStrokeStyle1;

            public IntPtr CreatePathGeometry1;

            public IntPtr CreateDrawingStateBlock1;

            public IntPtr CreateGdiMetafile;

            public IntPtr RegisterEffectFromStream;

            public IntPtr RegisterEffectFromString;

            public IntPtr UnregisterEffect;

            public IntPtr GetRegisteredEffects;

            public IntPtr GetEffectProperties;

            public IntPtr CreateDevice1;

            public IntPtr CreateDevice2;

            public IntPtr CreateDevice3;

            public IntPtr CreateDevice4;

            public IntPtr CreateDevice5;
        }
    }
}
