// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct D2D_MATRIX_3X2_F
    {
        [NativeTypeName("D2D_MATRIX_3X2_F::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/dcommon.h:277:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref float m11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous1.m11, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous1))->m11;
#endif
            }
        }

        public unsafe ref float m12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous1.m12, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous1))->m12;
#endif
            }
        }

        public unsafe ref float m21
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous1.m21, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous1))->m21;
#endif
            }
        }

        public unsafe ref float m22
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous1.m22, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous1))->m22;
#endif
            }
        }

        public unsafe ref float dx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous1.dx, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous1))->dx;
#endif
            }
        }

        public unsafe ref float dy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous1.dy, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous1))->dy;
#endif
            }
        }

        public unsafe ref float _11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous2._11, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous2_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous2))->_11;
#endif
            }
        }

        public unsafe ref float _12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous2._12, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous2_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous2))->_12;
#endif
            }
        }

        public unsafe ref float _21
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous2._21, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous2_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous2))->_21;
#endif
            }
        }

        public unsafe ref float _22
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous2._22, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous2_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous2))->_22;
#endif
            }
        }

        public unsafe ref float _31
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous2._31, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous2_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous2))->_31;
#endif
            }
        }

        public unsafe ref float _32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous2._32, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous2_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous2))->_32;
#endif
            }
        }

        public unsafe Span<float> m
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref Anonymous.m[0], 3);
#else
                return new Span<float>(((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->m, 3);
#endif
            }
        }

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
