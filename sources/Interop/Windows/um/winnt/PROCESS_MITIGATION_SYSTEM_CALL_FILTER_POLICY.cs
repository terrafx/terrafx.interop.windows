// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct PROCESS_MITIGATION_SYSTEM_CALL_FILTER_POLICY
    {
        [NativeTypeName("_PROCESS_MITIGATION_SYSTEM_CALL_FILTER_POLICY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11817:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint Flags => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Flags, 1));

        public uint FilterId
        {
            get
            {
                return Anonymous.Anonymous.FilterId;
            }

            set
            {
                Anonymous.Anonymous.FilterId = value;
            }
        }

        public uint ReservedFlags
        {
            get
            {
                return Anonymous.Anonymous.ReservedFlags;
            }

            set
            {
                Anonymous.Anonymous.ReservedFlags = value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Flags;

            [FieldOffset(0)]
            [NativeTypeName("_PROCESS_MITIGATION_SYSTEM_CALL_FILTER_POLICY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11819:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("DWORD : 4")]
                public uint FilterId
                {
                    get
                    {
                        return _bitfield & 0xFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~0xFu) | (value & 0xFu);
                    }
                }

                [NativeTypeName("DWORD : 28")]
                public uint ReservedFlags
                {
                    get
                    {
                        return (_bitfield >> 4) & 0xFFFFFFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0xFFFFFFFu << 4)) | ((value & 0xFFFFFFFu) << 4);
                    }
                }
            }
        }
    }
}
