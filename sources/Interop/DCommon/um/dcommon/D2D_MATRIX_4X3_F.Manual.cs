// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct D2D_MATRIX_4X3_F : IEquatable<D2D_MATRIX_4X3_F>
    {
        public static readonly D2D_MATRIX_4X3_F DEFAULT = new D2D_MATRIX_4X3_F(
            1.0f, 0.0f, 0.0f, 0.0f,
            1.0f, 0.0f, 0.0f, 0.0f,
            1.0f, 0.0f, 0.0f, 0.0f);

        public D2D_MATRIX_4X3_F(
            float m11, float m12, float m13,
            float m21, float m22, float m23,
            float m31, float m32, float m33,
            float m41, float m42, float m43) : this()
        {
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

        public bool Equals(D2D_MATRIX_4X3_F other) => this == other;

        public override bool Equals(object? obj) => (obj is D2D_MATRIX_4X3_F other) && this == other;

        public override int GetHashCode()
        {
            var hashCode = new HashCode();

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

            return hashCode.ToHashCode();
        }

        public static bool operator ==(D2D_MATRIX_4X3_F left, D2D_MATRIX_4X3_F right) =>
            left.Anonymous.Anonymous._11 == right.Anonymous.Anonymous._11 &&
            left.Anonymous.Anonymous._12 == right.Anonymous.Anonymous._12 &&
            left.Anonymous.Anonymous._13 == right.Anonymous.Anonymous._13 &&

            left.Anonymous.Anonymous._21 == right.Anonymous.Anonymous._21 &&
            left.Anonymous.Anonymous._22 == right.Anonymous.Anonymous._22 &&
            left.Anonymous.Anonymous._23 == right.Anonymous.Anonymous._23 &&

            left.Anonymous.Anonymous._31 == right.Anonymous.Anonymous._31 &&
            left.Anonymous.Anonymous._32 == right.Anonymous.Anonymous._32 &&
            left.Anonymous.Anonymous._33 == right.Anonymous.Anonymous._33 &&

            left.Anonymous.Anonymous._41 == right.Anonymous.Anonymous._41 &&
            left.Anonymous.Anonymous._42 == right.Anonymous.Anonymous._42 &&
            left.Anonymous.Anonymous._43 == right.Anonymous.Anonymous._43;

        public static bool operator !=(D2D_MATRIX_4X3_F left, D2D_MATRIX_4X3_F right) =>
            left.Anonymous.Anonymous._11 != right.Anonymous.Anonymous._11 ||
            left.Anonymous.Anonymous._12 != right.Anonymous.Anonymous._12 ||
            left.Anonymous.Anonymous._13 != right.Anonymous.Anonymous._13 ||

            left.Anonymous.Anonymous._21 != right.Anonymous.Anonymous._21 ||
            left.Anonymous.Anonymous._22 != right.Anonymous.Anonymous._22 ||
            left.Anonymous.Anonymous._23 != right.Anonymous.Anonymous._23 ||

            left.Anonymous.Anonymous._31 != right.Anonymous.Anonymous._31 ||
            left.Anonymous.Anonymous._32 != right.Anonymous.Anonymous._32 ||
            left.Anonymous.Anonymous._33 != right.Anonymous.Anonymous._33 ||

            left.Anonymous.Anonymous._41 != right.Anonymous.Anonymous._41 ||
            left.Anonymous.Anonymous._42 != right.Anonymous.Anonymous._42 ||
            left.Anonymous.Anonymous._43 != right.Anonymous.Anonymous._43;
    }
}
