// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDWriteInMemoryFontFileLoader" /> struct.</summary>
    public static class IDWriteInMemoryFontFileLoaderTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDWriteInMemoryFontFileLoader" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDWriteInMemoryFontFileLoader).GUID, Is.EqualTo(IID_IDWriteInMemoryFontFileLoader));
        }

        /// <summary>Validates that the layout of the <see cref="IDWriteInMemoryFontFileLoader" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDWriteInMemoryFontFileLoader).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDWriteInMemoryFontFileLoader" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDWriteInMemoryFontFileLoader>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDWriteInMemoryFontFileLoader>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDWriteInMemoryFontFileLoader.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDWriteInMemoryFontFileLoader" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDWriteInMemoryFontFileLoader.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDWriteInMemoryFontFileLoader" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDWriteInMemoryFontFileLoader.Vtbl>(), Is.EqualTo(48));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDWriteInMemoryFontFileLoader.Vtbl>(), Is.EqualTo(24));
                }
            }
        }
    }
}
