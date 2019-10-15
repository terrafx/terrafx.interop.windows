// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DWRITE_LINE_BREAKPOINT
    {
        internal byte _bitfield;

        [NativeTypeName("UINT8 : 2")]
        public byte breakConditionBefore
        {
            get
            {
                return (byte)((uint)_bitfield & 0x3);
            }

            set
            {
                _bitfield = (byte)((_bitfield & ~0x3u) | ((uint)value & 0x3));
            }
        }

        [NativeTypeName("UINT8 : 2")]
        public byte breakConditionAfter
        {
            get
            {
                return (byte)(((uint)_bitfield >> 2) & 0x3);
            }

            set
            {
                _bitfield = (byte)((_bitfield & ~(0x3u << 2)) | (((uint)value & 0x3) << 2));
            }
        }

        [NativeTypeName("UINT8 : 1")]
        public byte isWhitespace
        {
            get
            {
                return (byte)(((uint)_bitfield >> 4) & 0x1);
            }

            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 4)) | (((uint)value & 0x1) << 4));
            }
        }

        [NativeTypeName("UINT8 : 1")]
        public byte isSoftHyphen
        {
            get
            {
                return (byte)(((uint)_bitfield >> 5) & 0x1);
            }

            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 5)) | (((uint)value & 0x1) << 5));
            }
        }

        [NativeTypeName("UINT8 : 2")]
        public byte padding
        {
            get
            {
                return (byte)(((uint)_bitfield >> 6) & 0x3);
            }

            set
            {
                _bitfield = (byte)((_bitfield & ~(0x3u << 6)) | (((uint)value & 0x3) << 6));
            }
        }
    }
}
