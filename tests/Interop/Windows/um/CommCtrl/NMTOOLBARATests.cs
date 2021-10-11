// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="NMTOOLBARA" /> struct.</summary>
    public static unsafe partial class NMTOOLBARATests
    {
        /// <summary>Validates that the <see cref="NMTOOLBARA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<NMTOOLBARA>(), Is.EqualTo(sizeof(NMTOOLBARA)));
        }

        /// <summary>Validates that the <see cref="NMTOOLBARA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(NMTOOLBARA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="NMTOOLBARA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(NMTOOLBARA), Is.EqualTo(96));
            }
            else
            {
                Assert.That(sizeof(NMTOOLBARA), Is.EqualTo(60));
            }
        }
    }
}
