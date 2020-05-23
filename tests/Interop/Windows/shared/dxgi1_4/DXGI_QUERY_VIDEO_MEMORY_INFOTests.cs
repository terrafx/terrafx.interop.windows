// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DXGI_QUERY_VIDEO_MEMORY_INFO" /> struct.</summary>
    public static class DXGI_QUERY_VIDEO_MEMORY_INFOTests
    {
        /// <summary>Validates that the layout of the <see cref="DXGI_QUERY_VIDEO_MEMORY_INFO" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DXGI_QUERY_VIDEO_MEMORY_INFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="DXGI_QUERY_VIDEO_MEMORY_INFO" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<DXGI_QUERY_VIDEO_MEMORY_INFO>(), Is.EqualTo(32));
        }
    }
}
