// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

public partial struct Point
{
    public static Point operator+(in Point self, in Point point)
    {
        return new Point(
            self.X + point.X,
            self.Y + point.Y
        );
    }

    public static Point operator -(in Point self, in Point point)
    {
        return new Point(
            self.X - point.X,
            self.Y - point.Y
        );
    }
}
