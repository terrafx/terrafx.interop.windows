// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D3D11_CULL_MODE;
using static TerraFX.Interop.D3D11_FILL_MODE;
using static TerraFX.Interop.D3D11_RASTERIZER_DESC;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D11_RASTERIZER_DESC" /> struct.</summary>
    public static unsafe class D3D11_RASTERIZER_DESCTests
    {
        /// <summary>Validates that the <see cref="D3D11_RASTERIZER_DESC" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D3D11_RASTERIZER_DESC>(), Is.EqualTo(sizeof(D3D11_RASTERIZER_DESC)));
        }

        /// <summary>Validates that the <see cref="D3D11_RASTERIZER_DESC" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3D11_RASTERIZER_DESC).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D3D11_RASTERIZER_DESC" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D3D11_RASTERIZER_DESC), Is.EqualTo(40));
        }

        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.FillMode, Is.EqualTo(D3D11_FILL_SOLID));
            Assert.That(DEFAULT.CullMode, Is.EqualTo(D3D11_CULL_BACK));
            Assert.That(DEFAULT.FrontCounterClockwise, Is.EqualTo(FALSE));
            Assert.That(DEFAULT.DepthBias, Is.EqualTo(D3D11_DEFAULT_DEPTH_BIAS));
            Assert.That(DEFAULT.DepthBiasClamp, Is.EqualTo(D3D11_DEFAULT_DEPTH_BIAS_CLAMP));
            Assert.That(DEFAULT.SlopeScaledDepthBias, Is.EqualTo(D3D11_DEFAULT_SLOPE_SCALED_DEPTH_BIAS));
            Assert.That(DEFAULT.DepthClipEnable, Is.EqualTo(TRUE));
            Assert.That(DEFAULT.ScissorEnable, Is.EqualTo(FALSE));
            Assert.That(DEFAULT.MultisampleEnable, Is.EqualTo(FALSE));
            Assert.That(DEFAULT.AntialiasedLineEnable, Is.EqualTo(FALSE));
        }
    }
}
