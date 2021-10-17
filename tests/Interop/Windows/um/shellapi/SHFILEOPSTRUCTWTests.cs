// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SHFILEOPSTRUCTW" /> struct.</summary>
    public static unsafe partial class SHFILEOPSTRUCTWTests
    {
        /// <summary>Validates that the <see cref="SHFILEOPSTRUCTW" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SHFILEOPSTRUCTW>(), Is.EqualTo(sizeof(SHFILEOPSTRUCTW)));
        }

        /// <summary>Validates that the <see cref="SHFILEOPSTRUCTW" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SHFILEOPSTRUCTW).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SHFILEOPSTRUCTW" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SHFILEOPSTRUCTW), Is.EqualTo(50));
            }
            else
            {
                Assert.That(sizeof(SHFILEOPSTRUCTW), Is.EqualTo(30));
            }
        }
    }
}
