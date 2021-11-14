// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="ARM64_FPSR_REG" /> struct.</summary>
    public static unsafe partial class ARM64_FPSR_REGTests
    {
        /// <summary>Validates that the <see cref="ARM64_FPSR_REG" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ARM64_FPSR_REG>(), Is.EqualTo(sizeof(ARM64_FPSR_REG)));
        }

        /// <summary>Validates that the <see cref="ARM64_FPSR_REG" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(ARM64_FPSR_REG).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="ARM64_FPSR_REG" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(ARM64_FPSR_REG), Is.EqualTo(4));
        }
    }
}
