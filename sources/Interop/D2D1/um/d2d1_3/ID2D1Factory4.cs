// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Creates Direct2D resources. This interface also enables the creation of ID2D1Device3 objects.</summary>
    [Guid("BD4EC2D2-0662-4BEE-BA8E-6F29F032E096")]
    public unsafe partial struct ID2D1Factory4
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1Factory4* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1Factory4* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1Factory4* This);

        /// <summary>Cause the factory to refresh any system metrics that it might have been snapped on factory creation.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReloadSystemMetrics(ID2D1Factory4* This);

        /// <summary>Retrieves the current desktop DPI. To refresh this, call ReloadSystemMetrics.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDesktopDpi(ID2D1Factory4* This, [NativeTypeName("FLOAT")] float* dpiX, [NativeTypeName("FLOAT")] float* dpiY);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRectangleGeometry(ID2D1Factory4* This, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rectangle, ID2D1RectangleGeometry** rectangleGeometry);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRoundedRectangleGeometry(ID2D1Factory4* This, D2D1_ROUNDED_RECT* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEllipseGeometry(ID2D1Factory4* This, D2D1_ELLIPSE* ellipse, ID2D1EllipseGeometry** ellipseGeometry);

        /// <summary>Create a geometry which holds other geometries.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGeometryGroup(ID2D1Factory4* This, D2D1_FILL_MODE fillMode, [NativeTypeName("ID2D1Geometry*[]")] ID2D1Geometry** geometries, [NativeTypeName("UINT32")] uint geometriesCount, ID2D1GeometryGroup** geometryGroup);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTransformedGeometry(ID2D1Factory4* This, ID2D1Geometry* sourceGeometry, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform, ID2D1TransformedGeometry** transformedGeometry);

        /// <summary>Returns an initially empty path geometry interface. A geometry sink is created off the interface to populate it.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePathGeometry(ID2D1Factory4* This, ID2D1PathGeometry** pathGeometry);

        /// <summary>Allows a non-default stroke style to be specified for a given geometry at draw time.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStrokeStyle(ID2D1Factory4* This, D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties, [Optional, NativeTypeName("FLOAT[]")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, ID2D1StrokeStyle** strokeStyle);

        /// <summary>Creates a new drawing state block, this can be used in subsequent SaveDrawingState and RestoreDrawingState operations on the render target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDrawingStateBlock(ID2D1Factory4* This, [Optional] D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription, [Optional] IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock);

        /// <summary>Creates a render target which is a source of bitmaps.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateWicBitmapRenderTarget(ID2D1Factory4* This, IWICBitmap* target, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget);

        /// <summary>Creates a render target that appears on the display.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateHwndRenderTarget(ID2D1Factory4* This, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget);

        /// <summary>Creates a render target that draws to a DXGI Surface. The device that owns the surface is used for rendering.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDxgiSurfaceRenderTarget(ID2D1Factory4* This, IDXGISurface* dxgiSurface, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget);

        /// <summary>Creates a render target that draws to a GDI device context.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDCRenderTarget(ID2D1Factory4* This, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget);

        /// <summary>This creates a new Direct2D device from the given IDXGIDevice.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDevice(ID2D1Factory4* This, IDXGIDevice* dxgiDevice, ID2D1Device** d2dDevice);

        /// <summary>This creates a stroke style with the ability to preserve stroke width in various ways.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStrokeStyle1(ID2D1Factory4* This, D2D1_STROKE_STYLE_PROPERTIES1* strokeStyleProperties, [Optional, NativeTypeName("FLOAT[]")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, ID2D1StrokeStyle1** strokeStyle);

        /// <summary>Creates a path geometry with new operational methods.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePathGeometry1(ID2D1Factory4* This, ID2D1PathGeometry1** pathGeometry);

        /// <summary>Creates a new drawing state block, this can be used in subsequent SaveDrawingState and RestoreDrawingState operations on the render target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDrawingStateBlock1(ID2D1Factory4* This, [Optional] D2D1_DRAWING_STATE_DESCRIPTION1* drawingStateDescription, [Optional] IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock1** drawingStateBlock);

        /// <summary>Creates a new GDI metafile.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGdiMetafile(ID2D1Factory4* This, IStream* metafileStream, ID2D1GdiMetafile** metafile);

        /// <summary>This globally registers the given effect. The effect can later be instantiated by using the registered class id. The effect registration is reference counted.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterEffectFromStream(ID2D1Factory4* This, [NativeTypeName("REFCLSID")] Guid* classId, IStream* propertyXml, [Optional] D2D1_PROPERTY_BINDING* bindings, [NativeTypeName("UINT32")] uint bindingsCount, PD2D1_EFFECT_FACTORY effectFactory);

        /// <summary>This globally registers the given effect. The effect can later be instantiated by using the registered class id. The effect registration is reference counted.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterEffectFromString(ID2D1Factory4* This, [NativeTypeName("REFCLSID")] Guid* classId, [NativeTypeName("PCWSTR")] ushort* propertyXml, [Optional, NativeTypeName("D2D1_PROPERTY_BINDING[]")] D2D1_PROPERTY_BINDING* bindings, [NativeTypeName("UINT32")] uint bindingsCount, PD2D1_EFFECT_FACTORY effectFactory);

        /// <summary>This unregisters the given effect by its class id, you need to call UnregisterEffect for every call to ID2D1Factory1::RegisterEffectFromStream and ID2D1Factory1::RegisterEffectFromString to completely unregister it.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnregisterEffect(ID2D1Factory4* This, [NativeTypeName("REFCLSID")] Guid* classId);

        /// <summary>This returns all of the registered effects in the process, including any built-in effects.</summary>
        /// <param name="effectsReturned">The number of effects returned into the passed in effects array.</param>
        /// <param name="effectsRegistered">The number of effects currently registered in the system.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRegisteredEffects(ID2D1Factory4* This, [Optional, NativeTypeName("CLSID[]")] Guid* effects, [NativeTypeName("UINT32")] uint effectsCount, [NativeTypeName("UINT32")] uint* effectsReturned = null, [NativeTypeName("UINT32")] uint* effectsRegistered = null);

        /// <summary>This retrieves the effect properties for the given effect, all of the effect properties will be set to a default value since an effect is not instantiated to implement the returned property interface.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEffectProperties(ID2D1Factory4* This, [NativeTypeName("REFCLSID")] Guid* effectId, ID2D1Properties** properties);

        /// <summary>This creates a new Direct2D device from the given IDXGIDevice.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDevice1(ID2D1Factory4* This, IDXGIDevice* dxgiDevice, ID2D1Device1** d2dDevice1);

        /// <summary>This creates a new Direct2D device from the given IDXGIDevice.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDevice2(ID2D1Factory4* This, IDXGIDevice* dxgiDevice, ID2D1Device2** d2dDevice2);

        /// <summary>This creates a new Direct2D device from the given IDXGIDevice.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDevice3(ID2D1Factory4* This, IDXGIDevice* dxgiDevice, ID2D1Device3** d2dDevice3);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReloadSystemMetrics()
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ReloadSystemMetrics>(lpVtbl->ReloadSystemMetrics)(This);
            }
        }

        public void GetDesktopDpi([NativeTypeName("FLOAT")] float* dpiX, [NativeTypeName("FLOAT")] float* dpiY)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDesktopDpi>(lpVtbl->GetDesktopDpi)(This, dpiX, dpiY);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRectangleGeometry([NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rectangle, ID2D1RectangleGeometry** rectangleGeometry)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateRectangleGeometry>(lpVtbl->CreateRectangleGeometry)(This, rectangle, rectangleGeometry);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRoundedRectangleGeometry(D2D1_ROUNDED_RECT* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateRoundedRectangleGeometry>(lpVtbl->CreateRoundedRectangleGeometry)(This, roundedRectangle, roundedRectangleGeometry);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEllipseGeometry(D2D1_ELLIPSE* ellipse, ID2D1EllipseGeometry** ellipseGeometry)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateEllipseGeometry>(lpVtbl->CreateEllipseGeometry)(This, ellipse, ellipseGeometry);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryGroup(D2D1_FILL_MODE fillMode, [NativeTypeName("ID2D1Geometry*[]")] ID2D1Geometry** geometries, [NativeTypeName("UINT32")] uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateGeometryGroup>(lpVtbl->CreateGeometryGroup)(This, fillMode, geometries, geometriesCount, geometryGroup);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform, ID2D1TransformedGeometry** transformedGeometry)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateTransformedGeometry>(lpVtbl->CreateTransformedGeometry)(This, sourceGeometry, transform, transformedGeometry);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePathGeometry(ID2D1PathGeometry** pathGeometry)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePathGeometry>(lpVtbl->CreatePathGeometry)(This, pathGeometry);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStrokeStyle(D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties, [Optional, NativeTypeName("FLOAT[]")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, ID2D1StrokeStyle** strokeStyle)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateStrokeStyle>(lpVtbl->CreateStrokeStyle)(This, strokeStyleProperties, dashes, dashesCount, strokeStyle);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock([Optional] D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription, [Optional] IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDrawingStateBlock>(lpVtbl->CreateDrawingStateBlock)(This, drawingStateDescription, textRenderingParams, drawingStateBlock);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateWicBitmapRenderTarget(IWICBitmap* target, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateWicBitmapRenderTarget>(lpVtbl->CreateWicBitmapRenderTarget)(This, target, renderTargetProperties, renderTarget);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHwndRenderTarget(D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateHwndRenderTarget>(lpVtbl->CreateHwndRenderTarget)(This, renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDxgiSurfaceRenderTarget(IDXGISurface* dxgiSurface, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDxgiSurfaceRenderTarget>(lpVtbl->CreateDxgiSurfaceRenderTarget)(This, dxgiSurface, renderTargetProperties, renderTarget);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDCRenderTarget(D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDCRenderTarget>(lpVtbl->CreateDCRenderTarget)(This, renderTargetProperties, dcRenderTarget);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDevice(IDXGIDevice* dxgiDevice, ID2D1Device** d2dDevice)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDevice>(lpVtbl->CreateDevice)(This, dxgiDevice, d2dDevice);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStrokeStyle1(D2D1_STROKE_STYLE_PROPERTIES1* strokeStyleProperties, [Optional, NativeTypeName("FLOAT[]")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, ID2D1StrokeStyle1** strokeStyle)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateStrokeStyle1>(lpVtbl->CreateStrokeStyle1)(This, strokeStyleProperties, dashes, dashesCount, strokeStyle);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePathGeometry1(ID2D1PathGeometry1** pathGeometry)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePathGeometry1>(lpVtbl->CreatePathGeometry1)(This, pathGeometry);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock1([Optional] D2D1_DRAWING_STATE_DESCRIPTION1* drawingStateDescription, [Optional] IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock1** drawingStateBlock)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDrawingStateBlock1>(lpVtbl->CreateDrawingStateBlock1)(This, drawingStateDescription, textRenderingParams, drawingStateBlock);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGdiMetafile(IStream* metafileStream, ID2D1GdiMetafile** metafile)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateGdiMetafile>(lpVtbl->CreateGdiMetafile)(This, metafileStream, metafile);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterEffectFromStream([NativeTypeName("REFCLSID")] Guid* classId, IStream* propertyXml, [Optional] D2D1_PROPERTY_BINDING* bindings, [NativeTypeName("UINT32")] uint bindingsCount, PD2D1_EFFECT_FACTORY effectFactory)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterEffectFromStream>(lpVtbl->RegisterEffectFromStream)(This, classId, propertyXml, bindings, bindingsCount, effectFactory);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterEffectFromString([NativeTypeName("REFCLSID")] Guid* classId, [NativeTypeName("PCWSTR")] ushort* propertyXml, [Optional, NativeTypeName("D2D1_PROPERTY_BINDING[]")] D2D1_PROPERTY_BINDING* bindings, [NativeTypeName("UINT32")] uint bindingsCount, PD2D1_EFFECT_FACTORY effectFactory)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterEffectFromString>(lpVtbl->RegisterEffectFromString)(This, classId, propertyXml, bindings, bindingsCount, effectFactory);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterEffect([NativeTypeName("REFCLSID")] Guid* classId)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_UnregisterEffect>(lpVtbl->UnregisterEffect)(This, classId);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRegisteredEffects([Optional, NativeTypeName("CLSID[]")] Guid* effects, [NativeTypeName("UINT32")] uint effectsCount, [NativeTypeName("UINT32")] uint* effectsReturned = null, [NativeTypeName("UINT32")] uint* effectsRegistered = null)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRegisteredEffects>(lpVtbl->GetRegisteredEffects)(This, effects, effectsCount, effectsReturned, effectsRegistered);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEffectProperties([NativeTypeName("REFCLSID")] Guid* effectId, ID2D1Properties** properties)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEffectProperties>(lpVtbl->GetEffectProperties)(This, effectId, properties);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDevice1(IDXGIDevice* dxgiDevice, ID2D1Device1** d2dDevice1)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDevice1>(lpVtbl->CreateDevice1)(This, dxgiDevice, d2dDevice1);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDevice2(IDXGIDevice* dxgiDevice, ID2D1Device2** d2dDevice2)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDevice2>(lpVtbl->CreateDevice2)(This, dxgiDevice, d2dDevice2);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDevice3(IDXGIDevice* dxgiDevice, ID2D1Device3** d2dDevice3)
        {
            fixed (ID2D1Factory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDevice3>(lpVtbl->CreateDevice3)(This, dxgiDevice, d2dDevice3);
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
        }
    }
}
