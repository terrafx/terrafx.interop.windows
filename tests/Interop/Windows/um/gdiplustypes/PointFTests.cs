// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PointF" /> struct.</summary>
    public static unsafe partial class PointFTests
    {
        /// <summary>Validates that the <see cref="PointF" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PointF>(), Is.EqualTo(sizeof(PointF)));
        }

        /// <summary>Validates that the <see cref="PointF" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PointF).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PointF" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PointF), Is.EqualTo(8));
        }
    }
}
