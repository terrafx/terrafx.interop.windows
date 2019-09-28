// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DISPLAYCONFIG_PATH_SOURCE_INFO
    {
        public LUID adapterId;

        [NativeTypeName("UINT32")]
        public uint id;

        [NativeTypeName("struct (anonymous struct at um/wingdi.h:2950:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("UINT32")]
        public uint statusFlags;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint modeInfoIdx;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at um/wingdi.h:2953:9)")]
            public _Anonymous_e__Record Anonymous;

            public partial struct _Anonymous_e__Record
            {
                internal uint _bitfield;

                [NativeTypeName("UINT32")]
                public uint cloneGroupId
                {
                    get
                    {
                        return _bitfield & 0xFFFF;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFF);
                    }
                }

                [NativeTypeName("UINT32")]
                public uint sourceModeInfoIdx
                {
                    get
                    {
                        return (_bitfield >> 16) & 0xFFFF;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0xFFFFu << 16)) | ((value & 0xFFFF) << 16);
                    }
                }
            }
        }
    }
}
