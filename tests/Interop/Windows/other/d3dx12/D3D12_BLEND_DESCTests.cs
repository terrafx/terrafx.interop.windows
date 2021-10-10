// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in the microsoft/DirectX-Graphics-Samples tag v10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using NUnit.Framework;
using static TerraFX.Interop.D3D12_BLEND_DESC;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D12_BLEND_DESC" /> struct.</summary>
    public static unsafe partial class D3D12_BLEND_DESCTests
    {
        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.AlphaToCoverageEnable, Is.EqualTo(FALSE));
            Assert.That(DEFAULT.IndependentBlendEnable, Is.EqualTo(FALSE));
            Assert.That(DEFAULT.RenderTarget[0], Is.EqualTo(D3D12_RENDER_TARGET_BLEND_DESC.DEFAULT));
            Assert.That(DEFAULT.RenderTarget[1], Is.EqualTo(D3D12_RENDER_TARGET_BLEND_DESC.DEFAULT));
            Assert.That(DEFAULT.RenderTarget[2], Is.EqualTo(D3D12_RENDER_TARGET_BLEND_DESC.DEFAULT));
            Assert.That(DEFAULT.RenderTarget[3], Is.EqualTo(D3D12_RENDER_TARGET_BLEND_DESC.DEFAULT));
            Assert.That(DEFAULT.RenderTarget[4], Is.EqualTo(D3D12_RENDER_TARGET_BLEND_DESC.DEFAULT));
            Assert.That(DEFAULT.RenderTarget[5], Is.EqualTo(D3D12_RENDER_TARGET_BLEND_DESC.DEFAULT));
            Assert.That(DEFAULT.RenderTarget[6], Is.EqualTo(D3D12_RENDER_TARGET_BLEND_DESC.DEFAULT));
            Assert.That(DEFAULT.RenderTarget[7], Is.EqualTo(D3D12_RENDER_TARGET_BLEND_DESC.DEFAULT));
        }
    }
}
