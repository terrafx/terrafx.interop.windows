// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3BAB440E-417E-47DF-A2E2-BC0BE6A00916")]
    public unsafe partial struct ID2D1CommandSink2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1CommandSink2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1CommandSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1CommandSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BeginDraw(ID2D1CommandSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EndDraw(ID2D1CommandSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAntialiasMode(ID2D1CommandSink2* pThis, D2D1_ANTIALIAS_MODE antialiasMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTags(ID2D1CommandSink2* pThis, [NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTextAntialiasMode(ID2D1CommandSink2* pThis, D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTextRenderingParams(ID2D1CommandSink2* pThis, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTransform(ID2D1CommandSink2* pThis, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrimitiveBlend(ID2D1CommandSink2* pThis, D2D1_PRIMITIVE_BLEND primitiveBlend);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetUnitMode(ID2D1CommandSink2* pThis, D2D1_UNIT_MODE unitMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Clear(ID2D1CommandSink2* pThis, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawGlyphRun(ID2D1CommandSink2* pThis, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawLine(ID2D1CommandSink2* pThis, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawGeometry(ID2D1CommandSink2* pThis, [NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawRectangle(ID2D1CommandSink2* pThis, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawBitmap(ID2D1CommandSink2* pThis, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("FLOAT")] float opacity, D2D1_INTERPOLATION_MODE interpolationMode, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle, [NativeTypeName("const D2D1_MATRIX_4X4_F *")] D2D_MATRIX_4X4_F* perspectiveTransform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawImage(ID2D1CommandSink2* pThis, [NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawGdiMetafile(ID2D1CommandSink2* pThis, [NativeTypeName("ID2D1GdiMetafile *")] ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FillMesh(ID2D1CommandSink2* pThis, [NativeTypeName("ID2D1Mesh *")] ID2D1Mesh* mesh, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FillOpacityMask(ID2D1CommandSink2* pThis, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* opacityMask, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FillGeometry(ID2D1CommandSink2* pThis, [NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* opacityBrush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FillRectangle(ID2D1CommandSink2* pThis, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushAxisAlignedClip(ID2D1CommandSink2* pThis, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushLayer(ID2D1CommandSink2* pThis, [NativeTypeName("const D2D1_LAYER_PARAMETERS1 *")] D2D1_LAYER_PARAMETERS1* layerParameters1, [NativeTypeName("ID2D1Layer *")] ID2D1Layer* layer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PopAxisAlignedClip(ID2D1CommandSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PopLayer(ID2D1CommandSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrimitiveBlend1(ID2D1CommandSink2* pThis, D2D1_PRIMITIVE_BLEND primitiveBlend);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawInk(ID2D1CommandSink2* pThis, [NativeTypeName("ID2D1Ink *")] ID2D1Ink* ink, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("ID2D1InkStyle *")] ID2D1InkStyle* inkStyle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawGradientMesh(ID2D1CommandSink2* pThis, [NativeTypeName("ID2D1GradientMesh *")] ID2D1GradientMesh* gradientMesh);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawGdiMetafile1(ID2D1CommandSink2* pThis, [NativeTypeName("ID2D1GdiMetafile *")] ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginDraw()
        {
            return Marshal.GetDelegateForFunctionPointer<_BeginDraw>(lpVtbl->BeginDraw)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EndDraw()
        {
            return Marshal.GetDelegateForFunctionPointer<_EndDraw>(lpVtbl->EndDraw)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAntialiasMode>(lpVtbl->SetAntialiasMode)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), antialiasMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTags([NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTags>(lpVtbl->SetTags)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTextAntialiasMode>(lpVtbl->SetTextAntialiasMode)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), textAntialiasMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextRenderingParams([NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTextRenderingParams>(lpVtbl->SetTextRenderingParams)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTransform>(lpVtbl->SetTransform)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrimitiveBlend>(lpVtbl->SetPrimitiveBlend)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), primitiveBlend);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUnitMode(D2D1_UNIT_MODE unitMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetUnitMode>(lpVtbl->SetUnitMode)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), unitMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clear([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color)
        {
            return Marshal.GetDelegateForFunctionPointer<_Clear>(lpVtbl->Clear)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), color);
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_DrawGlyphRun>(lpVtbl->DrawGlyphRun)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle)
        {
            return Marshal.GetDelegateForFunctionPointer<_DrawLine>(lpVtbl->DrawLine)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), point0, point1, brush, strokeWidth, strokeStyle);
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle)
        {
            return Marshal.GetDelegateForFunctionPointer<_DrawGeometry>(lpVtbl->DrawGeometry)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), geometry, brush, strokeWidth, strokeStyle);
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle)
        {
            return Marshal.GetDelegateForFunctionPointer<_DrawRectangle>(lpVtbl->DrawRectangle)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), rect, brush, strokeWidth, strokeStyle);
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawBitmap([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("FLOAT")] float opacity, D2D1_INTERPOLATION_MODE interpolationMode, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle, [NativeTypeName("const D2D1_MATRIX_4X4_F *")] D2D_MATRIX_4X4_F* perspectiveTransform)
        {
            return Marshal.GetDelegateForFunctionPointer<_DrawBitmap>(lpVtbl->DrawBitmap)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawImage([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_DrawImage>(lpVtbl->DrawImage)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), image, targetOffset, imageRectangle, interpolationMode, compositeMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawGdiMetafile([NativeTypeName("ID2D1GdiMetafile *")] ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset)
        {
            return Marshal.GetDelegateForFunctionPointer<_DrawGdiMetafile>(lpVtbl->DrawGdiMetafile)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), gdiMetafile, targetOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int FillMesh([NativeTypeName("ID2D1Mesh *")] ID2D1Mesh* mesh, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            return Marshal.GetDelegateForFunctionPointer<_FillMesh>(lpVtbl->FillMesh)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), mesh, brush);
        }

        [return: NativeTypeName("HRESULT")]
        public int FillOpacityMask([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* opacityMask, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle)
        {
            return Marshal.GetDelegateForFunctionPointer<_FillOpacityMask>(lpVtbl->FillOpacityMask)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), opacityMask, brush, destinationRectangle, sourceRectangle);
        }

        [return: NativeTypeName("HRESULT")]
        public int FillGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* opacityBrush)
        {
            return Marshal.GetDelegateForFunctionPointer<_FillGeometry>(lpVtbl->FillGeometry)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), geometry, brush, opacityBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int FillRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            return Marshal.GetDelegateForFunctionPointer<_FillRectangle>(lpVtbl->FillRectangle)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), rect, brush);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushAxisAlignedClip([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_PushAxisAlignedClip>(lpVtbl->PushAxisAlignedClip)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), clipRect, antialiasMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushLayer([NativeTypeName("const D2D1_LAYER_PARAMETERS1 *")] D2D1_LAYER_PARAMETERS1* layerParameters1, [NativeTypeName("ID2D1Layer *")] ID2D1Layer* layer)
        {
            return Marshal.GetDelegateForFunctionPointer<_PushLayer>(lpVtbl->PushLayer)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), layerParameters1, layer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PopAxisAlignedClip()
        {
            return Marshal.GetDelegateForFunctionPointer<_PopAxisAlignedClip>(lpVtbl->PopAxisAlignedClip)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PopLayer()
        {
            return Marshal.GetDelegateForFunctionPointer<_PopLayer>(lpVtbl->PopLayer)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrimitiveBlend1(D2D1_PRIMITIVE_BLEND primitiveBlend)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrimitiveBlend1>(lpVtbl->SetPrimitiveBlend1)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), primitiveBlend);
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawInk([NativeTypeName("ID2D1Ink *")] ID2D1Ink* ink, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("ID2D1InkStyle *")] ID2D1InkStyle* inkStyle)
        {
            return Marshal.GetDelegateForFunctionPointer<_DrawInk>(lpVtbl->DrawInk)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), ink, brush, inkStyle);
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawGradientMesh([NativeTypeName("ID2D1GradientMesh *")] ID2D1GradientMesh* gradientMesh)
        {
            return Marshal.GetDelegateForFunctionPointer<_DrawGradientMesh>(lpVtbl->DrawGradientMesh)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), gradientMesh);
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawGdiMetafile([NativeTypeName("ID2D1GdiMetafile *")] ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle)
        {
            return Marshal.GetDelegateForFunctionPointer<_DrawGdiMetafile1>(lpVtbl->DrawGdiMetafile1)((ID2D1CommandSink2*)Unsafe.AsPointer(ref this), gdiMetafile, destinationRectangle, sourceRectangle);
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
            public IntPtr BeginDraw;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr EndDraw;

            [NativeTypeName("HRESULT (D2D1_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAntialiasMode;

            [NativeTypeName("HRESULT (D2D1_TAG, D2D1_TAG) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTags;

            [NativeTypeName("HRESULT (D2D1_TEXT_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTextAntialiasMode;

            [NativeTypeName("HRESULT (IDWriteRenderingParams *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTextRenderingParams;

            [NativeTypeName("HRESULT (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTransform;

            [NativeTypeName("HRESULT (D2D1_PRIMITIVE_BLEND) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetPrimitiveBlend;

            [NativeTypeName("HRESULT (D2D1_UNIT_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetUnitMode;

            [NativeTypeName("HRESULT (const D2D1_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Clear;

            [NativeTypeName("HRESULT (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, const DWRITE_GLYPH_RUN_DESCRIPTION *, ID2D1Brush *, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawGlyphRun;

            [NativeTypeName("HRESULT (D2D1_POINT_2F, D2D1_POINT_2F, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawLine;

            [NativeTypeName("HRESULT (ID2D1Geometry *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawGeometry;

            [NativeTypeName("HRESULT (const D2D1_RECT_F *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawRectangle;

            [NativeTypeName("HRESULT (ID2D1Bitmap *, const D2D1_RECT_F *, FLOAT, D2D1_INTERPOLATION_MODE, const D2D1_RECT_F *, const D2D1_MATRIX_4X4_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawBitmap;

            [NativeTypeName("HRESULT (ID2D1Image *, const D2D1_POINT_2F *, const D2D1_RECT_F *, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawImage;

            [NativeTypeName("HRESULT (ID2D1GdiMetafile *, const D2D1_POINT_2F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawGdiMetafile;

            [NativeTypeName("HRESULT (ID2D1Mesh *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FillMesh;

            [NativeTypeName("HRESULT (ID2D1Bitmap *, ID2D1Brush *, const D2D1_RECT_F *, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FillOpacityMask;

            [NativeTypeName("HRESULT (ID2D1Geometry *, ID2D1Brush *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FillGeometry;

            [NativeTypeName("HRESULT (const D2D1_RECT_F *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FillRectangle;

            [NativeTypeName("HRESULT (const D2D1_RECT_F *, D2D1_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr PushAxisAlignedClip;

            [NativeTypeName("HRESULT (const D2D1_LAYER_PARAMETERS1 *, ID2D1Layer *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr PushLayer;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr PopAxisAlignedClip;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr PopLayer;

            [NativeTypeName("HRESULT (D2D1_PRIMITIVE_BLEND) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetPrimitiveBlend1;

            [NativeTypeName("HRESULT (ID2D1Ink *, ID2D1Brush *, ID2D1InkStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawInk;

            [NativeTypeName("HRESULT (ID2D1GradientMesh *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawGradientMesh;

            [NativeTypeName("HRESULT (ID2D1GdiMetafile *, const D2D1_RECT_F *, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawGdiMetafile1;
        }
    }
}
