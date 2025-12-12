// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12compiler.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IID" /> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref="IID_ID3D12CompilerFactoryChild" /> property is correct.</summary>
    [Test]
    public static void IID_ID3D12CompilerFactoryChildTest()
    {
        Assert.That(IID_ID3D12CompilerFactoryChild, Is.EqualTo(new Guid(0xe0d06420, 0x9f31, 0x47e8, 0xae, 0x9a, 0xdd, 0x2b, 0xa2, 0x5a, 0xc0, 0xbc)));
    }

    /// <summary>Validates that the value of the <see cref="IID_ID3D12CompilerCacheSession" /> property is correct.</summary>
    [Test]
    public static void IID_ID3D12CompilerCacheSessionTest()
    {
        Assert.That(IID_ID3D12CompilerCacheSession, Is.EqualTo(new Guid(0x5704e5e6, 0x054b, 0x4738, 0xb6, 0x61, 0x7b, 0x0d, 0x68, 0xd8, 0xdd, 0xe2)));
    }

    /// <summary>Validates that the value of the <see cref="IID_ID3D12CompilerStateObject" /> property is correct.</summary>
    [Test]
    public static void IID_ID3D12CompilerStateObjectTest()
    {
        Assert.That(IID_ID3D12CompilerStateObject, Is.EqualTo(new Guid(0x5981cca4, 0xe8ae, 0x44ca, 0x9b, 0x92, 0x4f, 0xa8, 0x6f, 0x5a, 0x3a, 0x3a)));
    }

    /// <summary>Validates that the value of the <see cref="IID_ID3D12Compiler" /> property is correct.</summary>
    [Test]
    public static void IID_ID3D12CompilerTest()
    {
        Assert.That(IID_ID3D12Compiler, Is.EqualTo(new Guid(0x8c403c12, 0x993b, 0x4583, 0x80, 0xf1, 0x68, 0x24, 0x13, 0x8f, 0xa6, 0x8e)));
    }

    /// <summary>Validates that the value of the <see cref="IID_ID3D12CompilerFactory" /> property is correct.</summary>
    [Test]
    public static void IID_ID3D12CompilerFactoryTest()
    {
        Assert.That(IID_ID3D12CompilerFactory, Is.EqualTo(new Guid(0xc1ee4b59, 0x3f59, 0x47a5, 0x9b, 0x4e, 0xa8, 0x55, 0xc8, 0x58, 0xa8, 0x78)));
    }
}
