// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_BRUSH_PROPERTIES;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D2D1_BRUSH_PROPERTIES" /> struct.</summary>
    public static unsafe class D2D1_BRUSH_PROPERTIESTests
    {
        /// <summary>Validates that the <see cref="D2D1_BRUSH_PROPERTIES" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D2D1_BRUSH_PROPERTIES>(), Is.EqualTo(sizeof(D2D1_BRUSH_PROPERTIES)));
        }

        /// <summary>Validates that the <see cref="D2D1_BRUSH_PROPERTIES" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D2D1_BRUSH_PROPERTIES).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D2D1_BRUSH_PROPERTIES" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D2D1_BRUSH_PROPERTIES), Is.EqualTo(28));
        }

        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.opacity, Is.EqualTo(1.0f));
            Assert.That(DEFAULT.transform, Is.EqualTo(D2D_MATRIX_3X2_F.Identity));
        }
    }
}
