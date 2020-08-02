// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="STORAGE_TEMPERATURE_DATA_DESCRIPTOR" />struct.</summary>
    public static unsafe class STORAGE_TEMPERATURE_DATA_DESCRIPTORTests
    {
        /// <summary>Validates that the <see cref="STORAGE_TEMPERATURE_DATA_DESCRIPTOR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<STORAGE_TEMPERATURE_DATA_DESCRIPTOR>(), Is.EqualTo(sizeof(STORAGE_TEMPERATURE_DATA_DESCRIPTOR)));
        }

        /// <summary>Validates that the <see cref="STORAGE_TEMPERATURE_DATA_DESCRIPTOR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(STORAGE_TEMPERATURE_DATA_DESCRIPTOR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="STORAGE_TEMPERATURE_DATA_DESCRIPTOR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(STORAGE_TEMPERATURE_DATA_DESCRIPTOR), Is.EqualTo(40));
        }
    }
}
