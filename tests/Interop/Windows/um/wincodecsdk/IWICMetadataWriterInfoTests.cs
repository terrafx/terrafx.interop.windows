// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.WinCodec;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWICMetadataWriterInfo" /> struct.</summary>
    public static class IWICMetadataWriterInfoTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICMetadataWriterInfo" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWICMetadataWriterInfo).GUID, Is.EqualTo(IID_IWICMetadataWriterInfo));
        }

        /// <summary>Validates that the layout of the <see cref="IWICMetadataWriterInfo" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWICMetadataWriterInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IWICMetadataWriterInfo" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IWICMetadataWriterInfo>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IWICMetadataWriterInfo>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IWICMetadataWriterInfo.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IWICMetadataWriterInfo" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IWICMetadataWriterInfo.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IWICMetadataWriterInfo" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IWICMetadataWriterInfo.Vtbl>(), Is.EqualTo(160));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IWICMetadataWriterInfo.Vtbl>(), Is.EqualTo(80));
                }
            }
        }
    }
}
