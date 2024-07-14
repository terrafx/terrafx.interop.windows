// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDMLCompiledOperator" /> struct.</summary>
public static unsafe partial class IDMLCompiledOperatorTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDMLCompiledOperator" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDMLCompiledOperator).GUID, Is.EqualTo(IID_IDMLCompiledOperator));
    }
}
