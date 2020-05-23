// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="FONTSIGNATURE" /> struct.</summary>
    public static class FONTSIGNATURETests
    {
        /// <summary>Validates that the layout of the <see cref="FONTSIGNATURE" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(FONTSIGNATURE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="FONTSIGNATURE" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<FONTSIGNATURE>(), Is.EqualTo(24));
        }
    }
}
