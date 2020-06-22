// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="wireVARIANT" /> struct.</summary>
    public static unsafe class wireVARIANTTests
    {
        /// <summary>Validates that the <see cref="wireVARIANT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<wireVARIANT>(), Is.EqualTo(sizeof(wireVARIANT)));
        }

        /// <summary>Validates that the <see cref="wireVARIANT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(wireVARIANT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="wireVARIANT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(wireVARIANT), Is.EqualTo(32));
        }
    }
}
