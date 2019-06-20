// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>How the glyph is oriented to the x-axis. This is an output from the text analyzer, dependent on the desired orientation, bidi level, and character properties.</summary>
    public enum DWRITE_GLYPH_ORIENTATION_ANGLE
    {
        /// <summary>Glyph orientation is upright.</summary>
        DWRITE_GLYPH_ORIENTATION_ANGLE_0_DEGREES,

        /// <summary>Glyph orientation is rotated 90 clockwise.</summary>
        DWRITE_GLYPH_ORIENTATION_ANGLE_90_DEGREES,

        /// <summary>Glyph orientation is upside-down.</summary>
        DWRITE_GLYPH_ORIENTATION_ANGLE_180_DEGREES,

        /// <summary>Glyph orientation is rotated 270 clockwise.</summary>
        DWRITE_GLYPH_ORIENTATION_ANGLE_270_DEGREES
    }
}
