// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWICImagingFactory" /> struct.</summary>
    public static class IWICImagingFactoryTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICImagingFactory" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWICImagingFactory).GUID, Is.EqualTo(IID_IWICImagingFactory));
        }

        /// <summary>Validates that the layout of the <see cref="IWICImagingFactory" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWICImagingFactory).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IWICImagingFactory" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IWICImagingFactory>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IWICImagingFactory>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IWICImagingFactory.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IWICImagingFactory" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IWICImagingFactory.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IWICImagingFactory" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IWICImagingFactory.Vtbl>(), Is.EqualTo(224));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IWICImagingFactory.Vtbl>(), Is.EqualTo(112));
                }
            }
        }
    }
}
