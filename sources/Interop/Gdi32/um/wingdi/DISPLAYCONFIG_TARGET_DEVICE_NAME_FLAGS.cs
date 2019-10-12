// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS
    {
        [NativeTypeName("struct (anonymous struct at um/wingdi.h:3071:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at um/wingdi.h:3073:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint value;

            public partial struct _Anonymous_e__Struct
            {
                internal uint _bitfield;

                [NativeTypeName("UINT32")]
                public uint friendlyNameFromEdid
                {
                    get
                    {
                        return _bitfield & 0x1;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1);
                    }
                }

                [NativeTypeName("UINT32")]
                public uint friendlyNameForced
                {
                    get
                    {
                        return (_bitfield >> 1) & 0x1;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1) << 1);
                    }
                }

                [NativeTypeName("UINT32")]
                public uint edidIdsValid
                {
                    get
                    {
                        return (_bitfield >> 2) & 0x1;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1) << 2);
                    }
                }

                [NativeTypeName("UINT32")]
                public uint reserved
                {
                    get
                    {
                        return (_bitfield >> 3) & 0x1FFFFFFF;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1FFFFFFFu << 3)) | ((value & 0x1FFFFFFF) << 3);
                    }
                }
            }
        }
    }
}
