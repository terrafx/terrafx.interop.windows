// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Optional adjustment to a glyph's position. A glyph offset changes the position of a glyph without affecting the pen position. Offsets are in logical, pre-transform units.</summary>
    public struct DWRITE_GLYPH_OFFSET
    {
        /// <summary>Offset in the advance direction of the run. A positive advance offset moves the glyph to the right (in pre-transform coordinates) if the run is left-to-right or to the left if the run is right-to-left.</summary>
        [NativeTypeName("FLOAT")]
        public float advanceOffset;

        /// <summary>Offset in the ascent direction, i.e., the direction ascenders point. A positive ascender offset moves the glyph up (in pre-transform coordinates).</summary>
        [NativeTypeName("FLOAT")]
        public float ascenderOffset;
    }
}
