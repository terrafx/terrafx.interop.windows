// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="ID3D12MetaCommand" /> struct.</summary>
public static unsafe partial class ID3D12MetaCommandTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3D12MetaCommand" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID3D12MetaCommand).GUID, Is.EqualTo(IID_ID3D12MetaCommand));
    }
}
