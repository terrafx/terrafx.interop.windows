// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DVD_VideoAttributes" />struct.</summary>
    public static unsafe class DVD_VideoAttributesTests
    {
        /// <summary>Validates that the <see cref="DVD_VideoAttributes" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DVD_VideoAttributes>(), Is.EqualTo(sizeof(DVD_VideoAttributes)));
        }

        /// <summary>Validates that the <see cref="DVD_VideoAttributes" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DVD_VideoAttributes).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DVD_VideoAttributes" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DVD_VideoAttributes), Is.EqualTo(52));
        }
    }
}
