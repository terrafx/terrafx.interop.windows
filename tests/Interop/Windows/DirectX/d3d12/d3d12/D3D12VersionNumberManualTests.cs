// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using NUnit.Framework;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation for manually ported D3D12 version helpers.</summary>
public static class D3D12VersionNumberManualTests
{
    /// <summary>Validates that version components are masked and packed into a 64-bit value.</summary>
    [Test]
    public static void D3D12_MAKE_VERSION_NUMBERTest()
    {
        Assert.That(DirectX.D3D12_MAKE_VERSION_NUMBER(0x1_000C, 0x2_0008, 0x3_0001, 0x4_0000), Is.EqualTo(0x000C_0008_0001_0000UL));
    }
}
