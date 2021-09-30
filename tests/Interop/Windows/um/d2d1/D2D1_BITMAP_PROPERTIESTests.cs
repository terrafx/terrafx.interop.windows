// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_BITMAP_PROPERTIES;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D2D1_BITMAP_PROPERTIES" /> struct.</summary>
    public static unsafe class D2D1_BITMAP_PROPERTIESTests
    {
        /// <summary>Validates that the <see cref="D2D1_BITMAP_PROPERTIES" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D2D1_BITMAP_PROPERTIES>(), Is.EqualTo(sizeof(D2D1_BITMAP_PROPERTIES)));
        }

        /// <summary>Validates that the <see cref="D2D1_BITMAP_PROPERTIES" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D2D1_BITMAP_PROPERTIES).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D2D1_BITMAP_PROPERTIES" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D2D1_BITMAP_PROPERTIES), Is.EqualTo(16));
        }

        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.pixelFormat, Is.EqualTo(D2D1_PIXEL_FORMAT.DEFAULT));
            Assert.That(DEFAULT.dpiX, Is.EqualTo(96.0f));
            Assert.That(DEFAULT.dpiY, Is.EqualTo(96.0f));
        }
    }
}
