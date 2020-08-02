// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DEVICE_LB_PROVISIONING_DESCRIPTOR
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        public byte _bitfield;

        [NativeTypeName("BYTE : 1")]
        public byte ThinProvisioningEnabled
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

        [NativeTypeName("BYTE : 1")]
        public byte ThinProvisioningReadZeros
        {
            get
            {
                return (byte)((_bitfield >> 1) & 0x1u);
            }

            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
            }
        }

        [NativeTypeName("BYTE : 3")]
        public byte AnchorSupported
        {
            get
            {
                return (byte)((_bitfield >> 2) & 0x7u);
            }

            set
            {
                _bitfield = (byte)((_bitfield & ~(0x7u << 2)) | ((value & 0x7u) << 2));
            }
        }

        [NativeTypeName("BYTE : 1")]
        public byte UnmapGranularityAlignmentValid
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

        [NativeTypeName("BYTE : 2")]
        public byte Reserved0
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

        [NativeTypeName("BYTE [7]")]
        public fixed byte Reserved1[7];

        [NativeTypeName("DWORDLONG")]
        public ulong OptimalUnmapGranularity;

        [NativeTypeName("DWORDLONG")]
        public ulong UnmapGranularityAlignment;

        [NativeTypeName("DWORD")]
        public uint MaxUnmapLbaCount;

        [NativeTypeName("DWORD")]
        public uint MaxUnmapBlockDescriptorCount;
    }
}
