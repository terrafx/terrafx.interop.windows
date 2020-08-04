// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct STORAGE_HW_FIRMWARE_SLOT_INFO
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("BYTE")]
        public byte SlotNumber;

        public byte _bitfield;

        [NativeTypeName("BYTE : 1")]
        public byte ReadOnly
        {
            get
            {
                return (byte)(_bitfield & 0x1u);
            }

            set
            {
                _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u));
            }
        }

        [NativeTypeName("BYTE : 7")]
        public byte Reserved0
        {
            get
            {
                return (byte)((_bitfield >> 1) & 0x7Fu);
            }

            set
            {
                _bitfield = (byte)((_bitfield & ~(0x7Fu << 1)) | ((value & 0x7Fu) << 1));
            }
        }

        [NativeTypeName("BYTE [6]")]
        public fixed byte Reserved1[6];

        [NativeTypeName("BYTE [16]")]
        public fixed byte Revision[16];
    }
}
