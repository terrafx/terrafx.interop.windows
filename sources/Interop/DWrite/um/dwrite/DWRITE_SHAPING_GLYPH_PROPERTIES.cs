// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DWRITE_SHAPING_GLYPH_PROPERTIES
    {
        internal ushort _bitfield;

        [NativeTypeName("UINT16 : 4")]
        public ushort justification
        {
            get
            {
                return (ushort)(_bitfield & 0xFu);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~0xFu) | (value & 0xFu));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort isClusterStart
        {
            get
            {
                return (ushort)((_bitfield >> 4) & 0x1u);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort isDiacritic
        {
            get
            {
                return (ushort)((_bitfield >> 5) & 0x1u);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort isZeroWidthSpace
        {
            get
            {
                return (ushort)((_bitfield >> 6) & 0x1u);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6));
            }
        }

        [NativeTypeName("UINT16 : 9")]
        public ushort reserved
        {
            get
            {
                return (ushort)((_bitfield >> 7) & 0x1FFu);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1FFu << 7)) | ((value & 0x1FFu) << 7));
            }
        }
    }
}
