// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

public partial struct GpPoint
{
    public static GpPoint operator +(in GpPoint self, in GpPoint point)
    {
        return new GpPoint(
            self.X + point.X,
            self.Y + point.Y
        );
    }

    public static GpPoint operator -(in GpPoint self, in GpPoint point)
    {
        return new GpPoint(
            self.X - point.X,
            self.Y - point.Y
        );
    }
}
