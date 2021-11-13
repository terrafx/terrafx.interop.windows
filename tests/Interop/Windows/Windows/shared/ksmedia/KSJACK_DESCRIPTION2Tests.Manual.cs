// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ksmedia.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="KSJACK_DESCRIPTION2" /> struct.</summary>
    public static unsafe class KSJACK_DESCRIPTION2Tests
    {
        /// <summary>Validates that the <see cref="KSJACK_DESCRIPTION2" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<KSJACK_DESCRIPTION2>(), Is.EqualTo(sizeof(KSJACK_DESCRIPTION2)));
        }

        /// <summary>Validates that the <see cref="KSJACK_DESCRIPTION2" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(KSJACK_DESCRIPTION2).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="KSJACK_DESCRIPTION2" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(KSJACK_DESCRIPTION2), Is.EqualTo(8));
        }
    }
}
