// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidusage.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
public static partial class WindowsTests
{
    /// <summary>Validates that the button usage macro preserves the usage identifier.</summary>
    [Test]
    public static void HID_USAGE_BUTTON_IDTest()
    {
        Assert.That(HID_USAGE_BUTTON_ID(0x1234), Is.EqualTo((ushort)0x1234));
    }
}
