// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="RTL_SRWLOCK" /> struct.</summary>
    public static unsafe class RTL_SRWLOCKTests
    {
        /// <summary>Validates that the <see cref="RTL_SRWLOCK" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<RTL_SRWLOCK>(), Is.EqualTo(sizeof(RTL_SRWLOCK)));
        }

        /// <summary>Validates that the <see cref="RTL_SRWLOCK" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(RTL_SRWLOCK).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="RTL_SRWLOCK" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(RTL_SRWLOCK), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(RTL_SRWLOCK), Is.EqualTo(4));
            }
        }
    }
}
