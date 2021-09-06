// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/commoncontrols.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMAGELISTSTAT" /> struct.</summary>
    public static unsafe class IMAGELISTSTATTests
    {
        /// <summary>Validates that the <see cref="IMAGELISTSTAT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMAGELISTSTAT>(), Is.EqualTo(sizeof(IMAGELISTSTAT)));
        }

        /// <summary>Validates that the <see cref="IMAGELISTSTAT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMAGELISTSTAT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMAGELISTSTAT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(IMAGELISTSTAT), Is.EqualTo(16));
        }
    }
}
