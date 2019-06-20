// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.WinCodec;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWICEnumMetadataItem" /> struct.</summary>
    public static class IWICEnumMetadataItemTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICEnumMetadataItem" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWICEnumMetadataItem).GUID, Is.EqualTo(IID_IWICEnumMetadataItem));
        }

        /// <summary>Validates that the layout of the <see cref="IWICEnumMetadataItem" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWICEnumMetadataItem).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IWICEnumMetadataItem" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IWICEnumMetadataItem>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IWICEnumMetadataItem>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IWICEnumMetadataItem.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IWICEnumMetadataItem" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IWICEnumMetadataItem.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IWICEnumMetadataItem" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IWICEnumMetadataItem.Vtbl>(), Is.EqualTo(56));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IWICEnumMetadataItem.Vtbl>(), Is.EqualTo(28));
                }
            }
        }
    }
}
