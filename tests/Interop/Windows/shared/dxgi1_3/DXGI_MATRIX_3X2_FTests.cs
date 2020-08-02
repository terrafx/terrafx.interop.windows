// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DXGI_MATRIX_3X2_F" />struct.</summary>
    public static unsafe class DXGI_MATRIX_3X2_FTests
    {
        /// <summary>Validates that the <see cref="DXGI_MATRIX_3X2_F" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DXGI_MATRIX_3X2_F>(), Is.EqualTo(sizeof(DXGI_MATRIX_3X2_F)));
        }

        /// <summary>Validates that the <see cref="DXGI_MATRIX_3X2_F" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DXGI_MATRIX_3X2_F).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DXGI_MATRIX_3X2_F" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DXGI_MATRIX_3X2_F), Is.EqualTo(24));
        }
    }
}
