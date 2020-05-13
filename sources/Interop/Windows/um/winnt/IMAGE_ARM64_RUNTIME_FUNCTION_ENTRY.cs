// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY
    {
        [NativeTypeName("DWORD")]
        public uint BeginAddress;

        [NativeTypeName("_IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winnt.h:18603:5)")]
        public _Anonymous_e__Union1 Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union1
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint UnwindData;

            [FieldOffset(0)]
            [NativeTypeName("_IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winnt.h:18605:9)")]
            public _Anonymous_e__Union2 Anonymous;

            public partial struct _Anonymous_e__Union2
            {
                internal uint _bitfield;

                [NativeTypeName("DWORD : 2")]
                public uint Flag
                {
                    get
                    {
                        return _bitfield & 0x3u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~0x3u) | (value & 0x3u);
                    }
                }

                [NativeTypeName("DWORD : 11")]
                public uint FunctionLength
                {
                    get
                    {
                        return (_bitfield >> 2) & 0x7FFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x7FFu << 2)) | ((value & 0x7FFu) << 2);
                    }
                }

                [NativeTypeName("DWORD : 3")]
                public uint RegF
                {
                    get
                    {
                        return (_bitfield >> 13) & 0x7u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x7u << 13)) | ((value & 0x7u) << 13);
                    }
                }

                [NativeTypeName("DWORD : 4")]
                public uint RegI
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
                public uint H
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

                [NativeTypeName("DWORD : 2")]
                public uint CR
                {
                    get
                    {
                        return (_bitfield >> 21) & 0x3u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x3u << 21)) | ((value & 0x3u) << 21);
                    }
                }

                [NativeTypeName("DWORD : 9")]
                public uint FrameSize
                {
                    get
                    {
                        return (_bitfield >> 23) & 0x1FFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1FFu << 23)) | ((value & 0x1FFu) << 23);
                    }
                }
            }
        }
    }
}
