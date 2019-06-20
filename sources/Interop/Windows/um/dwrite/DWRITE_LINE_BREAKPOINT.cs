// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>Line breakpoint characteristics of a character.</summary>
    [Unmanaged]
    public struct DWRITE_LINE_BREAKPOINT
    {
        #region Fields
        private byte _bitField;
        #endregion

        #region Properties
        /// <summary>Breaking condition before the character.</summary>
        [NativeTypeName("UINT8:2")]
        public byte breakConditionBefore
        {
            get
            {
                return (byte)(_bitField & 0b0000_0011);
            }

            set
            {
                _bitField = (byte)((_bitField & 0b1111_1100) | (value & 0b0000_0011));
            }
        }

        /// <summary>Breaking condition after the character.</summary>
        [NativeTypeName("UINT8:2")]
        public byte breakConditionAfter
        {
            get
            {
                return (byte)((_bitField & 0b0000_1100) >> 2);
            }

            set
            {
                _bitField = (byte)((_bitField & 0b1111_0011) | ((value << 2) & 0b0000_1100));
            }
        }

        /// <summary>The character is some form of whitespace, which may be meaningful for justification.</summary>
        [NativeTypeName("UINT8:1")]
        public byte isWhitespace
        {
            get
            {
                return (byte)((_bitField & 0b0001_0000) >> 4);
            }

            set
            {
                _bitField = (byte)((_bitField & 0b1110_1111) | ((value << 4) & 0b0001_0000));
            }
        }

        /// <summary>The character is a soft hyphen, often used to indicate hyphenation points inside words.</summary>
        [NativeTypeName("UINT8:1")]
        public byte isSoftHyphen
        {
            get
            {
                return (byte)((_bitField & 0b0010_0000) >> 5);
            }

            set
            {
                _bitField = (byte)((_bitField & 0b1101_1111) | ((value << 5) & 0b0010_0000));
            }
        }

        [NativeTypeName("UINT8:2")]
        public byte padding
        {
            get
            {
                return (byte)((_bitField & 0b1100_0000) >> 6);
            }

            set
            {
                _bitField = (byte)((_bitField & 0b0011_1111) | ((value << 6) & 0b1100_0000));
            }
        }
        #endregion
    }
}
