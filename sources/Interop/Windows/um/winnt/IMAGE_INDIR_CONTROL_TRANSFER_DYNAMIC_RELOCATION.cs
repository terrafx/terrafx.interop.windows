// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct IMAGE_INDIR_CONTROL_TRANSFER_DYNAMIC_RELOCATION
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

        [NativeTypeName("WORD : 1")]
        public ushort IndirectCall
        {
            get
            {
                return (ushort)((_bitfield >> 12) & 0x1u);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12));
            }
        }

        [NativeTypeName("WORD : 1")]
        public ushort RexWPrefix
        {
            get
            {
                return (ushort)((_bitfield >> 13) & 0x1u);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 13)) | ((value & 0x1u) << 13));
            }
        }

        [NativeTypeName("WORD : 1")]
        public ushort CfgCheck
        {
            get
            {
                return (ushort)((_bitfield >> 14) & 0x1u);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 14)) | ((value & 0x1u) << 14));
            }
        }

        [NativeTypeName("WORD : 1")]
        public ushort Reserved
        {
            get
            {
                return (ushort)((_bitfield >> 15) & 0x1u);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15));
            }
        }
    }
}
