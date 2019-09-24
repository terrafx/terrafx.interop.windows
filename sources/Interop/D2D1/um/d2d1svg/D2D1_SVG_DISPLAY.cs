// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Specifies a value for the SVG display property.</summary>
    public enum D2D1_SVG_DISPLAY : uint
    {
        /// <summary>The element uses the default display behavior.</summary>
        D2D1_SVG_DISPLAY_INLINE = 0,

        /// <summary>The element and all children are not rendered directly.</summary>
        D2D1_SVG_DISPLAY_NONE = 1,

        D2D1_SVG_DISPLAY_FORCE_DWORD = 0xFFFFFFFF
    }
}
