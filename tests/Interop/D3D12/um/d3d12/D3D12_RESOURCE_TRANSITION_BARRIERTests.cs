// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D12_RESOURCE_TRANSITION_BARRIER" /> struct.</summary>
    public static class D3D12_RESOURCE_TRANSITION_BARRIERTests
    {
        /// <summary>Validates that the layout of the <see cref="D3D12_RESOURCE_TRANSITION_BARRIER" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3D12_RESOURCE_TRANSITION_BARRIER).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="D3D12_RESOURCE_TRANSITION_BARRIER" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<D3D12_RESOURCE_TRANSITION_BARRIER>(), Is.EqualTo(24));
            }
            else
            {
                Assert.That(Marshal.SizeOf<D3D12_RESOURCE_TRANSITION_BARRIER>(), Is.EqualTo(16));
            }
        }
    }
}
