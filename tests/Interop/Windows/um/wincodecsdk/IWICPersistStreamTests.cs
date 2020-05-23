// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWICPersistStream" /> struct.</summary>
    public static class IWICPersistStreamTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICPersistStream" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWICPersistStream).GUID, Is.EqualTo(IID_IWICPersistStream));
        }

        /// <summary>Validates that the layout of the <see cref="IWICPersistStream" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWICPersistStream).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IWICPersistStream" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IWICPersistStream>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IWICPersistStream>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IWICPersistStream.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IWICPersistStream" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IWICPersistStream.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IWICPersistStream" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IWICPersistStream.Vtbl>(), Is.EqualTo(80));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IWICPersistStream.Vtbl>(), Is.EqualTo(40));
                }
            }
        }
    }
}
