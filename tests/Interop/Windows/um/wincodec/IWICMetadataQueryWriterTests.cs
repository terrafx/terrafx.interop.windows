// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWICMetadataQueryWriter" /> struct.</summary>
    public static class IWICMetadataQueryWriterTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICMetadataQueryWriter" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWICMetadataQueryWriter).GUID, Is.EqualTo(IID_IWICMetadataQueryWriter));
        }

        /// <summary>Validates that the layout of the <see cref="IWICMetadataQueryWriter" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWICMetadataQueryWriter).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IWICMetadataQueryWriter" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IWICMetadataQueryWriter>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IWICMetadataQueryWriter>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IWICMetadataQueryWriter.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IWICMetadataQueryWriter" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IWICMetadataQueryWriter.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IWICMetadataQueryWriter" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IWICMetadataQueryWriter.Vtbl>(), Is.EqualTo(72));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IWICMetadataQueryWriter.Vtbl>(), Is.EqualTo(36));
                }
            }
        }
    }
}
