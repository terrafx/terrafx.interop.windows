// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWICMetadataWriter" /> struct.</summary>
    public static unsafe class IWICMetadataWriterTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICMetadataWriter" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWICMetadataWriter).GUID, Is.EqualTo(IID_IWICMetadataWriter));
        }

        /// <summary>Validates that the <see cref="IWICMetadataWriter" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IWICMetadataWriter>(), Is.EqualTo(sizeof(IWICMetadataWriter)));
        }

        /// <summary>Validates that the <see cref="IWICMetadataWriter" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWICMetadataWriter).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IWICMetadataWriter" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IWICMetadataWriter), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IWICMetadataWriter), Is.EqualTo(4));
            }
        }
    }
}
