// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DXGI_HDR_METADATA_HDR10" /> struct.</summary>
    public static class DXGI_HDR_METADATA_HDR10Tests
    {
        /// <summary>Validates that the layout of the <see cref="DXGI_HDR_METADATA_HDR10" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DXGI_HDR_METADATA_HDR10).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="DXGI_HDR_METADATA_HDR10" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<DXGI_HDR_METADATA_HDR10>(), Is.EqualTo(28));
        }
    }
}
