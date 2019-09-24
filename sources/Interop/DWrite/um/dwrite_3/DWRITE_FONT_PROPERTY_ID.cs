// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The font property enumeration identifies a string in a font.</summary>
    public enum DWRITE_FONT_PROPERTY_ID
    {
        /// <summary>Unspecified font property identifier.</summary>
        DWRITE_FONT_PROPERTY_ID_NONE,

        /// <summary>Family name for the weight-width-slope model.</summary>
        DWRITE_FONT_PROPERTY_ID_FAMILY_NAME,

        /// <summary>Family name preferred by the designer. This enables font designers to group more than four fonts in a single family without losing compatibility with GDI. This name is typically only present if it differs from the GDI-compatible family name.</summary>
        DWRITE_FONT_PROPERTY_ID_PREFERRED_FAMILY_NAME,

        /// <summary>Face name of the (e.g., Regular or Bold).</summary>
        DWRITE_FONT_PROPERTY_ID_FACE_NAME,

        /// <summary>The full name of the font, e.g. "Arial Bold", from name id 4 in the name table.</summary>
        DWRITE_FONT_PROPERTY_ID_FULL_NAME,

        /// <summary>GDI-compatible family name. Because GDI allows a maximum of four fonts per family, fonts in the same family may have different GDI-compatible family names (e.g., "Arial", "Arial Narrow", "Arial Black").</summary>
        DWRITE_FONT_PROPERTY_ID_WIN32_FAMILY_NAME,

        /// <summary>The postscript name of the font, e.g. "GillSans-Bold" from name id 6 in the name table.</summary>
        DWRITE_FONT_PROPERTY_ID_POSTSCRIPT_NAME,

        /// <summary>Script/language tag to identify the scripts or languages that the font was primarily designed to support.</summary>
        /// <remarks> The design script/language tag is meant to be understood from the perspective of users. For example, a font is considered designed for English if it is considered useful for English users. Note that this is different from what a font might be capable of supporting. For example, the Meiryo font was primarily designed for Japanese users. While it is capable of displaying English well, it was not meant to be offered for the benefit of non-Japanese-speaking English users. As another example, a font designed for Chinese may be capable of displaying Japanese text, but would likely look incorrect to Japanese users. The valid values for this property are "ScriptLangTag" values. These are adapted from the IETF BCP 47 specification, "Tags for Identifying Languages" (see http://tools.ietf.org/html/bcp47). In a BCP 47 language tag, a language subtag element is mandatory and other subtags are optional. In a ScriptLangTag, a script subtag is mandatory and other subtags are option. The following augmented BNF syntax, adapted from BCP 47, is used: ScriptLangTag = [language "-"] script ["-" region] *("-" variant) *("-" extension) ["-" privateuse] The expansion of the elements and the intended semantics associated with each are as defined in BCP 47. Script subtags are taken from ISO 15924. At present, no extensions are defined, and any extension should be ignored. Private use subtags are defined by private agreement between the source and recipient and may be ignored. Subtags must be valid for use in BCP 47 and contained in the Language Subtag Registry maintained by IANA. (See http://www.iana.org/assignments/language-subtag-registry/language-subtag-registry and section 3 of BCP 47 for details. Any ScriptLangTag value not conforming to these specifications is ignored. Examples: "Latn" denotes Latin script (and any language or writing system using Latin) "Cyrl" denotes Cyrillic script "sr-Cyrl" denotes Cyrillic script as used for writing the Serbian language; a font that has this property value may not be suitable for displaying text in Russian or other languages written using Cyrillic script "Jpan" denotes Japanese writing (Han + Hiragana + Katakana) When passing this property to GetPropertyValues, use the overload which does not take a language parameter, since this property has no specific language.</remarks>
        DWRITE_FONT_PROPERTY_ID_DESIGN_SCRIPT_LANGUAGE_TAG,

        /// <summary>Script/language tag to identify the scripts or languages that the font declares it is able to support.</summary>
        DWRITE_FONT_PROPERTY_ID_SUPPORTED_SCRIPT_LANGUAGE_TAG,

        /// <summary>Semantic tag to describe the font (e.g. Fancy, Decorative, Handmade, Sans-serif, Swiss, Pixel, Futuristic).</summary>
        DWRITE_FONT_PROPERTY_ID_SEMANTIC_TAG,

        /// <summary>Weight of the font represented as a decimal string in the range 1-999.</summary>
        DWRITE_FONT_PROPERTY_ID_WEIGHT,

        /// <summary>Stretch of the font represented as a decimal string in the range 1-9.</summary>
        DWRITE_FONT_PROPERTY_ID_STRETCH,

        /// <summary>Stretch of the font represented as a decimal string in the range 0-2.</summary>
        DWRITE_FONT_PROPERTY_ID_STYLE,

        /// <summary>Total number of properties.</summary>
        /// <remarks>DWRITE_FONT_PROPERTY_ID_TOTAL cannot be used as a property ID.</remarks>
        DWRITE_FONT_PROPERTY_ID_TOTAL
    }
}
