// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TVDISPINFOEXA" /> struct.</summary>
    public static unsafe class TVDISPINFOEXATests
    {
        /// <summary>Validates that the <see cref="TVDISPINFOEXA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TVDISPINFOEXA>(), Is.EqualTo(sizeof(TVDISPINFOEXA)));
        }

        /// <summary>Validates that the <see cref="TVDISPINFOEXA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TVDISPINFOEXA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TVDISPINFOEXA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(TVDISPINFOEXA), Is.EqualTo(104));
            }
            else
            {
                Assert.That(sizeof(TVDISPINFOEXA), Is.EqualTo(72));
            }
        }
    }
}
