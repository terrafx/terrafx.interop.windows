// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_CAP_STYLE;
using static TerraFX.Interop.D2D1_DASH_STYLE;
using static TerraFX.Interop.D2D1_LINE_JOIN;
using static TerraFX.Interop.D2D1_STROKE_STYLE_PROPERTIES1;
using static TerraFX.Interop.D2D1_STROKE_TRANSFORM_TYPE;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D2D1_STROKE_STYLE_PROPERTIES1" /> struct.</summary>
    public static unsafe class D2D1_STROKE_STYLE_PROPERTIES1Tests
    {
        /// <summary>Validates that the <see cref="D2D1_STROKE_STYLE_PROPERTIES1" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D2D1_STROKE_STYLE_PROPERTIES1>(), Is.EqualTo(sizeof(D2D1_STROKE_STYLE_PROPERTIES1)));
        }

        /// <summary>Validates that the <see cref="D2D1_STROKE_STYLE_PROPERTIES1" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D2D1_STROKE_STYLE_PROPERTIES1).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D2D1_STROKE_STYLE_PROPERTIES1" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D2D1_STROKE_STYLE_PROPERTIES1), Is.EqualTo(32));
        }

        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.startCap, Is.EqualTo(D2D1_CAP_STYLE_FLAT));
            Assert.That(DEFAULT.endCap, Is.EqualTo(D2D1_CAP_STYLE_FLAT));
            Assert.That(DEFAULT.dashCap, Is.EqualTo(D2D1_CAP_STYLE_FLAT));
            Assert.That(DEFAULT.lineJoin, Is.EqualTo(D2D1_LINE_JOIN_MITER));
            Assert.That(DEFAULT.miterLimit, Is.EqualTo(10.0f));
            Assert.That(DEFAULT.dashStyle, Is.EqualTo(D2D1_DASH_STYLE_SOLID));
            Assert.That(DEFAULT.dashOffset, Is.EqualTo(0.0f));
            Assert.That(DEFAULT.transformType, Is.EqualTo(D2D1_STROKE_TRANSFORM_TYPE_NORMAL));
        }
    }
}
