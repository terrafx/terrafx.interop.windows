// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.DirectX.D3D12;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="D3D12" /> class.</summary>
public static partial class D3D12Tests
{
    /// <summary>Validates that the value of the <see cref="D3D12_PROTECTED_RESOURCES_SESSION_HARDWARE_PROTECTED" /> property is correct.</summary>
    [Test]
    public static void D3D12_PROTECTED_RESOURCES_SESSION_HARDWARE_PROTECTEDTest()
    {
        Assert.That(D3D12_PROTECTED_RESOURCES_SESSION_HARDWARE_PROTECTED, Is.EqualTo(new Guid(0x62B0084E, 0xC70E, 0x4DAA, 0xA1, 0x09, 0x30, 0xFF, 0x8D, 0x5A, 0x04, 0x82)));
    }
}
