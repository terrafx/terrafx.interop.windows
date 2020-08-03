// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DEVICE_STORAGE_RANGE_ATTRIBUTES
    {
        [NativeTypeName("DWORDLONG")]
        public ulong LengthInBytes;

        [NativeTypeName("_DEVICE_STORAGE_RANGE_ATTRIBUTES::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:4326:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint AllFlags => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.AllFlags, 1));

        public uint IsRangeBad
        {
            get
            {
                return Anonymous.Anonymous.IsRangeBad;
            }

            set
            {
                Anonymous.Anonymous.IsRangeBad = value;
            }
        }

        [NativeTypeName("DWORD")]
        public uint Reserved;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint AllFlags;

            [FieldOffset(0)]
            [NativeTypeName("_DEVICE_STORAGE_RANGE_ATTRIBUTES::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:4330:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("DWORD : 1")]
                public uint IsRangeBad
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
            }
        }
    }
}
