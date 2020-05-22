// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct IMPORT_OBJECT_HEADER
    {
        [NativeTypeName("WORD")]
        public ushort Sig1;

        [NativeTypeName("WORD")]
        public ushort Sig2;

        [NativeTypeName("WORD")]
        public ushort Version;

        [NativeTypeName("WORD")]
        public ushort Machine;

        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        [NativeTypeName("DWORD")]
        public uint SizeOfData;

        [NativeTypeName("IMPORT_OBJECT_HEADER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:18946:5)")]
        public _Anonymous_e__Union Anonymous;

        internal ushort _bitfield;

        [NativeTypeName("WORD : 2")]
        public ushort Type
        {
            get
            {
                return (ushort)(_bitfield & 0x3u);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~0x3u) | (value & 0x3u));
            }
        }

        [NativeTypeName("WORD : 3")]
        public ushort NameType
        {
            get
            {
                return (ushort)((_bitfield >> 2) & 0x7u);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x7u << 2)) | ((value & 0x7u) << 2));
            }
        }

        [NativeTypeName("WORD : 11")]
        public ushort Reserved
        {
            get
            {
                return (ushort)((_bitfield >> 5) & 0x7FFu);
            }

            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x7FFu << 5)) | ((value & 0x7FFu) << 5));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("WORD")]
            public ushort Ordinal;

            [FieldOffset(0)]
            [NativeTypeName("WORD")]
            public ushort Hint;
        }
    }
}
