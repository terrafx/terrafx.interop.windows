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
                return (ushort)((uint)_bitfield & 0xF);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~0xFu) | ((uint)value & 0xF));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort isClusterStart
        {
            get
            {
                return (ushort)(((uint)_bitfield >> 4) & 0x1);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 4)) | (((uint)value & 0x1) << 4));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort isDiacritic
        {
            get
            {
                return (ushort)(((uint)_bitfield >> 5) & 0x1);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 5)) | (((uint)value & 0x1) << 5));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort isZeroWidthSpace
        {
            get
            {
                return (ushort)(((uint)_bitfield >> 6) & 0x1);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 6)) | (((uint)value & 0x1) << 6));
            }
        }

        [NativeTypeName("UINT16 : 9")]
        public ushort reserved
        {
            get
            {
                return (ushort)(((uint)_bitfield >> 7) & 0x1FF);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1FFu << 7)) | (((uint)value & 0x1FF) << 7));
            }
        }
    }
}
