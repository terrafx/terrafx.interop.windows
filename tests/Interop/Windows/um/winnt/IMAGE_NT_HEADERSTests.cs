// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMAGE_NT_HEADERS" />struct.</summary>
    public static unsafe class IMAGE_NT_HEADERSTests
    {
        /// <summary>Validates that the <see cref="IMAGE_NT_HEADERS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMAGE_NT_HEADERS>(), Is.EqualTo(sizeof(IMAGE_NT_HEADERS)));
        }

        /// <summary>Validates that the <see cref="IMAGE_NT_HEADERS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMAGE_NT_HEADERS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMAGE_NT_HEADERS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(IMAGE_NT_HEADERS), Is.EqualTo(248));
        }
    }
}
