// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dshadercacheregistration.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IID" /> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref="IID_ID3DShaderCacheInstallerClient" /> property is correct.</summary>
    [Test]
    public static void IID_ID3DShaderCacheInstallerClientTest()
    {
        Assert.That(IID_ID3DShaderCacheInstallerClient, Is.EqualTo(new Guid(0xa16ee930, 0xd9f6, 0x4222, 0xa5, 0x14, 0x24, 0x44, 0x73, 0xe5, 0xd2, 0x66)));
    }

    /// <summary>Validates that the value of the <see cref="IID_ID3DShaderCacheComponent" /> property is correct.</summary>
    [Test]
    public static void IID_ID3DShaderCacheComponentTest()
    {
        Assert.That(IID_ID3DShaderCacheComponent, Is.EqualTo(new Guid(0xeed1bf00, 0xf5c7, 0x4cf7, 0x88, 0x5c, 0xd0, 0xf9, 0xc0, 0xcb, 0x48, 0x28)));
    }

    /// <summary>Validates that the value of the <see cref="IID_ID3DShaderCacheApplication" /> property is correct.</summary>
    [Test]
    public static void IID_ID3DShaderCacheApplicationTest()
    {
        Assert.That(IID_ID3DShaderCacheApplication, Is.EqualTo(new Guid(0xfc688ee2, 0x1b35, 0x4913, 0x93, 0xbe, 0x1c, 0xa3, 0xfa, 0x7d, 0xf3, 0x9e)));
    }

    /// <summary>Validates that the value of the <see cref="IID_ID3DShaderCacheInstaller" /> property is correct.</summary>
    [Test]
    public static void IID_ID3DShaderCacheInstallerTest()
    {
        Assert.That(IID_ID3DShaderCacheInstaller, Is.EqualTo(new Guid(0xbbe30de1, 0x6318, 0x4526, 0xae, 0x17, 0x77, 0x66, 0x93, 0x19, 0x1b, 0xb4)));
    }

    /// <summary>Validates that the value of the <see cref="IID_ID3DShaderCacheExplorer" /> property is correct.</summary>
    [Test]
    public static void IID_ID3DShaderCacheExplorerTest()
    {
        Assert.That(IID_ID3DShaderCacheExplorer, Is.EqualTo(new Guid(0x90432322, 0x32f5, 0x487f, 0x92, 0x64, 0xe9, 0x39, 0x0f, 0xa5, 0x8b, 0x2a)));
    }

    /// <summary>Validates that the value of the <see cref="IID_ID3DShaderCacheInstallerFactory" /> property is correct.</summary>
    [Test]
    public static void IID_ID3DShaderCacheInstallerFactoryTest()
    {
        Assert.That(IID_ID3DShaderCacheInstallerFactory, Is.EqualTo(new Guid(0x09b2dfe4, 0x840f, 0x401a, 0x80, 0x4c, 0x0d, 0xd8, 0xaa, 0xdc, 0x9e, 0x9f)));
    }
}
