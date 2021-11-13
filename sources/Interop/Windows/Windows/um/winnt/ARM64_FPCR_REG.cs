// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct ARM64_FPCR_REG
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Value;

        [FieldOffset(0)]
        [NativeTypeName("_ARM64_FPCR_REG::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:6759:5)")]
        public _Anonymous_e__Struct Anonymous;

        public uint res0_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.res0_1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.res0_1 = value;
            }
        }

        public uint IOE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.IOE;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.IOE = value;
            }
        }

        public uint DZE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.DZE;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.DZE = value;
            }
        }

        public uint OFE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.OFE;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.OFE = value;
            }
        }

        public uint UFE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.UFE;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.UFE = value;
            }
        }

        public uint IXE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.IXE;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.IXE = value;
            }
        }

        public uint res0_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.res0_2;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.res0_2 = value;
            }
        }

        public uint IDE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.IDE;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.IDE = value;
            }
        }

        public uint Len
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Len;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Len = value;
            }
        }

        public uint FZ16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.FZ16;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.FZ16 = value;
            }
        }

        public uint Stride
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Stride;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Stride = value;
            }
        }

        public uint RMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.RMode;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.RMode = value;
            }
        }

        public uint FZ
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.FZ;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.FZ = value;
            }
        }

        public uint DN
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.DN;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.DN = value;
            }
        }

        public uint AHP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.AHP;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.AHP = value;
            }
        }

        public uint res0_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.res0_3;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.res0_3 = value;
            }
        }

        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("DWORD : 8")]
            public uint res0_1
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield & 0xFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0xFFu) | (value & 0xFFu);
                }
            }

            [NativeTypeName("DWORD : 1")]
            public uint IOE
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 8) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8);
                }
            }

            [NativeTypeName("DWORD : 1")]
            public uint DZE
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 9) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 9)) | ((value & 0x1u) << 9);
                }
            }

            [NativeTypeName("DWORD : 1")]
            public uint OFE
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 10) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 10)) | ((value & 0x1u) << 10);
                }
            }

            [NativeTypeName("DWORD : 1")]
            public uint UFE
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 11) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 11)) | ((value & 0x1u) << 11);
                }
            }

            [NativeTypeName("DWORD : 1")]
            public uint IXE
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 12) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12);
                }
            }

            [NativeTypeName("DWORD : 2")]
            public uint res0_2
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 13) & 0x3u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x3u << 13)) | ((value & 0x3u) << 13);
                }
            }

            [NativeTypeName("DWORD : 1")]
            public uint IDE
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 15) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15);
                }
            }

            [NativeTypeName("DWORD : 3")]
            public uint Len
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 16) & 0x7u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x7u << 16)) | ((value & 0x7u) << 16);
                }
            }

            [NativeTypeName("DWORD : 1")]
            public uint FZ16
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 19) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 19)) | ((value & 0x1u) << 19);
                }
            }

            [NativeTypeName("DWORD : 2")]
            public uint Stride
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 20) & 0x3u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x3u << 20)) | ((value & 0x3u) << 20);
                }
            }

            [NativeTypeName("DWORD : 2")]
            public uint RMode
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 22) & 0x3u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x3u << 22)) | ((value & 0x3u) << 22);
                }
            }

            [NativeTypeName("DWORD : 1")]
            public uint FZ
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 24) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 24)) | ((value & 0x1u) << 24);
                }
            }

            [NativeTypeName("DWORD : 1")]
            public uint DN
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 25) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 25)) | ((value & 0x1u) << 25);
                }
            }

            [NativeTypeName("DWORD : 1")]
            public uint AHP
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 26) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 26)) | ((value & 0x1u) << 26);
                }
            }

            [NativeTypeName("DWORD : 5")]
            public uint res0_3
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 27) & 0x1Fu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1Fu << 27)) | ((value & 0x1Fu) << 27);
                }
            }
        }
    }
}
