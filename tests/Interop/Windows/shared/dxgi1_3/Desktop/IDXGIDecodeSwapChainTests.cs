// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.Desktop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIDecodeSwapChain" /> struct.</summary>
    public static class IDXGIDecodeSwapChainTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIDecodeSwapChain" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDXGIDecodeSwapChain).GUID, Is.EqualTo(IID_IDXGIDecodeSwapChain));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGIDecodeSwapChain" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIDecodeSwapChain).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGIDecodeSwapChain" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGIDecodeSwapChain>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGIDecodeSwapChain>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGIDecodeSwapChain.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGIDecodeSwapChain" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGIDecodeSwapChain.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGIDecodeSwapChain" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGIDecodeSwapChain.Vtbl>(), Is.EqualTo(96));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGIDecodeSwapChain.Vtbl>(), Is.EqualTo(48));
                }
            }
        }
    }
}
