// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DISPLAYCONFIG_SET_ADVANCED_COLOR_STATE
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        [NativeTypeName("struct (anonymous struct at um/wingdi.h:3175:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at um/wingdi.h:3177:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint value;

            public partial struct _Anonymous_e__Struct
            {
                private uint _bitfield;

                [NativeTypeName("UINT32")]
                public uint enableAdvancedColor
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
                public uint reserved
                {
                    get
                    {
                        return (_bitfield >> 1) & 0x7FFFFFFF;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFF) << 1);
                    }
                }
            }
        }
    }
}
