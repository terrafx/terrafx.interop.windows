// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1;

namespace TerraFX.Interop
{
    public partial struct D2D1_BRUSH_PROPERTIES
    {
        public static readonly D2D1_BRUSH_PROPERTIES DEFAULT = new D2D1_BRUSH_PROPERTIES(1.0f, D2D_MATRIX_3X2_F.Identity);

        public D2D1_BRUSH_PROPERTIES([NativeTypeName("FLOAT")] float opacity = 1.0f) : this(opacity, IdentityMatrix)
        {
        }

        public D2D1_BRUSH_PROPERTIES([NativeTypeName("FLOAT"), Optional, DefaultParameterValue(1.0f)] float opacity, [NativeTypeName("const D2D1_MATRIX_3X2_F &")] in D2D_MATRIX_3X2_F transform)
        {
            this = BrushProperties(opacity, transform);
        }
    }
}
