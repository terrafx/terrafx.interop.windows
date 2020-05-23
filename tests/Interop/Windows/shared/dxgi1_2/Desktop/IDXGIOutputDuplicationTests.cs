// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.Desktop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIOutputDuplication" /> struct.</summary>
    public static class IDXGIOutputDuplicationTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIOutputDuplication" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDXGIOutputDuplication).GUID, Is.EqualTo(IID_IDXGIOutputDuplication));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGIOutputDuplication" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIOutputDuplication).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGIOutputDuplication" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGIOutputDuplication>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGIOutputDuplication>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGIOutputDuplication.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGIOutputDuplication" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGIOutputDuplication.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGIOutputDuplication" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGIOutputDuplication.Vtbl>(), Is.EqualTo(120));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGIOutputDuplication.Vtbl>(), Is.EqualTo(60));
                }
            }
        }
    }
}
