// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS
    {
        [NativeTypeName("DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:3073:5)")]
        public _Anonymous_e__Union Anonymous;

        public uint friendlyNameFromEdid
        {
            get
            {
                return Anonymous.Anonymous.friendlyNameFromEdid;
            }

            set
            {
                Anonymous.Anonymous.friendlyNameFromEdid = value;
            }
        }

        public uint friendlyNameForced
        {
            get
            {
                return Anonymous.Anonymous.friendlyNameForced;
            }

            set
            {
                Anonymous.Anonymous.friendlyNameForced = value;
            }
        }

        public uint edidIdsValid
        {
            get
            {
                return Anonymous.Anonymous.edidIdsValid;
            }

            set
            {
                Anonymous.Anonymous.edidIdsValid = value;
            }
        }

        public uint reserved
        {
            get
            {
                return Anonymous.Anonymous.reserved;
            }

            set
            {
                Anonymous.Anonymous.reserved = value;
            }
        }

        public ref uint value => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.value, 1));

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:3075:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint value;

            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("UINT32 : 1")]
                public uint friendlyNameFromEdid
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

                [NativeTypeName("UINT32 : 1")]
                public uint friendlyNameForced
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

                [NativeTypeName("UINT32 : 1")]
                public uint edidIdsValid
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

                [NativeTypeName("UINT32 : 29")]
                public uint reserved
                {
                    get
                    {
                        return (_bitfield >> 3) & 0x1FFFFFFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1FFFFFFFu << 3)) | ((value & 0x1FFFFFFFu) << 3);
                    }
                }
            }
        }
    }
}
