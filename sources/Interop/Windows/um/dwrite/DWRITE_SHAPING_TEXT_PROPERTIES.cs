// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DWRITE_SHAPING_TEXT_PROPERTIES
    {
        internal ushort _bitfield;

        [NativeTypeName("UINT16 : 1")]
        public ushort isShapedAlone
        {
            get
            {
                return (ushort)(_bitfield & 0x1u);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~0x1u) | (value & 0x1u));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort reserved1
        {
            get
            {
                return (ushort)((_bitfield >> 1) & 0x1u);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort canBreakShapingAfter
        {
            get
            {
                return (ushort)((_bitfield >> 2) & 0x1u);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2));
            }
        }

        [NativeTypeName("UINT16 : 13")]
        public ushort reserved
        {
            get
            {
                return (ushort)((_bitfield >> 3) & 0x1FFFu);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1FFFu << 3)) | ((value & 0x1FFFu) << 3));
            }
        }
    }
}
