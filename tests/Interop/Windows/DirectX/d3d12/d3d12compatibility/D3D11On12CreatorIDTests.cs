// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12compatibility.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="D3D11On12CreatorID" /> struct.</summary>
public static unsafe partial class D3D11On12CreatorIDTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="D3D11On12CreatorID" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(D3D11On12CreatorID).GUID, Is.EqualTo(IID_D3D11On12CreatorID));
    }
}
