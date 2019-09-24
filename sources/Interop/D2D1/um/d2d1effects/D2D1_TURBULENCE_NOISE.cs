// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_TURBULENCE_NOISE : uint
    {
        D2D1_TURBULENCE_NOISE_FRACTAL_SUM = 0,

        D2D1_TURBULENCE_NOISE_TURBULENCE = 1,

        D2D1_TURBULENCE_NOISE_FORCE_DWORD = 0xFFFFFFFF
    }
}
