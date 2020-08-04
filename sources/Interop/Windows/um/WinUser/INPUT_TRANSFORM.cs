// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct INPUT_TRANSFORM
    {
        [NativeTypeName("tagINPUT_TRANSFORM::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/WinUser.h:6802:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref float _11 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._11, 1));

        public ref float _12 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._12, 1));

        public ref float _13 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._13, 1));

        public ref float _14 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._14, 1));

        public ref float _21 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._21, 1));

        public ref float _22 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._22, 1));

        public ref float _23 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._23, 1));

        public ref float _24 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._24, 1));

        public ref float _31 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._31, 1));

        public ref float _32 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._32, 1));

        public ref float _33 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._33, 1));

        public ref float _34 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._34, 1));

        public ref float _41 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._41, 1));

        public ref float _42 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._42, 1));

        public ref float _43 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._43, 1));

        public ref float _44 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._44, 1));

        public Span<float> m => MemoryMarshal.CreateSpan(ref Anonymous.m[0], 4);

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("tagINPUT_TRANSFORM::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/WinUser.h:6803:9)")]
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
