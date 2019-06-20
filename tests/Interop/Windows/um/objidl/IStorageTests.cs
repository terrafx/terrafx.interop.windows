// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IStorage" /> struct.</summary>
    public static class IStorageTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IStorage" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IStorage).GUID, Is.EqualTo(IID_IStorage));
        }

        /// <summary>Validates that the layout of the <see cref="IStorage" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IStorage).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IStorage" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IStorage>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IStorage>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IStorage.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IStorage" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IStorage.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IStorage" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IStorage.Vtbl>(), Is.EqualTo(144));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IStorage.Vtbl>(), Is.EqualTo(72));
                }
            }
        }
    }
}
