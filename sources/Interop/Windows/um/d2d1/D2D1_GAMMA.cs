// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>This determines what gamma is used for interpolation/blending.</summary>
    public enum D2D1_GAMMA : uint
    {
        /// <summary>Colors are manipulated in 2.2 gamma color space.</summary>
        D2D1_GAMMA_2_2 = 0,

        /// <summary>Colors are manipulated in 1.0 gamma color space.</summary>
        D2D1_GAMMA_1_0 = 1,

        D2D1_GAMMA_FORCE_DWORD = 0xFFFFFFFF
    }
}
