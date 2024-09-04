// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

using System.Drawing;

/// <include file='RECT.xml' path='doc/member[@name="RECT"]/*' />
public partial struct RECT
{
    /// <include file='RECT.xml' path='doc/member[@name="RECT.left"]/*' />
    [NativeTypeName("LONG")]
    public int left;

    /// <include file='RECT.xml' path='doc/member[@name="RECT.top"]/*' />
    [NativeTypeName("LONG")]
    public int top;

    /// <include file='RECT.xml' path='doc/member[@name="RECT.right"]/*' />
    [NativeTypeName("LONG")]
    public int right;

    /// <include file='RECT.xml' path='doc/member[@name="RECT.bottom"]/*' />
    [NativeTypeName("LONG")]
    public int bottom;

    // type 'Rectangle' is from System.Drawing.Primitives which is from the base shared framework.
    // as such these operators *should* be safe to include here.
    public static explicit operator Rectangle(RECT rectangle)
        => Rectangle.FromLTRB(rectangle.left, rectangle.top, rectangle.right, rectangle.bottom);

    public static explicit operator RECT(Rectangle rectangle)
        => new RECT()
        {
            // Obtained from inspecting 'Rectangle.FromLTRB(int, int, int, int)'.
            left = rectangle.X,
            top = rectangle.Y,
            right = rectangle.Width + rectangle.X,
            bottom = rectangle.Height + rectangle.Y,
        };
}
