// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.Gdiplus;

/// <include file='Point.xml' path='doc/member[@name="Point"]/*' />
public partial struct Point
{
    /// <include file='Point.xml' path='doc/member[@name="Point.X"]/*' />
    public int X;

    /// <include file='Point.xml' path='doc/member[@name="Point.Y"]/*' />
    public int Y;

    public Point()
    {
        X = Y = 0;
    }

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

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public unsafe BOOL Equals([NativeTypeName("const Gdiplus::Point &")] Point* point)
    {
        return ((X == point->X) && (Y == point->Y)) ? 1 : 0;
    }
}
