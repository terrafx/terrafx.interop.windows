// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct PointF
    {
        [NativeTypeName("Gdiplus::REAL")]
        public float X;

        [NativeTypeName("Gdiplus::REAL")]
        public float Y;

        public unsafe PointF([NativeTypeName("const Gdiplus::PointF &")] PointF* point)
        {
            X = point->X;
            Y = point->Y;
        }

        public unsafe PointF([NativeTypeName("const Gdiplus::SizeF &")] SizeF* size)
        {
            X = size->Width;
            Y = size->Height;
        }

        public PointF([NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y)
        {
            X = x;
            Y = y;
        }

        public unsafe PointF Add([NativeTypeName("const Gdiplus::PointF &")] PointF* point)
        {
            return new PointF(X + point->X, Y + point->Y);
        }

        public unsafe PointF Subtract([NativeTypeName("const Gdiplus::PointF &")] PointF* point)
        {
            return new PointF(X - point->X, Y - point->Y);
        }

        [return: NativeTypeName("BOOL")]
        public unsafe int Equals([NativeTypeName("const Gdiplus::PointF &")] PointF* point)
        {
            return ((X == point->X) && (Y == point->Y)) ? 1 : 0;
        }
    }
}
