// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DWRITE_GLYPH_RUN_DESCRIPTION" /> struct.</summary>
    public static class DWRITE_GLYPH_RUN_DESCRIPTIONTests
    {
        /// <summary>Validates that the layout of the <see cref="DWRITE_GLYPH_RUN_DESCRIPTION" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DWRITE_GLYPH_RUN_DESCRIPTION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="DWRITE_GLYPH_RUN_DESCRIPTION" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<DWRITE_GLYPH_RUN_DESCRIPTION>(), Is.EqualTo(40));
            }
            else
            {
                Assert.That(Marshal.SizeOf<DWRITE_GLYPH_RUN_DESCRIPTION>(), Is.EqualTo(20));
            }
        }
    }
}
