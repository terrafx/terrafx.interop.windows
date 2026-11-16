// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.GUID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="GUID" /> class.</summary>
public static partial class GUIDTests
{
    /// <summary>Validates that the value of the <see cref="GUID_DeviceArrivedLaunch" /> property is correct.</summary>
    [Test]
    public static void GUID_DeviceArrivedLaunchTest()
    {
        Assert.That(GUID_DeviceArrivedLaunch, Is.EqualTo(new Guid(0x740d9ee6, 0x70f1, 0x11d1, 0xad, 0x10, 0x0, 0xa0, 0x24, 0x38, 0xad, 0x48)));
    }

    /// <summary>Validates that the value of the <see cref="GUID_ScanImage" /> property is correct.</summary>
    [Test]
    public static void GUID_ScanImageTest()
    {
        Assert.That(GUID_ScanImage, Is.EqualTo(new Guid(0xa6c5a715, 0x8c6e, 0x11d2, 0x97, 0x7a, 0x0, 0x0, 0xf8, 0x7a, 0x92, 0x6f)));
    }

    /// <summary>Validates that the value of the <see cref="GUID_ScanPrintImage" /> property is correct.</summary>
    [Test]
    public static void GUID_ScanPrintImageTest()
    {
        Assert.That(GUID_ScanPrintImage, Is.EqualTo(new Guid(0xb441f425, 0x8c6e, 0x11d2, 0x97, 0x7a, 0x0, 0x0, 0xf8, 0x7a, 0x92, 0x6f)));
    }

    /// <summary>Validates that the value of the <see cref="GUID_ScanFaxImage" /> property is correct.</summary>
    [Test]
    public static void GUID_ScanFaxImageTest()
    {
        Assert.That(GUID_ScanFaxImage, Is.EqualTo(new Guid(0xc00eb793, 0x8c6e, 0x11d2, 0x97, 0x7a, 0x0, 0x0, 0xf8, 0x7a, 0x92, 0x6f)));
    }

    /// <summary>Validates that the value of the <see cref="GUID_STIUserDefined1" /> property is correct.</summary>
    [Test]
    public static void GUID_STIUserDefined1Test()
    {
        Assert.That(GUID_STIUserDefined1, Is.EqualTo(new Guid(0xc00eb795, 0x8c6e, 0x11d2, 0x97, 0x7a, 0x0, 0x0, 0xf8, 0x7a, 0x92, 0x6f)));
    }

    /// <summary>Validates that the value of the <see cref="GUID_STIUserDefined2" /> property is correct.</summary>
    [Test]
    public static void GUID_STIUserDefined2Test()
    {
        Assert.That(GUID_STIUserDefined2, Is.EqualTo(new Guid(0xc77ae9c5, 0x8c6e, 0x11d2, 0x97, 0x7a, 0x0, 0x0, 0xf8, 0x7a, 0x92, 0x6f)));
    }

    /// <summary>Validates that the value of the <see cref="GUID_STIUserDefined3" /> property is correct.</summary>
    [Test]
    public static void GUID_STIUserDefined3Test()
    {
        Assert.That(GUID_STIUserDefined3, Is.EqualTo(new Guid(0xc77ae9c6, 0x8c6e, 0x11d2, 0x97, 0x7a, 0x0, 0x0, 0xf8, 0x7a, 0x92, 0x6f)));
    }
}
