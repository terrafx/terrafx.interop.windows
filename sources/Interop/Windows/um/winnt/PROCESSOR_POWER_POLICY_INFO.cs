// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PROCESSOR_POWER_POLICY_INFO
    {
        [NativeTypeName("DWORD")]
        public uint TimeCheck;

        [NativeTypeName("DWORD")]
        public uint DemoteLimit;

        [NativeTypeName("DWORD")]
        public uint PromoteLimit;

        [NativeTypeName("BYTE")]
        public byte DemotePercent;

        [NativeTypeName("BYTE")]
        public byte PromotePercent;

        [NativeTypeName("BYTE [2]")]
        public fixed byte Spare[2];

        public uint _bitfield;

        [NativeTypeName("DWORD : 1")]
        public uint AllowDemotion
        {
            get
            {
                return _bitfield & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
            }
        }

        [NativeTypeName("DWORD : 1")]
        public uint AllowPromotion
        {
            get
            {
                return (_bitfield >> 1) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
            }
        }

        [NativeTypeName("DWORD : 30")]
        public uint Reserved
        {
            get
            {
                return (_bitfield >> 2) & 0x3FFFFFFFu;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2);
            }
        }
    }
}
