// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DXGI_JPEG_DC_HUFFMAN_TABLE" /> struct.</summary>
    public static class DXGI_JPEG_DC_HUFFMAN_TABLETests
    {
        /// <summary>Validates that the layout of the <see cref="DXGI_JPEG_DC_HUFFMAN_TABLE" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DXGI_JPEG_DC_HUFFMAN_TABLE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="DXGI_JPEG_DC_HUFFMAN_TABLE" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<DXGI_JPEG_DC_HUFFMAN_TABLE>(), Is.EqualTo(24));
        }
    }
}
