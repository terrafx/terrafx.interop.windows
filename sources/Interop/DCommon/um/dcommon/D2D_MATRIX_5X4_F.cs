// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D2D_MATRIX_5X4_F
    {
        [NativeTypeName("D2D_MATRIX_5X4_F::(anonymous union at um/dcommon.h:373:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("D2D_MATRIX_5X4_F::(anonymous struct at um/dcommon.h:375:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("FLOAT [5][4]")]
            public fixed float m[5 * 4];

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("FLOAT")]
                public float _11;

                [NativeTypeName("FLOAT")]
                public float _12;

                [NativeTypeName("FLOAT")]
                public float _13;

                [NativeTypeName("FLOAT")]
                public float _14;

                [NativeTypeName("FLOAT")]
                public float _21;

                [NativeTypeName("FLOAT")]
                public float _22;

                [NativeTypeName("FLOAT")]
                public float _23;

                [NativeTypeName("FLOAT")]
                public float _24;

                [NativeTypeName("FLOAT")]
                public float _31;

                [NativeTypeName("FLOAT")]
                public float _32;

                [NativeTypeName("FLOAT")]
                public float _33;

                [NativeTypeName("FLOAT")]
                public float _34;

                [NativeTypeName("FLOAT")]
                public float _41;

                [NativeTypeName("FLOAT")]
                public float _42;

                [NativeTypeName("FLOAT")]
                public float _43;

                [NativeTypeName("FLOAT")]
                public float _44;

                [NativeTypeName("FLOAT")]
                public float _51;

                [NativeTypeName("FLOAT")]
                public float _52;

                [NativeTypeName("FLOAT")]
                public float _53;

                [NativeTypeName("FLOAT")]
                public float _54;
            }
        }
    }
}
