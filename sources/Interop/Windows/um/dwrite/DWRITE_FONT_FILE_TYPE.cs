// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The type of a font represented by a single font file. Font formats that consist of multiple files, e.g. Type 1 .PFM and .PFB, have separate enum values for each of the file type.</summary>
    public enum DWRITE_FONT_FILE_TYPE
    {
        /// <summary>Font type is not recognized by the DirectWrite font system.</summary>
        DWRITE_FONT_FILE_TYPE_UNKNOWN,

        /// <summary>OpenType font with CFF outlines.</summary>
        DWRITE_FONT_FILE_TYPE_CFF,

        /// <summary>OpenType font with TrueType outlines.</summary>
        DWRITE_FONT_FILE_TYPE_TRUETYPE,

        /// <summary>OpenType font that contains a TrueType collection.</summary>
        DWRITE_FONT_FILE_TYPE_OPENTYPE_COLLECTION,

        /// <summary>Type 1 PFM font.</summary>
        DWRITE_FONT_FILE_TYPE_TYPE1_PFM,

        /// <summary>Type 1 PFB font.</summary>
        DWRITE_FONT_FILE_TYPE_TYPE1_PFB,

        /// <summary>Vector .FON font.</summary>
        DWRITE_FONT_FILE_TYPE_VECTOR,

        /// <summary>Bitmap .FON font.</summary>
        DWRITE_FONT_FILE_TYPE_BITMAP,

        // The following name is obsolete, but kept as an alias to avoid breaking existing code.
        DWRITE_FONT_FILE_TYPE_TRUETYPE_COLLECTION = DWRITE_FONT_FILE_TYPE_OPENTYPE_COLLECTION, }
}
