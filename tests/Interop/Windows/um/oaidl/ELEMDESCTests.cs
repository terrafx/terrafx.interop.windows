// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ELEMDESC" /> struct.</summary>
    public static class ELEMDESCTests
    {
        /// <summary>Validates that the layout of the <see cref="ELEMDESC" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ELEMDESC).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="ELEMDESC" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<ELEMDESC>(), Is.EqualTo(32));
            }
            else
            {
                Assert.That(Marshal.SizeOf<ELEMDESC>(), Is.EqualTo(16));
            }
        }
    }
}
