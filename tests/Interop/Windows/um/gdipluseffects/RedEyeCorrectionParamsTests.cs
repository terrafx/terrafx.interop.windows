// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="RedEyeCorrectionParams" /> struct.</summary>
    public static unsafe partial class RedEyeCorrectionParamsTests
    {
        /// <summary>Validates that the <see cref="RedEyeCorrectionParams" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<RedEyeCorrectionParams>(), Is.EqualTo(sizeof(RedEyeCorrectionParams)));
        }

        /// <summary>Validates that the <see cref="RedEyeCorrectionParams" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(RedEyeCorrectionParams).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="RedEyeCorrectionParams" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(RedEyeCorrectionParams), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(RedEyeCorrectionParams), Is.EqualTo(8));
            }
        }
    }
}
