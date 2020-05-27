// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct LDT_ENTRY
    {
        [NativeTypeName("WORD")]
        public ushort LimitLow;

        [NativeTypeName("WORD")]
        public ushort BaseLow;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:7724:5)")]
        public _HighWord_e__Union HighWord;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _HighWord_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:7725:9)")]
            public _Bytes_e__Struct Bytes;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:7731:9)")]
            public _Bits_e__Struct Bits;

            public partial struct _Bytes_e__Struct
            {
                [NativeTypeName("BYTE")]
                public byte BaseMid;

                [NativeTypeName("BYTE")]
                public byte Flags1;

                [NativeTypeName("BYTE")]
                public byte Flags2;

                [NativeTypeName("BYTE")]
                public byte BaseHi;
            }

            public partial struct _Bits_e__Struct
            {
                internal uint _bitfield;

                [NativeTypeName("DWORD : 8")]
                public uint BaseMid
                {
                    get
                    {
                        return _bitfield & 0xFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~0xFFu) | (value & 0xFFu);
                    }
                }

                [NativeTypeName("DWORD : 5")]
                public uint Type
                {
                    get
                    {
                        return (_bitfield >> 8) & 0x1Fu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1Fu << 8)) | ((value & 0x1Fu) << 8);
                    }
                }

                [NativeTypeName("DWORD : 2")]
                public uint Dpl
                {
                    get
                    {
                        return (_bitfield >> 13) & 0x3u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x3u << 13)) | ((value & 0x3u) << 13);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint Pres
                {
                    get
                    {
                        return (_bitfield >> 15) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15);
                    }
                }

                [NativeTypeName("DWORD : 4")]
                public uint LimitHi
                {
                    get
                    {
                        return (_bitfield >> 16) & 0xFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0xFu << 16)) | ((value & 0xFu) << 16);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint Sys
                {
                    get
                    {
                        return (_bitfield >> 20) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 20)) | ((value & 0x1u) << 20);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint Reserved_0
                {
                    get
                    {
                        return (_bitfield >> 21) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 21)) | ((value & 0x1u) << 21);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint Default_Big
                {
                    get
                    {
                        return (_bitfield >> 22) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 22)) | ((value & 0x1u) << 22);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint Granularity
                {
                    get
                    {
                        return (_bitfield >> 23) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 23)) | ((value & 0x1u) << 23);
                    }
                }

                [NativeTypeName("DWORD : 8")]
                public uint BaseHi
                {
                    get
                    {
                        return (_bitfield >> 24) & 0xFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0xFFu << 24)) | ((value & 0xFFu) << 24);
                    }
                }
            }
        }
    }
}
