// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Script-specific properties for caret navigation and justification.</summary>
    public struct DWRITE_SCRIPT_PROPERTIES
    {
        #region Fields
        /// <summary>The standardized four character code for the given script. Note these only include the general Unicode scripts, not any additional ISO 15924 scripts for bibliographic distinction (for example, Fraktur Latin vs Gaelic Latin). http://unicode.org/iso15924/iso15924-codes.html</summary>
        [NativeTypeName("UINT32")]
        public uint isoScriptCode;

        /// <summary>The standardized numeric code, ranging 0-999. http://unicode.org/iso15924/iso15924-codes.html</summary>
        [NativeTypeName("UINT32")]
        public uint isoScriptNumber;

        /// <summary>Number of characters to estimate look-ahead for complex scripts. Latin and all Kana are generally 1. Indic scripts are up to 15, and most others are 8. Note that combining marks and variation selectors can produce clusters longer than these look-aheads, so this estimate is considered typical language use. Diacritics must be tested explicitly separately.</summary>
        [NativeTypeName("UINT32")]
        public uint clusterLookahead;

        /// <summary>Appropriate character to elongate the given script for justification.
        /// Examples: Arabic    - U+0640 Tatweel Ogham     - U+1680 Ogham Space Mark</summary>
        [NativeTypeName("UINT32")]
        public uint justificationCharacter;

        private uint _bitField;
        #endregion

        #region Properties
        /// <summary>Restrict the caret to whole clusters, like Thai and Devanagari. Scripts such as Arabic by default allow navigation between clusters. Others like Thai always navigate across whole clusters.</summary>
        [NativeTypeName("UINT32:1")]
        public uint restrictCaretToClusters
        {
            get
            {
                return _bitField & 0b0000_0000_0000_0000_0000_0000_0000_0001;
            }

            set
            {
                _bitField = (_bitField & 0b1111_1111_1111_1111_1111_1111_1111_1110) | (value & 0b0000_0000_0000_0000_0000_0000_0000_0001);
            }
        }

        /// <summary>The language uses dividers between words, such as spaces between Latin or the Ethiopic wordspace.
        /// Examples: Latin, Greek, Devanagari, Ethiopic Excludes: Chinese, Korean, Thai.</summary>
        [NativeTypeName("UINT32:1")]
        public uint usesWordDividers
        {
            get
            {
                return (_bitField & 0b0000_0000_0000_0000_0000_0000_0000_0010) >> 1;
            }

            set
            {
                _bitField = (_bitField & 0b1111_1111_1111_1111_1111_1111_1111_1101) | ((value << 1) & 0b0000_0000_0000_0000_0000_0000_0000_0010);
            }
        }

        /// <summary>The characters are discrete units from each other. This includes both block scripts and clustered scripts.
        /// Examples: Latin, Greek, Cyrillic, Hebrew, Chinese, Thai</summary>
        [NativeTypeName("UINT32:1")]
        public uint isDiscreteWriting
        {
            get
            {
                return (_bitField & 0b0000_0000_0000_0000_0000_0000_0000_0100) >> 2;
            }

            set
            {
                _bitField = (_bitField & 0b1111_1111_1111_1111_1111_1111_1111_1011) | ((value << 2) & 0b0000_0000_0000_0000_0000_0000_0000_0100);
            }
        }

        /// <summary>The language is a block script, expanding between characters.
        /// Examples: Chinese, Japanese, Korean, Bopomofo.</summary>
        [NativeTypeName("UINT32:1")]
        public uint isBlockWriting
        {
            get
            {
                return (_bitField & 0b0000_0000_0000_0000_0000_0000_0000_1000) >> 3;
            }

            set
            {
                _bitField = (_bitField & 0b1111_1111_1111_1111_1111_1111_1111_0111) | ((value << 3) & 0b0000_0000_0000_0000_0000_0000_0000_1000);
            }
        }

        /// <summary>The language is justified within glyph clusters, not just between glyph clusters. One such as the character sequence is Thai Lu and Sara Am (U+E026, U+E033) which form a single cluster but still expand between them.
        /// Examples: Thai, Lao, Khmer</summary>
        [NativeTypeName("UINT32:1")]
        public uint isDistributedWithinCluster
        {
            get
            {
                return (_bitField & 0b0000_0000_0000_0000_0000_0000_0001_0000) >> 4;
            }

            set
            {
                _bitField = (_bitField & 0b1111_1111_1111_1111_1111_1111_1110_1111) | ((value << 4) & 0b0000_0000_0000_0000_0000_0000_0001_0000);
            }
        }

        /// <summary>The script's clusters are connected to each other (such as the baseline-linked Devanagari), and no separation should be added between characters. Note that cursively linked scripts like Arabic are also connected (but not all connected scripts are cursive).
        /// Examples: Devanagari, Arabic, Syriac, Bengali, Gurmukhi, Ogham Excludes: Latin, Chinese, Thaana</summary>
        [NativeTypeName("UINT32:1")]
        public uint isConnectedWriting
        {
            get
            {
                return (_bitField & 0b0000_0000_0000_0000_0000_0000_0010_0000) >> 5;
            }

            set
            {
                _bitField = (_bitField & 0b1111_1111_1111_1111_1111_1111_1101_1111) | ((value << 5) & 0b0000_0000_0000_0000_0000_0000_0010_0000);
            }
        }

        /// <summary>The script is naturally cursive (Arabic/Syriac), meaning it uses other justification methods like kashida extension rather than intercharacter spacing. Note that although other scripts like Latin and Japanese may actually support handwritten cursive forms, they are not considered cursive scripts.
        /// Examples: Arabic, Syriac, Mongolian Excludes: Thaana, Devanagari, Latin, Chinese</summary>
        [NativeTypeName("UINT32:1")]
        public uint isCursiveWriting
        {
            get
            {
                return (_bitField & 0b0000_0000_0000_0000_0000_0000_0100_0000) >> 6;
            }

            set
            {
                _bitField = (_bitField & 0b1111_1111_1111_1111_1111_1111_1011_1111) | ((value << 6) & 0b0000_0000_0000_0000_0000_0000_0100_0000);
            }
        }

        [NativeTypeName("UINT32:25")]
        public uint reserved
        {
            get
            {
                return (_bitField & 0b1111_1111_1111_1111_1111_1111_1000_0000) >> 7;
            }

            set
            {
                _bitField = (_bitField & 0b0000_0000_0000_0000_0000_0000_0111_1111) | ((value << 7) & 0b1111_1111_1111_1111_1111_1111_1000_0000);
            }
        }
        #endregion
    }
}
