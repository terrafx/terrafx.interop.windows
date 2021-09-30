// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_BITMAP_OPTIONS;
using static TerraFX.Interop.D2D1_BITMAP_PROPERTIES1;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D2D1_BITMAP_PROPERTIES1" /> struct.</summary>
    public static unsafe class D2D1_BITMAP_PROPERTIES1Tests
    {
        /// <summary>Validates that the <see cref="D2D1_BITMAP_PROPERTIES1" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D2D1_BITMAP_PROPERTIES1>(), Is.EqualTo(sizeof(D2D1_BITMAP_PROPERTIES1)));
        }

        /// <summary>Validates that the <see cref="D2D1_BITMAP_PROPERTIES1" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D2D1_BITMAP_PROPERTIES1).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D2D1_BITMAP_PROPERTIES1" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(D2D1_BITMAP_PROPERTIES1), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(D2D1_BITMAP_PROPERTIES1), Is.EqualTo(24));
            }
        }

        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.pixelFormat, Is.EqualTo(D2D1_PIXEL_FORMAT.DEFAULT));
            Assert.That(DEFAULT.dpiX, Is.EqualTo(96.0f));
            Assert.That(DEFAULT.dpiY, Is.EqualTo(96.0f));
            Assert.That(DEFAULT.bitmapOptions, Is.EqualTo(D2D1_BITMAP_OPTIONS_NONE));
            Assert.That((nuint)DEFAULT.colorContext, Is.EqualTo((nuint)0));
        }
    }
}
