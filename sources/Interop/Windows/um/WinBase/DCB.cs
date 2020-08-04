// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DCB
    {
        [NativeTypeName("DWORD")]
        public uint DCBlength;

        [NativeTypeName("DWORD")]
        public uint BaudRate;

        public uint _bitfield;

        [NativeTypeName("DWORD : 1")]
        public uint fBinary
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
        public uint fParity
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
        public uint fOutxCtsFlow
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
        public uint fOutxDsrFlow
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

        [NativeTypeName("DWORD : 2")]
        public uint fDtrControl
        {
            get
            {
                return (_bitfield >> 4) & 0x3u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x3u << 4)) | ((value & 0x3u) << 4);
            }
        }

        [NativeTypeName("DWORD : 1")]
        public uint fDsrSensitivity
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

        [NativeTypeName("DWORD : 1")]
        public uint fTXContinueOnXoff
        {
            get
            {
                return (_bitfield >> 7) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7);
            }
        }

        [NativeTypeName("DWORD : 1")]
        public uint fOutX
        {
            get
            {
                return (_bitfield >> 8) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8);
            }
        }

        [NativeTypeName("DWORD : 1")]
        public uint fInX
        {
            get
            {
                return (_bitfield >> 9) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 9)) | ((value & 0x1u) << 9);
            }
        }

        [NativeTypeName("DWORD : 1")]
        public uint fErrorChar
        {
            get
            {
                return (_bitfield >> 10) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 10)) | ((value & 0x1u) << 10);
            }
        }

        [NativeTypeName("DWORD : 1")]
        public uint fNull
        {
            get
            {
                return (_bitfield >> 11) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 11)) | ((value & 0x1u) << 11);
            }
        }

        [NativeTypeName("DWORD : 2")]
        public uint fRtsControl
        {
            get
            {
                return (_bitfield >> 12) & 0x3u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x3u << 12)) | ((value & 0x3u) << 12);
            }
        }

        [NativeTypeName("DWORD : 1")]
        public uint fAbortOnError
        {
            get
            {
                return (_bitfield >> 14) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 14)) | ((value & 0x1u) << 14);
            }
        }

        [NativeTypeName("DWORD : 17")]
        public uint fDummy2
        {
            get
            {
                return (_bitfield >> 15) & 0x1FFFFu;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1FFFFu << 15)) | ((value & 0x1FFFFu) << 15);
            }
        }

        [NativeTypeName("WORD")]
        public ushort wReserved;

        [NativeTypeName("WORD")]
        public ushort XonLim;

        [NativeTypeName("WORD")]
        public ushort XoffLim;

        [NativeTypeName("BYTE")]
        public byte ByteSize;

        [NativeTypeName("BYTE")]
        public byte Parity;

        [NativeTypeName("BYTE")]
        public byte StopBits;

        [NativeTypeName("char")]
        public sbyte XonChar;

        [NativeTypeName("char")]
        public sbyte XoffChar;

        [NativeTypeName("char")]
        public sbyte ErrorChar;

        [NativeTypeName("char")]
        public sbyte EofChar;

        [NativeTypeName("char")]
        public sbyte EvtChar;

        [NativeTypeName("WORD")]
        public ushort wReserved1;
    }
}
