// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.WinCodec;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWICColorTransform" /> struct.</summary>
    public static class IWICColorTransformTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICColorTransform" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWICColorTransform).GUID, Is.EqualTo(IID_IWICColorTransform));
        }

        /// <summary>Validates that the layout of the <see cref="IWICColorTransform" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWICColorTransform).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IWICColorTransform" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IWICColorTransform>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IWICColorTransform>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IWICColorTransform.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IWICColorTransform" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IWICColorTransform.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IWICColorTransform" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IWICColorTransform.Vtbl>(), Is.EqualTo(72));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IWICColorTransform.Vtbl>(), Is.EqualTo(36));
                }
            }
        }
    }
}
