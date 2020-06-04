// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="RemBRUSH" /> struct.</summary>
    public static unsafe class RemBRUSHTests
    {
        /// <summary>Validates that the <see cref="RemBRUSH" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<RemBRUSH>(), Is.EqualTo(sizeof(RemBRUSH)));
        }

        /// <summary>Validates that the <see cref="RemBRUSH" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(RemBRUSH).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="RemBRUSH" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(RemBRUSH), Is.EqualTo(8));
        }
    }
}
