// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct HIDP_VALUE_CAPS
    {
        [NativeTypeName("USAGE")]
        public ushort UsagePage;

        [NativeTypeName("UCHAR")]
        public byte ReportID;

        [NativeTypeName("BOOLEAN")]
        public byte IsAlias;

        [NativeTypeName("USHORT")]
        public ushort BitField;

        [NativeTypeName("USHORT")]
        public ushort LinkCollection;

        [NativeTypeName("USAGE")]
        public ushort LinkUsage;

        [NativeTypeName("USAGE")]
        public ushort LinkUsagePage;

        [NativeTypeName("BOOLEAN")]
        public byte IsRange;

        [NativeTypeName("BOOLEAN")]
        public byte IsStringRange;

        [NativeTypeName("BOOLEAN")]
        public byte IsDesignatorRange;

        [NativeTypeName("BOOLEAN")]
        public byte IsAbsolute;

        [NativeTypeName("BOOLEAN")]
        public byte HasNull;

        [NativeTypeName("UCHAR")]
        public byte Reserved;

        [NativeTypeName("USHORT")]
        public ushort BitSize;

        [NativeTypeName("USHORT")]
        public ushort ReportCount;

        [NativeTypeName("USHORT [5]")]
        public fixed ushort Reserved2[5];

        [NativeTypeName("ULONG")]
        public uint UnitsExp;

        [NativeTypeName("ULONG")]
        public uint Units;

        [NativeTypeName("LONG")]
        public int LogicalMin;

        [NativeTypeName("LONG")]
        public int LogicalMax;

        [NativeTypeName("LONG")]
        public int PhysicalMin;

        [NativeTypeName("LONG")]
        public int PhysicalMax;

        [NativeTypeName("_HIDP_VALUE_CAPS::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/shared/hidpi.h:134:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/shared/hidpi.h:135:9)")]
            public _Range_e__Union Range;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/shared/hidpi.h:142:9)")]
            public _NotRange_e__Union NotRange;

            public partial struct _Range_e__Union
            {
                [NativeTypeName("USAGE")]
                public ushort UsageMin;

                [NativeTypeName("USAGE")]
                public ushort UsageMax;

                [NativeTypeName("USHORT")]
                public ushort StringMin;

                [NativeTypeName("USHORT")]
                public ushort StringMax;

                [NativeTypeName("USHORT")]
                public ushort DesignatorMin;

                [NativeTypeName("USHORT")]
                public ushort DesignatorMax;

                [NativeTypeName("USHORT")]
                public ushort DataIndexMin;

                [NativeTypeName("USHORT")]
                public ushort DataIndexMax;
            }

            public partial struct _NotRange_e__Union
            {
                [NativeTypeName("USAGE")]
                public ushort Usage;

                [NativeTypeName("USAGE")]
                public ushort Reserved1;

                [NativeTypeName("USHORT")]
                public ushort StringIndex;

                [NativeTypeName("USHORT")]
                public ushort Reserved2;

                [NativeTypeName("USHORT")]
                public ushort DesignatorIndex;

                [NativeTypeName("USHORT")]
                public ushort Reserved3;

                [NativeTypeName("USHORT")]
                public ushort DataIndex;

                [NativeTypeName("USHORT")]
                public ushort Reserved4;
            }
        }
    }
}
