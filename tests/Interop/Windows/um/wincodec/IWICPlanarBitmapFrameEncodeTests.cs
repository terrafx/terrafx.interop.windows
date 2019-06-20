// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.WinCodec;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWICPlanarBitmapFrameEncode" /> struct.</summary>
    public static class IWICPlanarBitmapFrameEncodeTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICPlanarBitmapFrameEncode" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWICPlanarBitmapFrameEncode).GUID, Is.EqualTo(IID_IWICPlanarBitmapFrameEncode));
        }

        /// <summary>Validates that the layout of the <see cref="IWICPlanarBitmapFrameEncode" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWICPlanarBitmapFrameEncode).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IWICPlanarBitmapFrameEncode" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IWICPlanarBitmapFrameEncode>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IWICPlanarBitmapFrameEncode>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IWICPlanarBitmapFrameEncode.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IWICPlanarBitmapFrameEncode" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IWICPlanarBitmapFrameEncode.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IWICPlanarBitmapFrameEncode" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IWICPlanarBitmapFrameEncode.Vtbl>(), Is.EqualTo(40));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IWICPlanarBitmapFrameEncode.Vtbl>(), Is.EqualTo(20));
                }
            }
        }
    }
}
