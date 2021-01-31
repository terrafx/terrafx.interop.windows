// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SizeF" /> struct.</summary>
    public static unsafe class SizeFTests
    {
        /// <summary>Validates that the <see cref="SizeF" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SizeF>(), Is.EqualTo(sizeof(SizeF)));
        }

        /// <summary>Validates that the <see cref="SizeF" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SizeF).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SizeF" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SizeF), Is.EqualTo(8));
        }
    }
}
