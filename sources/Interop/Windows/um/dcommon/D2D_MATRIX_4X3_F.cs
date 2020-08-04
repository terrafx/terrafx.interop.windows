// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct D2D_MATRIX_4X3_F
    {
        [NativeTypeName("D2D_MATRIX_4X3_F::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/dcommon.h:331:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref float _11 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._11, 1));

        public ref float _12 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._12, 1));

        public ref float _13 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._13, 1));

        public ref float _21 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._21, 1));

        public ref float _22 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._22, 1));

        public ref float _23 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._23, 1));

        public ref float _31 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._31, 1));

        public ref float _32 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._32, 1));

        public ref float _33 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._33, 1));

        public ref float _41 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._41, 1));

        public ref float _42 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._42, 1));

        public ref float _43 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._43, 1));

        public Span<float> m => MemoryMarshal.CreateSpan(ref Anonymous.m[0], 4);

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("D2D_MATRIX_4X3_F::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/dcommon.h:333:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("FLOAT [4][3]")]
            public fixed float m[4 * 3];

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("FLOAT")]
                public float _11;

                [NativeTypeName("FLOAT")]
                public float _12;

                [NativeTypeName("FLOAT")]
                public float _13;

                [NativeTypeName("FLOAT")]
                public float _21;

                [NativeTypeName("FLOAT")]
                public float _22;

                [NativeTypeName("FLOAT")]
                public float _23;

                [NativeTypeName("FLOAT")]
                public float _31;

                [NativeTypeName("FLOAT")]
                public float _32;

                [NativeTypeName("FLOAT")]
                public float _33;

                [NativeTypeName("FLOAT")]
                public float _41;

                [NativeTypeName("FLOAT")]
                public float _42;

                [NativeTypeName("FLOAT")]
                public float _43;
            }
        }
    }
}
