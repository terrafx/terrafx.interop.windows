// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MINIDUMP_THREAD_CALLBACK" /> struct.</summary>
    public static unsafe partial class MINIDUMP_THREAD_CALLBACKTests
    {
        /// <summary>Validates that the <see cref="MINIDUMP_THREAD_CALLBACK" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MINIDUMP_THREAD_CALLBACK>(), Is.EqualTo(sizeof(MINIDUMP_THREAD_CALLBACK)));
        }

        /// <summary>Validates that the <see cref="MINIDUMP_THREAD_CALLBACK" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MINIDUMP_THREAD_CALLBACK).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MINIDUMP_THREAD_CALLBACK" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(MINIDUMP_THREAD_CALLBACK), Is.EqualTo(1272));
            }
            else
            {
                Assert.That(sizeof(MINIDUMP_THREAD_CALLBACK), Is.EqualTo(1264));
            }
        }
    }
}
