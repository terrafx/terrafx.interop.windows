// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CAFILETIME" /> struct.</summary>
    public static class CAFILETIMETests
    {
        /// <summary>Validates that the layout of the <see cref="CAFILETIME" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CAFILETIME).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="CAFILETIME" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<CAFILETIME>(), Is.EqualTo(16));
            }
            else
            {
                Assert.That(Marshal.SizeOf<CAFILETIME>(), Is.EqualTo(8));
            }
        }
    }
}
