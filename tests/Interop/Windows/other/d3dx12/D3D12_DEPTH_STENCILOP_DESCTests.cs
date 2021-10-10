// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in the microsoft/DirectX-Graphics-Samples tag v10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using NUnit.Framework;
using static TerraFX.Interop.D3D12_COMPARISON_FUNC;
using static TerraFX.Interop.D3D12_DEPTH_STENCILOP_DESC;
using static TerraFX.Interop.D3D12_STENCIL_OP;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D12_DEPTH_STENCILOP_DESC" /> struct.</summary>
    public static unsafe partial class D3D12_DEPTH_STENCILOP_DESCTests
    {
        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.StencilFailOp, Is.EqualTo(D3D12_STENCIL_OP_KEEP));
            Assert.That(DEFAULT.StencilDepthFailOp, Is.EqualTo(D3D12_STENCIL_OP_KEEP));
            Assert.That(DEFAULT.StencilPassOp, Is.EqualTo(D3D12_STENCIL_OP_KEEP));
            Assert.That(DEFAULT.StencilFunc, Is.EqualTo(D3D12_COMPARISON_FUNC_ALWAYS));
        }
    }
}
