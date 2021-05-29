// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="XSTATE_CONTEXT" /> struct.</summary>
    public static unsafe class XSTATE_CONTEXTTests
    {
        /// <summary>Validates that the <see cref="XSTATE_CONTEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XSTATE_CONTEXT>(), Is.EqualTo(sizeof(XSTATE_CONTEXT)));
        }

        /// <summary>Validates that the <see cref="XSTATE_CONTEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(XSTATE_CONTEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="XSTATE_CONTEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(XSTATE_CONTEXT), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(XSTATE_CONTEXT), Is.EqualTo(32));
            }
        }
    }
}
