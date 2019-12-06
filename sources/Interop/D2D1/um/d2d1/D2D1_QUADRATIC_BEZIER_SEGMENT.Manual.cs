// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D1_QUADRATIC_BEZIER_SEGMENT
    {
        public D2D1_QUADRATIC_BEZIER_SEGMENT(in D2D_POINT_2F point1, in D2D_POINT_2F point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
    }
}
