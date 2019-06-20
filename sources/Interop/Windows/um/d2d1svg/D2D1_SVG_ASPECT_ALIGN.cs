// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The alignment portion of the SVG preserveAspectRatio attribute.</summary>
    public enum D2D1_SVG_ASPECT_ALIGN : uint
    {
        /// <summary>The alignment is set to SVG's 'none' value.</summary>
        D2D1_SVG_ASPECT_ALIGN_NONE = 0,

        /// <summary>The alignment is set to SVG's 'xMinYMin' value.</summary>
        D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MIN = 1,

        /// <summary>The alignment is set to SVG's 'xMidYMin' value.</summary>
        D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MIN = 2,

        /// <summary>The alignment is set to SVG's 'xMaxYMin' value.</summary>
        D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MIN = 3,

        /// <summary>The alignment is set to SVG's 'xMinYMid' value.</summary>
        D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MID = 4,

        /// <summary>The alignment is set to SVG's 'xMidYMid' value.</summary>
        D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MID = 5,

        /// <summary>The alignment is set to SVG's 'xMaxYMid' value.</summary>
        D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MID = 6,

        /// <summary>The alignment is set to SVG's 'xMinYMax' value.</summary>
        D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MAX = 7,

        /// <summary>The alignment is set to SVG's 'xMidYMax' value.</summary>
        D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MAX = 8,

        /// <summary>The alignment is set to SVG's 'xMaxYMax' value.</summary>
        D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MAX = 9,

        D2D1_SVG_ASPECT_ALIGN_FORCE_DWORD = 0xFFFFFFFF
    }
}
