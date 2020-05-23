// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D2D_MATRIX_3X2_F
    {
        [NativeTypeName("D2D_MATRIX_3X2_F::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/dcommon.h:277:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("D2D_MATRIX_3X2_F::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/dcommon.h:279:9)")]
            public _Anonymous1_e__Struct Anonymous1;

            [FieldOffset(0)]
            [NativeTypeName("D2D_MATRIX_3X2_F::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/dcommon.h:312:9)")]
            public _Anonymous2_e__Struct Anonymous2;

            [FieldOffset(0)]
            [NativeTypeName("FLOAT [3][2]")]
            public fixed float m[3 * 2];

            public partial struct _Anonymous1_e__Struct
            {
                [NativeTypeName("FLOAT")]
                public float m11;

                [NativeTypeName("FLOAT")]
                public float m12;

                [NativeTypeName("FLOAT")]
                public float m21;

                [NativeTypeName("FLOAT")]
                public float m22;

                [NativeTypeName("FLOAT")]
                public float dx;

                [NativeTypeName("FLOAT")]
                public float dy;
            }

            public partial struct _Anonymous2_e__Struct
            {
                [NativeTypeName("FLOAT")]
                public float _11;

                [NativeTypeName("FLOAT")]
                public float _12;

                [NativeTypeName("FLOAT")]
                public float _21;

                [NativeTypeName("FLOAT")]
                public float _22;

                [NativeTypeName("FLOAT")]
                public float _31;

                [NativeTypeName("FLOAT")]
                public float _32;
            }
        }
    }
}
