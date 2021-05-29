// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="AudioClientProperties" /> struct.</summary>
    public static unsafe class AudioClientPropertiesTests
    {
        /// <summary>Validates that the <see cref="AudioClientProperties" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<AudioClientProperties>(), Is.EqualTo(sizeof(AudioClientProperties)));
        }

        /// <summary>Validates that the <see cref="AudioClientProperties" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(AudioClientProperties).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="AudioClientProperties" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(AudioClientProperties), Is.EqualTo(16));
        }
    }
}
