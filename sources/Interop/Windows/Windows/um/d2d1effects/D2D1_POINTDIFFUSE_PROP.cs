// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum D2D1_POINTDIFFUSE_PROP : uint
    {
        D2D1_POINTDIFFUSE_PROP_LIGHT_POSITION = 0,
        D2D1_POINTDIFFUSE_PROP_DIFFUSE_CONSTANT = 1,
        D2D1_POINTDIFFUSE_PROP_SURFACE_SCALE = 2,
        D2D1_POINTDIFFUSE_PROP_COLOR = 3,
        D2D1_POINTDIFFUSE_PROP_KERNEL_UNIT_LENGTH = 4,
        D2D1_POINTDIFFUSE_PROP_SCALE_MODE = 5,
        D2D1_POINTDIFFUSE_PROP_FORCE_DWORD = 0xffffffff,
    }
}
