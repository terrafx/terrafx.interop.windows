// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_ANTIALIAS_MODE;
using static TerraFX.Interop.D2D1_DRAWING_STATE_DESCRIPTION1;
using static TerraFX.Interop.D2D1_PRIMITIVE_BLEND;
using static TerraFX.Interop.D2D1_TEXT_ANTIALIAS_MODE;
using static TerraFX.Interop.D2D1_UNIT_MODE;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D2D1_DRAWING_STATE_DESCRIPTION1" /> struct.</summary>
    public static unsafe class D2D1_DRAWING_STATE_DESCRIPTION1Tests
    {
        /// <summary>Validates that the <see cref="D2D1_DRAWING_STATE_DESCRIPTION1" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D2D1_DRAWING_STATE_DESCRIPTION1>(), Is.EqualTo(sizeof(D2D1_DRAWING_STATE_DESCRIPTION1)));
        }

        /// <summary>Validates that the <see cref="D2D1_DRAWING_STATE_DESCRIPTION1" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D2D1_DRAWING_STATE_DESCRIPTION1).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D2D1_DRAWING_STATE_DESCRIPTION1" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D2D1_DRAWING_STATE_DESCRIPTION1), Is.EqualTo(56));
        }

        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.antialiasMode, Is.EqualTo(D2D1_ANTIALIAS_MODE_PER_PRIMITIVE));
            Assert.That(DEFAULT.textAntialiasMode, Is.EqualTo(D2D1_TEXT_ANTIALIAS_MODE_DEFAULT));
            Assert.That(DEFAULT.tag1, Is.EqualTo(0));
            Assert.That(DEFAULT.tag2, Is.EqualTo(0));
            Assert.That(DEFAULT.transform, Is.EqualTo(IdentityMatrix));
            Assert.That(DEFAULT.primitiveBlend, Is.EqualTo(D2D1_PRIMITIVE_BLEND_SOURCE_OVER));
            Assert.That(DEFAULT.unitMode, Is.EqualTo(D2D1_UNIT_MODE_DIPS));
        }
    }
}
