// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D2D_MATRIX_3X2_F
    {
        public static readonly D2D_MATRIX_3X2_F Identity = new D2D_MATRIX_3X2_F(
            1.0f, 0.0f, 0.0f,
            1.0f, 0.0f, 0.0f);

        public D2D_MATRIX_3X2_F(
            float m11, float m12, float m21,
            float m22, float m31, float m32) : this()
        {
            Anonymous.Anonymous2._11 = m11;
            Anonymous.Anonymous2._12 = m12;

            Anonymous.Anonymous2._21 = m21;
            Anonymous.Anonymous2._22 = m22;

            Anonymous.Anonymous2._31 = m31;
            Anonymous.Anonymous2._32 = m32;
        }

        public readonly float Determinant => (Anonymous.Anonymous2._11 * Anonymous.Anonymous2._22) - (Anonymous.Anonymous2._12 * Anonymous.Anonymous2._21);

        public readonly bool IsInvertible
        {
            get
            {
                fixed (D2D_MATRIX_3X2_F* matrix = &this)
                {
                    return DCommon.D2D1IsMatrixInvertible(matrix) != 0;
                }
            }
        }

        public readonly bool IsIdentity =>
            Anonymous.Anonymous2._11 == 1.0f && Anonymous.Anonymous2._12 == 0.0f &&
            Anonymous.Anonymous2._21 == 0.0f && Anonymous.Anonymous2._22 == 1.0f &&
            Anonymous.Anonymous2._31 == 0.0f && Anonymous.Anonymous2._32 == 0.0f;

        public bool Invert()
        {
            fixed (D2D_MATRIX_3X2_F* matrix = &this)
            {
                return DCommon.D2D1InvertMatrix(matrix) != 0;
            }
        }

        public void SetProduct(in D2D_MATRIX_3X2_F a, in D2D_MATRIX_3X2_F b)
        {
            Anonymous.Anonymous2._11 = (a.Anonymous.Anonymous2._11 * b.Anonymous.Anonymous2._11) + (a.Anonymous.Anonymous2._12 * b.Anonymous.Anonymous2._21);
            Anonymous.Anonymous2._12 = (a.Anonymous.Anonymous2._11 * b.Anonymous.Anonymous2._12) + (a.Anonymous.Anonymous2._12 * b.Anonymous.Anonymous2._22);
            Anonymous.Anonymous2._21 = (a.Anonymous.Anonymous2._21 * b.Anonymous.Anonymous2._11) + (a.Anonymous.Anonymous2._22 * b.Anonymous.Anonymous2._21);
            Anonymous.Anonymous2._22 = (a.Anonymous.Anonymous2._21 * b.Anonymous.Anonymous2._12) + (a.Anonymous.Anonymous2._22 * b.Anonymous.Anonymous2._22);
            Anonymous.Anonymous2._31 = (a.Anonymous.Anonymous2._31 * b.Anonymous.Anonymous2._11) + (a.Anonymous.Anonymous2._32 * b.Anonymous.Anonymous2._21) + b.Anonymous.Anonymous2._31;
            Anonymous.Anonymous2._32 = (a.Anonymous.Anonymous2._31 * b.Anonymous.Anonymous2._12) + (a.Anonymous.Anonymous2._32 * b.Anonymous.Anonymous2._22) + b.Anonymous.Anonymous2._32;
        }

        public void SetProduct(D2D_MATRIX_3X2_F* a, D2D_MATRIX_3X2_F* b)
        {
            Anonymous.Anonymous2._11 = (a->Anonymous.Anonymous2._11 * b->Anonymous.Anonymous2._11) + (a->Anonymous.Anonymous2._12 * b->Anonymous.Anonymous2._21);
            Anonymous.Anonymous2._12 = (a->Anonymous.Anonymous2._11 * b->Anonymous.Anonymous2._12) + (a->Anonymous.Anonymous2._12 * b->Anonymous.Anonymous2._22);
            Anonymous.Anonymous2._21 = (a->Anonymous.Anonymous2._21 * b->Anonymous.Anonymous2._11) + (a->Anonymous.Anonymous2._22 * b->Anonymous.Anonymous2._21);
            Anonymous.Anonymous2._22 = (a->Anonymous.Anonymous2._21 * b->Anonymous.Anonymous2._12) + (a->Anonymous.Anonymous2._22 * b->Anonymous.Anonymous2._22);
            Anonymous.Anonymous2._31 = (a->Anonymous.Anonymous2._31 * b->Anonymous.Anonymous2._11) + (a->Anonymous.Anonymous2._32 * b->Anonymous.Anonymous2._21) + b->Anonymous.Anonymous2._31;
            Anonymous.Anonymous2._32 = (a->Anonymous.Anonymous2._31 * b->Anonymous.Anonymous2._12) + (a->Anonymous.Anonymous2._32 * b->Anonymous.Anonymous2._22) + b->Anonymous.Anonymous2._32;
        }

        public readonly D2D_POINT_2F TransformPoint(in D2D_POINT_2F point) => new D2D_POINT_2F((point.x * Anonymous.Anonymous2._11) + (point.y * Anonymous.Anonymous2._21) + Anonymous.Anonymous2._31, (point.x * Anonymous.Anonymous2._12) + (point.y * Anonymous.Anonymous2._22) + Anonymous.Anonymous2._32);

        public static D2D_MATRIX_3X2_F Translation(in D2D_SIZE_F size) => new D2D_MATRIX_3X2_F(1.0f, 0.0f, 0.0f, 1.0f, size.width, size.height);

        public static D2D_MATRIX_3X2_F Translation(float x, float y) => Translation(new D2D_SIZE_F(x, y));

        public static D2D_MATRIX_3X2_F Scale(in D2D_SIZE_F size, in D2D_POINT_2F center = default) => new D2D_MATRIX_3X2_F(size.width, 0.0f, 0.0f, size.height, center.x - (size.width * center.x), center.y - (size.height * center.y));

        public static D2D_MATRIX_3X2_F Scale(float x, float y, in D2D_POINT_2F center) => Scale(new D2D_SIZE_F(x, y), center);

        public static D2D_MATRIX_3X2_F IdentityMatrix() => Identity;

        public static D2D_MATRIX_3X2_F Rotation(float angle, D2D_POINT_2F center = default)
        {
            D2D_MATRIX_3X2_F rotation;

            DCommon.D2D1MakeRotateMatrix(angle, center, &rotation);

            return rotation;
        }

        public static D2D_MATRIX_3X2_F Skew(float angleX, float angleY, D2D_POINT_2F center = default)
        {
            D2D_MATRIX_3X2_F skew;

            DCommon.D2D1MakeSkewMatrix(angleX, angleY, center, &skew);

            return skew;
        }

        public static D2D_MATRIX_3X2_F operator *(in D2D_MATRIX_3X2_F a, in D2D_MATRIX_3X2_F b)
        {
            D2D_MATRIX_3X2_F result = default;

            result.SetProduct(a, b);

            return result;
        }

        public static D2D_POINT_2F operator *(in D2D_POINT_2F point, in D2D_MATRIX_3X2_F matrix) => matrix.TransformPoint(point);
    }
}
