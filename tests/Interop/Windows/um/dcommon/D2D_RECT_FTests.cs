// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D_RECT_F;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D2D_RECT_F" /> struct.</summary>
    public static unsafe class D2D_RECT_FTests
    {
        /// <summary>Validates that the <see cref="D2D_RECT_F" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D2D_RECT_F>(), Is.EqualTo(sizeof(D2D_RECT_F)));
        }

        /// <summary>Validates that the <see cref="D2D_RECT_F" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D2D_RECT_F).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D2D_RECT_F" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D2D_RECT_F), Is.EqualTo(16));
        }

        /// <summary>Validates that the value of the <see cref="Infinite" /> property is correct.</summary>
        [Test]
        public static void InfiniteTest()
        {
            Assert.That(Infinite.left, Is.EqualTo(-FloatMax));
            Assert.That(Infinite.top, Is.EqualTo(-FloatMax));
            Assert.That(Infinite.right, Is.EqualTo(FloatMax));
            Assert.That(Infinite.bottom, Is.EqualTo(FloatMax));
        }
    }
}
