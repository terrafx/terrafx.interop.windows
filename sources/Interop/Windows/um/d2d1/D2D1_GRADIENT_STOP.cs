// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D1_GRADIENT_STOP
    {
        [NativeTypeName("FLOAT")]
        public float position;

        [NativeTypeName("D2D1_COLOR_F")]
        public DXGI_RGBA color;
    }
}
