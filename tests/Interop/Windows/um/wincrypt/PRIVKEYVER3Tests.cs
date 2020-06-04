// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PRIVKEYVER3" /> struct.</summary>
    public static unsafe class PRIVKEYVER3Tests
    {
        /// <summary>Validates that the <see cref="PRIVKEYVER3" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PRIVKEYVER3>(), Is.EqualTo(sizeof(PRIVKEYVER3)));
        }

        /// <summary>Validates that the <see cref="PRIVKEYVER3" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PRIVKEYVER3).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PRIVKEYVER3" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PRIVKEYVER3), Is.EqualTo(44));
        }
    }
}
