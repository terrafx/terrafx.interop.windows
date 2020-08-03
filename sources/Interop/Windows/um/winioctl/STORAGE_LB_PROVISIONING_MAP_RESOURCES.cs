// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct STORAGE_LB_PROVISIONING_MAP_RESOURCES
    {
        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint Version;

        public byte _bitfield1;

        [NativeTypeName("BYTE : 1")]
        public byte AvailableMappingResourcesValid
        {
            get
            {
                return (byte)(_bitfield1 & 0x1u);
            }

            set
            {
                _bitfield1 = (byte)((_bitfield1 & ~0x1u) | (value & 0x1u));
            }
        }

        [NativeTypeName("BYTE : 1")]
        public byte UsedMappingResourcesValid
        {
            get
            {
                return (byte)((_bitfield1 >> 1) & 0x1u);
            }

            set
            {
                _bitfield1 = (byte)((_bitfield1 & ~(0x1u << 1)) | ((value & 0x1u) << 1));
            }
        }

        [NativeTypeName("BYTE : 6")]
        public byte Reserved0
        {
            get
            {
                return (byte)((_bitfield1 >> 2) & 0x3Fu);
            }

            set
            {
                _bitfield1 = (byte)((_bitfield1 & ~(0x3Fu << 2)) | ((value & 0x3Fu) << 2));
            }
        }

        [NativeTypeName("BYTE [3]")]
        public fixed byte Reserved1[3];

        public byte _bitfield2;

        [NativeTypeName("BYTE : 2")]
        public byte AvailableMappingResourcesScope
        {
            get
            {
                return (byte)(_bitfield2 & 0x3u);
            }

            set
            {
                _bitfield2 = (byte)((_bitfield2 & ~0x3u) | (value & 0x3u));
            }
        }

        [NativeTypeName("BYTE : 2")]
        public byte UsedMappingResourcesScope
        {
            get
            {
                return (byte)((_bitfield2 >> 2) & 0x3u);
            }

            set
            {
                _bitfield2 = (byte)((_bitfield2 & ~(0x3u << 2)) | ((value & 0x3u) << 2));
            }
        }

        [NativeTypeName("BYTE : 4")]
        public byte Reserved2
        {
            get
            {
                return (byte)((_bitfield2 >> 4) & 0xFu);
            }

            set
            {
                _bitfield2 = (byte)((_bitfield2 & ~(0xFu << 4)) | ((value & 0xFu) << 4));
            }
        }

        [NativeTypeName("BYTE [3]")]
        public fixed byte Reserved3[3];

        [NativeTypeName("DWORDLONG")]
        public ulong AvailableMappingResources;

        [NativeTypeName("DWORDLONG")]
        public ulong UsedMappingResources;
    }
}
