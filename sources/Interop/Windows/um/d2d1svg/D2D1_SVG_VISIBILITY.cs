// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Specifies a value for the SVG visibility property.</summary>
    public enum D2D1_SVG_VISIBILITY : uint
    {
        /// <summary>The element is visible.</summary>
        D2D1_SVG_VISIBILITY_VISIBLE = 0,

        /// <summary>The element is invisible.</summary>
        D2D1_SVG_VISIBILITY_HIDDEN = 1,

        D2D1_SVG_VISIBILITY_FORCE_DWORD = 0xFFFFFFFF
    }
}
