// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Specifies a value for the SVG overflow property.</summary>
    public enum D2D1_SVG_OVERFLOW : uint
    {
        /// <summary>The element is not clipped to its viewport.</summary>
        D2D1_SVG_OVERFLOW_VISIBLE = 0,

        /// <summary>The element is clipped to its viewport.</summary>
        D2D1_SVG_OVERFLOW_HIDDEN = 1,

        D2D1_SVG_OVERFLOW_FORCE_DWORD = 0xFFFFFFFF
    }
}
