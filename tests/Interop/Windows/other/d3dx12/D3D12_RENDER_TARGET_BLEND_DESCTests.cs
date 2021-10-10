// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in the microsoft/DirectX-Graphics-Samples tag v10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using NUnit.Framework;
using static TerraFX.Interop.D3D12_BLEND;
using static TerraFX.Interop.D3D12_BLEND_OP;
using static TerraFX.Interop.D3D12_COLOR_WRITE_ENABLE;
using static TerraFX.Interop.D3D12_LOGIC_OP;
using static TerraFX.Interop.D3D12_RENDER_TARGET_BLEND_DESC;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D12_RENDER_TARGET_BLEND_DESC" /> struct.</summary>
    public static unsafe partial class D3D12_RENDER_TARGET_BLEND_DESCTests
    {
        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.BlendEnable, Is.EqualTo(FALSE));
            Assert.That(DEFAULT.LogicOpEnable, Is.EqualTo(FALSE));
            Assert.That(DEFAULT.SrcBlend, Is.EqualTo(D3D12_BLEND_ONE));
            Assert.That(DEFAULT.DestBlend, Is.EqualTo(D3D12_BLEND_ZERO));
            Assert.That(DEFAULT.BlendOp, Is.EqualTo(D3D12_BLEND_OP_ADD));
            Assert.That(DEFAULT.SrcBlendAlpha, Is.EqualTo(D3D12_BLEND_ONE));
            Assert.That(DEFAULT.DestBlendAlpha, Is.EqualTo(D3D12_BLEND_ZERO));
            Assert.That(DEFAULT.BlendOpAlpha, Is.EqualTo(D3D12_BLEND_OP_ADD));
            Assert.That(DEFAULT.LogicOp, Is.EqualTo(D3D12_LOGIC_OP_NOOP));
            Assert.That(DEFAULT.RenderTargetWriteMask, Is.EqualTo((byte)D3D12_COLOR_WRITE_ENABLE_ALL));
        }
    }
}
