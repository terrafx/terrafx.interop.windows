// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Justification information per glyph.</summary>
    public partial struct DWRITE_JUSTIFICATION_OPPORTUNITY
    {
        /// <summary>Minimum amount of expansion to apply to the side of the glyph. This may vary from 0 to infinity, typically being zero except for kashida.</summary>
        [NativeTypeName("FLOAT")]
        public float expansionMinimum;

        /// <summary>Maximum amount of expansion to apply to the side of the glyph. This may vary from 0 to infinity, being zero for fixed-size characters and connected scripts, and non-zero for discrete scripts, and non-zero for cursive scripts at expansion points.</summary>
        [NativeTypeName("FLOAT")]
        public float expansionMaximum;

        /// <summary>Maximum amount of compression to apply to the side of the glyph. This may vary from 0 up to the glyph cluster size.</summary>
        [NativeTypeName("FLOAT")]
        public float compressionMaximum;

        private uint _bitField;

        /// <summary>Priority of this expansion point. Larger priorities are applied later, while priority zero does nothing.</summary>
        [NativeTypeName("UINT32:8")]
        public uint expansionPriority
        {
            get
            {
                return _bitField & 0b0000_0000_0000_0000_0000_0000_1111_1111;
            }

            set
            {
                _bitField = (_bitField & 0b1111_1111_1111_1111_1111_1111_0000_0000) | (value & 0b0000_0000_0000_0000_0000_0000_1111_1111);
            }
        }

        /// <summary>Priority of this compression point. Larger priorities are applied later, while priority zero does nothing.</summary>
        [NativeTypeName("UINT32:8")]
        public uint compressionPriority
        {
            get
            {
                return (_bitField & 0b0000_0000_0000_0000_1111_1111_0000_0000) >> 8;
            }

            set
            {
                _bitField = (_bitField & 0b1111_1111_1111_1111_0000_0000_1111_1111) | ((value << 8) & 0b0000_0000_0000_0000_1111_1111_0000_0000);
            }
        }

        /// <summary>Allow this expansion point to use up any remaining slack space even after all expansion priorities have been used up.</summary>
        [NativeTypeName("UINT32:1")]
        public uint allowResidualExpansion
        {
            get
            {
                return (_bitField & 0b0000_0000_0000_0001_0000_0000_0000_0000) >> 16;
            }

            set
            {
                _bitField = (_bitField & 0b1111_1111_1111_1110_1111_1111_1111_1111) | ((value << 16) & 0b0000_0000_0000_0001_0000_0000_0000_0000);
            }
        }

        /// <summary>Allow this compression point to use up any remaining space even after all compression priorities have been used up.</summary>
        [NativeTypeName("UINT32:1")]
        public uint allowResidualCompression
        {
            get
            {
                return (_bitField & 0b0000_0000_0000_0010_0000_0000_0000_0000) >> 17;
            }

            set
            {
                _bitField = (_bitField & 0b1111_1111_1111_1101_1111_1111_1111_1111) | ((value << 17) & 0b0000_0000_0000_0010_0000_0000_0000_0000);
            }
        }

        /// <summary>Apply expansion/compression to the leading edge of the glyph. This will be false for connected scripts, fixed-size characters, and diacritics. It is generally false within a multi-glyph cluster, unless the script allows expansion of glyphs within a cluster, like Thai.</summary>
        [NativeTypeName("UINT32:1")]
        public uint applyToLeadingEdge
        {
            get
            {
                return (_bitField & 0b0000_0000_0000_0100_0000_0000_0000_0000) >> 18;
            }

            set
            {
                _bitField = (_bitField & 0b1111_1111_1111_1011_1111_1111_1111_1111) | ((value << 18) & 0b0000_0000_0000_0100_0000_0000_0000_0000);
            }
        }

        /// <summary>Apply expansion/compression to the trailing edge of the glyph. This will be false for connected scripts, fixed-size characters, and diacritics. It is generally false within a multi-glyph cluster, unless the script allows expansion of glyphs within a cluster, like Thai.</summary>
        [NativeTypeName("UINT32:1")]
        public uint applyToTrailingEdge
        {
            get
            {
                return (_bitField & 0b0000_0000_0000_1000_0000_0000_0000_0000) >> 19;
            }

            set
            {
                _bitField = (_bitField & 0b1111_1111_1111_0111_1111_1111_1111_1111) | ((value << 19) & 0b0000_0000_0000_1000_0000_0000_0000_0000);
            }
        }

        [NativeTypeName("UINT32:12")]
        public uint reserved
        {
            get
            {
                return (_bitField & 0b1111_1111_1111_0000_0000_0000_0000_0000) >> 20;
            }

            set
            {
                _bitField = (_bitField & 0b0000_0000_0000_1111_1111_1111_1111_1111) | ((value << 20) & 0b1111_1111_1111_0000_0000_0000_0000_0000);
            }
        }
    }
}
