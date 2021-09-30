// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D3D11_COMPARISON_FUNC;
using static TerraFX.Interop.D3D11_DEPTH_STENCILOP_DESC;
using static TerraFX.Interop.D3D11_STENCIL_OP;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D11_DEPTH_STENCILOP_DESC" /> struct.</summary>
    public static unsafe class D3D11_DEPTH_STENCILOP_DESCTests
    {
        /// <summary>Validates that the <see cref="D3D11_DEPTH_STENCILOP_DESC" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D3D11_DEPTH_STENCILOP_DESC>(), Is.EqualTo(sizeof(D3D11_DEPTH_STENCILOP_DESC)));
        }

        /// <summary>Validates that the <see cref="D3D11_DEPTH_STENCILOP_DESC" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3D11_DEPTH_STENCILOP_DESC).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D3D11_DEPTH_STENCILOP_DESC" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D3D11_DEPTH_STENCILOP_DESC), Is.EqualTo(16));
        }

        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.StencilFailOp, Is.EqualTo(D3D11_STENCIL_OP_KEEP));
            Assert.That(DEFAULT.StencilDepthFailOp, Is.EqualTo(D3D11_STENCIL_OP_KEEP));
            Assert.That(DEFAULT.StencilPassOp, Is.EqualTo(D3D11_STENCIL_OP_KEEP));
            Assert.That(DEFAULT.StencilFunc, Is.EqualTo(D3D11_COMPARISON_ALWAYS));
        }
    }
}
