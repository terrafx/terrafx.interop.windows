// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D_MATRIX_3X2_F;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D2D_MATRIX_3X2_F" /> struct.</summary>
    public static unsafe class D2D_MATRIX_3X2_FTests
    {
        /// <summary>Validates that the <see cref="D2D_MATRIX_3X2_F" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D2D_MATRIX_3X2_F>(), Is.EqualTo(sizeof(D2D_MATRIX_3X2_F)));
        }

        /// <summary>Validates that the <see cref="D2D_MATRIX_3X2_F" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D2D_MATRIX_3X2_F).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D2D_MATRIX_3X2_F" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D2D_MATRIX_3X2_F), Is.EqualTo(24));
        }

        /// <summary>Validates that the value of the <see cref="Identity" /> property is correct.</summary>
        [Test]
        public static void IdentityTest()
        {
            Assert.That(Identity._11, Is.EqualTo(1.0f));
            Assert.That(Identity._12, Is.EqualTo(0.0f));
            Assert.That(Identity._21, Is.EqualTo(0.0f));
            Assert.That(Identity._22, Is.EqualTo(1.0f));
            Assert.That(Identity._31, Is.EqualTo(0.0f));
            Assert.That(Identity._32, Is.EqualTo(0.0f));
        }
    }
}
