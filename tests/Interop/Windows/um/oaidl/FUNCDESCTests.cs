// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="FUNCDESC" /> struct.</summary>
    public static class FUNCDESCTests
    {
        /// <summary>Validates that the layout of the <see cref="FUNCDESC" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(FUNCDESC).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="FUNCDESC" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<FUNCDESC>(), Is.EqualTo(88));
            }
            else
            {
                Assert.That(Marshal.SizeOf<FUNCDESC>(), Is.EqualTo(52));
            }
        }
    }
}
