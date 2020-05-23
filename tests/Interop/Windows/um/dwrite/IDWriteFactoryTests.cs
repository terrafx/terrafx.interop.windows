// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDWriteFactory" /> struct.</summary>
    public static class IDWriteFactoryTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDWriteFactory" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDWriteFactory).GUID, Is.EqualTo(IID_IDWriteFactory));
        }

        /// <summary>Validates that the layout of the <see cref="IDWriteFactory" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDWriteFactory).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDWriteFactory" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDWriteFactory>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDWriteFactory>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDWriteFactory.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDWriteFactory" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDWriteFactory.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDWriteFactory" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDWriteFactory.Vtbl>(), Is.EqualTo(192));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDWriteFactory.Vtbl>(), Is.EqualTo(96));
                }
            }
        }
    }
}
