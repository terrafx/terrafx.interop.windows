// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/microsoft/DirectXShaderCompiler/blob/main/projects/dxilconv/include/DxbcConverter.h
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="CLSID" /> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref="CLSID_DxbcConverter" /> property is correct.</summary>
    [Test]
    public static void CLSID_DxbcConverterTest()
    {
        Assert.That(CLSID_DxbcConverter, Is.EqualTo(new Guid(0x4900391e, 0xb752, 0x4edd, 0xa8, 0x85, 0x6f, 0xb7, 0x6e, 0x25, 0xad, 0xdb)));
    }
}
