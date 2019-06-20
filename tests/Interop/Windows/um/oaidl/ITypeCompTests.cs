// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ITypeComp" /> struct.</summary>
    public static class ITypeCompTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ITypeComp" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ITypeComp).GUID, Is.EqualTo(IID_ITypeComp));
        }

        /// <summary>Validates that the layout of the <see cref="ITypeComp" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ITypeComp).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="ITypeComp" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<ITypeComp>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<ITypeComp>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="ITypeComp.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="ITypeComp" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(ITypeComp.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="ITypeComp" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<ITypeComp.Vtbl>(), Is.EqualTo(40));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<ITypeComp.Vtbl>(), Is.EqualTo(20));
                }
            }
        }
    }
}
