// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MF_FLOAT3" /> struct.</summary>
    public static unsafe class MF_FLOAT3Tests
    {
        /// <summary>Validates that the <see cref="MF_FLOAT3" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MF_FLOAT3>(), Is.EqualTo(sizeof(MF_FLOAT3)));
        }

        /// <summary>Validates that the <see cref="MF_FLOAT3" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MF_FLOAT3).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MF_FLOAT3" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MF_FLOAT3), Is.EqualTo(12));
        }
    }
}
