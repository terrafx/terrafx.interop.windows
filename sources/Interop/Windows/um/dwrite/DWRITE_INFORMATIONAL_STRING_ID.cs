// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The informational string enumeration identifies a string in a font.</summary>
    public enum DWRITE_INFORMATIONAL_STRING_ID
    {
        /// <summary>Unspecified name ID.</summary>
        DWRITE_INFORMATIONAL_STRING_NONE,

        /// <summary>Copyright notice provided by the font.</summary>
        DWRITE_INFORMATIONAL_STRING_COPYRIGHT_NOTICE,

        /// <summary>String containing a version number.</summary>
        DWRITE_INFORMATIONAL_STRING_VERSION_STRINGS,

        /// <summary>Trademark information provided by the font.</summary>
        DWRITE_INFORMATIONAL_STRING_TRADEMARK,

        /// <summary>Name of the font manufacturer.</summary>
        DWRITE_INFORMATIONAL_STRING_MANUFACTURER,

        /// <summary>Name of the font designer.</summary>
        DWRITE_INFORMATIONAL_STRING_DESIGNER,

        /// <summary>URL of font designer (with protocol, e.g., http://, ftp://).</summary>
        DWRITE_INFORMATIONAL_STRING_DESIGNER_URL,

        /// <summary>Description of the font. Can contain revision information, usage recommendations, history, features, etc.</summary>
        DWRITE_INFORMATIONAL_STRING_DESCRIPTION,

        /// <summary>URL of font vendor (with protocol, e.g., http://, ftp://). If a unique serial number is embedded in the URL, it can be used to register the font.</summary>
        DWRITE_INFORMATIONAL_STRING_FONT_VENDOR_URL,

        /// <summary>Description of how the font may be legally used, or different example scenarios for licensed use. This field should be written in plain language, not legalese.</summary>
        DWRITE_INFORMATIONAL_STRING_LICENSE_DESCRIPTION,

        /// <summary>URL where additional licensing information can be found.</summary>
        DWRITE_INFORMATIONAL_STRING_LICENSE_INFO_URL,

        /// <summary>GDI-compatible family name. Because GDI allows a maximum of four fonts per family, fonts in the same family may have different GDI-compatible family names (e.g., "Arial", "Arial Narrow", "Arial Black").</summary>
        DWRITE_INFORMATIONAL_STRING_WIN32_FAMILY_NAMES,

        /// <summary>GDI-compatible subfamily name.</summary>
        DWRITE_INFORMATIONAL_STRING_WIN32_SUBFAMILY_NAMES,

        /// <summary>Family name preferred by the designer. This enables font designers to group more than four fonts in a single family without losing compatibility with GDI. This name is typically only present if it differs from the GDI-compatible family name.</summary>
        DWRITE_INFORMATIONAL_STRING_PREFERRED_FAMILY_NAMES,

        /// <summary>Subfamily name preferred by the designer. This name is typically only present if it differs from the GDI-compatible subfamily name. </summary>
        DWRITE_INFORMATIONAL_STRING_PREFERRED_SUBFAMILY_NAMES,

        /// <summary>Sample text. This can be the font name or any other text that the designer thinks is the best example to display the font in.</summary>
        DWRITE_INFORMATIONAL_STRING_SAMPLE_TEXT,

        /// <summary>The full name of the font, e.g. "Arial Bold", from name id 4 in the name table.</summary>
        DWRITE_INFORMATIONAL_STRING_FULL_NAME,

        /// <summary>The postscript name of the font, e.g. "GillSans-Bold" from name id 6 in the name table.</summary>
        DWRITE_INFORMATIONAL_STRING_POSTSCRIPT_NAME,

        /// <summary>The postscript CID findfont name, from name id 20 in the name table.</summary>
        DWRITE_INFORMATIONAL_STRING_POSTSCRIPT_CID_NAME,

        /// <summary>Family name for the weight-width-slope model.</summary>
        DWRITE_INFORMATIONAL_STRING_WWS_FAMILY_NAME,

        /// <summary>Script/language tag to identify the scripts or languages that the font was primarily designed to support. See DWRITE_FONT_PROPERTY_ID_DESIGN_SCRIPT_LANGUAGE_TAG for a longer description.</summary>
        DWRITE_INFORMATIONAL_STRING_DESIGN_SCRIPT_LANGUAGE_TAG,

        /// <summary>Script/language tag to identify the scripts or languages that the font declares it is able to support.</summary>
        DWRITE_INFORMATIONAL_STRING_SUPPORTED_SCRIPT_LANGUAGE_TAG,
    }
}
