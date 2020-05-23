// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public partial struct D2D1_ROUNDED_RECT
    {
        public D2D1_ROUNDED_RECT([NativeTypeName("const D2D1_RECT_F")] in D2D_RECT_F rect, [NativeTypeName("FLOAT")] float radiusX, [NativeTypeName("FLOAT")] float radiusY)
        {
            this = RoundedRect(rect, radiusX, radiusY);
        }
    }
}
