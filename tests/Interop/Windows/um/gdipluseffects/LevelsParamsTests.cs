// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="LevelsParams" /> struct.</summary>
    public static unsafe partial class LevelsParamsTests
    {
        /// <summary>Validates that the <see cref="LevelsParams" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<LevelsParams>(), Is.EqualTo(sizeof(LevelsParams)));
        }

        /// <summary>Validates that the <see cref="LevelsParams" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(LevelsParams).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="LevelsParams" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(LevelsParams), Is.EqualTo(12));
        }
    }
}
