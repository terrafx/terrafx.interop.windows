// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_FEATURE_LEVEL;
using static TerraFX.Interop.D2D1_RENDER_TARGET_PROPERTIES;
using static TerraFX.Interop.D2D1_RENDER_TARGET_TYPE;
using static TerraFX.Interop.D2D1_RENDER_TARGET_USAGE;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D2D1_RENDER_TARGET_PROPERTIES" /> struct.</summary>
    public static unsafe class D2D1_RENDER_TARGET_PROPERTIESTests
    {
        /// <summary>Validates that the <see cref="D2D1_RENDER_TARGET_PROPERTIES" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D2D1_RENDER_TARGET_PROPERTIES>(), Is.EqualTo(sizeof(D2D1_RENDER_TARGET_PROPERTIES)));
        }

        /// <summary>Validates that the <see cref="D2D1_RENDER_TARGET_PROPERTIES" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D2D1_RENDER_TARGET_PROPERTIES).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D2D1_RENDER_TARGET_PROPERTIES" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D2D1_RENDER_TARGET_PROPERTIES), Is.EqualTo(28));
        }

        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.type, Is.EqualTo(D2D1_RENDER_TARGET_TYPE_DEFAULT));
            Assert.That(DEFAULT.pixelFormat, Is.EqualTo(D2D1_PIXEL_FORMAT.DEFAULT));
            Assert.That(DEFAULT.dpiX, Is.EqualTo(0.0f));
            Assert.That(DEFAULT.dpiY, Is.EqualTo(0.0f));
            Assert.That(DEFAULT.usage, Is.EqualTo(D2D1_RENDER_TARGET_USAGE_NONE));
            Assert.That(DEFAULT.minLevel, Is.EqualTo(D2D1_FEATURE_LEVEL_DEFAULT));
        }
    }
}
