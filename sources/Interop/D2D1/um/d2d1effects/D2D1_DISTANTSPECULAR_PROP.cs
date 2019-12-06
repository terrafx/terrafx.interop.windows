// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum D2D1_DISTANTSPECULAR_PROP : uint
    {
        D2D1_DISTANTSPECULAR_PROP_AZIMUTH = 0,
        D2D1_DISTANTSPECULAR_PROP_ELEVATION = 1,
        D2D1_DISTANTSPECULAR_PROP_SPECULAR_EXPONENT = 2,
        D2D1_DISTANTSPECULAR_PROP_SPECULAR_CONSTANT = 3,
        D2D1_DISTANTSPECULAR_PROP_SURFACE_SCALE = 4,
        D2D1_DISTANTSPECULAR_PROP_COLOR = 5,
        D2D1_DISTANTSPECULAR_PROP_KERNEL_UNIT_LENGTH = 6,
        D2D1_DISTANTSPECULAR_PROP_SCALE_MODE = 7,
        D2D1_DISTANTSPECULAR_PROP_FORCE_DWORD = 0xffffffff,
    }
}
