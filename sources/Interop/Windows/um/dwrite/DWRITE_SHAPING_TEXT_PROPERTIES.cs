// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>Shaping output properties per input character.</summary>
    [Unmanaged]
    public struct DWRITE_SHAPING_TEXT_PROPERTIES
    {
        #region Fields
        private ushort _bitField;
        #endregion

        #region Properties
        /// <summary>This character can be shaped independently from the others (usually set for the space character).</summary>
        [NativeTypeName("UINT16:1")]
        public ushort isShapedAlone
        {
            get
            {
                return (ushort)(_bitField & 0b0000_0000_0000_0001);
            }

            set
            {
                _bitField = (ushort)((_bitField & 0b1111_1111_1111_1110) | (value & 0b0000_0000_0000_0001));
            }
        }

        /// <summary>Reserved for use by shaping engine.</summary>
        [NativeTypeName("UINT16:15")]
        public ushort reserved
        {
            get
            {
                return (ushort)((_bitField & 0b1111_1111_1111_1110) >> 1);
            }

            set
            {
                _bitField = (ushort)((_bitField & 0b0000_0000_0000_0001) | ((value << 1) & 0b1111_1111_1111_1110));
            }
        }
        #endregion
    }
}
