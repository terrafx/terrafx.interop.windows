// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.Gdiplus;

public unsafe partial struct GpRect
{
    public readonly GpRect Clone() => this;

    public BOOL Intersect(GpRect* rect)
    {
        GpRect source = this;
        GpRect intersection = default;
        BOOL result = Intersect(&intersection, &source, rect);
        this = intersection;
        return result;
    }
}
