// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IEnumString" /> struct.</summary>
    public static class IEnumStringTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IEnumString" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IEnumString).GUID, Is.EqualTo(IID_IEnumString));
        }

        /// <summary>Validates that the layout of the <see cref="IEnumString" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IEnumString).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IEnumString" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IEnumString>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IEnumString>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IEnumString.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IEnumString" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IEnumString.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IEnumString" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IEnumString.Vtbl>(), Is.EqualTo(56));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IEnumString.Vtbl>(), Is.EqualTo(28));
                }
            }
        }
    }
}
