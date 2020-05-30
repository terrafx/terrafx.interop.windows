// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION
    {
        internal uint _bitfield;

        [NativeTypeName("DWORD : 12")]
        public uint PageRelativeOffset
        {
            get
            {
                return _bitfield & 0xFFFu;
            }

            set
            {
                _bitfield = (_bitfield & ~0xFFFu) | (value & 0xFFFu);
            }
        }

        [NativeTypeName("DWORD : 1")]
        public uint IndirectCall
        {
            get
            {
                return (_bitfield >> 12) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12);
            }
        }

        [NativeTypeName("DWORD : 19")]
        public uint IATIndex
        {
            get
            {
                return (_bitfield >> 13) & 0x7FFFFu;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x7FFFFu << 13)) | ((value & 0x7FFFFu) << 13);
            }
        }
    }
}
