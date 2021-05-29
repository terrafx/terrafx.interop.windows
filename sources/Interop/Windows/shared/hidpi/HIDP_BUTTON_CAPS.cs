// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct HIDP_BUTTON_CAPS
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

        [NativeTypeName("ULONG [10]")]
        public fixed uint Reserved[10];

        [NativeTypeName("_HIDP_BUTTON_CAPS::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/hidpi.h:86:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref _Anonymous_e__Union._Range_e__Struct Range
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Range, 1));
            }
        }

        public ref _Anonymous_e__Union._NotRange_e__Struct NotRange
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.NotRange, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/hidpi.h:87:9)")]
            public _Range_e__Struct Range;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/hidpi.h:93:9)")]
            public _NotRange_e__Struct NotRange;

            public partial struct _Range_e__Struct
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

            public partial struct _NotRange_e__Struct
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
