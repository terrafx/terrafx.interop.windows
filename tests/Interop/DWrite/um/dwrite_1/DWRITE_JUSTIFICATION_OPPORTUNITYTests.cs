// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DWRITE_JUSTIFICATION_OPPORTUNITY" /> struct.</summary>
    public static class DWRITE_JUSTIFICATION_OPPORTUNITYTests
    {
        /// <summary>Validates that the layout of the <see cref="DWRITE_JUSTIFICATION_OPPORTUNITY" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DWRITE_JUSTIFICATION_OPPORTUNITY).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="DWRITE_JUSTIFICATION_OPPORTUNITY" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<DWRITE_JUSTIFICATION_OPPORTUNITY>(), Is.EqualTo(16));
        }
    }
}
