// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Enum which describes the drawing of the ends of a line.</summary>
    public enum D2D1_CAP_STYLE : uint
    {
        /// <summary>Flat line cap.</summary>
        D2D1_CAP_STYLE_FLAT = 0,

        /// <summary>Square line cap.</summary>
        D2D1_CAP_STYLE_SQUARE = 1,

        /// <summary>Round line cap.</summary>
        D2D1_CAP_STYLE_ROUND = 2,

        /// <summary>Triangle line cap.</summary>
        D2D1_CAP_STYLE_TRIANGLE = 3,

        D2D1_CAP_STYLE_FORCE_DWORD = 0xFFFFFFFF
    }
}
