// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE" /> struct.</summary>
    public static unsafe partial class D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZETests
    {
        /// <summary>Validates that the <see cref="D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE>(), Is.EqualTo(sizeof(D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE)));
        }

        /// <summary>Validates that the <see cref="D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE), Is.EqualTo(72));
        }
    }
}
