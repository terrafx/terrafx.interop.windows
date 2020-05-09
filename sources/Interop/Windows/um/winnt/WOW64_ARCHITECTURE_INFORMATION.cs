// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct WOW64_ARCHITECTURE_INFORMATION
    {
        internal uint _bitfield;

        [NativeTypeName("DWORD : 16")]
        public uint Machine
        {
            get
            {
                return _bitfield & 0xFFFFu;
            }

            set
            {
                _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu);
            }
        }

        [NativeTypeName("DWORD : 1")]
        public uint KernelMode
        {
            get
            {
                return (_bitfield >> 16) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 16)) | ((value & 0x1u) << 16);
            }
        }

        [NativeTypeName("DWORD : 1")]
        public uint UserMode
        {
            get
            {
                return (_bitfield >> 17) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 17)) | ((value & 0x1u) << 17);
            }
        }

        [NativeTypeName("DWORD : 1")]
        public uint Native
        {
            get
            {
                return (_bitfield >> 18) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 18)) | ((value & 0x1u) << 18);
            }
        }

        [NativeTypeName("DWORD : 1")]
        public uint Process
        {
            get
            {
                return (_bitfield >> 19) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 19)) | ((value & 0x1u) << 19);
            }
        }

        [NativeTypeName("DWORD : 12")]
        public uint ReservedZero0
        {
            get
            {
                return (_bitfield >> 20) & 0xFFFu;
            }

            set
            {
                _bitfield = (_bitfield & ~(0xFFFu << 20)) | ((value & 0xFFFu) << 20);
            }
        }
    }
}
