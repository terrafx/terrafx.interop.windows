// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D_MATRIX_5X4_F
    {
        public static readonly D2D_MATRIX_5X4_F DEFAULT = new D2D_MATRIX_5X4_F(
            1.0f, 0.0f, 0.0f, 0.0f,
            0.0f, 1.0f, 0.0f, 0.0f,
            0.0f, 0.0f, 1.0f, 0.0f,
            0.0f, 0.0f, 0.0f, 1.0f,
            0.0f, 0.0f, 0.0f, 0.0f);

        public D2D_MATRIX_5X4_F(
            float m11, float m12, float m13, float m14,
            float m21, float m22, float m23, float m24,
            float m31, float m32, float m33, float m34,
            float m41, float m42, float m43, float m44,
            float m51, float m52, float m53, float m54) : this()
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

            Anonymous.Anonymous._51 = m51;
            Anonymous.Anonymous._52 = m52;
            Anonymous.Anonymous._53 = m53;
            Anonymous.Anonymous._54 = m54;
        }
    }
}
