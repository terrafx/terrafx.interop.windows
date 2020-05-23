// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGISwapChain3" /> struct.</summary>
    public static class IDXGISwapChain3Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGISwapChain3" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDXGISwapChain3).GUID, Is.EqualTo(IID_IDXGISwapChain3));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGISwapChain3" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGISwapChain3).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGISwapChain3" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGISwapChain3>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGISwapChain3>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGISwapChain3.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGISwapChain3" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGISwapChain3.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGISwapChain3" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGISwapChain3.Vtbl>(), Is.EqualTo(320));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGISwapChain3.Vtbl>(), Is.EqualTo(160));
                }
            }
        }
    }
}
