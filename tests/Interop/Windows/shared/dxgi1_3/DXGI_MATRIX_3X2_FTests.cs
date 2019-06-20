// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DXGI_MATRIX_3X2_F" /> struct.</summary>
    public static class DXGI_MATRIX_3X2_FTests
    {
        /// <summary>Validates that the layout of the <see cref="DXGI_MATRIX_3X2_F" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DXGI_MATRIX_3X2_F).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="DXGI_MATRIX_3X2_F" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<DXGI_MATRIX_3X2_F>(), Is.EqualTo(24));
        }
    }
}
