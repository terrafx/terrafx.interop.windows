// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("54D7898A-A061-40A7-BEC7-E465BCBA2C4F")]
    [NativeTypeName("struct ID2D1CommandSink : IUnknown")]
    public unsafe partial struct ID2D1CommandSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, uint>)(lpVtbl[1]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, uint>)(lpVtbl[2]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginDraw()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, int>)(lpVtbl[3]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndDraw()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, int>)(lpVtbl[4]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, D2D1_ANTIALIAS_MODE, int>)(lpVtbl[5]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), antialiasMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTags([NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, ulong, ulong, int>)(lpVtbl[6]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, D2D1_TEXT_ANTIALIAS_MODE, int>)(lpVtbl[7]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), textAntialiasMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTextRenderingParams([NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, IDWriteRenderingParams*, int>)(lpVtbl[8]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, D2D_MATRIX_3X2_F*, int>)(lpVtbl[9]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, D2D1_PRIMITIVE_BLEND, int>)(lpVtbl[10]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), primitiveBlend);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUnitMode(D2D1_UNIT_MODE unitMode)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, D2D1_UNIT_MODE, int>)(lpVtbl[11]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), unitMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clear([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, DXGI_RGBA*, int>)(lpVtbl[12]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, ID2D1Brush*, DWRITE_MEASURING_MODE, int>)(lpVtbl[13]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, D2D_POINT_2F, D2D_POINT_2F, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)(lpVtbl[14]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), point0, point1, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)(lpVtbl[15]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), geometry, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, D2D_RECT_F*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)(lpVtbl[16]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), rect, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawBitmap([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("FLOAT")] float opacity, D2D1_INTERPOLATION_MODE interpolationMode, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle, [NativeTypeName("const D2D1_MATRIX_4X4_F *")] D2D_MATRIX_4X4_F* perspectiveTransform)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, ID2D1Bitmap*, D2D_RECT_F*, float, D2D1_INTERPOLATION_MODE, D2D_RECT_F*, D2D_MATRIX_4X4_F*, int>)(lpVtbl[17]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawImage([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, ID2D1Image*, D2D_POINT_2F*, D2D_RECT_F*, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE, int>)(lpVtbl[18]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), image, targetOffset, imageRectangle, interpolationMode, compositeMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawGdiMetafile([NativeTypeName("ID2D1GdiMetafile *")] ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, ID2D1GdiMetafile*, D2D_POINT_2F*, int>)(lpVtbl[19]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), gdiMetafile, targetOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FillMesh([NativeTypeName("ID2D1Mesh *")] ID2D1Mesh* mesh, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, ID2D1Mesh*, ID2D1Brush*, int>)(lpVtbl[20]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), mesh, brush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FillOpacityMask([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* opacityMask, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, ID2D1Bitmap*, ID2D1Brush*, D2D_RECT_F*, D2D_RECT_F*, int>)(lpVtbl[21]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), opacityMask, brush, destinationRectangle, sourceRectangle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FillGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* opacityBrush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)(lpVtbl[22]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), geometry, brush, opacityBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FillRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, D2D_RECT_F*, ID2D1Brush*, int>)(lpVtbl[23]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), rect, brush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PushAxisAlignedClip([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, D2D_RECT_F*, D2D1_ANTIALIAS_MODE, int>)(lpVtbl[24]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), clipRect, antialiasMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PushLayer([NativeTypeName("const D2D1_LAYER_PARAMETERS1 *")] D2D1_LAYER_PARAMETERS1* layerParameters1, [NativeTypeName("ID2D1Layer *")] ID2D1Layer* layer)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, D2D1_LAYER_PARAMETERS1*, ID2D1Layer*, int>)(lpVtbl[25]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), layerParameters1, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PopAxisAlignedClip()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, int>)(lpVtbl[26]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PopLayer()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink*, int>)(lpVtbl[27]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this));
        }
    }
}
