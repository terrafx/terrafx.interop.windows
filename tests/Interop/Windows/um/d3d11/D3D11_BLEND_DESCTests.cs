// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D3D11_BLEND_DESC;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D11_BLEND_DESC" /> struct.</summary>
    public static unsafe class D3D11_BLEND_DESCTests
    {
        /// <summary>Validates that the <see cref="D3D11_BLEND_DESC" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D3D11_BLEND_DESC>(), Is.EqualTo(sizeof(D3D11_BLEND_DESC)));
        }

        /// <summary>Validates that the <see cref="D3D11_BLEND_DESC" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3D11_BLEND_DESC).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D3D11_BLEND_DESC" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D3D11_BLEND_DESC), Is.EqualTo(264));
        }

        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.AlphaToCoverageEnable, Is.EqualTo(FALSE));
            Assert.That(DEFAULT.IndependentBlendEnable, Is.EqualTo(FALSE));
            Assert.That(DEFAULT.RenderTarget[0], Is.EqualTo(D3D11_RENDER_TARGET_BLEND_DESC.DEFAULT));
            Assert.That(DEFAULT.RenderTarget[1], Is.EqualTo(D3D11_RENDER_TARGET_BLEND_DESC.DEFAULT));
            Assert.That(DEFAULT.RenderTarget[2], Is.EqualTo(D3D11_RENDER_TARGET_BLEND_DESC.DEFAULT));
            Assert.That(DEFAULT.RenderTarget[3], Is.EqualTo(D3D11_RENDER_TARGET_BLEND_DESC.DEFAULT));
            Assert.That(DEFAULT.RenderTarget[4], Is.EqualTo(D3D11_RENDER_TARGET_BLEND_DESC.DEFAULT));
            Assert.That(DEFAULT.RenderTarget[5], Is.EqualTo(D3D11_RENDER_TARGET_BLEND_DESC.DEFAULT));
            Assert.That(DEFAULT.RenderTarget[6], Is.EqualTo(D3D11_RENDER_TARGET_BLEND_DESC.DEFAULT));
            Assert.That(DEFAULT.RenderTarget[7], Is.EqualTo(D3D11_RENDER_TARGET_BLEND_DESC.DEFAULT));
        }
    }
}
