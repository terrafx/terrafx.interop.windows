// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CY" /> struct.</summary>
    public static class CYTests
    {
        /// <summary>Validates that the layout of the <see cref="CY" /> struct is <see cref="LayoutKind.Explicit" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(CY).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="CY" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<CY>(), Is.EqualTo(8));
        }
    }
}
