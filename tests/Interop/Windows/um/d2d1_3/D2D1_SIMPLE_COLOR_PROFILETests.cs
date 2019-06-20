// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D2D1_SIMPLE_COLOR_PROFILE" /> struct.</summary>
    public static class D2D1_SIMPLE_COLOR_PROFILETests
    {
        /// <summary>Validates that the layout of the <see cref="D2D1_SIMPLE_COLOR_PROFILE" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D2D1_SIMPLE_COLOR_PROFILE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="D2D1_SIMPLE_COLOR_PROFILE" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<D2D1_SIMPLE_COLOR_PROFILE>(), Is.EqualTo(36));
        }
    }
}
