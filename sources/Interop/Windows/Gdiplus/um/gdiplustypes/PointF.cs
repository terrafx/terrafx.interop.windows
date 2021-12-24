// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.Gdiplus;

/// <include file='PointF.xml' path='doc/member[@name="PointF"]/*' />
public partial struct PointF
{
    /// <include file='PointF.xml' path='doc/member[@name="PointF.X"]/*' />
    [NativeTypeName("Gdiplus::REAL")]
    public float X;

    /// <include file='PointF.xml' path='doc/member[@name="PointF.Y"]/*' />
    [NativeTypeName("Gdiplus::REAL")]
    public float Y;

    public PointF()
    {
        X = Y = 0.0f;
    }

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

    public unsafe BOOL Equals([NativeTypeName("const Gdiplus::PointF &")] PointF* point)
    {
        return ((X == point->X) && (Y == point->Y)) ? 1 : 0;
    }
}
