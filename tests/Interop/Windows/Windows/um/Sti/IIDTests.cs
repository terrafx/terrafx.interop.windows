// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IID" /> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref="IID_IStillImageW" /> property is correct.</summary>
    [Test]
    public static void IID_IStillImageWTest()
    {
        Assert.That(IID_IStillImageW, Is.EqualTo(new Guid(0x641BD880, 0x2DC8, 0x11D0, 0x90, 0xEA, 0x00, 0xAA, 0x00, 0x60, 0xF8, 0x6C)));
    }

    /// <summary>Validates that the value of the <see cref="IID_IStiDevice" /> property is correct.</summary>
    [Test]
    public static void IID_IStiDeviceTest()
    {
        Assert.That(IID_IStiDevice, Is.EqualTo(new Guid(0x6CFA5A80, 0x2DC8, 0x11D0, 0x90, 0xEA, 0x00, 0xAA, 0x00, 0x60, 0xF8, 0x6C)));
    }
}
