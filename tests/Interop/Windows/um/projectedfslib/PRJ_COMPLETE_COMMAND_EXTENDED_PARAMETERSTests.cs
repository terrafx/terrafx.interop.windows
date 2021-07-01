// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS" /> struct.</summary>
    public static unsafe class PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERSTests
    {
        /// <summary>Validates that the <see cref="PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS>(), Is.EqualTo(sizeof(PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS)));
        }

        /// <summary>Validates that the <see cref="PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS), Is.EqualTo(8));
            }
        }
    }
}
