// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D_VECTOR_3F
    {
        public static readonly D2D_VECTOR_3F DEFAULT = new D2D_VECTOR_3F(0.0f, 0.0f, 0.0f);

        public D2D_VECTOR_3F(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
