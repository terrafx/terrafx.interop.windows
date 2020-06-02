// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_BITMAP_INTERPOLATION_MODE;
using static TerraFX.Interop.D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS;
using static TerraFX.Interop.D2D1_DRAW_TEXT_OPTIONS;
using static TerraFX.Interop.D2D1_EXTEND_MODE;
using static TerraFX.Interop.D2D1_GAMMA;
using static TerraFX.Interop.DWRITE_MEASURING_MODE;

namespace TerraFX.Interop
{
    [Guid("1C51BC64-DE61-46FD-9899-63A5D8F03950")]
    public unsafe partial struct ID2D1DCRenderTarget
    {
        public Vtbl* lpVtbl;

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
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [NativeTypeName("const void *")] void* srcData, [NativeTypeName("UINT32")] uint pitch, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return lpVtbl->CreateBitmap((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), size, srcData, pitch, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromWicBitmap([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return lpVtbl->CreateBitmapFromWicBitmap((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), wicBitmapSource, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSharedBitmap([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* data, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return lpVtbl->CreateSharedBitmap((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), riid, data, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES *")] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1BitmapBrush **")] ID2D1BitmapBrush** bitmapBrush)
        {
            return lpVtbl->CreateBitmapBrush((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSolidColorBrush([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1SolidColorBrush **")] ID2D1SolidColorBrush** solidColorBrush)
        {
            return lpVtbl->CreateSolidColorBrush((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), color, brushProperties, solidColorBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGradientStopCollection([NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, [NativeTypeName("ID2D1GradientStopCollection **")] ID2D1GradientStopCollection** gradientStopCollection)
        {
            return lpVtbl->CreateGradientStopCollection((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLinearGradientBrush([NativeTypeName("const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES *")] D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1LinearGradientBrush **")] ID2D1LinearGradientBrush** linearGradientBrush)
        {
            return lpVtbl->CreateLinearGradientBrush((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRadialGradientBrush([NativeTypeName("const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES *")] D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1RadialGradientBrush **")] ID2D1RadialGradientBrush** radialGradientBrush)
        {
            return lpVtbl->CreateRadialGradientBrush((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* desiredSize, [NativeTypeName("const D2D1_SIZE_U *")] D2D_SIZE_U* desiredPixelSize, [NativeTypeName("const D2D1_PIXEL_FORMAT *")] D2D1_PIXEL_FORMAT* desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return lpVtbl->CreateCompatibleRenderTarget((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLayer([NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* size, [NativeTypeName("ID2D1Layer **")] ID2D1Layer** layer)
        {
            return lpVtbl->CreateLayer((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), size, layer);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMesh([NativeTypeName("ID2D1Mesh **")] ID2D1Mesh** mesh)
        {
            return lpVtbl->CreateMesh((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), mesh);
        }

        public void DrawLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            lpVtbl->DrawLine((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), point0, point1, brush, strokeWidth, strokeStyle);
        }

        public void DrawRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            lpVtbl->DrawRectangle((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), rect, brush, strokeWidth, strokeStyle);
        }

        public void FillRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            lpVtbl->FillRectangle((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), rect, brush);
        }

        public void DrawRoundedRectangle([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            lpVtbl->DrawRoundedRectangle((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), roundedRect, brush, strokeWidth, strokeStyle);
        }

        public void FillRoundedRectangle([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            lpVtbl->FillRoundedRectangle((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), roundedRect, brush);
        }

        public void DrawEllipse([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            lpVtbl->DrawEllipse((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), ellipse, brush, strokeWidth, strokeStyle);
        }

        public void FillEllipse([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            lpVtbl->FillEllipse((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), ellipse, brush);
        }

        public void DrawGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            lpVtbl->DrawGeometry((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), geometry, brush, strokeWidth, strokeStyle);
        }

        public void FillGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* opacityBrush = null)
        {
            lpVtbl->FillGeometry((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), geometry, brush, opacityBrush);
        }

        public void FillMesh([NativeTypeName("ID2D1Mesh *")] ID2D1Mesh* mesh, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            lpVtbl->FillMesh((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), mesh, brush);
        }

        public void FillOpacityMask([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* opacityMask, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, D2D1_OPACITY_MASK_CONTENT content, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            lpVtbl->FillOpacityMask((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), opacityMask, brush, content, destinationRectangle, sourceRectangle);
        }

        public void DrawBitmap([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("FLOAT")] float opacity = 1.0f, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            lpVtbl->DrawBitmap((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
        }

        public void DrawText([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* layoutRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            lpVtbl->DrawText((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
        }

        public void DrawTextLayout([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F origin, [NativeTypeName("IDWriteTextLayout *")] IDWriteTextLayout* textLayout, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE)
        {
            lpVtbl->DrawTextLayout((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), origin, textLayout, defaultFillBrush, options);
        }

        public void DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            lpVtbl->DrawGlyphRun((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, foregroundBrush, measuringMode);
        }

        public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            lpVtbl->SetTransform((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), transform);
        }

        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            lpVtbl->GetTransform((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), transform);
        }

        public void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode)
        {
            lpVtbl->SetAntialiasMode((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), antialiasMode);
        }

        public D2D1_ANTIALIAS_MODE GetAntialiasMode()
        {
            return lpVtbl->GetAntialiasMode((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this));
        }

        public void SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode)
        {
            lpVtbl->SetTextAntialiasMode((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), textAntialiasMode);
        }

        public D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode()
        {
            return lpVtbl->GetTextAntialiasMode((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this));
        }

        public void SetTextRenderingParams([NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams = null)
        {
            lpVtbl->SetTextRenderingParams((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        public void GetTextRenderingParams([NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** textRenderingParams)
        {
            lpVtbl->GetTextRenderingParams((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        public void SetTags([NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2)
        {
            lpVtbl->SetTags((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        public void GetTags([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            lpVtbl->GetTags((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        public void PushLayer([NativeTypeName("const D2D1_LAYER_PARAMETERS *")] D2D1_LAYER_PARAMETERS* layerParameters, [NativeTypeName("ID2D1Layer *")] ID2D1Layer* layer)
        {
            lpVtbl->PushLayer((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), layerParameters, layer);
        }

        public void PopLayer()
        {
            lpVtbl->PopLayer((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Flush([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            return lpVtbl->Flush((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        public void SaveDrawingState([NativeTypeName("ID2D1DrawingStateBlock *")] ID2D1DrawingStateBlock* drawingStateBlock)
        {
            lpVtbl->SaveDrawingState((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), drawingStateBlock);
        }

        public void RestoreDrawingState([NativeTypeName("ID2D1DrawingStateBlock *")] ID2D1DrawingStateBlock* drawingStateBlock)
        {
            lpVtbl->RestoreDrawingState((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), drawingStateBlock);
        }

        public void PushAxisAlignedClip([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
        {
            lpVtbl->PushAxisAlignedClip((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), clipRect, antialiasMode);
        }

        public void PopAxisAlignedClip()
        {
            lpVtbl->PopAxisAlignedClip((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this));
        }

        public void Clear([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* clearColor = null)
        {
            lpVtbl->Clear((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), clearColor);
        }

        public void BeginDraw()
        {
            lpVtbl->BeginDraw((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EndDraw([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            return lpVtbl->EndDraw((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        public D2D1_PIXEL_FORMAT GetPixelFormat()
        {
            D2D1_PIXEL_FORMAT result;
            return *lpVtbl->GetPixelFormat((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), &result);
        }

        public void SetDpi([NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY)
        {
            lpVtbl->SetDpi((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        public void GetDpi([NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY)
        {
            lpVtbl->GetDpi((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetSize()
        {
            D2D_SIZE_F result;
            return *lpVtbl->GetSize((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("D2D1_SIZE_U")]
        public D2D_SIZE_U GetPixelSize()
        {
            D2D_SIZE_U result;
            return *lpVtbl->GetPixelSize((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetMaximumBitmapSize()
        {
            return lpVtbl->GetMaximumBitmapSize((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsSupported([NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties)
        {
            return lpVtbl->IsSupported((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), renderTargetProperties);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindDC([NativeTypeName("const HDC")] IntPtr hDC, [NativeTypeName("const RECT *")] RECT* pSubRect)
        {
            return lpVtbl->BindDC((ID2D1DCRenderTarget*)Unsafe.AsPointer(ref this), hDC, pSubRect);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("HRESULT (D2D1_SIZE_U, const void *, UINT32, const D2D1_BITMAP_PROPERTIES *, ID2D1Bitmap **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D_SIZE_U, void*, uint, D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**, int> CreateBitmap;

            [NativeTypeName("HRESULT (IWICBitmapSource *, const D2D1_BITMAP_PROPERTIES *, ID2D1Bitmap **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, IWICBitmapSource*, D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**, int> CreateBitmapFromWicBitmap;

            [NativeTypeName("HRESULT (const IID &, void *, const D2D1_BITMAP_PROPERTIES *, ID2D1Bitmap **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, Guid*, void*, D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**, int> CreateSharedBitmap;

            [NativeTypeName("HRESULT (ID2D1Bitmap *, const D2D1_BITMAP_BRUSH_PROPERTIES *, const D2D1_BRUSH_PROPERTIES *, ID2D1BitmapBrush **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, ID2D1Bitmap*, D2D1_BITMAP_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1BitmapBrush**, int> CreateBitmapBrush;

            [NativeTypeName("HRESULT (const D2D1_COLOR_F *, const D2D1_BRUSH_PROPERTIES *, ID2D1SolidColorBrush **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, DXGI_RGBA*, D2D1_BRUSH_PROPERTIES*, ID2D1SolidColorBrush**, int> CreateSolidColorBrush;

            [NativeTypeName("HRESULT (const D2D1_GRADIENT_STOP *, UINT32, D2D1_GAMMA, D2D1_EXTEND_MODE, ID2D1GradientStopCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D1_GRADIENT_STOP*, uint, D2D1_GAMMA, D2D1_EXTEND_MODE, ID2D1GradientStopCollection**, int> CreateGradientStopCollection;

            [NativeTypeName("HRESULT (const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES *, const D2D1_BRUSH_PROPERTIES *, ID2D1GradientStopCollection *, ID2D1LinearGradientBrush **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int> CreateLinearGradientBrush;

            [NativeTypeName("HRESULT (const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES *, const D2D1_BRUSH_PROPERTIES *, ID2D1GradientStopCollection *, ID2D1RadialGradientBrush **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int> CreateRadialGradientBrush;

            [NativeTypeName("HRESULT (const D2D1_SIZE_F *, const D2D1_SIZE_U *, const D2D1_PIXEL_FORMAT *, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, ID2D1BitmapRenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D_SIZE_F*, D2D_SIZE_U*, D2D1_PIXEL_FORMAT*, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, ID2D1BitmapRenderTarget**, int> CreateCompatibleRenderTarget;

            [NativeTypeName("HRESULT (const D2D1_SIZE_F *, ID2D1Layer **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D_SIZE_F*, ID2D1Layer**, int> CreateLayer;

            [NativeTypeName("HRESULT (ID2D1Mesh **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, ID2D1Mesh**, int> CreateMesh;

            [NativeTypeName("void (D2D1_POINT_2F, D2D1_POINT_2F, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D_POINT_2F, D2D_POINT_2F, ID2D1Brush*, float, ID2D1StrokeStyle*, void> DrawLine;

            [NativeTypeName("void (const D2D1_RECT_F *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D_RECT_F*, ID2D1Brush*, float, ID2D1StrokeStyle*, void> DrawRectangle;

            [NativeTypeName("void (const D2D1_RECT_F *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D_RECT_F*, ID2D1Brush*, void> FillRectangle;

            [NativeTypeName("void (const D2D1_ROUNDED_RECT *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D1_ROUNDED_RECT*, ID2D1Brush*, float, ID2D1StrokeStyle*, void> DrawRoundedRectangle;

            [NativeTypeName("void (const D2D1_ROUNDED_RECT *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D1_ROUNDED_RECT*, ID2D1Brush*, void> FillRoundedRectangle;

            [NativeTypeName("void (const D2D1_ELLIPSE *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D1_ELLIPSE*, ID2D1Brush*, float, ID2D1StrokeStyle*, void> DrawEllipse;

            [NativeTypeName("void (const D2D1_ELLIPSE *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D1_ELLIPSE*, ID2D1Brush*, void> FillEllipse;

            [NativeTypeName("void (ID2D1Geometry *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void> DrawGeometry;

            [NativeTypeName("void (ID2D1Geometry *, ID2D1Brush *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void> FillGeometry;

            [NativeTypeName("void (ID2D1Mesh *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, ID2D1Mesh*, ID2D1Brush*, void> FillMesh;

            [NativeTypeName("void (ID2D1Bitmap *, ID2D1Brush *, D2D1_OPACITY_MASK_CONTENT, const D2D1_RECT_F *, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, D2D1_OPACITY_MASK_CONTENT, D2D_RECT_F*, D2D_RECT_F*, void> FillOpacityMask;

            [NativeTypeName("void (ID2D1Bitmap *, const D2D1_RECT_F *, FLOAT, D2D1_BITMAP_INTERPOLATION_MODE, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, ID2D1Bitmap*, D2D_RECT_F*, float, D2D1_BITMAP_INTERPOLATION_MODE, D2D_RECT_F*, void> DrawBitmap;

            [NativeTypeName("void (const WCHAR *, UINT32, IDWriteTextFormat *, const D2D1_RECT_F *, ID2D1Brush *, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, ushort*, uint, IDWriteTextFormat*, D2D_RECT_F*, ID2D1Brush*, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE, void> DrawText;

            [NativeTypeName("void (D2D1_POINT_2F, IDWriteTextLayout *, ID2D1Brush *, D2D1_DRAW_TEXT_OPTIONS) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D_POINT_2F, IDWriteTextLayout*, ID2D1Brush*, D2D1_DRAW_TEXT_OPTIONS, void> DrawTextLayout;

            [NativeTypeName("void (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, ID2D1Brush *, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, ID2D1Brush*, DWRITE_MEASURING_MODE, void> DrawGlyphRun;

            [NativeTypeName("void (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D_MATRIX_3X2_F*, void> SetTransform;

            [NativeTypeName("void (D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D_MATRIX_3X2_F*, void> GetTransform;

            [NativeTypeName("void (D2D1_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D1_ANTIALIAS_MODE, void> SetAntialiasMode;

            [NativeTypeName("D2D1_ANTIALIAS_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D1_ANTIALIAS_MODE> GetAntialiasMode;

            [NativeTypeName("void (D2D1_TEXT_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D1_TEXT_ANTIALIAS_MODE, void> SetTextAntialiasMode;

            [NativeTypeName("D2D1_TEXT_ANTIALIAS_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D1_TEXT_ANTIALIAS_MODE> GetTextAntialiasMode;

            [NativeTypeName("void (IDWriteRenderingParams *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, IDWriteRenderingParams*, void> SetTextRenderingParams;

            [NativeTypeName("void (IDWriteRenderingParams **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, IDWriteRenderingParams**, void> GetTextRenderingParams;

            [NativeTypeName("void (D2D1_TAG, D2D1_TAG) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, ulong, ulong, void> SetTags;

            [NativeTypeName("void (D2D1_TAG *, D2D1_TAG *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, ulong*, ulong*, void> GetTags;

            [NativeTypeName("void (const D2D1_LAYER_PARAMETERS *, ID2D1Layer *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D1_LAYER_PARAMETERS*, ID2D1Layer*, void> PushLayer;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, void> PopLayer;

            [NativeTypeName("HRESULT (D2D1_TAG *, D2D1_TAG *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, ulong*, ulong*, int> Flush;

            [NativeTypeName("void (ID2D1DrawingStateBlock *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, ID2D1DrawingStateBlock*, void> SaveDrawingState;

            [NativeTypeName("void (ID2D1DrawingStateBlock *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, ID2D1DrawingStateBlock*, void> RestoreDrawingState;

            [NativeTypeName("void (const D2D1_RECT_F *, D2D1_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D_RECT_F*, D2D1_ANTIALIAS_MODE, void> PushAxisAlignedClip;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, void> PopAxisAlignedClip;

            [NativeTypeName("void (const D2D1_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, DXGI_RGBA*, void> Clear;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, void> BeginDraw;

            [NativeTypeName("HRESULT (D2D1_TAG *, D2D1_TAG *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, ulong*, ulong*, int> EndDraw;

            [NativeTypeName("D2D1_PIXEL_FORMAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D1_PIXEL_FORMAT*, D2D1_PIXEL_FORMAT*> GetPixelFormat;

            [NativeTypeName("void (FLOAT, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, float, float, void> SetDpi;

            [NativeTypeName("void (FLOAT *, FLOAT *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, float*, float*, void> GetDpi;

            [NativeTypeName("D2D1_SIZE_F () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D_SIZE_F*, D2D_SIZE_F*> GetSize;

            [NativeTypeName("D2D1_SIZE_U () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D_SIZE_U*, D2D_SIZE_U*> GetPixelSize;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, uint> GetMaximumBitmapSize;

            [NativeTypeName("BOOL (const D2D1_RENDER_TARGET_PROPERTIES *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, D2D1_RENDER_TARGET_PROPERTIES*, int> IsSupported;

            [NativeTypeName("HRESULT (const HDC, const RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DCRenderTarget*, IntPtr, RECT*, int> BindDC;
        }
    }
}
