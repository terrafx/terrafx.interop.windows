// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/microsoft/DirectXShaderCompiler/blob/main/projects/dxilconv/include/DxbcConverter.h
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDxbcConverter" /> struct.</summary>
public static unsafe partial class IDxbcConverterTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDxbcConverter" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDxbcConverter).GUID, Is.EqualTo(IID_IDxbcConverter));
    }
}
