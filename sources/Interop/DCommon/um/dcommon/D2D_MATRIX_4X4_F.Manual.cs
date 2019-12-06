// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.D2D1;

namespace TerraFX.Interop
{
    public unsafe partial struct D2D_MATRIX_4X4_F : IEquatable<D2D_MATRIX_4X4_F>
    {
        public static readonly D2D_MATRIX_4X4_F DEFAULT = new D2D_MATRIX_4X4_F(
            1.0f, 0.0f, 0.0f, 0.0f,
            0.0f, 1.0f, 0.0f, 0.0f,
            0.0f, 0.0f, 1.0f, 0.0f,
            0.0f, 0.0f, 0.0f, 1.0f);

        public D2D_MATRIX_4X4_F(
            float m11, float m12, float m13, float m14,
            float m21, float m22, float m23, float m24,
            float m31, float m32, float m33, float m34,
            float m41, float m42, float m43, float m44) : this()
        {
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

        public float Determinant
        {
            get
            {
                var minor1 = Anonymous.Anonymous._41 * ((Anonymous.Anonymous._12 * ((Anonymous.Anonymous._23 * Anonymous.Anonymous._34) - (Anonymous.Anonymous._33 * Anonymous.Anonymous._24))) - (Anonymous.Anonymous._13 * ((Anonymous.Anonymous._22 * Anonymous.Anonymous._34) - (Anonymous.Anonymous._24 * Anonymous.Anonymous._32))) + (Anonymous.Anonymous._14 * ((Anonymous.Anonymous._22 * Anonymous.Anonymous._33) - (Anonymous.Anonymous._23 * Anonymous.Anonymous._32))));
                var minor2 = Anonymous.Anonymous._42 * ((Anonymous.Anonymous._11 * ((Anonymous.Anonymous._21 * Anonymous.Anonymous._34) - (Anonymous.Anonymous._31 * Anonymous.Anonymous._24))) - (Anonymous.Anonymous._13 * ((Anonymous.Anonymous._21 * Anonymous.Anonymous._34) - (Anonymous.Anonymous._24 * Anonymous.Anonymous._31))) + (Anonymous.Anonymous._14 * ((Anonymous.Anonymous._21 * Anonymous.Anonymous._33) - (Anonymous.Anonymous._23 * Anonymous.Anonymous._31))));
                var minor3 = Anonymous.Anonymous._43 * ((Anonymous.Anonymous._11 * ((Anonymous.Anonymous._22 * Anonymous.Anonymous._34) - (Anonymous.Anonymous._32 * Anonymous.Anonymous._24))) - (Anonymous.Anonymous._12 * ((Anonymous.Anonymous._21 * Anonymous.Anonymous._34) - (Anonymous.Anonymous._24 * Anonymous.Anonymous._31))) + (Anonymous.Anonymous._14 * ((Anonymous.Anonymous._21 * Anonymous.Anonymous._32) - (Anonymous.Anonymous._22 * Anonymous.Anonymous._31))));
                var minor4 = Anonymous.Anonymous._44 * ((Anonymous.Anonymous._11 * ((Anonymous.Anonymous._22 * Anonymous.Anonymous._33) - (Anonymous.Anonymous._32 * Anonymous.Anonymous._23))) - (Anonymous.Anonymous._12 * ((Anonymous.Anonymous._21 * Anonymous.Anonymous._33) - (Anonymous.Anonymous._23 * Anonymous.Anonymous._31))) + (Anonymous.Anonymous._13 * ((Anonymous.Anonymous._21 * Anonymous.Anonymous._32) - (Anonymous.Anonymous._22 * Anonymous.Anonymous._31))));

                return minor1 - minor2 + minor3 - minor4;
            }
        }

        public bool IsIdentity =>
            Anonymous.Anonymous._11 == 1.0f && Anonymous.Anonymous._12 == 0.0f && Anonymous.Anonymous._13 == 0.0f && Anonymous.Anonymous._14 == 0.0f &&
            Anonymous.Anonymous._21 == 0.0f && Anonymous.Anonymous._22 == 1.0f && Anonymous.Anonymous._23 == 0.0f && Anonymous.Anonymous._24 == 0.0f &&
            Anonymous.Anonymous._31 == 0.0f && Anonymous.Anonymous._32 == 0.0f && Anonymous.Anonymous._33 == 1.0f && Anonymous.Anonymous._34 == 0.0f &&
            Anonymous.Anonymous._41 == 0.0f && Anonymous.Anonymous._42 == 0.0f && Anonymous.Anonymous._43 == 0.0f && Anonymous.Anonymous._44 == 1.0f;

        public void SetProduct(in D2D_MATRIX_4X4_F a, in D2D_MATRIX_4X4_F b)
        {
            Anonymous.Anonymous._11 = (a.Anonymous.Anonymous._11 * b.Anonymous.Anonymous._11) + (a.Anonymous.Anonymous._12 * b.Anonymous.Anonymous._21) + (a.Anonymous.Anonymous._13 * b.Anonymous.Anonymous._31) + (a.Anonymous.Anonymous._14 * b.Anonymous.Anonymous._41);
            Anonymous.Anonymous._12 = (a.Anonymous.Anonymous._11 * b.Anonymous.Anonymous._12) + (a.Anonymous.Anonymous._12 * b.Anonymous.Anonymous._22) + (a.Anonymous.Anonymous._13 * b.Anonymous.Anonymous._32) + (a.Anonymous.Anonymous._14 * b.Anonymous.Anonymous._42);
            Anonymous.Anonymous._13 = (a.Anonymous.Anonymous._11 * b.Anonymous.Anonymous._13) + (a.Anonymous.Anonymous._12 * b.Anonymous.Anonymous._23) + (a.Anonymous.Anonymous._13 * b.Anonymous.Anonymous._33) + (a.Anonymous.Anonymous._14 * b.Anonymous.Anonymous._43);
            Anonymous.Anonymous._14 = (a.Anonymous.Anonymous._11 * b.Anonymous.Anonymous._14) + (a.Anonymous.Anonymous._12 * b.Anonymous.Anonymous._24) + (a.Anonymous.Anonymous._13 * b.Anonymous.Anonymous._34) + (a.Anonymous.Anonymous._14 * b.Anonymous.Anonymous._44);

            Anonymous.Anonymous._21 = (a.Anonymous.Anonymous._21 * b.Anonymous.Anonymous._11) + (a.Anonymous.Anonymous._22 * b.Anonymous.Anonymous._21) + (a.Anonymous.Anonymous._23 * b.Anonymous.Anonymous._31) + (a.Anonymous.Anonymous._24 * b.Anonymous.Anonymous._41);
            Anonymous.Anonymous._22 = (a.Anonymous.Anonymous._21 * b.Anonymous.Anonymous._12) + (a.Anonymous.Anonymous._22 * b.Anonymous.Anonymous._22) + (a.Anonymous.Anonymous._23 * b.Anonymous.Anonymous._32) + (a.Anonymous.Anonymous._24 * b.Anonymous.Anonymous._42);
            Anonymous.Anonymous._23 = (a.Anonymous.Anonymous._21 * b.Anonymous.Anonymous._13) + (a.Anonymous.Anonymous._22 * b.Anonymous.Anonymous._23) + (a.Anonymous.Anonymous._23 * b.Anonymous.Anonymous._33) + (a.Anonymous.Anonymous._24 * b.Anonymous.Anonymous._43);
            Anonymous.Anonymous._24 = (a.Anonymous.Anonymous._21 * b.Anonymous.Anonymous._14) + (a.Anonymous.Anonymous._22 * b.Anonymous.Anonymous._24) + (a.Anonymous.Anonymous._23 * b.Anonymous.Anonymous._34) + (a.Anonymous.Anonymous._24 * b.Anonymous.Anonymous._44);

            Anonymous.Anonymous._31 = (a.Anonymous.Anonymous._31 * b.Anonymous.Anonymous._11) + (a.Anonymous.Anonymous._32 * b.Anonymous.Anonymous._21) + (a.Anonymous.Anonymous._33 * b.Anonymous.Anonymous._31) + (a.Anonymous.Anonymous._34 * b.Anonymous.Anonymous._41);
            Anonymous.Anonymous._32 = (a.Anonymous.Anonymous._31 * b.Anonymous.Anonymous._12) + (a.Anonymous.Anonymous._32 * b.Anonymous.Anonymous._22) + (a.Anonymous.Anonymous._33 * b.Anonymous.Anonymous._32) + (a.Anonymous.Anonymous._34 * b.Anonymous.Anonymous._42);
            Anonymous.Anonymous._33 = (a.Anonymous.Anonymous._31 * b.Anonymous.Anonymous._13) + (a.Anonymous.Anonymous._32 * b.Anonymous.Anonymous._23) + (a.Anonymous.Anonymous._33 * b.Anonymous.Anonymous._33) + (a.Anonymous.Anonymous._34 * b.Anonymous.Anonymous._43);
            Anonymous.Anonymous._34 = (a.Anonymous.Anonymous._31 * b.Anonymous.Anonymous._14) + (a.Anonymous.Anonymous._32 * b.Anonymous.Anonymous._24) + (a.Anonymous.Anonymous._33 * b.Anonymous.Anonymous._34) + (a.Anonymous.Anonymous._34 * b.Anonymous.Anonymous._44);

            Anonymous.Anonymous._41 = (a.Anonymous.Anonymous._41 * b.Anonymous.Anonymous._11) + (a.Anonymous.Anonymous._42 * b.Anonymous.Anonymous._21) + (a.Anonymous.Anonymous._43 * b.Anonymous.Anonymous._31) + (a.Anonymous.Anonymous._44 * b.Anonymous.Anonymous._41);
            Anonymous.Anonymous._42 = (a.Anonymous.Anonymous._41 * b.Anonymous.Anonymous._12) + (a.Anonymous.Anonymous._42 * b.Anonymous.Anonymous._22) + (a.Anonymous.Anonymous._43 * b.Anonymous.Anonymous._32) + (a.Anonymous.Anonymous._44 * b.Anonymous.Anonymous._42);
            Anonymous.Anonymous._43 = (a.Anonymous.Anonymous._41 * b.Anonymous.Anonymous._13) + (a.Anonymous.Anonymous._42 * b.Anonymous.Anonymous._23) + (a.Anonymous.Anonymous._43 * b.Anonymous.Anonymous._33) + (a.Anonymous.Anonymous._44 * b.Anonymous.Anonymous._43);
            Anonymous.Anonymous._44 = (a.Anonymous.Anonymous._41 * b.Anonymous.Anonymous._14) + (a.Anonymous.Anonymous._42 * b.Anonymous.Anonymous._24) + (a.Anonymous.Anonymous._43 * b.Anonymous.Anonymous._34) + (a.Anonymous.Anonymous._44 * b.Anonymous.Anonymous._44);
        }

        public void SetProduct(D2D_MATRIX_4X4_F* a, D2D_MATRIX_4X4_F* b)
        {
            Anonymous.Anonymous._11 = (a->Anonymous.Anonymous._11 * b->Anonymous.Anonymous._11) + (a->Anonymous.Anonymous._12 * b->Anonymous.Anonymous._21) + (a->Anonymous.Anonymous._13 * b->Anonymous.Anonymous._31) + (a->Anonymous.Anonymous._14 * b->Anonymous.Anonymous._41);
            Anonymous.Anonymous._12 = (a->Anonymous.Anonymous._11 * b->Anonymous.Anonymous._12) + (a->Anonymous.Anonymous._12 * b->Anonymous.Anonymous._22) + (a->Anonymous.Anonymous._13 * b->Anonymous.Anonymous._32) + (a->Anonymous.Anonymous._14 * b->Anonymous.Anonymous._42);
            Anonymous.Anonymous._13 = (a->Anonymous.Anonymous._11 * b->Anonymous.Anonymous._13) + (a->Anonymous.Anonymous._12 * b->Anonymous.Anonymous._23) + (a->Anonymous.Anonymous._13 * b->Anonymous.Anonymous._33) + (a->Anonymous.Anonymous._14 * b->Anonymous.Anonymous._43);
            Anonymous.Anonymous._14 = (a->Anonymous.Anonymous._11 * b->Anonymous.Anonymous._14) + (a->Anonymous.Anonymous._12 * b->Anonymous.Anonymous._24) + (a->Anonymous.Anonymous._13 * b->Anonymous.Anonymous._34) + (a->Anonymous.Anonymous._14 * b->Anonymous.Anonymous._44);

            Anonymous.Anonymous._21 = (a->Anonymous.Anonymous._21 * b->Anonymous.Anonymous._11) + (a->Anonymous.Anonymous._22 * b->Anonymous.Anonymous._21) + (a->Anonymous.Anonymous._23 * b->Anonymous.Anonymous._31) + (a->Anonymous.Anonymous._24 * b->Anonymous.Anonymous._41);
            Anonymous.Anonymous._22 = (a->Anonymous.Anonymous._21 * b->Anonymous.Anonymous._12) + (a->Anonymous.Anonymous._22 * b->Anonymous.Anonymous._22) + (a->Anonymous.Anonymous._23 * b->Anonymous.Anonymous._32) + (a->Anonymous.Anonymous._24 * b->Anonymous.Anonymous._42);
            Anonymous.Anonymous._23 = (a->Anonymous.Anonymous._21 * b->Anonymous.Anonymous._13) + (a->Anonymous.Anonymous._22 * b->Anonymous.Anonymous._23) + (a->Anonymous.Anonymous._23 * b->Anonymous.Anonymous._33) + (a->Anonymous.Anonymous._24 * b->Anonymous.Anonymous._43);
            Anonymous.Anonymous._24 = (a->Anonymous.Anonymous._21 * b->Anonymous.Anonymous._14) + (a->Anonymous.Anonymous._22 * b->Anonymous.Anonymous._24) + (a->Anonymous.Anonymous._23 * b->Anonymous.Anonymous._34) + (a->Anonymous.Anonymous._24 * b->Anonymous.Anonymous._44);

            Anonymous.Anonymous._31 = (a->Anonymous.Anonymous._31 * b->Anonymous.Anonymous._11) + (a->Anonymous.Anonymous._32 * b->Anonymous.Anonymous._21) + (a->Anonymous.Anonymous._33 * b->Anonymous.Anonymous._31) + (a->Anonymous.Anonymous._34 * b->Anonymous.Anonymous._41);
            Anonymous.Anonymous._32 = (a->Anonymous.Anonymous._31 * b->Anonymous.Anonymous._12) + (a->Anonymous.Anonymous._32 * b->Anonymous.Anonymous._22) + (a->Anonymous.Anonymous._33 * b->Anonymous.Anonymous._32) + (a->Anonymous.Anonymous._34 * b->Anonymous.Anonymous._42);
            Anonymous.Anonymous._33 = (a->Anonymous.Anonymous._31 * b->Anonymous.Anonymous._13) + (a->Anonymous.Anonymous._32 * b->Anonymous.Anonymous._23) + (a->Anonymous.Anonymous._33 * b->Anonymous.Anonymous._33) + (a->Anonymous.Anonymous._34 * b->Anonymous.Anonymous._43);
            Anonymous.Anonymous._34 = (a->Anonymous.Anonymous._31 * b->Anonymous.Anonymous._14) + (a->Anonymous.Anonymous._32 * b->Anonymous.Anonymous._24) + (a->Anonymous.Anonymous._33 * b->Anonymous.Anonymous._34) + (a->Anonymous.Anonymous._34 * b->Anonymous.Anonymous._44);

            Anonymous.Anonymous._41 = (a->Anonymous.Anonymous._41 * b->Anonymous.Anonymous._11) + (a->Anonymous.Anonymous._42 * b->Anonymous.Anonymous._21) + (a->Anonymous.Anonymous._43 * b->Anonymous.Anonymous._31) + (a->Anonymous.Anonymous._44 * b->Anonymous.Anonymous._41);
            Anonymous.Anonymous._42 = (a->Anonymous.Anonymous._41 * b->Anonymous.Anonymous._12) + (a->Anonymous.Anonymous._42 * b->Anonymous.Anonymous._22) + (a->Anonymous.Anonymous._43 * b->Anonymous.Anonymous._32) + (a->Anonymous.Anonymous._44 * b->Anonymous.Anonymous._42);
            Anonymous.Anonymous._43 = (a->Anonymous.Anonymous._41 * b->Anonymous.Anonymous._13) + (a->Anonymous.Anonymous._42 * b->Anonymous.Anonymous._23) + (a->Anonymous.Anonymous._43 * b->Anonymous.Anonymous._33) + (a->Anonymous.Anonymous._44 * b->Anonymous.Anonymous._43);
            Anonymous.Anonymous._44 = (a->Anonymous.Anonymous._41 * b->Anonymous.Anonymous._14) + (a->Anonymous.Anonymous._42 * b->Anonymous.Anonymous._24) + (a->Anonymous.Anonymous._43 * b->Anonymous.Anonymous._34) + (a->Anonymous.Anonymous._44 * b->Anonymous.Anonymous._44);
        }

        public bool Equals(D2D_MATRIX_4X4_F other) => this == other;

        public override bool Equals(object? obj) => (obj is D2D_MATRIX_4X4_F other) && this == other;

        public override int GetHashCode()
        {
            var hashCode = new HashCode();

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

            return hashCode.ToHashCode();
        }

        public static D2D_MATRIX_4X4_F Translation(float x, float y, float z) => new D2D_MATRIX_4X4_F(
            1.0f, 0.0f, 0.0f, 0.0f,
            0.0f, 1.0f, 0.0f, 0.0f,
            0.0f, 0.0f, 1.0f, 0.0f,
            x, y, z, 1.0f);

        public static D2D_MATRIX_4X4_F Scale(float x, float y, float z) => new D2D_MATRIX_4X4_F(
            x, 0.0f, 0.0f, 0.0f,
            0.0f, y, 0.0f, 0.0f,
            0.0f, 0.0f, z, 0.0f,
            0.0f, 0.0f, 0.0f, 1.0f);

        public static D2D_MATRIX_4X4_F RotationX(float degreeX)
        {
            var angleInRadian = degreeX * (MathF.PI / 180.0f);
            var sinAngle = 0.0f;
            var cosAngle = 0.0f;

            D2D1SinCos(angleInRadian, &sinAngle, &cosAngle);

            return new D2D_MATRIX_4X4_F(
                1.0f, 0.0f, 0.0f, 0.0f,
                0.0f, cosAngle, sinAngle, 0.0f,
                0.0f, -sinAngle, cosAngle, 0.0f,
                0.0f, 0.0f, 0.0f, 1.0f);
        }

        public static D2D_MATRIX_4X4_F RotationY(float degreeY)
        {
            var angleInRadian = degreeY * (MathF.PI / 180.0f);
            var sinAngle = 0.0f;
            var cosAngle = 0.0f;

            D2D1SinCos(angleInRadian, &sinAngle, &cosAngle);

            return new D2D_MATRIX_4X4_F(
                cosAngle, 0.0f, -sinAngle, 0.0f,
                0.0f, 1.0f, 0.0f, 0.0f,
                sinAngle, 0.0f, cosAngle, 0.0f,
                0.0f, 0.0f, 0.0f, 1.0f);
        }

        public static D2D_MATRIX_4X4_F RotationZ(float degreeZ)
        {
            var angleInRadian = degreeZ * (MathF.PI / 180.0f);
            var sinAngle = 0.0f;
            var cosAngle = 0.0f;

            D2D1SinCos(angleInRadian, &sinAngle, &cosAngle);

            return new D2D_MATRIX_4X4_F(
                cosAngle, sinAngle, 0.0f, 0.0f,
                -sinAngle, cosAngle, 0.0f, 0.0f,
                0.0f, 0.0f, 1.0f, 0.0f,
                0.0f, 0.0f, 0.0f, 1.0f);
        }

        public static D2D_MATRIX_4X4_F RotationArbitraryAxis(float x, float y, float z, float degree)
        {
            var magnitude = D2D1Vec3Length(x, y, z);

            x /= magnitude;
            y /= magnitude;
            z /= magnitude;

            var angleInRadian = degree * (MathF.PI / 180.0f);
            var sinAngle = 0.0f;
            var cosAngle = 0.0f;

            D2D1SinCos(angleInRadian, &sinAngle, &cosAngle);

            var oneMinusCosAngle = 1 - cosAngle;

            return new D2D_MATRIX_4X4_F(
                1 + (oneMinusCosAngle * ((x * x) - 1)), (z * sinAngle) + (oneMinusCosAngle * x * y), (-y * sinAngle) + (oneMinusCosAngle * x * z), 0.0f,
                (-z * sinAngle) + (oneMinusCosAngle * y * x), 1 + (oneMinusCosAngle * ((y * y) - 1)), (x * sinAngle) + (oneMinusCosAngle * y * z), 0.0f,
                (y * sinAngle) + (oneMinusCosAngle * z * x), (-x * sinAngle) + (oneMinusCosAngle * z * y), 1 + (oneMinusCosAngle * ((z * z) - 1)), 0.0f,
                0.0f, 0.0f, 0.0f, 1.0f);
        }

        public static D2D_MATRIX_4X4_F SkewX(float degreeX)
        {
            var angleInRadian = degreeX * (MathF.PI / 180.0f);
            var tanAngle = D2D1Tan(angleInRadian);

            return new D2D_MATRIX_4X4_F(
                1.0f, 0.0f, 0.0f, 0.0f,
                tanAngle, 1.0f, 0.0f, 0.0f,
                0.0f, 0.0f, 1.0f, 0.0f,
                0.0f, 0.0f, 0.0f, 1.0f);
        }

        public static D2D_MATRIX_4X4_F SkewY(float degreeY)
        {
            var angleInRadian = degreeY * (MathF.PI / 180.0f);
            var tanAngle = D2D1Tan(angleInRadian);

            return new D2D_MATRIX_4X4_F(
                1.0f, tanAngle, 0.0f, 0.0f,
                0.0f, 1.0f, 0.0f, 0.0f,
                0.0f, 0.0f, 1.0f, 0.0f,
                0.0f, 0.0f, 0.0f, 1.0f);
        }

        public static D2D_MATRIX_4X4_F PerspectiveProjection(float depth)
        {
            var proj = depth > 0 ? -1 / depth : 0.0f;

            return new D2D_MATRIX_4X4_F(
                1.0f, 0.0f, 0.0f, 0.0f,
                0.0f, 1.0f, 0.0f, 0.0f,
                0.0f, 0.0f, 1.0f, proj,
                0.0f, 0.0f, 0.0f, 1.0f);
        }

        public static bool operator ==(D2D_MATRIX_4X4_F left, D2D_MATRIX_4X4_F right) =>
            left.Anonymous.Anonymous._11 == right.Anonymous.Anonymous._11 &&
            left.Anonymous.Anonymous._12 == right.Anonymous.Anonymous._12 &&
            left.Anonymous.Anonymous._13 == right.Anonymous.Anonymous._13 &&
            left.Anonymous.Anonymous._14 == right.Anonymous.Anonymous._14 &&

            left.Anonymous.Anonymous._21 == right.Anonymous.Anonymous._21 &&
            left.Anonymous.Anonymous._22 == right.Anonymous.Anonymous._22 &&
            left.Anonymous.Anonymous._23 == right.Anonymous.Anonymous._23 &&
            left.Anonymous.Anonymous._24 == right.Anonymous.Anonymous._24 &&

            left.Anonymous.Anonymous._31 == right.Anonymous.Anonymous._31 &&
            left.Anonymous.Anonymous._32 == right.Anonymous.Anonymous._32 &&
            left.Anonymous.Anonymous._33 == right.Anonymous.Anonymous._33 &&
            left.Anonymous.Anonymous._34 == right.Anonymous.Anonymous._34 &&

            left.Anonymous.Anonymous._41 == right.Anonymous.Anonymous._41 &&
            left.Anonymous.Anonymous._42 == right.Anonymous.Anonymous._42 &&
            left.Anonymous.Anonymous._43 == right.Anonymous.Anonymous._43 &&
            left.Anonymous.Anonymous._44 == right.Anonymous.Anonymous._44;

        public static bool operator !=(D2D_MATRIX_4X4_F left, D2D_MATRIX_4X4_F right) =>
            left.Anonymous.Anonymous._11 != right.Anonymous.Anonymous._11 ||
            left.Anonymous.Anonymous._12 != right.Anonymous.Anonymous._12 ||
            left.Anonymous.Anonymous._13 != right.Anonymous.Anonymous._13 ||
            left.Anonymous.Anonymous._14 != right.Anonymous.Anonymous._14 ||

            left.Anonymous.Anonymous._21 != right.Anonymous.Anonymous._21 ||
            left.Anonymous.Anonymous._22 != right.Anonymous.Anonymous._22 ||
            left.Anonymous.Anonymous._23 != right.Anonymous.Anonymous._23 ||
            left.Anonymous.Anonymous._24 != right.Anonymous.Anonymous._24 ||

            left.Anonymous.Anonymous._31 != right.Anonymous.Anonymous._31 ||
            left.Anonymous.Anonymous._32 != right.Anonymous.Anonymous._32 ||
            left.Anonymous.Anonymous._33 != right.Anonymous.Anonymous._33 ||
            left.Anonymous.Anonymous._34 != right.Anonymous.Anonymous._34 ||

            left.Anonymous.Anonymous._41 != right.Anonymous.Anonymous._41 ||
            left.Anonymous.Anonymous._42 != right.Anonymous.Anonymous._42 ||
            left.Anonymous.Anonymous._43 != right.Anonymous.Anonymous._43 ||
            left.Anonymous.Anonymous._44 != right.Anonymous.Anonymous._44;

        public static D2D_MATRIX_4X4_F operator *(in D2D_MATRIX_4X4_F a, in D2D_MATRIX_4X4_F b)
        {
            D2D_MATRIX_4X4_F result = default;

            result.SetProduct(a, b);

            return result;
        }
    }
}
