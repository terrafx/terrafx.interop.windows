// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusflat.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreatePath([NativeTypeName("Gdiplus::GpFillMode")] FillMode brushMode, [NativeTypeName("Gdiplus::GpPath **")] IntPtr* path);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreatePath2([NativeTypeName("const Gdiplus::GpPointF *")] PointF* param0, [NativeTypeName("const BYTE *")] byte* param1, [NativeTypeName("INT")] int param2, [NativeTypeName("Gdiplus::GpFillMode")] FillMode param3, [NativeTypeName("Gdiplus::GpPath **")] IntPtr* path);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreatePath2I([NativeTypeName("const Gdiplus::GpPoint *")] Point* param0, [NativeTypeName("const BYTE *")] byte* param1, [NativeTypeName("INT")] int param2, [NativeTypeName("Gdiplus::GpFillMode")] FillMode param3, [NativeTypeName("Gdiplus::GpPath **")] IntPtr* path);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipClonePath([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::GpPath **")] IntPtr* clonePath);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDeletePath([NativeTypeName("Gdiplus::GpPath *")] IntPtr path);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipResetPath([NativeTypeName("Gdiplus::GpPath *")] IntPtr path);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPointCount([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("INT *")] int* count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathTypes([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("BYTE *")] byte* types, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathPoints([NativeTypeName("Gdiplus::GpPath *")] IntPtr param0, [NativeTypeName("Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathPointsI([NativeTypeName("Gdiplus::GpPath *")] IntPtr param0, [NativeTypeName("Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathFillMode([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::GpFillMode *")] FillMode* fillmode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPathFillMode([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::GpFillMode")] FillMode fillmode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathData([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::GpPathData *")] PathData* pathData);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipStartPathFigure([NativeTypeName("Gdiplus::GpPath *")] IntPtr path);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipClosePathFigure([NativeTypeName("Gdiplus::GpPath *")] IntPtr path);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipClosePathFigures([NativeTypeName("Gdiplus::GpPath *")] IntPtr path);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPathMarker([NativeTypeName("Gdiplus::GpPath *")] IntPtr path);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipClearPathMarkers([NativeTypeName("Gdiplus::GpPath *")] IntPtr path);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipReversePath([NativeTypeName("Gdiplus::GpPath *")] IntPtr path);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathLastPoint([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::GpPointF *")] PointF* lastPoint);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathLine([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::REAL")] float x1, [NativeTypeName("Gdiplus::REAL")] float y1, [NativeTypeName("Gdiplus::REAL")] float x2, [NativeTypeName("Gdiplus::REAL")] float y2);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathLine2([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathArc([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height, [NativeTypeName("Gdiplus::REAL")] float startAngle, [NativeTypeName("Gdiplus::REAL")] float sweepAngle);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathBezier([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::REAL")] float x1, [NativeTypeName("Gdiplus::REAL")] float y1, [NativeTypeName("Gdiplus::REAL")] float x2, [NativeTypeName("Gdiplus::REAL")] float y2, [NativeTypeName("Gdiplus::REAL")] float x3, [NativeTypeName("Gdiplus::REAL")] float y3, [NativeTypeName("Gdiplus::REAL")] float x4, [NativeTypeName("Gdiplus::REAL")] float y4);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathBeziers([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathCurve([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathCurve2([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::REAL")] float tension);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathCurve3([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count, [NativeTypeName("INT")] int offset, [NativeTypeName("INT")] int numberOfSegments, [NativeTypeName("Gdiplus::REAL")] float tension);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathClosedCurve([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathClosedCurve2([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::REAL")] float tension);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathRectangle([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathRectangles([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpRectF *")] RectF* rects, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathEllipse([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathPie([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height, [NativeTypeName("Gdiplus::REAL")] float startAngle, [NativeTypeName("Gdiplus::REAL")] float sweepAngle);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathPolygon([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathPath([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpPath *")] IntPtr addingPath, [NativeTypeName("BOOL")] int connect);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathString([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("INT")] int length, [NativeTypeName("const Gdiplus::GpFontFamily *")] IntPtr family, [NativeTypeName("INT")] int style, [NativeTypeName("Gdiplus::REAL")] float emSize, [NativeTypeName("const Gdiplus::RectF *")] RectF* layoutRect, [NativeTypeName("const Gdiplus::GpStringFormat *")] IntPtr format);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathStringI([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("INT")] int length, [NativeTypeName("const Gdiplus::GpFontFamily *")] IntPtr family, [NativeTypeName("INT")] int style, [NativeTypeName("Gdiplus::REAL")] float emSize, [NativeTypeName("const Gdiplus::Rect *")] Rect* layoutRect, [NativeTypeName("const Gdiplus::GpStringFormat *")] IntPtr format);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathLineI([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("INT")] int x1, [NativeTypeName("INT")] int y1, [NativeTypeName("INT")] int x2, [NativeTypeName("INT")] int y2);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathLine2I([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathArcI([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height, [NativeTypeName("Gdiplus::REAL")] float startAngle, [NativeTypeName("Gdiplus::REAL")] float sweepAngle);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathBezierI([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("INT")] int x1, [NativeTypeName("INT")] int y1, [NativeTypeName("INT")] int x2, [NativeTypeName("INT")] int y2, [NativeTypeName("INT")] int x3, [NativeTypeName("INT")] int y3, [NativeTypeName("INT")] int x4, [NativeTypeName("INT")] int y4);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathBeziersI([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathCurveI([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathCurve2I([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::REAL")] float tension);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathCurve3I([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count, [NativeTypeName("INT")] int offset, [NativeTypeName("INT")] int numberOfSegments, [NativeTypeName("Gdiplus::REAL")] float tension);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathClosedCurveI([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathClosedCurve2I([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::REAL")] float tension);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathRectangleI([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathRectanglesI([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpRect *")] Rect* rects, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathEllipseI([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathPieI([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height, [NativeTypeName("Gdiplus::REAL")] float startAngle, [NativeTypeName("Gdiplus::REAL")] float sweepAngle);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipAddPathPolygonI([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFlattenPath([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::REAL")] float flatness);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipWindingModeOutline([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::REAL")] float flatness);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipWidenPath([NativeTypeName("Gdiplus::GpPath *")] IntPtr nativePath, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::REAL")] float flatness);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipWarpPath([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::REAL")] float srcx, [NativeTypeName("Gdiplus::REAL")] float srcy, [NativeTypeName("Gdiplus::REAL")] float srcwidth, [NativeTypeName("Gdiplus::REAL")] float srcheight, [NativeTypeName("Gdiplus::WarpMode")] WarpMode warpMode, [NativeTypeName("Gdiplus::REAL")] float flatness);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipTransformPath([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathWorldBounds([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::GpRectF *")] RectF* bounds, [NativeTypeName("const Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("const Gdiplus::GpPen *")] IntPtr pen);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathWorldBoundsI([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::GpRect *")] Rect* bounds, [NativeTypeName("const Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("const Gdiplus::GpPen *")] IntPtr pen);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsVisiblePathPoint([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsVisiblePathPointI([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsOutlineVisiblePathPoint([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsOutlineVisiblePathPointI([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreatePathIter([NativeTypeName("Gdiplus::GpPathIterator **")] IntPtr* iterator, [NativeTypeName("Gdiplus::GpPath *")] IntPtr path);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDeletePathIter([NativeTypeName("Gdiplus::GpPathIterator *")] IntPtr iterator);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipPathIterNextSubpath([NativeTypeName("Gdiplus::GpPathIterator *")] IntPtr iterator, [NativeTypeName("INT *")] int* resultCount, [NativeTypeName("INT *")] int* startIndex, [NativeTypeName("INT *")] int* endIndex, [NativeTypeName("BOOL *")] int* isClosed);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipPathIterNextSubpathPath([NativeTypeName("Gdiplus::GpPathIterator *")] IntPtr iterator, [NativeTypeName("INT *")] int* resultCount, [NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("BOOL *")] int* isClosed);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipPathIterNextPathType([NativeTypeName("Gdiplus::GpPathIterator *")] IntPtr iterator, [NativeTypeName("INT *")] int* resultCount, [NativeTypeName("BYTE *")] byte* pathType, [NativeTypeName("INT *")] int* startIndex, [NativeTypeName("INT *")] int* endIndex);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipPathIterNextMarker([NativeTypeName("Gdiplus::GpPathIterator *")] IntPtr iterator, [NativeTypeName("INT *")] int* resultCount, [NativeTypeName("INT *")] int* startIndex, [NativeTypeName("INT *")] int* endIndex);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipPathIterNextMarkerPath([NativeTypeName("Gdiplus::GpPathIterator *")] IntPtr iterator, [NativeTypeName("INT *")] int* resultCount, [NativeTypeName("Gdiplus::GpPath *")] IntPtr path);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipPathIterGetCount([NativeTypeName("Gdiplus::GpPathIterator *")] IntPtr iterator, [NativeTypeName("INT *")] int* count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipPathIterGetSubpathCount([NativeTypeName("Gdiplus::GpPathIterator *")] IntPtr iterator, [NativeTypeName("INT *")] int* count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipPathIterIsValid([NativeTypeName("Gdiplus::GpPathIterator *")] IntPtr iterator, [NativeTypeName("BOOL *")] int* valid);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipPathIterHasCurve([NativeTypeName("Gdiplus::GpPathIterator *")] IntPtr iterator, [NativeTypeName("BOOL *")] int* hasCurve);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipPathIterRewind([NativeTypeName("Gdiplus::GpPathIterator *")] IntPtr iterator);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipPathIterEnumerate([NativeTypeName("Gdiplus::GpPathIterator *")] IntPtr iterator, [NativeTypeName("INT *")] int* resultCount, [NativeTypeName("Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("BYTE *")] byte* types, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipPathIterCopyData([NativeTypeName("Gdiplus::GpPathIterator *")] IntPtr iterator, [NativeTypeName("INT *")] int* resultCount, [NativeTypeName("Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("BYTE *")] byte* types, [NativeTypeName("INT")] int startIndex, [NativeTypeName("INT")] int endIndex);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateMatrix([NativeTypeName("Gdiplus::GpMatrix **")] IntPtr* matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateMatrix2([NativeTypeName("Gdiplus::REAL")] float m11, [NativeTypeName("Gdiplus::REAL")] float m12, [NativeTypeName("Gdiplus::REAL")] float m21, [NativeTypeName("Gdiplus::REAL")] float m22, [NativeTypeName("Gdiplus::REAL")] float dx, [NativeTypeName("Gdiplus::REAL")] float dy, [NativeTypeName("Gdiplus::GpMatrix **")] IntPtr* matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateMatrix3([NativeTypeName("const Gdiplus::GpRectF *")] RectF* rect, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* dstplg, [NativeTypeName("Gdiplus::GpMatrix **")] IntPtr* matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateMatrix3I([NativeTypeName("const Gdiplus::GpRect *")] Rect* rect, [NativeTypeName("const Gdiplus::GpPoint *")] Point* dstplg, [NativeTypeName("Gdiplus::GpMatrix **")] IntPtr* matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCloneMatrix([NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::GpMatrix **")] IntPtr* cloneMatrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDeleteMatrix([NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetMatrixElements([NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::REAL")] float m11, [NativeTypeName("Gdiplus::REAL")] float m12, [NativeTypeName("Gdiplus::REAL")] float m21, [NativeTypeName("Gdiplus::REAL")] float m22, [NativeTypeName("Gdiplus::REAL")] float dx, [NativeTypeName("Gdiplus::REAL")] float dy);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipMultiplyMatrix([NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix2, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipTranslateMatrix([NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::REAL")] float offsetX, [NativeTypeName("Gdiplus::REAL")] float offsetY, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipScaleMatrix([NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::REAL")] float scaleX, [NativeTypeName("Gdiplus::REAL")] float scaleY, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipRotateMatrix([NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::REAL")] float angle, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipShearMatrix([NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::REAL")] float shearX, [NativeTypeName("Gdiplus::REAL")] float shearY, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipInvertMatrix([NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipTransformMatrixPoints([NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::GpPointF *")] PointF* pts, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipTransformMatrixPointsI([NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::GpPoint *")] Point* pts, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipVectorTransformMatrixPoints([NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::GpPointF *")] PointF* pts, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipVectorTransformMatrixPointsI([NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::GpPoint *")] Point* pts, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetMatrixElements([NativeTypeName("const Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::REAL *")] float* matrixOut);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsMatrixInvertible([NativeTypeName("const Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsMatrixIdentity([NativeTypeName("const Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsMatrixEqual([NativeTypeName("const Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("const Gdiplus::GpMatrix *")] IntPtr matrix2, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateRegion([NativeTypeName("Gdiplus::GpRegion **")] IntPtr* region);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateRegionRect([NativeTypeName("const Gdiplus::GpRectF *")] RectF* rect, [NativeTypeName("Gdiplus::GpRegion **")] IntPtr* region);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateRegionRectI([NativeTypeName("const Gdiplus::GpRect *")] Rect* rect, [NativeTypeName("Gdiplus::GpRegion **")] IntPtr* region);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateRegionPath([NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::GpRegion **")] IntPtr* region);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateRegionRgnData([NativeTypeName("const BYTE *")] byte* regionData, [NativeTypeName("INT")] int size, [NativeTypeName("Gdiplus::GpRegion **")] IntPtr* region);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateRegionHrgn([NativeTypeName("HRGN")] IntPtr hRgn, [NativeTypeName("Gdiplus::GpRegion **")] IntPtr* region);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCloneRegion([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("Gdiplus::GpRegion **")] IntPtr* cloneRegion);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDeleteRegion([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetInfinite([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetEmpty([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCombineRegionRect([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("const Gdiplus::GpRectF *")] RectF* rect, [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCombineRegionRectI([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("const Gdiplus::GpRect *")] Rect* rect, [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCombineRegionPath([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCombineRegionRegion([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("Gdiplus::GpRegion *")] IntPtr region2, [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipTranslateRegion([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("Gdiplus::REAL")] float dx, [NativeTypeName("Gdiplus::REAL")] float dy);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipTranslateRegionI([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("INT")] int dx, [NativeTypeName("INT")] int dy);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipTransformRegion([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetRegionBounds([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpRectF *")] RectF* rect);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetRegionBoundsI([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpRect *")] Rect* rect);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetRegionHRgn([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("HRGN *")] IntPtr* hRgn);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsEmptyRegion([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsInfiniteRegion([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsEqualRegion([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("Gdiplus::GpRegion *")] IntPtr region2, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetRegionDataSize([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("UINT *")] uint* bufferSize);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetRegionData([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("BYTE *")] byte* buffer, [NativeTypeName("UINT")] uint bufferSize, [NativeTypeName("UINT *")] uint* sizeFilled);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsVisibleRegionPoint([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsVisibleRegionPointI([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsVisibleRegionRect([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsVisibleRegionRectI([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetRegionScansCount([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("UINT *")] uint* count, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetRegionScans([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("Gdiplus::GpRectF *")] RectF* rects, [NativeTypeName("INT *")] int* count, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetRegionScansI([NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("Gdiplus::GpRect *")] Rect* rects, [NativeTypeName("INT *")] int* count, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCloneBrush([NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("Gdiplus::GpBrush **")] IntPtr* cloneBrush);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDeleteBrush([NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetBrushType([NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("Gdiplus::GpBrushType *")] BrushType* type);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateHatchBrush([NativeTypeName("Gdiplus::GpHatchStyle")] HatchStyle hatchstyle, [NativeTypeName("Gdiplus::ARGB")] uint forecol, [NativeTypeName("Gdiplus::ARGB")] uint backcol, [NativeTypeName("Gdiplus::GpHatch **")] IntPtr* brush);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetHatchStyle([NativeTypeName("Gdiplus::GpHatch *")] IntPtr brush, [NativeTypeName("Gdiplus::GpHatchStyle *")] HatchStyle* hatchstyle);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetHatchForegroundColor([NativeTypeName("Gdiplus::GpHatch *")] IntPtr brush, [NativeTypeName("Gdiplus::ARGB *")] uint* forecol);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetHatchBackgroundColor([NativeTypeName("Gdiplus::GpHatch *")] IntPtr brush, [NativeTypeName("Gdiplus::ARGB *")] uint* backcol);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateTexture([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::GpWrapMode")] WrapMode wrapmode, [NativeTypeName("Gdiplus::GpTexture **")] IntPtr* texture);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateTexture2([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::GpWrapMode")] WrapMode wrapmode, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height, [NativeTypeName("Gdiplus::GpTexture **")] IntPtr* texture);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateTextureIA([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height, [NativeTypeName("Gdiplus::GpTexture **")] IntPtr* texture);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateTexture2I([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::GpWrapMode")] WrapMode wrapmode, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height, [NativeTypeName("Gdiplus::GpTexture **")] IntPtr* texture);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateTextureIAI([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height, [NativeTypeName("Gdiplus::GpTexture **")] IntPtr* texture);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetTextureTransform([NativeTypeName("Gdiplus::GpTexture *")] IntPtr brush, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetTextureTransform([NativeTypeName("Gdiplus::GpTexture *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipResetTextureTransform([NativeTypeName("Gdiplus::GpTexture *")] IntPtr brush);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipMultiplyTextureTransform([NativeTypeName("Gdiplus::GpTexture *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipTranslateTextureTransform([NativeTypeName("Gdiplus::GpTexture *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float dx, [NativeTypeName("Gdiplus::REAL")] float dy, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipScaleTextureTransform([NativeTypeName("Gdiplus::GpTexture *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float sx, [NativeTypeName("Gdiplus::REAL")] float sy, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipRotateTextureTransform([NativeTypeName("Gdiplus::GpTexture *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float angle, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetTextureWrapMode([NativeTypeName("Gdiplus::GpTexture *")] IntPtr brush, [NativeTypeName("Gdiplus::GpWrapMode")] WrapMode wrapmode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetTextureWrapMode([NativeTypeName("Gdiplus::GpTexture *")] IntPtr brush, [NativeTypeName("Gdiplus::GpWrapMode *")] WrapMode* wrapmode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetTextureImage([NativeTypeName("Gdiplus::GpTexture *")] IntPtr brush, [NativeTypeName("Gdiplus::GpImage **")] IntPtr* image);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateSolidFill([NativeTypeName("Gdiplus::ARGB")] uint color, [NativeTypeName("Gdiplus::GpSolidFill **")] IntPtr* brush);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetSolidFillColor([NativeTypeName("Gdiplus::GpSolidFill *")] IntPtr brush, [NativeTypeName("Gdiplus::ARGB")] uint color);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetSolidFillColor([NativeTypeName("Gdiplus::GpSolidFill *")] IntPtr brush, [NativeTypeName("Gdiplus::ARGB *")] uint* color);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateLineBrush([NativeTypeName("const Gdiplus::GpPointF *")] PointF* point1, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* point2, [NativeTypeName("Gdiplus::ARGB")] uint color1, [NativeTypeName("Gdiplus::ARGB")] uint color2, [NativeTypeName("Gdiplus::GpWrapMode")] WrapMode wrapMode, [NativeTypeName("Gdiplus::GpLineGradient **")] IntPtr* lineGradient);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateLineBrushI([NativeTypeName("const Gdiplus::GpPoint *")] Point* point1, [NativeTypeName("const Gdiplus::GpPoint *")] Point* point2, [NativeTypeName("Gdiplus::ARGB")] uint color1, [NativeTypeName("Gdiplus::ARGB")] uint color2, [NativeTypeName("Gdiplus::GpWrapMode")] WrapMode wrapMode, [NativeTypeName("Gdiplus::GpLineGradient **")] IntPtr* lineGradient);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateLineBrushFromRect([NativeTypeName("const Gdiplus::GpRectF *")] RectF* rect, [NativeTypeName("Gdiplus::ARGB")] uint color1, [NativeTypeName("Gdiplus::ARGB")] uint color2, [NativeTypeName("Gdiplus::LinearGradientMode")] LinearGradientMode mode, [NativeTypeName("Gdiplus::GpWrapMode")] WrapMode wrapMode, [NativeTypeName("Gdiplus::GpLineGradient **")] IntPtr* lineGradient);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateLineBrushFromRectI([NativeTypeName("const Gdiplus::GpRect *")] Rect* rect, [NativeTypeName("Gdiplus::ARGB")] uint color1, [NativeTypeName("Gdiplus::ARGB")] uint color2, [NativeTypeName("Gdiplus::LinearGradientMode")] LinearGradientMode mode, [NativeTypeName("Gdiplus::GpWrapMode")] WrapMode wrapMode, [NativeTypeName("Gdiplus::GpLineGradient **")] IntPtr* lineGradient);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateLineBrushFromRectWithAngle([NativeTypeName("const Gdiplus::GpRectF *")] RectF* rect, [NativeTypeName("Gdiplus::ARGB")] uint color1, [NativeTypeName("Gdiplus::ARGB")] uint color2, [NativeTypeName("Gdiplus::REAL")] float angle, [NativeTypeName("BOOL")] int isAngleScalable, [NativeTypeName("Gdiplus::GpWrapMode")] WrapMode wrapMode, [NativeTypeName("Gdiplus::GpLineGradient **")] IntPtr* lineGradient);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateLineBrushFromRectWithAngleI([NativeTypeName("const Gdiplus::GpRect *")] Rect* rect, [NativeTypeName("Gdiplus::ARGB")] uint color1, [NativeTypeName("Gdiplus::ARGB")] uint color2, [NativeTypeName("Gdiplus::REAL")] float angle, [NativeTypeName("BOOL")] int isAngleScalable, [NativeTypeName("Gdiplus::GpWrapMode")] WrapMode wrapMode, [NativeTypeName("Gdiplus::GpLineGradient **")] IntPtr* lineGradient);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetLineColors([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::ARGB")] uint color1, [NativeTypeName("Gdiplus::ARGB")] uint color2);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetLineColors([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::ARGB *")] uint* colors);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetLineRect([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::GpRectF *")] RectF* rect);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetLineRectI([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::GpRect *")] Rect* rect);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetLineGammaCorrection([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("BOOL")] int useGammaCorrection);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetLineGammaCorrection([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("BOOL *")] int* useGammaCorrection);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetLineBlendCount([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("INT *")] int* count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetLineBlend([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL *")] float* blend, [NativeTypeName("Gdiplus::REAL *")] float* positions, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetLineBlend([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("const Gdiplus::REAL *")] float* blend, [NativeTypeName("const Gdiplus::REAL *")] float* positions, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetLinePresetBlendCount([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("INT *")] int* count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetLinePresetBlend([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::ARGB *")] uint* blend, [NativeTypeName("Gdiplus::REAL *")] float* positions, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetLinePresetBlend([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("const Gdiplus::ARGB *")] uint* blend, [NativeTypeName("const Gdiplus::REAL *")] float* positions, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetLineSigmaBlend([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float focus, [NativeTypeName("Gdiplus::REAL")] float scale);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetLineLinearBlend([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float focus, [NativeTypeName("Gdiplus::REAL")] float scale);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetLineWrapMode([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::GpWrapMode")] WrapMode wrapmode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetLineWrapMode([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::GpWrapMode *")] WrapMode* wrapmode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetLineTransform([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetLineTransform([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipResetLineTransform([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipMultiplyLineTransform([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipTranslateLineTransform([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float dx, [NativeTypeName("Gdiplus::REAL")] float dy, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipScaleLineTransform([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float sx, [NativeTypeName("Gdiplus::REAL")] float sy, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipRotateLineTransform([NativeTypeName("Gdiplus::GpLineGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float angle, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreatePathGradient([NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::GpWrapMode")] WrapMode wrapMode, [NativeTypeName("Gdiplus::GpPathGradient **")] IntPtr* polyGradient);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreatePathGradientI([NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::GpWrapMode")] WrapMode wrapMode, [NativeTypeName("Gdiplus::GpPathGradient **")] IntPtr* polyGradient);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreatePathGradientFromPath([NativeTypeName("const Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::GpPathGradient **")] IntPtr* polyGradient);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathGradientCenterColor([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::ARGB *")] uint* colors);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPathGradientCenterColor([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::ARGB")] uint colors);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathGradientSurroundColorsWithCount([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::ARGB *")] uint* color, [NativeTypeName("INT *")] int* count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPathGradientSurroundColorsWithCount([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("const Gdiplus::ARGB *")] uint* color, [NativeTypeName("INT *")] int* count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathGradientPath([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::GpPath *")] IntPtr path);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPathGradientPath([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpPath *")] IntPtr path);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathGradientCenterPoint([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::GpPointF *")] PointF* points);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathGradientCenterPointI([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::GpPoint *")] Point* points);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPathGradientCenterPoint([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPathGradientCenterPointI([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathGradientRect([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::GpRectF *")] RectF* rect);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathGradientRectI([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::GpRect *")] Rect* rect);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathGradientPointCount([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("INT *")] int* count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathGradientSurroundColorCount([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("INT *")] int* count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPathGradientGammaCorrection([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("BOOL")] int useGammaCorrection);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathGradientGammaCorrection([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("BOOL *")] int* useGammaCorrection);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathGradientBlendCount([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("INT *")] int* count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathGradientBlend([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL *")] float* blend, [NativeTypeName("Gdiplus::REAL *")] float* positions, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPathGradientBlend([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("const Gdiplus::REAL *")] float* blend, [NativeTypeName("const Gdiplus::REAL *")] float* positions, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathGradientPresetBlendCount([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("INT *")] int* count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathGradientPresetBlend([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::ARGB *")] uint* blend, [NativeTypeName("Gdiplus::REAL *")] float* positions, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPathGradientPresetBlend([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("const Gdiplus::ARGB *")] uint* blend, [NativeTypeName("const Gdiplus::REAL *")] float* positions, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPathGradientSigmaBlend([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float focus, [NativeTypeName("Gdiplus::REAL")] float scale);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPathGradientLinearBlend([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float focus, [NativeTypeName("Gdiplus::REAL")] float scale);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathGradientWrapMode([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::GpWrapMode *")] WrapMode* wrapmode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPathGradientWrapMode([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::GpWrapMode")] WrapMode wrapmode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathGradientTransform([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPathGradientTransform([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipResetPathGradientTransform([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipMultiplyPathGradientTransform([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipTranslatePathGradientTransform([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float dx, [NativeTypeName("Gdiplus::REAL")] float dy, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipScalePathGradientTransform([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float sx, [NativeTypeName("Gdiplus::REAL")] float sy, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipRotatePathGradientTransform([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float angle, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPathGradientFocusScales([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL *")] float* xScale, [NativeTypeName("Gdiplus::REAL *")] float* yScale);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPathGradientFocusScales([NativeTypeName("Gdiplus::GpPathGradient *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float xScale, [NativeTypeName("Gdiplus::REAL")] float yScale);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreatePen1([NativeTypeName("Gdiplus::ARGB")] uint color, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::GpUnit")] Unit unit, [NativeTypeName("Gdiplus::GpPen **")] IntPtr* pen);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreatePen2([NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::GpUnit")] Unit unit, [NativeTypeName("Gdiplus::GpPen **")] IntPtr* pen);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipClonePen([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpPen **")] IntPtr* clonepen);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDeletePen([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenWidth([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::REAL")] float width);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenWidth([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::REAL *")] float* width);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenUnit([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpUnit")] Unit unit);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenUnit([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpUnit *")] Unit* unit);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenLineCap197819([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpLineCap")] LineCap startCap, [NativeTypeName("Gdiplus::GpLineCap")] LineCap endCap, [NativeTypeName("Gdiplus::GpDashCap")] DashCap dashCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenStartCap([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpLineCap")] LineCap startCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenEndCap([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpLineCap")] LineCap endCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenDashCap197819([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpDashCap")] DashCap dashCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenStartCap([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpLineCap *")] LineCap* startCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenEndCap([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpLineCap *")] LineCap* endCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenDashCap197819([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpDashCap *")] DashCap* dashCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenLineJoin([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpLineJoin")] LineJoin lineJoin);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenLineJoin([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpLineJoin *")] LineJoin* lineJoin);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenCustomStartCap([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpCustomLineCap *")] IntPtr customCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenCustomStartCap([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpCustomLineCap **")] IntPtr* customCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenCustomEndCap([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpCustomLineCap *")] IntPtr customCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenCustomEndCap([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpCustomLineCap **")] IntPtr* customCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenMiterLimit([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::REAL")] float miterLimit);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenMiterLimit([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::REAL *")] float* miterLimit);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenMode([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpPenAlignment")] PenAlignment penMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenMode([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpPenAlignment *")] PenAlignment* penMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenTransform([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenTransform([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipResetPenTransform([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipMultiplyPenTransform([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipTranslatePenTransform([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::REAL")] float dx, [NativeTypeName("Gdiplus::REAL")] float dy, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipScalePenTransform([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::REAL")] float sx, [NativeTypeName("Gdiplus::REAL")] float sy, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipRotatePenTransform([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::REAL")] float angle, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenColor([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::ARGB")] uint argb);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenColor([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::ARGB *")] uint* argb);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenBrushFill([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenBrushFill([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpBrush **")] IntPtr* brush);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenFillType([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpPenType *")] PenType* type);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenDashStyle([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpDashStyle *")] DashStyle* dashstyle);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenDashStyle([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpDashStyle")] DashStyle dashstyle);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenDashOffset([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::REAL *")] float* offset);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenDashOffset([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::REAL")] float offset);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenDashCount([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("INT *")] int* count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenDashArray([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::REAL *")] float* dash, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenDashArray([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::REAL *")] float* dash, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenCompoundCount([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("INT *")] int* count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPenCompoundArray([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::REAL *")] float* dash, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPenCompoundArray([NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::REAL *")] float* dash, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateCustomLineCap([NativeTypeName("Gdiplus::GpPath *")] IntPtr fillPath, [NativeTypeName("Gdiplus::GpPath *")] IntPtr strokePath, [NativeTypeName("Gdiplus::GpLineCap")] LineCap baseCap, [NativeTypeName("Gdiplus::REAL")] float baseInset, [NativeTypeName("Gdiplus::GpCustomLineCap **")] IntPtr* customCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDeleteCustomLineCap([NativeTypeName("Gdiplus::GpCustomLineCap *")] IntPtr customCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCloneCustomLineCap([NativeTypeName("Gdiplus::GpCustomLineCap *")] IntPtr customCap, [NativeTypeName("Gdiplus::GpCustomLineCap **")] IntPtr* clonedCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetCustomLineCapType([NativeTypeName("Gdiplus::GpCustomLineCap *")] IntPtr customCap, [NativeTypeName("Gdiplus::CustomLineCapType *")] CustomLineCapType* capType);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetCustomLineCapStrokeCaps([NativeTypeName("Gdiplus::GpCustomLineCap *")] IntPtr customCap, [NativeTypeName("Gdiplus::GpLineCap")] LineCap startCap, [NativeTypeName("Gdiplus::GpLineCap")] LineCap endCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetCustomLineCapStrokeCaps([NativeTypeName("Gdiplus::GpCustomLineCap *")] IntPtr customCap, [NativeTypeName("Gdiplus::GpLineCap *")] LineCap* startCap, [NativeTypeName("Gdiplus::GpLineCap *")] LineCap* endCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetCustomLineCapStrokeJoin([NativeTypeName("Gdiplus::GpCustomLineCap *")] IntPtr customCap, [NativeTypeName("Gdiplus::GpLineJoin")] LineJoin lineJoin);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetCustomLineCapStrokeJoin([NativeTypeName("Gdiplus::GpCustomLineCap *")] IntPtr customCap, [NativeTypeName("Gdiplus::GpLineJoin *")] LineJoin* lineJoin);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetCustomLineCapBaseCap([NativeTypeName("Gdiplus::GpCustomLineCap *")] IntPtr customCap, [NativeTypeName("Gdiplus::GpLineCap")] LineCap baseCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetCustomLineCapBaseCap([NativeTypeName("Gdiplus::GpCustomLineCap *")] IntPtr customCap, [NativeTypeName("Gdiplus::GpLineCap *")] LineCap* baseCap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetCustomLineCapBaseInset([NativeTypeName("Gdiplus::GpCustomLineCap *")] IntPtr customCap, [NativeTypeName("Gdiplus::REAL")] float inset);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetCustomLineCapBaseInset([NativeTypeName("Gdiplus::GpCustomLineCap *")] IntPtr customCap, [NativeTypeName("Gdiplus::REAL *")] float* inset);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetCustomLineCapWidthScale([NativeTypeName("Gdiplus::GpCustomLineCap *")] IntPtr customCap, [NativeTypeName("Gdiplus::REAL")] float widthScale);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetCustomLineCapWidthScale([NativeTypeName("Gdiplus::GpCustomLineCap *")] IntPtr customCap, [NativeTypeName("Gdiplus::REAL *")] float* widthScale);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateAdjustableArrowCap([NativeTypeName("Gdiplus::REAL")] float height, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("BOOL")] int isFilled, [NativeTypeName("Gdiplus::GpAdjustableArrowCap **")] IntPtr* cap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetAdjustableArrowCapHeight([NativeTypeName("Gdiplus::GpAdjustableArrowCap *")] IntPtr cap, [NativeTypeName("Gdiplus::REAL")] float height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetAdjustableArrowCapHeight([NativeTypeName("Gdiplus::GpAdjustableArrowCap *")] IntPtr cap, [NativeTypeName("Gdiplus::REAL *")] float* height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetAdjustableArrowCapWidth([NativeTypeName("Gdiplus::GpAdjustableArrowCap *")] IntPtr cap, [NativeTypeName("Gdiplus::REAL")] float width);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetAdjustableArrowCapWidth([NativeTypeName("Gdiplus::GpAdjustableArrowCap *")] IntPtr cap, [NativeTypeName("Gdiplus::REAL *")] float* width);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetAdjustableArrowCapMiddleInset([NativeTypeName("Gdiplus::GpAdjustableArrowCap *")] IntPtr cap, [NativeTypeName("Gdiplus::REAL")] float middleInset);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetAdjustableArrowCapMiddleInset([NativeTypeName("Gdiplus::GpAdjustableArrowCap *")] IntPtr cap, [NativeTypeName("Gdiplus::REAL *")] float* middleInset);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetAdjustableArrowCapFillState([NativeTypeName("Gdiplus::GpAdjustableArrowCap *")] IntPtr cap, [NativeTypeName("BOOL")] int fillState);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetAdjustableArrowCapFillState([NativeTypeName("Gdiplus::GpAdjustableArrowCap *")] IntPtr cap, [NativeTypeName("BOOL *")] int* fillState);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipLoadImageFromStream(IStream* stream, [NativeTypeName("Gdiplus::GpImage **")] IntPtr* image);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipLoadImageFromFile([NativeTypeName("const WCHAR *")] ushort* filename, [NativeTypeName("Gdiplus::GpImage **")] IntPtr* image);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipLoadImageFromStreamICM(IStream* stream, [NativeTypeName("Gdiplus::GpImage **")] IntPtr* image);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipLoadImageFromFileICM([NativeTypeName("const WCHAR *")] ushort* filename, [NativeTypeName("Gdiplus::GpImage **")] IntPtr* image);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCloneImage([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::GpImage **")] IntPtr* cloneImage);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDisposeImage([NativeTypeName("Gdiplus::GpImage *")] IntPtr image);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSaveImageToFile([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("const WCHAR *")] ushort* filename, [NativeTypeName("const CLSID *")] Guid* clsidEncoder, [NativeTypeName("const Gdiplus::EncoderParameters *")] EncoderParameters* encoderParams);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSaveImageToStream([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, IStream* stream, [NativeTypeName("const CLSID *")] Guid* clsidEncoder, [NativeTypeName("const Gdiplus::EncoderParameters *")] EncoderParameters* encoderParams);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSaveAdd([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("const Gdiplus::EncoderParameters *")] EncoderParameters* encoderParams);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSaveAddImage([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::GpImage *")] IntPtr newImage, [NativeTypeName("const Gdiplus::EncoderParameters *")] EncoderParameters* encoderParams);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImageGraphicsContext([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::GpGraphics **")] IntPtr* graphics);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImageBounds([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::GpRectF *")] RectF* srcRect, [NativeTypeName("Gdiplus::GpUnit *")] Unit* srcUnit);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImageDimension([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::REAL *")] float* width, [NativeTypeName("Gdiplus::REAL *")] float* height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImageType([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::ImageType *")] ImageType* type);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImageWidth([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("UINT *")] uint* width);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImageHeight([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("UINT *")] uint* height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImageHorizontalResolution([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::REAL *")] float* resolution);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImageVerticalResolution([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::REAL *")] float* resolution);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImageFlags([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("UINT *")] uint* flags);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImageRawFormat([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("GUID *")] Guid* format);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImagePixelFormat([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::PixelFormat *")] int* format);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImageThumbnail([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("UINT")] uint thumbWidth, [NativeTypeName("UINT")] uint thumbHeight, [NativeTypeName("Gdiplus::GpImage **")] IntPtr* thumbImage, [NativeTypeName("Gdiplus::GetThumbnailImageAbort")] delegate* unmanaged<void*, int> callback, void* callbackData);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetEncoderParameterListSize([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("const CLSID *")] Guid* clsidEncoder, [NativeTypeName("UINT *")] uint* size);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetEncoderParameterList([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("const CLSID *")] Guid* clsidEncoder, [NativeTypeName("UINT")] uint size, [NativeTypeName("Gdiplus::EncoderParameters *")] EncoderParameters* buffer);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipImageGetFrameDimensionsCount([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("UINT *")] uint* count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipImageGetFrameDimensionsList([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("GUID *")] Guid* dimensionIDs, [NativeTypeName("UINT")] uint count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipImageGetFrameCount([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("const GUID *")] Guid* dimensionID, [NativeTypeName("UINT *")] uint* count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipImageSelectActiveFrame([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("const GUID *")] Guid* dimensionID, [NativeTypeName("UINT")] uint frameIndex);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipImageRotateFlip([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::RotateFlipType")] RotateFlipType rfType);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImagePalette([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::ColorPalette *")] ColorPalette* palette, [NativeTypeName("INT")] int size);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetImagePalette([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("const Gdiplus::ColorPalette *")] ColorPalette* palette);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImagePaletteSize([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("INT *")] int* size);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPropertyCount([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("UINT *")] uint* numOfProperty);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPropertyIdList([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("UINT")] uint numOfProperty, [NativeTypeName("PROPID *")] uint* list);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPropertyItemSize([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("PROPID")] uint propId, [NativeTypeName("UINT *")] uint* size);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPropertyItem([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("PROPID")] uint propId, [NativeTypeName("UINT")] uint propSize, [NativeTypeName("Gdiplus::PropertyItem *")] PropertyItem* buffer);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPropertySize([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("UINT *")] uint* totalBufferSize, [NativeTypeName("UINT *")] uint* numProperties);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetAllPropertyItems([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("UINT")] uint totalBufferSize, [NativeTypeName("UINT")] uint numProperties, [NativeTypeName("Gdiplus::PropertyItem *")] PropertyItem* allItems);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipRemovePropertyItem([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("PROPID")] uint propId);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPropertyItem([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("const Gdiplus::PropertyItem *")] PropertyItem* item);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFindFirstImageItem([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::ImageItemData *")] ImageItemData* item);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFindNextImageItem([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::ImageItemData *")] ImageItemData* item);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImageItemData([NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::ImageItemData *")] ImageItemData* item);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipImageForceValidation([NativeTypeName("Gdiplus::GpImage *")] IntPtr image);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateBitmapFromStream(IStream* stream, [NativeTypeName("Gdiplus::GpBitmap **")] IntPtr* bitmap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateBitmapFromFile([NativeTypeName("const WCHAR *")] ushort* filename, [NativeTypeName("Gdiplus::GpBitmap **")] IntPtr* bitmap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateBitmapFromStreamICM(IStream* stream, [NativeTypeName("Gdiplus::GpBitmap **")] IntPtr* bitmap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateBitmapFromFileICM([NativeTypeName("const WCHAR *")] ushort* filename, [NativeTypeName("Gdiplus::GpBitmap **")] IntPtr* bitmap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateBitmapFromScan0([NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height, [NativeTypeName("INT")] int stride, [NativeTypeName("Gdiplus::PixelFormat")] int format, [NativeTypeName("BYTE *")] byte* scan0, [NativeTypeName("Gdiplus::GpBitmap **")] IntPtr* bitmap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateBitmapFromGraphics([NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr target, [NativeTypeName("Gdiplus::GpBitmap **")] IntPtr* bitmap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateBitmapFromDirectDrawSurface(IDirectDrawSurface7* surface, [NativeTypeName("Gdiplus::GpBitmap **")] IntPtr* bitmap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateBitmapFromGdiDib([NativeTypeName("const BITMAPINFO *")] BITMAPINFO* gdiBitmapInfo, void* gdiBitmapData, [NativeTypeName("Gdiplus::GpBitmap **")] IntPtr* bitmap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateBitmapFromHBITMAP([NativeTypeName("HBITMAP")] IntPtr hbm, [NativeTypeName("HPALETTE")] IntPtr hpal, [NativeTypeName("Gdiplus::GpBitmap **")] IntPtr* bitmap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateHBITMAPFromBitmap([NativeTypeName("Gdiplus::GpBitmap *")] IntPtr bitmap, [NativeTypeName("HBITMAP *")] IntPtr* hbmReturn, [NativeTypeName("Gdiplus::ARGB")] uint background);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateBitmapFromHICON([NativeTypeName("HICON")] IntPtr hicon, [NativeTypeName("Gdiplus::GpBitmap **")] IntPtr* bitmap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateHICONFromBitmap([NativeTypeName("Gdiplus::GpBitmap *")] IntPtr bitmap, [NativeTypeName("HICON *")] IntPtr* hbmReturn);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateBitmapFromResource([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("const WCHAR *")] ushort* lpBitmapName, [NativeTypeName("Gdiplus::GpBitmap **")] IntPtr* bitmap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCloneBitmapArea([NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height, [NativeTypeName("Gdiplus::PixelFormat")] int format, [NativeTypeName("Gdiplus::GpBitmap *")] IntPtr srcBitmap, [NativeTypeName("Gdiplus::GpBitmap **")] IntPtr* dstBitmap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCloneBitmapAreaI([NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height, [NativeTypeName("Gdiplus::PixelFormat")] int format, [NativeTypeName("Gdiplus::GpBitmap *")] IntPtr srcBitmap, [NativeTypeName("Gdiplus::GpBitmap **")] IntPtr* dstBitmap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipBitmapLockBits([NativeTypeName("Gdiplus::GpBitmap *")] IntPtr bitmap, [NativeTypeName("const Gdiplus::GpRect *")] Rect* rect, [NativeTypeName("UINT")] uint flags, [NativeTypeName("Gdiplus::PixelFormat")] int format, [NativeTypeName("Gdiplus::BitmapData *")] BitmapData* lockedBitmapData);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipBitmapUnlockBits([NativeTypeName("Gdiplus::GpBitmap *")] IntPtr bitmap, [NativeTypeName("Gdiplus::BitmapData *")] BitmapData* lockedBitmapData);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipBitmapGetPixel([NativeTypeName("Gdiplus::GpBitmap *")] IntPtr bitmap, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("Gdiplus::ARGB *")] uint* color);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipBitmapSetPixel([NativeTypeName("Gdiplus::GpBitmap *")] IntPtr bitmap, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("Gdiplus::ARGB")] uint color);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipImageSetAbort([NativeTypeName("Gdiplus::GpImage *")] IntPtr pImage, [NativeTypeName("Gdiplus::GdiplusAbort *")] GdiplusAbort* pIAbort);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGraphicsSetAbort([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr pGraphics, [NativeTypeName("Gdiplus::GdiplusAbort *")] GdiplusAbort* pIAbort);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipBitmapConvertFormat([NativeTypeName("Gdiplus::GpBitmap *")] IntPtr pInputBitmap, [NativeTypeName("Gdiplus::PixelFormat")] int format, [NativeTypeName("Gdiplus::DitherType")] DitherType dithertype, [NativeTypeName("Gdiplus::PaletteType")] PaletteType palettetype, [NativeTypeName("Gdiplus::ColorPalette *")] ColorPalette* palette, [NativeTypeName("Gdiplus::REAL")] float alphaThresholdPercent);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipInitializePalette([NativeTypeName("Gdiplus::ColorPalette *")] ColorPalette* palette, [NativeTypeName("Gdiplus::PaletteType")] PaletteType palettetype, [NativeTypeName("INT")] int optimalColors, [NativeTypeName("BOOL")] int useTransparentColor, [NativeTypeName("Gdiplus::GpBitmap *")] IntPtr bitmap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipBitmapApplyEffect([NativeTypeName("Gdiplus::GpBitmap *")] IntPtr bitmap, [NativeTypeName("Gdiplus::CGpEffect *")] IntPtr effect, RECT* roi, [NativeTypeName("BOOL")] int useAuxData, void** auxData, [NativeTypeName("INT *")] int* auxDataSize);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipBitmapCreateApplyEffect([NativeTypeName("Gdiplus::GpBitmap **")] IntPtr* inputBitmaps, [NativeTypeName("INT")] int numInputs, [NativeTypeName("Gdiplus::CGpEffect *")] IntPtr effect, RECT* roi, RECT* outputRect, [NativeTypeName("Gdiplus::GpBitmap **")] IntPtr* outputBitmap, [NativeTypeName("BOOL")] int useAuxData, void** auxData, [NativeTypeName("INT *")] int* auxDataSize);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipBitmapGetHistogram([NativeTypeName("Gdiplus::GpBitmap *")] IntPtr bitmap, [NativeTypeName("Gdiplus::HistogramFormat")] HistogramFormat format, [NativeTypeName("UINT")] uint NumberOfEntries, [NativeTypeName("UINT *")] uint* channel0, [NativeTypeName("UINT *")] uint* channel1, [NativeTypeName("UINT *")] uint* channel2, [NativeTypeName("UINT *")] uint* channel3);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipBitmapGetHistogramSize([NativeTypeName("Gdiplus::HistogramFormat")] HistogramFormat format, [NativeTypeName("UINT *")] uint* NumberOfEntries);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipBitmapSetResolution([NativeTypeName("Gdiplus::GpBitmap *")] IntPtr bitmap, [NativeTypeName("Gdiplus::REAL")] float xdpi, [NativeTypeName("Gdiplus::REAL")] float ydpi);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateImageAttributes([NativeTypeName("Gdiplus::GpImageAttributes **")] IntPtr* imageattr);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCloneImageAttributes([NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageattr, [NativeTypeName("Gdiplus::GpImageAttributes **")] IntPtr* cloneImageattr);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDisposeImageAttributes([NativeTypeName("Gdiplus::GpImageAttributes *")] IntPtr imageattr);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetImageAttributesToIdentity([NativeTypeName("Gdiplus::GpImageAttributes *")] IntPtr imageattr, [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipResetImageAttributes([NativeTypeName("Gdiplus::GpImageAttributes *")] IntPtr imageattr, [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetImageAttributesColorMatrix([NativeTypeName("Gdiplus::GpImageAttributes *")] IntPtr imageattr, [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type, [NativeTypeName("BOOL")] int enableFlag, [NativeTypeName("const Gdiplus::ColorMatrix *")] ColorMatrix* colorMatrix, [NativeTypeName("const Gdiplus::ColorMatrix *")] ColorMatrix* grayMatrix, [NativeTypeName("Gdiplus::ColorMatrixFlags")] ColorMatrixFlags flags);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetImageAttributesThreshold([NativeTypeName("Gdiplus::GpImageAttributes *")] IntPtr imageattr, [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type, [NativeTypeName("BOOL")] int enableFlag, [NativeTypeName("Gdiplus::REAL")] float threshold);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetImageAttributesGamma([NativeTypeName("Gdiplus::GpImageAttributes *")] IntPtr imageattr, [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type, [NativeTypeName("BOOL")] int enableFlag, [NativeTypeName("Gdiplus::REAL")] float gamma);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetImageAttributesNoOp([NativeTypeName("Gdiplus::GpImageAttributes *")] IntPtr imageattr, [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type, [NativeTypeName("BOOL")] int enableFlag);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetImageAttributesColorKeys([NativeTypeName("Gdiplus::GpImageAttributes *")] IntPtr imageattr, [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type, [NativeTypeName("BOOL")] int enableFlag, [NativeTypeName("Gdiplus::ARGB")] uint colorLow, [NativeTypeName("Gdiplus::ARGB")] uint colorHigh);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetImageAttributesOutputChannel([NativeTypeName("Gdiplus::GpImageAttributes *")] IntPtr imageattr, [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type, [NativeTypeName("BOOL")] int enableFlag, [NativeTypeName("Gdiplus::ColorChannelFlags")] ColorChannelFlags channelFlags);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetImageAttributesOutputChannelColorProfile([NativeTypeName("Gdiplus::GpImageAttributes *")] IntPtr imageattr, [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type, [NativeTypeName("BOOL")] int enableFlag, [NativeTypeName("const WCHAR *")] ushort* colorProfileFilename);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetImageAttributesRemapTable([NativeTypeName("Gdiplus::GpImageAttributes *")] IntPtr imageattr, [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type, [NativeTypeName("BOOL")] int enableFlag, [NativeTypeName("UINT")] uint mapSize, [NativeTypeName("const Gdiplus::ColorMap *")] ColorMap* map);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetImageAttributesWrapMode([NativeTypeName("Gdiplus::GpImageAttributes *")] IntPtr imageAttr, [NativeTypeName("Gdiplus::WrapMode")] WrapMode wrap, [NativeTypeName("Gdiplus::ARGB")] uint argb, [NativeTypeName("BOOL")] int clamp);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetImageAttributesICMMode([NativeTypeName("Gdiplus::GpImageAttributes *")] IntPtr imageAttr, [NativeTypeName("BOOL")] int on);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImageAttributesAdjustedPalette([NativeTypeName("Gdiplus::GpImageAttributes *")] IntPtr imageAttr, [NativeTypeName("Gdiplus::ColorPalette *")] ColorPalette* colorPalette, [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType colorAdjustType);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFlush([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpFlushIntention")] FlushIntention intention);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateFromHDC([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("Gdiplus::GpGraphics **")] IntPtr* graphics);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateFromHDC2([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("Gdiplus::GpGraphics **")] IntPtr* graphics);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateFromHWND([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("Gdiplus::GpGraphics **")] IntPtr* graphics);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateFromHWNDICM([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("Gdiplus::GpGraphics **")] IntPtr* graphics);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDeleteGraphics([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetDC([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("HDC *")] IntPtr* hdc);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipReleaseDC([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetCompositingMode([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::CompositingMode")] CompositingMode compositingMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetCompositingMode([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::CompositingMode *")] CompositingMode* compositingMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetRenderingOrigin([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetRenderingOrigin([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("INT *")] int* x, [NativeTypeName("INT *")] int* y);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetCompositingQuality([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::CompositingQuality")] CompositingQuality compositingQuality);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetCompositingQuality([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::CompositingQuality *")] CompositingQuality* compositingQuality);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetSmoothingMode([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::SmoothingMode")] SmoothingMode smoothingMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetSmoothingMode([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::SmoothingMode *")] SmoothingMode* smoothingMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPixelOffsetMode([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::PixelOffsetMode")] PixelOffsetMode pixelOffsetMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPixelOffsetMode([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::PixelOffsetMode *")] PixelOffsetMode* pixelOffsetMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetTextRenderingHint([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::TextRenderingHint")] TextRenderingHint mode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetTextRenderingHint([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::TextRenderingHint *")] TextRenderingHint* mode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetTextContrast([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("UINT")] uint contrast);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetTextContrast([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("UINT *")] uint* contrast);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetInterpolationMode([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::InterpolationMode")] InterpolationMode interpolationMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetInterpolationMode([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::InterpolationMode *")] InterpolationMode* interpolationMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetWorldTransform([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipResetWorldTransform([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipMultiplyWorldTransform([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipTranslateWorldTransform([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::REAL")] float dx, [NativeTypeName("Gdiplus::REAL")] float dy, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipScaleWorldTransform([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::REAL")] float sx, [NativeTypeName("Gdiplus::REAL")] float sy, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipRotateWorldTransform([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::REAL")] float angle, [NativeTypeName("Gdiplus::GpMatrixOrder")] MatrixOrder order);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetWorldTransform([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipResetPageTransform([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPageUnit([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpUnit *")] Unit* unit);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetPageScale([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::REAL *")] float* scale);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPageUnit([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpUnit")] Unit unit);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetPageScale([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::REAL")] float scale);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetDpiX([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::REAL *")] float* dpi);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetDpiY([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::REAL *")] float* dpi);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipTransformPoints([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpCoordinateSpace")] CoordinateSpace destSpace, [NativeTypeName("Gdiplus::GpCoordinateSpace")] CoordinateSpace srcSpace, [NativeTypeName("Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipTransformPointsI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpCoordinateSpace")] CoordinateSpace destSpace, [NativeTypeName("Gdiplus::GpCoordinateSpace")] CoordinateSpace srcSpace, [NativeTypeName("Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetNearestColor([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::ARGB *")] uint* argb);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("HPALETTE")]
        public static extern IntPtr GdipCreateHalftonePalette();

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawLine([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::REAL")] float x1, [NativeTypeName("Gdiplus::REAL")] float y1, [NativeTypeName("Gdiplus::REAL")] float x2, [NativeTypeName("Gdiplus::REAL")] float y2);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawLineI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("INT")] int x1, [NativeTypeName("INT")] int y1, [NativeTypeName("INT")] int x2, [NativeTypeName("INT")] int y2);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawLines([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawLinesI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawArc([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height, [NativeTypeName("Gdiplus::REAL")] float startAngle, [NativeTypeName("Gdiplus::REAL")] float sweepAngle);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawArcI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height, [NativeTypeName("Gdiplus::REAL")] float startAngle, [NativeTypeName("Gdiplus::REAL")] float sweepAngle);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawBezier([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::REAL")] float x1, [NativeTypeName("Gdiplus::REAL")] float y1, [NativeTypeName("Gdiplus::REAL")] float x2, [NativeTypeName("Gdiplus::REAL")] float y2, [NativeTypeName("Gdiplus::REAL")] float x3, [NativeTypeName("Gdiplus::REAL")] float y3, [NativeTypeName("Gdiplus::REAL")] float x4, [NativeTypeName("Gdiplus::REAL")] float y4);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawBezierI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("INT")] int x1, [NativeTypeName("INT")] int y1, [NativeTypeName("INT")] int x2, [NativeTypeName("INT")] int y2, [NativeTypeName("INT")] int x3, [NativeTypeName("INT")] int y3, [NativeTypeName("INT")] int x4, [NativeTypeName("INT")] int y4);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawBeziers([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawBeziersI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawRectangle([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawRectangleI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawRectangles([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpRectF *")] RectF* rects, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawRectanglesI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpRect *")] Rect* rects, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawEllipse([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawEllipseI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawPie([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height, [NativeTypeName("Gdiplus::REAL")] float startAngle, [NativeTypeName("Gdiplus::REAL")] float sweepAngle);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawPieI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height, [NativeTypeName("Gdiplus::REAL")] float startAngle, [NativeTypeName("Gdiplus::REAL")] float sweepAngle);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawPolygon([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawPolygonI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawPath([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("Gdiplus::GpPath *")] IntPtr path);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawCurve([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawCurveI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawCurve2([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::REAL")] float tension);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawCurve2I([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::REAL")] float tension);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawCurve3([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count, [NativeTypeName("INT")] int offset, [NativeTypeName("INT")] int numberOfSegments, [NativeTypeName("Gdiplus::REAL")] float tension);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawCurve3I([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count, [NativeTypeName("INT")] int offset, [NativeTypeName("INT")] int numberOfSegments, [NativeTypeName("Gdiplus::REAL")] float tension);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawClosedCurve([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawClosedCurveI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawClosedCurve2([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::REAL")] float tension);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawClosedCurve2I([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPen *")] IntPtr pen, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::REAL")] float tension);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGraphicsClear([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::ARGB")] uint color);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillRectangle([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillRectangleI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillRectangles([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpRectF *")] RectF* rects, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillRectanglesI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpRect *")] Rect* rects, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillPolygon([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::GpFillMode")] FillMode fillMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillPolygonI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::GpFillMode")] FillMode fillMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillPolygon2([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillPolygon2I([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillEllipse([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillEllipseI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillPie([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height, [NativeTypeName("Gdiplus::REAL")] float startAngle, [NativeTypeName("Gdiplus::REAL")] float sweepAngle);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillPieI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height, [NativeTypeName("Gdiplus::REAL")] float startAngle, [NativeTypeName("Gdiplus::REAL")] float sweepAngle);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillPath([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("Gdiplus::GpPath *")] IntPtr path);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillClosedCurve([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillClosedCurveI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillClosedCurve2([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::REAL")] float tension, [NativeTypeName("Gdiplus::GpFillMode")] FillMode fillMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillClosedCurve2I([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::REAL")] float tension, [NativeTypeName("Gdiplus::GpFillMode")] FillMode fillMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFillRegion([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("Gdiplus::GpRegion *")] IntPtr region);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawImageFX([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::GpRectF *")] RectF* source, [NativeTypeName("Gdiplus::GpMatrix *")] IntPtr xForm, [NativeTypeName("Gdiplus::CGpEffect *")] IntPtr effect, [NativeTypeName("Gdiplus::GpImageAttributes *")] IntPtr imageAttributes, [NativeTypeName("Gdiplus::GpUnit")] Unit srcUnit);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawImage([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawImageI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawImageRect([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawImageRectI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawImagePoints([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* dstpoints, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawImagePointsI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("const Gdiplus::GpPoint *")] Point* dstpoints, [NativeTypeName("INT")] int count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawImagePointRect([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float srcx, [NativeTypeName("Gdiplus::REAL")] float srcy, [NativeTypeName("Gdiplus::REAL")] float srcwidth, [NativeTypeName("Gdiplus::REAL")] float srcheight, [NativeTypeName("Gdiplus::GpUnit")] Unit srcUnit);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawImagePointRectI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int srcx, [NativeTypeName("INT")] int srcy, [NativeTypeName("INT")] int srcwidth, [NativeTypeName("INT")] int srcheight, [NativeTypeName("Gdiplus::GpUnit")] Unit srcUnit);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawImageRectRect([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("Gdiplus::REAL")] float dstx, [NativeTypeName("Gdiplus::REAL")] float dsty, [NativeTypeName("Gdiplus::REAL")] float dstwidth, [NativeTypeName("Gdiplus::REAL")] float dstheight, [NativeTypeName("Gdiplus::REAL")] float srcx, [NativeTypeName("Gdiplus::REAL")] float srcy, [NativeTypeName("Gdiplus::REAL")] float srcwidth, [NativeTypeName("Gdiplus::REAL")] float srcheight, [NativeTypeName("Gdiplus::GpUnit")] Unit srcUnit, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes, [NativeTypeName("Gdiplus::DrawImageAbort")] delegate* unmanaged<void*, int> callback, void* callbackData);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawImageRectRectI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("INT")] int dstx, [NativeTypeName("INT")] int dsty, [NativeTypeName("INT")] int dstwidth, [NativeTypeName("INT")] int dstheight, [NativeTypeName("INT")] int srcx, [NativeTypeName("INT")] int srcy, [NativeTypeName("INT")] int srcwidth, [NativeTypeName("INT")] int srcheight, [NativeTypeName("Gdiplus::GpUnit")] Unit srcUnit, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes, [NativeTypeName("Gdiplus::DrawImageAbort")] delegate* unmanaged<void*, int> callback, void* callbackData);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawImagePointsRect([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("const Gdiplus::GpPointF *")] PointF* points, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::REAL")] float srcx, [NativeTypeName("Gdiplus::REAL")] float srcy, [NativeTypeName("Gdiplus::REAL")] float srcwidth, [NativeTypeName("Gdiplus::REAL")] float srcheight, [NativeTypeName("Gdiplus::GpUnit")] Unit srcUnit, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes, [NativeTypeName("Gdiplus::DrawImageAbort")] delegate* unmanaged<void*, int> callback, void* callbackData);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawImagePointsRectI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpImage *")] IntPtr image, [NativeTypeName("const Gdiplus::GpPoint *")] Point* points, [NativeTypeName("INT")] int count, [NativeTypeName("INT")] int srcx, [NativeTypeName("INT")] int srcy, [NativeTypeName("INT")] int srcwidth, [NativeTypeName("INT")] int srcheight, [NativeTypeName("Gdiplus::GpUnit")] Unit srcUnit, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes, [NativeTypeName("Gdiplus::DrawImageAbort")] delegate* unmanaged<void*, int> callback, void* callbackData);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipEnumerateMetafileDestPoint([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("const Gdiplus::PointF &")] PointF* destPoint, [NativeTypeName("Gdiplus::EnumerateMetafileProc")] delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, int> callback, void* callbackData, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipEnumerateMetafileDestPointI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("const Gdiplus::Point &")] Point* destPoint, [NativeTypeName("Gdiplus::EnumerateMetafileProc")] delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, int> callback, void* callbackData, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipEnumerateMetafileDestRect([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("const Gdiplus::RectF &")] RectF* destRect, [NativeTypeName("Gdiplus::EnumerateMetafileProc")] delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, int> callback, void* callbackData, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipEnumerateMetafileDestRectI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("const Gdiplus::Rect &")] Rect* destRect, [NativeTypeName("Gdiplus::EnumerateMetafileProc")] delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, int> callback, void* callbackData, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipEnumerateMetafileDestPoints([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("const Gdiplus::PointF *")] PointF* destPoints, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::EnumerateMetafileProc")] delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, int> callback, void* callbackData, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipEnumerateMetafileDestPointsI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("const Gdiplus::Point *")] Point* destPoints, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::EnumerateMetafileProc")] delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, int> callback, void* callbackData, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipEnumerateMetafileSrcRectDestPoint([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("const Gdiplus::PointF &")] PointF* destPoint, [NativeTypeName("const Gdiplus::RectF &")] RectF* srcRect, [NativeTypeName("Gdiplus::Unit")] Unit srcUnit, [NativeTypeName("Gdiplus::EnumerateMetafileProc")] delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, int> callback, void* callbackData, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipEnumerateMetafileSrcRectDestPointI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("const Gdiplus::Point &")] Point* destPoint, [NativeTypeName("const Gdiplus::Rect &")] Rect* srcRect, [NativeTypeName("Gdiplus::Unit")] Unit srcUnit, [NativeTypeName("Gdiplus::EnumerateMetafileProc")] delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, int> callback, void* callbackData, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipEnumerateMetafileSrcRectDestRect([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("const Gdiplus::RectF &")] RectF* destRect, [NativeTypeName("const Gdiplus::RectF &")] RectF* srcRect, [NativeTypeName("Gdiplus::Unit")] Unit srcUnit, [NativeTypeName("Gdiplus::EnumerateMetafileProc")] delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, int> callback, void* callbackData, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipEnumerateMetafileSrcRectDestRectI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("const Gdiplus::Rect &")] Rect* destRect, [NativeTypeName("const Gdiplus::Rect &")] Rect* srcRect, [NativeTypeName("Gdiplus::Unit")] Unit srcUnit, [NativeTypeName("Gdiplus::EnumerateMetafileProc")] delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, int> callback, void* callbackData, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipEnumerateMetafileSrcRectDestPoints([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("const Gdiplus::PointF *")] PointF* destPoints, [NativeTypeName("INT")] int count, [NativeTypeName("const Gdiplus::RectF &")] RectF* srcRect, [NativeTypeName("Gdiplus::Unit")] Unit srcUnit, [NativeTypeName("Gdiplus::EnumerateMetafileProc")] delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, int> callback, void* callbackData, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipEnumerateMetafileSrcRectDestPointsI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("const Gdiplus::Point *")] Point* destPoints, [NativeTypeName("INT")] int count, [NativeTypeName("const Gdiplus::Rect &")] Rect* srcRect, [NativeTypeName("Gdiplus::Unit")] Unit srcUnit, [NativeTypeName("Gdiplus::EnumerateMetafileProc")] delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, int> callback, void* callbackData, [NativeTypeName("const Gdiplus::GpImageAttributes *")] IntPtr imageAttributes);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipPlayMetafileRecord([NativeTypeName("const Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("Gdiplus::EmfPlusRecordType")] EmfPlusRecordType recordType, [NativeTypeName("UINT")] uint flags, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const BYTE *")] byte* data);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetClipGraphics([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr srcgraphics, [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetClipRect([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height, [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetClipRectI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height, [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetClipPath([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpPath *")] IntPtr path, [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetClipRegion([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpRegion *")] IntPtr region, [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetClipHrgn([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("HRGN")] IntPtr hRgn, [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipResetClip([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipTranslateClip([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::REAL")] float dx, [NativeTypeName("Gdiplus::REAL")] float dy);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipTranslateClipI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("INT")] int dx, [NativeTypeName("INT")] int dy);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetClip([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpRegion *")] IntPtr region);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetClipBounds([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpRectF *")] RectF* rect);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetClipBoundsI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpRect *")] Rect* rect);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsClipEmpty([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetVisibleClipBounds([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpRectF *")] RectF* rect);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetVisibleClipBoundsI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpRect *")] Rect* rect);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsVisibleClipEmpty([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsVisiblePoint([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsVisiblePointI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsVisibleRect([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsVisibleRectI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height, [NativeTypeName("BOOL *")] int* result);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSaveGraphics([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GraphicsState *")] uint* state);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipRestoreGraphics([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GraphicsState")] uint state);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipBeginContainer([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const Gdiplus::GpRectF *")] RectF* dstrect, [NativeTypeName("const Gdiplus::GpRectF *")] RectF* srcrect, [NativeTypeName("Gdiplus::GpUnit")] Unit unit, [NativeTypeName("Gdiplus::GraphicsContainer *")] uint* state);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipBeginContainerI([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const Gdiplus::GpRect *")] Rect* dstrect, [NativeTypeName("const Gdiplus::GpRect *")] Rect* srcrect, [NativeTypeName("Gdiplus::GpUnit")] Unit unit, [NativeTypeName("Gdiplus::GraphicsContainer *")] uint* state);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipBeginContainer2([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GraphicsContainer *")] uint* state);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipEndContainer([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GraphicsContainer")] uint state);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetMetafileHeaderFromWmf([NativeTypeName("HMETAFILE")] IntPtr hWmf, [NativeTypeName("const Gdiplus::WmfPlaceableFileHeader *")] WmfPlaceableFileHeader* wmfPlaceableFileHeader, [NativeTypeName("Gdiplus::MetafileHeader *")] MetafileHeader* header);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetMetafileHeaderFromEmf([NativeTypeName("HENHMETAFILE")] IntPtr hEmf, [NativeTypeName("Gdiplus::MetafileHeader *")] MetafileHeader* header);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetMetafileHeaderFromFile([NativeTypeName("const WCHAR *")] ushort* filename, [NativeTypeName("Gdiplus::MetafileHeader *")] MetafileHeader* header);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetMetafileHeaderFromStream(IStream* stream, [NativeTypeName("Gdiplus::MetafileHeader *")] MetafileHeader* header);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetMetafileHeaderFromMetafile([NativeTypeName("Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("Gdiplus::MetafileHeader *")] MetafileHeader* header);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetHemfFromMetafile([NativeTypeName("Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("HENHMETAFILE *")] IntPtr* hEmf);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateStreamOnFile([NativeTypeName("const WCHAR *")] ushort* filename, [NativeTypeName("UINT")] uint access, IStream** stream);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateMetafileFromWmf([NativeTypeName("HMETAFILE")] IntPtr hWmf, [NativeTypeName("BOOL")] int deleteWmf, [NativeTypeName("const Gdiplus::WmfPlaceableFileHeader *")] WmfPlaceableFileHeader* wmfPlaceableFileHeader, [NativeTypeName("Gdiplus::GpMetafile **")] IntPtr* metafile);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateMetafileFromEmf([NativeTypeName("HENHMETAFILE")] IntPtr hEmf, [NativeTypeName("BOOL")] int deleteEmf, [NativeTypeName("Gdiplus::GpMetafile **")] IntPtr* metafile);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateMetafileFromFile([NativeTypeName("const WCHAR *")] ushort* file, [NativeTypeName("Gdiplus::GpMetafile **")] IntPtr* metafile);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateMetafileFromWmfFile([NativeTypeName("const WCHAR *")] ushort* file, [NativeTypeName("const Gdiplus::WmfPlaceableFileHeader *")] WmfPlaceableFileHeader* wmfPlaceableFileHeader, [NativeTypeName("Gdiplus::GpMetafile **")] IntPtr* metafile);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateMetafileFromStream(IStream* stream, [NativeTypeName("Gdiplus::GpMetafile **")] IntPtr* metafile);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipRecordMetafile([NativeTypeName("HDC")] IntPtr referenceHdc, [NativeTypeName("Gdiplus::EmfType")] EmfType type, [NativeTypeName("const Gdiplus::GpRectF *")] RectF* frameRect, [NativeTypeName("Gdiplus::MetafileFrameUnit")] MetafileFrameUnit frameUnit, [NativeTypeName("const WCHAR *")] ushort* description, [NativeTypeName("Gdiplus::GpMetafile **")] IntPtr* metafile);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipRecordMetafileI([NativeTypeName("HDC")] IntPtr referenceHdc, [NativeTypeName("Gdiplus::EmfType")] EmfType type, [NativeTypeName("const Gdiplus::GpRect *")] Rect* frameRect, [NativeTypeName("Gdiplus::MetafileFrameUnit")] MetafileFrameUnit frameUnit, [NativeTypeName("const WCHAR *")] ushort* description, [NativeTypeName("Gdiplus::GpMetafile **")] IntPtr* metafile);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipRecordMetafileFileName([NativeTypeName("const WCHAR *")] ushort* fileName, [NativeTypeName("HDC")] IntPtr referenceHdc, [NativeTypeName("Gdiplus::EmfType")] EmfType type, [NativeTypeName("const Gdiplus::GpRectF *")] RectF* frameRect, [NativeTypeName("Gdiplus::MetafileFrameUnit")] MetafileFrameUnit frameUnit, [NativeTypeName("const WCHAR *")] ushort* description, [NativeTypeName("Gdiplus::GpMetafile **")] IntPtr* metafile);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipRecordMetafileFileNameI([NativeTypeName("const WCHAR *")] ushort* fileName, [NativeTypeName("HDC")] IntPtr referenceHdc, [NativeTypeName("Gdiplus::EmfType")] EmfType type, [NativeTypeName("const Gdiplus::GpRect *")] Rect* frameRect, [NativeTypeName("Gdiplus::MetafileFrameUnit")] MetafileFrameUnit frameUnit, [NativeTypeName("const WCHAR *")] ushort* description, [NativeTypeName("Gdiplus::GpMetafile **")] IntPtr* metafile);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipRecordMetafileStream(IStream* stream, [NativeTypeName("HDC")] IntPtr referenceHdc, [NativeTypeName("Gdiplus::EmfType")] EmfType type, [NativeTypeName("const Gdiplus::GpRectF *")] RectF* frameRect, [NativeTypeName("Gdiplus::MetafileFrameUnit")] MetafileFrameUnit frameUnit, [NativeTypeName("const WCHAR *")] ushort* description, [NativeTypeName("Gdiplus::GpMetafile **")] IntPtr* metafile);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipRecordMetafileStreamI(IStream* stream, [NativeTypeName("HDC")] IntPtr referenceHdc, [NativeTypeName("Gdiplus::EmfType")] EmfType type, [NativeTypeName("const Gdiplus::GpRect *")] Rect* frameRect, [NativeTypeName("Gdiplus::MetafileFrameUnit")] MetafileFrameUnit frameUnit, [NativeTypeName("const WCHAR *")] ushort* description, [NativeTypeName("Gdiplus::GpMetafile **")] IntPtr* metafile);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetMetafileDownLevelRasterizationLimit([NativeTypeName("Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("UINT")] uint metafileRasterizationLimitDpi);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetMetafileDownLevelRasterizationLimit([NativeTypeName("const Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("UINT *")] uint* metafileRasterizationLimitDpi);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImageDecodersSize([NativeTypeName("UINT *")] uint* numDecoders, [NativeTypeName("UINT *")] uint* size);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImageDecoders([NativeTypeName("UINT")] uint numDecoders, [NativeTypeName("UINT")] uint size, [NativeTypeName("Gdiplus::ImageCodecInfo *")] ImageCodecInfo* decoders);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImageEncodersSize([NativeTypeName("UINT *")] uint* numEncoders, [NativeTypeName("UINT *")] uint* size);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetImageEncoders([NativeTypeName("UINT")] uint numEncoders, [NativeTypeName("UINT")] uint size, [NativeTypeName("Gdiplus::ImageCodecInfo *")] ImageCodecInfo* encoders);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipComment([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("UINT")] uint sizeData, [NativeTypeName("const BYTE *")] byte* data);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateFontFamilyFromName([NativeTypeName("const WCHAR *")] ushort* name, [NativeTypeName("Gdiplus::GpFontCollection *")] IntPtr fontCollection, [NativeTypeName("Gdiplus::GpFontFamily **")] IntPtr* fontFamily);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDeleteFontFamily([NativeTypeName("Gdiplus::GpFontFamily *")] IntPtr fontFamily);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCloneFontFamily([NativeTypeName("Gdiplus::GpFontFamily *")] IntPtr fontFamily, [NativeTypeName("Gdiplus::GpFontFamily **")] IntPtr* clonedFontFamily);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetGenericFontFamilySansSerif([NativeTypeName("Gdiplus::GpFontFamily **")] IntPtr* nativeFamily);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetGenericFontFamilySerif([NativeTypeName("Gdiplus::GpFontFamily **")] IntPtr* nativeFamily);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetGenericFontFamilyMonospace([NativeTypeName("Gdiplus::GpFontFamily **")] IntPtr* nativeFamily);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetFamilyName([NativeTypeName("const Gdiplus::GpFontFamily *")] IntPtr family, [NativeTypeName("LPWSTR")] ushort* name, [NativeTypeName("LANGID")] ushort language);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipIsStyleAvailable([NativeTypeName("const Gdiplus::GpFontFamily *")] IntPtr family, [NativeTypeName("INT")] int style, [NativeTypeName("BOOL *")] int* IsStyleAvailable);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFontCollectionEnumerable([NativeTypeName("Gdiplus::GpFontCollection *")] IntPtr fontCollection, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("INT *")] int* numFound);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipFontCollectionEnumerate([NativeTypeName("Gdiplus::GpFontCollection *")] IntPtr fontCollection, [NativeTypeName("INT")] int numSought, [NativeTypeName("Gdiplus::GpFontFamily *[]")] IntPtr* gpfamilies, [NativeTypeName("INT *")] int* numFound, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetEmHeight([NativeTypeName("const Gdiplus::GpFontFamily *")] IntPtr family, [NativeTypeName("INT")] int style, [NativeTypeName("UINT16 *")] ushort* EmHeight);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetCellAscent([NativeTypeName("const Gdiplus::GpFontFamily *")] IntPtr family, [NativeTypeName("INT")] int style, [NativeTypeName("UINT16 *")] ushort* CellAscent);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetCellDescent([NativeTypeName("const Gdiplus::GpFontFamily *")] IntPtr family, [NativeTypeName("INT")] int style, [NativeTypeName("UINT16 *")] ushort* CellDescent);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetLineSpacing([NativeTypeName("const Gdiplus::GpFontFamily *")] IntPtr family, [NativeTypeName("INT")] int style, [NativeTypeName("UINT16 *")] ushort* LineSpacing);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateFontFromDC([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("Gdiplus::GpFont **")] IntPtr* font);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateFontFromLogfontA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const LOGFONTA *")] LOGFONTA* logfont, [NativeTypeName("Gdiplus::GpFont **")] IntPtr* font);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateFontFromLogfontW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const LOGFONTW *")] LOGFONTW* logfont, [NativeTypeName("Gdiplus::GpFont **")] IntPtr* font);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateFont([NativeTypeName("const Gdiplus::GpFontFamily *")] IntPtr fontFamily, [NativeTypeName("Gdiplus::REAL")] float emSize, [NativeTypeName("INT")] int style, [NativeTypeName("Gdiplus::Unit")] Unit unit, [NativeTypeName("Gdiplus::GpFont **")] IntPtr* font);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCloneFont([NativeTypeName("Gdiplus::GpFont *")] IntPtr font, [NativeTypeName("Gdiplus::GpFont **")] IntPtr* cloneFont);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDeleteFont([NativeTypeName("Gdiplus::GpFont *")] IntPtr font);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetFamily([NativeTypeName("Gdiplus::GpFont *")] IntPtr font, [NativeTypeName("Gdiplus::GpFontFamily **")] IntPtr* family);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetFontStyle([NativeTypeName("Gdiplus::GpFont *")] IntPtr font, [NativeTypeName("INT *")] int* style);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetFontSize([NativeTypeName("Gdiplus::GpFont *")] IntPtr font, [NativeTypeName("Gdiplus::REAL *")] float* size);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetFontUnit([NativeTypeName("Gdiplus::GpFont *")] IntPtr font, [NativeTypeName("Gdiplus::Unit *")] Unit* unit);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetFontHeight([NativeTypeName("const Gdiplus::GpFont *")] IntPtr font, [NativeTypeName("const Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::REAL *")] float* height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetFontHeightGivenDPI([NativeTypeName("const Gdiplus::GpFont *")] IntPtr font, [NativeTypeName("Gdiplus::REAL")] float dpi, [NativeTypeName("Gdiplus::REAL *")] float* height);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetLogFontA([NativeTypeName("Gdiplus::GpFont *")] IntPtr font, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, LOGFONTA* logfontA);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetLogFontW([NativeTypeName("Gdiplus::GpFont *")] IntPtr font, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, LOGFONTW* logfontW);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipNewInstalledFontCollection([NativeTypeName("Gdiplus::GpFontCollection **")] IntPtr* fontCollection);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipNewPrivateFontCollection([NativeTypeName("Gdiplus::GpFontCollection **")] IntPtr* fontCollection);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDeletePrivateFontCollection([NativeTypeName("Gdiplus::GpFontCollection **")] IntPtr* fontCollection);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetFontCollectionFamilyCount([NativeTypeName("Gdiplus::GpFontCollection *")] IntPtr fontCollection, [NativeTypeName("INT *")] int* numFound);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetFontCollectionFamilyList([NativeTypeName("Gdiplus::GpFontCollection *")] IntPtr fontCollection, [NativeTypeName("INT")] int numSought, [NativeTypeName("Gdiplus::GpFontFamily *[]")] IntPtr* gpfamilies, [NativeTypeName("INT *")] int* numFound);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipPrivateAddFontFile([NativeTypeName("Gdiplus::GpFontCollection *")] IntPtr fontCollection, [NativeTypeName("const WCHAR *")] ushort* filename);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipPrivateAddMemoryFont([NativeTypeName("Gdiplus::GpFontCollection *")] IntPtr fontCollection, [NativeTypeName("const void *")] void* memory, [NativeTypeName("INT")] int length);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawString([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("INT")] int length, [NativeTypeName("const Gdiplus::GpFont *")] IntPtr font, [NativeTypeName("const Gdiplus::RectF *")] RectF* layoutRect, [NativeTypeName("const Gdiplus::GpStringFormat *")] IntPtr stringFormat, [NativeTypeName("const Gdiplus::GpBrush *")] IntPtr brush);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipMeasureString([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("INT")] int length, [NativeTypeName("const Gdiplus::GpFont *")] IntPtr font, [NativeTypeName("const Gdiplus::RectF *")] RectF* layoutRect, [NativeTypeName("const Gdiplus::GpStringFormat *")] IntPtr stringFormat, [NativeTypeName("Gdiplus::RectF *")] RectF* boundingBox, [NativeTypeName("INT *")] int* codepointsFitted, [NativeTypeName("INT *")] int* linesFilled);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipMeasureCharacterRanges([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("INT")] int length, [NativeTypeName("const Gdiplus::GpFont *")] IntPtr font, [NativeTypeName("const Gdiplus::RectF &")] RectF* layoutRect, [NativeTypeName("const Gdiplus::GpStringFormat *")] IntPtr stringFormat, [NativeTypeName("INT")] int regionCount, [NativeTypeName("Gdiplus::GpRegion **")] IntPtr* regions);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawDriverString([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const UINT16 *")] ushort* text, [NativeTypeName("INT")] int length, [NativeTypeName("const Gdiplus::GpFont *")] IntPtr font, [NativeTypeName("const Gdiplus::GpBrush *")] IntPtr brush, [NativeTypeName("const Gdiplus::PointF *")] PointF* positions, [NativeTypeName("INT")] int flags, [NativeTypeName("const Gdiplus::GpMatrix *")] IntPtr matrix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipMeasureDriverString([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("const UINT16 *")] ushort* text, [NativeTypeName("INT")] int length, [NativeTypeName("const Gdiplus::GpFont *")] IntPtr font, [NativeTypeName("const Gdiplus::PointF *")] PointF* positions, [NativeTypeName("INT")] int flags, [NativeTypeName("const Gdiplus::GpMatrix *")] IntPtr matrix, [NativeTypeName("Gdiplus::RectF *")] RectF* boundingBox);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateStringFormat([NativeTypeName("INT")] int formatAttributes, [NativeTypeName("LANGID")] ushort language, [NativeTypeName("Gdiplus::GpStringFormat **")] IntPtr* format);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipStringFormatGetGenericDefault([NativeTypeName("Gdiplus::GpStringFormat **")] IntPtr* format);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipStringFormatGetGenericTypographic([NativeTypeName("Gdiplus::GpStringFormat **")] IntPtr* format);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDeleteStringFormat([NativeTypeName("Gdiplus::GpStringFormat *")] IntPtr format);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCloneStringFormat([NativeTypeName("const Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("Gdiplus::GpStringFormat **")] IntPtr* newFormat);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetStringFormatFlags([NativeTypeName("Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("INT")] int flags);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetStringFormatFlags([NativeTypeName("const Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("INT *")] int* flags);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetStringFormatAlign([NativeTypeName("Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("Gdiplus::StringAlignment")] StringAlignment align);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetStringFormatAlign([NativeTypeName("const Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("Gdiplus::StringAlignment *")] StringAlignment* align);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetStringFormatLineAlign([NativeTypeName("Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("Gdiplus::StringAlignment")] StringAlignment align);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetStringFormatLineAlign([NativeTypeName("const Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("Gdiplus::StringAlignment *")] StringAlignment* align);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetStringFormatTrimming([NativeTypeName("Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("Gdiplus::StringTrimming")] StringTrimming trimming);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetStringFormatTrimming([NativeTypeName("const Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("Gdiplus::StringTrimming *")] StringTrimming* trimming);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetStringFormatHotkeyPrefix([NativeTypeName("Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("INT")] int hotkeyPrefix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetStringFormatHotkeyPrefix([NativeTypeName("const Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("INT *")] int* hotkeyPrefix);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetStringFormatTabStops([NativeTypeName("Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("Gdiplus::REAL")] float firstTabOffset, [NativeTypeName("INT")] int count, [NativeTypeName("const Gdiplus::REAL *")] float* tabStops);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetStringFormatTabStops([NativeTypeName("const Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("INT")] int count, [NativeTypeName("Gdiplus::REAL *")] float* firstTabOffset, [NativeTypeName("Gdiplus::REAL *")] float* tabStops);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetStringFormatTabStopCount([NativeTypeName("const Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("INT *")] int* count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetStringFormatDigitSubstitution([NativeTypeName("Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("LANGID")] ushort language, [NativeTypeName("Gdiplus::StringDigitSubstitute")] StringDigitSubstitute substitute);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetStringFormatDigitSubstitution([NativeTypeName("const Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("LANGID *")] ushort* language, [NativeTypeName("Gdiplus::StringDigitSubstitute *")] StringDigitSubstitute* substitute);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipGetStringFormatMeasurableCharacterRangeCount([NativeTypeName("const Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("INT *")] int* count);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetStringFormatMeasurableCharacterRanges([NativeTypeName("Gdiplus::GpStringFormat *")] IntPtr format, [NativeTypeName("INT")] int rangeCount, [NativeTypeName("const Gdiplus::CharacterRange *")] CharacterRange* ranges);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipCreateCachedBitmap([NativeTypeName("Gdiplus::GpBitmap *")] IntPtr bitmap, [NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpCachedBitmap **")] IntPtr* cachedBitmap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDeleteCachedBitmap([NativeTypeName("Gdiplus::GpCachedBitmap *")] IntPtr cachedBitmap);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipDrawCachedBitmap([NativeTypeName("Gdiplus::GpGraphics *")] IntPtr graphics, [NativeTypeName("Gdiplus::GpCachedBitmap *")] IntPtr cachedBitmap, [NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GdipEmfToWmfBits([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint cbData16, [NativeTypeName("LPBYTE")] byte* pData16, [NativeTypeName("INT")] int iMapMode, [NativeTypeName("INT")] int eFlags);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipSetImageAttributesCachedBackground([NativeTypeName("Gdiplus::GpImageAttributes *")] IntPtr imageattr, [NativeTypeName("BOOL")] int enableFlag);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipTestControl([NativeTypeName("Gdiplus::GpTestControlEnum")] GpTestControlEnum control, void* param1);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdiplusNotificationHook([NativeTypeName("ULONG_PTR *")] nuint* token);

        [DllImport("GdiPlus", ExactSpelling = true)]
        public static extern void GdiplusNotificationUnhook([NativeTypeName("ULONG_PTR")] nuint token);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipConvertToEmfPlus([NativeTypeName("const Gdiplus::GpGraphics *")] IntPtr refGraphics, [NativeTypeName("Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("INT *")] int* conversionFailureFlag, [NativeTypeName("Gdiplus::EmfType")] EmfType emfType, [NativeTypeName("const WCHAR *")] ushort* description, [NativeTypeName("Gdiplus::GpMetafile **")] IntPtr* out_metafile);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipConvertToEmfPlusToFile([NativeTypeName("const Gdiplus::GpGraphics *")] IntPtr refGraphics, [NativeTypeName("Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("INT *")] int* conversionFailureFlag, [NativeTypeName("const WCHAR *")] ushort* filename, [NativeTypeName("Gdiplus::EmfType")] EmfType emfType, [NativeTypeName("const WCHAR *")] ushort* description, [NativeTypeName("Gdiplus::GpMetafile **")] IntPtr* out_metafile);

        [DllImport("GdiPlus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::GpStatus")]
        public static extern Status GdipConvertToEmfPlusToStream([NativeTypeName("const Gdiplus::GpGraphics *")] IntPtr refGraphics, [NativeTypeName("Gdiplus::GpMetafile *")] IntPtr metafile, [NativeTypeName("INT *")] int* conversionFailureFlag, IStream* stream, [NativeTypeName("Gdiplus::EmfType")] EmfType emfType, [NativeTypeName("const WCHAR *")] ushort* description, [NativeTypeName("Gdiplus::GpMetafile **")] IntPtr* out_metafile);
    }
}
