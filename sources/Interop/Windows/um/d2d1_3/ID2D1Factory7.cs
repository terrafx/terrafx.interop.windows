// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BDC2BDD3-B96C-4DE6-BDF7-99D4745454DE")]
    [NativeTypeName("struct ID2D1Factory7 : ID2D1Factory6")]
    public unsafe partial struct ID2D1Factory7
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION &")] D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription, ID2D1DrawingStateBlock** drawingStateBlock)
        {
            return CreateDrawingStateBlock(drawingStateDescription, null, drawingStateBlock);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock(ID2D1DrawingStateBlock** drawingStateBlock)
        {
            return CreateDrawingStateBlock(null, null, drawingStateBlock);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION1 &")] D2D1_DRAWING_STATE_DESCRIPTION1* drawingStateDescription, ID2D1DrawingStateBlock1** drawingStateBlock)
        {
            return CreateDrawingStateBlock(drawingStateDescription, null, drawingStateBlock);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock(ID2D1DrawingStateBlock1** drawingStateBlock)
        {
            return CreateDrawingStateBlock(null, null, drawingStateBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1Factory7*, uint>)(lpVtbl[1]))((ID2D1Factory7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1Factory7*, uint>)(lpVtbl[2]))((ID2D1Factory7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReloadSystemMetrics()
        {
            return ((delegate* unmanaged<ID2D1Factory7*, int>)(lpVtbl[3]))((ID2D1Factory7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDesktopDpi([NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY)
        {
            ((delegate* unmanaged<ID2D1Factory7*, float*, float*, void>)(lpVtbl[4]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRectangleGeometry([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rectangle, ID2D1RectangleGeometry** rectangleGeometry)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, D2D_RECT_F*, ID2D1RectangleGeometry**, int>)(lpVtbl[5]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), rectangle, rectangleGeometry);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRoundedRectangleGeometry([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, D2D1_ROUNDED_RECT*, ID2D1RoundedRectangleGeometry**, int>)(lpVtbl[6]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), roundedRectangle, roundedRectangleGeometry);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEllipseGeometry([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, ID2D1EllipseGeometry** ellipseGeometry)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, D2D1_ELLIPSE*, ID2D1EllipseGeometry**, int>)(lpVtbl[7]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), ellipse, ellipseGeometry);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryGroup(D2D1_FILL_MODE fillMode, ID2D1Geometry** geometries, [NativeTypeName("UINT32")] uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, D2D1_FILL_MODE, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)(lpVtbl[8]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), fillMode, geometries, geometriesCount, geometryGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform, ID2D1TransformedGeometry** transformedGeometry)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, ID2D1Geometry*, D2D_MATRIX_3X2_F*, ID2D1TransformedGeometry**, int>)(lpVtbl[9]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), sourceGeometry, transform, transformedGeometry);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePathGeometry(ID2D1PathGeometry** pathGeometry)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, ID2D1PathGeometry**, int>)(lpVtbl[10]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), pathGeometry);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStrokeStyle([NativeTypeName("const D2D1_STROKE_STYLE_PROPERTIES *")] D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties, [NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, ID2D1StrokeStyle** strokeStyle)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, D2D1_STROKE_STYLE_PROPERTIES*, float*, uint, ID2D1StrokeStyle**, int>)(lpVtbl[11]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), strokeStyleProperties, dashes, dashesCount, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, D2D1_DRAWING_STATE_DESCRIPTION*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)(lpVtbl[12]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), drawingStateDescription, textRenderingParams, drawingStateBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWicBitmapRenderTarget(IWICBitmap* target, [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, IWICBitmap*, D2D1_RENDER_TARGET_PROPERTIES*, ID2D1RenderTarget**, int>)(lpVtbl[13]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), target, renderTargetProperties, renderTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateHwndRenderTarget([NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, [NativeTypeName("const D2D1_HWND_RENDER_TARGET_PROPERTIES *")] D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, D2D1_RENDER_TARGET_PROPERTIES*, D2D1_HWND_RENDER_TARGET_PROPERTIES*, ID2D1HwndRenderTarget**, int>)(lpVtbl[14]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDxgiSurfaceRenderTarget(IDXGISurface* dxgiSurface, [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, IDXGISurface*, D2D1_RENDER_TARGET_PROPERTIES*, ID2D1RenderTarget**, int>)(lpVtbl[15]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), dxgiSurface, renderTargetProperties, renderTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDCRenderTarget([NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, D2D1_RENDER_TARGET_PROPERTIES*, ID2D1DCRenderTarget**, int>)(lpVtbl[16]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), renderTargetProperties, dcRenderTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDevice(IDXGIDevice* dxgiDevice, ID2D1Device** d2dDevice)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, IDXGIDevice*, ID2D1Device**, int>)(lpVtbl[17]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStrokeStyle([NativeTypeName("const D2D1_STROKE_STYLE_PROPERTIES1 *")] D2D1_STROKE_STYLE_PROPERTIES1* strokeStyleProperties, [NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, ID2D1StrokeStyle1** strokeStyle)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, D2D1_STROKE_STYLE_PROPERTIES1*, float*, uint, ID2D1StrokeStyle1**, int>)(lpVtbl[18]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), strokeStyleProperties, dashes, dashesCount, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePathGeometry(ID2D1PathGeometry1** pathGeometry)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, ID2D1PathGeometry1**, int>)(lpVtbl[19]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), pathGeometry);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION1 *")] D2D1_DRAWING_STATE_DESCRIPTION1* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock1** drawingStateBlock)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, D2D1_DRAWING_STATE_DESCRIPTION1*, IDWriteRenderingParams*, ID2D1DrawingStateBlock1**, int>)(lpVtbl[20]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), drawingStateDescription, textRenderingParams, drawingStateBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGdiMetafile(IStream* metafileStream, ID2D1GdiMetafile** metafile)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, IStream*, ID2D1GdiMetafile**, int>)(lpVtbl[21]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), metafileStream, metafile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterEffectFromStream([NativeTypeName("const IID &")] Guid* classId, IStream* propertyXml, [NativeTypeName("const D2D1_PROPERTY_BINDING *")] D2D1_PROPERTY_BINDING* bindings, [NativeTypeName("UINT32")] uint bindingsCount, [NativeTypeName("const PD2D1_EFFECT_FACTORY")] delegate* unmanaged<IUnknown**, int> effectFactory)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, Guid*, IStream*, D2D1_PROPERTY_BINDING*, uint, delegate* unmanaged<IUnknown**, int>, int>)(lpVtbl[22]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), classId, propertyXml, bindings, bindingsCount, effectFactory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterEffectFromString([NativeTypeName("const IID &")] Guid* classId, [NativeTypeName("PCWSTR")] ushort* propertyXml, [NativeTypeName("const D2D1_PROPERTY_BINDING *")] D2D1_PROPERTY_BINDING* bindings, [NativeTypeName("UINT32")] uint bindingsCount, [NativeTypeName("const PD2D1_EFFECT_FACTORY")] delegate* unmanaged<IUnknown**, int> effectFactory)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, Guid*, ushort*, D2D1_PROPERTY_BINDING*, uint, delegate* unmanaged<IUnknown**, int>, int>)(lpVtbl[23]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), classId, propertyXml, bindings, bindingsCount, effectFactory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterEffect([NativeTypeName("const IID &")] Guid* classId)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, Guid*, int>)(lpVtbl[24]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), classId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRegisteredEffects([NativeTypeName("CLSID *")] Guid* effects, [NativeTypeName("UINT32")] uint effectsCount, [NativeTypeName("UINT32 *")] uint* effectsReturned, [NativeTypeName("UINT32 *")] uint* effectsRegistered)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, Guid*, uint, uint*, uint*, int>)(lpVtbl[25]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), effects, effectsCount, effectsReturned, effectsRegistered);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEffectProperties([NativeTypeName("const IID &")] Guid* effectId, ID2D1Properties** properties)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, Guid*, ID2D1Properties**, int>)(lpVtbl[26]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), effectId, properties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDevice(IDXGIDevice* dxgiDevice, ID2D1Device1** d2dDevice1)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, IDXGIDevice*, ID2D1Device1**, int>)(lpVtbl[27]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDevice(IDXGIDevice* dxgiDevice, ID2D1Device2** d2dDevice2)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, IDXGIDevice*, ID2D1Device2**, int>)(lpVtbl[28]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDevice(IDXGIDevice* dxgiDevice, ID2D1Device3** d2dDevice3)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, IDXGIDevice*, ID2D1Device3**, int>)(lpVtbl[29]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDevice(IDXGIDevice* dxgiDevice, ID2D1Device4** d2dDevice4)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, IDXGIDevice*, ID2D1Device4**, int>)(lpVtbl[30]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDevice(IDXGIDevice* dxgiDevice, ID2D1Device5** d2dDevice5)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, IDXGIDevice*, ID2D1Device5**, int>)(lpVtbl[31]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice5);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDevice(IDXGIDevice* dxgiDevice, ID2D1Device6** d2dDevice6)
        {
            return ((delegate* unmanaged<ID2D1Factory7*, IDXGIDevice*, ID2D1Device6**, int>)(lpVtbl[32]))((ID2D1Factory7*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice6);
        }
    }
}
