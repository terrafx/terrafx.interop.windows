// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PUBKEYVER3" />struct.</summary>
    public static unsafe class PUBKEYVER3Tests
    {
        /// <summary>Validates that the <see cref="PUBKEYVER3" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PUBKEYVER3>(), Is.EqualTo(sizeof(PUBKEYVER3)));
        }

        /// <summary>Validates that the <see cref="PUBKEYVER3" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PUBKEYVER3).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PUBKEYVER3" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PUBKEYVER3), Is.EqualTo(40));
        }
    }
}
