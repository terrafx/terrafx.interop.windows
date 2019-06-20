// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DXGI_PRESENT_PARAMETERS" /> struct.</summary>
    public static class DXGI_PRESENT_PARAMETERSTests
    {
        /// <summary>Validates that the layout of the <see cref="DXGI_PRESENT_PARAMETERS" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DXGI_PRESENT_PARAMETERS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="DXGI_PRESENT_PARAMETERS" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<DXGI_PRESENT_PARAMETERS>(), Is.EqualTo(32));
            }
            else
            {
                Assert.That(Marshal.SizeOf<DXGI_PRESENT_PARAMETERS>(), Is.EqualTo(16));
            }
        }
    }
}
