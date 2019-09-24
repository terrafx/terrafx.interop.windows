// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.WinCodec;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWICBitmapEncoderInfo" /> struct.</summary>
    public static class IWICBitmapEncoderInfoTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICBitmapEncoderInfo" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWICBitmapEncoderInfo).GUID, Is.EqualTo(IID_IWICBitmapEncoderInfo));
        }

        /// <summary>Validates that the layout of the <see cref="IWICBitmapEncoderInfo" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWICBitmapEncoderInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IWICBitmapEncoderInfo" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IWICBitmapEncoderInfo>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IWICBitmapEncoderInfo>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IWICBitmapEncoderInfo.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IWICBitmapEncoderInfo" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IWICBitmapEncoderInfo.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IWICBitmapEncoderInfo" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IWICBitmapEncoderInfo.Vtbl>(), Is.EqualTo(192));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IWICBitmapEncoderInfo.Vtbl>(), Is.EqualTo(96));
                }
            }
        }
    }
}
