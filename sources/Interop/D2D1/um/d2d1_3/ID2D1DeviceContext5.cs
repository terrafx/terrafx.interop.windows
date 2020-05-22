// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_ALPHA_MODE;
using static TerraFX.Interop.D2D1_BITMAP_INTERPOLATION_MODE;
using static TerraFX.Interop.D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION;
using static TerraFX.Interop.D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS;
using static TerraFX.Interop.D2D1_COMPOSITE_MODE;
using static TerraFX.Interop.D2D1_DRAW_TEXT_OPTIONS;
using static TerraFX.Interop.D2D1_EXTEND_MODE;
using static TerraFX.Interop.D2D1_GAMMA;
using static TerraFX.Interop.D2D1_IMAGE_SOURCE_LOADING_OPTIONS;
using static TerraFX.Interop.D2D1_INTERPOLATION_MODE;
using static TerraFX.Interop.D2D1_SPRITE_OPTIONS;
using static TerraFX.Interop.DWRITE_MEASURING_MODE;

namespace TerraFX.Interop
{
    [Guid("7836D248-68CC-4DF6-B9E8-DE991BF62EB7")]
    public unsafe partial struct ID2D1DeviceContext5
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1DeviceContext5* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1DeviceContext5* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1DeviceContext5* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmap(ID2D1DeviceContext5* pThis, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [NativeTypeName("const void *")] void* srcData, [NativeTypeName("UINT32")] uint pitch, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromWicBitmap(ID2D1DeviceContext5* pThis, [NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSharedBitmap(ID2D1DeviceContext5* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* data, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapBrush(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES *")] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1BitmapBrush **")] ID2D1BitmapBrush** bitmapBrush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSolidColorBrush(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1SolidColorBrush **")] ID2D1SolidColorBrush** solidColorBrush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGradientStopCollection(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, [NativeTypeName("ID2D1GradientStopCollection **")] ID2D1GradientStopCollection** gradientStopCollection);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateLinearGradientBrush(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES *")] D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1LinearGradientBrush **")] ID2D1LinearGradientBrush** linearGradientBrush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRadialGradientBrush(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES *")] D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1RadialGradientBrush **")] ID2D1RadialGradientBrush** radialGradientBrush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCompatibleRenderTarget(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* desiredSize, [NativeTypeName("const D2D1_SIZE_U *")] D2D_SIZE_U* desiredPixelSize, [NativeTypeName("const D2D1_PIXEL_FORMAT *")] D2D1_PIXEL_FORMAT* desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateLayer(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* size, [NativeTypeName("ID2D1Layer **")] ID2D1Layer** layer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMesh(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Mesh **")] ID2D1Mesh** mesh);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawLine(ID2D1DeviceContext5* pThis, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawRectangle(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillRectangle(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawRoundedRectangle(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillRoundedRectangle(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawEllipse(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillEllipse(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawGeometry(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillGeometry(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* opacityBrush = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillMesh(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Mesh *")] ID2D1Mesh* mesh, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillOpacityMask(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* opacityMask, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, D2D1_OPACITY_MASK_CONTENT content, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawBitmap(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("FLOAT")] float opacity = 1.0f, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawText(ID2D1DeviceContext5* pThis, [NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* layoutRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawTextLayout(ID2D1DeviceContext5* pThis, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F origin, [NativeTypeName("IDWriteTextLayout *")] IDWriteTextLayout* textLayout, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawGlyphRun(ID2D1DeviceContext5* pThis, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTransform(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTransform(ID2D1DeviceContext5* pThis, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetAntialiasMode(ID2D1DeviceContext5* pThis, D2D1_ANTIALIAS_MODE antialiasMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_ANTIALIAS_MODE _GetAntialiasMode(ID2D1DeviceContext5* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTextAntialiasMode(ID2D1DeviceContext5* pThis, D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_TEXT_ANTIALIAS_MODE _GetTextAntialiasMode(ID2D1DeviceContext5* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTextRenderingParams(ID2D1DeviceContext5* pThis, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTextRenderingParams(ID2D1DeviceContext5* pThis, [NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** textRenderingParams);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTags(ID2D1DeviceContext5* pThis, [NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTags(ID2D1DeviceContext5* pThis, [NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PushLayer(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_LAYER_PARAMETERS *")] D2D1_LAYER_PARAMETERS* layerParameters, [NativeTypeName("ID2D1Layer *")] ID2D1Layer* layer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PopLayer(ID2D1DeviceContext5* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Flush(ID2D1DeviceContext5* pThis, [NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SaveDrawingState(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1DrawingStateBlock *")] ID2D1DrawingStateBlock* drawingStateBlock);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _RestoreDrawingState(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1DrawingStateBlock *")] ID2D1DrawingStateBlock* drawingStateBlock);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PushAxisAlignedClip(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PopAxisAlignedClip(ID2D1DeviceContext5* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Clear(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* clearColor = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _BeginDraw(ID2D1DeviceContext5* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EndDraw(ID2D1DeviceContext5* pThis, [NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_PIXEL_FORMAT* _GetPixelFormat(ID2D1DeviceContext5* pThis, D2D1_PIXEL_FORMAT* _result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetDpi(ID2D1DeviceContext5* pThis, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDpi(ID2D1DeviceContext5* pThis, [NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_SIZE_F")]
        public delegate D2D_SIZE_F* _GetSize(ID2D1DeviceContext5* pThis, D2D_SIZE_F* _result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_SIZE_U")]
        public delegate D2D_SIZE_U* _GetPixelSize(ID2D1DeviceContext5* pThis, D2D_SIZE_U* _result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetMaximumBitmapSize(ID2D1DeviceContext5* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsSupported(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmap1(ID2D1DeviceContext5* pThis, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [NativeTypeName("const void *")] void* sourceData, [NativeTypeName("UINT32")] uint pitch, [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")] D2D1_BITMAP_PROPERTIES1* bitmapProperties, [NativeTypeName("ID2D1Bitmap1 **")] ID2D1Bitmap1** bitmap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromWicBitmap1(ID2D1DeviceContext5* pThis, [NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")] D2D1_BITMAP_PROPERTIES1* bitmapProperties, [NativeTypeName("ID2D1Bitmap1 **")] ID2D1Bitmap1** bitmap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContext(ID2D1DeviceContext5* pThis, D2D1_COLOR_SPACE space, [NativeTypeName("const BYTE *")] byte* profile, [NativeTypeName("UINT32")] uint profileSize, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContextFromFilename(ID2D1DeviceContext5* pThis, [NativeTypeName("PCWSTR")] ushort* filename, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContextFromWicColorContext(ID2D1DeviceContext5* pThis, [NativeTypeName("IWICColorContext *")] IWICColorContext* wicColorContext, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromDxgiSurface(ID2D1DeviceContext5* pThis, [NativeTypeName("IDXGISurface *")] IDXGISurface* surface, [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")] D2D1_BITMAP_PROPERTIES1* bitmapProperties, [NativeTypeName("ID2D1Bitmap1 **")] ID2D1Bitmap1** bitmap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEffect(ID2D1DeviceContext5* pThis, [NativeTypeName("const IID &")] Guid* effectId, [NativeTypeName("ID2D1Effect **")] ID2D1Effect** effect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGradientStopCollection1(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* straightAlphaGradientStops, [NativeTypeName("UINT32")] uint straightAlphaGradientStopsCount, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, [NativeTypeName("ID2D1GradientStopCollection1 **")] ID2D1GradientStopCollection1** gradientStopCollection1);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateImageBrush(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("const D2D1_IMAGE_BRUSH_PROPERTIES *")] D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1ImageBrush **")] ID2D1ImageBrush** imageBrush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapBrush1(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES1 *")] D2D1_BITMAP_BRUSH_PROPERTIES1* bitmapBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1BitmapBrush1 **")] ID2D1BitmapBrush1** bitmapBrush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommandList(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1CommandList **")] ID2D1CommandList** commandList);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsDxgiFormatSupported(ID2D1DeviceContext5* pThis, DXGI_FORMAT format);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsBufferPrecisionSupported(ID2D1DeviceContext5* pThis, D2D1_BUFFER_PRECISION bufferPrecision);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetImageLocalBounds(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* localBounds);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetImageWorldBounds(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* worldBounds);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGlyphRunWorldBounds(ID2D1DeviceContext5* pThis, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDevice(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Device **")] ID2D1Device** device);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTarget(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Image *")] ID2D1Image* image);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTarget(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Image **")] ID2D1Image** image);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetRenderingControls(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_RENDERING_CONTROLS *")] D2D1_RENDERING_CONTROLS* renderingControls);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetRenderingControls(ID2D1DeviceContext5* pThis, [NativeTypeName("D2D1_RENDERING_CONTROLS *")] D2D1_RENDERING_CONTROLS* renderingControls);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetPrimitiveBlend(ID2D1DeviceContext5* pThis, D2D1_PRIMITIVE_BLEND primitiveBlend);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_PRIMITIVE_BLEND _GetPrimitiveBlend(ID2D1DeviceContext5* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetUnitMode(ID2D1DeviceContext5* pThis, D2D1_UNIT_MODE unitMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_UNIT_MODE _GetUnitMode(ID2D1DeviceContext5* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawGlyphRun1(ID2D1DeviceContext5* pThis, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawImage(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle = null, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawGdiMetafile(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1GdiMetafile *")] ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawBitmap1(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("FLOAT")] float opacity, D2D1_INTERPOLATION_MODE interpolationMode, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null, [NativeTypeName("const D2D1_MATRIX_4X4_F *")] D2D_MATRIX_4X4_F* perspectiveTransform = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PushLayer1(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_LAYER_PARAMETERS1 *")] D2D1_LAYER_PARAMETERS1* layerParameters, [NativeTypeName("ID2D1Layer *")] ID2D1Layer* layer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InvalidateEffectInputRectangle(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("UINT32")] uint input, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* inputRectangle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEffectInvalidRectangleCount(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("UINT32 *")] uint* rectangleCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEffectInvalidRectangles(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* rectangles, [NativeTypeName("UINT32")] uint rectanglesCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEffectRequiredInputRectangles(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Effect *")] ID2D1Effect* renderEffect, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* renderImageRectangle, [NativeTypeName("const D2D1_EFFECT_INPUT_DESCRIPTION *")] D2D1_EFFECT_INPUT_DESCRIPTION* inputDescriptions, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* requiredInputRects, [NativeTypeName("UINT32")] uint inputCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillOpacityMask1(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* opacityMask, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFilledGeometryRealization(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("ID2D1GeometryRealization **")] ID2D1GeometryRealization** geometryRealization);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStrokedGeometryRealization(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle, [NativeTypeName("ID2D1GeometryRealization **")] ID2D1GeometryRealization** geometryRealization);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawGeometryRealization(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1GeometryRealization *")] ID2D1GeometryRealization* geometryRealization, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInk(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_INK_POINT *")] D2D1_INK_POINT* startPoint, [NativeTypeName("ID2D1Ink **")] ID2D1Ink** ink);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInkStyle(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_INK_STYLE_PROPERTIES *")] D2D1_INK_STYLE_PROPERTIES* inkStyleProperties, [NativeTypeName("ID2D1InkStyle **")] ID2D1InkStyle** inkStyle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGradientMesh(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_GRADIENT_MESH_PATCH *")] D2D1_GRADIENT_MESH_PATCH* patches, [NativeTypeName("UINT32")] uint patchesCount, [NativeTypeName("ID2D1GradientMesh **")] ID2D1GradientMesh** gradientMesh);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateImageSourceFromWic(ID2D1DeviceContext5* pThis, [NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, D2D1_IMAGE_SOURCE_LOADING_OPTIONS loadingOptions, D2D1_ALPHA_MODE alphaMode, [NativeTypeName("ID2D1ImageSourceFromWic **")] ID2D1ImageSourceFromWic** imageSource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateLookupTable3D(ID2D1DeviceContext5* pThis, D2D1_BUFFER_PRECISION precision, [NativeTypeName("const UINT32 *")] uint* extents, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("const UINT32 *")] uint* strides, [NativeTypeName("ID2D1LookupTable3D **")] ID2D1LookupTable3D** lookupTable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateImageSourceFromDxgi(ID2D1DeviceContext5* pThis, [NativeTypeName("IDXGISurface **")] IDXGISurface** surfaces, [NativeTypeName("UINT32")] uint surfaceCount, DXGI_COLOR_SPACE_TYPE colorSpace, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS options, [NativeTypeName("ID2D1ImageSource **")] ID2D1ImageSource** imageSource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGradientMeshWorldBounds(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1GradientMesh *")] ID2D1GradientMesh* gradientMesh, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* pBounds);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawInk(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1Ink *")] ID2D1Ink* ink, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("ID2D1InkStyle *")] ID2D1InkStyle* inkStyle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawGradientMesh(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1GradientMesh *")] ID2D1GradientMesh* gradientMesh);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawGdiMetafile1(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1GdiMetafile *")] ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTransformedImageSource(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1ImageSource *")] ID2D1ImageSource* imageSource, [NativeTypeName("const D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES *")] D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties, [NativeTypeName("ID2D1TransformedImageSource **")] ID2D1TransformedImageSource** transformedImageSource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSpriteBatch(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1SpriteBatch **")] ID2D1SpriteBatch** spriteBatch);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawSpriteBatch(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1SpriteBatch *")] ID2D1SpriteBatch* spriteBatch, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, D2D1_SPRITE_OPTIONS spriteOptions = D2D1_SPRITE_OPTIONS_NONE);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSvgGlyphStyle(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1SvgGlyphStyle **")] ID2D1SvgGlyphStyle** svgGlyphStyle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawText1(ID2D1DeviceContext5* pThis, [NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* layoutRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, [NativeTypeName("ID2D1SvgGlyphStyle *")] ID2D1SvgGlyphStyle* svgGlyphStyle, [NativeTypeName("UINT32")] uint colorPaletteIndex = 0, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawTextLayout1(ID2D1DeviceContext5* pThis, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F origin, [NativeTypeName("IDWriteTextLayout *")] IDWriteTextLayout* textLayout, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, [NativeTypeName("ID2D1SvgGlyphStyle *")] ID2D1SvgGlyphStyle* svgGlyphStyle, [NativeTypeName("UINT32")] uint colorPaletteIndex = 0, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawColorBitmapGlyphRun(ID2D1DeviceContext5* pThis, DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL, D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION bitmapSnapOption = D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DEFAULT);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawSvgGlyphRun(ID2D1DeviceContext5* pThis, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush = null, [NativeTypeName("ID2D1SvgGlyphStyle *")] ID2D1SvgGlyphStyle* svgGlyphStyle = null, [NativeTypeName("UINT32")] uint colorPaletteIndex = 0, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetColorBitmapGlyphImage(ID2D1DeviceContext5* pThis, DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F glyphOrigin, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("UINT16")] ushort glyphIndex, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* glyphTransform, [NativeTypeName("ID2D1Image **")] ID2D1Image** glyphImage);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSvgGlyphImage(ID2D1DeviceContext5* pThis, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F glyphOrigin, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("UINT16")] ushort glyphIndex, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, [NativeTypeName("ID2D1SvgGlyphStyle *")] ID2D1SvgGlyphStyle* svgGlyphStyle, [NativeTypeName("UINT32")] uint colorPaletteIndex, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* glyphTransform, [NativeTypeName("ID2D1CommandList **")] ID2D1CommandList** glyphImage);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSvgDocument(ID2D1DeviceContext5* pThis, [NativeTypeName("IStream *")] IStream* inputXmlStream, [NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F viewportSize, [NativeTypeName("ID2D1SvgDocument **")] ID2D1SvgDocument** svgDocument);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawSvgDocument(ID2D1DeviceContext5* pThis, [NativeTypeName("ID2D1SvgDocument *")] ID2D1SvgDocument* svgDocument);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContextFromDxgiColorSpace(ID2D1DeviceContext5* pThis, DXGI_COLOR_SPACE_TYPE colorSpace, [NativeTypeName("ID2D1ColorContext1 **")] ID2D1ColorContext1** colorContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContextFromSimpleColorProfile(ID2D1DeviceContext5* pThis, [NativeTypeName("const D2D1_SIMPLE_COLOR_PROFILE *")] D2D1_SIMPLE_COLOR_PROFILE* simpleProfile, [NativeTypeName("ID2D1ColorContext1 **")] ID2D1ColorContext1** colorContext);

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [NativeTypeName("const D2D1_BITMAP_PROPERTIES &")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return CreateBitmap(size, null, 0, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromWicBitmap([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return CreateBitmapFromWicBitmap(wicBitmapSource, null, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("ID2D1BitmapBrush **")] ID2D1BitmapBrush** bitmapBrush)
        {
            return CreateBitmapBrush(bitmap, null, null, bitmapBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES &")] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, [NativeTypeName("ID2D1BitmapBrush **")] ID2D1BitmapBrush** bitmapBrush)
        {
            return CreateBitmapBrush(bitmap, bitmapBrushProperties, null, bitmapBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSolidColorBrush([NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color, [NativeTypeName("ID2D1SolidColorBrush **")] ID2D1SolidColorBrush** solidColorBrush)
        {
            return CreateSolidColorBrush(color, null, solidColorBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGradientStopCollection([NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount, [NativeTypeName("ID2D1GradientStopCollection **")] ID2D1GradientStopCollection** gradientStopCollection)
        {
            return CreateGradientStopCollection(gradientStops, gradientStopsCount, D2D1_GAMMA_2_2, D2D1_EXTEND_MODE_CLAMP, gradientStopCollection);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLinearGradientBrush([NativeTypeName("const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES &")] D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1LinearGradientBrush **")] ID2D1LinearGradientBrush** linearGradientBrush)
        {
            return CreateLinearGradientBrush(linearGradientBrushProperties, null, gradientStopCollection, linearGradientBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRadialGradientBrush([NativeTypeName("const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES &")] D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1RadialGradientBrush **")] ID2D1RadialGradientBrush** radialGradientBrush)
        {
            return CreateRadialGradientBrush(radialGradientBrushProperties, null, gradientStopCollection, radialGradientBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(null, null, null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(&desiredSize, null, null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U desiredPixelSize, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U desiredPixelSize, D2D1_PIXEL_FORMAT desiredFormat, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, &desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U desiredPixelSize, D2D1_PIXEL_FORMAT desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, &desiredFormat, options, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLayer([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F size, [NativeTypeName("ID2D1Layer **")] ID2D1Layer** layer)
        {
            return CreateLayer(&size, layer);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLayer([NativeTypeName("ID2D1Layer **")] ID2D1Layer** layer)
        {
            return CreateLayer(null, layer);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromWicBitmap([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("ID2D1Bitmap1 **")] ID2D1Bitmap1** bitmap)
        {
            return CreateBitmapFromWicBitmap(wicBitmapSource, null, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageBrush([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("const D2D1_IMAGE_BRUSH_PROPERTIES &")] D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushProperties, [NativeTypeName("ID2D1ImageBrush **")] ID2D1ImageBrush** imageBrush)
        {
            return CreateImageBrush(image, imageBrushProperties, null, imageBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("ID2D1BitmapBrush1 **")] ID2D1BitmapBrush1** bitmapBrush)
        {
            return CreateBitmapBrush(bitmap, null, null, bitmapBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES1 &")] D2D1_BITMAP_BRUSH_PROPERTIES1* bitmapBrushProperties, [NativeTypeName("ID2D1BitmapBrush1 **")] ID2D1BitmapBrush1** bitmapBrush)
        {
            return CreateBitmapBrush(bitmap, bitmapBrushProperties, null, bitmapBrush);
        }

        public void DrawImage([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle = null, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            ID2D1Image* output = null;

            effect->GetOutput(&output);
            DrawImage(output, targetOffset, imageRectangle, interpolationMode, compositeMode);
            output->Release();
        }

        public void DrawImage([NativeTypeName("ID2D1Image *")] ID2D1Image* image, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(image, null, null, interpolationMode, compositeMode);
        }

        public void DrawImage([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(effect, null, null, interpolationMode, compositeMode);
        }

        public void DrawImage([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(image, &targetOffset, null, interpolationMode, compositeMode);
        }

        public void DrawImage([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(effect, &targetOffset, null, interpolationMode, compositeMode);
        }

        public void DrawImage([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset, [NativeTypeName("const D2D1_RECT_F &")] D2D_RECT_F* imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(image, &targetOffset, imageRectangle, interpolationMode, compositeMode);
        }

        public void DrawImage([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset, [NativeTypeName("const D2D1_RECT_F &")] D2D_RECT_F* imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(effect, &targetOffset, imageRectangle, interpolationMode, compositeMode);
        }

        public void DrawGdiMetafile([NativeTypeName("ID2D1GdiMetafile *")] ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset)
        {
            DrawGdiMetafile(gdiMetafile, &targetOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageSourceFromWic([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, D2D1_IMAGE_SOURCE_LOADING_OPTIONS loadingOptions, [NativeTypeName("ID2D1ImageSourceFromWic **")] ID2D1ImageSourceFromWic** imageSource)
        {
            return CreateImageSourceFromWic(wicBitmapSource, loadingOptions, D2D1_ALPHA_MODE_UNKNOWN, imageSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageSourceFromWic([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("ID2D1ImageSourceFromWic **")] ID2D1ImageSourceFromWic** imageSource)
        {
            return CreateImageSourceFromWic(wicBitmapSource, D2D1_IMAGE_SOURCE_LOADING_OPTIONS_NONE, D2D1_ALPHA_MODE_UNKNOWN, imageSource);
        }

        public void DrawSpriteBatch([NativeTypeName("ID2D1SpriteBatch *")] ID2D1SpriteBatch* spriteBatch, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, D2D1_SPRITE_OPTIONS spriteOptions = D2D1_SPRITE_OPTIONS_NONE)
        {
            DrawSpriteBatch(spriteBatch, 0, spriteBatch->GetSpriteCount(), bitmap, interpolationMode, spriteOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [NativeTypeName("const void *")] void* srcData, [NativeTypeName("UINT32")] uint pitch, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBitmap>(lpVtbl->CreateBitmap)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), size, srcData, pitch, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromWicBitmap([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromWicBitmap>(lpVtbl->CreateBitmapFromWicBitmap)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), wicBitmapSource, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSharedBitmap([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* data, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSharedBitmap>(lpVtbl->CreateSharedBitmap)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), riid, data, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES *")] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1BitmapBrush **")] ID2D1BitmapBrush** bitmapBrush)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBitmapBrush>(lpVtbl->CreateBitmapBrush)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSolidColorBrush([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1SolidColorBrush **")] ID2D1SolidColorBrush** solidColorBrush)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSolidColorBrush>(lpVtbl->CreateSolidColorBrush)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), color, brushProperties, solidColorBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGradientStopCollection([NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, [NativeTypeName("ID2D1GradientStopCollection **")] ID2D1GradientStopCollection** gradientStopCollection)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateGradientStopCollection>(lpVtbl->CreateGradientStopCollection)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLinearGradientBrush([NativeTypeName("const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES *")] D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1LinearGradientBrush **")] ID2D1LinearGradientBrush** linearGradientBrush)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateLinearGradientBrush>(lpVtbl->CreateLinearGradientBrush)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRadialGradientBrush([NativeTypeName("const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES *")] D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1RadialGradientBrush **")] ID2D1RadialGradientBrush** radialGradientBrush)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRadialGradientBrush>(lpVtbl->CreateRadialGradientBrush)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* desiredSize, [NativeTypeName("const D2D1_SIZE_U *")] D2D_SIZE_U* desiredPixelSize, [NativeTypeName("const D2D1_PIXEL_FORMAT *")] D2D1_PIXEL_FORMAT* desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCompatibleRenderTarget>(lpVtbl->CreateCompatibleRenderTarget)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLayer([NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* size, [NativeTypeName("ID2D1Layer **")] ID2D1Layer** layer)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateLayer>(lpVtbl->CreateLayer)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), size, layer);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMesh([NativeTypeName("ID2D1Mesh **")] ID2D1Mesh** mesh)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateMesh>(lpVtbl->CreateMesh)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), mesh);
        }

        public void DrawLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawLine>(lpVtbl->DrawLine)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), point0, point1, brush, strokeWidth, strokeStyle);
        }

        public void DrawRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawRectangle>(lpVtbl->DrawRectangle)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), rect, brush, strokeWidth, strokeStyle);
        }

        public void FillRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            Marshal.GetDelegateForFunctionPointer<_FillRectangle>(lpVtbl->FillRectangle)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), rect, brush);
        }

        public void DrawRoundedRectangle([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawRoundedRectangle>(lpVtbl->DrawRoundedRectangle)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), roundedRect, brush, strokeWidth, strokeStyle);
        }

        public void FillRoundedRectangle([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            Marshal.GetDelegateForFunctionPointer<_FillRoundedRectangle>(lpVtbl->FillRoundedRectangle)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), roundedRect, brush);
        }

        public void DrawEllipse([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawEllipse>(lpVtbl->DrawEllipse)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), ellipse, brush, strokeWidth, strokeStyle);
        }

        public void FillEllipse([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            Marshal.GetDelegateForFunctionPointer<_FillEllipse>(lpVtbl->FillEllipse)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), ellipse, brush);
        }

        public void DrawGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawGeometry>(lpVtbl->DrawGeometry)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), geometry, brush, strokeWidth, strokeStyle);
        }

        public void FillGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* opacityBrush = null)
        {
            Marshal.GetDelegateForFunctionPointer<_FillGeometry>(lpVtbl->FillGeometry)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), geometry, brush, opacityBrush);
        }

        public void FillMesh([NativeTypeName("ID2D1Mesh *")] ID2D1Mesh* mesh, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            Marshal.GetDelegateForFunctionPointer<_FillMesh>(lpVtbl->FillMesh)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), mesh, brush);
        }

        public void FillOpacityMask([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* opacityMask, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, D2D1_OPACITY_MASK_CONTENT content, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            Marshal.GetDelegateForFunctionPointer<_FillOpacityMask>(lpVtbl->FillOpacityMask)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), opacityMask, brush, content, destinationRectangle, sourceRectangle);
        }

        public void DrawBitmap([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("FLOAT")] float opacity = 1.0f, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawBitmap>(lpVtbl->DrawBitmap)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
        }

        public void DrawText([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* layoutRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawText>(lpVtbl->DrawText)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
        }

        public void DrawTextLayout([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F origin, [NativeTypeName("IDWriteTextLayout *")] IDWriteTextLayout* textLayout, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawTextLayout>(lpVtbl->DrawTextLayout)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), origin, textLayout, defaultFillBrush, options);
        }

        public void DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawGlyphRun>(lpVtbl->DrawGlyphRun)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, foregroundBrush, measuringMode);
        }

        public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            Marshal.GetDelegateForFunctionPointer<_SetTransform>(lpVtbl->SetTransform)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), transform);
        }

        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            Marshal.GetDelegateForFunctionPointer<_GetTransform>(lpVtbl->GetTransform)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), transform);
        }

        public void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode)
        {
            Marshal.GetDelegateForFunctionPointer<_SetAntialiasMode>(lpVtbl->SetAntialiasMode)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), antialiasMode);
        }

        public D2D1_ANTIALIAS_MODE GetAntialiasMode()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAntialiasMode>(lpVtbl->GetAntialiasMode)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        public void SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode)
        {
            Marshal.GetDelegateForFunctionPointer<_SetTextAntialiasMode>(lpVtbl->SetTextAntialiasMode)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), textAntialiasMode);
        }

        public D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTextAntialiasMode>(lpVtbl->GetTextAntialiasMode)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        public void SetTextRenderingParams([NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams = null)
        {
            Marshal.GetDelegateForFunctionPointer<_SetTextRenderingParams>(lpVtbl->SetTextRenderingParams)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        public void GetTextRenderingParams([NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** textRenderingParams)
        {
            Marshal.GetDelegateForFunctionPointer<_GetTextRenderingParams>(lpVtbl->GetTextRenderingParams)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        public void SetTags([NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2)
        {
            Marshal.GetDelegateForFunctionPointer<_SetTags>(lpVtbl->SetTags)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        public void GetTags([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            Marshal.GetDelegateForFunctionPointer<_GetTags>(lpVtbl->GetTags)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        public void PushLayer([NativeTypeName("const D2D1_LAYER_PARAMETERS *")] D2D1_LAYER_PARAMETERS* layerParameters, [NativeTypeName("ID2D1Layer *")] ID2D1Layer* layer)
        {
            Marshal.GetDelegateForFunctionPointer<_PushLayer>(lpVtbl->PushLayer)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), layerParameters, layer);
        }

        public void PopLayer()
        {
            Marshal.GetDelegateForFunctionPointer<_PopLayer>(lpVtbl->PopLayer)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Flush([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_Flush>(lpVtbl->Flush)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        public void SaveDrawingState([NativeTypeName("ID2D1DrawingStateBlock *")] ID2D1DrawingStateBlock* drawingStateBlock)
        {
            Marshal.GetDelegateForFunctionPointer<_SaveDrawingState>(lpVtbl->SaveDrawingState)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), drawingStateBlock);
        }

        public void RestoreDrawingState([NativeTypeName("ID2D1DrawingStateBlock *")] ID2D1DrawingStateBlock* drawingStateBlock)
        {
            Marshal.GetDelegateForFunctionPointer<_RestoreDrawingState>(lpVtbl->RestoreDrawingState)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), drawingStateBlock);
        }

        public void PushAxisAlignedClip([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
        {
            Marshal.GetDelegateForFunctionPointer<_PushAxisAlignedClip>(lpVtbl->PushAxisAlignedClip)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), clipRect, antialiasMode);
        }

        public void PopAxisAlignedClip()
        {
            Marshal.GetDelegateForFunctionPointer<_PopAxisAlignedClip>(lpVtbl->PopAxisAlignedClip)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        public void Clear([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* clearColor = null)
        {
            Marshal.GetDelegateForFunctionPointer<_Clear>(lpVtbl->Clear)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), clearColor);
        }

        public void BeginDraw()
        {
            Marshal.GetDelegateForFunctionPointer<_BeginDraw>(lpVtbl->BeginDraw)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EndDraw([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_EndDraw>(lpVtbl->EndDraw)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        public D2D1_PIXEL_FORMAT GetPixelFormat()
        {
            D2D1_PIXEL_FORMAT result;
            return *Marshal.GetDelegateForFunctionPointer<_GetPixelFormat>(lpVtbl->GetPixelFormat)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), &result);
        }

        public void SetDpi([NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY)
        {
            Marshal.GetDelegateForFunctionPointer<_SetDpi>(lpVtbl->SetDpi)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        public void GetDpi([NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDpi>(lpVtbl->GetDpi)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetSize()
        {
            D2D_SIZE_F result;
            return *Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("D2D1_SIZE_U")]
        public D2D_SIZE_U GetPixelSize()
        {
            D2D_SIZE_U result;
            return *Marshal.GetDelegateForFunctionPointer<_GetPixelSize>(lpVtbl->GetPixelSize)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetMaximumBitmapSize()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMaximumBitmapSize>(lpVtbl->GetMaximumBitmapSize)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsSupported([NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsSupported>(lpVtbl->IsSupported)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), renderTargetProperties);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [NativeTypeName("const void *")] void* sourceData, [NativeTypeName("UINT32")] uint pitch, [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")] D2D1_BITMAP_PROPERTIES1* bitmapProperties, [NativeTypeName("ID2D1Bitmap1 **")] ID2D1Bitmap1** bitmap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBitmap1>(lpVtbl->CreateBitmap1)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), size, sourceData, pitch, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromWicBitmap([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")] D2D1_BITMAP_PROPERTIES1* bitmapProperties, [NativeTypeName("ID2D1Bitmap1 **")] ID2D1Bitmap1** bitmap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromWicBitmap1>(lpVtbl->CreateBitmapFromWicBitmap1)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), wicBitmapSource, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext(D2D1_COLOR_SPACE space, [NativeTypeName("const BYTE *")] byte* profile, [NativeTypeName("UINT32")] uint profileSize, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateColorContext>(lpVtbl->CreateColorContext)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), space, profile, profileSize, colorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromFilename([NativeTypeName("PCWSTR")] ushort* filename, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateColorContextFromFilename>(lpVtbl->CreateColorContextFromFilename)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), filename, colorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromWicColorContext([NativeTypeName("IWICColorContext *")] IWICColorContext* wicColorContext, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateColorContextFromWicColorContext>(lpVtbl->CreateColorContextFromWicColorContext)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), wicColorContext, colorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromDxgiSurface([NativeTypeName("IDXGISurface *")] IDXGISurface* surface, [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")] D2D1_BITMAP_PROPERTIES1* bitmapProperties, [NativeTypeName("ID2D1Bitmap1 **")] ID2D1Bitmap1** bitmap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromDxgiSurface>(lpVtbl->CreateBitmapFromDxgiSurface)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), surface, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEffect([NativeTypeName("const IID &")] Guid* effectId, [NativeTypeName("ID2D1Effect **")] ID2D1Effect** effect)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateEffect>(lpVtbl->CreateEffect)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), effectId, effect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGradientStopCollection([NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* straightAlphaGradientStops, [NativeTypeName("UINT32")] uint straightAlphaGradientStopsCount, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, [NativeTypeName("ID2D1GradientStopCollection1 **")] ID2D1GradientStopCollection1** gradientStopCollection1)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateGradientStopCollection1>(lpVtbl->CreateGradientStopCollection1)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), straightAlphaGradientStops, straightAlphaGradientStopsCount, preInterpolationSpace, postInterpolationSpace, bufferPrecision, extendMode, colorInterpolationMode, gradientStopCollection1);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageBrush([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("const D2D1_IMAGE_BRUSH_PROPERTIES *")] D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1ImageBrush **")] ID2D1ImageBrush** imageBrush)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateImageBrush>(lpVtbl->CreateImageBrush)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), image, imageBrushProperties, brushProperties, imageBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES1 *")] D2D1_BITMAP_BRUSH_PROPERTIES1* bitmapBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1BitmapBrush1 **")] ID2D1BitmapBrush1** bitmapBrush)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBitmapBrush1>(lpVtbl->CreateBitmapBrush1)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandList([NativeTypeName("ID2D1CommandList **")] ID2D1CommandList** commandList)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCommandList>(lpVtbl->CreateCommandList)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), commandList);
        }

        [return: NativeTypeName("BOOL")]
        public int IsDxgiFormatSupported(DXGI_FORMAT format)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsDxgiFormatSupported>(lpVtbl->IsDxgiFormatSupported)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), format);
        }

        [return: NativeTypeName("BOOL")]
        public int IsBufferPrecisionSupported(D2D1_BUFFER_PRECISION bufferPrecision)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsBufferPrecisionSupported>(lpVtbl->IsBufferPrecisionSupported)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), bufferPrecision);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetImageLocalBounds([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* localBounds)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetImageLocalBounds>(lpVtbl->GetImageLocalBounds)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), image, localBounds);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetImageWorldBounds([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* worldBounds)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetImageWorldBounds>(lpVtbl->GetImageWorldBounds)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), image, worldBounds);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphRunWorldBounds([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGlyphRunWorldBounds>(lpVtbl->GetGlyphRunWorldBounds)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, measuringMode, bounds);
        }

        public void GetDevice([NativeTypeName("ID2D1Device **")] ID2D1Device** device)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), device);
        }

        public void SetTarget([NativeTypeName("ID2D1Image *")] ID2D1Image* image)
        {
            Marshal.GetDelegateForFunctionPointer<_SetTarget>(lpVtbl->SetTarget)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), image);
        }

        public void GetTarget([NativeTypeName("ID2D1Image **")] ID2D1Image** image)
        {
            Marshal.GetDelegateForFunctionPointer<_GetTarget>(lpVtbl->GetTarget)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), image);
        }

        public void SetRenderingControls([NativeTypeName("const D2D1_RENDERING_CONTROLS *")] D2D1_RENDERING_CONTROLS* renderingControls)
        {
            Marshal.GetDelegateForFunctionPointer<_SetRenderingControls>(lpVtbl->SetRenderingControls)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), renderingControls);
        }

        public void GetRenderingControls([NativeTypeName("D2D1_RENDERING_CONTROLS *")] D2D1_RENDERING_CONTROLS* renderingControls)
        {
            Marshal.GetDelegateForFunctionPointer<_GetRenderingControls>(lpVtbl->GetRenderingControls)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), renderingControls);
        }

        public void SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend)
        {
            Marshal.GetDelegateForFunctionPointer<_SetPrimitiveBlend>(lpVtbl->SetPrimitiveBlend)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), primitiveBlend);
        }

        public D2D1_PRIMITIVE_BLEND GetPrimitiveBlend()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrimitiveBlend>(lpVtbl->GetPrimitiveBlend)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        public void SetUnitMode(D2D1_UNIT_MODE unitMode)
        {
            Marshal.GetDelegateForFunctionPointer<_SetUnitMode>(lpVtbl->SetUnitMode)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), unitMode);
        }

        public D2D1_UNIT_MODE GetUnitMode()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetUnitMode>(lpVtbl->GetUnitMode)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        public void DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawGlyphRun1>(lpVtbl->DrawGlyphRun1)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
        }

        public void DrawImage([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle = null, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawImage>(lpVtbl->DrawImage)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), image, targetOffset, imageRectangle, interpolationMode, compositeMode);
        }

        public void DrawGdiMetafile([NativeTypeName("ID2D1GdiMetafile *")] ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawGdiMetafile>(lpVtbl->DrawGdiMetafile)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), gdiMetafile, targetOffset);
        }

        public void DrawBitmap([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("FLOAT")] float opacity, D2D1_INTERPOLATION_MODE interpolationMode, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null, [NativeTypeName("const D2D1_MATRIX_4X4_F *")] D2D_MATRIX_4X4_F* perspectiveTransform = null)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawBitmap1>(lpVtbl->DrawBitmap1)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
        }

        public void PushLayer([NativeTypeName("const D2D1_LAYER_PARAMETERS1 *")] D2D1_LAYER_PARAMETERS1* layerParameters, [NativeTypeName("ID2D1Layer *")] ID2D1Layer* layer)
        {
            Marshal.GetDelegateForFunctionPointer<_PushLayer1>(lpVtbl->PushLayer1)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), layerParameters, layer);
        }

        [return: NativeTypeName("HRESULT")]
        public int InvalidateEffectInputRectangle([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("UINT32")] uint input, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* inputRectangle)
        {
            return Marshal.GetDelegateForFunctionPointer<_InvalidateEffectInputRectangle>(lpVtbl->InvalidateEffectInputRectangle)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), effect, input, inputRectangle);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEffectInvalidRectangleCount([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("UINT32 *")] uint* rectangleCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEffectInvalidRectangleCount>(lpVtbl->GetEffectInvalidRectangleCount)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), effect, rectangleCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEffectInvalidRectangles([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* rectangles, [NativeTypeName("UINT32")] uint rectanglesCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEffectInvalidRectangles>(lpVtbl->GetEffectInvalidRectangles)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), effect, rectangles, rectanglesCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEffectRequiredInputRectangles([NativeTypeName("ID2D1Effect *")] ID2D1Effect* renderEffect, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* renderImageRectangle, [NativeTypeName("const D2D1_EFFECT_INPUT_DESCRIPTION *")] D2D1_EFFECT_INPUT_DESCRIPTION* inputDescriptions, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* requiredInputRects, [NativeTypeName("UINT32")] uint inputCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEffectRequiredInputRectangles>(lpVtbl->GetEffectRequiredInputRectangles)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), renderEffect, renderImageRectangle, inputDescriptions, requiredInputRects, inputCount);
        }

        public void FillOpacityMask([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* opacityMask, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            Marshal.GetDelegateForFunctionPointer<_FillOpacityMask1>(lpVtbl->FillOpacityMask1)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), opacityMask, brush, destinationRectangle, sourceRectangle);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFilledGeometryRealization([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("ID2D1GeometryRealization **")] ID2D1GeometryRealization** geometryRealization)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFilledGeometryRealization>(lpVtbl->CreateFilledGeometryRealization)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), geometry, flatteningTolerance, geometryRealization);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStrokedGeometryRealization([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle, [NativeTypeName("ID2D1GeometryRealization **")] ID2D1GeometryRealization** geometryRealization)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateStrokedGeometryRealization>(lpVtbl->CreateStrokedGeometryRealization)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), geometry, flatteningTolerance, strokeWidth, strokeStyle, geometryRealization);
        }

        public void DrawGeometryRealization([NativeTypeName("ID2D1GeometryRealization *")] ID2D1GeometryRealization* geometryRealization, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawGeometryRealization>(lpVtbl->DrawGeometryRealization)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), geometryRealization, brush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInk([NativeTypeName("const D2D1_INK_POINT *")] D2D1_INK_POINT* startPoint, [NativeTypeName("ID2D1Ink **")] ID2D1Ink** ink)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateInk>(lpVtbl->CreateInk)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), startPoint, ink);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInkStyle([NativeTypeName("const D2D1_INK_STYLE_PROPERTIES *")] D2D1_INK_STYLE_PROPERTIES* inkStyleProperties, [NativeTypeName("ID2D1InkStyle **")] ID2D1InkStyle** inkStyle)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateInkStyle>(lpVtbl->CreateInkStyle)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), inkStyleProperties, inkStyle);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGradientMesh([NativeTypeName("const D2D1_GRADIENT_MESH_PATCH *")] D2D1_GRADIENT_MESH_PATCH* patches, [NativeTypeName("UINT32")] uint patchesCount, [NativeTypeName("ID2D1GradientMesh **")] ID2D1GradientMesh** gradientMesh)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateGradientMesh>(lpVtbl->CreateGradientMesh)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), patches, patchesCount, gradientMesh);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageSourceFromWic([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, D2D1_IMAGE_SOURCE_LOADING_OPTIONS loadingOptions, D2D1_ALPHA_MODE alphaMode, [NativeTypeName("ID2D1ImageSourceFromWic **")] ID2D1ImageSourceFromWic** imageSource)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateImageSourceFromWic>(lpVtbl->CreateImageSourceFromWic)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), wicBitmapSource, loadingOptions, alphaMode, imageSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLookupTable3D(D2D1_BUFFER_PRECISION precision, [NativeTypeName("const UINT32 *")] uint* extents, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("const UINT32 *")] uint* strides, [NativeTypeName("ID2D1LookupTable3D **")] ID2D1LookupTable3D** lookupTable)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateLookupTable3D>(lpVtbl->CreateLookupTable3D)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), precision, extents, data, dataCount, strides, lookupTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageSourceFromDxgi([NativeTypeName("IDXGISurface **")] IDXGISurface** surfaces, [NativeTypeName("UINT32")] uint surfaceCount, DXGI_COLOR_SPACE_TYPE colorSpace, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS options, [NativeTypeName("ID2D1ImageSource **")] ID2D1ImageSource** imageSource)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateImageSourceFromDxgi>(lpVtbl->CreateImageSourceFromDxgi)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), surfaces, surfaceCount, colorSpace, options, imageSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGradientMeshWorldBounds([NativeTypeName("ID2D1GradientMesh *")] ID2D1GradientMesh* gradientMesh, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* pBounds)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGradientMeshWorldBounds>(lpVtbl->GetGradientMeshWorldBounds)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), gradientMesh, pBounds);
        }

        public void DrawInk([NativeTypeName("ID2D1Ink *")] ID2D1Ink* ink, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("ID2D1InkStyle *")] ID2D1InkStyle* inkStyle)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawInk>(lpVtbl->DrawInk)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), ink, brush, inkStyle);
        }

        public void DrawGradientMesh([NativeTypeName("ID2D1GradientMesh *")] ID2D1GradientMesh* gradientMesh)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawGradientMesh>(lpVtbl->DrawGradientMesh)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), gradientMesh);
        }

        public void DrawGdiMetafile([NativeTypeName("ID2D1GdiMetafile *")] ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawGdiMetafile1>(lpVtbl->DrawGdiMetafile1)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), gdiMetafile, destinationRectangle, sourceRectangle);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransformedImageSource([NativeTypeName("ID2D1ImageSource *")] ID2D1ImageSource* imageSource, [NativeTypeName("const D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES *")] D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties, [NativeTypeName("ID2D1TransformedImageSource **")] ID2D1TransformedImageSource** transformedImageSource)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTransformedImageSource>(lpVtbl->CreateTransformedImageSource)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), imageSource, properties, transformedImageSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSpriteBatch([NativeTypeName("ID2D1SpriteBatch **")] ID2D1SpriteBatch** spriteBatch)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSpriteBatch>(lpVtbl->CreateSpriteBatch)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), spriteBatch);
        }

        public void DrawSpriteBatch([NativeTypeName("ID2D1SpriteBatch *")] ID2D1SpriteBatch* spriteBatch, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, D2D1_SPRITE_OPTIONS spriteOptions = D2D1_SPRITE_OPTIONS_NONE)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawSpriteBatch>(lpVtbl->DrawSpriteBatch)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), spriteBatch, startIndex, spriteCount, bitmap, interpolationMode, spriteOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSvgGlyphStyle([NativeTypeName("ID2D1SvgGlyphStyle **")] ID2D1SvgGlyphStyle** svgGlyphStyle)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSvgGlyphStyle>(lpVtbl->CreateSvgGlyphStyle)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), svgGlyphStyle);
        }

        public void DrawText([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* layoutRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, [NativeTypeName("ID2D1SvgGlyphStyle *")] ID2D1SvgGlyphStyle* svgGlyphStyle, [NativeTypeName("UINT32")] uint colorPaletteIndex = 0, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawText1>(lpVtbl->DrawText1)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutRect, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, options, measuringMode);
        }

        public void DrawTextLayout([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F origin, [NativeTypeName("IDWriteTextLayout *")] IDWriteTextLayout* textLayout, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, [NativeTypeName("ID2D1SvgGlyphStyle *")] ID2D1SvgGlyphStyle* svgGlyphStyle, [NativeTypeName("UINT32")] uint colorPaletteIndex = 0, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawTextLayout1>(lpVtbl->DrawTextLayout1)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), origin, textLayout, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, options);
        }

        public void DrawColorBitmapGlyphRun(DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL, D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION bitmapSnapOption = D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DEFAULT)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawColorBitmapGlyphRun>(lpVtbl->DrawColorBitmapGlyphRun)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), glyphImageFormat, baselineOrigin, glyphRun, measuringMode, bitmapSnapOption);
        }

        public void DrawSvgGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush = null, [NativeTypeName("ID2D1SvgGlyphStyle *")] ID2D1SvgGlyphStyle* svgGlyphStyle = null, [NativeTypeName("UINT32")] uint colorPaletteIndex = 0, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawSvgGlyphRun>(lpVtbl->DrawSvgGlyphRun)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, measuringMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorBitmapGlyphImage(DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F glyphOrigin, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("UINT16")] ushort glyphIndex, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* glyphTransform, [NativeTypeName("ID2D1Image **")] ID2D1Image** glyphImage)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetColorBitmapGlyphImage>(lpVtbl->GetColorBitmapGlyphImage)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), glyphImageFormat, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, dpiX, dpiY, glyphTransform, glyphImage);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSvgGlyphImage([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F glyphOrigin, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("UINT16")] ushort glyphIndex, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, [NativeTypeName("ID2D1SvgGlyphStyle *")] ID2D1SvgGlyphStyle* svgGlyphStyle, [NativeTypeName("UINT32")] uint colorPaletteIndex, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* glyphTransform, [NativeTypeName("ID2D1CommandList **")] ID2D1CommandList** glyphImage)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSvgGlyphImage>(lpVtbl->GetSvgGlyphImage)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImage);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSvgDocument([NativeTypeName("IStream *")] IStream* inputXmlStream, [NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F viewportSize, [NativeTypeName("ID2D1SvgDocument **")] ID2D1SvgDocument** svgDocument)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSvgDocument>(lpVtbl->CreateSvgDocument)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), inputXmlStream, viewportSize, svgDocument);
        }

        public void DrawSvgDocument([NativeTypeName("ID2D1SvgDocument *")] ID2D1SvgDocument* svgDocument)
        {
            Marshal.GetDelegateForFunctionPointer<_DrawSvgDocument>(lpVtbl->DrawSvgDocument)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), svgDocument);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromDxgiColorSpace(DXGI_COLOR_SPACE_TYPE colorSpace, [NativeTypeName("ID2D1ColorContext1 **")] ID2D1ColorContext1** colorContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateColorContextFromDxgiColorSpace>(lpVtbl->CreateColorContextFromDxgiColorSpace)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), colorSpace, colorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromSimpleColorProfile([NativeTypeName("const D2D1_SIMPLE_COLOR_PROFILE *")] D2D1_SIMPLE_COLOR_PROFILE* simpleProfile, [NativeTypeName("ID2D1ColorContext1 **")] ID2D1ColorContext1** colorContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateColorContextFromSimpleColorProfile>(lpVtbl->CreateColorContextFromSimpleColorProfile)((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), simpleProfile, colorContext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFactory;

            [NativeTypeName("HRESULT (D2D1_SIZE_U, const void *, UINT32, const D2D1_BITMAP_PROPERTIES *, ID2D1Bitmap **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateBitmap;

            [NativeTypeName("HRESULT (IWICBitmapSource *, const D2D1_BITMAP_PROPERTIES *, ID2D1Bitmap **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateBitmapFromWicBitmap;

            [NativeTypeName("HRESULT (const IID &, void *, const D2D1_BITMAP_PROPERTIES *, ID2D1Bitmap **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSharedBitmap;

            [NativeTypeName("HRESULT (ID2D1Bitmap *, const D2D1_BITMAP_BRUSH_PROPERTIES *, const D2D1_BRUSH_PROPERTIES *, ID2D1BitmapBrush **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateBitmapBrush;

            [NativeTypeName("HRESULT (const D2D1_COLOR_F *, const D2D1_BRUSH_PROPERTIES *, ID2D1SolidColorBrush **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSolidColorBrush;

            [NativeTypeName("HRESULT (const D2D1_GRADIENT_STOP *, UINT32, D2D1_GAMMA, D2D1_EXTEND_MODE, ID2D1GradientStopCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateGradientStopCollection;

            [NativeTypeName("HRESULT (const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES *, const D2D1_BRUSH_PROPERTIES *, ID2D1GradientStopCollection *, ID2D1LinearGradientBrush **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateLinearGradientBrush;

            [NativeTypeName("HRESULT (const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES *, const D2D1_BRUSH_PROPERTIES *, ID2D1GradientStopCollection *, ID2D1RadialGradientBrush **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateRadialGradientBrush;

            [NativeTypeName("HRESULT (const D2D1_SIZE_F *, const D2D1_SIZE_U *, const D2D1_PIXEL_FORMAT *, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, ID2D1BitmapRenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateCompatibleRenderTarget;

            [NativeTypeName("HRESULT (const D2D1_SIZE_F *, ID2D1Layer **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateLayer;

            [NativeTypeName("HRESULT (ID2D1Mesh **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateMesh;

            [NativeTypeName("void (D2D1_POINT_2F, D2D1_POINT_2F, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawLine;

            [NativeTypeName("void (const D2D1_RECT_F *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawRectangle;

            [NativeTypeName("void (const D2D1_RECT_F *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FillRectangle;

            [NativeTypeName("void (const D2D1_ROUNDED_RECT *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawRoundedRectangle;

            [NativeTypeName("void (const D2D1_ROUNDED_RECT *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FillRoundedRectangle;

            [NativeTypeName("void (const D2D1_ELLIPSE *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawEllipse;

            [NativeTypeName("void (const D2D1_ELLIPSE *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FillEllipse;

            [NativeTypeName("void (ID2D1Geometry *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawGeometry;

            [NativeTypeName("void (ID2D1Geometry *, ID2D1Brush *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FillGeometry;

            [NativeTypeName("void (ID2D1Mesh *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FillMesh;

            [NativeTypeName("void (ID2D1Bitmap *, ID2D1Brush *, D2D1_OPACITY_MASK_CONTENT, const D2D1_RECT_F *, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FillOpacityMask;

            [NativeTypeName("void (ID2D1Bitmap *, const D2D1_RECT_F *, FLOAT, D2D1_BITMAP_INTERPOLATION_MODE, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawBitmap;

            [NativeTypeName("void (const WCHAR *, UINT32, IDWriteTextFormat *, const D2D1_RECT_F *, ID2D1Brush *, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawText;

            [NativeTypeName("void (D2D1_POINT_2F, IDWriteTextLayout *, ID2D1Brush *, D2D1_DRAW_TEXT_OPTIONS) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawTextLayout;

            [NativeTypeName("void (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, ID2D1Brush *, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawGlyphRun;

            [NativeTypeName("void (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTransform;

            [NativeTypeName("void (D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTransform;

            [NativeTypeName("void (D2D1_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAntialiasMode;

            [NativeTypeName("D2D1_ANTIALIAS_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetAntialiasMode;

            [NativeTypeName("void (D2D1_TEXT_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTextAntialiasMode;

            [NativeTypeName("D2D1_TEXT_ANTIALIAS_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTextAntialiasMode;

            [NativeTypeName("void (IDWriteRenderingParams *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTextRenderingParams;

            [NativeTypeName("void (IDWriteRenderingParams **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTextRenderingParams;

            [NativeTypeName("void (D2D1_TAG, D2D1_TAG) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTags;

            [NativeTypeName("void (D2D1_TAG *, D2D1_TAG *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTags;

            [NativeTypeName("void (const D2D1_LAYER_PARAMETERS *, ID2D1Layer *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr PushLayer;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr PopLayer;

            [NativeTypeName("HRESULT (D2D1_TAG *, D2D1_TAG *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Flush;

            [NativeTypeName("void (ID2D1DrawingStateBlock *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SaveDrawingState;

            [NativeTypeName("void (ID2D1DrawingStateBlock *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr RestoreDrawingState;

            [NativeTypeName("void (const D2D1_RECT_F *, D2D1_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr PushAxisAlignedClip;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr PopAxisAlignedClip;

            [NativeTypeName("void (const D2D1_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Clear;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BeginDraw;

            [NativeTypeName("HRESULT (D2D1_TAG *, D2D1_TAG *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr EndDraw;

            [NativeTypeName("D2D1_PIXEL_FORMAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPixelFormat;

            [NativeTypeName("void (FLOAT, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetDpi;

            [NativeTypeName("void (FLOAT *, FLOAT *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDpi;

            [NativeTypeName("D2D1_SIZE_F () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSize;

            [NativeTypeName("D2D1_SIZE_U () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPixelSize;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMaximumBitmapSize;

            [NativeTypeName("BOOL (const D2D1_RENDER_TARGET_PROPERTIES *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsSupported;

            [NativeTypeName("HRESULT (D2D1_SIZE_U, const void *, UINT32, const D2D1_BITMAP_PROPERTIES1 *, ID2D1Bitmap1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateBitmap1;

            [NativeTypeName("HRESULT (IWICBitmapSource *, const D2D1_BITMAP_PROPERTIES1 *, ID2D1Bitmap1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateBitmapFromWicBitmap1;

            [NativeTypeName("HRESULT (D2D1_COLOR_SPACE, const BYTE *, UINT32, ID2D1ColorContext **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateColorContext;

            [NativeTypeName("HRESULT (PCWSTR, ID2D1ColorContext **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateColorContextFromFilename;

            [NativeTypeName("HRESULT (IWICColorContext *, ID2D1ColorContext **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateColorContextFromWicColorContext;

            [NativeTypeName("HRESULT (IDXGISurface *, const D2D1_BITMAP_PROPERTIES1 *, ID2D1Bitmap1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateBitmapFromDxgiSurface;

            [NativeTypeName("HRESULT (const IID &, ID2D1Effect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateEffect;

            [NativeTypeName("HRESULT (const D2D1_GRADIENT_STOP *, UINT32, D2D1_COLOR_SPACE, D2D1_COLOR_SPACE, D2D1_BUFFER_PRECISION, D2D1_EXTEND_MODE, D2D1_COLOR_INTERPOLATION_MODE, ID2D1GradientStopCollection1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateGradientStopCollection1;

            [NativeTypeName("HRESULT (ID2D1Image *, const D2D1_IMAGE_BRUSH_PROPERTIES *, const D2D1_BRUSH_PROPERTIES *, ID2D1ImageBrush **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateImageBrush;

            [NativeTypeName("HRESULT (ID2D1Bitmap *, const D2D1_BITMAP_BRUSH_PROPERTIES1 *, const D2D1_BRUSH_PROPERTIES *, ID2D1BitmapBrush1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateBitmapBrush1;

            [NativeTypeName("HRESULT (ID2D1CommandList **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateCommandList;

            [NativeTypeName("BOOL (DXGI_FORMAT) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsDxgiFormatSupported;

            [NativeTypeName("BOOL (D2D1_BUFFER_PRECISION) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsBufferPrecisionSupported;

            [NativeTypeName("HRESULT (ID2D1Image *, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetImageLocalBounds;

            [NativeTypeName("HRESULT (ID2D1Image *, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetImageWorldBounds;

            [NativeTypeName("HRESULT (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, DWRITE_MEASURING_MODE, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGlyphRunWorldBounds;

            [NativeTypeName("void (ID2D1Device **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDevice;

            [NativeTypeName("void (ID2D1Image *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTarget;

            [NativeTypeName("void (ID2D1Image **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTarget;

            [NativeTypeName("void (const D2D1_RENDERING_CONTROLS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetRenderingControls;

            [NativeTypeName("void (D2D1_RENDERING_CONTROLS *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetRenderingControls;

            [NativeTypeName("void (D2D1_PRIMITIVE_BLEND) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetPrimitiveBlend;

            [NativeTypeName("D2D1_PRIMITIVE_BLEND () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPrimitiveBlend;

            [NativeTypeName("void (D2D1_UNIT_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetUnitMode;

            [NativeTypeName("D2D1_UNIT_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetUnitMode;

            [NativeTypeName("void (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, const DWRITE_GLYPH_RUN_DESCRIPTION *, ID2D1Brush *, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawGlyphRun1;

            [NativeTypeName("void (ID2D1Image *, const D2D1_POINT_2F *, const D2D1_RECT_F *, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawImage;

            [NativeTypeName("void (ID2D1GdiMetafile *, const D2D1_POINT_2F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawGdiMetafile;

            [NativeTypeName("void (ID2D1Bitmap *, const D2D1_RECT_F *, FLOAT, D2D1_INTERPOLATION_MODE, const D2D1_RECT_F *, const D2D1_MATRIX_4X4_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawBitmap1;

            [NativeTypeName("void (const D2D1_LAYER_PARAMETERS1 *, ID2D1Layer *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr PushLayer1;

            [NativeTypeName("HRESULT (ID2D1Effect *, UINT32, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr InvalidateEffectInputRectangle;

            [NativeTypeName("HRESULT (ID2D1Effect *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetEffectInvalidRectangleCount;

            [NativeTypeName("HRESULT (ID2D1Effect *, D2D1_RECT_F *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetEffectInvalidRectangles;

            [NativeTypeName("HRESULT (ID2D1Effect *, const D2D1_RECT_F *, const D2D1_EFFECT_INPUT_DESCRIPTION *, D2D1_RECT_F *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetEffectRequiredInputRectangles;

            [NativeTypeName("void (ID2D1Bitmap *, ID2D1Brush *, const D2D1_RECT_F *, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FillOpacityMask1;

            [NativeTypeName("HRESULT (ID2D1Geometry *, FLOAT, ID2D1GeometryRealization **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFilledGeometryRealization;

            [NativeTypeName("HRESULT (ID2D1Geometry *, FLOAT, FLOAT, ID2D1StrokeStyle *, ID2D1GeometryRealization **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateStrokedGeometryRealization;

            [NativeTypeName("void (ID2D1GeometryRealization *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawGeometryRealization;

            [NativeTypeName("HRESULT (const D2D1_INK_POINT *, ID2D1Ink **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateInk;

            [NativeTypeName("HRESULT (const D2D1_INK_STYLE_PROPERTIES *, ID2D1InkStyle **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateInkStyle;

            [NativeTypeName("HRESULT (const D2D1_GRADIENT_MESH_PATCH *, UINT32, ID2D1GradientMesh **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateGradientMesh;

            [NativeTypeName("HRESULT (IWICBitmapSource *, D2D1_IMAGE_SOURCE_LOADING_OPTIONS, D2D1_ALPHA_MODE, ID2D1ImageSourceFromWic **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateImageSourceFromWic;

            [NativeTypeName("HRESULT (D2D1_BUFFER_PRECISION, const UINT32 *, const BYTE *, UINT32, const UINT32 *, ID2D1LookupTable3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateLookupTable3D;

            [NativeTypeName("HRESULT (IDXGISurface **, UINT32, DXGI_COLOR_SPACE_TYPE, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS, ID2D1ImageSource **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateImageSourceFromDxgi;

            [NativeTypeName("HRESULT (ID2D1GradientMesh *, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGradientMeshWorldBounds;

            [NativeTypeName("void (ID2D1Ink *, ID2D1Brush *, ID2D1InkStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawInk;

            [NativeTypeName("void (ID2D1GradientMesh *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawGradientMesh;

            [NativeTypeName("void (ID2D1GdiMetafile *, const D2D1_RECT_F *, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawGdiMetafile1;

            [NativeTypeName("HRESULT (ID2D1ImageSource *, const D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES *, ID2D1TransformedImageSource **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTransformedImageSource;

            [NativeTypeName("HRESULT (ID2D1SpriteBatch **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSpriteBatch;

            [NativeTypeName("void (ID2D1SpriteBatch *, UINT32, UINT32, ID2D1Bitmap *, D2D1_BITMAP_INTERPOLATION_MODE, D2D1_SPRITE_OPTIONS) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawSpriteBatch;

            [NativeTypeName("HRESULT (ID2D1SvgGlyphStyle **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSvgGlyphStyle;

            [NativeTypeName("void (const WCHAR *, UINT32, IDWriteTextFormat *, const D2D1_RECT_F *, ID2D1Brush *, ID2D1SvgGlyphStyle *, UINT32, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawText1;

            [NativeTypeName("void (D2D1_POINT_2F, IDWriteTextLayout *, ID2D1Brush *, ID2D1SvgGlyphStyle *, UINT32, D2D1_DRAW_TEXT_OPTIONS) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawTextLayout1;

            [NativeTypeName("void (DWRITE_GLYPH_IMAGE_FORMATS, D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, DWRITE_MEASURING_MODE, D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawColorBitmapGlyphRun;

            [NativeTypeName("void (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, ID2D1Brush *, ID2D1SvgGlyphStyle *, UINT32, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawSvgGlyphRun;

            [NativeTypeName("HRESULT (DWRITE_GLYPH_IMAGE_FORMATS, D2D1_POINT_2F, IDWriteFontFace *, FLOAT, UINT16, BOOL, const D2D1_MATRIX_3X2_F *, FLOAT, FLOAT, D2D1_MATRIX_3X2_F *, ID2D1Image **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetColorBitmapGlyphImage;

            [NativeTypeName("HRESULT (D2D1_POINT_2F, IDWriteFontFace *, FLOAT, UINT16, BOOL, const D2D1_MATRIX_3X2_F *, ID2D1Brush *, ID2D1SvgGlyphStyle *, UINT32, D2D1_MATRIX_3X2_F *, ID2D1CommandList **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSvgGlyphImage;

            [NativeTypeName("HRESULT (IStream *, D2D1_SIZE_F, ID2D1SvgDocument **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSvgDocument;

            [NativeTypeName("void (ID2D1SvgDocument *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawSvgDocument;

            [NativeTypeName("HRESULT (DXGI_COLOR_SPACE_TYPE, ID2D1ColorContext1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateColorContextFromDxgiColorSpace;

            [NativeTypeName("HRESULT (const D2D1_SIMPLE_COLOR_PROFILE *, ID2D1ColorContext1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateColorContextFromSimpleColorProfile;
        }
    }
}
