// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D2D1_GAMMA;

namespace TerraFX.Interop
{
    /// <summary>This determines what gamma is used for interpolation/blending.</summary>
    public enum D2D1_GAMMA1 : uint
    {
        /// <summary>Colors are manipulated in 2.2 gamma color space.</summary>
        D2D1_GAMMA1_G22 = D2D1_GAMMA_2_2,

        /// <summary>Colors are manipulated in 1.0 gamma color space.</summary>
        D2D1_GAMMA1_G10 = D2D1_GAMMA_1_0,

        /// <summary>Colors are manipulated in ST.2084 PQ gamma color space.</summary>
        D2D1_GAMMA1_G2084 = 2,

        D2D1_GAMMA1_FORCE_DWORD = 0xFFFFFFFF
    }
}
