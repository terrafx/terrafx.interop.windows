// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DISPATCHER_CONTEXT_OTHER" /> struct.</summary>
    public static unsafe partial class DISPATCHER_CONTEXT_OTHERTests
    {
        /// <summary>Validates that the <see cref="DISPATCHER_CONTEXT_OTHER" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DISPATCHER_CONTEXT_OTHER>(), Is.EqualTo(sizeof(DISPATCHER_CONTEXT_OTHER)));
        }

        /// <summary>Validates that the <see cref="DISPATCHER_CONTEXT_OTHER" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DISPATCHER_CONTEXT_OTHER).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DISPATCHER_CONTEXT_OTHER" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(DISPATCHER_CONTEXT_OTHER), Is.EqualTo(80));
            }
            else
            {
                Assert.That(sizeof(DISPATCHER_CONTEXT_OTHER), Is.EqualTo(64));
            }
        }
    }
}
