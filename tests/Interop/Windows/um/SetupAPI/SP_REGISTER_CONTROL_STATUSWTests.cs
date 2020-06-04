// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SP_REGISTER_CONTROL_STATUSW" /> struct.</summary>
    public static unsafe class SP_REGISTER_CONTROL_STATUSWTests
    {
        /// <summary>Validates that the <see cref="SP_REGISTER_CONTROL_STATUSW" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SP_REGISTER_CONTROL_STATUSW>(), Is.EqualTo(sizeof(SP_REGISTER_CONTROL_STATUSW)));
        }

        /// <summary>Validates that the <see cref="SP_REGISTER_CONTROL_STATUSW" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SP_REGISTER_CONTROL_STATUSW).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SP_REGISTER_CONTROL_STATUSW" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SP_REGISTER_CONTROL_STATUSW), Is.EqualTo(20));
            }
            else
            {
                Assert.That(sizeof(SP_REGISTER_CONTROL_STATUSW), Is.EqualTo(16));
            }
        }
    }
}
