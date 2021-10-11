// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SP_DEVINSTALL_PARAMS_A" /> struct.</summary>
    public static unsafe partial class SP_DEVINSTALL_PARAMS_ATests
    {
        /// <summary>Validates that the <see cref="SP_DEVINSTALL_PARAMS_A" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SP_DEVINSTALL_PARAMS_A>(), Is.EqualTo(sizeof(SP_DEVINSTALL_PARAMS_A)));
        }

        /// <summary>Validates that the <see cref="SP_DEVINSTALL_PARAMS_A" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SP_DEVINSTALL_PARAMS_A).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SP_DEVINSTALL_PARAMS_A" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SP_DEVINSTALL_PARAMS_A), Is.EqualTo(316));
            }
            else
            {
                Assert.That(sizeof(SP_DEVINSTALL_PARAMS_A), Is.EqualTo(296));
            }
        }
    }
}
