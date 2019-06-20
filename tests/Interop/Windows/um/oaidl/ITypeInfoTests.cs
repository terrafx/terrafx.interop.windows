// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ITypeInfo" /> struct.</summary>
    public static class ITypeInfoTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ITypeInfo" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ITypeInfo).GUID, Is.EqualTo(IID_ITypeInfo));
        }

        /// <summary>Validates that the layout of the <see cref="ITypeInfo" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ITypeInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="ITypeInfo" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<ITypeInfo>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<ITypeInfo>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="ITypeInfo.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="ITypeInfo" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(ITypeInfo.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="ITypeInfo" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<ITypeInfo.Vtbl>(), Is.EqualTo(176));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<ITypeInfo.Vtbl>(), Is.EqualTo(88));
                }
            }
        }
    }
}
