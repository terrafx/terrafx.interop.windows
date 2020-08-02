// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MFCameraIntrinsic_PinholeCameraModel" />struct.</summary>
    public static unsafe class MFCameraIntrinsic_PinholeCameraModelTests
    {
        /// <summary>Validates that the <see cref="MFCameraIntrinsic_PinholeCameraModel" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MFCameraIntrinsic_PinholeCameraModel>(), Is.EqualTo(sizeof(MFCameraIntrinsic_PinholeCameraModel)));
        }

        /// <summary>Validates that the <see cref="MFCameraIntrinsic_PinholeCameraModel" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MFCameraIntrinsic_PinholeCameraModel).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MFCameraIntrinsic_PinholeCameraModel" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MFCameraIntrinsic_PinholeCameraModel), Is.EqualTo(16));
        }
    }
}
