// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

public partial struct GpPointF
{
    public static GpPointF operator +(in GpPointF self, in GpPointF point)
    {
        return new GpPointF(
            self.X + point.X,
            self.Y + point.Y
        );
    }

    public static GpPointF operator -(in GpPointF self, in GpPointF point)
    {
        return new GpPointF(
            self.X - point.X,
            self.Y - point.Y
        );
    }
}
