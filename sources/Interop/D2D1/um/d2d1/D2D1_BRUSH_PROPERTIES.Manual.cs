// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D2D1_BRUSH_PROPERTIES
    {
        public static readonly D2D1_BRUSH_PROPERTIES DEFAULT = new D2D1_BRUSH_PROPERTIES(1.0f, D2D_MATRIX_3X2_F.Identity);

        public D2D1_BRUSH_PROPERTIES(float opacity, in D2D_MATRIX_3X2_F transform)
        {
            this.opacity = opacity;
            this.transform = transform;
        }
    }
}
