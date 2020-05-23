// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID3DInclude" /> struct.</summary>
    public static class ID3DIncludeTests
    {
        /// <summary>Validates that the layout of the <see cref="ID3DInclude" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID3DInclude).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="ID3DInclude" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<ID3DInclude>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<ID3DInclude>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="ID3DInclude.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="ID3DInclude" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(ID3DInclude.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="ID3DInclude" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<ID3DInclude.Vtbl>(), Is.EqualTo(16));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<ID3DInclude.Vtbl>(), Is.EqualTo(8));
                }
            }
        }
    }
}
