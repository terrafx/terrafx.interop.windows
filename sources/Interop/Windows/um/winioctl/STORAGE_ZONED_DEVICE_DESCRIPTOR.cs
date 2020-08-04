// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct STORAGE_ZONED_DEVICE_DESCRIPTOR
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        public STORAGE_ZONED_DEVICE_TYPES DeviceType;

        [NativeTypeName("DWORD")]
        public uint ZoneCount;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:2867:5)")]
        public _ZoneAttributes_e__Union ZoneAttributes;

        [NativeTypeName("DWORD")]
        public uint ZoneGroupCount;

        [NativeTypeName("STORAGE_ZONE_GROUP [1]")]
        public _ZoneGroup_e__FixedBuffer ZoneGroup;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _ZoneAttributes_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:2868:9)")]
            public _SequentialRequiredZone_e__Struct SequentialRequiredZone;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:2878:9)")]
            public _SequentialPreferredZone_e__Struct SequentialPreferredZone;

            public unsafe partial struct _SequentialRequiredZone_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint MaxOpenZoneCount;

                [NativeTypeName("BOOLEAN")]
                public byte UnrestrictedRead;

                [NativeTypeName("BYTE [3]")]
                public fixed byte Reserved[3];
            }

            public partial struct _SequentialPreferredZone_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint OptimalOpenZoneCount;

                [NativeTypeName("DWORD")]
                public uint Reserved;
            }
        }

        public partial struct _ZoneGroup_e__FixedBuffer
        {
            public STORAGE_ZONE_GROUP e0;

            public ref STORAGE_ZONE_GROUP this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<STORAGE_ZONE_GROUP> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
