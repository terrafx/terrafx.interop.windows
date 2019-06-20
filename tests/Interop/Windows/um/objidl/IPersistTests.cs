// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IPersist" /> struct.</summary>
    public static class IPersistTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IPersist" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IPersist).GUID, Is.EqualTo(IID_IPersist));
        }

        /// <summary>Validates that the layout of the <see cref="IPersist" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IPersist).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IPersist" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IPersist>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IPersist>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IPersist.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IPersist" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IPersist.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IPersist" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IPersist.Vtbl>(), Is.EqualTo(32));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IPersist.Vtbl>(), Is.EqualTo(16));
                }
            }
        }
    }
}
