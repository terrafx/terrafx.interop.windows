// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGISwapChain" /> struct.</summary>
    public static class IDXGISwapChainTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGISwapChain" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDXGISwapChain).GUID, Is.EqualTo(IID_IDXGISwapChain));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGISwapChain" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGISwapChain).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGISwapChain" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGISwapChain>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGISwapChain>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGISwapChain.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGISwapChain" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGISwapChain.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGISwapChain" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGISwapChain.Vtbl>(), Is.EqualTo(144));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGISwapChain.Vtbl>(), Is.EqualTo(72));
                }
            }
        }
    }
}
