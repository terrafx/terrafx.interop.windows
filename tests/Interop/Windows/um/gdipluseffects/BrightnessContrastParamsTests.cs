// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="BrightnessContrastParams" /> struct.</summary>
    public static unsafe partial class BrightnessContrastParamsTests
    {
        /// <summary>Validates that the <see cref="BrightnessContrastParams" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<BrightnessContrastParams>(), Is.EqualTo(sizeof(BrightnessContrastParams)));
        }

        /// <summary>Validates that the <see cref="BrightnessContrastParams" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(BrightnessContrastParams).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="BrightnessContrastParams" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(BrightnessContrastParams), Is.EqualTo(8));
        }
    }
}
