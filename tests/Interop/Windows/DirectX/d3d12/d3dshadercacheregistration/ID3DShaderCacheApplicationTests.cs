// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dshadercacheregistration.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="ID3DShaderCacheApplication" /> struct.</summary>
public static unsafe partial class ID3DShaderCacheApplicationTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3DShaderCacheApplication" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID3DShaderCacheApplication).GUID, Is.EqualTo(IID_ID3DShaderCacheApplication));
    }
}
