// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IEnumSTATSTG" /> struct.</summary>
    public static class IEnumSTATSTGTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IEnumSTATSTG" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IEnumSTATSTG).GUID, Is.EqualTo(IID_IEnumSTATSTG));
        }

        /// <summary>Validates that the layout of the <see cref="IEnumSTATSTG" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IEnumSTATSTG).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IEnumSTATSTG" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IEnumSTATSTG>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IEnumSTATSTG>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IEnumSTATSTG.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IEnumSTATSTG" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IEnumSTATSTG.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IEnumSTATSTG" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IEnumSTATSTG.Vtbl>(), Is.EqualTo(56));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IEnumSTATSTG.Vtbl>(), Is.EqualTo(28));
                }
            }
        }
    }
}
