// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Defines how the world transform, dots per inch (dpi), and stroke width affect the shape of the pen used to stroke a primitive.</summary>
    public enum D2D1_STROKE_TRANSFORM_TYPE : uint
    {
        /// <summary>The stroke respects the world transform, the DPI, and the stroke width.</summary>
        D2D1_STROKE_TRANSFORM_TYPE_NORMAL = 0,

        /// <summary>The stroke does not respect the world transform, but it does respect the DPI and the stroke width.</summary>
        D2D1_STROKE_TRANSFORM_TYPE_FIXED = 1,

        /// <summary>The stroke is forced to one pixel wide.</summary>
        D2D1_STROKE_TRANSFORM_TYPE_HAIRLINE = 2,

        D2D1_STROKE_TRANSFORM_TYPE_FORCE_DWORD = 0xFFFFFFFF
    }
}
