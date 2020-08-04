// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct AM_COLCON
    {
        public byte _bitfield1;

        [NativeTypeName("UCHAR : 4")]
        public byte emph1col
        {
            get
            {
                return (byte)(_bitfield1 & 0xFu);
            }

            set
            {
                _bitfield1 = (byte)((_bitfield1 & ~0xFu) | (value & 0xFu));
            }
        }

        [NativeTypeName("UCHAR : 4")]
        public byte emph2col
        {
            get
            {
                return (byte)((_bitfield1 >> 4) & 0xFu);
            }

            set
            {
                _bitfield1 = (byte)((_bitfield1 & ~(0xFu << 4)) | ((value & 0xFu) << 4));
            }
        }

        public byte _bitfield2;

        [NativeTypeName("UCHAR : 4")]
        public byte backcol
        {
            get
            {
                return (byte)(_bitfield2 & 0xFu);
            }

            set
            {
                _bitfield2 = (byte)((_bitfield2 & ~0xFu) | (value & 0xFu));
            }
        }

        [NativeTypeName("UCHAR : 4")]
        public byte patcol
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

        public byte _bitfield3;

        [NativeTypeName("UCHAR : 4")]
        public byte emph1con
        {
            get
            {
                return (byte)(_bitfield3 & 0xFu);
            }

            set
            {
                _bitfield3 = (byte)((_bitfield3 & ~0xFu) | (value & 0xFu));
            }
        }

        [NativeTypeName("UCHAR : 4")]
        public byte emph2con
        {
            get
            {
                return (byte)((_bitfield3 >> 4) & 0xFu);
            }

            set
            {
                _bitfield3 = (byte)((_bitfield3 & ~(0xFu << 4)) | ((value & 0xFu) << 4));
            }
        }

        public byte _bitfield4;

        [NativeTypeName("UCHAR : 4")]
        public byte backcon
        {
            get
            {
                return (byte)(_bitfield4 & 0xFu);
            }

            set
            {
                _bitfield4 = (byte)((_bitfield4 & ~0xFu) | (value & 0xFu));
            }
        }

        [NativeTypeName("UCHAR : 4")]
        public byte patcon
        {
            get
            {
                return (byte)((_bitfield4 >> 4) & 0xFu);
            }

            set
            {
                _bitfield4 = (byte)((_bitfield4 & ~(0xFu << 4)) | ((value & 0xFu) << 4));
            }
        }
    }
}
