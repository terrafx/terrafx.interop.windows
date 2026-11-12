// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using NUnit.Framework;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Validates manually ported Direct2D matrix helper factories.</summary>
public static class D2DMatrixHelperManualTests
{
    /// <summary>Matrix helper defaults are identity and component overloads preserve row-major values.</summary>
    [Test]
    public static void MatrixHelpersCreateIdentityAndComponentMatrices()
    {
        Assert.That(DirectX.Matrix3x2F(), Is.EqualTo(default(D2D_MATRIX_3X2_F)));
        Assert.That(DirectX.Matrix4x3F(), Is.EqualTo(D2D_MATRIX_4X3_F.Identity));
        Assert.That(DirectX.Matrix4x4F(), Is.EqualTo(D2D_MATRIX_4X4_F.Identity));
        Assert.That(DirectX.Matrix5x4F(), Is.EqualTo(D2D_MATRIX_5X4_F.Identity));

        D2D_MATRIX_3X2_F matrix3x2 = DirectX.Matrix3x2F(1, 2, 3, 4, 5, 6);
        Assert.That(matrix3x2.m11, Is.EqualTo(1));
        Assert.That(matrix3x2.m12, Is.EqualTo(2));
        Assert.That(matrix3x2.m21, Is.EqualTo(3));
        Assert.That(matrix3x2.m22, Is.EqualTo(4));
        Assert.That(matrix3x2.dx, Is.EqualTo(5));
        Assert.That(matrix3x2.dy, Is.EqualTo(6));

        D2D_MATRIX_4X3_F matrix4x3 = DirectX.Matrix4x3F(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
        Assert.That(matrix4x3._41, Is.EqualTo(10));
        Assert.That(matrix4x3._43, Is.EqualTo(12));

        D2D_MATRIX_4X4_F matrix4x4 = DirectX.Matrix4x4F(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
        Assert.That(matrix4x4._41, Is.EqualTo(13));
        Assert.That(matrix4x4._44, Is.EqualTo(16));

        D2D_MATRIX_5X4_F matrix5x4 = DirectX.Matrix5x4F(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20);
        Assert.That(matrix5x4._51, Is.EqualTo(17));
        Assert.That(matrix5x4._54, Is.EqualTo(20));
    }
}
