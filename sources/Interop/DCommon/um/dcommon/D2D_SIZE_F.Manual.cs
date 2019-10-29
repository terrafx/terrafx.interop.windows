// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D_SIZE_F
    {
        public static readonly D2D_SIZE_F DEFAULT = new D2D_SIZE_F(0.0f, 0.0f);

        public D2D_SIZE_F(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
