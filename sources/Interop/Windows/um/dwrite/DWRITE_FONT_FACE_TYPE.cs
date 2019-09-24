// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The file format of a complete font face. Font formats that consist of multiple files, e.g. Type 1 .PFM and .PFB, have a single enum entry.</summary>
    public enum DWRITE_FONT_FACE_TYPE
    {
        /// <summary>OpenType font face with CFF outlines.</summary>
        DWRITE_FONT_FACE_TYPE_CFF,

        /// <summary>OpenType font face with TrueType outlines.</summary>
        DWRITE_FONT_FACE_TYPE_TRUETYPE,

        /// <summary>OpenType font face that is a part of a TrueType or CFF collection.</summary>
        DWRITE_FONT_FACE_TYPE_OPENTYPE_COLLECTION,

        /// <summary>A Type 1 font face.</summary>
        DWRITE_FONT_FACE_TYPE_TYPE1,

        /// <summary>A vector .FON format font face.</summary>
        DWRITE_FONT_FACE_TYPE_VECTOR,

        /// <summary>A bitmap .FON format font face.</summary>
        DWRITE_FONT_FACE_TYPE_BITMAP,

        /// <summary>Font face type is not recognized by the DirectWrite font system.</summary>
        DWRITE_FONT_FACE_TYPE_UNKNOWN,

        /// <summary>The font data includes only the CFF table from an OpenType CFF font. This font face type can be used only for embedded fonts (i.e., custom font file loaders) and the resulting font face object supports only the minimum functionality necessary to render glyphs.</summary>
        DWRITE_FONT_FACE_TYPE_RAW_CFF,

        // The following name is obsolete, but kept as an alias to avoid breaking existing code.
        DWRITE_FONT_FACE_TYPE_TRUETYPE_COLLECTION = DWRITE_FONT_FACE_TYPE_OPENTYPE_COLLECTION, }
}
