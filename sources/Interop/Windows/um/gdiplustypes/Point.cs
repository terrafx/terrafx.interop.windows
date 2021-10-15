// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct Point
    {
        [NativeTypeName("INT")]
        public int X;

        [NativeTypeName("INT")]
        public int Y;

        public unsafe Point([NativeTypeName("const Gdiplus::Point &")] Point* point)
        {
            X = point->X;
            Y = point->Y;
        }

        public unsafe Point([NativeTypeName("const Gdiplus::Size &")] Size* size)
        {
            X = size->Width;
            Y = size->Height;
        }

        public Point([NativeTypeName("INT")] int x, [NativeTypeName("INT")] int y)
        {
            X = x;
            Y = y;
        }

        [return: NativeTypeName("Gdiplus::Point")]
        public unsafe Point Add([NativeTypeName("const Gdiplus::Point &")] Point* point)
        {
            return new Point(X + point->X, Y + point->Y);
        }

        [return: NativeTypeName("Gdiplus::Point")]
        public unsafe Point Subtract([NativeTypeName("const Gdiplus::Point &")] Point* point)
        {
            return new Point(X - point->X, Y - point->Y);
        }

        [return: NativeTypeName("BOOL")]
        public unsafe int Equals([NativeTypeName("const Gdiplus::Point &")] Point* point)
        {
            return ((X == point->X) && (Y == point->Y)) ? 1 : 0;
        }
    }
}
