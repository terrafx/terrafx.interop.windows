// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.WinCodec;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWICFormatConverter" /> struct.</summary>
    public static class IWICFormatConverterTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICFormatConverter" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWICFormatConverter).GUID, Is.EqualTo(IID_IWICFormatConverter));
        }

        /// <summary>Validates that the layout of the <see cref="IWICFormatConverter" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWICFormatConverter).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IWICFormatConverter" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IWICFormatConverter>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IWICFormatConverter>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IWICFormatConverter.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IWICFormatConverter" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IWICFormatConverter.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IWICFormatConverter" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IWICFormatConverter.Vtbl>(), Is.EqualTo(80));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IWICFormatConverter.Vtbl>(), Is.EqualTo(40));
                }
            }
        }
    }
}
