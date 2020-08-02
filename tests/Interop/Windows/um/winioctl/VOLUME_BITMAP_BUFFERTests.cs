// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VOLUME_BITMAP_BUFFER" />struct.</summary>
    public static unsafe class VOLUME_BITMAP_BUFFERTests
    {
        /// <summary>Validates that the <see cref="VOLUME_BITMAP_BUFFER" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VOLUME_BITMAP_BUFFER>(), Is.EqualTo(sizeof(VOLUME_BITMAP_BUFFER)));
        }

        /// <summary>Validates that the <see cref="VOLUME_BITMAP_BUFFER" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VOLUME_BITMAP_BUFFER).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VOLUME_BITMAP_BUFFER" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(VOLUME_BITMAP_BUFFER), Is.EqualTo(24));
        }
    }
}
