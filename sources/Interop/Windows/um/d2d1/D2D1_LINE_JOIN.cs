// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Enum which describes the drawing of the corners on the line.</summary>
    public enum D2D1_LINE_JOIN : uint
    {
        /// <summary>Miter join.</summary>
        D2D1_LINE_JOIN_MITER = 0,

        /// <summary>Bevel join.</summary>
        D2D1_LINE_JOIN_BEVEL = 1,

        /// <summary>Round join.</summary>
        D2D1_LINE_JOIN_ROUND = 2,

        /// <summary>Miter/Bevel join.</summary>
        D2D1_LINE_JOIN_MITER_OR_BEVEL = 3,

        D2D1_LINE_JOIN_FORCE_DWORD = 0xFFFFFFFF
    }
}
