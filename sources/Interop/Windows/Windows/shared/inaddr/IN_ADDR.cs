// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/inaddr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct IN_ADDR
    {
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/inaddr.h:26:9)")]
        public _S_un_e__Union S_un;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _S_un_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/inaddr.h:27:17)")]
            public _S_un_b_e__Struct S_un_b;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/inaddr.h:28:17)")]
            public _S_un_w_e__Struct S_un_w;

            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint S_addr;

            public partial struct _S_un_b_e__Struct
            {
                [NativeTypeName("UCHAR")]
                public byte s_b1;

                [NativeTypeName("UCHAR")]
                public byte s_b2;

                [NativeTypeName("UCHAR")]
                public byte s_b3;

                [NativeTypeName("UCHAR")]
                public byte s_b4;
            }

            public partial struct _S_un_w_e__Struct
            {
                public ushort s_w1;

                public ushort s_w2;
            }
        }
    }
}
