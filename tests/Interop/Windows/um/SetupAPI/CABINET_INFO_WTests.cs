// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CABINET_INFO_W" /> struct.</summary>
    public static unsafe class CABINET_INFO_WTests
    {
        /// <summary>Validates that the <see cref="CABINET_INFO_W" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CABINET_INFO_W>(), Is.EqualTo(sizeof(CABINET_INFO_W)));
        }

        /// <summary>Validates that the <see cref="CABINET_INFO_W" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CABINET_INFO_W).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CABINET_INFO_W" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CABINET_INFO_W), Is.EqualTo(28));
            }
            else
            {
                Assert.That(sizeof(CABINET_INFO_W), Is.EqualTo(16));
            }
        }
    }
}
