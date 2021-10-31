// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public unsafe partial struct D2D_MATRIX_4X4_F : IEquatable<D2D_MATRIX_4X4_F>
    {
        public D2D_MATRIX_4X4_F(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
        {
            this = default;

            Anonymous.Anonymous._11 = m11;
            Anonymous.Anonymous._12 = m12;
            Anonymous.Anonymous._13 = m13;
            Anonymous.Anonymous._14 = m14;
            Anonymous.Anonymous._21 = m21;
            Anonymous.Anonymous._22 = m22;
            Anonymous.Anonymous._23 = m23;
            Anonymous.Anonymous._24 = m24;
            Anonymous.Anonymous._31 = m31;
            Anonymous.Anonymous._32 = m32;
            Anonymous.Anonymous._33 = m33;
            Anonymous.Anonymous._34 = m34;
            Anonymous.Anonymous._41 = m41;
            Anonymous.Anonymous._42 = m42;
            Anonymous.Anonymous._43 = m43;
            Anonymous.Anonymous._44 = m44;
        }

        public static ref readonly D2D_MATRIX_4X4_F Identity
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0x80, 0x3F,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x80, 0x3F,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x80, 0x3F,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x80, 0x3F,
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<D2D_MATRIX_4X4_F>());
                return ref Unsafe.As<byte, D2D_MATRIX_4X4_F>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static bool operator ==([NativeTypeName("const D2D1_MATRIX_4X4_F &")] in D2D_MATRIX_4X4_F l, [NativeTypeName("const D2D1_MATRIX_4X4_F &")] in D2D_MATRIX_4X4_F r)
        {
            return l.Anonymous.Anonymous._11 == r.Anonymous.Anonymous._11 && l.Anonymous.Anonymous._12 == r.Anonymous.Anonymous._12 && l.Anonymous.Anonymous._13 == r.Anonymous.Anonymous._13 && l.Anonymous.Anonymous._14 == r.Anonymous.Anonymous._14 && l.Anonymous.Anonymous._21 == r.Anonymous.Anonymous._21 && l.Anonymous.Anonymous._22 == r.Anonymous.Anonymous._22 && l.Anonymous.Anonymous._23 == r.Anonymous.Anonymous._23 && l.Anonymous.Anonymous._24 == r.Anonymous.Anonymous._24 && l.Anonymous.Anonymous._31 == r.Anonymous.Anonymous._31 && l.Anonymous.Anonymous._32 == r.Anonymous.Anonymous._32 && l.Anonymous.Anonymous._33 == r.Anonymous.Anonymous._33 && l.Anonymous.Anonymous._34 == r.Anonymous.Anonymous._34 && l.Anonymous.Anonymous._41 == r.Anonymous.Anonymous._41 && l.Anonymous.Anonymous._42 == r.Anonymous.Anonymous._42 && l.Anonymous.Anonymous._43 == r.Anonymous.Anonymous._43 && l.Anonymous.Anonymous._44 == r.Anonymous.Anonymous._44;
        }

        public static bool operator !=([NativeTypeName("const D2D1_MATRIX_4X4_F &")] in D2D_MATRIX_4X4_F l, [NativeTypeName("const D2D1_MATRIX_4X4_F &")] in D2D_MATRIX_4X4_F r)
        {
            return !(l == r);
        }

        public static D2D_MATRIX_4X4_F Translation(float x, float y, float z)
        {
            D2D_MATRIX_4X4_F translation = default;

            translation.Anonymous.Anonymous._11 = 1.0f;
            translation.Anonymous.Anonymous._12 = 0.0f;
            translation.Anonymous.Anonymous._13 = 0.0f;
            translation.Anonymous.Anonymous._14 = 0.0f;
            translation.Anonymous.Anonymous._21 = 0.0f;
            translation.Anonymous.Anonymous._22 = 1.0f;
            translation.Anonymous.Anonymous._23 = 0.0f;
            translation.Anonymous.Anonymous._24 = 0.0f;
            translation.Anonymous.Anonymous._31 = 0.0f;
            translation.Anonymous.Anonymous._32 = 0.0f;
            translation.Anonymous.Anonymous._33 = 1.0f;
            translation.Anonymous.Anonymous._34 = 0.0f;
            translation.Anonymous.Anonymous._41 = x;
            translation.Anonymous.Anonymous._42 = y;
            translation.Anonymous.Anonymous._43 = z;
            translation.Anonymous.Anonymous._44 = 1.0f;

            return translation;
        }

        public static D2D_MATRIX_4X4_F Scale(float x, float y, float z)
        {
            D2D_MATRIX_4X4_F scale = default;

            scale.Anonymous.Anonymous._11 = x;
            scale.Anonymous.Anonymous._12 = 0.0f;
            scale.Anonymous.Anonymous._13 = 0.0f;
            scale.Anonymous.Anonymous._14 = 0.0f;
            scale.Anonymous.Anonymous._21 = 0.0f;
            scale.Anonymous.Anonymous._22 = y;
            scale.Anonymous.Anonymous._23 = 0.0f;
            scale.Anonymous.Anonymous._24 = 0.0f;
            scale.Anonymous.Anonymous._31 = 0.0f;
            scale.Anonymous.Anonymous._32 = 0.0f;
            scale.Anonymous.Anonymous._33 = z;
            scale.Anonymous.Anonymous._34 = 0.0f;
            scale.Anonymous.Anonymous._41 = 0.0f;
            scale.Anonymous.Anonymous._42 = 0.0f;
            scale.Anonymous.Anonymous._43 = 0.0f;
            scale.Anonymous.Anonymous._44 = 1.0f;

            return scale;
        }

        public static D2D_MATRIX_4X4_F RotationX(float degreeX)
        {
            float angleInRadian = degreeX * (MathF.PI / 180.0f);
            float sinAngle = 0.0f;
            float cosAngle = 0.0f;

            D2D1SinCos(angleInRadian, &sinAngle, &cosAngle);

            D2D_MATRIX_4X4_F rotationX = new D2D_MATRIX_4X4_F(1, 0, 0, 0, 0, cosAngle, sinAngle, 0, 0, -sinAngle, cosAngle, 0, 0, 0, 0, 1);

            return rotationX;
        }

        public static D2D_MATRIX_4X4_F RotationY(float degreeY)
        {
            float angleInRadian = degreeY * (MathF.PI / 180.0f);
            float sinAngle = 0.0f;
            float cosAngle = 0.0f;

            D2D1SinCos(angleInRadian, &sinAngle, &cosAngle);

            D2D_MATRIX_4X4_F rotationY = new D2D_MATRIX_4X4_F(cosAngle, 0, -sinAngle, 0, 0, 1, 0, 0, sinAngle, 0, cosAngle, 0, 0, 0, 0, 1);

            return rotationY;
        }

        public static D2D_MATRIX_4X4_F RotationZ(float degreeZ)
        {
            float angleInRadian = degreeZ * (MathF.PI / 180.0f);
            float sinAngle = 0.0f;
            float cosAngle = 0.0f;

            D2D1SinCos(angleInRadian, &sinAngle, &cosAngle);

            D2D_MATRIX_4X4_F rotationZ = new D2D_MATRIX_4X4_F(cosAngle, sinAngle, 0, 0, -sinAngle, cosAngle, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);

            return rotationZ;
        }

        public static D2D_MATRIX_4X4_F RotationArbitraryAxis(float x, float y, float z, float degree)
        {
            float magnitude = D2D1Vec3Length(x, y, z);

            x /= magnitude;
            y /= magnitude;
            z /= magnitude;

            float angleInRadian = degree * (3.141592654f / 180.0f);
            float sinAngle = 0.0f;
            float cosAngle = 0.0f;

            D2D1SinCos(angleInRadian, &sinAngle, &cosAngle);

            float oneMinusCosAngle = 1 - cosAngle;
            D2D_MATRIX_4X4_F rotationArb = new D2D_MATRIX_4X4_F(1 + oneMinusCosAngle * (x * x - 1), z * sinAngle + oneMinusCosAngle * x * y, -y * sinAngle + oneMinusCosAngle * x * z, 0, -z * sinAngle + oneMinusCosAngle * y * x, 1 + oneMinusCosAngle * (y * y - 1), x * sinAngle + oneMinusCosAngle * y * z, 0, y * sinAngle + oneMinusCosAngle * z * x, -x * sinAngle + oneMinusCosAngle * z * y, 1 + oneMinusCosAngle * (z * z - 1), 0, 0, 0, 0, 1);

            return rotationArb;
        }

        public static D2D_MATRIX_4X4_F SkewX(float degreeX)
        {
            float angleInRadian = degreeX * (3.141592654f / 180.0f);
            float tanAngle = D2D1Tan(angleInRadian);

            D2D_MATRIX_4X4_F skewX = new D2D_MATRIX_4X4_F(1, 0, 0, 0, tanAngle, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);

            return skewX;
        }

        public static D2D_MATRIX_4X4_F SkewY(float degreeY)
        {
            float angleInRadian = degreeY * (3.141592654f / 180.0f);
            float tanAngle = D2D1Tan(angleInRadian);

            D2D_MATRIX_4X4_F skewY = new D2D_MATRIX_4X4_F(1, tanAngle, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);

            return skewY;
        }

        public static D2D_MATRIX_4X4_F PerspectiveProjection(float depth)
        {
            float proj = 0;

            if (depth > 0)
            {
                proj = -1 / depth;
            }

            D2D_MATRIX_4X4_F projection = new D2D_MATRIX_4X4_F(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, proj, 0, 0, 0, 1);

            return projection;
        }

        public float Determinant
        {
            get
            {
                float minor1 = Anonymous.Anonymous._41 * (Anonymous.Anonymous._12 * (Anonymous.Anonymous._23 * Anonymous.Anonymous._34 - Anonymous.Anonymous._33 * Anonymous.Anonymous._24) - Anonymous.Anonymous._13 * (Anonymous.Anonymous._22 * Anonymous.Anonymous._34 - Anonymous.Anonymous._24 * Anonymous.Anonymous._32) + Anonymous.Anonymous._14 * (Anonymous.Anonymous._22 * Anonymous.Anonymous._33 - Anonymous.Anonymous._23 * Anonymous.Anonymous._32));
                float minor2 = Anonymous.Anonymous._42 * (Anonymous.Anonymous._11 * (Anonymous.Anonymous._21 * Anonymous.Anonymous._34 - Anonymous.Anonymous._31 * Anonymous.Anonymous._24) - Anonymous.Anonymous._13 * (Anonymous.Anonymous._21 * Anonymous.Anonymous._34 - Anonymous.Anonymous._24 * Anonymous.Anonymous._31) + Anonymous.Anonymous._14 * (Anonymous.Anonymous._21 * Anonymous.Anonymous._33 - Anonymous.Anonymous._23 * Anonymous.Anonymous._31));
                float minor3 = Anonymous.Anonymous._43 * (Anonymous.Anonymous._11 * (Anonymous.Anonymous._22 * Anonymous.Anonymous._34 - Anonymous.Anonymous._32 * Anonymous.Anonymous._24) - Anonymous.Anonymous._12 * (Anonymous.Anonymous._21 * Anonymous.Anonymous._34 - Anonymous.Anonymous._24 * Anonymous.Anonymous._31) + Anonymous.Anonymous._14 * (Anonymous.Anonymous._21 * Anonymous.Anonymous._32 - Anonymous.Anonymous._22 * Anonymous.Anonymous._31));
                float minor4 = Anonymous.Anonymous._44 * (Anonymous.Anonymous._11 * (Anonymous.Anonymous._22 * Anonymous.Anonymous._33 - Anonymous.Anonymous._32 * Anonymous.Anonymous._23) - Anonymous.Anonymous._12 * (Anonymous.Anonymous._21 * Anonymous.Anonymous._33 - Anonymous.Anonymous._23 * Anonymous.Anonymous._31) + Anonymous.Anonymous._13 * (Anonymous.Anonymous._21 * Anonymous.Anonymous._32 - Anonymous.Anonymous._22 * Anonymous.Anonymous._31));

                return minor1 - minor2 + minor3 - minor4;
            }
        }

        public bool IsIdentity
        {
            get
            {
                return Anonymous.Anonymous._11 == 1.0f && Anonymous.Anonymous._12 == 0.0f && Anonymous.Anonymous._13 == 0.0f && Anonymous.Anonymous._14 == 0.0f && Anonymous.Anonymous._21 == 0.0f && Anonymous.Anonymous._22 == 1.0f && Anonymous.Anonymous._23 == 0.0f && Anonymous.Anonymous._24 == 0.0f && Anonymous.Anonymous._31 == 0.0f && Anonymous.Anonymous._32 == 0.0f && Anonymous.Anonymous._33 == 1.0f && Anonymous.Anonymous._34 == 0.0f && Anonymous.Anonymous._41 == 0.0f && Anonymous.Anonymous._42 == 0.0f && Anonymous.Anonymous._43 == 0.0f && Anonymous.Anonymous._44 == 1.0f;
            }
        }

        public void SetProduct([NativeTypeName("const D2D1_MATRIX_4x4_F &")] in D2D_MATRIX_4X4_F a, [NativeTypeName("const D2D1_MATRIX_4x4_F &")] in D2D_MATRIX_4X4_F b)
        {
            Anonymous.Anonymous._11 = a.Anonymous.Anonymous._11 * b.Anonymous.Anonymous._11 + a.Anonymous.Anonymous._12 * b.Anonymous.Anonymous._21 + a.Anonymous.Anonymous._13 * b.Anonymous.Anonymous._31 + a.Anonymous.Anonymous._14 * b.Anonymous.Anonymous._41;
            Anonymous.Anonymous._12 = a.Anonymous.Anonymous._11 * b.Anonymous.Anonymous._12 + a.Anonymous.Anonymous._12 * b.Anonymous.Anonymous._22 + a.Anonymous.Anonymous._13 * b.Anonymous.Anonymous._32 + a.Anonymous.Anonymous._14 * b.Anonymous.Anonymous._42;
            Anonymous.Anonymous._13 = a.Anonymous.Anonymous._11 * b.Anonymous.Anonymous._13 + a.Anonymous.Anonymous._12 * b.Anonymous.Anonymous._23 + a.Anonymous.Anonymous._13 * b.Anonymous.Anonymous._33 + a.Anonymous.Anonymous._14 * b.Anonymous.Anonymous._43;
            Anonymous.Anonymous._14 = a.Anonymous.Anonymous._11 * b.Anonymous.Anonymous._14 + a.Anonymous.Anonymous._12 * b.Anonymous.Anonymous._24 + a.Anonymous.Anonymous._13 * b.Anonymous.Anonymous._34 + a.Anonymous.Anonymous._14 * b.Anonymous.Anonymous._44;
            Anonymous.Anonymous._21 = a.Anonymous.Anonymous._21 * b.Anonymous.Anonymous._11 + a.Anonymous.Anonymous._22 * b.Anonymous.Anonymous._21 + a.Anonymous.Anonymous._23 * b.Anonymous.Anonymous._31 + a.Anonymous.Anonymous._24 * b.Anonymous.Anonymous._41;
            Anonymous.Anonymous._22 = a.Anonymous.Anonymous._21 * b.Anonymous.Anonymous._12 + a.Anonymous.Anonymous._22 * b.Anonymous.Anonymous._22 + a.Anonymous.Anonymous._23 * b.Anonymous.Anonymous._32 + a.Anonymous.Anonymous._24 * b.Anonymous.Anonymous._42;
            Anonymous.Anonymous._23 = a.Anonymous.Anonymous._21 * b.Anonymous.Anonymous._13 + a.Anonymous.Anonymous._22 * b.Anonymous.Anonymous._23 + a.Anonymous.Anonymous._23 * b.Anonymous.Anonymous._33 + a.Anonymous.Anonymous._24 * b.Anonymous.Anonymous._43;
            Anonymous.Anonymous._24 = a.Anonymous.Anonymous._21 * b.Anonymous.Anonymous._14 + a.Anonymous.Anonymous._22 * b.Anonymous.Anonymous._24 + a.Anonymous.Anonymous._23 * b.Anonymous.Anonymous._34 + a.Anonymous.Anonymous._24 * b.Anonymous.Anonymous._44;
            Anonymous.Anonymous._31 = a.Anonymous.Anonymous._31 * b.Anonymous.Anonymous._11 + a.Anonymous.Anonymous._32 * b.Anonymous.Anonymous._21 + a.Anonymous.Anonymous._33 * b.Anonymous.Anonymous._31 + a.Anonymous.Anonymous._34 * b.Anonymous.Anonymous._41;
            Anonymous.Anonymous._32 = a.Anonymous.Anonymous._31 * b.Anonymous.Anonymous._12 + a.Anonymous.Anonymous._32 * b.Anonymous.Anonymous._22 + a.Anonymous.Anonymous._33 * b.Anonymous.Anonymous._32 + a.Anonymous.Anonymous._34 * b.Anonymous.Anonymous._42;
            Anonymous.Anonymous._33 = a.Anonymous.Anonymous._31 * b.Anonymous.Anonymous._13 + a.Anonymous.Anonymous._32 * b.Anonymous.Anonymous._23 + a.Anonymous.Anonymous._33 * b.Anonymous.Anonymous._33 + a.Anonymous.Anonymous._34 * b.Anonymous.Anonymous._43;
            Anonymous.Anonymous._34 = a.Anonymous.Anonymous._31 * b.Anonymous.Anonymous._14 + a.Anonymous.Anonymous._32 * b.Anonymous.Anonymous._24 + a.Anonymous.Anonymous._33 * b.Anonymous.Anonymous._34 + a.Anonymous.Anonymous._34 * b.Anonymous.Anonymous._44;
            Anonymous.Anonymous._41 = a.Anonymous.Anonymous._41 * b.Anonymous.Anonymous._11 + a.Anonymous.Anonymous._42 * b.Anonymous.Anonymous._21 + a.Anonymous.Anonymous._43 * b.Anonymous.Anonymous._31 + a.Anonymous.Anonymous._44 * b.Anonymous.Anonymous._41;
            Anonymous.Anonymous._42 = a.Anonymous.Anonymous._41 * b.Anonymous.Anonymous._12 + a.Anonymous.Anonymous._42 * b.Anonymous.Anonymous._22 + a.Anonymous.Anonymous._43 * b.Anonymous.Anonymous._32 + a.Anonymous.Anonymous._44 * b.Anonymous.Anonymous._42;
            Anonymous.Anonymous._43 = a.Anonymous.Anonymous._41 * b.Anonymous.Anonymous._13 + a.Anonymous.Anonymous._42 * b.Anonymous.Anonymous._23 + a.Anonymous.Anonymous._43 * b.Anonymous.Anonymous._33 + a.Anonymous.Anonymous._44 * b.Anonymous.Anonymous._43;
            Anonymous.Anonymous._44 = a.Anonymous.Anonymous._41 * b.Anonymous.Anonymous._14 + a.Anonymous.Anonymous._42 * b.Anonymous.Anonymous._24 + a.Anonymous.Anonymous._43 * b.Anonymous.Anonymous._34 + a.Anonymous.Anonymous._44 * b.Anonymous.Anonymous._44;
        }

        public static D2D_MATRIX_4X4_F operator *([NativeTypeName("const D2D1_MATRIX_4x4_F &")] in D2D_MATRIX_4X4_F a, [NativeTypeName("const D2D1_MATRIX_4x4_F &")] in D2D_MATRIX_4X4_F b)
        {
            D2D_MATRIX_4X4_F result = default;

            result.SetProduct(a, b);

            return result;
        }

        public bool Equals(D2D_MATRIX_4X4_F other) => this == other;

        public override bool Equals(object? obj) => (obj is D2D_MATRIX_4X4_F other) && this == other;

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            {
                hashCode.Add(Anonymous.Anonymous._11);
                hashCode.Add(Anonymous.Anonymous._12);
                hashCode.Add(Anonymous.Anonymous._13);
                hashCode.Add(Anonymous.Anonymous._14);
                hashCode.Add(Anonymous.Anonymous._21);
                hashCode.Add(Anonymous.Anonymous._22);
                hashCode.Add(Anonymous.Anonymous._23);
                hashCode.Add(Anonymous.Anonymous._24);
                hashCode.Add(Anonymous.Anonymous._31);
                hashCode.Add(Anonymous.Anonymous._32);
                hashCode.Add(Anonymous.Anonymous._33);
                hashCode.Add(Anonymous.Anonymous._34);
                hashCode.Add(Anonymous.Anonymous._41);
                hashCode.Add(Anonymous.Anonymous._42);
                hashCode.Add(Anonymous.Anonymous._43);
                hashCode.Add(Anonymous.Anonymous._44);
            }
            return hashCode.ToHashCode();
        }
    }
}
