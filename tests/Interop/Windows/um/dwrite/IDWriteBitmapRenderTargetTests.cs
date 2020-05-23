// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDWriteBitmapRenderTarget" /> struct.</summary>
    public static class IDWriteBitmapRenderTargetTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDWriteBitmapRenderTarget" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDWriteBitmapRenderTarget).GUID, Is.EqualTo(IID_IDWriteBitmapRenderTarget));
        }

        /// <summary>Validates that the layout of the <see cref="IDWriteBitmapRenderTarget" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDWriteBitmapRenderTarget).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDWriteBitmapRenderTarget" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDWriteBitmapRenderTarget>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDWriteBitmapRenderTarget>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDWriteBitmapRenderTarget.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDWriteBitmapRenderTarget" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDWriteBitmapRenderTarget.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDWriteBitmapRenderTarget" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDWriteBitmapRenderTarget.Vtbl>(), Is.EqualTo(88));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDWriteBitmapRenderTarget.Vtbl>(), Is.EqualTo(44));
                }
            }
        }
    }
}
