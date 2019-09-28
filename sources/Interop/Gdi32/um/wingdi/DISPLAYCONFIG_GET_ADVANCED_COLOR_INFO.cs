// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        [NativeTypeName("struct (anonymous struct at um/wingdi.h:3156:5)")]
        public _Anonymous_e__Union Anonymous;

        public DISPLAYCONFIG_COLOR_ENCODING colorEncoding;

        [NativeTypeName("UINT32")]
        public uint bitsPerColorChannel;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at um/wingdi.h:3158:9)")]
            public _Anonymous_e__Record Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint value;

            public partial struct _Anonymous_e__Record
            {
                internal uint _bitfield;

                [NativeTypeName("UINT32")]
                public uint advancedColorSupported
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
                public uint advancedColorEnabled
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
                public uint reserved
                {
                    get
                    {
                        return (_bitfield >> 2) & 0x3FFFFFFF;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFF) << 2);
                    }
                }
            }
        }
    }
}
