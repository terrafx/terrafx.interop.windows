// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct COMSTAT
    {
        public uint _bitfield;

        [NativeTypeName("DWORD : 1")]
        public uint fCtsHold
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
        public uint fDsrHold
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

        [NativeTypeName("DWORD : 1")]
        public uint fRlsdHold
        {
            get
            {
                return (_bitfield >> 2) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
            }
        }

        [NativeTypeName("DWORD : 1")]
        public uint fXoffHold
        {
            get
            {
                return (_bitfield >> 3) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
            }
        }

        [NativeTypeName("DWORD : 1")]
        public uint fXoffSent
        {
            get
            {
                return (_bitfield >> 4) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
            }
        }

        [NativeTypeName("DWORD : 1")]
        public uint fEof
        {
            get
            {
                return (_bitfield >> 5) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5);
            }
        }

        [NativeTypeName("DWORD : 1")]
        public uint fTxim
        {
            get
            {
                return (_bitfield >> 6) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6);
            }
        }

        [NativeTypeName("DWORD : 25")]
        public uint fReserved
        {
            get
            {
                return (_bitfield >> 7) & 0x1FFFFFFu;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1FFFFFFu << 7)) | ((value & 0x1FFFFFFu) << 7);
            }
        }

        [NativeTypeName("DWORD")]
        public uint cbInQue;

        [NativeTypeName("DWORD")]
        public uint cbOutQue;
    }
}
