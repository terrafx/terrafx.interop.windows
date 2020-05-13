// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct IMAGE_RESOURCE_DIRECTORY_ENTRY
    {
        [NativeTypeName("_IMAGE_RESOURCE_DIRECTORY_ENTRY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winnt.h:18206:5)")]
        public _Anonymous_e__Union1 Anonymous1;

        [NativeTypeName("_IMAGE_RESOURCE_DIRECTORY_ENTRY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winnt.h:18214:5)")]
        public _Anonymous_e__Union3 Anonymous2;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union1
        {
            [FieldOffset(0)]
            [NativeTypeName("_IMAGE_RESOURCE_DIRECTORY_ENTRY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winnt.h:18207:9)")]
            public _Anonymous_e__Union2 Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Name;

            [FieldOffset(0)]
            [NativeTypeName("WORD")]
            public ushort Id;

            public partial struct _Anonymous_e__Union2
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
        public partial struct _Anonymous_e__Union3
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint OffsetToData;

            [FieldOffset(0)]
            [NativeTypeName("_IMAGE_RESOURCE_DIRECTORY_ENTRY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winnt.h:18216:9)")]
            public _Anonymous_e__Union4 Anonymous;

            public partial struct _Anonymous_e__Union4
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
