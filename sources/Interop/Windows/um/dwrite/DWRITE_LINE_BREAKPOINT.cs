// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
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
                return (byte)(_bitfield & 0x3u);
            }

            set
            {
                _bitfield = (byte)((_bitfield & ~0x3u) | (value & 0x3u));
            }
        }

        [NativeTypeName("UINT8 : 2")]
        public byte breakConditionAfter
        {
            get
            {
                return (byte)((_bitfield >> 2) & 0x3u);
            }

            set
            {
                _bitfield = (byte)((_bitfield & ~(0x3u << 2)) | ((value & 0x3u) << 2));
            }
        }

        [NativeTypeName("UINT8 : 1")]
        public byte isWhitespace
        {
            get
            {
                return (byte)((_bitfield >> 4) & 0x1u);
            }

            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4));
            }
        }

        [NativeTypeName("UINT8 : 1")]
        public byte isSoftHyphen
        {
            get
            {
                return (byte)((_bitfield >> 5) & 0x1u);
            }

            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5));
            }
        }

        [NativeTypeName("UINT8 : 2")]
        public byte padding
        {
            get
            {
                return (byte)((_bitfield >> 6) & 0x3u);
            }

            set
            {
                _bitfield = (byte)((_bitfield & ~(0x3u << 6)) | ((value & 0x3u) << 6));
            }
        }
    }
}
