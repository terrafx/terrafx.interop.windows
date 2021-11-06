// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MINIDUMP_CALLBACK_OUTPUT" /> struct.</summary>
    public static unsafe partial class MINIDUMP_CALLBACK_OUTPUTTests
    {
        /// <summary>Validates that the <see cref="MINIDUMP_CALLBACK_OUTPUT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MINIDUMP_CALLBACK_OUTPUT>(), Is.EqualTo(sizeof(MINIDUMP_CALLBACK_OUTPUT)));
        }

        /// <summary>Validates that the <see cref="MINIDUMP_CALLBACK_OUTPUT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MINIDUMP_CALLBACK_OUTPUT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MINIDUMP_CALLBACK_OUTPUT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(MINIDUMP_CALLBACK_OUTPUT), Is.EqualTo(56));
            }
            else
            {
                Assert.That(sizeof(MINIDUMP_CALLBACK_OUTPUT), Is.EqualTo(52));
            }
        }
    }
}
