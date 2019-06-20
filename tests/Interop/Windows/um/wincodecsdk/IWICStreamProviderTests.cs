// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.WinCodec;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWICStreamProvider" /> struct.</summary>
    public static class IWICStreamProviderTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICStreamProvider" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWICStreamProvider).GUID, Is.EqualTo(IID_IWICStreamProvider));
        }

        /// <summary>Validates that the layout of the <see cref="IWICStreamProvider" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWICStreamProvider).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IWICStreamProvider" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IWICStreamProvider>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IWICStreamProvider>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IWICStreamProvider.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IWICStreamProvider" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IWICStreamProvider.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IWICStreamProvider" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IWICStreamProvider.Vtbl>(), Is.EqualTo(56));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IWICStreamProvider.Vtbl>(), Is.EqualTo(28));
                }
            }
        }
    }
}
