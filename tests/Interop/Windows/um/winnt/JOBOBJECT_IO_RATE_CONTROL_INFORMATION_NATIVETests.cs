// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE" /> struct.</summary>
    public static unsafe class JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVETests
    {
        /// <summary>Validates that the <see cref="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE>(), Is.EqualTo(sizeof(JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE)));
        }

        /// <summary>Validates that the <see cref="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE), Is.EqualTo(40));
            }
        }
    }
}
