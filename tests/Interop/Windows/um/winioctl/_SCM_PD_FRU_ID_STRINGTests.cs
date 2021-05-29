// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="_SCM_PD_FRU_ID_STRING" /> struct.</summary>
    public static unsafe class _SCM_PD_FRU_ID_STRINGTests
    {
        /// <summary>Validates that the <see cref="_SCM_PD_FRU_ID_STRING" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<_SCM_PD_FRU_ID_STRING>(), Is.EqualTo(sizeof(_SCM_PD_FRU_ID_STRING)));
        }

        /// <summary>Validates that the <see cref="_SCM_PD_FRU_ID_STRING" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(_SCM_PD_FRU_ID_STRING).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="_SCM_PD_FRU_ID_STRING" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(_SCM_PD_FRU_ID_STRING), Is.EqualTo(16));
        }
    }
}
