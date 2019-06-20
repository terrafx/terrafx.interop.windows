// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DWRITE_FILE_FRAGMENT" /> struct.</summary>
    public static class DWRITE_FILE_FRAGMENTTests
    {
        /// <summary>Validates that the layout of the <see cref="DWRITE_FILE_FRAGMENT" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DWRITE_FILE_FRAGMENT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="DWRITE_FILE_FRAGMENT" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<DWRITE_FILE_FRAGMENT>(), Is.EqualTo(16));
        }
    }
}
