// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SP_ENABLECLASS_PARAMS" /> struct.</summary>
    public static unsafe class SP_ENABLECLASS_PARAMSTests
    {
        /// <summary>Validates that the <see cref="SP_ENABLECLASS_PARAMS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SP_ENABLECLASS_PARAMS>(), Is.EqualTo(sizeof(SP_ENABLECLASS_PARAMS)));
        }

        /// <summary>Validates that the <see cref="SP_ENABLECLASS_PARAMS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SP_ENABLECLASS_PARAMS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SP_ENABLECLASS_PARAMS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SP_ENABLECLASS_PARAMS), Is.EqualTo(28));
        }
    }
}
