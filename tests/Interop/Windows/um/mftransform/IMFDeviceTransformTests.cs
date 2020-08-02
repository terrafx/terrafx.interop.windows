// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMFDeviceTransform" />struct.</summary>
    public static unsafe class IMFDeviceTransformTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFDeviceTransform" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IMFDeviceTransform).GUID, Is.EqualTo(IID_IMFDeviceTransform));
        }

        /// <summary>Validates that the <see cref="IMFDeviceTransform" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMFDeviceTransform>(), Is.EqualTo(sizeof(IMFDeviceTransform)));
        }

        /// <summary>Validates that the <see cref="IMFDeviceTransform" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMFDeviceTransform).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMFDeviceTransform" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IMFDeviceTransform), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IMFDeviceTransform), Is.EqualTo(4));
            }
        }
    }
}
