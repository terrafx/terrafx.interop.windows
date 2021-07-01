// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="AMD64_MXCSR_REG" /> struct.</summary>
    public static unsafe class AMD64_MXCSR_REGTests
    {
        /// <summary>Validates that the <see cref="AMD64_MXCSR_REG" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<AMD64_MXCSR_REG>(), Is.EqualTo(sizeof(AMD64_MXCSR_REG)));
        }

        /// <summary>Validates that the <see cref="AMD64_MXCSR_REG" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(AMD64_MXCSR_REG).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="AMD64_MXCSR_REG" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(AMD64_MXCSR_REG), Is.EqualTo(4));
        }
    }
}
