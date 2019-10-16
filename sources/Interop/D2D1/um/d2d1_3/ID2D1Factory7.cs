// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BDC2BDD3-B96C-4DE6-BDF7-99D4745454DE")]
    public unsafe partial struct ID2D1Factory7
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1Factory7* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1Factory7* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1Factory7* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReloadSystemMetrics(ID2D1Factory7* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDesktopDpi(ID2D1Factory7* pThis, [NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRectangleGeometry(ID2D1Factory7* pThis, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rectangle, [NativeTypeName("ID2D1RectangleGeometry **")] ID2D1RectangleGeometry** rectangleGeometry);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRoundedRectangleGeometry(ID2D1Factory7* pThis, [NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRectangle, [NativeTypeName("ID2D1RoundedRectangleGeometry **")] ID2D1RoundedRectangleGeometry** roundedRectangleGeometry);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEllipseGeometry(ID2D1Factory7* pThis, [NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, [NativeTypeName("ID2D1EllipseGeometry **")] ID2D1EllipseGeometry** ellipseGeometry);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGeometryGroup(ID2D1Factory7* pThis, D2D1_FILL_MODE fillMode, [NativeTypeName("ID2D1Geometry **")] ID2D1Geometry** geometries, [NativeTypeName("UINT32")] uint geometriesCount, [NativeTypeName("ID2D1GeometryGroup **")] ID2D1GeometryGroup** geometryGroup);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTransformedGeometry(ID2D1Factory7* pThis, [NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* sourceGeometry, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform, [NativeTypeName("ID2D1TransformedGeometry **")] ID2D1TransformedGeometry** transformedGeometry);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePathGeometry(ID2D1Factory7* pThis, [NativeTypeName("ID2D1PathGeometry **")] ID2D1PathGeometry** pathGeometry);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStrokeStyle(ID2D1Factory7* pThis, [NativeTypeName("const D2D1_STROKE_STYLE_PROPERTIES *")] D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties, [NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("ID2D1StrokeStyle **")] ID2D1StrokeStyle** strokeStyle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDrawingStateBlock(ID2D1Factory7* pThis, [NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams, [NativeTypeName("ID2D1DrawingStateBlock **")] ID2D1DrawingStateBlock** drawingStateBlock);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateWicBitmapRenderTarget(ID2D1Factory7* pThis, [NativeTypeName("IWICBitmap *")] IWICBitmap* target, [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, [NativeTypeName("ID2D1RenderTarget **")] ID2D1RenderTarget** renderTarget);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateHwndRenderTarget(ID2D1Factory7* pThis, [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, [NativeTypeName("const D2D1_HWND_RENDER_TARGET_PROPERTIES *")] D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties, [NativeTypeName("ID2D1HwndRenderTarget **")] ID2D1HwndRenderTarget** hwndRenderTarget);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDxgiSurfaceRenderTarget(ID2D1Factory7* pThis, [NativeTypeName("IDXGISurface *")] IDXGISurface* dxgiSurface, [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, [NativeTypeName("ID2D1RenderTarget **")] ID2D1RenderTarget** renderTarget);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDCRenderTarget(ID2D1Factory7* pThis, [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, [NativeTypeName("ID2D1DCRenderTarget **")] ID2D1DCRenderTarget** dcRenderTarget);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDevice(ID2D1Factory7* pThis, [NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("ID2D1Device **")] ID2D1Device** d2dDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStrokeStyle1(ID2D1Factory7* pThis, [NativeTypeName("const D2D1_STROKE_STYLE_PROPERTIES1 *")] D2D1_STROKE_STYLE_PROPERTIES1* strokeStyleProperties, [NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("ID2D1StrokeStyle1 **")] ID2D1StrokeStyle1** strokeStyle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePathGeometry1(ID2D1Factory7* pThis, [NativeTypeName("ID2D1PathGeometry1 **")] ID2D1PathGeometry1** pathGeometry);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDrawingStateBlock1(ID2D1Factory7* pThis, [NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION1 *")] D2D1_DRAWING_STATE_DESCRIPTION1* drawingStateDescription, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams, [NativeTypeName("ID2D1DrawingStateBlock1 **")] ID2D1DrawingStateBlock1** drawingStateBlock);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGdiMetafile(ID2D1Factory7* pThis, [NativeTypeName("IStream *")] IStream* metafileStream, [NativeTypeName("ID2D1GdiMetafile **")] ID2D1GdiMetafile** metafile);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterEffectFromStream(ID2D1Factory7* pThis, [NativeTypeName("const IID &")] Guid* classId, [NativeTypeName("IStream *")] IStream* propertyXml, [NativeTypeName("const D2D1_PROPERTY_BINDING *")] D2D1_PROPERTY_BINDING* bindings, [NativeTypeName("UINT32")] uint bindingsCount, [NativeTypeName("const PD2D1_EFFECT_FACTORY")] IntPtr effectFactory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterEffectFromString(ID2D1Factory7* pThis, [NativeTypeName("const IID &")] Guid* classId, [NativeTypeName("PCWSTR")] ushort* propertyXml, [NativeTypeName("const D2D1_PROPERTY_BINDING *")] D2D1_PROPERTY_BINDING* bindings, [NativeTypeName("UINT32")] uint bindingsCount, [NativeTypeName("const PD2D1_EFFECT_FACTORY")] IntPtr effectFactory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnregisterEffect(ID2D1Factory7* pThis, [NativeTypeName("const IID &")] Guid* classId);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRegisteredEffects(ID2D1Factory7* pThis, [NativeTypeName("CLSID *")] Guid* effects, [NativeTypeName("UINT32")] uint effectsCount, [NativeTypeName("UINT32 *")] uint* effectsReturned, [NativeTypeName("UINT32 *")] uint* effectsRegistered);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEffectProperties(ID2D1Factory7* pThis, [NativeTypeName("const IID &")] Guid* effectId, [NativeTypeName("ID2D1Properties **")] ID2D1Properties** properties);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDevice1(ID2D1Factory7* pThis, [NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("ID2D1Device1 **")] ID2D1Device1** d2dDevice1);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDevice2(ID2D1Factory7* pThis, [NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("ID2D1Device2 **")] ID2D1Device2** d2dDevice2);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDevice3(ID2D1Factory7* pThis, [NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("ID2D1Device3 **")] ID2D1Device3** d2dDevice3);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDevice4(ID2D1Factory7* pThis, [NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("ID2D1Device4 **")] ID2D1Device4** d2dDevice4);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDevice5(ID2D1Factory7* pThis, [NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("ID2D1Device5 **")] ID2D1Device5** d2dDevice5);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDevice6(ID2D1Factory7* pThis, [NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("ID2D1Device6 **")] ID2D1Device6** d2dDevice6);

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION &")] D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription, [NativeTypeName("ID2D1DrawingStateBlock **")] ID2D1DrawingStateBlock** drawingStateBlock)
        {
            return CreateDrawingStateBlock(drawingStateDescription, null, drawingStateBlock);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock([NativeTypeName("ID2D1DrawingStateBlock **")] ID2D1DrawingStateBlock** drawingStateBlock)
        {
            return CreateDrawingStateBlock(null, null, drawingStateBlock);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION1 &")] D2D1_DRAWING_STATE_DESCRIPTION1* drawingStateDescription, [NativeTypeName("ID2D1DrawingStateBlock1 **")] ID2D1DrawingStateBlock1** drawingStateBlock)
        {
            return CreateDrawingStateBlock(drawingStateDescription, null, drawingStateBlock);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock([NativeTypeName("ID2D1DrawingStateBlock1 **")] ID2D1DrawingStateBlock1** drawingStateBlock)
        {
            return CreateDrawingStateBlock(null, null, drawingStateBlock);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1Factory7*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1Factory7*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1Factory7*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReloadSystemMetrics()
        {
            return Marshal.GetDelegateForFunctionPointer<_ReloadSystemMetrics>(lpVtbl->ReloadSystemMetrics)((ID2D1Factory7*)Unsafe.AsPointer(ref this));
        }

        public void GetDesktopDpi([NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDesktopDpi>(lpVtbl->GetDesktopDpi)((ID2D1Factory7*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRectangleGeometry([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rectangle, [NativeTypeName("ID2D1RectangleGeometry **")] ID2D1RectangleGeometry** rectangleGeometry)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRectangleGeometry>(lpVtbl->CreateRectangleGeometry)((ID2D1Factory7*)Unsafe.AsPointer(ref this), rectangle, rectangleGeometry);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRoundedRectangleGeometry([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRectangle, [NativeTypeName("ID2D1RoundedRectangleGeometry **")] ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRoundedRectangleGeometry>(lpVtbl->CreateRoundedRectangleGeometry)((ID2D1Factory7*)Unsafe.AsPointer(ref this), roundedRectangle, roundedRectangleGeometry);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEllipseGeometry([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, [NativeTypeName("ID2D1EllipseGeometry **")] ID2D1EllipseGeometry** ellipseGeometry)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateEllipseGeometry>(lpVtbl->CreateEllipseGeometry)((ID2D1Factory7*)Unsafe.AsPointer(ref this), ellipse, ellipseGeometry);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryGroup(D2D1_FILL_MODE fillMode, [NativeTypeName("ID2D1Geometry **")] ID2D1Geometry** geometries, [NativeTypeName("UINT32")] uint geometriesCount, [NativeTypeName("ID2D1GeometryGroup **")] ID2D1GeometryGroup** geometryGroup)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateGeometryGroup>(lpVtbl->CreateGeometryGroup)((ID2D1Factory7*)Unsafe.AsPointer(ref this), fillMode, geometries, geometriesCount, geometryGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransformedGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* sourceGeometry, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform, [NativeTypeName("ID2D1TransformedGeometry **")] ID2D1TransformedGeometry** transformedGeometry)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTransformedGeometry>(lpVtbl->CreateTransformedGeometry)((ID2D1Factory7*)Unsafe.AsPointer(ref this), sourceGeometry, transform, transformedGeometry);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePathGeometry([NativeTypeName("ID2D1PathGeometry **")] ID2D1PathGeometry** pathGeometry)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreatePathGeometry>(lpVtbl->CreatePathGeometry)((ID2D1Factory7*)Unsafe.AsPointer(ref this), pathGeometry);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStrokeStyle([NativeTypeName("const D2D1_STROKE_STYLE_PROPERTIES *")] D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties, [NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("ID2D1StrokeStyle **")] ID2D1StrokeStyle** strokeStyle)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateStrokeStyle>(lpVtbl->CreateStrokeStyle)((ID2D1Factory7*)Unsafe.AsPointer(ref this), strokeStyleProperties, dashes, dashesCount, strokeStyle);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams, [NativeTypeName("ID2D1DrawingStateBlock **")] ID2D1DrawingStateBlock** drawingStateBlock)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDrawingStateBlock>(lpVtbl->CreateDrawingStateBlock)((ID2D1Factory7*)Unsafe.AsPointer(ref this), drawingStateDescription, textRenderingParams, drawingStateBlock);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateWicBitmapRenderTarget([NativeTypeName("IWICBitmap *")] IWICBitmap* target, [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, [NativeTypeName("ID2D1RenderTarget **")] ID2D1RenderTarget** renderTarget)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateWicBitmapRenderTarget>(lpVtbl->CreateWicBitmapRenderTarget)((ID2D1Factory7*)Unsafe.AsPointer(ref this), target, renderTargetProperties, renderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHwndRenderTarget([NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, [NativeTypeName("const D2D1_HWND_RENDER_TARGET_PROPERTIES *")] D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties, [NativeTypeName("ID2D1HwndRenderTarget **")] ID2D1HwndRenderTarget** hwndRenderTarget)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateHwndRenderTarget>(lpVtbl->CreateHwndRenderTarget)((ID2D1Factory7*)Unsafe.AsPointer(ref this), renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDxgiSurfaceRenderTarget([NativeTypeName("IDXGISurface *")] IDXGISurface* dxgiSurface, [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, [NativeTypeName("ID2D1RenderTarget **")] ID2D1RenderTarget** renderTarget)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDxgiSurfaceRenderTarget>(lpVtbl->CreateDxgiSurfaceRenderTarget)((ID2D1Factory7*)Unsafe.AsPointer(ref this), dxgiSurface, renderTargetProperties, renderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDCRenderTarget([NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, [NativeTypeName("ID2D1DCRenderTarget **")] ID2D1DCRenderTarget** dcRenderTarget)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDCRenderTarget>(lpVtbl->CreateDCRenderTarget)((ID2D1Factory7*)Unsafe.AsPointer(ref this), renderTargetProperties, dcRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDevice([NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("ID2D1Device **")] ID2D1Device** d2dDevice)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDevice>(lpVtbl->CreateDevice)((ID2D1Factory7*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStrokeStyle([NativeTypeName("const D2D1_STROKE_STYLE_PROPERTIES1 *")] D2D1_STROKE_STYLE_PROPERTIES1* strokeStyleProperties, [NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("ID2D1StrokeStyle1 **")] ID2D1StrokeStyle1** strokeStyle)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateStrokeStyle1>(lpVtbl->CreateStrokeStyle1)((ID2D1Factory7*)Unsafe.AsPointer(ref this), strokeStyleProperties, dashes, dashesCount, strokeStyle);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePathGeometry([NativeTypeName("ID2D1PathGeometry1 **")] ID2D1PathGeometry1** pathGeometry)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreatePathGeometry1>(lpVtbl->CreatePathGeometry1)((ID2D1Factory7*)Unsafe.AsPointer(ref this), pathGeometry);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION1 *")] D2D1_DRAWING_STATE_DESCRIPTION1* drawingStateDescription, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams, [NativeTypeName("ID2D1DrawingStateBlock1 **")] ID2D1DrawingStateBlock1** drawingStateBlock)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDrawingStateBlock1>(lpVtbl->CreateDrawingStateBlock1)((ID2D1Factory7*)Unsafe.AsPointer(ref this), drawingStateDescription, textRenderingParams, drawingStateBlock);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGdiMetafile([NativeTypeName("IStream *")] IStream* metafileStream, [NativeTypeName("ID2D1GdiMetafile **")] ID2D1GdiMetafile** metafile)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateGdiMetafile>(lpVtbl->CreateGdiMetafile)((ID2D1Factory7*)Unsafe.AsPointer(ref this), metafileStream, metafile);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterEffectFromStream([NativeTypeName("const IID &")] Guid* classId, [NativeTypeName("IStream *")] IStream* propertyXml, [NativeTypeName("const D2D1_PROPERTY_BINDING *")] D2D1_PROPERTY_BINDING* bindings, [NativeTypeName("UINT32")] uint bindingsCount, [NativeTypeName("const PD2D1_EFFECT_FACTORY")] IntPtr effectFactory)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterEffectFromStream>(lpVtbl->RegisterEffectFromStream)((ID2D1Factory7*)Unsafe.AsPointer(ref this), classId, propertyXml, bindings, bindingsCount, effectFactory);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterEffectFromString([NativeTypeName("const IID &")] Guid* classId, [NativeTypeName("PCWSTR")] ushort* propertyXml, [NativeTypeName("const D2D1_PROPERTY_BINDING *")] D2D1_PROPERTY_BINDING* bindings, [NativeTypeName("UINT32")] uint bindingsCount, [NativeTypeName("const PD2D1_EFFECT_FACTORY")] IntPtr effectFactory)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterEffectFromString>(lpVtbl->RegisterEffectFromString)((ID2D1Factory7*)Unsafe.AsPointer(ref this), classId, propertyXml, bindings, bindingsCount, effectFactory);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterEffect([NativeTypeName("const IID &")] Guid* classId)
        {
            return Marshal.GetDelegateForFunctionPointer<_UnregisterEffect>(lpVtbl->UnregisterEffect)((ID2D1Factory7*)Unsafe.AsPointer(ref this), classId);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRegisteredEffects([NativeTypeName("CLSID *")] Guid* effects, [NativeTypeName("UINT32")] uint effectsCount, [NativeTypeName("UINT32 *")] uint* effectsReturned, [NativeTypeName("UINT32 *")] uint* effectsRegistered)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRegisteredEffects>(lpVtbl->GetRegisteredEffects)((ID2D1Factory7*)Unsafe.AsPointer(ref this), effects, effectsCount, effectsReturned, effectsRegistered);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEffectProperties([NativeTypeName("const IID &")] Guid* effectId, [NativeTypeName("ID2D1Properties **")] ID2D1Properties** properties)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEffectProperties>(lpVtbl->GetEffectProperties)((ID2D1Factory7*)Unsafe.AsPointer(ref this), effectId, properties);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDevice([NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("ID2D1Device1 **")] ID2D1Device1** d2dDevice1)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDevice1>(lpVtbl->CreateDevice1)((ID2D1Factory7*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice1);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDevice([NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("ID2D1Device2 **")] ID2D1Device2** d2dDevice2)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDevice2>(lpVtbl->CreateDevice2)((ID2D1Factory7*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice2);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDevice([NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("ID2D1Device3 **")] ID2D1Device3** d2dDevice3)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDevice3>(lpVtbl->CreateDevice3)((ID2D1Factory7*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice3);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDevice([NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("ID2D1Device4 **")] ID2D1Device4** d2dDevice4)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDevice4>(lpVtbl->CreateDevice4)((ID2D1Factory7*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice4);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDevice([NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("ID2D1Device5 **")] ID2D1Device5** d2dDevice5)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDevice5>(lpVtbl->CreateDevice5)((ID2D1Factory7*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice5);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDevice([NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("ID2D1Device6 **")] ID2D1Device6** d2dDevice6)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDevice6>(lpVtbl->CreateDevice6)((ID2D1Factory7*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice6);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ReloadSystemMetrics;

            [NativeTypeName("void (FLOAT *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDesktopDpi;

            [NativeTypeName("HRESULT (const D2D1_RECT_F *, ID2D1RectangleGeometry **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateRectangleGeometry;

            [NativeTypeName("HRESULT (const D2D1_ROUNDED_RECT *, ID2D1RoundedRectangleGeometry **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateRoundedRectangleGeometry;

            [NativeTypeName("HRESULT (const D2D1_ELLIPSE *, ID2D1EllipseGeometry **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateEllipseGeometry;

            [NativeTypeName("HRESULT (D2D1_FILL_MODE, ID2D1Geometry **, UINT32, ID2D1GeometryGroup **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateGeometryGroup;

            [NativeTypeName("HRESULT (ID2D1Geometry *, const D2D1_MATRIX_3X2_F *, ID2D1TransformedGeometry **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTransformedGeometry;

            [NativeTypeName("HRESULT (ID2D1PathGeometry **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreatePathGeometry;

            [NativeTypeName("HRESULT (const D2D1_STROKE_STYLE_PROPERTIES *, const FLOAT *, UINT32, ID2D1StrokeStyle **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateStrokeStyle;

            [NativeTypeName("HRESULT (const D2D1_DRAWING_STATE_DESCRIPTION *, IDWriteRenderingParams *, ID2D1DrawingStateBlock **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateDrawingStateBlock;

            [NativeTypeName("HRESULT (IWICBitmap *, const D2D1_RENDER_TARGET_PROPERTIES *, ID2D1RenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateWicBitmapRenderTarget;

            [NativeTypeName("HRESULT (const D2D1_RENDER_TARGET_PROPERTIES *, const D2D1_HWND_RENDER_TARGET_PROPERTIES *, ID2D1HwndRenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateHwndRenderTarget;

            [NativeTypeName("HRESULT (IDXGISurface *, const D2D1_RENDER_TARGET_PROPERTIES *, ID2D1RenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateDxgiSurfaceRenderTarget;

            [NativeTypeName("HRESULT (const D2D1_RENDER_TARGET_PROPERTIES *, ID2D1DCRenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateDCRenderTarget;

            [NativeTypeName("HRESULT (IDXGIDevice *, ID2D1Device **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateDevice;

            [NativeTypeName("HRESULT (const D2D1_STROKE_STYLE_PROPERTIES1 *, const FLOAT *, UINT32, ID2D1StrokeStyle1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateStrokeStyle1;

            [NativeTypeName("HRESULT (ID2D1PathGeometry1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreatePathGeometry1;

            [NativeTypeName("HRESULT (const D2D1_DRAWING_STATE_DESCRIPTION1 *, IDWriteRenderingParams *, ID2D1DrawingStateBlock1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateDrawingStateBlock1;

            [NativeTypeName("HRESULT (IStream *, ID2D1GdiMetafile **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateGdiMetafile;

            [NativeTypeName("HRESULT (const IID &, IStream *, const D2D1_PROPERTY_BINDING *, UINT32, const PD2D1_EFFECT_FACTORY) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr RegisterEffectFromStream;

            [NativeTypeName("HRESULT (const IID &, PCWSTR, const D2D1_PROPERTY_BINDING *, UINT32, const PD2D1_EFFECT_FACTORY) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr RegisterEffectFromString;

            [NativeTypeName("HRESULT (const IID &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr UnregisterEffect;

            [NativeTypeName("HRESULT (CLSID *, UINT32, UINT32 *, UINT32 *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetRegisteredEffects;

            [NativeTypeName("HRESULT (const IID &, ID2D1Properties **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetEffectProperties;

            [NativeTypeName("HRESULT (IDXGIDevice *, ID2D1Device1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateDevice1;

            [NativeTypeName("HRESULT (IDXGIDevice *, ID2D1Device2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateDevice2;

            [NativeTypeName("HRESULT (IDXGIDevice *, ID2D1Device3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateDevice3;

            [NativeTypeName("HRESULT (IDXGIDevice *, ID2D1Device4 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateDevice4;

            [NativeTypeName("HRESULT (IDXGIDevice *, ID2D1Device5 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateDevice5;

            [NativeTypeName("HRESULT (IDXGIDevice *, ID2D1Device6 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateDevice6;
        }
    }
}
