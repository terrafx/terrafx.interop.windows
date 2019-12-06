// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D1_DRAWING_STATE_DESCRIPTION
    {
        public static readonly D2D1_DRAWING_STATE_DESCRIPTION DEFAULT = new D2D1_DRAWING_STATE_DESCRIPTION(D2D1_ANTIALIAS_MODE.D2D1_ANTIALIAS_MODE_PER_PRIMITIVE, D2D1_TEXT_ANTIALIAS_MODE.D2D1_TEXT_ANTIALIAS_MODE_DEFAULT, 0ul, 0ul, D2D_MATRIX_3X2_F.Identity);

        public D2D1_DRAWING_STATE_DESCRIPTION(D2D1_ANTIALIAS_MODE antialiasMode, D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode, ulong tag1, ulong tag2, D2D_MATRIX_3X2_F transform)
        {
            this.antialiasMode = antialiasMode;
            this.textAntialiasMode = textAntialiasMode;
            this.tag1 = tag1;
            this.tag2 = tag2;
            this.transform = transform;
        }
    }
}
