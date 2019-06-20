// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDLDESC" /> struct.</summary>
    public static class IDLDESCTests
    {
        /// <summary>Validates that the layout of the <see cref="IDLDESC" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDLDESC).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDLDESC" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDLDESC>(), Is.EqualTo(16));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDLDESC>(), Is.EqualTo(8));
            }
        }
    }
}
