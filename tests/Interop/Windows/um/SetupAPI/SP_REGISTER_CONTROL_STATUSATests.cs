// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SP_REGISTER_CONTROL_STATUSA" /> struct.</summary>
    public static unsafe class SP_REGISTER_CONTROL_STATUSATests
    {
        /// <summary>Validates that the <see cref="SP_REGISTER_CONTROL_STATUSA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SP_REGISTER_CONTROL_STATUSA>(), Is.EqualTo(sizeof(SP_REGISTER_CONTROL_STATUSA)));
        }

        /// <summary>Validates that the <see cref="SP_REGISTER_CONTROL_STATUSA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SP_REGISTER_CONTROL_STATUSA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SP_REGISTER_CONTROL_STATUSA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SP_REGISTER_CONTROL_STATUSA), Is.EqualTo(20));
            }
            else
            {
                Assert.That(sizeof(SP_REGISTER_CONTROL_STATUSA), Is.EqualTo(16));
            }
        }
    }
}
