// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D2D1_INTERPOLATION_MODE_DEFINITION;

namespace TerraFX.Interop
{
    public enum D2D1_BITMAP_INTERPOLATION_MODE : uint
    {
        D2D1_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR = D2D1_INTERPOLATION_MODE_DEFINITION_NEAREST_NEIGHBOR,
        D2D1_BITMAP_INTERPOLATION_MODE_LINEAR = D2D1_INTERPOLATION_MODE_DEFINITION_LINEAR,
        D2D1_BITMAP_INTERPOLATION_MODE_FORCE_DWORD = 0xffffffff,
    }
}
