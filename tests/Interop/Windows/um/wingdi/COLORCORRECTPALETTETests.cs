// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="COLORCORRECTPALETTE" />struct.</summary>
    public static unsafe class COLORCORRECTPALETTETests
    {
        /// <summary>Validates that the <see cref="COLORCORRECTPALETTE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<COLORCORRECTPALETTE>(), Is.EqualTo(sizeof(COLORCORRECTPALETTE)));
        }

        /// <summary>Validates that the <see cref="COLORCORRECTPALETTE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(COLORCORRECTPALETTE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="COLORCORRECTPALETTE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(COLORCORRECTPALETTE), Is.EqualTo(24));
        }
    }
}
