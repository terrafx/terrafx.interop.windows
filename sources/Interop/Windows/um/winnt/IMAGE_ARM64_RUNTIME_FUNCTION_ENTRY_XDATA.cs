// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint HeaderData;

        [FieldOffset(0)]
        [NativeTypeName("IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:18778:5)")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            internal uint _bitfield;

            [NativeTypeName("DWORD : 18")]
            public uint FunctionLength
            {
                get
                {
                    return _bitfield & 0x3FFFFu;
                }

                set
                {
                    _bitfield = (_bitfield & ~0x3FFFFu) | (value & 0x3FFFFu);
                }
            }

            [NativeTypeName("DWORD : 2")]
            public uint Version
            {
                get
                {
                    return (_bitfield >> 18) & 0x3u;
                }

                set
                {
                    _bitfield = (_bitfield & ~(0x3u << 18)) | ((value & 0x3u) << 18);
                }
            }

            [NativeTypeName("DWORD : 1")]
            public uint ExceptionDataPresent
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
            public uint EpilogInHeader
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

            [NativeTypeName("DWORD : 5")]
            public uint EpilogCount
            {
                get
                {
                    return (_bitfield >> 22) & 0x1Fu;
                }

                set
                {
                    _bitfield = (_bitfield & ~(0x1Fu << 22)) | ((value & 0x1Fu) << 22);
                }
            }

            [NativeTypeName("DWORD : 5")]
            public uint CodeWords
            {
                get
                {
                    return (_bitfield >> 27) & 0x1Fu;
                }

                set
                {
                    _bitfield = (_bitfield & ~(0x1Fu << 27)) | ((value & 0x1Fu) << 27);
                }
            }
        }
    }
}
