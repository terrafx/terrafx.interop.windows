// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.WinCodec;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWICDdsEncoder" /> struct.</summary>
    public static class IWICDdsEncoderTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICDdsEncoder" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWICDdsEncoder).GUID, Is.EqualTo(IID_IWICDdsEncoder));
        }

        /// <summary>Validates that the layout of the <see cref="IWICDdsEncoder" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWICDdsEncoder).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IWICDdsEncoder" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IWICDdsEncoder>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IWICDdsEncoder>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IWICDdsEncoder.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IWICDdsEncoder" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IWICDdsEncoder.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IWICDdsEncoder" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IWICDdsEncoder.Vtbl>(), Is.EqualTo(48));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IWICDdsEncoder.Vtbl>(), Is.EqualTo(24));
                }
            }
        }
    }
}
