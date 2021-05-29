// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="_STORAGE_REINITIALIZE_MEDIA" /> struct.</summary>
    public static unsafe class _STORAGE_REINITIALIZE_MEDIATests
    {
        /// <summary>Validates that the <see cref="_STORAGE_REINITIALIZE_MEDIA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<_STORAGE_REINITIALIZE_MEDIA>(), Is.EqualTo(sizeof(_STORAGE_REINITIALIZE_MEDIA)));
        }

        /// <summary>Validates that the <see cref="_STORAGE_REINITIALIZE_MEDIA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(_STORAGE_REINITIALIZE_MEDIA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="_STORAGE_REINITIALIZE_MEDIA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(_STORAGE_REINITIALIZE_MEDIA), Is.EqualTo(16));
        }
    }
}
