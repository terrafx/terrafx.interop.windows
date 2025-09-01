// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="ID3D12ProtectedResourceSession" /> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class ID3D12ProtectedResourceSessionTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3D12ProtectedResourceSession" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID3D12ProtectedResourceSession).GUID, Is.EqualTo(IID_ID3D12ProtectedResourceSession));
    }
}
