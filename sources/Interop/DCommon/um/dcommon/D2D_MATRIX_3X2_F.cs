// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dcommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Represents a 3-by-2 matrix.</summary>
    public unsafe struct D2D_MATRIX_3X2_F
    {
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public _Anonymous1_e__Struct Anonymous1;

            [FieldOffset(0)]
            public _Anonymous2_e__Struct Anonymous2;

            [FieldOffset(0)]
            [NativeTypeName("FLOAT[3][2]")]
            public fixed float m[3 * 2];

            public struct _Anonymous1_e__Struct
            {
                /// <summary>Horizontal scaling / cosine of rotation</summary>
                public float m11;

                /// <summary>Vertical shear / sine of rotation</summary>
                public float m12;

                /// <summary>Horizontal shear / negative sine of rotation</summary>
                public float m21;

                /// <summary>Vertical scaling / cosine of rotation</summary>
                public float m22;

                /// <summary>Horizontal shift (always orthogonal regardless of rotation)</summary>
                public float dx;

                /// <summary>Vertical shift (always orthogonal regardless of rotation)</summary>
                public float dy;
            }

            public struct _Anonymous2_e__Struct
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
