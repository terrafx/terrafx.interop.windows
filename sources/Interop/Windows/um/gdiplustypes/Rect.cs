// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct Rect
    {
        [NativeTypeName("INT")]
        public int X;

        [NativeTypeName("INT")]
        public int Y;

        [NativeTypeName("INT")]
        public int Width;

        [NativeTypeName("INT")]
        public int Height;

        public Rect([NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y, [NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public unsafe Rect([NativeTypeName("const Gdiplus::Point &")] Point* location, [NativeTypeName("const Gdiplus::Size &")] Size* size)
        {
            X = location->X;
            Y = location->Y;
            Width = size->Width;
            Height = size->Height;
        }

        public unsafe void GetLocation([NativeTypeName("Gdiplus::Point *")] Point* point)
        {
            point->X = X;
            point->Y = Y;
        }

        public unsafe void GetSize([NativeTypeName("Gdiplus::Size *")] Size* size)
        {
            size->Width = Width;
            size->Height = Height;
        }

        public unsafe void GetBounds([NativeTypeName("Gdiplus::Rect *")] Rect* rect)
        {
            rect->X = X;
            rect->Y = Y;
            rect->Width = Width;
            rect->Height = Height;
        }

        [return: NativeTypeName("INT")]
        public int GetLeft()
        {
            return X;
        }

        [return: NativeTypeName("INT")]
        public int GetTop()
        {
            return Y;
        }

        [return: NativeTypeName("INT")]
        public int GetRight()
        {
            return X + Width;
        }

        [return: NativeTypeName("INT")]
        public int GetBottom()
        {
            return Y + Height;
        }

        [return: NativeTypeName("BOOL")]
        public int IsEmptyArea()
        {
            return ((Width <= 0) || (Height <= 0)) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public unsafe int Equals([NativeTypeName("const Gdiplus::Rect &")] Rect* rect)
        {
            return (X == rect->X && Y == rect->Y && Width == rect->Width && Height == rect->Height) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public int Contains([NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y)
        {
            return (x >= X && x < X + Width && y >= Y && y < Y + Height) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public unsafe int Contains([NativeTypeName("const Gdiplus::Point &")] Point* pt)
        {
            return Contains(pt->X, pt->Y);
        }

        [return: NativeTypeName("BOOL")]
        public unsafe int Contains([NativeTypeName("Gdiplus::Rect &")] Rect* rect)
        {
            return ((X <= rect->X) && (rect->GetRight() <= GetRight()) && (Y <= rect->Y) && (rect->GetBottom() <= GetBottom())) ? 1 : 0;
        }

        public void Inflate([NativeTypeName("INT")] int dx, [NativeTypeName("INT")] int dy)
        {
            X -= dx;
            Y -= dy;
            Width += 2 * dx;
            Height += 2 * dy;
        }

        public unsafe void Inflate([NativeTypeName("const Gdiplus::Point &")] Point* point)
        {
            Inflate(point->X, point->Y);
        }

        [return: NativeTypeName("BOOL")]
        public static unsafe int Intersect([NativeTypeName("Gdiplus::Rect &")] Rect* c, [NativeTypeName("const Gdiplus::Rect &")] Rect* a, [NativeTypeName("const Gdiplus::Rect &")] Rect* b)
        {
            int right = (((a->GetRight()) < (b->GetRight())) ? (a->GetRight()) : (b->GetRight()));
            int bottom = (((a->GetBottom()) < (b->GetBottom())) ? (a->GetBottom()) : (b->GetBottom()));
            int left = (((a->GetLeft()) > (b->GetLeft())) ? (a->GetLeft()) : (b->GetLeft()));
            int top = (((a->GetTop()) > (b->GetTop())) ? (a->GetTop()) : (b->GetTop()));

            c->X = left;
            c->Y = top;
            c->Width = right - left;
            c->Height = bottom - top;
            return (c->IsEmptyArea() == 0) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public unsafe int IntersectsWith([NativeTypeName("const Gdiplus::Rect &")] Rect* rect)
        {
            return (GetLeft() < rect->GetRight() && GetTop() < rect->GetBottom() && GetRight() > rect->GetLeft() && GetBottom() > rect->GetTop()) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public static unsafe int Union([NativeTypeName("Gdiplus::Rect &")] Rect* c, [NativeTypeName("const Gdiplus::Rect &")] Rect* a, [NativeTypeName("const Gdiplus::Rect &")] Rect* b)
        {
            int right = (((a->GetRight()) > (b->GetRight())) ? (a->GetRight()) : (b->GetRight()));
            int bottom = (((a->GetBottom()) > (b->GetBottom())) ? (a->GetBottom()) : (b->GetBottom()));
            int left = (((a->GetLeft()) < (b->GetLeft())) ? (a->GetLeft()) : (b->GetLeft()));
            int top = (((a->GetTop()) < (b->GetTop())) ? (a->GetTop()) : (b->GetTop()));

            c->X = left;
            c->Y = top;
            c->Width = right - left;
            c->Height = bottom - top;
            return (c->IsEmptyArea() == 0) ? 1 : 0;
        }

        public unsafe void Offset([NativeTypeName("const Gdiplus::Point &")] Point* point)
        {
            Offset(point->X, point->Y);
        }

        public void Offset([NativeTypeName("INT")] int dx, [NativeTypeName("INT")] int dy)
        {
            X += dx;
            Y += dy;
        }
    }
}
