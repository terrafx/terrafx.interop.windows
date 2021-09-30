// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D2D_MATRIX_4X3_F : IEquatable<D2D_MATRIX_4X3_F>
    {
        public D2D_MATRIX_4X3_F([NativeTypeName("FLOAT")] float m11, [NativeTypeName("FLOAT")] float m12, [NativeTypeName("FLOAT")] float m13, [NativeTypeName("FLOAT")] float m21, [NativeTypeName("FLOAT")] float m22, [NativeTypeName("FLOAT")] float m23, [NativeTypeName("FLOAT")] float m31, [NativeTypeName("FLOAT")] float m32, [NativeTypeName("FLOAT")] float m33, [NativeTypeName("FLOAT")] float m41, [NativeTypeName("FLOAT")] float m42, [NativeTypeName("FLOAT")] float m43)
        {
            this = default;

            Anonymous.Anonymous._11 = m11;
            Anonymous.Anonymous._12 = m12;
            Anonymous.Anonymous._13 = m13;
            Anonymous.Anonymous._21 = m21;
            Anonymous.Anonymous._22 = m22;
            Anonymous.Anonymous._23 = m23;
            Anonymous.Anonymous._31 = m31;
            Anonymous.Anonymous._32 = m32;
            Anonymous.Anonymous._33 = m33;
            Anonymous.Anonymous._41 = m41;
            Anonymous.Anonymous._42 = m42;
            Anonymous.Anonymous._43 = m43;
        }

        public static ref readonly D2D_MATRIX_4X3_F Identity
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0x80, 0x3F,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x80, 0x3F,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x80, 0x3F,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<D2D_MATRIX_4X3_F>());
                return ref Unsafe.As<byte, D2D_MATRIX_4X3_F>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static bool operator ==([NativeTypeName("const D2D_MATRIX_4X3_F &")] in D2D_MATRIX_4X3_F l, [NativeTypeName("const D2D_MATRIX_4X3_F &")] in D2D_MATRIX_4X3_F r)
        {
            return l.Anonymous.Anonymous._11 == r.Anonymous.Anonymous._11 && l.Anonymous.Anonymous._12 == r.Anonymous.Anonymous._12 && l.Anonymous.Anonymous._13 == r.Anonymous.Anonymous._13 && l.Anonymous.Anonymous._21 == r.Anonymous.Anonymous._21 && l.Anonymous.Anonymous._22 == r.Anonymous.Anonymous._22 && l.Anonymous.Anonymous._23 == r.Anonymous.Anonymous._23 && l.Anonymous.Anonymous._31 == r.Anonymous.Anonymous._31 && l.Anonymous.Anonymous._32 == r.Anonymous.Anonymous._32 && l.Anonymous.Anonymous._33 == r.Anonymous.Anonymous._33 && l.Anonymous.Anonymous._41 == r.Anonymous.Anonymous._41 && l.Anonymous.Anonymous._42 == r.Anonymous.Anonymous._42 && l.Anonymous.Anonymous._43 == r.Anonymous.Anonymous._43;
        }

        public static bool operator !=([NativeTypeName("const D2D_MATRIX_4X3_F &")] in D2D_MATRIX_4X3_F l, [NativeTypeName("const D2D_MATRIX_4X3_F &")] in D2D_MATRIX_4X3_F r)
        {
            return !(l == r);
        }

        public bool Equals(D2D_MATRIX_4X3_F other) => this == other;

        public override bool Equals(object? obj) => (obj is D2D_MATRIX_4X3_F other) && this == other;

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            {
                hashCode.Add(Anonymous.Anonymous._11);
                hashCode.Add(Anonymous.Anonymous._12);
                hashCode.Add(Anonymous.Anonymous._13);
                hashCode.Add(Anonymous.Anonymous._21);
                hashCode.Add(Anonymous.Anonymous._22);
                hashCode.Add(Anonymous.Anonymous._23);
                hashCode.Add(Anonymous.Anonymous._31);
                hashCode.Add(Anonymous.Anonymous._32);
                hashCode.Add(Anonymous.Anonymous._33);
                hashCode.Add(Anonymous.Anonymous._41);
                hashCode.Add(Anonymous.Anonymous._42);
                hashCode.Add(Anonymous.Anonymous._43);
            }
            return hashCode.ToHashCode();
        }
    }
}
