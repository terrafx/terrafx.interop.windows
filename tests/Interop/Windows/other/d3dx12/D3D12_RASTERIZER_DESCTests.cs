// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in the microsoft/DirectX-Graphics-Samples tag v10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using NUnit.Framework;
using static TerraFX.Interop.D3D12_CULL_MODE;
using static TerraFX.Interop.D3D12_FILL_MODE;
using static TerraFX.Interop.D3D12_CONSERVATIVE_RASTERIZATION_MODE;
using static TerraFX.Interop.D3D12_RASTERIZER_DESC;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D12_RASTERIZER_DESC" /> struct.</summary>
    public static unsafe partial class D3D12_RASTERIZER_DESCTests
    {
        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.FillMode, Is.EqualTo(D3D12_FILL_MODE_SOLID));
            Assert.That(DEFAULT.CullMode, Is.EqualTo(D3D12_CULL_MODE_BACK));
            Assert.That(DEFAULT.FrontCounterClockwise, Is.EqualTo(FALSE));
            Assert.That(DEFAULT.DepthBias, Is.EqualTo(D3D12_DEFAULT_DEPTH_BIAS));
            Assert.That(DEFAULT.DepthBiasClamp, Is.EqualTo(D3D12_DEFAULT_DEPTH_BIAS_CLAMP));
            Assert.That(DEFAULT.SlopeScaledDepthBias, Is.EqualTo(D3D12_DEFAULT_SLOPE_SCALED_DEPTH_BIAS));
            Assert.That(DEFAULT.DepthClipEnable, Is.EqualTo(TRUE));
            Assert.That(DEFAULT.MultisampleEnable, Is.EqualTo(FALSE));
            Assert.That(DEFAULT.AntialiasedLineEnable, Is.EqualTo(FALSE));
            Assert.That(DEFAULT.ForcedSampleCount, Is.EqualTo(0));
            Assert.That(DEFAULT.ConservativeRaster, Is.EqualTo(D3D12_CONSERVATIVE_RASTERIZATION_MODE_OFF));
        }
    }
}
