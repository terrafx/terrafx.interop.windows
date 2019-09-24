// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES" /> struct.</summary>
    public static class D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIESTests
    {
        /// <summary>Validates that the layout of the <see cref="D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES>(), Is.EqualTo(20));
        }
    }
}
