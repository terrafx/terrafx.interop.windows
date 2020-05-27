// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DWRITE_GLYPH_OFFSET" /> struct.</summary>
    public static class DWRITE_GLYPH_OFFSETTests
    {
        /// <summary>Validates that the layout of the <see cref="DWRITE_GLYPH_OFFSET" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DWRITE_GLYPH_OFFSET).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="DWRITE_GLYPH_OFFSET" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<DWRITE_GLYPH_OFFSET>(), Is.EqualTo(8));
        }
    }
}
