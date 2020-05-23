// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWICBitmapFrameDecode" /> struct.</summary>
    public static class IWICBitmapFrameDecodeTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICBitmapFrameDecode" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWICBitmapFrameDecode).GUID, Is.EqualTo(IID_IWICBitmapFrameDecode));
        }

        /// <summary>Validates that the layout of the <see cref="IWICBitmapFrameDecode" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWICBitmapFrameDecode).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IWICBitmapFrameDecode" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IWICBitmapFrameDecode>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IWICBitmapFrameDecode>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IWICBitmapFrameDecode.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IWICBitmapFrameDecode" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IWICBitmapFrameDecode.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IWICBitmapFrameDecode" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IWICBitmapFrameDecode.Vtbl>(), Is.EqualTo(88));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IWICBitmapFrameDecode.Vtbl>(), Is.EqualTo(44));
                }
            }
        }
    }
}
