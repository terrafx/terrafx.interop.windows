// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/guiddef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
public static partial class WindowsTests
{
    /// <summary>Validates GUID equality helper bindings.</summary>
    [Test]
    public static void IsEqualGUIDTest()
    {
        Guid first = new(0x01234567, 0x89AB, 0xCDEF, 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF);
        Guid equal = first;
        Guid different = Guid.Empty;

        Assert.That(IsEqualGUID(first, equal), Is.EqualTo(1));
        Assert.That(IsEqualCATID(first, equal), Is.EqualTo(1));
        Assert.That(IsEqualCLSID(first, equal), Is.EqualTo(1));
        Assert.That(IsEqualFMTID(first, equal), Is.EqualTo(1));
        Assert.That(IsEqualIID(first, equal), Is.EqualTo(1));
        Assert.That(IsEqualGUID(first, different), Is.EqualTo(0));
        Assert.That(IsEqualCATID(first, different), Is.EqualTo(0));
    }
}
