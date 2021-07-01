// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D12_DESCRIPTOR_RANGE1" /> struct.</summary>
    public static unsafe class D3D12_DESCRIPTOR_RANGE1Tests
    {
        /// <summary>Validates that the <see cref="D3D12_DESCRIPTOR_RANGE1" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D3D12_DESCRIPTOR_RANGE1>(), Is.EqualTo(sizeof(D3D12_DESCRIPTOR_RANGE1)));
        }

        /// <summary>Validates that the <see cref="D3D12_DESCRIPTOR_RANGE1" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3D12_DESCRIPTOR_RANGE1).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D3D12_DESCRIPTOR_RANGE1" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D3D12_DESCRIPTOR_RANGE1), Is.EqualTo(24));
        }
    }
}
