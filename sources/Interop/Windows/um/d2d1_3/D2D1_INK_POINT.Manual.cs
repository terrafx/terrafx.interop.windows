// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3helper.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public partial struct D2D1_INK_POINT
    {
        public D2D1_INK_POINT([NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F point, [NativeTypeName("FLOAT")] float radius)
        {
            this = InkPoint(point, radius);
        }
    }
}
