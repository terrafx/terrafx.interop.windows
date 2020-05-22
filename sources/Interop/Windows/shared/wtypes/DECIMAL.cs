// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DECIMAL
    {
        public ushort wReserved;

        [NativeTypeName("DECIMAL::(anonymous union at shared/wtypes.h:697:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("ULONG")]
        public uint Hi32;

        [NativeTypeName("DECIMAL::(anonymous union at shared/wtypes.h:705:5)")]
        public _Anonymous2_e__Union Anonymous2;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at shared/wtypes.h:698:9)")]
            _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("USHORT")]
            public ushort signscale;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("BYTE")]
                public byte scale;

                [NativeTypeName("BYTE")]
                public byte sign;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at shared/wtypes.h:706:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Lo64;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Lo32;

                [NativeTypeName("ULONG")]
                public uint Mid32;
            }
        }
    }
}
