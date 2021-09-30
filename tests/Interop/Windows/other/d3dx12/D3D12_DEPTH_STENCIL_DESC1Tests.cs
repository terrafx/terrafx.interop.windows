// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in the microsoft/DirectX-Graphics-Samples tag v10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using NUnit.Framework;
using static TerraFX.Interop.D3D12_COMPARISON_FUNC;
using static TerraFX.Interop.D3D12_DEPTH_STENCIL_DESC1;
using static TerraFX.Interop.D3D12_DEPTH_WRITE_MASK;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D12_DEPTH_STENCIL_DESC1" /> struct.</summary>
    public static unsafe partial class D3D12_DEPTH_STENCIL_DESC1Tests
    {
        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.DepthEnable, Is.EqualTo(TRUE));
            Assert.That(DEFAULT.DepthWriteMask, Is.EqualTo(D3D12_DEPTH_WRITE_MASK_ALL));
            Assert.That(DEFAULT.DepthFunc, Is.EqualTo(D3D12_COMPARISON_FUNC_LESS));
            Assert.That(DEFAULT.StencilEnable, Is.EqualTo(FALSE));
            Assert.That(DEFAULT.StencilReadMask, Is.EqualTo((byte)D3D12_DEFAULT_STENCIL_READ_MASK));
            Assert.That(DEFAULT.StencilWriteMask, Is.EqualTo((byte)D3D12_DEFAULT_STENCIL_WRITE_MASK));
            Assert.That(DEFAULT.FrontFace, Is.EqualTo(D3D12_DEPTH_STENCILOP_DESC.DEFAULT));
            Assert.That(DEFAULT.BackFace, Is.EqualTo(D3D12_DEPTH_STENCILOP_DESC.DEFAULT));
            Assert.That(DEFAULT.DepthBoundsTestEnable, Is.EqualTo(FALSE));
        }
    }
}
