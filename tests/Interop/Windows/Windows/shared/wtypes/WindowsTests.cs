// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
public static unsafe partial class WindowsTests
{
    /// <summary>Validates clipboard data sizing and decimal initialization helpers.</summary>
    [Test]
    public static void WTypesHelpersTest()
    {
        CLIPDATA clipData = new() { cbSize = 24 };
        Assert.That(CBPCLIPDATA(clipData), Is.EqualTo((nuint)20));

        DECIMAL dec = default;
        dec.Hi32 = 1;
        dec.Lo64 = 2;
        dec.signscale = 3;
        DECIMAL_SETZERO(&dec);
        Assert.That(dec.Hi32, Is.EqualTo(0u));
        Assert.That(dec.Lo64, Is.EqualTo(0ul));
        Assert.That(dec.signscale, Is.EqualTo((ushort)0));
    }
}
