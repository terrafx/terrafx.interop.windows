// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="FLOATING_SAVE_AREA" /> struct.</summary>
    public static unsafe partial class FLOATING_SAVE_AREATests
    {
        /// <summary>Validates that the <see cref="FLOATING_SAVE_AREA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<FLOATING_SAVE_AREA>(), Is.EqualTo(sizeof(FLOATING_SAVE_AREA)));
        }

        /// <summary>Validates that the <see cref="FLOATING_SAVE_AREA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(FLOATING_SAVE_AREA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="FLOATING_SAVE_AREA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(FLOATING_SAVE_AREA), Is.EqualTo(112));
        }
    }
}
