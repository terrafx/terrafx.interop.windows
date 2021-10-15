// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct RectF
    {
        [NativeTypeName("Gdiplus::REAL")]
        public float X;

        [NativeTypeName("Gdiplus::REAL")]
        public float Y;

        [NativeTypeName("Gdiplus::REAL")]
        public float Width;

        [NativeTypeName("Gdiplus::REAL")]
        public float Height;

        public RectF([NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public unsafe RectF([NativeTypeName("const Gdiplus::PointF &")] PointF* location, [NativeTypeName("const Gdiplus::SizeF &")] SizeF* size)
        {
            X = location->X;
            Y = location->Y;
            Width = size->Width;
            Height = size->Height;
        }

        public unsafe void GetLocation([NativeTypeName("Gdiplus::PointF *")] PointF* point)
        {
            point->X = X;
            point->Y = Y;
        }

        public unsafe void GetSize([NativeTypeName("Gdiplus::SizeF *")] SizeF* size)
        {
            size->Width = Width;
            size->Height = Height;
        }

        public unsafe void GetBounds([NativeTypeName("Gdiplus::RectF *")] RectF* rect)
        {
            rect->X = X;
            rect->Y = Y;
            rect->Width = Width;
            rect->Height = Height;
        }

        [return: NativeTypeName("Gdiplus::REAL")]
        public float GetLeft()
        {
            return X;
        }

        [return: NativeTypeName("Gdiplus::REAL")]
        public float GetTop()
        {
            return Y;
        }

        [return: NativeTypeName("Gdiplus::REAL")]
        public float GetRight()
        {
            return X + Width;
        }

        [return: NativeTypeName("Gdiplus::REAL")]
        public float GetBottom()
        {
            return Y + Height;
        }

        [return: NativeTypeName("BOOL")]
        public int IsEmptyArea()
        {
            return ((Width <= 1.192092896e-07F) || (Height <= 1.192092896e-07F)) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public unsafe int Equals([NativeTypeName("const Gdiplus::RectF &")] RectF* rect)
        {
            return (X == rect->X && Y == rect->Y && Width == rect->Width && Height == rect->Height) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public int Contains([NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y)
        {
            return (x >= X && x < X + Width && y >= Y && y < Y + Height) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public unsafe int Contains([NativeTypeName("const Gdiplus::PointF &")] PointF* pt)
        {
            return Contains(pt->X, pt->Y);
        }

        [return: NativeTypeName("BOOL")]
        public unsafe int Contains([NativeTypeName("const Gdiplus::RectF &")] RectF* rect)
        {
            return ((X <= rect->X) && (rect->GetRight() <= GetRight()) && (Y <= rect->Y) && (rect->GetBottom() <= GetBottom())) ? 1 : 0;
        }

        public void Inflate([NativeTypeName("Gdiplus::REAL")] float dx, [NativeTypeName("Gdiplus::REAL")] float dy)
        {
            X -= dx;
            Y -= dy;
            Width += 2 * dx;
            Height += 2 * dy;
        }

        public unsafe void Inflate([NativeTypeName("const Gdiplus::PointF &")] PointF* point)
        {
            Inflate(point->X, point->Y);
        }

        [return: NativeTypeName("BOOL")]
        public static unsafe int Intersect([NativeTypeName("Gdiplus::RectF &")] RectF* c, [NativeTypeName("const Gdiplus::RectF &")] RectF* a, [NativeTypeName("const Gdiplus::RectF &")] RectF* b)
        {
            float right = (((a->GetRight()) < (b->GetRight())) ? (a->GetRight()) : (b->GetRight()));
            float bottom = (((a->GetBottom()) < (b->GetBottom())) ? (a->GetBottom()) : (b->GetBottom()));
            float left = (((a->GetLeft()) > (b->GetLeft())) ? (a->GetLeft()) : (b->GetLeft()));
            float top = (((a->GetTop()) > (b->GetTop())) ? (a->GetTop()) : (b->GetTop()));

            c->X = left;
            c->Y = top;
            c->Width = right - left;
            c->Height = bottom - top;
            return (c->IsEmptyArea() == 0) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public unsafe int IntersectsWith([NativeTypeName("const Gdiplus::RectF &")] RectF* rect)
        {
            return (GetLeft() < rect->GetRight() && GetTop() < rect->GetBottom() && GetRight() > rect->GetLeft() && GetBottom() > rect->GetTop()) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public static unsafe int Union([NativeTypeName("Gdiplus::RectF &")] RectF* c, [NativeTypeName("const Gdiplus::RectF &")] RectF* a, [NativeTypeName("const Gdiplus::RectF &")] RectF* b)
        {
            float right = (((a->GetRight()) > (b->GetRight())) ? (a->GetRight()) : (b->GetRight()));
            float bottom = (((a->GetBottom()) > (b->GetBottom())) ? (a->GetBottom()) : (b->GetBottom()));
            float left = (((a->GetLeft()) < (b->GetLeft())) ? (a->GetLeft()) : (b->GetLeft()));
            float top = (((a->GetTop()) < (b->GetTop())) ? (a->GetTop()) : (b->GetTop()));

            c->X = left;
            c->Y = top;
            c->Width = right - left;
            c->Height = bottom - top;
            return (c->IsEmptyArea() == 0) ? 1 : 0;
        }

        public unsafe void Offset([NativeTypeName("const Gdiplus::PointF &")] PointF* point)
        {
            Offset(point->X, point->Y);
        }

        public void Offset([NativeTypeName("Gdiplus::REAL")] float dx, [NativeTypeName("Gdiplus::REAL")] float dy)
        {
            X += dx;
            Y += dy;
        }
    }
}
