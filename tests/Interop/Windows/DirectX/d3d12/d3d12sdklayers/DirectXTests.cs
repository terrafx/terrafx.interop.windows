// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.DirectX.DirectX;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="DirectX" /> class.</summary>
public static partial class DirectXTests
{
    /// <summary>Validates that the value of the <see cref="WKPDID_D3DAutoDebugObjectNameW" /> property is correct.</summary>
    [Test]
    public static void WKPDID_D3DAutoDebugObjectNameWTest()
    {
        Assert.That(WKPDID_D3DAutoDebugObjectNameW, Is.EqualTo(new Guid(0xd4902e36, 0x757a, 0x4942, 0x95, 0x94, 0xb6, 0x76, 0x9a, 0xfa, 0x43, 0xcd)));
    }
}
