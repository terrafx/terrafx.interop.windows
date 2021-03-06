// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IAppxBundleManifestOptionalBundleInfoEnumerator" /> struct.</summary>
    public static unsafe class IAppxBundleManifestOptionalBundleInfoEnumeratorTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAppxBundleManifestOptionalBundleInfoEnumerator" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IAppxBundleManifestOptionalBundleInfoEnumerator).GUID, Is.EqualTo(IID_IAppxBundleManifestOptionalBundleInfoEnumerator));
        }

        /// <summary>Validates that the <see cref="IAppxBundleManifestOptionalBundleInfoEnumerator" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IAppxBundleManifestOptionalBundleInfoEnumerator>(), Is.EqualTo(sizeof(IAppxBundleManifestOptionalBundleInfoEnumerator)));
        }

        /// <summary>Validates that the <see cref="IAppxBundleManifestOptionalBundleInfoEnumerator" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IAppxBundleManifestOptionalBundleInfoEnumerator).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IAppxBundleManifestOptionalBundleInfoEnumerator" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IAppxBundleManifestOptionalBundleInfoEnumerator), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IAppxBundleManifestOptionalBundleInfoEnumerator), Is.EqualTo(4));
            }
        }
    }
}
