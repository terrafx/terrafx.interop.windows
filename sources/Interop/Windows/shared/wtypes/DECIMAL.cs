// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\WTypesbase.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DECIMAL
    {
        public ushort wReserved;

        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("ULONG")]
        public uint Hi32;

        public _Anonymous2_e__Union Anonymous2;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
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
