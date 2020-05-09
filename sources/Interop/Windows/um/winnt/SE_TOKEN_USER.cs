// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SE_TOKEN_USER
    {
        [NativeTypeName("_SE_TOKEN_USER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winnt.h:10805:5)")]
        public _Anonymous_e__Union1 Anonymous1;

        [NativeTypeName("_SE_TOKEN_USER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winnt.h:10810:5)")]
        public _Anonymous_e__Union2 Anonymous2;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union1
        {
            [FieldOffset(0)]
            public TOKEN_USER TokenUser;

            [FieldOffset(0)]
            public SID_AND_ATTRIBUTES User;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union2
        {
            [FieldOffset(0)]
            public SID Sid;

            [FieldOffset(0)]
            [NativeTypeName("BYTE [68]")]
            public fixed byte Buffer[68];
        }
    }
}
