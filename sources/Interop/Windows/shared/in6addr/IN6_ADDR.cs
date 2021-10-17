// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/in6addr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct IN6_ADDR
    {
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/in6addr.h:26:5)")]
        public _u_e__Union u;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _u_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UCHAR [16]")]
            public fixed byte Byte[16];

            [FieldOffset(0)]
            [NativeTypeName("USHORT [8]")]
            public fixed ushort Word[8];
        }
    }
}
