// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D3D11_DEPTH_STENCIL_DESC;
using static TerraFX.Interop.D3D11_DEPTH_WRITE_MASK;
using static TerraFX.Interop.D3D11_COMPARISON_FUNC;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D11_DEPTH_STENCIL_DESC" /> struct.</summary>
    public static unsafe class D3D11_DEPTH_STENCIL_DESCTests
    {
        /// <summary>Validates that the <see cref="D3D11_DEPTH_STENCIL_DESC" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D3D11_DEPTH_STENCIL_DESC>(), Is.EqualTo(sizeof(D3D11_DEPTH_STENCIL_DESC)));
        }

        /// <summary>Validates that the <see cref="D3D11_DEPTH_STENCIL_DESC" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3D11_DEPTH_STENCIL_DESC).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D3D11_DEPTH_STENCIL_DESC" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D3D11_DEPTH_STENCIL_DESC), Is.EqualTo(52));
        }

        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.DepthEnable, Is.EqualTo(TRUE));
            Assert.That(DEFAULT.DepthWriteMask, Is.EqualTo(D3D11_DEPTH_WRITE_MASK_ALL));
            Assert.That(DEFAULT.DepthFunc, Is.EqualTo(D3D11_COMPARISON_LESS));
            Assert.That(DEFAULT.StencilEnable, Is.EqualTo(FALSE));
            Assert.That(DEFAULT.StencilReadMask, Is.EqualTo((byte)D3D12_DEFAULT_STENCIL_READ_MASK));
            Assert.That(DEFAULT.StencilWriteMask, Is.EqualTo((byte)D3D12_DEFAULT_STENCIL_WRITE_MASK));
            Assert.That(DEFAULT.FrontFace, Is.EqualTo(D3D11_DEPTH_STENCILOP_DESC.DEFAULT));
            Assert.That(DEFAULT.BackFace, Is.EqualTo(D3D11_DEPTH_STENCILOP_DESC.DEFAULT));
        }
    }
}
