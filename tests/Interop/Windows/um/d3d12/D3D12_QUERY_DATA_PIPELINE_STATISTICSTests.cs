// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D12_QUERY_DATA_PIPELINE_STATISTICS" /> struct.</summary>
    public static class D3D12_QUERY_DATA_PIPELINE_STATISTICSTests
    {
        /// <summary>Validates that the layout of the <see cref="D3D12_QUERY_DATA_PIPELINE_STATISTICS" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3D12_QUERY_DATA_PIPELINE_STATISTICS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="D3D12_QUERY_DATA_PIPELINE_STATISTICS" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<D3D12_QUERY_DATA_PIPELINE_STATISTICS>(), Is.EqualTo(88));
        }
    }
}
