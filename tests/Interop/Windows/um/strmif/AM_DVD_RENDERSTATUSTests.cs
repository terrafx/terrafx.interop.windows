// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="AM_DVD_RENDERSTATUS" /> struct.</summary>
    public static unsafe partial class AM_DVD_RENDERSTATUSTests
    {
        /// <summary>Validates that the <see cref="AM_DVD_RENDERSTATUS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<AM_DVD_RENDERSTATUS>(), Is.EqualTo(sizeof(AM_DVD_RENDERSTATUS)));
        }

        /// <summary>Validates that the <see cref="AM_DVD_RENDERSTATUS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(AM_DVD_RENDERSTATUS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="AM_DVD_RENDERSTATUS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(AM_DVD_RENDERSTATUS), Is.EqualTo(32));
        }
    }
}
