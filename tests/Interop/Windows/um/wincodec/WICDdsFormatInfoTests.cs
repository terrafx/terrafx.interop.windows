// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="WICDdsFormatInfo" /> struct.</summary>
    public static unsafe class WICDdsFormatInfoTests
    {
        /// <summary>Validates that the <see cref="WICDdsFormatInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<WICDdsFormatInfo>(), Is.EqualTo(sizeof(WICDdsFormatInfo)));
        }

        /// <summary>Validates that the <see cref="WICDdsFormatInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(WICDdsFormatInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="WICDdsFormatInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(WICDdsFormatInfo), Is.EqualTo(16));
        }
    }
}
