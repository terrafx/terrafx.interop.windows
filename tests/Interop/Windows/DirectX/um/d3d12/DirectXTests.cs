// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.DirectX.DirectX;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="DirectX" /> class.</summary>
public static unsafe partial class DirectXTests
{
    /// <summary>Validates that the value of the <see cref="D3D12ExperimentalShaderModels" /> property is correct.</summary>
    [Test]
    public static void D3D12ExperimentalShaderModelsTest()
    {
        Assert.That(D3D12ExperimentalShaderModels, Is.EqualTo(new Guid(0x76f5573e, 0xf13a, 0x40f5, 0xb2, 0x97, 0x81, 0xce, 0x9e, 0x18, 0x93, 0x3f)));
    }

    /// <summary>Validates that the value of the <see cref="D3D12TiledResourceTier4" /> property is correct.</summary>
    [Test]
    public static void D3D12TiledResourceTier4Test()
    {
        Assert.That(D3D12TiledResourceTier4, Is.EqualTo(new Guid(0xc9c4725f, 0xa81a, 0x4f56, 0x8c, 0x5b, 0xc5, 0x10, 0x39, 0xd6, 0x94, 0xfb)));
    }

    /// <summary>Validates that the value of the <see cref="D3D12MetaCommand" /> property is correct.</summary>
    [Test]
    public static void D3D12MetaCommandTest()
    {
        Assert.That(D3D12MetaCommand, Is.EqualTo(new Guid(0xc734c97e, 0x8077, 0x48c8, 0x9f, 0xdc, 0xd9, 0xd1, 0xdd, 0x31, 0xdd, 0x77)));
    }
}
