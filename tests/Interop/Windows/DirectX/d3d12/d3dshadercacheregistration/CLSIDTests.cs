// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dshadercacheregistration.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="CLSID" /> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref="CLSID_D3DShaderCacheInstallerFactory" /> property is correct.</summary>
    [Test]
    public static void CLSID_D3DShaderCacheInstallerFactoryTest()
    {
        Assert.That(CLSID_D3DShaderCacheInstallerFactory, Is.EqualTo(new Guid(0x16195a0b, 0x607c, 0x41f1, 0xbf, 0x03, 0xc7, 0x69, 0x4d, 0x60, 0xa8, 0xd4)));
    }
}
