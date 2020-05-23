// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct IMAGE_SWITCHTABLE_BRANCH_DYNAMIC_RELOCATION
    {
        internal ushort _bitfield;

        [NativeTypeName("WORD : 12")]
        public ushort PageRelativeOffset
        {
            get
            {
                return (ushort)(_bitfield & 0xFFFu);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~0xFFFu) | (value & 0xFFFu));
            }
        }

        [NativeTypeName("WORD : 4")]
        public ushort RegisterNumber
        {
            get
            {
                return (ushort)((_bitfield >> 12) & 0xFu);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0xFu << 12)) | ((value & 0xFu) << 12));
            }
        }
    }
}
