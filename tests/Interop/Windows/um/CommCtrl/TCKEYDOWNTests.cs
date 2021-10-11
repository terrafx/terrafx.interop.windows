// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TCKEYDOWN" /> struct.</summary>
    public static unsafe partial class TCKEYDOWNTests
    {
        /// <summary>Validates that the <see cref="TCKEYDOWN" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TCKEYDOWN>(), Is.EqualTo(sizeof(TCKEYDOWN)));
        }

        /// <summary>Validates that the <see cref="TCKEYDOWN" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TCKEYDOWN).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TCKEYDOWN" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(TCKEYDOWN), Is.EqualTo(30));
            }
            else
            {
                Assert.That(sizeof(TCKEYDOWN), Is.EqualTo(18));
            }
        }
    }
}
