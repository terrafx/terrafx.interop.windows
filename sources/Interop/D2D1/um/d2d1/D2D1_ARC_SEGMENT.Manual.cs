// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D1_ARC_SEGMENT
    {
        public D2D1_ARC_SEGMENT(in D2D_POINT_2F point, in D2D_SIZE_F size, float rotationAngle, D2D1_SWEEP_DIRECTION sweepDirection, D2D1_ARC_SIZE arcSize)
        {
            this.point = point;
            this.size = size;
            this.rotationAngle = rotationAngle;
            this.sweepDirection = sweepDirection;
            this.arcSize = arcSize;
        }
    }
}
