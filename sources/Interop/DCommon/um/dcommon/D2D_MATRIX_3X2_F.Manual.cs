// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.D2D1;

namespace TerraFX.Interop
{
    public unsafe partial struct D2D_MATRIX_3X2_F : IEquatable<D2D_MATRIX_3X2_F>
    {
        public D2D_MATRIX_3X2_F([NativeTypeName("FLOAT")] float m11, [NativeTypeName("FLOAT")] float m12, [NativeTypeName("FLOAT")] float m21, [NativeTypeName("FLOAT")] float m22, [NativeTypeName("FLOAT")] float m31, [NativeTypeName("FLOAT")] float m32)
        {
            this = default;

            Anonymous.Anonymous2._11 = m11;
            Anonymous.Anonymous2._12 = m12;
            Anonymous.Anonymous2._21 = m21;
            Anonymous.Anonymous2._22 = m22;
            Anonymous.Anonymous2._31 = m31;
            Anonymous.Anonymous2._32 = m32;
        }

        public static readonly D2D_MATRIX_3X2_F Identity = new D2D_MATRIX_3X2_F(1.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f);

        public static D2D_MATRIX_3X2_F Translation([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F size)
        {
            D2D_MATRIX_3X2_F translation = default;

            translation.Anonymous.Anonymous2._11 = 1.0f;
            translation.Anonymous.Anonymous2._12 = 0.0f;
            translation.Anonymous.Anonymous2._21 = 0.0f;
            translation.Anonymous.Anonymous2._22 = 1.0f;
            translation.Anonymous.Anonymous2._31 = size.width;
            translation.Anonymous.Anonymous2._32 = size.height;

            return translation;
        }

        public static D2D_MATRIX_3X2_F Translation([NativeTypeName("FLOAT")] float x, [NativeTypeName("FLOAT")] float y)
        {
            return Translation(new D2D_SIZE_F(x, y));
        }

        public static D2D_MATRIX_3X2_F Scale([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F size, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center = default)
        {
            D2D_MATRIX_3X2_F scale = default;

            scale.Anonymous.Anonymous2._11 = size.width;
            scale.Anonymous.Anonymous2._12 = 0.0f;
            scale.Anonymous.Anonymous2._21 = 0.0f;
            scale.Anonymous.Anonymous2._22 = size.height;
            scale.Anonymous.Anonymous2._31 = center.x - size.width * center.x;
            scale.Anonymous.Anonymous2._32 = center.y - size.height * center.y;

            return scale;
        }

        public static D2D_MATRIX_3X2_F Scale([NativeTypeName("FLOAT")] float x, [NativeTypeName("FLOAT")] float y, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center = default)
        {
            return Scale(new D2D_SIZE_F(x, y), center);
        }

        public static D2D_MATRIX_3X2_F Rotation(float angle, D2D_POINT_2F center = default)
        {
            D2D_MATRIX_3X2_F rotation;

            D2D1MakeRotateMatrix(angle, center, &rotation);

            return rotation;
        }

        public static D2D_MATRIX_3X2_F Skew(float angleX, float angleY, D2D_POINT_2F center = default)
        {
            D2D_MATRIX_3X2_F skew;

            D2D1MakeSkewMatrix(angleX, angleY, center, &skew);

            return skew;
        }

        public readonly float Determinant
        {
            [return: NativeTypeName("FLOAT")]
            get
            {
                return (Anonymous.Anonymous2._11 * Anonymous.Anonymous2._22) - (Anonymous.Anonymous2._12 * Anonymous.Anonymous2._21);
            }
        }
            
        public readonly bool IsInvertible
        {
            get
            {
                fixed (D2D_MATRIX_3X2_F* matrix = &this)
                {
                    return D2D1IsMatrixInvertible(matrix) != 0;
                }
            }
        }

        public bool Invert()
        {
            fixed (D2D_MATRIX_3X2_F* matrix = &this)
            {
                return D2D1InvertMatrix(matrix) != 0;
            }
        }

        public readonly bool IsIdentity
        {
            get
            {
                return Anonymous.Anonymous2._11 == 1.0f && Anonymous.Anonymous2._12 == 0.0f && Anonymous.Anonymous2._21 == 0.0f && Anonymous.Anonymous2._22 == 1.0f && Anonymous.Anonymous2._31 == 0.0f && Anonymous.Anonymous2._32 == 0.0f;
            }
        }

        public void SetProduct([NativeTypeName("const D2D1_MATRIX_3X2 &")] in D2D_MATRIX_3X2_F a, [NativeTypeName("const D2D1_MATRIX_3X2 &")] in D2D_MATRIX_3X2_F b)
        {
            Anonymous.Anonymous2._11 = (a.Anonymous.Anonymous2._11 * b.Anonymous.Anonymous2._11) + (a.Anonymous.Anonymous2._12 * b.Anonymous.Anonymous2._21);
            Anonymous.Anonymous2._12 = (a.Anonymous.Anonymous2._11 * b.Anonymous.Anonymous2._12) + (a.Anonymous.Anonymous2._12 * b.Anonymous.Anonymous2._22);
            Anonymous.Anonymous2._21 = (a.Anonymous.Anonymous2._21 * b.Anonymous.Anonymous2._11) + (a.Anonymous.Anonymous2._22 * b.Anonymous.Anonymous2._21);
            Anonymous.Anonymous2._22 = (a.Anonymous.Anonymous2._21 * b.Anonymous.Anonymous2._12) + (a.Anonymous.Anonymous2._22 * b.Anonymous.Anonymous2._22);
            Anonymous.Anonymous2._31 = (a.Anonymous.Anonymous2._31 * b.Anonymous.Anonymous2._11) + (a.Anonymous.Anonymous2._32 * b.Anonymous.Anonymous2._21) + b.Anonymous.Anonymous2._31;
            Anonymous.Anonymous2._32 = (a.Anonymous.Anonymous2._31 * b.Anonymous.Anonymous2._12) + (a.Anonymous.Anonymous2._32 * b.Anonymous.Anonymous2._22) + b.Anonymous.Anonymous2._32;
        }

        public static D2D_MATRIX_3X2_F operator *([NativeTypeName("const D2D1_MATRIX_3X2_F &")] in D2D_MATRIX_3X2_F a, [NativeTypeName("const D2D1_MATRIX_3X2_F &")] in D2D_MATRIX_3X2_F b)
        {
            D2D_MATRIX_3X2_F result = default;

            result.SetProduct(a, b);

            return result;
        }

        public readonly D2D_POINT_2F TransformPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point)
        {
            D2D_POINT_2F result = new D2D_POINT_2F
            {
                x = point.x * Anonymous.Anonymous2._11 + point.y * Anonymous.Anonymous2._21 + Anonymous.Anonymous2._31,
                y= point.x * Anonymous.Anonymous2._12 + point.y * Anonymous.Anonymous2._22 + Anonymous.Anonymous2._32,
            };
            return result;
        }

        public static D2D_POINT_2F operator *([NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F point, [NativeTypeName("const D2D1_MATRIX_3X2_F &")] in D2D_MATRIX_3X2_F matrix)
        {
            return matrix.TransformPoint(point);
        }

        public static bool operator ==(D2D_MATRIX_3X2_F l, D2D_MATRIX_3X2_F r)
        {
            return l.Anonymous.Anonymous2._11 == r.Anonymous.Anonymous2._11 && l.Anonymous.Anonymous2._12 == r.Anonymous.Anonymous2._12 && l.Anonymous.Anonymous2._21 == r.Anonymous.Anonymous2._21 && l.Anonymous.Anonymous2._22 == r.Anonymous.Anonymous2._22 && l.Anonymous.Anonymous2._31 == r.Anonymous.Anonymous2._31 && l.Anonymous.Anonymous2._32 == r.Anonymous.Anonymous2._32;
        }

        public static bool operator !=(D2D_MATRIX_3X2_F l, D2D_MATRIX_3X2_F r)
        {
            return !(l == r);
        }

        public bool Equals(D2D_MATRIX_3X2_F other) => this == other;

        public override bool Equals(object? obj) => (obj is D2D_MATRIX_3X2_F other) && this == other;

        public override int GetHashCode() => HashCode.Combine(Anonymous.Anonymous2._11, Anonymous.Anonymous2._12, Anonymous.Anonymous2._21, Anonymous.Anonymous2._22, Anonymous.Anonymous2._31, Anonymous.Anonymous2._32);
    }
}
