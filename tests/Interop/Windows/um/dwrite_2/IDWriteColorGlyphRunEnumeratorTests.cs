// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.DWrite;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDWriteColorGlyphRunEnumerator" /> struct.</summary>
    public static class IDWriteColorGlyphRunEnumeratorTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDWriteColorGlyphRunEnumerator" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDWriteColorGlyphRunEnumerator).GUID, Is.EqualTo(IID_IDWriteColorGlyphRunEnumerator));
        }

        /// <summary>Validates that the layout of the <see cref="IDWriteColorGlyphRunEnumerator" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDWriteColorGlyphRunEnumerator).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDWriteColorGlyphRunEnumerator" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDWriteColorGlyphRunEnumerator>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDWriteColorGlyphRunEnumerator>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDWriteColorGlyphRunEnumerator.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDWriteColorGlyphRunEnumerator" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDWriteColorGlyphRunEnumerator.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDWriteColorGlyphRunEnumerator" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDWriteColorGlyphRunEnumerator.Vtbl>(), Is.EqualTo(40));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDWriteColorGlyphRunEnumerator.Vtbl>(), Is.EqualTo(20));
                }
            }
        }
    }
}
