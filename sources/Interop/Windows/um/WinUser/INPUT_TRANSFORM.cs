// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct INPUT_TRANSFORM
    {
        [NativeTypeName("tagINPUT_TRANSFORM::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/WinUser.h:6787:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("tagINPUT_TRANSFORM::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/WinUser.h:6788:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("float [4][4]")]
            public fixed float m[4 * 4];

            public partial struct _Anonymous_e__Struct
            {
                public float _11;

                public float _12;

                public float _13;

                public float _14;

                public float _21;

                public float _22;

                public float _23;

                public float _24;

                public float _31;

                public float _32;

                public float _33;

                public float _34;

                public float _41;

                public float _42;

                public float _43;

                public float _44;
            }
        }
    }
}
