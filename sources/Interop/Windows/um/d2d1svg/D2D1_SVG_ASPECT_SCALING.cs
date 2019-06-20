// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The meetOrSlice portion of the SVG preserveAspectRatio attribute.</summary>
    public enum D2D1_SVG_ASPECT_SCALING : uint
    {
        /// <summary>Scale the viewBox up as much as possible such that the entire viewBox is visible within the viewport.</summary>
        D2D1_SVG_ASPECT_SCALING_MEET = 0,

        /// <summary>Scale the viewBox down as much as possible such that the entire viewport is covered by the viewBox.</summary>
        D2D1_SVG_ASPECT_SCALING_SLICE = 1,

        D2D1_SVG_ASPECT_SCALING_FORCE_DWORD = 0xFFFFFFFF
    }
}
