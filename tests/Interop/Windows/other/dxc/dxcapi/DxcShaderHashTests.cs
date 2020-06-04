// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/dxc/dxcapi.h in the microsoft/DirectXCompiler commit e0cde072b09b51506c0460697b2695d6cccca59d
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DxcShaderHash" /> struct.</summary>
    public static unsafe class DxcShaderHashTests
    {
        /// <summary>Validates that the <see cref="DxcShaderHash" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DxcShaderHash>(), Is.EqualTo(sizeof(DxcShaderHash)));
        }

        /// <summary>Validates that the <see cref="DxcShaderHash" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DxcShaderHash).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DxcShaderHash" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DxcShaderHash), Is.EqualTo(20));
        }
    }
}
