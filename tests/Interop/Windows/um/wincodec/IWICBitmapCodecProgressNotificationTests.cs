// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.WinCodec;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWICBitmapCodecProgressNotification" /> struct.</summary>
    public static class IWICBitmapCodecProgressNotificationTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICBitmapCodecProgressNotification" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWICBitmapCodecProgressNotification).GUID, Is.EqualTo(IID_IWICBitmapCodecProgressNotification));
        }

        /// <summary>Validates that the layout of the <see cref="IWICBitmapCodecProgressNotification" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWICBitmapCodecProgressNotification).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IWICBitmapCodecProgressNotification" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IWICBitmapCodecProgressNotification>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IWICBitmapCodecProgressNotification>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IWICBitmapCodecProgressNotification.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IWICBitmapCodecProgressNotification" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IWICBitmapCodecProgressNotification.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IWICBitmapCodecProgressNotification" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IWICBitmapCodecProgressNotification.Vtbl>(), Is.EqualTo(32));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IWICBitmapCodecProgressNotification.Vtbl>(), Is.EqualTo(16));
                }
            }
        }
    }
}
