// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D2D1;

namespace TerraFX.Interop
{
    /// <summary>Specifies the algorithm that is used when images are scaled or rotated.</summary>
    /// <remarks>Note Starting in Windows 8, more interpolations modes are available. See D2D1_INTERPOLATION_MODE for more info.</remarks>
    public enum D2D1_BITMAP_INTERPOLATION_MODE : uint
    {
        /// <summary>Nearest Neighbor filtering. Also known as nearest pixel or nearest point
        /// sampling.</summary>
        D2D1_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR = D2D1_INTERPOLATION_MODE_DEFINITION_NEAREST_NEIGHBOR,

        /// <summary>Linear filtering.</summary>
        D2D1_BITMAP_INTERPOLATION_MODE_LINEAR = D2D1_INTERPOLATION_MODE_DEFINITION_LINEAR,

        D2D1_BITMAP_INTERPOLATION_MODE_FORCE_DWORD = 0xFFFFFFFF
    }
}
