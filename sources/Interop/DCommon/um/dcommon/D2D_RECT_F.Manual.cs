// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D_RECT_F
    {
        public static readonly D2D_RECT_F DEFAULT = new D2D_RECT_F(0, 0, 0, 0);
        public static readonly D2D_RECT_F Infinite = new D2D_RECT_F(-float.MaxValue, -float.MaxValue, float.MaxValue, float.MaxValue);

        public D2D_RECT_F(float left, float top, float right, float bottom)
        {
            this.left = left;
            this.top = top;
            this.right = right;
            this.bottom = bottom;
        }
    }
}
