// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct IMAGE_RESOURCE_DIRECTORY_ENTRY
    {
        [NativeTypeName("_IMAGE_RESOURCE_DIRECTORY_ENTRY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:18348:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("_IMAGE_RESOURCE_DIRECTORY_ENTRY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:18356:5)")]
        public _Anonymous2_e__Union Anonymous2;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("_IMAGE_RESOURCE_DIRECTORY_ENTRY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:18349:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Name;

            [FieldOffset(0)]
            [NativeTypeName("WORD")]
            public ushort Id;

            public partial struct _Anonymous_e__Struct
            {
                internal uint _bitfield;

                [NativeTypeName("DWORD : 31")]
                public uint NameOffset
                {
                    get
                    {
                        return _bitfield & 0x7FFFFFFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~0x7FFFFFFFu) | (value & 0x7FFFFFFFu);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint NameIsString
                {
                    get
                    {
                        return (_bitfield >> 31) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 31)) | ((value & 0x1u) << 31);
                    }
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint OffsetToData;

            [FieldOffset(0)]
            [NativeTypeName("_IMAGE_RESOURCE_DIRECTORY_ENTRY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:18358:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                internal uint _bitfield;

                [NativeTypeName("DWORD : 31")]
                public uint OffsetToDirectory
                {
                    get
                    {
                        return _bitfield & 0x7FFFFFFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~0x7FFFFFFFu) | (value & 0x7FFFFFFFu);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint DataIsDirectory
                {
                    get
                    {
                        return (_bitfield >> 31) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 31)) | ((value & 0x1u) << 31);
                    }
                }
            }
        }
    }
}
